using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("items")]
    [Index(nameof(ItemCode), nameof(StockCode), Name = "items_idx", IsUnique = true)]
    public partial class Item
    {
        [Required]
        [Column("stock_code")]
        [StringLength(2)]
        public string StockCode { get; set; }
        [Required]
        [Column("item_code")]
        [StringLength(5)]
        public string ItemCode { get; set; }
        [Column("item_dtype", TypeName = "numeric(1, 0)")]
        public decimal? ItemDtype { get; set; }
        [Column("name_type")]
        public short? NameType { get; set; }
        [Column("eng_name")]
        [StringLength(100)]
        public string EngName { get; set; }
        [Column("item_desc", TypeName = "numeric(1, 0)")]
        public decimal? ItemDesc { get; set; }
        [Column("unit_name")]
        [StringLength(25)]
        public string UnitName { get; set; }
        [Column("item_orderlimit", TypeName = "numeric(20, 3)")]
        public decimal? ItemOrderlimit { get; set; }
        [Column("openbal_date", TypeName = "datetime")]
        public DateTime? OpenbalDate { get; set; }
        [Column("openbal_quant", TypeName = "numeric(20, 3)")]
        public decimal? OpenbalQuant { get; set; }
        [Column("fact_quant", TypeName = "numeric(20, 3)")]
        public decimal? FactQuant { get; set; }
        [Column("exp_date", TypeName = "datetime")]
        public DateTime? ExpDate { get; set; }
        [Column("value", TypeName = "numeric(20, 3)")]
        public decimal? Value { get; set; }
        [Column("open_quant", TypeName = "numeric(20, 3)")]
        public decimal? OpenQuant { get; set; }
        [Column("open_price", TypeName = "numeric(20, 3)")]
        public decimal? OpenPrice { get; set; }
        [Column("kindname")]
        [StringLength(12)]
        public string Kindname { get; set; }
        [Column("ktrn_date", TypeName = "datetime")]
        public DateTime? KtrnDate { get; set; }
        [Column("total_in", TypeName = "numeric(20, 3)")]
        public decimal? TotalIn { get; set; }
        [Column("total_out", TypeName = "numeric(20, 3)")]
        public decimal? TotalOut { get; set; }
        [Column("current_price", TypeName = "numeric(20, 3)")]
        public decimal? CurrentPrice { get; set; }
        [Column("current_balance", TypeName = "numeric(20, 3)")]
        public decimal? CurrentBalance { get; set; }
        [Column("real_quant", TypeName = "numeric(20, 3)")]
        public decimal? RealQuant { get; set; }
        [Column("grd_date", TypeName = "datetime")]
        public DateTime? GrdDate { get; set; }
        [Column("temp_grddate", TypeName = "datetime")]
        public DateTime? TempGrddate { get; set; }
        [Column("temp_stockcode")]
        [StringLength(2)]
        public string TempStockcode { get; set; }
        [Column("cas")]
        [StringLength(20)]
        public string Cas { get; set; }
        [Column("alternative_name1")]
        [StringLength(100)]
        public string AlternativeName1 { get; set; }
        [Column("alternative_name2")]
        [StringLength(100)]
        public string AlternativeName2 { get; set; }
        [Column("alternative_name3")]
        [StringLength(100)]
        public string AlternativeName3 { get; set; }
        [Column("alternative_name4")]
        [StringLength(100)]
        public string AlternativeName4 { get; set; }
        [Column("scientific_name")]
        [StringLength(100)]
        public string ScientificName { get; set; }
        [Column("serious_level")]
        [StringLength(25)]
        public string SeriousLevel { get; set; }
        [Column("isinstrument")]
        public int? Isinstrument { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("stockid")]
        public int Stockid { get; set; }

        [ForeignKey(nameof(Stockid))]
        [InverseProperty("Items")]
        public virtual Stock Stock { get; set; }
    }
}
