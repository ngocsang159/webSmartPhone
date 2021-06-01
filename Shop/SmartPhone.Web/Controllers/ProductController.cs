using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;
using SmartPhone.Services;

namespace SmartPhone.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryProductService categoryProductService;
        private readonly IPageImageService pageImageService;
        public ProductController(IPageImageService _pageImageService)
        {
            pageImageService = _pageImageService;
            productService = new ProductService();
            categoryProductService = new CategoryProductService();
        }
        
        [Route("dien-thoai")]
        [Route("danh-muc/{slug}/{CategoryId}")]
        [Route("Product/Inex/{CategoryId}")]
        public IActionResult Index(long? CategoryId)
        {
            ViewBag.imgPage = pageImageService.GetListImageProduct();
           
            if (CategoryId == null || CategoryId == 0)
            {
                CategoryId = 0;
                ViewBag.categoryName = "Điện thoại";
                var data1 = categoryProductService.GetListCategoryProduct().Where(n=>n.Name !="Phụ Kiện").ToList();
                ViewBag.Total = productService.GetListProductAll((long)CategoryId, 1, 1, 12).Total;
                ViewBag.pageSize = productService.GetListProductAll((long)CategoryId, 1, 1, 12).pageSize;
                return View("ProductAll",data1);
            }
            else
            {
                ViewBag.categoryName = categoryProductService.GetListCategoryProduct().FirstOrDefault(n => n.Id == CategoryId).Name.ToString();
            }
            ViewBag.idCategory = CategoryId;
            var data = categoryProductService.GetListCategoryProduct();
            ViewBag.Total = productService.GetListProductAll((long)CategoryId, 1, 1, 12).Total;
            ViewBag.pageCount = productService.GetListProductAll((long)CategoryId, 1, 1, 12).pageCount;
            return View(data);
        }
        [Route("phu-kien")]
        public IActionResult Accessories(long? CategoryId)
        {
            ViewBag.imgPage = pageImageService.GetListImageProduct();

            if (CategoryId == null || CategoryId == 0)
                CategoryId = 0;
                ViewBag.categoryName = "Phụ kiện";
            ViewBag.idCategory = CategoryId;
            //var data = categoryProductService.GetListCategoryProduct().Where(n => n.Name == "Phụ Kiện").ToList();
            ViewBag.pageCount = productService.GetListProductAccessries((long)CategoryId, 1, 1, 12).pageCount;
           
            var data = productService.GetListProductAccessries((long)CategoryId, 1, 1, 12);
            ViewBag.Total = productService.GetListProductAccessries((long)CategoryId, 1, 1, 12).Total;
            return View("Accessories", data);
        }
        [HttpPost]
        public PartialViewResult GetListProductByCate(long cate_id,int orderBy, int pageNumber)
        {
            var data = productService.GetListProductAll(cate_id, orderBy, pageNumber, 12);
            return PartialView("GetListProductByCate",data);
        }
        [HttpPost]
        public PartialViewResult GetListProductByCateAcc(long cate_id, int orderBy, int pageNumber)
        {
            var data = productService.GetListProductAccessries(cate_id, orderBy, pageNumber, 12);
            return PartialView("GetListProductByCate", data);
        }
        [HttpPost]
        public IActionResult GetListProductBySearch(long cate_id,int orderBy,int pageNumber,string search)
        {
            var data = productService.GetListProductSearch(cate_id, orderBy, pageNumber, 12, search);
            return Json(data);
        }

    }
}
