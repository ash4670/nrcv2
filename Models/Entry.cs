using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Entry
    {
        public string UserName { get; set; }
        public string UserAmr { get; set; }
        public decimal? UserId { get; set; }
        public decimal? Locked { get; set; }
        public decimal? GroupId { get; set; }
        public decimal AmrId { get; set; }
        public string B { get; set; }
        public string T { get; set; }
        public string R { get; set; }
        public string S { get; set; }

        public virtual Group Group { get; set; }
    }
}
