using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class OrderView
    {
        public Order order { get; set; }
        public Account admin { get; set; }
        public Customer customer { get; set; }
        public OrderStatus orderStatus { get; set; }
        public DistrictView districtViews { get; set; }
    }
}
