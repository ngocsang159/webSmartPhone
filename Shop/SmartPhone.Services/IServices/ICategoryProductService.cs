using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public interface ICategoryProductService
    {
        //admin
        public ResponseDataAdmin<CategoryProduct> GetListCategory(GetViewData getViewData);
        public CategoryProduct GetCategoryProductByID(long Id);
        public int AddOrUpdate(CategoryProduct categoryProduct);
        public bool DeleteCategory(long Id);

        //web
        public List<CategoryProduct> GetListCategoryProduct();

        public CategoryProduct GetCategoryProduct();

    }
}
