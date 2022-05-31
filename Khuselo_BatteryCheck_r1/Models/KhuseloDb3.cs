using System;
using System.Collections.Generic;

namespace Khuselo_BatteryCheck_r1.Models
{
    public partial class KhuseloDb3
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public DateTime DatePurchased { get; set; }
        public DateTime? DateExpired { get; set; }
        public string? Lifespan { get; set; }
        public string? Location { get; set; }
        public string? TechName { get; set; }
        public int? TechCell { get; set; }
        public string? Branch { get; set; }
        public string? ChargeCycles { get; set; }
        public string? DateInstalled { get; set; }
    }
}
