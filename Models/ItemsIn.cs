using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class ItemsIn
    {
        public string StockCode { get; set; }
        public string ItemCode { get; set; }
        public double? TotIn { get; set; }
    }
}
