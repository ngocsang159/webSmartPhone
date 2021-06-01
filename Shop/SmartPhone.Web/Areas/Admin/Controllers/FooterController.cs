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
    public class FooterController : Controller
    {
        public IFooterService _footerService;
        public FooterController()
        {
            _footerService = new FooterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _footerService.GetListFooter(getViewData);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _footerService.GetFooterById(Id);
            
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult GetFooterById(long Id)
        {
            var data = _footerService.GetFooterById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(Footer footer)
        {
            footer.UpdateBy = HttpContext.Session.GetString("Username");
            footer.CreatedBy = HttpContext.Session.GetString("Username");
            var data = _footerService.AddOrUpdate(footer);
            return Json(data);
        
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _footerService.Delete(Id);
            return Json(data);
        }

    }
}
