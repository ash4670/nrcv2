using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("win_titles")]
    public partial class WinTitle
    {
        [Key]
        [Column("win_id")]
        [StringLength(50)]
        public string WinId { get; set; }
        [Column("win_title")]
        [StringLength(250)]
        public string WinTitle1 { get; set; }
    }
}
