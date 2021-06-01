using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public interface IProductSpecificationService
    {
        public ProductSpecification GetSpecificationById(long Id);
        public ResponseDataAdmin<ProductSpecification> GetListSpecification(GetViewData getViewData,long ProductId);
        public bool AddOrUpdate(ProductSpecification productSpecification, long ProductId);
        public bool DeleteById(long Id);
        

        public ProductSpecification GetProductSpecificationByProductId(long ProductId);
        public ProductSpecification GetProductSpecification();
        public bool Edit(ProductSpecification productSpecification);

    }
}
