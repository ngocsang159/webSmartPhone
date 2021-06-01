using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class BannerProductView
    {
        public Banner banner { get; set; }
        public Product product { get; set; }
    }
}
