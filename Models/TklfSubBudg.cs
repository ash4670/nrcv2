using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    public partial class TklfSubBudg
    {
        [Required]
        [Column("KIND_CODE")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Required]
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Required]
        [Column("TKLFSUB_CODE")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("BUDGET")]
        public double? Budget { get; set; }
    }
}
