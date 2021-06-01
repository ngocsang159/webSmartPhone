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
    public class ImageInPageController : Controller
    {
        public  static long ParentId { get; set; }
        protected IPageImageService _pageImageService;
        public ImageInPageController()
        {
            _pageImageService = new PageImageService();
        }
        public IActionResult Index(long? Id)
        {
            if(Id == null)
            {
                var data = _pageImageService.GetListPage();
                return View("Page", data);
            }
            else
            {
                ParentId = (long)Id;
                return View();
            }
        }
        public IActionResult Page()
        {
            var data = _pageImageService.GetListPage();
            return View(data);
        }
     
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _pageImageService.GetListImage(getViewData, ParentId);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _pageImageService.GetImageById(Id);
            return PartialView(data);
        }
        
        [HttpPost]
        public JsonResult GetImageById(long Id)
        {
            var data = _pageImageService.GetImageById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(ImageInPage imageInPage)
        {
            imageInPage.UpdatedBy = HttpContext.Session.GetString("UserName");
            imageInPage.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _pageImageService.AddOrUpdate(imageInPage, ParentId);
            return Json(data);
        }


        [HttpPost]
        public JsonResult DeleteImageById(long Id)
        {
            var data = _pageImageService.DeleteImage(Id);
            return Json(data);
        }

    }
}
