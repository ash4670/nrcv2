using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("TKLF")]
    public partial class Tklf
    {
        [Column("KIND_CODE")]
        public byte? KindCode { get; set; }
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("TKLF_NAME")]
        [StringLength(60)]
        public string TklfName { get; set; }
    }
}
