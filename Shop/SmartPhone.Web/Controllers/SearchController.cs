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
    public class SearchController : Controller
    {
        private readonly IProductService productService;
        private readonly IProductDetailService productDetailService;
        private readonly INewService newService;
        private readonly ICategoryProductService categoryProductService;
        public SearchController(IProductService _productService)
        {
            productService = _productService;
             productService = new ProductService();
            newService = new NewService();
            categoryProductService = new CategoryProductService();
        }
        public IActionResult Index()
        {
            //list CategoryProduct
            ViewBag.listCate = categoryProductService.GetListCategoryProduct();
            ViewBag.listNew = newService.GetCategoryNew(); 
            return View();
        }
        [HttpPost]
        public PartialViewResult SearchByProduct(long cate_id,int OrderBy,int pageNumber,string search)
        {
            var data = productService.GetListProductSearch(cate_id, OrderBy, pageNumber, 12, search);
            return PartialView("SearchByProduct", data);
        }
        [HttpPost]
        public PartialViewResult SearchByNew(long cate_id, int OrderBy, int pageNumber, string search)
        {
            var data = newService.GetListNewBySearch(cate_id, OrderBy, pageNumber,12, search);
            return PartialView("SearchByNew",data);
        }
    }
}
