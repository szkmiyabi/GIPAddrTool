using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;
using System.Collections;

using System.IO;
using System.Net;

using System.Diagnostics;

namespace GIPAddrTool
{
    class Main
    {
        public static string getGIPAddr()
        {
            string t_url = "http://www.ugtop.com/spill.shtml";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

           
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(wc.DownloadString(t_url));

            HtmlAgilityPack.HtmlNodeCollection fns = doc.DocumentNode.SelectNodes(@"//font");

            string val = "";
            int cnt = 1;
            foreach(var fn in fns)
            {
                if(cnt == 2)
                {
                    val += fn.InnerText;
                }
                cnt++;

            }

            //Debug
            Debug.WriteLine(val);
            return val;
        }

    }
}
