using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Report
    {
        public byte? Rptno { get; set; }
        public string Rptname { get; set; }
        public string Formname { get; set; }
        public string Reportname { get; set; }
        public byte? GrNo { get; set; }
        public byte? Flag { get; set; }
    }
}
