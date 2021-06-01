using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using SmartPhone.Models.EF;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {

        private readonly IAccountService _accountService;
        public AdminController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        /// <summary>
        /// Đăng nhập admin
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _accountService.Login(username, password);
            if (user != null)
            {
                string userkey = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("User", userkey);
                HttpContext.Session.SetString("UserName", user.Name);
                return Json(true);
            }
            return Json(false);
        }
        /// <summary>
        /// Đăng xuất tài khoản admin
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult Logout()
        {
            var session = HttpContext.Session;
            session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Lấy tất cả tài khoản của admin
        /// </summary>
        /// <param name="getViewData">pageSize,pageNumber,search</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult _TableView(GetViewData getViewData)
        {
            var data = _accountService.GetListAccount(getViewData);
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
            var data = _accountService.GetAccountByID(Id);
            return PartialView(data);
        }
        /// <summary>
        /// Thêm mới hoắc sửa 1 tài khoản
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddOrEdit(Account admin)
        {
            var data = _accountService.AddOrUpdateAdmin(admin);
            return Json(data);
        }
        /// <summary>
        /// Xóa tài khoản
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteById(long Id)
        {
            var data = _accountService.Delete(Id);
            return Json(data);
        }
        /// <summary>
        /// Lấy tài khoản theo ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetAdminById(long Id)
        {
            var data = _accountService.GetAccountByID(Id);
            return Json(data);
        }
       

    }
}
