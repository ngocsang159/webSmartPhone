using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Web.Models.EF
{
    public partial class New
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public int? Views { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public long? ParentId { get; set; }
        public int? Position { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdateBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
