using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("MSysCompactError")]
    public partial class MsysCompactError
    {
        public int? ErrorCode { get; set; }
        [Column(TypeName = "text")]
        public string ErrorDescription { get; set; }
        [MaxLength(255)]
        public byte[] ErrorRecid { get; set; }
        [StringLength(255)]
        public string ErrorTable { get; set; }
    }
}
