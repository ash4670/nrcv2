using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    public partial class VGehaIssue
    {
        [Column("gha_code")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("gha_main")]
        [StringLength(4)]
        public string GhaMain { get; set; }
        [Column("gha_num")]
        [StringLength(4)]
        public string GhaNum { get; set; }
        [Column("val")]
        public double? Val { get; set; }
    }
}
