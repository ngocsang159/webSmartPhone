using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{

    public class BannerService : GenericService<Banner>, IBannerService
    {
        //admin
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Banner GetBannerByID(long Id)
        {
            return db.Banners.Find(Id);
        }

        public ResponseDataAdmin<BannerProductView> GetListBanner(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;
            var data = db.Banners.Where(n => n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Banners.Where(n => n.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Banners.Where(n => n.Name.ToLower().Contains(search.ToLower()) && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Banners.Where(n => n.Name.ToLower().Contains(search.ToLower()) && n.IsDelete == false).Count();
            }
            List<BannerProductView> dataBP = new List<BannerProductView>();
            foreach(var item in data)
            {
                BannerProductView BPW = new BannerProductView()
                {
                    banner = item,
                    product = db.Products.Find(item.ProductId)
                };
                dataBP.Add(BPW);
              
            }    
            ResponseDataAdmin<BannerProductView> dataBanner = new ResponseDataAdmin<BannerProductView>();
            dataBanner.data = dataBP;
            dataBanner.pageSize = pageSize;
            dataBanner.pageNumber = pageNumber;
            dataBanner.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataBanner.Total = total;
            return dataBanner;

        }
        public bool AddOrUpdate(Banner banner)
        {
            if (banner != null)
            {
                if (banner.Id == 0)
                {
                    banner.IsDelete = false;
                    banner.CreatedDate = DateTime.Now;
                    banner.UpdatedBy = "";
                    db.Banners.Add(banner);
                    db.SaveChanges();

                }
                else
                {
                    var obj = db.Banners.Find(banner.Id);
                    obj.Name = banner.Name;
                    obj.Image = banner.Image;
                    obj.Title = banner.Title;
                    obj.Position = banner.Position;
                    obj.ProductId = banner.ProductId;
                    obj.Status = banner.Status;
                    obj.UpdatedDate = DateTime.Now;
                    obj.UpdatedBy = banner.UpdatedBy;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteById(long Id)
        {
            var banner = db.Banners.Find(Id);
            banner.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        public List<Product> GetListProduct()
        {
            return db.Products.Where(n=>n.Status ==1 && n.IsDelete == false).ToList();
        }
        //web
        public List<Banner> GetListViewBanner()
        {
            return db.Banners.Where(n => n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Take(3).ToList();
        }

     
    }
}
