using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class OrderDetailView
    {
        public OrderDetail orderDetail { get; set; }
        public Product product { get; set; }
        public MasterDatum color { get; set; }
    }
}
