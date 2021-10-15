using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("TAZIZ_TRANS")]
    public partial class TazizTran
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TAZIZ_NO")]
        [StringLength(3)]
        public string TazizNo { get; set; }
        [Column("TAZIZ_DATE", TypeName = "datetime")]
        public DateTime? TazizDate { get; set; }
        [Column("KIND_CODE")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("TKLFSUB_CODE")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("out_code")]
        [StringLength(3)]
        public string OutCode { get; set; }
        [Column("TAZIZ_VAL")]
        public double? TazizVal { get; set; }
        [Column("KIND_CODE2")]
        [StringLength(2)]
        public string KindCode2 { get; set; }
        [Column("TKLF_CODE2")]
        [StringLength(4)]
        public string TklfCode2 { get; set; }
        [Column("TKLFSUB_CODE2")]
        [StringLength(4)]
        public string TklfsubCode2 { get; set; }
        [Column("out_code2")]
        [StringLength(3)]
        public string OutCode2 { get; set; }
    }
}
