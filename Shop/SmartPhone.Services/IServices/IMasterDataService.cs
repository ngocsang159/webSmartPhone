using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public interface IMasterDataService
    {
        public ResponseDataAdmin<MasterDatum> GetListItem(GetViewData GetViewData, long tableId);
        public MasterDatum GetItemById(long Id);
        public bool AddOrUpdate(MasterDatum masterData, long tableId);
        public bool DeleleItemByID(long Id);
    }
}
