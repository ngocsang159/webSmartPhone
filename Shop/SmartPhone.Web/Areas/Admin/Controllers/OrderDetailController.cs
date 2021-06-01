using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;
using SmartPhone.Services;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderDetailController : Controller
    {
        public IOrderService _orderService;
        public static long OrderId;
        public OrderDetailController()
        {
            _orderService = new OrderService();
        }
        public IActionResult Index(long Id)
        {
            OrderId = Id;
            ViewBag.Product = _orderService.GetListProduct();
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _orderService.GetListOrderDetail(OrderId);
            return PartialView(data);
        }   
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _orderService.GetOrderDetail(Id);
            return View(data);
        }
        [HttpPost]
        public JsonResult GetOrderDetailById(long Id)
        {
            var data = _orderService.GetOrderDetailById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(OrderDetail orderDetail)
        {
            orderDetail.OrderId = OrderId;
            var data = _orderService.InsertOrderDetail(orderDetail);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _orderService.DeleteOrderDetailById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetColorOfProduct(long ProductId)
        {
            var data = _orderService.GetListProductColor(ProductId);
            return Json(data);
        }
    }
}
