using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("Related")]
    public partial class Related
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("KIND_CODE")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("TKLFSUB_CODE")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("OUT_CODE")]
        [StringLength(4)]
        public string OutCode { get; set; }
        [Column("VALUE")]
        public double? Value { get; set; }
        [Column("OUT_DATE", TypeName = "datetime")]
        public DateTime? OutDate { get; set; }
        [Column("no")]
        public int? No { get; set; }
    }
}
