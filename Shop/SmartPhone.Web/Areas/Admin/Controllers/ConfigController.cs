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
    [Area("admin")]
    public class ConfigController : Controller
    {
        private IConfigService _configService;
        public ConfigController()
        {
            _configService = new ConfigService();
        }
        public IActionResult Index()
        {
            var data = _configService.GetConfig();
            return View(data);
        }
        [HttpPost]
        public JsonResult Edit(Config config)
        {
            config.UpdateBy = HttpContext.Session.GetString("UserName");
            var data = _configService.Edit(config);
            return Json(data);
        }
        

    }
}
