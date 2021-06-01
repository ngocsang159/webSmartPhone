using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductDetailService productDetailService;
        protected ICategoryProductService categoryProductService;
        public ProductDetailController()
        {
            categoryProductService = new CategoryProductService();
            productDetailService = new ProductDetailService();
        }

        [Route("san-pham/{slug}/{id}")]
        [Route("ProductDetail/Index/{id}")]

        public IActionResult Index(long Id)
        {
            ViewBag.productDetail = productDetailService.GetProductId(Id);
            ViewBag.listColor = productDetailService.GetListColorOfProduct(Id);
            ViewBag.listImage = productDetailService.GetImageOfProduct(Id);
            ViewBag.listProductSample = productDetailService.GetListProductSample(Id);
            ViewBag.productSpecification = productDetailService.GetProductSpecification(Id);

            ViewBag.CateSlug = productDetailService.GetCategoryOfProduct(Id).Slug;
            ViewBag.IdCate = productDetailService.GetProductId(Id).CategoryId;
            ViewBag.categoryName = categoryProductService.GetListCategoryProduct().FirstOrDefault(n => n.Id == (productDetailService.GetProductId(Id).CategoryId)).Name.ToString();
            ViewBag.productName = productDetailService.GetProductId(Id).Name.ToString();
            return View();

        }
    }
}
