using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Models.EF
{
    public partial class Banner
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public long? ProductId { get; set; }
        public int? Position { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
