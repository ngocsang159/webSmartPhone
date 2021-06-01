using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public class OrderService : GenericService<Order>, IOrderService
    {


        public ResponseDataAdmin<OrderView> GetListOrder(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;
            var data = db.Orders.Where(n => n.IsDelete == false).OrderByDescending(n => n.Id).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Orders.Where(n => n.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Orders.Where(n => (n.Id.ToString().Contains(search.ToLower())) && n.IsDelete == false).OrderByDescending(x => x.Id).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Orders.Where(n => n.Id.ToString().Contains(search.ToLower()) && n.IsDelete == false).Count();
            }
            List<OrderView> dataOV = new List<OrderView>();
            foreach (var item in data)
            {
                OrderView orderView = new OrderView();
                {
                    orderView.order = item;
                    orderView.admin = db.Accounts.Find(item.AdminId);
                    orderView.customer = db.Customers.Find(item.CustomerId);
                    orderView.orderStatus = db.OrderStatuses.Find(item.OrderStatusId);
                    List<DistrictView> datadv = new List<DistrictView>();
                    foreach (var item1 in db.Districts.ToList())
                    {
                        DistrictView dv = new DistrictView();
                        {
                            dv.district = item1;
                            dv.provinces = db.Provinces.Find(item1.ProvinceId);
                        }
                        datadv.Add(dv);
                    }
                    dataOV.Add(orderView);
                }
            }
            ResponseDataAdmin<OrderView> dataOrder = new ResponseDataAdmin<OrderView>();
            dataOrder.data = dataOV;
            dataOrder.pageNumber = pageNumber;
            dataOrder.pageSize = pageSize;
            dataOrder.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataOrder;
        }

        public OrderViewModel GetOrder(long Id)
        {
            OrderViewModel data = new OrderViewModel();
            data.order = db.Orders.Where(n => n.Id == Id).FirstOrDefault();
            data.district = db.Districts.Find(data.order.DistrictId);
            data.provinces = db.Provinces.Find(data.district.ProvinceId);
            return data;
        }
        public Order GetOrderById(long Id)
        {
            return db.Orders.Find(Id);
        }
        public bool InsertOrder(Order order)
        {
            if (order.Id == 0)
            {
                order.CreatedDate = DateTime.Now;
                order.IsDelete = false;
                db.Orders.Add(order);
                db.SaveChanges();
                var code = db.Orders.OrderByDescending(n => n.Id).FirstOrDefault();
                code.Code = "LH" + code.Id;
                db.SaveChanges();
                return true;
            }
            else
            {
                var od = db.Orders.Find(order.Id);
                if (od.AdminId == 0)
                {
                    od.AdminId = order.AdminId;

                }
                od.CustomerId = order.CustomerId;
                od.OrderStatusId = order.OrderStatusId;
                od.FullName = order.FullName;
                od.Address = order.Address;
                od.DistrictId = order.DistrictId;
                od.Email = order.Email;
                od.Phone = order.Phone;
                od.Note = order.Note;
                od.UpdatedBy = "";
                od.UpdatedDate = DateTime.Now;
                od.Status = order.Status;
                db.SaveChanges();
                return true;
            }
        }
        public bool DeleteOrder(long Id)
        {
            var obj = db.Orders.Find(Id);
            obj.IsDelete = true;
            db.SaveChanges();
            return true; ;
        }

        public List<Account> GetListAdmin()
        {
            return db.Accounts.Where(n => n.Status == 1 && n.IsAdmin == 1 && n.IsDelete == false).ToList();
        }

        public List<Customer> GetListCustomer()
        {
            return db.Customers.Where(n => n.IsDelete == false).ToList();
        }
        public List<OrderStatus> GetListStatusOrder()
        {
            return db.OrderStatuses.ToList();
        }

        /// <summary>
        /// OrderDetail
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<OrderDetailView> GetListOrderDetail(long OrderId)
        {
            var data = db.OrderDetails.Where(n => n.OrderId == OrderId).ToList();
            List<OrderDetailView> dataODV = new List<OrderDetailView>();
            foreach (var item in data)
            {
                OrderDetailView ODV = new OrderDetailView()
                {
                    orderDetail = item,
                    product = db.Products.Find(item.ProductId),
                    color = db.MasterData.Find(item.ColorId)
                };
                dataODV.Add(ODV);
            }
            return dataODV;

        }

        public OrderDetailView GetOrderDetail(long Id)
        {
            OrderDetailView data = new OrderDetailView();
            data.orderDetail = db.OrderDetails.Where(n => n.Id == Id).FirstOrDefault();
            data.color = db.MasterData.Find(data.orderDetail.ColorId);
            data.product = db.Products.Find(data.orderDetail.ProductId);
            return data;
        }

        public bool InsertOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.Id == 0)
            {
                orderDetail.TotalPrice = (orderDetail.Price * orderDetail.Quantity) + orderDetail.PriceShip;
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                return true;
            }
            else
            {
                var od = db.OrderDetails.Find(orderDetail.Id);
                od.ProductId = orderDetail.ProductId;
                od.ColorId = orderDetail.ColorId;
                od.Price = orderDetail.Price;
                od.PriceShip = orderDetail.PriceShip;
                od.Quantity = orderDetail.Quantity;
                od.TotalPrice = (od.Price * od.Quantity) + od.PriceShip;
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteOrderDetailById(long Id)
        {
            var data = db.OrderDetails.Find(Id);
            db.OrderDetails.Remove(data);
            db.SaveChanges();
            return true;
        }

        public OrderDetail GetOrderDetailById(long Id)
        {
            return db.OrderDetails.Where(n => n.Id == Id).FirstOrDefault();
        }

        public List<MasterDatum> GetListItemColor(long ParentId)
        {
            return db.MasterData.Where(n => n.ParentId == ParentId).ToList();
        }

        public List<MasterDatum> GetListProductColor(long ProductId)
        {
            List<MasterDatum> data = new List<MasterDatum>();
            var color = db.ProductColors.Where(n => n.ProductId == ProductId).ToList();
            foreach (var item in color)
            {
                data.Add(db.MasterData.Where(n => n.Id == item.MasterColorId).FirstOrDefault());
            }
            return data;
        }

        public List<Product> GetListProduct()
        {
            return db.Products.Where(n => n.Status == 1 && n.IsDelete == false).ToList();
        }

        public bool Order(Order order, List<OrderDetail> orderDetails)
        {
            try
            {
                if (order.Id == 0)
                {
                    order.CreatedDate = DateTime.Now;
                    db.Orders.Add(order);
                    db.SaveChanges();

                    if (orderDetails != null)
                    {
                        orderDetails = orderDetails.Select(x => { x.OrderId = order.Id; return x; }).ToList();
                        db.OrderDetails.AddRange(orderDetails);
                         db.SaveChanges();
                    }
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
