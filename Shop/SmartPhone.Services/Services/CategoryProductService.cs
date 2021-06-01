using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Commons;

namespace SmartPhone.Services
{
    public class CategoryProductService : GenericService<CategoryProduct>, ICategoryProductService
    {
        
        //admin
        public CategoryProduct GetCategoryProductByID(long Id)
        {
            return db.CategoryProducts.Find(Id);
        }

        public ResponseDataAdmin<CategoryProduct> GetListCategory(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string Search = getViewData.Search;

            var data = db.CategoryProducts.Where(n => n.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.CategoryProducts.Where(n => n.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(Search))
            {
                if (Search == null)
                    Search = "";
                Search = Search.Trim();
                data = db.CategoryProducts.Where(x => (x.Name.ToLower().Contains(Search.ToLower()) || x.Code.ToLower().Contains(Search.ToLower())) && x.IsDelete == false).OrderBy(x => x.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.CategoryProducts.Where(x => (x.Name.ToLower().Contains(Search.ToLower()) || x.Code.ToLower().Contains(Search.ToLower())) && x.IsDelete == false).Count();
            }

            ResponseDataAdmin<CategoryProduct> dataCategory = new ResponseDataAdmin<CategoryProduct>();
            dataCategory.data = data;
            dataCategory.pageNumber = pageNumber;
            dataCategory.pageSize = pageSize;
            dataCategory.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataCategory.Total = total;
            return dataCategory;
        }
        /// <summary>
        /// 202 : lỗi bị trùng
        /// 200: thêm  sửa thành công
        /// 201 : thêm sửa thất bại
        /// </summary>
        /// <param name="categoryProduct"></param>
        /// <returns></returns>
        public int AddOrUpdate(CategoryProduct categoryProduct)
        {
            if (categoryProduct != null)
            {
                if (categoryProduct.Id == 0)
                {
                    var data = db.CategoryProducts.Where(n => n.Code == categoryProduct.Code).FirstOrDefault();
                    if (data!=null)
                    {
                        return 202;
                    }    
                    categoryProduct.Slug = Constant.ConvertString(categoryProduct.Name);
                    categoryProduct.IsDelete = false;
                    categoryProduct.CreatedDate = DateTime.Now;
                    db.CategoryProducts.Add(categoryProduct);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.CategoryProducts.Find(categoryProduct.Id);
                    var data = db.CategoryProducts.Where(n => n.Code == categoryProduct.Code && n.Id != categoryProduct.Id).FirstOrDefault();
                    if (data != null )
                    {
                        return 202;
                    }
                    obj.Code = categoryProduct.Code;
                    obj.Name = categoryProduct.Name;
                    obj.Slug = Constant.ConvertString(obj.Name);
                    obj.Image = categoryProduct.Image;
                    obj.Position = categoryProduct.Position;
                    obj.Status = categoryProduct.Status;
                    obj.UpdatedBy = categoryProduct.UpdatedBy;
                    obj.UpdatedDate = DateTime.Now;
                    db.SaveChanges();
                }
                return 200;
            }
            else
            {
                return 201;
            }
    }

        public bool DeleteCategory(long Id)
        {
            var data = db.CategoryProducts.Find(Id);
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }
        //web
        //Lấy danh sách danh mục sản phẩm
        public List<CategoryProduct> GetListCategoryProduct()
        {
            return db.CategoryProducts.Where(n => n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
        }

        public CategoryProduct GetCategoryProduct()
        {
            return db.CategoryProducts.Where(n => n.Status == 1 && n.IsDelete == false).FirstOrDefault();
        }    
    }
}
