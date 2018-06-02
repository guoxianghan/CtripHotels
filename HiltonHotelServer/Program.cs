using HotelHttpBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HiltonHotelServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "";
            HotelHttpServer server = new HiltonHttpServer();
            string text = File.ReadAllText(@"C:\Users\Guo\Documents\HBuilderProjects\HelloHBuilder\希尔顿.html");
            server.InitLoad();
            string html = server.QueryPriceHtml("TAOGBHI", DateTime.Now.AddDays(4), out info);
            var room = server.AnalysePriceHtml(html, "", out info);
            server.RunRequest("TAOGBHI", DateTime.Now.AddDays(4), out info);
        }
    }
}
