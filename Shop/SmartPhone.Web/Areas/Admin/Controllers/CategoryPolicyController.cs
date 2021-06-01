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
    public class CategoryPolicyController : Controller
    {
        public IPolicyService _policyService;
        public CategoryPolicyController()
        {
            _policyService = new PolicyService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _policyService.GetListPolicy(getViewData, 0);
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult GetCategoryById(long Id)
        {
            var data = _policyService.GetPolicyById(Id);
            return Json(data);

        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _policyService.GetPolicyById(Id);
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(Policy policy)
        {
            policy.UpdatedBy = HttpContext.Session.GetString("UserName");
            policy.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _policyService.AddOrUpdate(policy,0);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _policyService.DeleteById(Id);
            return Json(data);
        }

    }
}
