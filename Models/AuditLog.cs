using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("audit_log")]
    public partial class AuditLog
    {
        [Key]
        [Column("user_id")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Key]
        [Column("app_id")]
        [StringLength(20)]
        public string AppId { get; set; }
        [Key]
        [Column("win_id")]
        [StringLength(50)]
        public string WinId { get; set; }
        [Key]
        [Column("data_key")]
        [StringLength(250)]
        public string DataKey { get; set; }
        [Column("op")]
        [StringLength(3)]
        public string Op { get; set; }
        [Key]
        [Column("upd_stamp", TypeName = "datetime")]
        public DateTime UpdStamp { get; set; }
        [Column("remarks")]
        [StringLength(500)]
        public string Remarks { get; set; }
    }
}
