using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("TKLFSUB")]
    [Index(nameof(KindCode), nameof(TklfCode), nameof(TklfsubCode), Name = "TKLFSUB_idx", IsUnique = true)]
    public partial class Tklfsub
    {
        public Tklfsub()
        {
            TklfDetails = new HashSet<TklfDetail>();
        }

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
        [Column("TKLFSUB_NAME")]
        [StringLength(60)]
        public string TklfsubName { get; set; }
        [Column("COST")]
        public double? Cost { get; set; }
        [Column("TAZIZ")]
        public double? Taziz { get; set; }
        [Column("NAME1")]
        [StringLength(50)]
        public string Name1 { get; set; }
        [Column("NAME2")]
        [StringLength(50)]
        public string Name2 { get; set; }
        [Column("name3")]
        [StringLength(100)]
        public string Name3 { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TKLFMAINid")]
        public int Tklfmainid { get; set; }

        [ForeignKey(nameof(Tklfmainid))]
        [InverseProperty("Tklfsubs")]
        public virtual Tklfmain Tklfmain { get; set; }
        [InverseProperty(nameof(TklfDetail.Tklfsub))]
        public virtual ICollection<TklfDetail> TklfDetails { get; set; }
    }
}
