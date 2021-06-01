using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.Controllers
{
    public class PolicyController : Controller
        
    {
        private readonly IPolicyService policyService;
        public PolicyController(IPolicyService _policyService)
        {
            policyService = _policyService;
        }
        [Route("chinh-sach/{Slug}/{Id}")]
        public IActionResult Index(long Id)
        {
            ViewBag.GetPolicy = policyService.GetListPolicyWeb();
            //ViewBag.policy = policyService.GetCategoryPolicy(Id);
            var policyDetail = policyService.GetPolicy(Id);
            ViewBag.PolicyDetail = policyDetail;

            return View();
        }

    }
}
