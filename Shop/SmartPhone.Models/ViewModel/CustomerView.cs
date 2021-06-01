using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Models.ViewModel
{
    public class CustomerView
    {
       
        public Customer customer { get; set; }
        public DistrictView districtViews { get; set; }
    }
}
