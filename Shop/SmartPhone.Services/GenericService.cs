using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public class GenericService<T> where T : class
    {
        protected readonly LanHangContext db;
        public GenericService()
        {
            db = new LanHangContext();
        }
    }
}
