using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;


namespace SmartPhone.Services
{
    public interface INewService
    {
        //admin
        public New GetNewById(long Id);
        public ResponseDataAdmin<New> GetListNew(GetViewData getViewData, long ParentId);
        public bool AddOrUpdate(New news, long ParentId);
        public bool DeleteById(long Id);

        // web
        // lây ra danh mục tin tức
        public New GetNewSide();
        public List<New> GetCategoryNew();
        public ResponseDataAdmin<New> GetListNew(long CategoryNewId, int OrderBy, int pageNumber, int pageSize);

        //lẩy ra tin tức bài viết mới nhất
        public List<New> GetListNewSide();

        public New GetNewByIdWeb(long Id);
        public List<New> GetListNewSample(long Id);
        public ResponseDataAdmin<New> GetListNewBySearch(long CategoryNewId, int OrderBy, int pageNumber, int pageSize,string search);

    }  
    
}
