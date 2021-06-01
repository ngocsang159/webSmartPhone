using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.ViewModel;
namespace SmartPhone.Services
{
    public interface IBannerService
    {
        //admin
        public Banner GetBannerByID(long Id);
        public ResponseDataAdmin<BannerProductView> GetListBanner(GetViewData getViewData);

        public bool AddOrUpdate(Banner banner);
        public bool DeleteById(long Id);

        public List<Product> GetListProduct();
        //web

        public List<Banner> GetListViewBanner();
    }
}
