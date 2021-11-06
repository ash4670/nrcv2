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

    }

    //public interface IGtools
    //{
    //    void Mynotify(string title="",string content="") { }
    //}
}
