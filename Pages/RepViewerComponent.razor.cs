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

      public void  OnDoItemBal() {
            HtmlRepContent = @" <!DOCTYPE html>    <html>        <head>    
                                    <title></title>
                                    <style>
                                    body { font-family: Arial, sans-serif; margin: 0; padding: 10px; }
                                        
                                    </style>
                                    </head>
                        <body>
                            <h3 >" + _reptitle + @"</h3>";
            HtmlRepContent += "";
            for (int i = 0; i < 100; i++)
            {
                HtmlRepContent += "<p>" + i + "</p>";
            }

            HtmlRepContent += "  </body>   </html>";
            
        }
    }
}
