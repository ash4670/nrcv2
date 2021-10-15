using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    public partial class View1
    {
        [Required]
        [Column("ar_name")]
        [StringLength(80)]
        public string ArName { get; set; }
        [Column("GHA_CODE")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("GHA_MAIN")]
        [StringLength(3)]
        public string GhaMain { get; set; }
        [Column("GHA_NUM")]
        [StringLength(3)]
        public string GhaNum { get; set; }
        [Column("GHA_NAME")]
        [StringLength(50)]
        public string GhaName { get; set; }
        [Column("work")]
        [StringLength(100)]
        public string Work { get; set; }
        [Column("job")]
        [StringLength(50)]
        public string Job { get; set; }
        [Column("bas_sal", TypeName = "numeric(18, 0)")]
        public decimal? BasSal { get; set; }
        [Column("oldcode")]
        [StringLength(5)]
        public string Oldcode { get; set; }
        [Column("nid")]
        [StringLength(20)]
        public string Nid { get; set; }
        [Column("LINE_NO")]
        public long? LineNo { get; set; }
        [Column("stock_code")]
        [StringLength(2)]
        public string StockCode { get; set; }
        [Column("KIND")]
        public byte? Kind { get; set; }
        [Column("TRN_NO")]
        [StringLength(10)]
        public string TrnNo { get; set; }
        [Column("TRN_YEAR")]
        [StringLength(4)]
        public string TrnYear { get; set; }
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
        [Column("total")]
        public double? Total { get; set; }
        [Column("UNIT_NAME")]
        [StringLength(25)]
        public string UnitName { get; set; }
        [Column("TRN_DATE", TypeName = "datetime")]
        public DateTime? TrnDate { get; set; }
        [StringLength(20)]
        public string Expr1 { get; set; }
        [Column("TRANSFER_QUANT")]
        public double? TransferQuant { get; set; }
        [Column("AR_NAMETO")]
        [StringLength(20)]
        public string ArNameto { get; set; }
        [Column("ITEM_DTYPE")]
        public byte? ItemDtype { get; set; }
        [Column("ITEM_DESC")]
        public byte? ItemDesc { get; set; }
        [StringLength(2)]
        public string Expr2 { get; set; }
        [StringLength(4)]
        public string Expr3 { get; set; }
        [StringLength(4)]
        public string Expr4 { get; set; }
        [Column("TRANSFER")]
        public bool? Transfer { get; set; }
        [Column("PERC")]
        public double? Perc { get; set; }
        [Column("INC_DEC")]
        public byte? IncDec { get; set; }
        [Column("TEMP_PRICE")]
        public double? TempPrice { get; set; }
        [Column("NOTES")]
        [StringLength(120)]
        public string Notes { get; set; }
        [Column("TDATE")]
        [StringLength(20)]
        public string Tdate { get; set; }
        [Column("STOCK_NAME")]
        [StringLength(50)]
        public string StockName { get; set; }
        [Required]
        [Column("ar_code")]
        [StringLength(20)]
        public string ArCode { get; set; }
    }
}
