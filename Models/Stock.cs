using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv2.Models
{
    [Table("STOCK")]
    [Index(nameof(StockCode), Name = "stock_idx", IsUnique = true)]
    public partial class Stock
    {
        public Stock()
        {
            Items = new HashSet<Item>();
        }

        [Required]
        [DisplayName("كود المخزن")]
        [Column("STOCK_CODE")]
        [StringLength(2)]
            public string StockCode { get; set; }

        [DisplayName("إسم المخزن")]
        [Column("STOCK_NAME")]
        [StringLength(50)]
        public string StockName { get; set; }
        [Column("NAME1")]
        [StringLength(30)]
        public string Name1 { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [InverseProperty(nameof(Item.Stock))]
        public virtual ICollection<Item> Items { get; set; }
    }
}
