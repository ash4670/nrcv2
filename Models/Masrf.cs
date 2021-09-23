using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Masrf
    {
        public int Id { get; set; }
        public string KindCode { get; set; }
        public string TklfCode { get; set; }
        public string TklfsubCode { get; set; }
        public string OutCode { get; set; }
        public double? Value { get; set; }
        public DateTime? OutDate { get; set; }
        public int? No { get; set; }
        public string Project { get; set; }
    }
}
