using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ICustomerService customerService;
        public AuthorController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }
        [Route("dang-nhap-tai-khoan")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("dang-ky-tai-khoan")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
      
        public IActionResult Login(string username, string password)
        {
            var data = customerService.Login(username, password);
            if (data != null)
            {
                string userkey = JsonConvert.SerializeObject(data);
                HttpContext.Session.SetString("User", userkey);
                HttpContext.Session.SetString("UserName", data.Name);

                var cookieOptions = new CookieOptions
                {
                    Secure = true,
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Expires = DateTime.Now.AddDays(30)
                };

                // Add the cookie to the response cookie collection
                Response.Cookies.Append("Author", userkey, cookieOptions);
                return Json(true);
            }
            return Json(false);
        }
        [HttpPost]
        
        public JsonResult Register(Customer customer)
        {
            var data = customerService.Register(customer);
            return Json(data);
        }
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("Author");
            HttpContext.Session.Remove("User");
            return RedirectToAction("Index", "Home");
        }

    }
}
