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
    public class BannerController : Controller
    {
        public IBannerService _bannerService;
        public BannerController()
        {
            _bannerService = new BannerService();
        }
        public IActionResult Index()
        {
            ViewBag.product = _bannerService.GetListProduct();
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _bannerService.GetListBanner(getViewData);
            return View(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _bannerService.GetBannerByID(Id);
            return View(data);
        }
        public JsonResult GetBannerByID(long Id)
        {
            var data = _bannerService.GetBannerByID(Id);
            return Json(data);
        }

        [HttpPost]
        public JsonResult AddOrUpdate(Banner banner)
        {
            banner.UpdatedBy = HttpContext.Session.GetString("UserName");
            banner.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _bannerService.AddOrUpdate(banner);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteByID(long Id)
        {
            var data = _bannerService.DeleteById(Id);
            return Json(data);
        }
    }
}
