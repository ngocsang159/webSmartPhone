using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Services
{
    public interface IConfigService
    {
        //Admin
        public Config GetConfig();
        public bool Edit(Config config);

        //Web

        public List<Config> GetDataFooter();
    }
}
