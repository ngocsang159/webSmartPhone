using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class CartViewModel
    {
        public Product product { get; set; }
        public MasterDatum color { get; set; }
        public int Quantity { get; set; }
        public decimal? PriceShip { get; set; }

    }
}
