using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Models.ViewModel
{
    public class CartItemView
    {
        public Order order { get; set; }
        public OrderDetail orderDetail { get; set; }
    }
}
