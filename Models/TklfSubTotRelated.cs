using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class TklfSubTotRelated
    {
        public string KindCode { get; set; }
        public string TklfCode { get; set; }
        public string TklfsubCode { get; set; }
        public double? TotRelated { get; set; }
    }
}
