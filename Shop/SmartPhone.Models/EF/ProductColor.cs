using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Models.EF
{
    public partial class ProductColor
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long? MasterColorId { get; set; }
    }
}
