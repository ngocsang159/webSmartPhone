using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public class FooterService : GenericService<Footer>, IFooterService

    {

        public Footer GetFooterById(long Id)
        {
            return db.Footers.Find(Id);
        }

        public ResponseDataAdmin<Footer> GetListFooter(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;

            var data = db.Footers.Where(n => n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Footers.Where(n => n.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Footers.Where(n => n.IsDelete == false && n.Name.ToLower().Contains(search)).OrderBy(n => n.Position).ToList();
                total = db.Footers.Where(n => n.IsDelete == false && n.Name.ToLower().Contains(search)).Count();
            }
            ResponseDataAdmin<Footer> dataFooter = new ResponseDataAdmin<Footer>();
            dataFooter.data = data;
            dataFooter.pageNumber = pageNumber;
            dataFooter.pageSize = pageSize;
            dataFooter.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataFooter;
        }
        public bool AddOrUpdate(Footer footer)
        {
            if (footer != null)

            {
                if(footer.Id == 0)
                {
                    footer.IsDelete = false;
                    footer.CreatedDate = DateTime.Now;
                    db.Footers.Add(footer);
                    db.SaveChanges();
                }    
                else
                {
                    var obj = db.Footers.Find(footer.Id);
                    obj.Name = footer.Name;
                    obj.Image = footer.Image;
                    obj.Description = footer.Description;
                    obj.Position = footer.Position;
                    obj.Status = footer.Status;
                    obj.UpdateDate = footer.UpdateDate;
                    obj.UpdateBy = footer.UpdateBy;
                    db.SaveChanges();

                }
                return true;
            }
            else
            {
                return false;
            }    
        }

        public bool Delete(long Id)
        {
            var footer = db.Footers.Find(Id);
            footer.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        //Web
        //List Footer
        public List<Footer> GetItemFooter()
        {
            return db.Footers.Where(n => n.Status == 1 && n.IsDelete == false).OrderBy(n=>n.Position).Take(4).ToList();
        }
    }
}
