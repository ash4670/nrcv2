using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("arnames")]
    [Index(nameof(ArCode), Name = "arnames_idx", IsUnique = true)]
    public partial class Arname
    {
        [Required]
        [Column("ar_code")]
        [StringLength(20)]
        public string ArCode { get; set; }
        [Required]
        [Column("ar_name")]
        [StringLength(80)]
        public string ArName1 { get; set; }
        [Column("GHA_CODE")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("GHA_MAIN")]
        [StringLength(3)]
        public string GhaMain { get; set; }
        [Column("GHA_NUM")]
        [StringLength(3)]
        public string GhaNum { get; set; }
        [Column("GHA_NAME")]
        [StringLength(50)]
        public string GhaName { get; set; }
        [Column("work")]
        [StringLength(100)]
        public string Work { get; set; }
        [Column("job")]
        [StringLength(50)]
        public string Job { get; set; }
        [Column("bas_sal", TypeName = "numeric(18, 0)")]
        public decimal? BasSal { get; set; }
        [Column("oldcode")]
        [StringLength(5)]
        public string Oldcode { get; set; }
        [Column("nid")]
        [StringLength(20)]
        public string Nid { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
