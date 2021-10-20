using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace nrcv2.services
{
    public class Gtools
    {

        protected NotificationService _NotificationService { get; set; }
        public Gtools()
        {
        }

        public Gtools(NotificationService Nt)
        {
            _NotificationService = Nt;
        }

        public  void Mynotify(string title = "", string content = "") {
            _NotificationService.Notify(NotificationSeverity.Error, title, content, -1);
        }

    }

    //public interface IGtools
    //{
    //    void Mynotify(string title="",string content="") { }
    //}
}
