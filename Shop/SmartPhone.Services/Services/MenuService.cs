using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public class MenuService : GenericService<Menu>, IMenuService
    {
        public Menu GetMenuById(long Id)
        {
            return db.Menus.Find(Id);
        }
        public bool AddOrUpdateMenu(Menu menu, long CategoryID)
        {
            if (menu != null)
            {
                if (menu.Id == 0)
                {
                    menu.ParentId = CategoryID;
                    menu.IsDelete = false;
                    menu.CreatedDate = DateTime.Now;
                    db.Menus.Add(menu);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.Menus.Find(menu.Id);
                    obj.Name = menu.Name;
                    obj.Slug = menu.Slug;
                    obj.Position = menu.Position; ;
                    obj.Status = menu.Status;
                    obj.UpdatedDate = DateTime.Now;
                    obj.UpdatedBy = menu.UpdatedBy;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public ResponseDataAdmin<Menu> GetListMenuByCategoryId(GetViewData getViewData, long CategoryID)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;

            var data = db.Menus.Where(n => n.ParentId == CategoryID && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Menus.Where(n => n.ParentId == CategoryID && n.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Menus.Where(n => n.ParentId == CategoryID && n.Name.ToLower().Contains(search.ToLower()) && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Menus.Where(n => n.ParentId == CategoryID && n.Name.ToLower().Contains(search.ToLower()) && n.IsDelete == false).Count();
            }

            ResponseDataAdmin<Menu> dataMenu = new ResponseDataAdmin<Menu>();
            dataMenu.data = data;
            dataMenu.pageSize = pageSize;
            dataMenu.pageNumber = pageNumber;
            dataMenu.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataMenu.Total = total;
            return dataMenu;


        }
        public bool Delete(long Id)
        {
            var data = db.Menus.Find(Id);
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        //Web
        public List<MenuViewModel> GetListMenu()
        {
            List<MenuViewModel> data = new List<MenuViewModel>();
            var menuParent = db.Menus.Where(n => n.ParentId == 0 && n.Status == 1 && n.IsDelete == false).OrderBy(n=>n.Position).ToList();
            foreach(var item in menuParent)
            {
                MenuViewModel sub = new MenuViewModel();
                sub.menu = item;
                sub.subMenu = db.Menus.Where(n=>n.ParentId == item.Id && n.Status == 1 && n.IsDelete == false).ToList();
                data.Add(sub);
            }
            return data;
        }

  


    }
}
