using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace nrcv2.Models
{
    public partial class nrcdbContext : DbContext
    {
        //public nrcdbContext()
        //{
        //}

        public nrcdbContext(DbContextOptions<nrcdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arname> Arnames { get; set; }
        public virtual DbSet<Arquant> Arquants { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<Dadd> Dadds { get; set; }
        public virtual DbSet<DumyRep> DumyReps { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Gha> Ghas { get; set; }
        public virtual DbSet<GlobVar> GlobVars { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Hadd> Hadds { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemsIn> ItemsIns { get; set; }
        public virtual DbSet<ItemsOut> ItemsOuts { get; set; }
        public virtual DbSet<Kareem> Kareems { get; set; }
        public virtual DbSet<Masrf> Masrves { get; set; }
        public virtual DbSet<Out> Outs { get; set; }
        public virtual DbSet<Pbcatcol> Pbcatcols { get; set; }
        public virtual DbSet<Pbcatedt> Pbcatedts { get; set; }
        public virtual DbSet<Pbcatfmt> Pbcatfmts { get; set; }
        public virtual DbSet<Pbcattbl> Pbcattbls { get; set; }
        public virtual DbSet<Pbcatvld> Pbcatvlds { get; set; }
        public virtual DbSet<Related> Relateds { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Taziz> Tazizs { get; set; }
        public virtual DbSet<TazizTran> TazizTrans { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<Tklf> Tklves { get; set; }
        public virtual DbSet<TklfDetail> TklfDetails { get; set; }
        public virtual DbSet<TklfSubBudg> TklfSubBudgs { get; set; }
        public virtual DbSet<TklfSubTotPayed> TklfSubTotPayeds { get; set; }
        public virtual DbSet<TklfSubTotRelated> TklfSubTotRelateds { get; set; }
        public virtual DbSet<Tklfmain> Tklfmains { get; set; }
        public virtual DbSet<Tklfsub> Tklfsubs { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<VGehaIssue> VGehaIssues { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseSqlServer("Data Source=DESKTOP-9VETURD\\ASHSQLSERVER12;Initial Catalog=nrcweb;User ID=sa;Password=123456");
              //  optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=nrcweb;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<Arname>(entity =>
            {
                entity.HasKey(e => e.ArCode)
                    .HasName("PK__arnames__4DEE5160");

                entity.ToTable("arnames");

                entity.Property(e => e.ArCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ar_code");

                entity.Property(e => e.ArName1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ar_name");

                entity.Property(e => e.BasSal)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bas_sal");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GHA_MAIN");

                entity.Property(e => e.GhaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NAME");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NUM");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Nid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nid");

                entity.Property(e => e.Oldcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("oldcode");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Work)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("work");
            });

            modelBuilder.Entity<Arquant>(entity =>
            {
                entity.HasKey(e => new { e.LineNo, e.Kind, e.StockCode, e.TrnNo, e.TrnYear, e.ItemCode });

                entity.ToTable("ARQUANT");

                entity.Property(e => e.LineNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LINE_NO");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRN_NO");

                entity.Property(e => e.TrnYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRN_YEAR");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ArName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AR_NAME");

                entity.Property(e => e.ArNameto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AR_NAMETO");

                entity.Property(e => e.EngName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENG_NAME");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXP_DATE");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_MAIN");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NUM");

                entity.Property(e => e.IncDec).HasColumnName("INC_DEC");

                entity.Property(e => e.ItemDesc).HasColumnName("ITEM_DESC");

                entity.Property(e => e.ItemDtype).HasColumnName("ITEM_DTYPE");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemQuant).HasColumnName("ITEM_QUANT");

                entity.Property(e => e.Notes)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Perc).HasColumnName("PERC");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TDATE");

                entity.Property(e => e.TempPrice).HasColumnName("TEMP_PRICE");

                entity.Property(e => e.Transfer).HasColumnName("TRANSFER");

                entity.Property(e => e.TransferQuant).HasColumnName("TRANSFER_QUANT");

                entity.Property(e => e.TrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRN_DATE");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_NAME");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AppId, e.WinId, e.DataKey, e.UpdStamp })
                    .HasName("pk_auditlog");

                entity.ToTable("audit_log");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.AppId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("app_id");

                entity.Property(e => e.WinId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("win_id");

                entity.Property(e => e.DataKey)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("data_key");

                entity.Property(e => e.UpdStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("upd_stamp");

                entity.Property(e => e.Op)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("op");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<Dadd>(entity =>
            {
                entity.HasKey(e => new { e.LineNo, e.Kind, e.StockCode, e.TrnNo, e.TrnYear, e.ItemCode });

                entity.ToTable("DADD");

                entity.Property(e => e.LineNo).HasColumnName("LINE_NO");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRN_NO");

                entity.Property(e => e.TrnYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRN_YEAR");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ArName)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AR_NAME");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(20, 9)")
                    .HasColumnName("cost");

                entity.Property(e => e.EngName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENG_NAME");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXP_DATE");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_MAIN");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NUM");

                entity.Property(e => e.IncDec).HasColumnName("INC_DEC");

                entity.Property(e => e.ItemDesc).HasColumnName("ITEM_DESC");

                entity.Property(e => e.ItemDtype).HasColumnName("ITEM_DTYPE");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemQuant).HasColumnName("ITEM_QUANT");

                entity.Property(e => e.Perc).HasColumnName("PERC");

                entity.Property(e => e.TempPrice).HasColumnName("TEMP_PRICE");

                entity.Property(e => e.Transfer).HasColumnName("TRANSFER");

                entity.Property(e => e.TrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRN_DATE");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_NAME");
            });

            modelBuilder.Entity<DumyRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dumy_reps");

                entity.HasIndex(e => e.ItemCode, "ind_item_code");

                entity.HasIndex(e => new { e.RepName, e.UserId }, "ind_rep_name");

                entity.HasIndex(e => e.VendCode, "ind_vend_code");

                entity.Property(e => e.Ccol0)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ccol0");

                entity.Property(e => e.Ccol1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ccol1");

                entity.Property(e => e.Ccol2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ccol2");

                entity.Property(e => e.Ccol3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccol3");

                entity.Property(e => e.Ccol4)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ccol4");

                entity.Property(e => e.Ccol5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ccol5");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Dcol1)
                    .HasColumnType("datetime")
                    .HasColumnName("dcol1");

                entity.Property(e => e.Dcol2)
                    .HasColumnType("datetime")
                    .HasColumnName("dcol2");

                entity.Property(e => e.Dcol3)
                    .HasColumnType("datetime")
                    .HasColumnName("dcol3");

                entity.Property(e => e.Dcol4)
                    .HasColumnType("datetime")
                    .HasColumnName("dcol4");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("item_code");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("item_name");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kind_code");

                entity.Property(e => e.Ncol0)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ncol0");

                entity.Property(e => e.Ncol1)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol1");

                entity.Property(e => e.Ncol10)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol10");

                entity.Property(e => e.Ncol11)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol11");

                entity.Property(e => e.Ncol12)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol12");

                entity.Property(e => e.Ncol13)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol13");

                entity.Property(e => e.Ncol14)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol14");

                entity.Property(e => e.Ncol15)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol15");

                entity.Property(e => e.Ncol16)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol16");

                entity.Property(e => e.Ncol17)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol17");

                entity.Property(e => e.Ncol18)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol18");

                entity.Property(e => e.Ncol19)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol19");

                entity.Property(e => e.Ncol2)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol2");

                entity.Property(e => e.Ncol20)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol20");

                entity.Property(e => e.Ncol21)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol21");

                entity.Property(e => e.Ncol22)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol22");

                entity.Property(e => e.Ncol23)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol23");

                entity.Property(e => e.Ncol24)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol24");

                entity.Property(e => e.Ncol25)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol25");

                entity.Property(e => e.Ncol26)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol26");

                entity.Property(e => e.Ncol27)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol27");

                entity.Property(e => e.Ncol28)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol28");

                entity.Property(e => e.Ncol29)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol29");

                entity.Property(e => e.Ncol3)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol3");

                entity.Property(e => e.Ncol30)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol30");

                entity.Property(e => e.Ncol31)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol31");

                entity.Property(e => e.Ncol32)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol32");

                entity.Property(e => e.Ncol33)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol33");

                entity.Property(e => e.Ncol4)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol4");

                entity.Property(e => e.Ncol5)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol5");

                entity.Property(e => e.Ncol6)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol6");

                entity.Property(e => e.Ncol7)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol7");

                entity.Property(e => e.Ncol8)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol8");

                entity.Property(e => e.Ncol9)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("ncol9");

                entity.Property(e => e.RepName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("rep_name");

                entity.Property(e => e.Scol0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scol0");

                entity.Property(e => e.Scol1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol1");

                entity.Property(e => e.Scol10)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol10");

                entity.Property(e => e.Scol2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol2");

                entity.Property(e => e.Scol3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol3");

                entity.Property(e => e.Scol4)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol4");

                entity.Property(e => e.Scol5)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol5");

                entity.Property(e => e.Scol6)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol6");

                entity.Property(e => e.Scol7)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol7");

                entity.Property(e => e.Scol8)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol8");

                entity.Property(e => e.Scol9)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("scol9");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("tklf_code");

                entity.Property(e => e.TklfName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tklf_name");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("tklfsub_code");

                entity.Property(e => e.TklfsubName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("tklfsub_name");

                entity.Property(e => e.TrnsDate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsNu).HasColumnName("trns_nu");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.VendCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("vend_code");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.AmrId })
                    .HasName("PK__entries__74DE014F");

                entity.ToTable("entries");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.AmrId)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("amr_id");

                entity.Property(e => e.B)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("b");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Locked)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("locked");

                entity.Property(e => e.R)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("r");

                entity.Property(e => e.S)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("s");

                entity.Property(e => e.T)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("t");

                entity.Property(e => e.UserAmr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_amr");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_groups");
            });

            modelBuilder.Entity<Gha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GHA");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NAME");

                entity.Property(e => e.TablName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TABL_NAME");
            });

            modelBuilder.Entity<GlobVar>(entity =>
            {
                entity.ToTable("glob_vars");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.Yearend)
                    .HasColumnType("date")
                    .HasColumnName("yearend");

                entity.Property(e => e.Yearstart)
                    .HasColumnType("date")
                    .HasColumnName("yearstart");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");
            });

            modelBuilder.Entity<Hadd>(entity =>
            {
                entity.HasKey(e => new { e.Kind, e.StockCode, e.TrnNo, e.TrnYear });

                entity.ToTable("HADD");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRN_NO");

                entity.Property(e => e.TrnYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRN_YEAR");

                entity.Property(e => e.ArName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AR_NAME");

                entity.Property(e => e.DocDate)
                    .HasColumnType("datetime")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("DOC_NO");

                entity.Property(e => e.DocNoN)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("DOC_NO_N");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_MAIN");

                entity.Property(e => e.GhaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NAME");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NUM");

                entity.Property(e => e.IncDec).HasColumnName("INC_DEC");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OUT_CODE");

                entity.Property(e => e.Perc).HasColumnName("PERC");

                entity.Property(e => e.SuppName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPP_NAME");

                entity.Property(e => e.Tanazol)
                    .HasColumnType("numeric(15, 5)")
                    .HasColumnName("tanazol");

                entity.Property(e => e.Transfer).HasColumnName("TRANSFER");

                entity.Property(e => e.TrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRN_DATE");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => new { e.StockCode, e.ItemCode })
                    .IsClustered(false);

                entity.ToTable("items");

                entity.HasIndex(e => new { e.ItemCode, e.StockCode }, "new_ind")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.StockCode, e.ItemCode }, "primarykey")
                    .IsUnique();

                entity.HasIndex(e => e.StockCode, "stck");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("item_code");

                entity.Property(e => e.AlternativeName1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alternative_name1");

                entity.Property(e => e.AlternativeName2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alternative_name2");

                entity.Property(e => e.AlternativeName3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alternative_name3");

                entity.Property(e => e.AlternativeName4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alternative_name4");

                entity.Property(e => e.Cas)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cas");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("current_balance");

                entity.Property(e => e.CurrentPrice)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("current_price");

                entity.Property(e => e.EngName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("eng_name");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exp_date");

                entity.Property(e => e.FactQuant)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("fact_quant");

                entity.Property(e => e.GrdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("grd_date");

                entity.Property(e => e.Isinstrument).HasColumnName("isinstrument");

                entity.Property(e => e.ItemDesc)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("item_desc");

                entity.Property(e => e.ItemDtype)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("item_dtype");

                entity.Property(e => e.ItemOrderlimit)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("item_orderlimit");

                entity.Property(e => e.Kindname)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("kindname");

                entity.Property(e => e.KtrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ktrn_date");

                entity.Property(e => e.NameType).HasColumnName("name_type");

                entity.Property(e => e.OpenPrice)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("open_price");

                entity.Property(e => e.OpenQuant)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("open_quant");

                entity.Property(e => e.OpenbalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("openbal_date");

                entity.Property(e => e.OpenbalQuant)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("openbal_quant");

                entity.Property(e => e.RealQuant)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("real_quant");

                entity.Property(e => e.ScientificName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scientific_name");

                entity.Property(e => e.SeriousLevel)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("serious_level");

                entity.Property(e => e.TempGrddate)
                    .HasColumnType("datetime")
                    .HasColumnName("temp_grddate");

                entity.Property(e => e.TempStockcode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("temp_stockcode");

                entity.Property(e => e.TotalIn)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("total_in");

                entity.Property(e => e.TotalOut)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("total_out");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("unit_name");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(20, 3)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<ItemsIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ITEMS_IN");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CODE");

                entity.Property(e => e.TotIn).HasColumnName("TOT_IN");
            });

            modelBuilder.Entity<ItemsOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ITEMS_OUT");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CODE");

                entity.Property(e => e.TotOut).HasColumnName("TOT_OUT");
            });

            modelBuilder.Entity<Kareem>(entity =>
            {
                entity.HasKey(e => e.R);

                entity.ToTable("kareem");

                entity.Property(e => e.R)
                    .ValueGeneratedNever()
                    .HasColumnName("r");

                entity.Property(e => e.Degree)
                    .HasMaxLength(250)
                    .HasColumnName("degree");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Nid)
                    .HasMaxLength(20)
                    .HasColumnName("nid");

                entity.Property(e => e.Sec)
                    .HasMaxLength(250)
                    .HasColumnName("sec");

                entity.Property(e => e.Shobaa)
                    .HasMaxLength(250)
                    .HasColumnName("shobaa");
            });

            modelBuilder.Entity<Masrf>(entity =>
            {
                entity.ToTable("MASRF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OUT_CODE");

                entity.Property(e => e.OutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OUT_DATE");

                entity.Property(e => e.Project)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("project");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Out>(entity =>
            {
                entity.HasKey(e => e.OutCode);

                entity.ToTable("OUTS");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OUT_CODE");

                entity.Property(e => e.OutName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OUT_NAME");

                entity.Property(e => e.OutType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OUT_TYPE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatcol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pbcatcol");

                entity.Property(e => e.PbcBmap)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbc_bmap")
                    .IsFixedLength(true);

                entity.Property(e => e.PbcCase).HasColumnName("pbc_case");

                entity.Property(e => e.PbcCid).HasColumnName("pbc_cid");

                entity.Property(e => e.PbcCmnt)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbc_cmnt");

                entity.Property(e => e.PbcCnam)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("pbc_cnam")
                    .IsFixedLength(true);

                entity.Property(e => e.PbcEdit)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("pbc_edit");

                entity.Property(e => e.PbcHdr)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbc_hdr");

                entity.Property(e => e.PbcHght).HasColumnName("pbc_hght");

                entity.Property(e => e.PbcHpos).HasColumnName("pbc_hpos");

                entity.Property(e => e.PbcInit)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbc_init");

                entity.Property(e => e.PbcJtfy).HasColumnName("pbc_jtfy");

                entity.Property(e => e.PbcLabl)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbc_labl");

                entity.Property(e => e.PbcLpos).HasColumnName("pbc_lpos");

                entity.Property(e => e.PbcMask)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("pbc_mask");

                entity.Property(e => e.PbcOwnr)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("pbc_ownr")
                    .IsFixedLength(true);

                entity.Property(e => e.PbcPtrn)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("pbc_ptrn");

                entity.Property(e => e.PbcTag)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbc_tag");

                entity.Property(e => e.PbcTid).HasColumnName("pbc_tid");

                entity.Property(e => e.PbcTnam)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("pbc_tnam")
                    .IsFixedLength(true);

                entity.Property(e => e.PbcWdth).HasColumnName("pbc_wdth");
            });

            modelBuilder.Entity<Pbcatedt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pbcatedt");

                entity.Property(e => e.PbeCntr).HasColumnName("pbe_cntr");

                entity.Property(e => e.PbeEdit)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbe_edit");

                entity.Property(e => e.PbeFlag).HasColumnName("pbe_flag");

                entity.Property(e => e.PbeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pbe_name");

                entity.Property(e => e.PbeSeqn).HasColumnName("pbe_seqn");

                entity.Property(e => e.PbeType).HasColumnName("pbe_type");

                entity.Property(e => e.PbeWork)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("pbe_work")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatfmt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pbcatfmt");

                entity.Property(e => e.PbfCntr).HasColumnName("pbf_cntr");

                entity.Property(e => e.PbfFrmt)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbf_frmt");

                entity.Property(e => e.PbfName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pbf_name");

                entity.Property(e => e.PbfType).HasColumnName("pbf_type");
            });

            modelBuilder.Entity<Pbcattbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pbcattbl");

                entity.Property(e => e.PbdFchr).HasColumnName("pbd_fchr");

                entity.Property(e => e.PbdFfce)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("pbd_ffce")
                    .IsFixedLength(true);

                entity.Property(e => e.PbdFhgt).HasColumnName("pbd_fhgt");

                entity.Property(e => e.PbdFitl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbd_fitl")
                    .IsFixedLength(true);

                entity.Property(e => e.PbdFptc).HasColumnName("pbd_fptc");

                entity.Property(e => e.PbdFunl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbd_funl")
                    .IsFixedLength(true);

                entity.Property(e => e.PbdFwgt).HasColumnName("pbd_fwgt");

                entity.Property(e => e.PbhFchr).HasColumnName("pbh_fchr");

                entity.Property(e => e.PbhFfce)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("pbh_ffce")
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFhgt).HasColumnName("pbh_fhgt");

                entity.Property(e => e.PbhFitl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbh_fitl")
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFptc).HasColumnName("pbh_fptc");

                entity.Property(e => e.PbhFunl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbh_funl")
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFwgt).HasColumnName("pbh_fwgt");

                entity.Property(e => e.PblFchr).HasColumnName("pbl_fchr");

                entity.Property(e => e.PblFfce)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("pbl_ffce")
                    .IsFixedLength(true);

                entity.Property(e => e.PblFhgt).HasColumnName("pbl_fhgt");

                entity.Property(e => e.PblFitl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbl_fitl")
                    .IsFixedLength(true);

                entity.Property(e => e.PblFptc).HasColumnName("pbl_fptc");

                entity.Property(e => e.PblFunl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pbl_funl")
                    .IsFixedLength(true);

                entity.Property(e => e.PblFwgt).HasColumnName("pbl_fwgt");

                entity.Property(e => e.PbtCmnt)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbt_cmnt");

                entity.Property(e => e.PbtOwnr)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("pbt_ownr")
                    .IsFixedLength(true);

                entity.Property(e => e.PbtTid).HasColumnName("pbt_tid");

                entity.Property(e => e.PbtTnam)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("pbt_tnam")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatvld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pbcatvld");

                entity.Property(e => e.PbvCntr).HasColumnName("pbv_cntr");

                entity.Property(e => e.PbvMsg)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbv_msg");

                entity.Property(e => e.PbvName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pbv_name");

                entity.Property(e => e.PbvType).HasColumnName("pbv_type");

                entity.Property(e => e.PbvVald)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("pbv_vald");
            });

            modelBuilder.Entity<Related>(entity =>
            {
                entity.ToTable("Related");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OUT_CODE");

                entity.Property(e => e.OutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OUT_DATE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reports");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Formname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("formname");

                entity.Property(e => e.GrNo).HasColumnName("GR_NO");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORTNAME");

                entity.Property(e => e.Rptname)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("rptname");

                entity.Property(e => e.Rptno).HasColumnName("rptno");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockCode)
                    .HasName("pk_stock");

                entity.ToTable("STOCK");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CODE");

                entity.Property(e => e.Name1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME1");

                entity.Property(e => e.StockName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_NAME");

                entity.Property(e => e.Vdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDATE");
            });

            modelBuilder.Entity<Taziz>(entity =>
            {
                entity.ToTable("TAZIZ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("out_code");

                entity.Property(e => e.TazizDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TAZIZ_DATE");

                entity.Property(e => e.TazizNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TAZIZ_NO");

                entity.Property(e => e.TazizVal).HasColumnName("TAZIZ_VAL");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");
            });

            modelBuilder.Entity<TazizTran>(entity =>
            {
                entity.ToTable("TAZIZ_TRANS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.KindCode2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE2");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("out_code");

                entity.Property(e => e.OutCode2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("out_code2");

                entity.Property(e => e.TazizDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TAZIZ_DATE");

                entity.Property(e => e.TazizNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TAZIZ_NO");

                entity.Property(e => e.TazizVal).HasColumnName("TAZIZ_VAL");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE2");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.TklfsubCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE2");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.BaseSal).HasColumnName("base_sal");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Four).HasColumnName("four");

                entity.Property(e => e.Net).HasColumnName("net");

                entity.Property(e => e.NetMore6).HasColumnName("net_more_6");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<Tklf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TKLF");

                entity.Property(e => e.KindCode).HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_NAME");
            });

            modelBuilder.Entity<TklfDetail>(entity =>
            {
                entity.HasKey(e => new { e.KindCode, e.TklfCode, e.TklfsubCode, e.OutCode });

                entity.ToTable("TKLF_DETAIL");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.OutCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OUT_CODE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Project)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("project");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<TklfSubBudg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TKLF_SUB_BUDG");

                entity.Property(e => e.Budget).HasColumnName("BUDGET");

                entity.Property(e => e.KindCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");
            });

            modelBuilder.Entity<TklfSubTotPayed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TKLF_SUB_TOT_PAYED");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.TotPayed).HasColumnName("TOT_PAYED");
            });

            modelBuilder.Entity<TklfSubTotRelated>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TKLF_SUB_TOT_RELATED");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.TotRelated).HasColumnName("TOT_RELATED");
            });

            modelBuilder.Entity<Tklfmain>(entity =>
            {
                entity.HasKey(e => new { e.KindCode, e.TklfCode })
                    .HasName("PK_TAKLFMAIN");

                entity.ToTable("TKLFMAIN");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.Cost).HasColumnName("COST");

                entity.Property(e => e.Shobacode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("shobacode");

                entity.Property(e => e.TklfName)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_NAME");
            });

            modelBuilder.Entity<Tklfsub>(entity =>
            {
                entity.HasKey(e => new { e.KindCode, e.TklfCode, e.TklfsubCode });

                entity.ToTable("TKLFSUB");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KIND_CODE");

                entity.Property(e => e.TklfCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLF_CODE");

                entity.Property(e => e.TklfsubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_CODE");

                entity.Property(e => e.Cost).HasColumnName("COST");

                entity.Property(e => e.Name1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME1");

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME2");

                entity.Property(e => e.Name3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name3");

                entity.Property(e => e.Taziz).HasColumnName("TAZIZ");

                entity.Property(e => e.TklfsubName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TKLFSUB_NAME");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TRANSFER");

                entity.Property(e => e.AddStock)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ADD_STOCK");

                entity.Property(e => e.NewItem)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NEW_ITEM");

                entity.Property(e => e.OldItem)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OLD_ITEM");

                entity.Property(e => e.OutStock)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("OUT_STOCK");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.TrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRN_DATE");

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRN_NO");
            });

            modelBuilder.Entity<VGehaIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_geha_issue");

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("gha_code");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("gha_main");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("gha_num");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_1");

                entity.Property(e => e.ArCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ar_code");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ar_name");

                entity.Property(e => e.ArNameto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AR_NAMETO");

                entity.Property(e => e.BasSal)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bas_sal");

                entity.Property(e => e.EngName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENG_NAME");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXP_DATE");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Expr3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Expr4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GhaCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GHA_CODE");

                entity.Property(e => e.GhaMain)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GHA_MAIN");

                entity.Property(e => e.GhaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NAME");

                entity.Property(e => e.GhaNum)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GHA_NUM");

                entity.Property(e => e.IncDec).HasColumnName("INC_DEC");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDesc).HasColumnName("ITEM_DESC");

                entity.Property(e => e.ItemDtype).HasColumnName("ITEM_DTYPE");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemQuant).HasColumnName("ITEM_QUANT");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.LineNo).HasColumnName("LINE_NO");

                entity.Property(e => e.Nid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nid");

                entity.Property(e => e.Notes)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Oldcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("oldcode");

                entity.Property(e => e.Perc).HasColumnName("PERC");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("stock_code");

                entity.Property(e => e.StockName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_NAME");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TDATE");

                entity.Property(e => e.TempPrice).HasColumnName("TEMP_PRICE");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.Transfer).HasColumnName("TRANSFER");

                entity.Property(e => e.TransferQuant).HasColumnName("TRANSFER_QUANT");

                entity.Property(e => e.TrnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRN_DATE");

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRN_NO");

                entity.Property(e => e.TrnYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRN_YEAR");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_NAME");

                entity.Property(e => e.Work)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("work");
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasKey(e => e.WCode);

                entity.ToTable("work");

                entity.Property(e => e.WCode)
                    .ValueGeneratedNever()
                    .HasColumnName("w_code");

                entity.Property(e => e.WName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("w_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
