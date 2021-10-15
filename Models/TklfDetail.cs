using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("TKLF_DETAIL")]
    [Index(nameof(KindCode), nameof(TklfCode), nameof(TklfsubCode), nameof(OutCode), Name = "TKLFdetail_idx", IsUnique = true)]
    public partial class TklfDetail
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
        [Required]
        [Column("OUT_CODE")]
        [StringLength(4)]
        public string OutCode { get; set; }
        [Column("VALUE")]
        public double? Value { get; set; }
        [Column("project")]
        [StringLength(60)]
        public string Project { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TKLFSUBid")]
        public int? Tklfsubid { get; set; }

        [ForeignKey(nameof(Tklfsubid))]
        [InverseProperty("TklfDetails")]
        public virtual Tklfsub Tklfsub { get; set; }
    }
}
