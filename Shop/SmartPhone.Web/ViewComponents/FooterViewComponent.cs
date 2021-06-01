using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.ViewComponents
{
    public class FooterViewComponent :ViewComponent
    {
        private readonly IFooterService footerService;
        public FooterViewComponent()
        {
            footerService = new FooterService();
        }
        public IViewComponentResult Invoke()
        {
            
            var result = footerService.GetItemFooter();
            return View(result);
        }
    }
}
