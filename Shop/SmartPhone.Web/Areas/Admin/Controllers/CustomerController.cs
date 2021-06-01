using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using Microsoft.AspNetCore.Http;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        protected ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        public IActionResult Index()
        {
            ViewBag.Province = _customerService.GetListProvince();
;            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _customerService.GetListCustomer(getViewData);
            return View(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _customerService.GetCustomer(Id);
            return View(data);
        }
        [HttpPost]
        public JsonResult GetCustomerById(long Id)
        {
            var data = _customerService.GetCustomerById(Id);
            return Json(data);

        }
        [HttpPost]
        public JsonResult AddOrUpdate(Customer customer)
        {
            customer.UpdatedBy = HttpContext.Session.GetString("UserName");
            customer.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _customerService.AddOrUpdate(customer);
            return Json(data);

        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _customerService.DeleteCustomerById(Id);
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
