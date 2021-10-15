using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("groups")]
    public partial class Group
    {
        public Group()
        {
            Entries = new HashSet<Entry>();
        }

        [Key]
        [Column("group_id", TypeName = "numeric(2, 0)")]
        public decimal GroupId { get; set; }
        [Column("group_name")]
        [StringLength(50)]
        public string GroupName { get; set; }

        [InverseProperty(nameof(Entry.Group))]
        public virtual ICollection<Entry> Entries { get; set; }
    }
}
