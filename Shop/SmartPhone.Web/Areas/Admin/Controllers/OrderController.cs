using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;
using SmartPhone.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Rotativa.AspNetCore;


namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        protected readonly LanHangContext db = new LanHangContext();
        public IOrderService _orderService;
        public ICustomerService _customerService;
        public OrderController()
        {
            _orderService = new OrderService();
            _customerService = new CustomerService();
        }
        public IActionResult Index()
        {
            ViewBag.Customer = _orderService.GetListCustomer();
            ViewBag.orderStatus = _orderService.GetListStatusOrder();
            ViewBag.Province = _customerService.GetListProvince();
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _orderService.GetListOrder(getViewData);
            return View(data);
        }
        [HttpPost]
        public IActionResult _OrderPdf(long Id)
        {
            var data = _orderService.GetOrderById(Id);
            List<OrderDetail> orderDetails = db.OrderDetails.Where(n => n.OrderId == data.Id).ToList();
 
           var district = db.Districts.Where(n => n.Id == data.DistrictId).FirstOrDefault();
            DistrictView dv = new DistrictView();
            {
                dv.district = district;
                dv.provinces = db.Provinces.Find(district.ProvinceId);
            }

            //foreach (var item1 in db.Districts.Where(n=>n.Id == data.DistrictId))
            //    {
            //    DistrictView dv = new DistrictView();
            //    dv.district = item1;
            //    dv.provinces = db.Provinces.Find(item1.ProvinceId);
            //    datadv.Add(dv);
            //}
            List<Product> products = new List<Product>();
            foreach (var item in orderDetails)
            {
                Product product = db.Products.Find(item.ProductId);
                products.Add(product);
            }
             
            
            foreach (var item in orderDetails)
            {
                MasterDatum Color = new MasterDatum();
                var color = db.MasterData.Where(n => n.Id == item.ColorId).FirstOrDefault();
                ViewBag.color = color;
            }
            ViewBag.products = products;

            ViewBag.orderdetial = orderDetails;
            ViewBag.dv = dv;
        
            return View(data);
        }
        [HttpGet]
        public IActionResult ExportPdf(long id)
        {

            var data = _orderService.GetOrderById(id);
            List<OrderDetail> orderDetails = db.OrderDetails.Where(n => n.OrderId == data.Id).ToList();
            var district = db.Districts.Where(n => n.Id == data.DistrictId).FirstOrDefault();
            DistrictView dv = new DistrictView();
            {
                dv.district = district;
                dv.provinces = db.Provinces.Find(district.ProvinceId);
            }
            List<Product> products = new List<Product>();
            foreach (var item in orderDetails)
            {
                Product product = db.Products.Find(item.ProductId);
                products.Add(product);
            }
            List<MasterDatum> Color = new List<MasterDatum>();
            foreach (var item in orderDetails)
            {

                var color = db.MasterData.Where(n => n.Id == item.ColorId).FirstOrDefault();
                Color.Add(color);
                
            }
          
            ViewBag.products = products;
            ViewBag.dv = dv;
            ViewBag.orderdetial = orderDetails;
            ViewBag.color = Color;
            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            dicParam.Add("orderInfor", data);
            dicParam.Add("orderDetails", orderDetails);
            dicParam.Add("address", dv);
            dicParam.Add("products", products);
            dicParam.Add("color", Color);

            return new ViewAsPdf("~/Areas/Admin/Views/Order/ViewPdf.cshtml", dicParam) {FileName="DonHang.pdf" };
                //return report;
        
            
        }
        public IActionResult Test()
        {
            return new ViewAsPdf();
        }
        [HttpPost]
        public JsonResult GetOrderById(long Id)
        {
            var data = _orderService.GetOrderById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(Order order)
        {
            var session = HttpContext.Session;
            var admin = JsonConvert.DeserializeObject<Account>(session.GetString("User")).Id;
            order.AdminId = admin;
            order.UpdatedBy = HttpContext.Session.GetString("UserName");
            var data = _orderService.InsertOrder(order);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _orderService.DeleteOrder(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetListDistrict(string Id)
        {
            var data = _customerService.GetListDistrict(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetDistrict(string Id)
        {
            var data = _customerService.GetDistrict(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetProvince(string districtId)
        {
            var data = _customerService.GetProvince(districtId);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetListProvince()
        {
            var data = _customerService.GetListProvince();
            return Json(data);
        }
    }
}
