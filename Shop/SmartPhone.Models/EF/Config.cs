using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Models.EF
{
    public partial class Config
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string HotLine { get; set; }
        public string Facebook { get; set; }
        public string Zalo { get; set; }
        public string Youtube { get; set; }
        public string Description { get; set; }
        public int? Position { get; set; }
        public string Map { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
