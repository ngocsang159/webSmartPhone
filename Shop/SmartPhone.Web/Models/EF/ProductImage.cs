using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Web.Models.EF
{
    public partial class ProductImage
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public long? ProductId { get; set; }
    }
}
