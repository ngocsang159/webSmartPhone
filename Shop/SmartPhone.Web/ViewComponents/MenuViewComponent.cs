using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;

namespace SmartPhone.Web.ViewComponents
{
    public class MenuViewComponent :ViewComponent
    {
        private readonly IMenuService menuService;
        public MenuViewComponent()
        {
            menuService = new MenuService();
        }
        public IViewComponentResult Invoke()
        {
            var data = menuService.GetListMenu();
            return View(data);
        }
    }
}
