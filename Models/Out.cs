using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("OUTS")]
    [Index(nameof(OutCode), Name = "OUTS_idx", IsUnique = true)]
    public partial class Out
    {
        [Required]
        [Column("OUT_CODE")]
        [StringLength(4)]
        public string OutCode { get; set; }
        [Column("OUT_NAME")]
        [StringLength(50)]
        public string OutName { get; set; }
        [Column("OUT_TYPE")]
        [StringLength(1)]
        public string OutType { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
