using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Group
    {
        public Group()
        {
            Entries = new HashSet<Entry>();
        }

        public decimal GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
