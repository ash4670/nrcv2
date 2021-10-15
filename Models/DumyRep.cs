using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Keyless]
    [Table("dumy_reps")]
    [Index(nameof(ItemCode), Name = "ind_item_code")]
    [Index(nameof(RepName), nameof(UserId), Name = "ind_rep_name")]
    [Index(nameof(VendCode), Name = "ind_vend_code")]
    public partial class DumyRep
    {
        [Column("code")]
        [StringLength(10)]
        public string Code { get; set; }
        [Column("descr")]
        [StringLength(100)]
        public string Descr { get; set; }
        [Required]
        [Column("rep_name")]
        [StringLength(80)]
        public string RepName { get; set; }
        [Column("user_id")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column("ncol0", TypeName = "numeric(10, 0)")]
        public decimal? Ncol0 { get; set; }
        [Column("ncol1", TypeName = "numeric(20, 3)")]
        public decimal? Ncol1 { get; set; }
        [Column("ncol2", TypeName = "numeric(20, 3)")]
        public decimal? Ncol2 { get; set; }
        [Column("ncol3", TypeName = "numeric(20, 3)")]
        public decimal? Ncol3 { get; set; }
        [Column("ncol4", TypeName = "numeric(20, 3)")]
        public decimal? Ncol4 { get; set; }
        [Column("ncol5", TypeName = "numeric(20, 3)")]
        public decimal? Ncol5 { get; set; }
        [Column("ncol6", TypeName = "numeric(20, 3)")]
        public decimal? Ncol6 { get; set; }
        [Column("ncol7", TypeName = "numeric(20, 3)")]
        public decimal? Ncol7 { get; set; }
        [Column("ncol8", TypeName = "numeric(20, 3)")]
        public decimal? Ncol8 { get; set; }
        [Column("ncol9", TypeName = "numeric(20, 3)")]
        public decimal? Ncol9 { get; set; }
        [Column("ncol10", TypeName = "numeric(20, 3)")]
        public decimal? Ncol10 { get; set; }
        [Column("ncol11", TypeName = "numeric(20, 3)")]
        public decimal? Ncol11 { get; set; }
        [Column("ncol12", TypeName = "numeric(20, 3)")]
        public decimal? Ncol12 { get; set; }
        [Column("ncol13", TypeName = "numeric(20, 3)")]
        public decimal? Ncol13 { get; set; }
        [Column("ncol14", TypeName = "numeric(20, 3)")]
        public decimal? Ncol14 { get; set; }
        [Column("ncol15", TypeName = "numeric(20, 3)")]
        public decimal? Ncol15 { get; set; }
        [Column("ncol16", TypeName = "numeric(20, 3)")]
        public decimal? Ncol16 { get; set; }
        [Column("ncol17", TypeName = "numeric(20, 3)")]
        public decimal? Ncol17 { get; set; }
        [Column("ncol18", TypeName = "numeric(20, 3)")]
        public decimal? Ncol18 { get; set; }
        [Column("ncol19", TypeName = "numeric(20, 3)")]
        public decimal? Ncol19 { get; set; }
        [Column("ncol20", TypeName = "numeric(20, 3)")]
        public decimal? Ncol20 { get; set; }
        [Column("ccol0")]
        [StringLength(2)]
        public string Ccol0 { get; set; }
        [Column("ccol1")]
        [StringLength(2)]
        public string Ccol1 { get; set; }
        [Column("ccol2")]
        [StringLength(2)]
        public string Ccol2 { get; set; }
        [Column("ccol3")]
        [StringLength(3)]
        public string Ccol3 { get; set; }
        [Column("ccol4")]
        [StringLength(4)]
        public string Ccol4 { get; set; }
        [Column("ccol5")]
        [StringLength(5)]
        public string Ccol5 { get; set; }
        [Column("scol0")]
        [StringLength(100)]
        public string Scol0 { get; set; }
        [Column("scol1")]
        [StringLength(80)]
        public string Scol1 { get; set; }
        [Column("scol2")]
        [StringLength(80)]
        public string Scol2 { get; set; }
        [Column("scol3")]
        [StringLength(80)]
        public string Scol3 { get; set; }
        [Column("scol4")]
        [StringLength(80)]
        public string Scol4 { get; set; }
        [Column("scol5")]
        [StringLength(80)]
        public string Scol5 { get; set; }
        [Column("scol6")]
        [StringLength(80)]
        public string Scol6 { get; set; }
        [Column("scol7")]
        [StringLength(80)]
        public string Scol7 { get; set; }
        [Column("scol8")]
        [StringLength(80)]
        public string Scol8 { get; set; }
        [Column("scol9")]
        [StringLength(80)]
        public string Scol9 { get; set; }
        [Column("scol10")]
        [StringLength(80)]
        public string Scol10 { get; set; }
        [Column("dcol1", TypeName = "datetime")]
        public DateTime? Dcol1 { get; set; }
        [Column("dcol2", TypeName = "datetime")]
        public DateTime? Dcol2 { get; set; }
        [Column("dcol3", TypeName = "datetime")]
        public DateTime? Dcol3 { get; set; }
        [Column("dcol4", TypeName = "datetime")]
        public DateTime? Dcol4 { get; set; }
        [Column("stock_code")]
        [StringLength(2)]
        public string StockCode { get; set; }
        [Column("item_code")]
        [StringLength(5)]
        public string ItemCode { get; set; }
        [Column("item_name")]
        [StringLength(100)]
        public string ItemName { get; set; }
        [Column("vend_code")]
        [StringLength(5)]
        public string VendCode { get; set; }
        [Column("ncol21", TypeName = "numeric(20, 3)")]
        public decimal? Ncol21 { get; set; }
        [Column("ncol22", TypeName = "numeric(20, 3)")]
        public decimal? Ncol22 { get; set; }
        [Column("ncol23", TypeName = "numeric(20, 3)")]
        public decimal? Ncol23 { get; set; }
        [Column("ncol24", TypeName = "numeric(20, 3)")]
        public decimal? Ncol24 { get; set; }
        [Column("ncol25", TypeName = "numeric(20, 3)")]
        public decimal? Ncol25 { get; set; }
        [Column("ncol26", TypeName = "numeric(20, 3)")]
        public decimal? Ncol26 { get; set; }
        [Column("ncol27", TypeName = "numeric(20, 3)")]
        public decimal? Ncol27 { get; set; }
        [Column("ncol28", TypeName = "numeric(20, 3)")]
        public decimal? Ncol28 { get; set; }
        [Column("ncol29", TypeName = "numeric(20, 3)")]
        public decimal? Ncol29 { get; set; }
        [Column("ncol30", TypeName = "numeric(20, 3)")]
        public decimal? Ncol30 { get; set; }
        [Column("ncol31", TypeName = "numeric(20, 3)")]
        public decimal? Ncol31 { get; set; }
        [Column("ncol32", TypeName = "numeric(20, 3)")]
        public decimal? Ncol32 { get; set; }
        [Column("ncol33", TypeName = "numeric(20, 3)")]
        public decimal? Ncol33 { get; set; }
        [Column("trns_date")]
        public byte[] TrnsDate { get; set; }
        [Column("trns_nu")]
        public byte? TrnsNu { get; set; }
        [Column("kind_code")]
        [StringLength(2)]
        public string KindCode { get; set; }
        [Column("tklf_code")]
        [StringLength(4)]
        public string TklfCode { get; set; }
        [Column("tklfsub_code")]
        [StringLength(4)]
        public string TklfsubCode { get; set; }
        [Column("tklf_name")]
        [StringLength(100)]
        public string TklfName { get; set; }
        [Column("tklfsub_name")]
        [StringLength(60)]
        public string TklfsubName { get; set; }
    }
}
