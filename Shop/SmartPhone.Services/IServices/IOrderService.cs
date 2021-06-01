using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public interface IOrderService
    {
        //get data
        //Order
        public ResponseDataAdmin<OrderView> GetListOrder(GetViewData getViewData);
        public OrderViewModel GetOrder(long Id);

        //OrderDetail
        public List<OrderDetailView> GetListOrderDetail(long OrderId);
        public OrderDetailView GetOrderDetail(long Id);

        //add data
        public bool InsertOrder(Order order);
        public bool InsertOrderDetail(OrderDetail orderDetail);

        //delete data
        public bool DeleteOrder(long Id);
        public bool DeleteOrderDetailById(long Id);

        //get obj
        public Order GetOrderById(long Id);
        public OrderDetail GetOrderDetailById(long Id);

        //danh sách người tạo
        public List<Account> GetListAdmin();
        public List<Customer> GetListCustomer();
        public List<OrderStatus> GetListStatusOrder();
        public List<MasterDatum> GetListItemColor(long ParentId);
         public List<MasterDatum> GetListProductColor(long ProductId);
        public List<Product> GetListProduct();

        public bool Order(Order order, List<OrderDetail> orderDetails);
    }
}
