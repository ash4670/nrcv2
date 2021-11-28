using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using nrcv2.Models;
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

        [Inject]
        IDbContextFactory<nrcwebContext> dbf { get; set; }
        public Gtools()
        {
        }
        public Gtools(NotificationService Nt, IDbContextFactory<nrcwebContext> dbfact )
        {
            _NotificationService = Nt;
            dbf = dbfact;
        }
        public  void Mynotify(string title = "", string content = "") {
            _NotificationService.Notify(NotificationSeverity.Error, title, content, -1);
        }
        public IEnumerable<T> GetAll<T>() where T : class, new()
        {
            IEnumerable<T> temp;
            using (var db = dbf.CreateDbContext())
            {
                temp = (from e in db.Set<T>() select e).ToList();
                return temp;
            }
            ;
        }
        public IEnumerable<T> GetAll<T>(Func<T, bool> w) where T : class, new()
        {
            IEnumerable<T> temp;    
            using (var db = dbf.CreateDbContext())
            {
                temp=(from e in db.Set<T>() select e ).ToList().Where(a=>w(a));
                return temp;
            }
             ;
        }
        public bool gf_check_arcode_status(string as_arcode) {
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

        public double? get_avg_b4_time(string as_itemcode,string as_stock, DateTime? as_dt) {
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
   
    
        public double? getbal(string as_stockcode, string as_itemcode,string as_year ) {
            double? trns_qty;
            using (var db = dbf.CreateDbContext()) {
                trns_qty= db.Dadds.Where(d => d.TrnYear.Equals(as_year) && d.ItemCode.Equals(as_itemcode) && d.StockCode.Equals(as_stockcode)).ToList().Sum(r=>r.ItemQuant);
                //trns_qty = (from t in db.Dadds where t.TrnYear.Equals(as_year) && t.ItemCode.Equals(as_itemcode) && t.StockCode.Equals(as_stockcode)
                //                select t).ToList().Sum(r => r.Kind == 1 ? r.ItemQuant : -1 * r.ItemQuant);
                if (trns_qty == null) trns_qty=0 ;
            }
           return trns_qty;
        }
    }

    //public interface IGtools
    //{
    //    void Mynotify(string title="",string content="") { }
    //}
}
