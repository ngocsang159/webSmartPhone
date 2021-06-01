using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;

namespace SmartPhone.Web.ViewComponents
{
    public class DropDownViewComponent:ViewComponent
    {
        private readonly ICategoryProductService categoryProductService;
        public DropDownViewComponent()
        {
            categoryProductService = new CategoryProductService();
        }
        public IViewComponentResult Invoke()
        {
            var data = categoryProductService.GetListCategoryProduct();
            return View(data);
        }

    }
}
