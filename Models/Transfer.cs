using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("TRANSFER")]
    public partial class Transfer
    {
        [Column("OUT_STOCK")]
        [StringLength(2)]
        public string OutStock { get; set; }
        [Column("ADD_STOCK")]
        [StringLength(2)]
        public string AddStock { get; set; }
        [Column("OLD_ITEM")]
        [StringLength(5)]
        public string OldItem { get; set; }
        [Column("NEW_ITEM")]
        [StringLength(5)]
        public string NewItem { get; set; }
        [Column("QUANTITY")]
        public double? Quantity { get; set; }
        [Column("TRN_NO")]
        [StringLength(5)]
        public string TrnNo { get; set; }
        [Column("TRN_DATE", TypeName = "datetime")]
        public DateTime? TrnDate { get; set; }
    }
}
