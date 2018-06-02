using HotelHttpBase;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HiltonHotelServer
{
    public class HiltonHttpServer : HotelHttpServer
    {
        /// <summary>
        /// https://secure3.hilton.com/zh_CN/hi/reservation/book.htm?ctyhocn=TAOGBHI&inputModule=HOTEL_SEARCH&arrivalDay=18&arrivalMonth=05&arrivalYear=2018&departureDay=19&departureMonth=05&departureYear=2018&redeemPts=false&promo_code=
        /// </summary>
        public HiltonHttpServer() : base(Platform.Hilton)
        {
            this._HotelServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            this._HotelServer.AcceptEncoding = "gzip, deflate, sdch";
            this._HotelServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            this._HotelServer.Host = "secure3.hilton.com";
            this._HotelServer.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.221 Safari/537.36 SE 2.X MetaSr 1.0";
            this._HotelServer.HeaderCollection.Add("Upgrade-Insecure-Requests", "1");
            this._HotelServer.Method = "get";
        }
        public override void InitLoad()
        {
            this._HotelServer.Url = "http://www.hilton.com.cn/zh-cn/";
            this._Result = this._HotelServer.GetHttpResult();
            this._HotelServer.Cookies = this._Result.Cookies;
            base.InitLoad();
        }
        public override string AnalyseHotelId(string html, out string info, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override List<RoomTypeEx> AnalysePriceHtml(string html, string param, out string info, params string[] paras)
        {
            info = "";
            List<RoomTypeEx> list = new List<RoomTypeEx>();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection roomtypes = doc.DocumentNode.SelectNodes("//*[@id=\"sortByRoom\"]/div/ul/li");
            var node = doc.GetElementbyId("sortByRoom");
            //roomtypes = doc.DocumentNode.SelectNodes("//div[@class=\"itemTitleAndDesc\"]");
            var raterooms = doc.DocumentNode.SelectNodes("//li[@class=\"rate\"]");
            RoomTypeEx room = null;
            Regex regbreakfirst = new Regex("</span>(?<breakfirst>.*?)<span");
            Regex regbedtype = new Regex("（(?<beg>.*?)）");
            foreach (var item in raterooms)
            {
                room = new RoomTypeEx() { CreateTime = DateTime.Now };
                room.Plat = this._plat;
                string srpId = item.SelectSingleNode("div[3]/form/input[@name=\"srpId\"]").Attributes["value"].Value;
                string roomCode = item.SelectSingleNode("div[3]/form/input[@name=\"roomCode\"]").Attributes["value"].Value;
                string travelAgentRate = item.SelectSingleNode("div[3]/form/input[@name=\"travelAgentRate\"]").Attributes["value"].Value;
                string accessibleFlag = item.SelectSingleNode("div[3]/form/input[@name=\"accessibleFlag\"]").Attributes["value"].Value;
                room.PlatformEx = new HiltenRoomEx() { roomCode = roomCode, srpId = srpId, accessibleFlag = accessibleFlag, travelAgentRate = travelAgentRate };
                if (paras.Length > 0)
                    room.HotelId = paras[0];
                if (paras.Length > 1)
                    room.HotelName = paras[1];
                room.PlatformPrivete = false;
                room.Name = item.SelectSingleNode("div/div/strong/a").ChildNodes[0].InnerText.Trim().Replace("详情", "");
                if (item.SelectSingleNode("div[2]/span").ChildNodes.Count != 5)
                    room.Price = Convert.ToInt32(item.SelectSingleNode("div[2]/span").InnerText.Trim().Replace("元人民币", "").Replace(",", ""));
                else
                    room.Price = Convert.ToInt32(item.SelectSingleNode("div[2]/span/ins").InnerText.Trim().Replace("元人民币", "").Replace(",", ""));
                try
                {
                    var matbreakfirst = regbreakfirst.Match(item.SelectSingleNode("div/div/strong/a").InnerHtml);
                    if (matbreakfirst.Success)
                    {
                        room.Breadfast = matbreakfirst.Groups["breakfirst"].Value.Trim();
                        room.Breadfast = room.Breadfast.Replace("提前预付", "");
                    }
                    var matbedtype = regbedtype.Match(room.Name);
                    if (matbedtype.Success)
                    {
                        room.BedType = matbedtype.Groups["beg"].Value;
                    }
                    var cancelnode = item.SelectSingleNode("div/div/span").InnerText.Trim(); if (cancelnode.Contains("不可"))
                        room.IsCancel = false;
                    else room.IsCancel = true;
                }
                catch (Exception ex)
                {
                    info = ex.ToString();
                    continue;
                }
                list.Add(room);
            }
            return list;
        }

        public override string GetCityID(string cityname, out string info, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override string GetHotelInfoHtml(string cityid, string hotelname, string param, out string info, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override string InitRequest(string hid, DateTime date1, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override string QueryPriceHtml(string hid, DateTime date1, out string info, params string[] paras)
        {
            return QueryPriceHtml(hid, date1, date1.AddDays(1), out info);
        }

        public override string QueryPriceHtml(string hid, string date1, out string info)
        {
            return QueryPriceHtml(hid, Convert.ToDateTime(date1), Convert.ToDateTime(date1).AddDays(1), out info);
        }

        /// <summary>
        /// https://secure3.hilton.com/zh_CN/hi/reservation/book.htm?ctyhocn=TAOGBHI&inputModule=HOTEL_SEARCH&arrivalDay=18&arrivalMonth=05&arrivalYear=2018&departureDay=19&departureMonth=05&departureYear=2018&redeemPts=false&promo_code=
        /// </summary>
        /// <param name="hid"></param>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public override string QueryPriceHtml(string hid, DateTime date1, DateTime date2, out string info, params string[] paras)
        {
            info = "";
            this._HotelServer.Url = "https://secure3.hilton.com/zh_CN/hi/reservation/book.htm?ctyhocn=TAOGBHI&inputModule=HOTEL_SEARCH&arrivalDay=18&arrivalMonth=05&arrivalYear=2018&departureDay=19&departureMonth=05&departureYear=2018&redeemPts=false&promo_code=";
            this._HotelServer.Url = "https://secure3.hilton.com/" + $@"zh_CN/hi/reservation/book.htm?ctyhocn={hid}&inputModule=HOTEL_SEARCH&arrivalDay={date1.Day}&arrivalMonth={date1.Month}&arrivalYear={date1.Year}&departureDay={date2.Day}&departureMonth={date2.Month}&departureYear={date2.Year}&redeemPts=false&promo_code=";
            this._HotelServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            this._HotelServer.AcceptEncoding = "gzip, deflate, sdch";
            this._HotelServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            this._HotelServer.Host = "secure3.hilton.com";
            this._HotelServer.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.221 Safari/537.36 SE 2.X MetaSr 1.0";
            this._HotelServer.HeaderCollection.Add("Upgrade-Insecure-Requests", "1");
            this._HotelServer.Method = "GET";
            this._HotelServer.Allowautoredirect = true;
            _Result = this._HotelServer.GetHttpResult();
            return _Result.Html;
        }

        public override string QueryPriceHtml(string hid, string date1, string date2, out string info, params string[] paras)
        {
            return QueryPriceHtml(hid, Convert.ToDateTime(date1), Convert.ToDateTime(date2), out info);
        }

        public override string QueryPriceHtml(string cityid, string hid, string date1, string date2, string roomtype, out string info, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override List<RoomTypeEx> RunRequest(string hid, DateTime date1, out string info, params string[] paras)
        {
            string html = QueryPriceHtml(hid, DateTime.Now.AddDays(4), out info, paras);
            var room = AnalysePriceHtml(html, "", out info, paras);
            return room;
        }
    }
}
