using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Stock
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Name1 { get; set; }
        public DateTime? Vdate { get; set; }
    }
}
