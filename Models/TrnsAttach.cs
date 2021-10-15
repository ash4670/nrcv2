using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("trns_attach")]
    public partial class TrnsAttach
    {
        [Key]
        [Column("trns_code")]
        [StringLength(2)]
        public string TrnsCode { get; set; }
        [Key]
        [Column("trns_no")]
        [StringLength(10)]
        public string TrnsNo { get; set; }
        [Key]
        [Column("docname")]
        [StringLength(100)]
        public string Docname { get; set; }
        [Column("t_attach", TypeName = "image")]
        public byte[] TAttach { get; set; }
    }
}
