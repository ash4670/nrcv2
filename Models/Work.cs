using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("work")]
    [Index(nameof(WCode), Name = "work_idx", IsUnique = true)]
    public partial class Work
    {
        [Column("w_code")]
        public int WCode { get; set; }
        [Column("w_name")]
        [StringLength(100)]
        public string WName { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
