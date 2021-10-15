using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("tklfsubo")]
    public partial class Tklfsubo
    {
        [Key]
        [Column("kind_code")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Key]
        [Column("tklf_code")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Key]
        [Column("tklfsub_code")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("tklfsub_name")]
        [StringLength(60)]
        public string TklfsubName { get; set; }
        [Column("cost")]
        public double? Cost { get; set; }
        [Column("taziz")]
        public double? Taziz { get; set; }
        [Column("name1")]
        [StringLength(50)]
        public string Name1 { get; set; }
        [Column("name2")]
        [StringLength(50)]
        public string Name2 { get; set; }
        [Column("name3")]
        [StringLength(100)]
        public string Name3 { get; set; }
    }
}
