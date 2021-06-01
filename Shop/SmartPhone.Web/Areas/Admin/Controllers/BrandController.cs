using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;
using SmartPhone.Models.EF;
using SmartPhone.Commons;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        public IMasterDataService _masterDataService;
        public BrandController()
        {
            _masterDataService = new MasterDataService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _masterDataService.GetListItem(getViewData, Constant.BRAND);
            return View(data);
;        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _masterDataService.GetItemById(Id);
            return View(data);
        }
        [HttpPost]
        public JsonResult GetBrandById(long Id)
        {
            var data = _masterDataService.GetItemById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(MasterDatum masterData)
        {
            var data = _masterDataService.AddOrUpdate(masterData, Constant.BRAND);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteBrandById(long Id)
        {
            var data = _masterDataService.DeleleItemByID(Id);
            return Json(data);
        }
    }
}
