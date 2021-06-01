using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PolicyController : Controller
    {
        
        public  static long ParentId {get;set; }
        public IPolicyService _policyService;
        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService;
        }
        public IActionResult Index(long Id)
        {
            ParentId = Id;
            ViewBag.parentName = _policyService.GetPolicyById(ParentId).Name;
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _policyService.GetListPolicy(getViewData, ParentId);
            return PartialView(data);
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _policyService.GetPolicyById(Id);
            return PartialView(data);
        }
        public IActionResult Create()
        {
            ViewBag.parentId = ParentId;
            return View();
        }
        public IActionResult Edit(long Id)
        {
            var data = _policyService.GetPolicyById(Id);
            ViewBag.parentId = ParentId;
            return View(data);
        }

        [HttpPost]
        public JsonResult _AddOrUpdate(Policy policy)
        {
            var data = _policyService.AddOrUpdate(policy, ParentId);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteById(long Id )
        {
            var data = _policyService.DeleteById(Id);
            return Json(data);
        }


    }
}
