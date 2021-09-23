using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class AuditLog
    {
        public string UserId { get; set; }
        public string AppId { get; set; }
        public string WinId { get; set; }
        public string DataKey { get; set; }
        public string Op { get; set; }
        public DateTime UpdStamp { get; set; }
        public string Remarks { get; set; }
    }
}
