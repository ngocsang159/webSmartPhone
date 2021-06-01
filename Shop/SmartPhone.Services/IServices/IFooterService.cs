using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public interface  IFooterService
    {
        public ResponseDataAdmin<Footer> GetListFooter(GetViewData getViewData);
        public Footer GetFooterById(long Id);
        public bool AddOrUpdate(Footer footer);
        public bool Delete(long Id);

        //Web
        public List<Footer> GetItemFooter();
    }
}
