using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("TKLFMAIN")]
    [Index(nameof(KindCode), nameof(TklfCode), Name = "TKLFMAIN_idx", IsUnique = true)]
    public partial class Tklfmain
    {
        public Tklfmain()
        {
            Tklfsubs = new HashSet<Tklfsub>();
        }

        [Required]
        [Column("KIND_CODE")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Required]
        [Column("TKLF_CODE")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("TKLF_NAME")]
        [StringLength(120)]
        public string TklfName { get; set; }
        [Column("COST")]
        public double? Cost { get; set; }
        [Column("shobacode")]
        [StringLength(4)]
        public string Shobacode { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [InverseProperty(nameof(Tklfsub.Tklfmain))]
        public virtual ICollection<Tklfsub> Tklfsubs { get; set; }
    }
}
