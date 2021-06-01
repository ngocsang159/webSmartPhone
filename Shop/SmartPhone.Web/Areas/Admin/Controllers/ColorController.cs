using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using SmartPhone.Commons;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        public IMasterDataService _masterDataService;
        public ColorController()
        {
            _masterDataService = new MasterDataService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _ViewDetail(long Id)
        {
            var data = _masterDataService.GetItemById(Id);
            return PartialView(data);
        }
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _masterDataService.GetListItem(getViewData, Constant.COLOR);
            return PartialView(data);
        }
        [HttpPost]
        public JsonResult GetColorByID(long Id)
        {
            var data = _masterDataService.GetItemById(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(MasterDatum masterdata)
        {
            var data = _masterDataService.AddOrUpdate(masterdata, Constant.COLOR);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteColorByID(long Id)
        {
            var data = _masterDataService.DeleleItemByID(Id);
            return Json(Id);
        }
    }
}
