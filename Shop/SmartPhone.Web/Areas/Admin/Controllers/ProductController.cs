using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using SmartPhone.Commons;
using Microsoft.AspNetCore.Http;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public static long CategoryId { get; set; }
        public IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(long Id)
        {
            CategoryId = Id;
            ViewBag.categoryName = _productService.GetCategoryProduct(Id).Name;
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _productService.GetListProductByCategoryById(getViewData, CategoryId);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _productService.GetProductByID(Id);
            return PartialView(data);
        }
        public IActionResult CreateProduct()
        {
            ViewBag.CategoryId = CategoryId;
            ViewBag.color = _productService.GetListItem(Constant.COLOR);
            ViewBag.brand = _productService.GetListItem(Constant.BRAND);
         
            return View();
        }
 
        public IActionResult EditProduct(long Id)
        {
            var data = _productService.GetProductByID(Id);
            ViewBag.CategoryId = CategoryId;
            ViewBag.brand = _productService.GetListItem(Constant.BRAND);
            ViewBag.color = _productService.GetListItem(Constant.COLOR);
          
            ViewBag.image = _productService.GetListImageProduct(Id);
            ViewBag.listColor = _productService.GetListProductColor(Id);
            return View(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(Product product,List<ProductColor> productColors,List<ProductImage> productImages)
        {
            product.UpdatedBy = HttpContext.Session.GetString("UserName");
            product.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _productService.AddOrUpdate(product, CategoryId, productColors, productImages);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetCategoryByID(long Id)
        {
            var data = _productService.GetCategoryProduct(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteByID(long Id)
        {
            var data = _productService.DeleteProduct(Id);
            return Json(data);
        }

    }
}
