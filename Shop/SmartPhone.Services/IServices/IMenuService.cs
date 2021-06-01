using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public interface IMenuService
    {
        //admin
        public ResponseDataAdmin<Menu> GetListMenuByCategoryId(GetViewData getViewData, long CategoryID);
        public Menu GetMenuById(long Id);
        public bool AddOrUpdateMenu(Menu menu, long CategoryID);
        public bool Delete(long Id);

        //Web
        public List<MenuViewModel> GetListMenu();
    }
}
