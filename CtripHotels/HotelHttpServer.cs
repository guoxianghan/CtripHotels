
using HttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelPriceModel;

namespace HttpHotelServer
{
    public abstract class HotelHttpServer
    {
        protected HotelHttpServer(Platform plat)
        {
            _plat = plat;
            _CtripServer = new HttpServer();
        }
        public HttpServer _CtripServer;
        public HttpResult _Result;
        public Platform _plat { get; set; }
        public abstract string GetCityID(string cityname, out string info);
        public abstract string GetHotelInfoHtml(string cityid, string hotelname, string param, out string info);
        public abstract string AnalyseHotelId(string html, out string info);
        public abstract string QueryPriceHtml(string cityid, string hid, string date1, string date2, string roomtype, out string info);
        public abstract List<RoomTypes> AnalysePriceHtml(string html, string param, out string info);
        public abstract string QueryPriceHtml(string hid, string date1, string date2, out string info);
        public abstract string QueryPriceHtml(string hid, DateTime date1, DateTime date2, out string info);
        public virtual void InitLoad()
        { }
    }
}
