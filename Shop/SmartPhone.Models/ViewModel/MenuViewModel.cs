using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class MenuViewModel
    {
        public Menu menu { get; set; }
        public List<Menu> subMenu { get; set; }
    }
}
