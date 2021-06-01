using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Commons;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public class PageImageService : GenericService<ImageInPage>, IPageImageService
    {
        
        public ImageInPage GetImageById(long Id)
        {
            return db.ImageInPages.Find(Id);
        }

        public ResponseDataAdmin<ImageInPage> GetListImage(GetViewData getViewData, long ParentId)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string Search = getViewData.Search;

            var data = db.ImageInPages.Where(n => n.LocationId == ParentId && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.ImageInPages.Where(n => n.LocationId == ParentId && n.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(Search))
            {
                if (Search == null)
                    Search = "";
                Search = Search.Trim();
                data = db.ImageInPages.Where(n => n.LocationId == ParentId && n.Name.ToLower().Contains(Search.ToLower()) && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.ImageInPages.Where(n => n.LocationId == ParentId && n.Name.ToLower().Contains(Search.ToLower()) && n.IsDelete == false).Count();
            }

            ResponseDataAdmin<ImageInPage> dataImage = new ResponseDataAdmin<ImageInPage>();
            dataImage.data = data;
            dataImage.pageNumber = pageNumber;
            dataImage.pageSize = pageSize;
            dataImage.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataImage;
        }

        public List<MasterDatum> GetListPage()
        {
            return db.MasterData.Where(n => n.ParentId == Constant.DISPLAYPAGE).ToList();
        }
        public bool AddOrUpdate(ImageInPage imageInPage, long ParentId)
        {
            if (imageInPage != null)
            {
                if (imageInPage.Id == 0)
                {
                    imageInPage.LocationId = ParentId;
                    imageInPage.IsDelete = false;
                    imageInPage.CreatedDate = DateTime.Now;
                    db.ImageInPages.Add(imageInPage);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.ImageInPages.Find(imageInPage.Id);
                    obj.Name = imageInPage.Name;
                    obj.Image = imageInPage.Image;
                    obj.Position = imageInPage.Position;
                    obj.Status = imageInPage.Status;
                    obj.UpdatedBy = imageInPage.UpdatedBy;
                    obj.UpdatedDate = DateTime.Now;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteImage(long Id)
        {
            var data = db.ImageInPages.Where(n=>n.Id == Id).FirstOrDefault();
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        public List<ImageInPage> GetListImageHome()
        {
            var display = Constant.HOME;
            return db.ImageInPages.Where(n => n.LocationId == display && n.Status == 1 && n.IsDelete == false).ToList();
        }    

        public List<ImageInPage> GetListImageProduct()
        {
            var display = Constant.PRODUCT;
            return db.ImageInPages.Where(n => n.LocationId == display && n.Status == 1 && n.IsDelete == false).ToList();
        }
    }
}
