
using HttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHttpBase
{
    public abstract class HotelHttpServer
    {
        protected HotelHttpServer(Platform plat)
        {
            _plat = plat;
            _HotelServer = new HttpServer();
        }
        public HttpServer _HotelServer;
        public HttpResult _Result;
        public Platform _plat { get; set; }

        public virtual string GetRequest(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public abstract string GetCityID(string cityname, out string info, params string[] paras);
        public abstract string GetHotelInfoHtml(string cityid, string hotelname, string param, out string info, params string[] paras);
        public abstract string AnalyseHotelId(string html, out string info, params string[] paras);
        public abstract string QueryPriceHtml(string cityid, string hid, string date1, string date2, string roomtype, out string info, params string[] paras);
        public abstract List<RoomTypeEx> AnalysePriceHtml(string html, string param, out string info, params string[] paras);
        public abstract string QueryPriceHtml(string hid, string date1, string date2, out string info, params string[] paras);
        public abstract string QueryPriceHtml(string hid, string date1, out string info);
        public abstract string QueryPriceHtml(string hid, DateTime date1, DateTime date2, out string info, params string[] paras);
        public abstract string QueryPriceHtml(string hid, DateTime date1, out string info, params string[] paras);
        public abstract string InitRequest(string hid, DateTime date1, params string[] paras);
        public abstract List<RoomTypeEx> RunRequest(string hid, DateTime date1, out string info, params string[] paras);
        public virtual void InitLoad()
        { }
    }
}
