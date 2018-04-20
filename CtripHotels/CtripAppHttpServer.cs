using HttpHotelServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelPriceModel;
using HttpHelper;
using HtmlAgilityPack;
namespace CtripHotels
{
    public class CtripAppHttpServer : HotelHttpServer
    {
        public CtripAppHttpServer() : base(Platform.CtripApp)
        {
            _CtripServer = new HttpServer();
            _CtripServer.Host = "m.ctrip.com";
            _CtripServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
        }
        /// <summary>
        /// http://m.ctrip.com/html5/hotel/sitemap-beijing1
        /// </summary>
        /// <param name="areacode"></param>
        /// <returns></returns>
        public List<string> Index(string areacode = "sitemap-beijing1")
        {
            List<string> list = new List<string>();
            this._CtripServer.Url = "http://m.ctrip.com/html5/hotel/" + areacode;
            this._Result = this._CtripServer.GetHttpResult();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(_Result.Html);
            var nodes = doc.DocumentNode.SelectNodes("//a[@class=\"line2items\"]");
            foreach (HtmlNode item in nodes)
            {
                list.Add(item.Attributes["href"].Value);
            }
            return list;
        }
        /*
         *  HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(_Result.Html);
            var nodes = doc.DocumentNode.SelectNodes("//a[@class=\"no\"]");
            foreach (HtmlNode item in nodes)
            {
                list.Add(item.Attributes["href"].Value);
            }
         */
        /// <summary>
        /// "http://"+_CtripServer.Host+url;
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetHotelUrls(string url)
        {
            List<string> list = new List<string>();
            this._CtripServer.Url = url;
            _CtripServer.Method = "get";
            this._Result = this._CtripServer.GetHttpResult();
           
            return _Result.Html;
        }
        public override string AnalyseHotelId(string html, out string info)
        {
            throw new NotImplementedException();
        }

        public override List<RoomTypes> AnalysePriceHtml(string html, string param, out string info)
        {
            throw new NotImplementedException();
        }

        public override string GetCityID(string cityname, out string info)
        {
            throw new NotImplementedException();
        }

        public override string GetHotelInfoHtml(string cityid, string hotelname, string param, out string info)
        {
            throw new NotImplementedException();
        }

        public override string QueryPriceHtml(string cityid, string hid, string date1, string date2, string roomtype, out string info)
        {
            throw new NotImplementedException();
        }

        public override string QueryPriceHtml(string hid, string date1, string date2, out string info)
        {
            throw new NotImplementedException();
        }

        public override string QueryPriceHtml(string hid, DateTime date1, DateTime date2, out string info)
        {
            throw new NotImplementedException();
        }
    }
}
