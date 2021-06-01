using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Commons;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public class NewService : GenericService<New>, INewService

    {
        public New GetNewById(long Id)
        {
            var data = db.News.Where(n => n.Id == Id).FirstOrDefault();
            return data;
        }

        public ResponseDataAdmin<New> GetListNew(GetViewData getViewData, long ParentId)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string Search = getViewData.Search;

            var data = db.News.Where(n => n.ParentId == ParentId && n.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.News.Where(n => n.ParentId == ParentId && n.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(Search))
            {
                if (Search == null)
                    Search = "";
                Search = Search.Trim();
                data = db.News.Where(n => n.ParentId == ParentId && n.Name.ToLower().Contains(Search.ToLower()) && n.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.News.Where(n => n.ParentId == ParentId && n.Name.ToLower().Contains(Search.ToLower()) && n.IsDelete == false).Count();
            }

            ResponseDataAdmin<New> dataNew = new ResponseDataAdmin<New>();
            dataNew.data = data;
            dataNew.pageNumber = pageNumber;
            dataNew.pageSize = pageSize;
            dataNew.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataNew;
        }

        public bool AddOrUpdate(New news, long ParentId)
        {
            if (news != null)
            {
                if (news.Id == 0)
                {
                    news.ParentId = ParentId;
                    news.Views = 0;
                    news.Slug = Constant.ConvertString(news.Name);
                    news.IsDelete = false;
                    news.CreatedDate = DateTime.Now;
                    news.UpdateBy = "";
                    db.News.Add(news);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.News.Find(news.Id);
                    obj.Name = news.Name;
                    obj.Image = news.Image;
                    obj.Slug = Constant.ConvertString(obj.Name);
                    obj.Description = news.Description;
                    obj.Content = news.Content;
                    obj.Position = news.Position;
                    obj.Status = news.Status;
                    obj.UpdateBy = news.UpdateBy;
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

        public bool DeleteById(long Id)
        {
            var data = db.News.Where(n => n.Id == Id).FirstOrDefault();
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        //web
       
         
        
        public List<New> GetCategoryNew()
        {
            return db.News.Where(n => n.ParentId == 0 && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
        }
        public ResponseDataAdmin<New> GetListNewBySearch(long CategoryNewId, int OrderBy, int pageNumber, int pageSize,string search)
        {
            List<New> data;
            int total = 0;
            if (!string.IsNullOrEmpty(search))
            {
                if (CategoryNewId == 0)
                {
                    data = db.News.Where(n => n.ParentId != 0 && n.Name.Contains(search) && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                    total = db.News.Where(n => n.Status == 1 && n.IsDelete == false && n.Name.Contains(search)).Count();
                }
                else
                {
                    data = db.News.Where(n => n.ParentId == CategoryNewId && n.Name.Contains(search) && n.Status == 1 && n.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                    total = db.News.Where(n => n.ParentId == CategoryNewId && n.Name.Contains(search) && n.Status == 1 && n.IsDelete == false).Count();
                }


            }
            else
            {
                data = db.News.Where(n => n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.News.Where(n => n.Status == 1 && n.IsDelete == false).Count();

            }
            if (OrderBy == 1)
            {
                data = data.OrderBy(n => n.CreatedDate).ToList();
            }
            else if (OrderBy == 2)
            {
                data = data.OrderByDescending(n => n.CreatedDate).ToList();
            }
            ResponseDataAdmin<New> dataRe = new ResponseDataAdmin<New>();
            dataRe.data = data;
            dataRe.pageNumber = pageNumber;
            dataRe.pageSize = pageSize;
            dataRe.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataRe;
        }
        public ResponseDataAdmin<New> GetListNew(long CategoryNewId, int OrderBy, int pageNumber, int pageSize)
        {
            List<New> data = new List<New>();
            int total = 0;
            if(CategoryNewId >0)
            {
                data = db.News.Where(n => n.ParentId == CategoryNewId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position == OrderBy).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                total = db.News.Where(n => n.ParentId == CategoryNewId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position == OrderBy).Count();
            }
            if (CategoryNewId == 0)
            {
                data = db.News.Where(n => n.ParentId != 0 && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position == OrderBy).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                total = db.News.Where(n => n.ParentId != 0 && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position == OrderBy).Count();
            }
            if (OrderBy == 1)
            {
                data = data.OrderBy(x => x.CreatedDate).ToList();
            }
            else if (OrderBy == 2)
            {
                data = data.OrderByDescending(x => x.CreatedDate).ToList();
            }
            ResponseDataAdmin<New> dataNew = new ResponseDataAdmin<New>();
            dataNew.data = data;
            dataNew.pageNumber = pageNumber;
            dataNew.pageSize = pageSize;
            dataNew.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataNew;
        }
        //lâý tin tức bên trái
        public List<New> GetListNewSide()
        {
            var data = db.News.Where(n => n.ParentId != 0 && n.Status == 1 && n.IsDelete == false).OrderByDescending(n => n.CreatedDate).Take(6).Skip(1).ToList();
            return data;
        }

        public New GetNewByIdWeb(long Id)
        {
            var data = db.News.Where(n => n.ParentId == Id && n.Status == 1 && n.IsDelete == false).FirstOrDefault();
            data.Views = data.Views + 1;
            db.SaveChanges();
            return data;
        }
        public New GetNewSide()
        {
            var data = db.News.Where(n => n.ParentId != 0 && n.Status == 1 && n.IsDelete == false).OrderByDescending(n => n.CreatedDate).Take(1).FirstOrDefault();
            return data;
        }
        public List<New> GetListNewSample(long Id)
        {
            var obj = db.News.Find(Id);
            if (obj != null)
            {
                return db.News.Where(n => n.ParentId == obj.ParentId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Take(6).ToList();
            }
            return null;
        }
        //public New GetCategoryById(long Id)
        //{
        //    var data = db.News.Where(n=>n.)
        //}

    }
}
