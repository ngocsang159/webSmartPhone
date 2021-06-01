using SmartPhone.Commons;
using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        /// <summary>
        /// 202 : lỗi bị trùng
        /// 200: thêm  sửa thành công
        /// 201 : thêm sửa thất bại
        /// </summary>
        /// <param name="product"></param>
        /// <param name="CategoryId"></param>
        /// <param name="productColors"></param>
        /// <param name="productImages"></param>
        /// <returns></returns>
        public int AddOrUpdate(Product product, long CategoryId, List<ProductColor> productColors, List<ProductImage> productImages)
        {
            if (product.Id == 0)
            {
                var data = db.Products.Where(n => n.Code == product.Code).FirstOrDefault();
                if (data != null)
                {
                    return 202;
                }
                product.Slug = Constant.ConvertString(product.Name);
                product.CategoryId = CategoryId;
                product.Like = 0;
                product.View = 0;
                product.CreatedDate = DateTime.Now;
                product.IsDelete = false;
                db.Products.Add(product);
                db.SaveChanges();
                var Id = db.Products.OrderByDescending(x => x.Id).FirstOrDefault().Id;
                if (productColors != null)
                {
                    productColors = productColors.Select(x => { x.ProductId = Id; return x; }).ToList();
                    db.ProductColors.AddRange(productColors);
                    db.SaveChanges();
                }
                if (productImages != null)
                {
                    productImages = productImages.Select(x => { x.ProductId = Id; return x; }).ToList();
                    db.ProductImages.AddRange(productImages);
                    db.SaveChanges();
                }
            }
            else
            {
                var pro = db.Products.Find(product.Id);
                var data = db.Products.Where(n => n.Code == product.Code && n.Id != product.Id).FirstOrDefault();
                if (data != null)
                {
                    return 202;
                }
                pro.Code = product.Code;
                pro.Name = product.Name;
                pro.Slug = Constant.ConvertString(product.Name);
                pro.Image = product.Image;
                pro.Price = product.Price;
                pro.PriceSale = product.PriceSale;
                pro.Description = product.Description;
                pro.Content = product.Content;
                pro.IsHot = product.IsHot;
                pro.OldNew = product.OldNew;
                pro.Total = product.Total;
                pro.Type = product.Type;
                pro.Position = product.Position;
                pro.Gift = product.Gift;
                pro.BrandId = product.BrandId;
                pro.UpdatedBy = product.UpdatedBy;
                pro.UpdatedDate = DateTime.Now;
                pro.Status = product.Status;
                db.SaveChanges();
                var Id = product.Id;
                // xóa các dữ liệu cũ
                db.ProductImages.RemoveRange(db.ProductImages.Where(x => x.ProductId == Id).ToList());
          
                db.ProductColors.RemoveRange(db.ProductColors.Where(x => x.ProductId == Id).ToList());

                if (productColors != null)
                {
                    productColors = productColors.Select(x => { x.ProductId = Id; return x; }).ToList();
                    db.ProductColors.AddRange(productColors);
                    db.SaveChanges();
                }
                if (productImages != null)
                {
                    productImages = productImages.Select(x => { x.ProductId = Id; return x; }).ToList();
                    db.ProductImages.AddRange(productImages);
                    db.SaveChanges();
                }
            }
            return 200;
        }

        public bool DeleteProduct(long Id)
        {
            var data = db.Products.Find(Id);
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        public CategoryProduct GetCategoryProduct(long Id)
        {
            return db.CategoryProducts.Find(Id);
        }

        public MasterDatum GetItemByID(long Id)
        {
            return db.MasterData.Find(Id);
        }

        public List<ProductImage> GetListImageProduct(long ProductId)
        {
            return db.ProductImages.Where(n => n.ProductId == ProductId).ToList();

        }

        public List<MasterDatum> GetListItem(long ParentId)
        {
            return db.MasterData.Where(n=>n.ParentId ==ParentId).ToList();
        }
        
        public ResponseDataAdmin<Product> GetListProductByCategoryById(GetViewData getViewData, long CategoryId)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;

            var data = db.Products.Where(x => x.CategoryId == CategoryId && x.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Products.Where(x => x.CategoryId == CategoryId && x.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Products.Where(x => (x.Code.ToLower().Contains(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower()) || x.Price.ToString().ToLower().Equals(search.ToLower())) && x.CategoryId == CategoryId && x.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Products.Where(x => (x.Code.ToLower().Contains(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower()) || x.Price.ToString().ToLower().Equals(search.ToLower())) && x.CategoryId == CategoryId && x.IsDelete == false).Count();
            }

            ResponseDataAdmin<Product> dataProduct = new ResponseDataAdmin<Product>();
            dataProduct.data = data;
            dataProduct.pageNumber = pageNumber;
            dataProduct.pageSize = pageSize;
            dataProduct.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataProduct.Total = total;
            return dataProduct;
        }

        public List<ProductColor> GetListProductColor(long ProductId)
        {
            var data = db.ProductColors.Where(n => n.ProductId == ProductId).ToList();
            return data;
        }

        public Product GetProductByID(long Id)
        {
            return db.Products.Find(Id);
        }
        //web
        //Hompage
        public List<Product> GetListProductHot()
        {
            return db.Products.Where(n => n.IsHot == 1 && n.Status == 1 && n.IsDelete == false).OrderBy(n=>n.Position).ToList();
        }
        public List<Product> GetListProductByCategory(long CategoryId)
        {
            return db.Products.Where(n => n.CategoryId == CategoryId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
        }

        //ProductPage
        public ResponseDataAdmin<Product> GetListProductAll(long CategoryId, int OrderBy, int PageNumber, int PageSize)
        {
            List<Product> data;
            int total = 0;
            if(CategoryId == 0)
            {
                data = db.Products.Where(n => n.Status == 1 && n.IsDelete == false&& n.Type == 1).OrderBy(n => n.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                total = db.Products.Where(n => n.Status == 1 && n.Type == 1 && n.IsDelete == false).Count();
            }
            else
            {
                data = db.Products.Where(n =>n.CategoryId == CategoryId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                total = db.Products.Where(n => n.CategoryId == CategoryId && n.Status == 1 && n.IsDelete == false).Count();
            }
            if(OrderBy == 1)
            {
                data = data.OrderBy(n => n.Name).ToList();
            }
            else if (OrderBy == 2)
            {
                data = data.OrderByDescending(n => n.Name).ToList();
            }
            else if (OrderBy == 3)
            {
                data = data.OrderByDescending(n => n.PriceSale).ToList();

            }
            else if (OrderBy == 4)
            {
                data = data.OrderBy(n => n.PriceSale).OrderBy(n=>n.Price).ToList();
            }
            ResponseDataAdmin<Product> dataProduct = new ResponseDataAdmin<Product>();
            dataProduct.data = data;
            dataProduct.pageNumber = PageNumber;
            dataProduct.pageSize = PageSize;
            dataProduct.pageCount = total % PageSize == 0 ? total / PageSize : total / PageSize + 1;
            dataProduct.Total = total;
            return dataProduct;
        }
        public ResponseDataAdmin<Product> GetListProductAccessries(long CategoryId, int OrderBy, int PageNumber, int PageSize)
        {
            List<Product> data;
            int total = 0;
            if (CategoryId == 0)
            {
                data = db.Products.Where(n => n.Status == 1 && n.IsDelete == false && n.Type == 0).OrderBy(n => n.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                total = db.Products.Where(n => n.Status == 1 && n.Type == 0 && n.IsDelete == false).Count();
            }
            else
            {
                data = db.Products.Where(n => n.CategoryId == CategoryId && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                total = db.Products.Where(n => n.CategoryId == CategoryId && n.Status == 1 && n.IsDelete == false).Count();
            }
            if (OrderBy == 1)
            {
                data = data.OrderBy(n => n.Name).ToList();
            }
            else if (OrderBy == 2)
            {
                data = data.OrderByDescending(n => n.Name).ToList();
            }
            else if (OrderBy == 3)
            {
                data = data.OrderByDescending(n => n.PriceSale).ToList();

            }
            else if (OrderBy == 4)
            {
                data = data.OrderBy(n => n.PriceSale).OrderBy(n => n.Price).ToList();
            }
            ResponseDataAdmin<Product> dataProduct = new ResponseDataAdmin<Product>();
            dataProduct.data = data;
            dataProduct.pageNumber = PageNumber;
            dataProduct.pageSize = PageSize;
            dataProduct.pageCount = total % PageSize == 0 ? total / PageSize : total / PageSize + 1;
            dataProduct.Total = total;
            return dataProduct;
        }
        public ResponseDataAdmin<Product> GetListProductSearch(long CategoryId, int OrderBy, int PageNumber, int PageSize, string search)
        {
            List<Product> data;
            int total = 0;
            if (!string.IsNullOrEmpty(search))
            {
                if (CategoryId == 0)
                {
                    data = db.Products.Where(x => x.Name.Contains(search) && x.Status == 1 && x.IsDelete == false).OrderBy(x => x.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                    total = db.Products.Where(x => x.Status == 1 && x.IsDelete == false && x.Name.Contains(search)).Count();
                }
                else
                {
                    data = db.Products.Where(x => x.CategoryId == CategoryId && x.Name.Contains(search) && x.Status == 1 && x.IsDelete == false).OrderBy(x => x.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                    total = db.Products.Where(x => x.CategoryId == CategoryId && x.Name.Contains(search) && x.Status == 1 && x.IsDelete == false).Count();
                }


            }
            else
            {
                data = db.Products.Where(x => x.Status == 1 && x.IsDelete == false).OrderBy(x => x.Position).Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
                total = db.Products.Where(x => x.Status == 1 && x.IsDelete == false).Count();

            }
            if (OrderBy == 1)
            {
                data = data.OrderBy(x => x.Name).ToList();
            }
            else if (OrderBy == 2)
            {
                data = data.OrderByDescending(x => x.Name).ToList();
            }
            else if (OrderBy == 3)
            {
                data = data.OrderByDescending(x => x.PriceSale).ToList();

            }
            else if (OrderBy == 4)
            {
                data = data.OrderBy(x => x.PriceSale).ToList();
            }
            else if (OrderBy == 5)
            {
                data = data.OrderBy(x => x.CreatedDate).ToList();
            }
            else if (OrderBy == 6)
            {
                data = data.OrderByDescending(x => x.CreatedDate).ToList();

            }

            ResponseDataAdmin<Product> dataProduct = new ResponseDataAdmin<Product>();
            dataProduct.data = data;
            dataProduct.pageNumber = PageNumber;
            dataProduct.pageSize = PageSize;
            dataProduct.pageCount = total % PageSize == 0 ? total / PageSize : total / PageSize + 1;
            dataProduct.Total = total;
            return dataProduct;
        }
    }
}
