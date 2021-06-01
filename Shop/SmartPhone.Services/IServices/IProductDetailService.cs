using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;


namespace SmartPhone.Services
{
    public interface IProductDetailService
    {
        public Product GetProductId(long Id);
        public MasterDatum GetColor(long colorId);
        public List<ProductImage> GetImageOfProduct(long ProducId);
        public MasterDatum GetMasterById(long Id);
        public List<MasterDatum> GetListColorOfProduct(long ProductId);
        public List<ImageInPage> GetListImagePage();
        public List<Product> GetListProductSample(long ProductId);
        public CategoryProduct GetCategoryOfProduct(long productId);
        public ProductSpecification GetProductSpecification(long productId);
        public bool LikeProduct(long Id);

    }
}
