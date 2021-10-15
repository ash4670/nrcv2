using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("temp")]
    public partial class Temp
    {
        [Column("code")]
        [StringLength(5)]
        public string Code { get; set; }
        [Column("val")]
        public double? Val { get; set; }
        [Column("four")]
        public double? Four { get; set; }
        [Column("net")]
        public double? Net { get; set; }
        [Column("net_more_6")]
        public double? NetMore6 { get; set; }
        [Column("base_sal")]
        public double? BaseSal { get; set; }
    }
}
