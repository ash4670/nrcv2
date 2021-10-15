using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("reports")]
    public partial class Report
    {
        [Column("rptno")]
        public byte? Rptno { get; set; }
        [Column("rptname")]
        [StringLength(65)]
        public string Rptname { get; set; }
        [Column("formname")]
        [StringLength(50)]
        public string Formname { get; set; }
        [Column("REPORTNAME")]
        [StringLength(50)]
        public string Reportname { get; set; }
        [Column("GR_NO")]
        public byte? GrNo { get; set; }
        [Column("flag")]
        public byte? Flag { get; set; }
    }
}
