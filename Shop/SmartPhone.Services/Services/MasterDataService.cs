using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;


namespace SmartPhone.Services
{
    public class MasterDataService : GenericService<MasterDatum>, IMasterDataService
    {

        public MasterDatum GetItemById(long Id)
        {
            var item = db.MasterData.Find(Id);
            return item;
        }

        public ResponseDataAdmin<MasterDatum> GetListItem(GetViewData GetViewData, long tableId)
        {
            int pageSize = GetViewData.pageSize;
            int pageNumber = GetViewData.pageNumber;
            string search = GetViewData.Search;

            var data = db.MasterData.Where(x => x.ParentId == tableId).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.MasterData.Where(x => x.ParentId == tableId).Count();
            if (!String.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.MasterData.Where(x => x.Name.ToLower().Contains(search.ToLower()) && x.ParentId == tableId).Skip(pageSize * (pageNumber - 1)).OrderBy(x => x.Position).Take(pageSize).ToList();
                total = db.MasterData.Where(x => x.Name.ToLower().Contains(search.ToLower()) && x.ParentId == tableId).Count();
            }

            ResponseDataAdmin<MasterDatum> dataItem = new ResponseDataAdmin<MasterDatum>();
            dataItem.data = data;
            dataItem.pageNumber = pageNumber;
            dataItem.pageSize = pageSize;
            dataItem.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataItem.Total = total;
            return dataItem;
        }
        public bool AddOrUpdate(MasterDatum masterData, long tableId)
        {
            if (masterData != null)
            {
                if (masterData.Id == 0)
                {
                    masterData.ParentId = tableId;
                    db.MasterData.Add(masterData);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.MasterData.Find(masterData.Id);
                    obj.Name = masterData.Name;
                    obj.Position = masterData.Position;
                    obj.Status = masterData.Status;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleleItemByID(long Id)
        {
            var item = db.MasterData.Find(Id);
            db.MasterData.Remove(item);
            db.SaveChanges();
            return true;
        }

    }
}
