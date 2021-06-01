using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Models.ViewModel
{
   public  class OrderViewItem
    {
        public Order order { get; set; }
        public OrderDetail orderDetail { get; set; }
        public District district { get; set; }
        public Province provinces { get; set; }
        public MasterDatum color { get; set; }
    }
}
