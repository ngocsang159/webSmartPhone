using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class DistrictView
    {
        public District district { get; set; }
        public Province provinces { get; set; }
    }
}
