using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    public partial class TklfSubTotRelated
    {
        [Column("KIND_CODE")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("TKLFSUB_CODE")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("TOT_RELATED")]
        public double? TotRelated { get; set; }
    }
}
