using CtripHotelServer;
using HiltonHotelServer;
using HotelHttpBase;
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
            HotelHttpServer ctrip = new CtripHotelHttpServer();
            string info = "";
            var tt = ctrip.RunRequest("5244926",new DateTime(2018,07,29), out info);
            //string html = ctrip.GetRequest("http://hotels.ctrip.com/hotel/939388.html#ctm_ref=hod_hp_hot_dl_n_2_1", "");
            //string html7 = ctrip.QueryPriceHtml("441351", DateTime.Now.AddDays(0), DateTime.Now.AddDays(1), out info);
            //var rrrrr = ctrip.AnalysePriceHtml(html7, "", out info);

            var server = new HiltonHttpServer();
            var room = server.RunRequest("TAOGBHI", DateTime.Now.AddDays(4), out info);
        }
    }
}
