using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace nrcv2.Models
{
    public partial class nrcwebContext : DbContext
    {
      
        public nrcwebContext(DbContextOptions<nrcwebContext> options)
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
        public virtual DbSet<Masrf> Masrves { get; set; }
        public virtual DbSet<MsysCompactError> MsysCompactErrors { get; set; }
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
        public virtual DbSet<Testtable> Testtables { get; set; }
        public virtual DbSet<Tklf> Tklves { get; set; }
        public virtual DbSet<TklfDetail> TklfDetails { get; set; }
        public virtual DbSet<TklfSubBudg> TklfSubBudgs { get; set; }
        public virtual DbSet<TklfSubTotPayed> TklfSubTotPayeds { get; set; }
        public virtual DbSet<TklfSubTotRelated> TklfSubTotRelateds { get; set; }
        public virtual DbSet<Tklfmain> Tklfmains { get; set; }
        public virtual DbSet<Tklfsub> Tklfsubs { get; set; }
        public virtual DbSet<Tklfsubo> Tklfsubos { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<TrnsAttach> TrnsAttaches { get; set; }
        public virtual DbSet<VGehaIssue> VGehaIssues { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<WinTitle> WinTitles { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
             //   optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=nrcweb;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<Arname>(entity =>
            {
                entity.Property(e => e.ArCode).IsUnicode(false);

                entity.Property(e => e.ArName1).IsUnicode(false);

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaName).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.Nid).IsUnicode(false);

                entity.Property(e => e.Oldcode).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Work).IsUnicode(false);
            });

            modelBuilder.Entity<Arquant>(entity =>
            {
                entity.Property(e => e.ArName).IsUnicode(false);

                entity.Property(e => e.ArNameto).IsUnicode(false);

                entity.Property(e => e.EngName).IsUnicode(false);

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.Tdate).IsUnicode(false);

                entity.Property(e => e.TrnNo).IsUnicode(false);

                entity.Property(e => e.TrnYear).IsUnicode(false);

                entity.Property(e => e.UnitName).IsUnicode(false);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AppId, e.WinId, e.DataKey, e.UpdStamp })
                    .HasName("pk_auditlog");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.AppId).IsUnicode(false);

                entity.Property(e => e.WinId).IsUnicode(false);

                entity.Property(e => e.DataKey).IsUnicode(false);

                entity.Property(e => e.Op).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<Dadd>(entity =>
            {
                entity.Property(e => e.ArName).IsUnicode(false);

                entity.Property(e => e.EngName).IsUnicode(false);

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.TrnNo).IsUnicode(false);

                entity.Property(e => e.TrnYear).IsUnicode(false);

                entity.Property(e => e.UnitName).IsUnicode(false);

                entity.HasOne(d => d.Hadd)
                    .WithMany(p => p.Dadds)
                    .HasForeignKey(d => d.Haddid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dadd_hadd");
            });

            modelBuilder.Entity<DumyRep>(entity =>
            {
                entity.Property(e => e.Ccol0).IsUnicode(false);

                entity.Property(e => e.Ccol1).IsUnicode(false);

                entity.Property(e => e.Ccol2).IsUnicode(false);

                entity.Property(e => e.Ccol3).IsUnicode(false);

                entity.Property(e => e.Ccol4).IsUnicode(false);

                entity.Property(e => e.Ccol5).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.ItemName).IsUnicode(false);

                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.RepName).IsUnicode(false);

                entity.Property(e => e.Scol0).IsUnicode(false);

                entity.Property(e => e.Scol1).IsUnicode(false);

                entity.Property(e => e.Scol10).IsUnicode(false);

                entity.Property(e => e.Scol2).IsUnicode(false);

                entity.Property(e => e.Scol3).IsUnicode(false);

                entity.Property(e => e.Scol4).IsUnicode(false);

                entity.Property(e => e.Scol5).IsUnicode(false);

                entity.Property(e => e.Scol6).IsUnicode(false);

                entity.Property(e => e.Scol7).IsUnicode(false);

                entity.Property(e => e.Scol8).IsUnicode(false);

                entity.Property(e => e.Scol9).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfName).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);

                entity.Property(e => e.TklfsubName).IsUnicode(false);

                entity.Property(e => e.TrnsDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.VendCode).IsUnicode(false);
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.AmrId })
                    .HasName("PK__entries__74DE014F");

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.B).IsUnicode(false);

                entity.Property(e => e.R).IsUnicode(false);

                entity.Property(e => e.S).IsUnicode(false);

                entity.Property(e => e.T).IsUnicode(false);

                entity.Property(e => e.UserAmr).IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_groups");
            });

            modelBuilder.Entity<Gha>(entity =>
            {
                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaName).IsUnicode(false);

                entity.Property(e => e.TablName).IsUnicode(false);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<Hadd>(entity =>
            {
                entity.Property(e => e.ArName).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocNoN).IsUnicode(false);

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaName).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.SuppName).IsUnicode(false);

                entity.Property(e => e.TrnNo).IsUnicode(false);

                entity.Property(e => e.TrnYear).IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.AlternativeName1).IsUnicode(false);

                entity.Property(e => e.AlternativeName2).IsUnicode(false);

                entity.Property(e => e.AlternativeName3).IsUnicode(false);

                entity.Property(e => e.AlternativeName4).IsUnicode(false);

                entity.Property(e => e.Cas).IsUnicode(false);

                entity.Property(e => e.EngName).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.Kindname).IsUnicode(false);

                entity.Property(e => e.ScientificName).IsUnicode(false);

                entity.Property(e => e.SeriousLevel).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.TempStockcode).IsUnicode(false);

                entity.Property(e => e.UnitName).IsUnicode(false);

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.Stockid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_items_stock");
            });

            modelBuilder.Entity<ItemsIn>(entity =>
            {
                entity.ToView("ITEMS_IN");

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);
            });

            modelBuilder.Entity<ItemsOut>(entity =>
            {
                entity.ToView("ITEMS_OUT");

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);
            });

            modelBuilder.Entity<Masrf>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.Project).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<MsysCompactError>(entity =>
            {
                entity.Property(e => e.ErrorTable).IsUnicode(false);
            });

            modelBuilder.Entity<Out>(entity =>
            {
                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.OutName).IsUnicode(false);

                entity.Property(e => e.OutType)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatcol>(entity =>
            {
                entity.Property(e => e.PbcBmap)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbcCmnt).IsUnicode(false);

                entity.Property(e => e.PbcCnam)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbcEdit).IsUnicode(false);

                entity.Property(e => e.PbcHdr).IsUnicode(false);

                entity.Property(e => e.PbcInit).IsUnicode(false);

                entity.Property(e => e.PbcLabl).IsUnicode(false);

                entity.Property(e => e.PbcMask).IsUnicode(false);

                entity.Property(e => e.PbcOwnr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbcPtrn).IsUnicode(false);

                entity.Property(e => e.PbcTag).IsUnicode(false);

                entity.Property(e => e.PbcTnam)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatedt>(entity =>
            {
                entity.Property(e => e.PbeEdit).IsUnicode(false);

                entity.Property(e => e.PbeName).IsUnicode(false);

                entity.Property(e => e.PbeWork)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatfmt>(entity =>
            {
                entity.Property(e => e.PbfFrmt).IsUnicode(false);

                entity.Property(e => e.PbfName).IsUnicode(false);
            });

            modelBuilder.Entity<Pbcattbl>(entity =>
            {
                entity.Property(e => e.PbdFfce)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbdFitl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbdFunl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFfce)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFitl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbhFunl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PblFfce)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PblFitl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PblFunl)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbtCmnt).IsUnicode(false);

                entity.Property(e => e.PbtOwnr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PbtTnam)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pbcatvld>(entity =>
            {
                entity.Property(e => e.PbvMsg).IsUnicode(false);

                entity.Property(e => e.PbvName).IsUnicode(false);

                entity.Property(e => e.PbvVald).IsUnicode(false);
            });

            modelBuilder.Entity<Related>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Formname).IsUnicode(false);

                entity.Property(e => e.Reportname).IsUnicode(false);

                entity.Property(e => e.Rptname).IsUnicode(false);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(e => e.Name1).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.StockName).IsUnicode(false);
            });

            modelBuilder.Entity<Taziz>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.TazizNo).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<TazizTran>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.KindCode2).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.OutCode2).IsUnicode(false);

                entity.Property(e => e.TazizNo).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfCode2).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode2).IsUnicode(false);
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);
            });

            modelBuilder.Entity<Tklf>(entity =>
            {
                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfName).IsUnicode(false);
            });

            modelBuilder.Entity<TklfDetail>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.OutCode).IsUnicode(false);

                entity.Property(e => e.Project).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);

                entity.HasOne(d => d.Tklfsub)
                    .WithMany(p => p.TklfDetails)
                    .HasForeignKey(d => d.Tklfsubid)
                    .HasConstraintName("fk_tkldetail_tklfsub");
            });

            modelBuilder.Entity<TklfSubBudg>(entity =>
            {
                entity.ToView("TKLF_SUB_BUDG");

                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<TklfSubTotPayed>(entity =>
            {
                entity.ToView("TKLF_SUB_TOT_PAYED");

                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<TklfSubTotRelated>(entity =>
            {
                entity.ToView("TKLF_SUB_TOT_RELATED");

                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);
            });

            modelBuilder.Entity<Tklfmain>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.Shobacode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfName).IsUnicode(false);
            });

            modelBuilder.Entity<Tklfsub>(entity =>
            {
                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.Name1).IsUnicode(false);

                entity.Property(e => e.Name2).IsUnicode(false);

                entity.Property(e => e.Name3).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);

                entity.Property(e => e.TklfsubName).IsUnicode(false);

                entity.HasOne(d => d.Tklfmain)
                    .WithMany(p => p.Tklfsubs)
                    .HasForeignKey(d => d.Tklfmainid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TKLFMAIN_TKLFSUB");
            });

            modelBuilder.Entity<Tklfsubo>(entity =>
            {
                entity.HasKey(e => new { e.KindCode, e.TklfCode, e.TklfsubCode })
                    .HasName("PK_TKLFSUBold");

                entity.Property(e => e.KindCode).IsUnicode(false);

                entity.Property(e => e.TklfCode).IsUnicode(false);

                entity.Property(e => e.TklfsubCode).IsUnicode(false);

                entity.Property(e => e.Name1).IsUnicode(false);

                entity.Property(e => e.Name2).IsUnicode(false);

                entity.Property(e => e.Name3).IsUnicode(false);

                entity.Property(e => e.TklfsubName).IsUnicode(false);
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.Property(e => e.AddStock).IsUnicode(false);

                entity.Property(e => e.NewItem).IsUnicode(false);

                entity.Property(e => e.OldItem).IsUnicode(false);

                entity.Property(e => e.OutStock).IsUnicode(false);

                entity.Property(e => e.TrnNo).IsUnicode(false);
            });

            modelBuilder.Entity<TrnsAttach>(entity =>
            {
                entity.HasKey(e => new { e.TrnsCode, e.TrnsNo, e.Docname })
                    .HasName("PK__trns_attach__4E00FDF4");

                entity.Property(e => e.TrnsCode).IsUnicode(false);

                entity.Property(e => e.TrnsNo).IsUnicode(false);

                entity.Property(e => e.Docname).IsUnicode(false);
            });

            modelBuilder.Entity<VGehaIssue>(entity =>
            {
                entity.ToView("v_geha_issue");

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.ToView("VIEW_1");

                entity.Property(e => e.ArCode).IsUnicode(false);

                entity.Property(e => e.ArName).IsUnicode(false);

                entity.Property(e => e.ArNameto).IsUnicode(false);

                entity.Property(e => e.EngName).IsUnicode(false);

                entity.Property(e => e.Expr1).IsUnicode(false);

                entity.Property(e => e.Expr2).IsUnicode(false);

                entity.Property(e => e.Expr3).IsUnicode(false);

                entity.Property(e => e.Expr4).IsUnicode(false);

                entity.Property(e => e.GhaCode).IsUnicode(false);

                entity.Property(e => e.GhaMain).IsUnicode(false);

                entity.Property(e => e.GhaName).IsUnicode(false);

                entity.Property(e => e.GhaNum).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.Nid).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Oldcode).IsUnicode(false);

                entity.Property(e => e.StockCode).IsUnicode(false);

                entity.Property(e => e.StockName).IsUnicode(false);

                entity.Property(e => e.Tdate).IsUnicode(false);

                entity.Property(e => e.TrnNo).IsUnicode(false);

                entity.Property(e => e.TrnYear).IsUnicode(false);

                entity.Property(e => e.UnitName).IsUnicode(false);

                entity.Property(e => e.Work).IsUnicode(false);
            });

            modelBuilder.Entity<WinTitle>(entity =>
            {
                entity.HasKey(e => e.WinId)
                    .HasName("pk_win_titles");

                entity.Property(e => e.WinId).IsUnicode(false);

                entity.Property(e => e.WinTitle1).IsUnicode(false);
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.Property(e => e.WName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
