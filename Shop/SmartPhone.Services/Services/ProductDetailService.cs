using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Commons;
using SmartPhone.Models.EF;
namespace SmartPhone.Services
{
    public class ProductDetailService : GenericService<Product>, IProductDetailService
    {
        //lấy danh mục sản phẩm cho sản phẩm
        public CategoryProduct GetCategoryOfProduct(long productId)
        {
            var CateId = db.Products.Find(productId);
            return db.CategoryProducts.Find(CateId.CategoryId);
        }

        public List<ProductImage> GetImageOfProduct(long ProducId)
        {
            return db.ProductImages.Where(n => n.ProductId == ProducId).ToList();
        }

        public List<MasterDatum> GetListColorOfProduct(long ProductId)
        {
            List<MasterDatum> data = new List<MasterDatum>();
            var color = db.ProductColors.Where(n => n.ProductId == ProductId).ToList();
            foreach(var item in color)
            {
                data.Add(db.MasterData.Where(n => n.Id == item.MasterColorId).FirstOrDefault());
            }
            return data;
        }

        public List<ImageInPage> GetListImagePage()
        {
            var display = Constant.PRODUCTDETAIL;
            return db.ImageInPages.Where(n => n.LocationId == display && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
        }

        public List<Product> GetListProductSample(long ProductId)
        {
            var obj = db.Products.Find(ProductId);
            if (obj != null)
            {
                return db.Products.Where(n=>n.CategoryId == obj.CategoryId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
            }    
            return null;
        }

        public MasterDatum GetMasterById(long Id)
        {
            return db.MasterData.Find(Id);
        }

        public Product GetProductId(long Id)
        {
            var obj = db.Products.Find(Id);
            if (obj.View == null)
                obj.View = 1;
            else
                obj.View = obj.View + 1;
            db.SaveChanges();
            return obj;
        }
        public ProductSpecification GetProductSpecification(long productId)
        {
            var obj = db.Products.Find(productId);
            return db.ProductSpecifications.Where(n => n.ProductId == obj.Id && n.IsDelete == false).FirstOrDefault();
        }
        public bool LikeProduct(long Id)
        {
            try
            {
                var obj = db.Products.Find(Id);
                if (obj.Like == null)
                    obj.Like = 1;
                else
                    obj.Like++;
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public MasterDatum GetColor(long colorId)
        {
            return db.MasterData.Where(n => n.Id == colorId).FirstOrDefault();
        }
    }
}
