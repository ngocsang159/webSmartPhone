using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.ViewComponents
{
    public class ConfigViewComponent: ViewComponent
    {
        private readonly IConfigService configService;
        private readonly IPolicyService policyService;
        public ConfigViewComponent()
        {
            configService = new ConfigService();
            policyService = new PolicyService();
        }
        public IViewComponentResult Invoke()
        {
           
            var data = configService.GetDataFooter();
            ViewBag.GetPolicy = policyService.GetListPolicyWeb();
            return View(data);
        }
    }
}
