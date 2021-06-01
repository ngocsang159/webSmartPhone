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
    public class ProductSpecificationController : Controller
    {
        
        public IProductSpecificationService _productSpecificationService;
        public ProductSpecificationController(IProductSpecificationService productSpecificationService)
        {
            _productSpecificationService = productSpecificationService;
        }
        public static long ProductId { get; set; }
        public IActionResult Index(long? Id)
        {

            ProductId = (long)Id;
            ViewBag.ProductId = ProductId;
            var obj = _productSpecificationService.GetProductSpecificationByProductId(ProductId);
            
            if(obj == null)
            {
                obj = _productSpecificationService.GetProductSpecification();
                return View(obj);
            }    
            return View(obj);
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _productSpecificationService.GetListSpecification(getViewData,ProductId);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _productSpecificationService.GetSpecificationById(Id);
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult GetSpecification(long Id)
        {
            var data = _productSpecificationService.GetSpecificationById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult _AddOrUpdate(ProductSpecification productSpecification)
        {
            productSpecification.UpdatedBy = HttpContext.Session.GetString("UserName");
            productSpecification.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _productSpecificationService.AddOrUpdate(productSpecification, ProductId);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _productSpecificationService.DeleteById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult Edit(ProductSpecification productSpecification)
        {
            var sessionName = HttpContext.Session.GetString("UserName");
            productSpecification.UpdatedBy = sessionName;
            //productSpecification.Status = 1;
            var data = _productSpecificationService.AddOrUpdate(productSpecification, ProductId);
            return Json(data);

        }


    }
}
