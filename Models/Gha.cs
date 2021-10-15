using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("GHA")]
    public partial class Gha
    {
        [Column("GHA_CODE")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("GHA_NAME")]
        [StringLength(50)]
        public string GhaName { get; set; }
        [Column("TABL_NAME")]
        [StringLength(25)]
        public string TablName { get; set; }
    }
}
