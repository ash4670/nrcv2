using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("entries")]
    public partial class Entry
    {
        [Key]
        [Column("user_name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [Column("user_amr")]
        [StringLength(50)]
        public string UserAmr { get; set; }
        [Column("user_id", TypeName = "numeric(4, 0)")]
        public decimal? UserId { get; set; }
        [Column("locked", TypeName = "numeric(1, 0)")]
        public decimal? Locked { get; set; }
        [Column("group_id", TypeName = "numeric(2, 0)")]
        public decimal? GroupId { get; set; }
        [Key]
        [Column("amr_id", TypeName = "numeric(1, 0)")]
        public decimal AmrId { get; set; }
        [Column("b")]
        [StringLength(1)]
        public string B { get; set; }
        [Column("t")]
        [StringLength(1)]
        public string T { get; set; }
        [Column("r")]
        [StringLength(1)]
        public string R { get; set; }
        [Column("s")]
        [StringLength(1)]
        public string S { get; set; }

        [ForeignKey(nameof(GroupId))]
        [InverseProperty("Entries")]
        public virtual Group Group { get; set; }
    }
}
