using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public interface IPageImageService
    {
        //admin
        public ImageInPage GetImageById(long Id);
        public ResponseDataAdmin<ImageInPage> GetListImage(GetViewData getViewData,long ParentId);
        public bool DeleteImage(long Id);
        public bool AddOrUpdate(ImageInPage imageInPage, long ParentId);
        public List<MasterDatum> GetListPage();

        //web
        public List<ImageInPage> GetListImageHome();
        public List<ImageInPage> GetListImageProduct();



    }
}
