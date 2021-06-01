using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Web.Models.EF
{
    public partial class CategoryProduct
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public int? Position { get; set; }
        public long? ParentId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
