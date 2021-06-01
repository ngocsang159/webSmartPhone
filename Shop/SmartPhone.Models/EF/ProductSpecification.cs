using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPhone.Models.EF
{
    public partial class ProductSpecification
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Design { get; set; }
        public string Size { get; set; }
        public string Screen { get; set; }
        public string ScreenResolution { get; set; }
        public string WideScreen { get; set; }
        public string CameraRear { get; set; }
        public string CameraSelfie { get; set; }
        public string Ram { get; set; }
        public string CardMemory { get; set; }
        public string Memory { get; set; }
        public string Cpu { get; set; }
        public string SpeedCpu { get; set; }
        public string Gpu { get; set; }
        public string Battery { get; set; }
        public string Sim { get; set; }
        public string Network { get; set; }
        public string ChargingPort { get; set; }
        public string JackHeadphone { get; set; }
        public string Os { get; set; }
        public string MadeIn { get; set; }
        public DateTime? LaunchTime { get; set; }
        public long? ProductId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
