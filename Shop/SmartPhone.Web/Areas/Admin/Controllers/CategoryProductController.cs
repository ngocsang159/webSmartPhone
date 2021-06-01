using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;
namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryProductController : Controller
    {
        public ICategoryProductService _categoryProductService;
        public CategoryProductController()
        {
            _categoryProductService = new CategoryProductService();
        }
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _categoryProductService.GetListCategory(getViewData);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _categoryProductService.GetCategoryProductByID(Id);
            return View(data);
        }
        [HttpPost]
        public JsonResult GetCatogoryByID(long Id)
        {
            var data = _categoryProductService.GetCategoryProductByID(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(CategoryProduct categoryProduct)
        {
            var data = _categoryProductService.AddOrUpdate(categoryProduct);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteByID(long Id)
        {
            var data = _categoryProductService.DeleteCategory(Id);
            return Json(data);
        }

    }
}
