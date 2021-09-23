using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Arquant
    {
        public long LineNo { get; set; }
        public byte Kind { get; set; }
        public string StockCode { get; set; }
        public string TrnNo { get; set; }
        public string TrnYear { get; set; }
        public string ItemCode { get; set; }
        public string EngName { get; set; }
        public DateTime? ExpDate { get; set; }
        public double? ItemQuant { get; set; }
        public double? ItemPrice { get; set; }
        public string UnitName { get; set; }
        public DateTime? TrnDate { get; set; }
        public string ArName { get; set; }
        public double? TransferQuant { get; set; }
        public string ArNameto { get; set; }
        public byte? ItemDtype { get; set; }
        public byte? ItemDesc { get; set; }
        public string GhaCode { get; set; }
        public string GhaMain { get; set; }
        public string GhaNum { get; set; }
        public bool Transfer { get; set; }
        public double? Perc { get; set; }
        public byte? IncDec { get; set; }
        public double? TempPrice { get; set; }
        public string Notes { get; set; }
        public string Tdate { get; set; }
    }
}
