using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Taziz
    {
        public int Id { get; set; }
        public string KindCode { get; set; }
        public string TklfCode { get; set; }
        public string TklfsubCode { get; set; }
        public string OutCode { get; set; }
        public string TazizNo { get; set; }
        public double? TazizVal { get; set; }
        public DateTime? TazizDate { get; set; }
    }
}
