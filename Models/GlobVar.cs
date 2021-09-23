using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class GlobVar
    {
        public decimal Id { get; set; }
        public DateTime? Yearstart { get; set; }
        public DateTime? Yearend { get; set; }
    }
}
