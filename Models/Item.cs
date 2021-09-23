using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Item
    {
        public string StockCode { get; set; }
        public string ItemCode { get; set; }
        public decimal? ItemDtype { get; set; }
        public short? NameType { get; set; }
        public string EngName { get; set; }
        public decimal? ItemDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? ItemOrderlimit { get; set; }
        public DateTime? OpenbalDate { get; set; }
        public decimal? OpenbalQuant { get; set; }
        public decimal? FactQuant { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? Value { get; set; }
        public decimal? OpenQuant { get; set; }
        public decimal? OpenPrice { get; set; }
        public string Kindname { get; set; }
        public DateTime? KtrnDate { get; set; }
        public decimal? TotalIn { get; set; }
        public decimal? TotalOut { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? RealQuant { get; set; }
        public DateTime? GrdDate { get; set; }
        public DateTime? TempGrddate { get; set; }
        public string TempStockcode { get; set; }
        public string Cas { get; set; }
        public string AlternativeName1 { get; set; }
        public string AlternativeName2 { get; set; }
        public string AlternativeName3 { get; set; }
        public string AlternativeName4 { get; set; }
        public string ScientificName { get; set; }
        public string SeriousLevel { get; set; }
        public int? Isinstrument { get; set; }
    }
}
