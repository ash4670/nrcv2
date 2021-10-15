using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("HADD")]
    [Index(nameof(Kind), nameof(StockCode), nameof(TrnNo), nameof(TrnYear), Name = "hadd_idx", IsUnique = true)]
    public partial class Hadd
    {
        public Hadd()
        {
            Dadds = new HashSet<Dadd>();
        }

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
        [Column("TRN_DATE", TypeName = "datetime")]
        public DateTime? TrnDate { get; set; }
        [Column("DOC_NO")]
        [StringLength(12)]
        public string DocNo { get; set; }
        [Column("DOC_NO_N")]
        [StringLength(13)]
        public string DocNoN { get; set; }
        [Column("GHA_CODE")]
        [StringLength(2)]
        public string GhaCode { get; set; }
        [Column("GHA_MAIN")]
        [StringLength(4)]
        public string GhaMain { get; set; }
        [Column("GHA_NUM")]
        [StringLength(4)]
        public string GhaNum { get; set; }
        [Column("SUPP_NAME")]
        [StringLength(50)]
        public string SuppName { get; set; }
        [Column("AR_NAME")]
        [StringLength(20)]
        public string ArName { get; set; }
        [Column("doc_date", TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column("TRANSFER")]
        public bool Transfer { get; set; }
        [Column("PERC")]
        public double? Perc { get; set; }
        [Column("INC_DEC")]
        public byte? IncDec { get; set; }
        [Column("GHA_NAME")]
        [StringLength(50)]
        public string GhaName { get; set; }
        [Column("OUT_CODE")]
        [StringLength(3)]
        public string OutCode { get; set; }
        [Column("tanazol", TypeName = "numeric(15, 5)")]
        public decimal? Tanazol { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [InverseProperty(nameof(Dadd.Hadd))]
        public virtual ICollection<Dadd> Dadds { get; set; }
    }
}
