using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("DADD")]
    [Index(nameof(LineNo), nameof(Kind), nameof(StockCode), nameof(TrnNo), nameof(TrnYear), nameof(ItemCode), Name = "DADD_idx", IsUnique = true)]
    public partial class Dadd
    {
        [Column("LINE_NO")]
        public int LineNo { get; set; }
        [Column("KIND")]
        public byte Kind { get; set; }
        [Required]
        [Column("stock_code")]
        [StringLength(2)]
        public string StockCode { get; set; }
        [Required]
        [Column("TRN_NO")]
        [StringLength(10)]
        public string TrnNo { get; set; }
        [Required]
        [Column("TRN_YEAR")]
        [StringLength(4)]
        public string TrnYear { get; set; }
        [Required]
        [Column("ITEM_CODE")]
        [StringLength(5)]
        public string ItemCode { get; set; }
        [Column("ENG_NAME")]
        [StringLength(100)]
        public string EngName { get; set; }
        [Column("EXP_DATE", TypeName = "datetime")]
        public DateTime? ExpDate { get; set; }
        [Column("ITEM_QUANT")]
        public double? ItemQuant { get; set; }
        [Column("ITEM_PRICE")]
        public double? ItemPrice { get; set; }
        [Column("UNIT_NAME")]
        [StringLength(25)]
        public string UnitName { get; set; }
        [Column("TRN_DATE", TypeName = "datetime")]
        public DateTime? TrnDate { get; set; }
        [Column("AR_NAME")]
        [StringLength(5)]
        public string ArName { get; set; }
        [Column("ITEM_DTYPE")]
        public byte? ItemDtype { get; set; }
        [Column("ITEM_DESC")]
        public byte? ItemDesc { get; set; }
        [Column("GHA_CODE")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("GHA_MAIN")]
        [StringLength(4)]
        public string GhaMain { get; set; }
        [Column("GHA_NUM")]
        [StringLength(4)]
        public string GhaNum { get; set; }
        [Column("TRANSFER")]
        public bool Transfer { get; set; }
        [Column("PERC")]
        public double? Perc { get; set; }
        [Column("INC_DEC")]
        public byte? IncDec { get; set; }
        [Column("TEMP_PRICE")]
        public double? TempPrice { get; set; }
        [Column("cost", TypeName = "numeric(20, 9)")]
        public decimal? Cost { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("haddid")]
        public int Haddid { get; set; }

        [ForeignKey(nameof(Haddid))]
        [InverseProperty("Dadds")]
        public virtual Hadd Hadd { get; set; }
    }
}
