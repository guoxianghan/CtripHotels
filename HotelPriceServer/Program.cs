using HttpHotelServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelPriceServer
{
    class Program
    {
        static void Main(string[] args)
        {
            CtripHotelHttpServer ctrip = new CtripHotelHttpServer();
            string info = "";
            var tt = ctrip.RunRequest("939388", DateTime.Now.AddDays(1), out info);
            string html = ctrip.GetRequest("http://hotels.ctrip.com/hotel/939388.html#ctm_ref=hod_hp_hot_dl_n_2_1", "");
            string html7 = ctrip.QueryPriceHtml("939388", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), out info);
            var rrrrr = ctrip.AnalysePriceHtml(html7, "", out info);
        }
    }
}
