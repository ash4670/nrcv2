using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace nrcv2.Pages
{
    public partial class RepViewerComponent
    {
        public RepViewerComponent()
        {

        }
        public List<Dictionary<string, object>> _repdata = new();
      public void  OnDoItemBal() {

            //for (int i = 0; i < 100; i++)
            //{
            //    HtmlRepContent += "<p>" + i + "</p>";
            //}
            _repdata =  gtools.GetDataFromQuery("select * from glob_vars").Result ;
            
          
            
        }
    }
}
