using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public class ConfigService : GenericService<Config>, IConfigService
    {
        //admin
        public bool Edit(Config config)
        {
            var obj = db.Configs.Find(config.Id);
            obj.Name = config.Name;
            obj.Logo = config.Logo;
            obj.Phone = config.Phone;
            obj.Email = config.Email; 
            obj.Address = config.Address;
            obj.HotLine = config.HotLine;
            obj.Phone = config.Phone;
            obj.Facebook = config.Facebook; 
            obj.Zalo = config.Zalo;
            obj.Youtube = config.Youtube;
            obj.Description = config.Description;
            obj.Position = config.Position; 
            obj.Map = config.Map;
            obj.Status = 1;
            obj.CreatedDate = DateTime.Now;
            obj.CreateBy = config.CreateBy;
            obj.UpdateDate = DateTime.Now;
            obj.UpdateBy = config.UpdateBy;
            db.SaveChanges();

            return true;
        }

        public Config GetConfig()
        {
            return db.Configs.FirstOrDefault();
        }

        //Web
        public List<Config> GetDataFooter()
        {
            return db.Configs.Where(n => n.Status == 1 && n.IsDelete == false).ToList();
        }
    }
}
