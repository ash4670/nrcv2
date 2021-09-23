using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class ItemsOut
    {
        public string StockCode { get; set; }
        public string ItemCode { get; set; }
        public double? TotOut { get; set; }
    }
}
