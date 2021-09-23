using System;
using System.Collections.Generic;

#nullable disable

namespace nrcv2.Models
{
    public partial class Hadd
    {
        public byte Kind { get; set; }
        public string StockCode { get; set; }
        public string TrnNo { get; set; }
        public string TrnYear { get; set; }
        public DateTime? TrnDate { get; set; }
        public string DocNo { get; set; }
        public string DocNoN { get; set; }
        public string GhaCode { get; set; }
        public string GhaMain { get; set; }
        public string GhaNum { get; set; }
        public string SuppName { get; set; }
        public string ArName { get; set; }
        public DateTime? DocDate { get; set; }
        public bool Transfer { get; set; }
        public double? Perc { get; set; }
        public byte? IncDec { get; set; }
        public string GhaName { get; set; }
        public string OutCode { get; set; }
        public decimal? Tanazol { get; set; }
    }
}
