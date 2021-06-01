using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Web.Models.EF
{
    public partial class Product
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceSale { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int? IsHot { get; set; }
        public int? OldNew { get; set; }
        public int? Total { get; set; }
        public int? Buyed { get; set; }
        public int? Like { get; set; }
        public int? View { get; set; }
        public int? Position { get; set; }
        public string Gift { get; set; }
        public long? CategoryId { get; set; }
        public long? BrandId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
