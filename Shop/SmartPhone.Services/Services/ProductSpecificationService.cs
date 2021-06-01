using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public class ProductSpecificationService : GenericService<ProductSpecification>, IProductSpecificationService
    {

        public ResponseDataAdmin<ProductSpecification> GetListSpecification(GetViewData getViewData, long ProductId)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;

            var data = db.ProductSpecifications.Where(n => n.IsDelete == false && n.ProductId == ProductId).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.ProductSpecifications.Where(n => n.IsDelete == false && n.ProductId == ProductId).Count();

            if (!string.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.ProductSpecifications.Where(n => n.IsDelete == false && n.ProductId == ProductId && n.Name.ToLower().Contains(search.ToLower())).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.ProductSpecifications.Where(n => n.IsDelete == false && n.ProductId == ProductId && n.Name.ToLower().Contains(search.ToLower())).Count();
            }
            ResponseDataAdmin<ProductSpecification> dataSpecification = new ResponseDataAdmin<ProductSpecification>();
            dataSpecification.data = data;
            dataSpecification.pageSize = pageSize;
            dataSpecification.pageNumber = pageNumber;
            dataSpecification.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataSpecification;

        }

        public ProductSpecification GetSpecificationById(long Id)
        {
            return db.ProductSpecifications.Find(Id);
        }
        public bool AddOrUpdate(ProductSpecification productSpecification, long ProductId)
        {
            if (productSpecification != null)
            {
                var obj = db.ProductSpecifications.Find(productSpecification.Id);
                if (productSpecification.Id == productSpecification.Id && obj.ProductId != ProductId)
                {
                    productSpecification.Id = 0;
                    productSpecification.ProductId = ProductId;
                    productSpecification.CreatedDate = DateTime.Now;
                    productSpecification.IsDelete = false;
                    db.ProductSpecifications.Add(productSpecification);
                    db.SaveChanges();
                }
                else
                {
                    obj.Name = productSpecification.Name;
                    obj.Design = productSpecification.Design;
                    obj.Size = productSpecification.Size;
                    obj.Screen = productSpecification.Screen;
                    obj.ScreenResolution = productSpecification.ScreenResolution;
                    obj.WideScreen = productSpecification.WideScreen;
                    obj.CameraRear = productSpecification.CameraRear;
                    obj.CameraSelfie = productSpecification.CameraSelfie;
                    obj.Ram = productSpecification.Ram;
                    obj.Memory = productSpecification.Memory;
                    obj.CardMemory = productSpecification.CardMemory;
                    obj.Cpu = productSpecification.Cpu;
                    obj.SpeedCpu = productSpecification.SpeedCpu;
                    obj.Gpu = productSpecification.Gpu;
                    obj.Battery = productSpecification.Battery;
                    obj.ChargingPort = productSpecification.ChargingPort;
                    obj.JackHeadphone = productSpecification.JackHeadphone;
                    obj.Sim = productSpecification.Sim;
                    obj.Network = productSpecification.Network;
                    obj.Os = productSpecification.Os;
                    obj.MadeIn = productSpecification.MadeIn;
                    obj.LaunchTime = productSpecification.LaunchTime;
                    productSpecification.ProductId = ProductId;
                    obj.ProductId = productSpecification.ProductId;
                    obj.Status = productSpecification.Status;
                    obj.UpdatedDate = DateTime.Now;
                    obj.UpdatedBy = productSpecification.UpdatedBy;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteById(long Id)
        {
            var data = db.ProductSpecifications.Where(n => n.Id == Id).FirstOrDefault();
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        public ProductSpecification GetProductSpecificationByProductId(long ProductId)
        {
            return db.ProductSpecifications.Where(n=>n.ProductId == ProductId).FirstOrDefault();
        }
        public ProductSpecification GetProductSpecification()
        {
            return db.ProductSpecifications.FirstOrDefault();
        }
        public bool Edit(ProductSpecification productSpecification)
        {
            var obj = db.ProductSpecifications.Find(productSpecification.Id);
            obj.Name = productSpecification.Name;
            obj.Design = productSpecification.Design;
            obj.Size = productSpecification.Size;
            obj.Screen = productSpecification.Screen;
            obj.ScreenResolution = productSpecification.ScreenResolution;
            obj.WideScreen = productSpecification.WideScreen;
            obj.CameraRear = productSpecification.CameraRear;
            obj.CameraSelfie = productSpecification.CameraSelfie;
            obj.Ram = productSpecification.Ram;
            obj.Memory = productSpecification.Memory;
            obj.CardMemory = productSpecification.CardMemory;
            obj.Cpu = productSpecification.Cpu;
            obj.SpeedCpu = productSpecification.SpeedCpu;
            obj.Gpu = productSpecification.Gpu;
            obj.Battery = productSpecification.Battery;
            obj.ChargingPort = productSpecification.ChargingPort;
            obj.JackHeadphone = productSpecification.JackHeadphone;
            obj.Sim = productSpecification.Sim;
            obj.Network = productSpecification.Network;
            obj.Os = productSpecification.Os;
            obj.MadeIn = productSpecification.MadeIn;
            obj.LaunchTime = productSpecification.LaunchTime;
            obj.ProductId = productSpecification.ProductId;
            obj.UpdatedDate = DateTime.Now;
            obj.UpdatedBy = productSpecification.UpdatedBy;
            db.SaveChanges();
            return true;
        }
    }
}
