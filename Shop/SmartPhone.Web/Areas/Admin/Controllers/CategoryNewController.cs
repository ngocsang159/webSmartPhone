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
    public class CategoryNewController : Controller
    {
        protected INewService _newService;
        public CategoryNewController()
        {
            _newService = new NewService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _newService.GetNewById(Id);
            return PartialView(data);
        }    
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {

            var data = _newService.GetListNew(getViewData, 0);
            return View(data);
        }
        [HttpPost]
        public JsonResult _GetCategoryNewById(long Id)
        {
            var data = _newService.GetNewById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult _AddOrUpdate(New categoryNew)
        {
            categoryNew.UpdateBy = HttpContext.Session.GetString("UserName");
            categoryNew.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _newService.AddOrUpdate(categoryNew, 0);
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
