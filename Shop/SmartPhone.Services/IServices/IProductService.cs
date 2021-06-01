using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
namespace SmartPhone.Services
{
   public interface IProductService
    {
        public ResponseDataAdmin<Product> GetListProductByCategoryById(GetViewData getViewData, long CategoryId);
        public List<MasterDatum> GetListItem(long ParentId);
        public MasterDatum GetItemByID(long Id);
        public List<ProductColor> GetListProductColor(long ProductId);
        public int AddOrUpdate(Product product, long CategoryId, List<ProductColor> productColors, List<ProductImage> productImages);
        public bool DeleteProduct(long Id);
        public CategoryProduct GetCategoryProduct(long Id);
        public Product GetProductByID(long Id);
        public List<ProductImage> GetListImageProduct(long ProductId);

        //Web
        //HomePage
        public List<Product> GetListProductHot();

        public List<Product> GetListProductByCategory(long CategoryId);

        //ProductPage
        public ResponseDataAdmin<Product> GetListProductAll(long CategoryId, int OrderBy, int PageNumber, int PageSize);
        public ResponseDataAdmin<Product> GetListProductAccessries(long CategoryId, int OrderBy, int PageNumber, int PageSize);
        public ResponseDataAdmin<Product> GetListProductSearch(long CategoryId, int OrderBy, int PageNumber, int PageSize, string search);

        


    }
}
