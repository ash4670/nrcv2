using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using nrcv2.Models;
using nrcv2.Pages;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace nrcv2.services
{
    public class Gtools
    {

        protected NotificationService _NotificationService { get; set; }
        protected DialogService _ds { get; set; }

        [Inject]
        IDbContextFactory<nrcwebContext> dbf { get; set; }
        public Gtools()
        {
        }
        public Gtools(NotificationService Nt, IDbContextFactory<nrcwebContext> dbfact , DialogService ds )
        {
            _NotificationService = Nt;
            _ds = ds;
            dbf = dbfact;
        }
        public void Mynotify(string title = "", string content = "")
        {
            _NotificationService.Notify(NotificationSeverity.Error, title, content, -1);
        }

        public void Myinfo(string title = "", string content = "")
        {
            _NotificationService.Notify(NotificationSeverity.Info, title, content, -1);
        }

       

        public IEnumerable<T> GetAll<T>() where T : class, new()
        {
            IEnumerable<T> temp;
            using (var db = dbf.CreateDbContext())
            {
                temp = (from e in db.Set<T>() select e).ToList();
                return temp;
            }
        }
        public IEnumerable<T> GetAll<T>(Func<T, bool> w) where T : class, new()
        {
            IEnumerable<T> temp;    
            using (var db = dbf.CreateDbContext())
            {
                temp=(from e in db.Set<T>() select e ).ToList().Where(a=>w(a));
                return temp;
            }
        }
        public bool CheckArcodeStatus(string as_arcode) {
            Arname _arname;
            using (var db = dbf.CreateDbContext())
            {
                if (!db.Arnames.Where(a => a.ArCode.Equals(as_arcode)).Any()) {
                    Mynotify("", "كود الموظف غير معرف");
                        return false;
                }
                _arname = db.Arnames.Where(a => a.ArCode.Equals(as_arcode)).FirstOrDefault();

            }

            if (string.IsNullOrWhiteSpace(_arname.Status)) return true;
            switch (_arname.Status.ToLower())
            {
               case  "s" :
                 Mynotify("خطأ", _arname.ArName1 + "بالمعاش");
                    return false;
                case "d":
                    Mynotify("خطأ", _arname.ArName1 + "متوفى");
                    return false;
                case "h":
                    Mynotify("خطأ", _arname.ArName1 + "أجازة بدون اجر");
                    return false;
                case "x":
                    Mynotify("خطأ", _arname.ArName1 + "مستقيل");
                    return false;
                default:
                    break;
            }
            
            return true;
        }
        public double? GetAvgB4Time(string as_itemcode,string as_stock, DateTime? as_dt) {
            using (var db = dbf.CreateDbContext())
            {
                decimal? ld_openprice, ld_cost;
                ld_openprice = (from it in db.Items where it.ItemCode.Equals(as_itemcode) && it.StockCode.Equals(as_stock) select it.OpenPrice).First();
                if (ld_openprice == null) ld_openprice = 0;
                if (db.Dadds.Where(d => d.Kind == 1 && d.ItemCode.Equals(as_itemcode) && d.StockCode.Equals(as_stock)
                            && d.TrnDate < as_dt).Count() > 0)
                {
                    ld_cost = (from d in db.Dadds
                               where d.Kind == 1 && d.ItemCode.Equals(as_itemcode) && d.StockCode.Equals(as_stock)
                               && d.TrnDate < as_dt
                               orderby d.TrnDate descending
                               select d.Cost).First();
                    return (double?)ld_cost;
                }
                else return (double?)ld_openprice;
            }
        }
        public decimal? GetBal(string as_stockcode, string as_itemcode, string as_year , nrcwebContext db)
        {
            decimal? trns_qty , ld_openbal;
            trns_qty =(decimal?) db.Dadds.Where(d => d.TrnYear.Equals(as_year) && d.ItemCode.Equals(as_itemcode) && d.StockCode.Equals(as_stockcode)).ToList().Sum(r => r.Kind == 1 ? r.ItemQuant : -1 * r.ItemQuant);
            if (trns_qty == null) trns_qty = 0;
            ld_openbal = db.Items.Where(i => i.ItemCode.Equals(as_itemcode) && i.StockCode.Equals(as_stockcode)).FirstOrDefault().OpenQuant;
            return ld_openbal + trns_qty;
        }
        public decimal? GetBal(string as_stockcode, string as_itemcode,string as_year  ) {
            decimal? trns_qty;
            using (var db = dbf.CreateDbContext()) trns_qty= GetBal( as_stockcode,  as_itemcode,  as_year, db);
           return trns_qty;
        }
        public void RecItemCost(string as_stockcode, string as_itemcode,DateTime? as_dt ,  string as_year, nrcwebContext db)
        {
            decimal? tempBal = 0m, tempcost = 0m;
            decimal? ld_openprice,ld_openbal, ld_trnsprice, ld_trnsqty;
            Item res =(Item) (from i in db.Items where i.StockCode.Equals(as_stockcode) && i.ItemCode.Equals(as_itemcode) select i ).FirstOrDefault();
            ld_openbal = res.OpenQuant; if (ld_openbal == null) ld_openbal = 0;
            ld_openprice = res.OpenPrice; if (ld_openprice == null) ld_openprice = 0;
            tempBal = ld_openbal;
            tempcost = ld_openprice;
           
            foreach (var drow in db.Dadds.Where(d=>d.StockCode.Equals(as_stockcode) && d.ItemCode.Equals(as_itemcode) && d.TrnYear.Equals(as_year)).OrderBy(d=>d.TrnDate) )
            {
                ld_trnsprice =(decimal) drow.ItemPrice; if (ld_trnsprice == null) ld_trnsprice = 0;
                ld_trnsqty = (decimal) drow.ItemQuant; if (ld_trnsqty == null) ld_trnsqty = 0;
                if (drow.Kind == 1) {
                    if (tempBal > 0) tempcost = ((tempcost * tempBal) + (ld_trnsprice * ld_trnsqty)) / (tempBal + ld_trnsqty);  
                    else tempcost = ld_trnsprice;
                    if (tempcost == null) tempcost = 0;
                    tempBal += (decimal) drow.ItemQuant;
                    if (DateTime.Compare((DateTime)drow.TrnDate, (DateTime)as_dt) >= 0)
                    {
                        drow.Cost = tempcost;
                    }
                }
                else tempBal -= (decimal) drow.ItemQuant;
            }
            db.Items.Where(i => i.StockCode.Equals(as_stockcode) && i.ItemCode.Equals(as_itemcode) /*i.year.Equals(as_year) */).FirstOrDefault().Value = tempcost;
        }

        public async Task<List<Dictionary<string, object>>> GetDataFromQuery(string argsql) {
            List<Dictionary<string, object>> _data=new();
            List<string> Columns = new();
            try
            {

           
            using (var db = dbf.CreateDbContext())
            {
                 await   db.Database.OpenConnectionAsync();
                    var command = db.Database.GetDbConnection().CreateCommand();
                command.CommandText = argsql;
                using var reader =  command.ExecuteReader();
                 
               
                
                

                Columns = Enumerable.Range(0, reader.FieldCount)
                                    .Select(reader.GetName)
                                    .ToList();

                    _data = new List<Dictionary<string, object>>();
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i) ?? "NULL";
                        }
                        _data.Add(row);
                    }
                
            }
            }
            catch (Exception e)
            {

                throw e;
            }

            return _data;
        }
    }
}
