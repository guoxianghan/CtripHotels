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
            string html7 = ctrip.QueryPriceHtml("939388", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), out info);
            var rrrrr = ctrip.AnalysePriceHtml(html7, "", out info);
        }
    }
}
