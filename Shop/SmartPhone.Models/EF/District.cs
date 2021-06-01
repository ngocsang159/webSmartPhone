using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Models.EF
{
    public partial class District
    {
        public long Stt { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ProvinceId { get; set; }
        public int? Status { get; set; }
        public bool? IsDelete { get; set; }
    }
}
