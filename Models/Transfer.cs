using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Transfer
    {
        public string OutStock { get; set; }
        public string AddStock { get; set; }
        public string OldItem { get; set; }
        public string NewItem { get; set; }
        public double? Quantity { get; set; }
        public string TrnNo { get; set; }
        public DateTime? TrnDate { get; set; }
    }
}
