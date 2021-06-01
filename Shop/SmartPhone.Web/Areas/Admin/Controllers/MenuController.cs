using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private IMenuService _menuService;
        public static long CategoryID = 0;
        public MenuController()
        {
            _menuService = new MenuService();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult Index(long? Id)
        {
            if (Id == null)

                Id = 0;
            CategoryID = (long)Id;
            ViewBag.Name = Id == 0 ? "Menu" : _menuService.GetMenuById((long)Id).Name;

            return View();
        }
        /// <summary>
        /// Lấy tất cả menu 
        /// </summary>
        /// <param name="getViewData">pageSize,pageNumber,search</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _menuService.GetListMenuByCategoryId(getViewData, CategoryID);
            return PartialView(data);
        }
        /// <summary>
        /// Xem chi tiết tài khoản
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult _GetViewDetail(long Id)
        {
            var data = _menuService.GetMenuById(Id);
            return PartialView(data);
        }

        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _menuService.Delete(Id);
            return Json(data);
        }
        [HttpPost]
        public JsonResult AddOrUpdate(Menu menu)
        {
            menu.UpdatedBy = HttpContext.Session.GetString("UserName");
            menu.CreatedBy = HttpContext.Session.GetString("UserName");
            var data = _menuService.AddOrUpdateMenu(menu, CategoryID);
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetMenuByID(long Id)
        {
            var data = _menuService.GetMenuById(Id);
            return Json(data);
        }

    }
}
