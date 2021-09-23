using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class VGehaIssue
    {
        public string GhaCode { get; set; }
        public string GhaMain { get; set; }
        public string GhaNum { get; set; }
        public double? Val { get; set; }
    }
}
