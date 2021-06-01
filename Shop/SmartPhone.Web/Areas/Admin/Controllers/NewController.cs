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
    public class NewController : Controller
    {
        protected INewService _newService;
        public static long ParentId { get; set; }
        public NewController()
        {
            _newService = new NewService();
        }
        public IActionResult Index(long Id)
        {
            ParentId = Id;
            ViewBag.parentName = _newService.GetNewById(ParentId).Name;
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _newService.GetListNew(getViewData, ParentId);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _newService.GetNewById(Id);
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult GetNewById(long Id)
        {
            var data = _newService.GetNewById(Id);
            return Json(data);
        }
        public IActionResult Create()
        {
            ViewBag.parentId = ParentId;
            return View();
        }
        public IActionResult Edit(long Id)
        {
            var data = _newService.GetNewById(Id);
            ViewBag.parentId = ParentId;
            return View(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(New news)
        {
            news.UpdateBy = HttpContext.Session.GetString("UserName");
            news.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _newService.AddOrUpdate(news,ParentId);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _newService.DeleteById(Id);
            return Json(data);
        }    
    }
}
