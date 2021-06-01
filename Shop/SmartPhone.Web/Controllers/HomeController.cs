using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartPhone.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;
using Newtonsoft.Json;

namespace SmartPhone.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBannerService bannerService;
        private readonly IPageImageService pageImageService;
        private readonly IProductService productService;
        private readonly IProductDetailService productDetailService;
        private readonly ICategoryProductService categoryProductService;

        public HomeController()
        {
            bannerService = new BannerService();
            pageImageService = new PageImageService();
            productService = new ProductService();
            productDetailService = new ProductDetailService();
            categoryProductService = new CategoryProductService();
        }
        
        [Route("")]
        [Route("Home")]
        [Route("trang-chu")]
        public IActionResult Index()
        {
            ViewBag.imgBanner = bannerService.GetListViewBanner();
            ViewBag.imgPage = pageImageService.GetListImageHome();
            ViewBag.productHot = productService.GetListProductHot();
            ViewBag.productIphone = productService.GetListProductByCategory(7);
            ViewBag.productSamsung = productService.GetListProductByCategory(8);
            ViewBag.productSmartPhone = productService.GetListProductByCategory(9);
            ViewBag.productAccessories = productService.GetListProductByCategory(10);
            var data = categoryProductService.GetCategoryProduct();
            return View(data);
        }
        [Route("quick-view/{id}")]
        public IActionResult QuickView(long Id)
        {
            var response = JsonConvert.SerializeObject(new
            {
                detailProduct = productDetailService.GetProductId(Id),
                Img = productDetailService.GetImageOfProduct(Id),
                color = productDetailService.GetListColorOfProduct(Id)
            },
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });
            return Content(response, "application/json");
            

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
