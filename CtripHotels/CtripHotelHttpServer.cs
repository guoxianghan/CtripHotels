using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpHelper;
using CommonHelper;
using System.Web;
using Newtonsoft.Json;
using HtmlAgilityPack;
using HotelPriceModel;
using Maticsoft.Model;

namespace HttpHotelServer
{
    public class CtripHotelHttpServer : HotelHttpServer
    {

        public CtripHotelHttpServer() : base(Platform.Ctrip)
        {
            _CtripServer = new HttpServer();
            _CtripServer.Host = "hotels.ctrip.com";
            _CtripServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
        }

        public string GetRequest(string url, string referer)
        {
            _CtripServer.Host = "hotels.ctrip.com";
            _CtripServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            _CtripServer.Method = "get";
            _CtripServer.Url = url;
            _CtripServer.Referer = referer;
            _Result = _CtripServer.GetHttpResult();
            return _Result.Html;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityid">城市ID</param>
        /// <param name="hotelname">酒店名称</param>
        /// <param name="branchoffice">分店名称</param>
        public override string GetHotelInfoHtml(string cityid, string hotelname, string param, out string info)
        {
            info = "";
            string kword = hotelname;
            _CtripServer.Url = "http://hotels.ctrip.com/hotel/" + cityid + "/k1" + HttpUtility.UrlEncode(kword);
            _CtripServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            //青岛途家斯维登度假公寓（万科金色广场）
            //青岛途家斯维登度假公寓（万科金色广场店）
            //_CtripServer.Url = "http://hotels.ctrip.com/hotel/" + cityid + "/k1%E9%9D%92%E5%B2%9B%E4%B8%BD%E6%99%B6%E5%A4%A7%E9%85%92%E5%BA%97";
            _Result = _CtripServer.GetHttpResult();
            //_CtripServer.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHotelPriceNew.aspx?distinct=0&city=7&type=new&psid=&hotel=430840&&RequestTravelMoney=F&promotion=F&prepay=F&IsCanReserve=F&IsJustConfirm=F&equip=&OrderBy=zhisou&OrderType=desc&startDate=2016-06-27&depDate=2016-06-28&couponlist=&index=1&productcode=&page=1&rs=1&priceInfo=-1&contyped=0&abForHuaZhu=";
            //_Result = _CtripServer.GetHttpResult();
            return _Result.Html;
        }
        public override string GetCityID(string cityname, out string info)
        {
            info = "";
            string cityid;
            try
            {
                _CtripServer.Url = "http://hotels.ctrip.com/Domestic/Tool/AjaxIndexCityNew.aspx?keyword=" + cityname + "&from=domestic";
                _CtripServer.Accept = "*/*";
                _CtripServer.Referer = "http://hotels.ctrip.com/Domestic/Tool/AjaxIndexCityNew.aspx?keyword=%25u5373%25u58A8&from=domestic";
                _Result = _CtripServer.GetHttpResult();
                string json = _Result.Html.Replace("cQuery.jsonpResponse=", "").Trim('@', ';');
                CtripCityJson city = Newtonsoft.Json.JsonConvert.DeserializeObject<CtripCityJson>(json);
                string[] arrs = city.data.Trim('@').Split('@');
                cityid = arrs[0].Split('|')[0] + arrs[0].Split('|')[2];
            }
            catch (Exception ex)
            {
                info = _Result.Html;
                return "";
            }
            return cityid.ToLower();
        }

        public override string AnalyseHotelId(string html, out string info)
        {
            info = "";
            string hotelid = "";
            try
            {
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                string count = doc.GetElementbyId("lblAmount").InnerText;
                HtmlNode hostlistNode = doc.GetElementbyId("hotel_list");
                HtmlNodeCollection listNode = hostlistNode.SelectNodes("div[@class=\"searchresult_list searchresult_list2\"]");
                if (listNode == null)
                    listNode = hostlistNode.SelectNodes("div[@class=\"searchresult_list \"]");
                if (listNode != null && listNode.Count > 1)
                {
                    hotelid = listNode[0].Attributes["id"].Value;
                }
            }
            catch (Exception ex)
            {
                info = ex.Message;
                return "";
            }
            return hotelid;
        }
        public override string QueryPriceHtml(string cityid, string hid, string date1, string date2, string roomtype, out string info)
        {
            info = "";
            //_CtripServer.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHotelPriceNew.aspx?distinct=0"
            //    + "&city=" + cityid + "&type=new&psid="
            //    + "&hotel=" + hid + "&&RequestTravelMoney=F&promotion=F&prepay=F&IsCanReserve=F&IsJustConfirm=F&equip=&OrderBy=zhisou&OrderType=desc"
            //    + "&startDate=" + date1
            //    + "&depDate=" + date2
            //    + "&couponlist=&index=1&productcode=&page=1&rs=1&priceInfo=-1&contyped=0&abForHuaZhu=";
            //_CtripServer.Accept = "*/*";
            //_CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            //_CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            //_CtripServer.Referer = "http://hotels.ctrip.com/hotel/" + cityid + "/k1%E9%9D%92%E5%B2%9B%E4%B8%BD%E5%A4%A9%E5%A4%A7%E9%85%92%E5%BA%97";
            //_Result = _CtripServer.GetHttpResult();
            _CtripServer.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHote1RoomListForDetai1.aspx?psid=&MasterHotelID=" + hid + "&hotel=" + hid
                + "&EDM=F&roomId=&IncludeRoom=&city=7&supplier=&showspothotel=T&IsDecoupleSpotHotelAndGroup=F&contrast=0&brand=0"
                + "&startDate=" + date1
                + "&depDate=" + date2
                + "&IsFlash=F&RequestTravelMoney=F&hsids=&IsJustConfirm=&contyped=0&priceInfo=-1&equip=&filter=bed|0,bf|0,network|0,policy|0,&productcode=&couponList=&abForHuaZhu=&eleven=1b3dcf5bf1081d0b1defd543ff3fa748&callback=CASJHbHQhgKUshiCWvw&_=1478828067323";
            //_CtripServer.Accept = "*/*";
            _CtripServer.Method = "get";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            _CtripServer.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            //_CtripServer.HeaderCollection.Add("If-Modified-Since", "Thu, 01 Jan 1970 00:00:00 GMT");
            //this._CtripServer.IfModifiedSince = DateTime.Now;
            _CtripServer.Referer = "http://hotels.ctrip.com/hotel/" + hid + ".html?isFull=F";
            _Result = _CtripServer.GetHttpResult();
            return _Result.Html;
        }

        public override List<RoomTypeEx> AnalysePriceHtml(string html, string param, out string info)
        {
            info = "";

            //List<CtripRoom> ctriproomlist = new List<CtripRoom>();
            List<RoomTypeEx> list = new List<RoomTypeEx>();
            CtripPriceHtml pricehtml = null;
            try
            {
                pricehtml = JsonConvert.DeserializeObject<CtripPriceHtml>(html);
            }
            catch (Exception ex)
            {
                info = ex.ToString();
            }
            if (pricehtml == null)
                return list;
            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(pricehtml.html);
            var nodes = doc.DocumentNode.SelectNodes("//tr[@expand]");
            var roomtypes = nodes.GroupBy(x => x.Attributes["brid"].Value);
            RoomTypeEx r = null;
            foreach (var item in roomtypes)
            {
                var roomtype = doc.DocumentNode.SelectSingleNode("//tr[@expand=\"\" and @class=\"\" and @ brid=\"" + item.Key + "\"]");
                if (roomtype == null)
                    continue;
                string roomtypename = "";
                try
                {
                    roomtypename = roomtype.SelectNodes("td")[0].InnerText.Trim().Replace("\n", "").Replace("查看详情", "").Trim();
                }
                catch (Exception ex)
                {
                    info = ex.ToString();
                }
                foreach (var i in item)
                {
                    if (i.SelectSingleNode("td/span[@class=\"room_type_name\"]").SelectSingleNode("span") != null)
                    { continue; }
                    int price = 0;
                    r = new RoomTypeEx();
                    r.HotelId = param;
                    r.Name = roomtypename;
                    r.CreateTime = DateTime.Now;
                    try
                    {
                        if ((i.SelectSingleNode("td/span[@class=\"room_policy\"]")).InnerText.Contains("不可取消"))
                            r.IsCancel = false;
                        else r.IsCancel = true;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        bool isnum = Int32.TryParse(i.SelectSingleNode("td/div/a").Attributes["data-price"].Value, out price);
                        if (!isnum)
                            continue;
                        r.Price = price;
                    }
                    catch (Exception ex)
                    {
                        info = ex.ToString();
                        continue;
                    }
                    if (i.Equals(item.ToArray()[0]))
                    {
                        r.BedType = i.SelectNodes("td")[2].InnerText;
                        r.Breadfast = i.SelectNodes("td")[3].InnerText;
                        //bool isnum = Int32.TryParse(i.SelectSingleNode("td/div/a").Attributes["data-price"].Value, out price);
                        //if (!isnum)
                        //    continue;
                        //r.Price = price;

                    }
                    else
                    {
                        r.BedType = i.SelectNodes("td")[1].InnerText;
                        r.Breadfast = i.SelectNodes("td")[2].InnerText;
                        //bool isnum = Int32.TryParse(i.SelectSingleNode("td/div/a").Attributes["data-price"].Value, out price);
                        //if (!isnum)
                        //    continue;
                        //r.Price = price;

                    }
                    list.Add(r);
                }
            }
            return list;
        }

        public string CompareHtml(string hotelid, string date1, string date2)
        {
            //info = "";
            //_CtripServer.Url = "http://hotels.ctrip.com/domestic/ComparePriceNew/RoomList";
            //_CtripServer.Accept = "*/*";
            //_CtripServer.Method = "post";
            //_CtripServer.PostData = "type=1&hotelId=" + hotelid + "&checkIn=" + date1 + "&checkOut=" + date2 + "&edm=&pagetype=&useFPGP=&contyped=0&productcode=";
            //_CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            //_CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            //_CtripServer.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            //_CtripServer.Referer = "http://hotels.ctrip.com/hotel/" + hotelid + ".html?isFull=F";
            //_Result = _CtripServer.GetHttpResult();
            _CtripServer.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHote1RoomListForDetai1.aspx?psid=&MasterHotelID=" + hotelid + "&hotel=" + hotelid
                + "&EDM=F&roomId=&IncludeRoom=&city=7&supplier=&showspothotel=T&IsDecoupleSpotHotelAndGroup=F&contrast=0&brand=0"
                + "&startDate=" + date1
                + "&depDate=" + date2
                + "&IsFlash=F&RequestTravelMoney=F&hsids=&IsJustConfirm=&contyped=0&priceInfo=-1&equip=&filter=bed|0,bf|0,network|0,policy|0,&productcode=&couponList=&abForHuaZhu=&eleven=1b3dcf5bf1081d0b1defd543ff3fa748&callback=CASJHbHQhgKUshiCWvw&_=1478828067323";
            //_CtripServer.Accept = "*/*";
            _CtripServer.Method = "get";
            _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
            _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
            _CtripServer.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            _CtripServer.HeaderCollection.Add("If-Modified-Since", "Thu, 01 Jan 1970 00:00:00 GMT");
            _CtripServer.Referer = "http://hotels.ctrip.com/hotel/" + hotelid + ".html?isFull=F";
            _Result = _CtripServer.GetHttpResult();


            return _Result.Html;
        }

        public override string QueryPriceHtml(string hid, string date1, string date2, out string info)
        {
            info = "";
            string html = "";
            try
            {
                _CtripServer.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHote1RoomListForDetai1.aspx?psid=&MasterHotelID=" + hid
                           + "&hotel=" + hid + "&EDM=F&roomId=&IncludeRoom=&city=1&supplier=&showspothotel=T&IsDecoupleSpotHotelAndGroup=F&contrast=0&brand=614"
                           + "&startDate=" + date1 + "&depDate=" + date2;
                _CtripServer.Referer = "http://hotels.ctrip.com/hotel/" + hid + ".html";
                _CtripServer.Method = "get";
                _CtripServer.AcceptEncoding = "gzip,deflate,sdch";
                _CtripServer.AcceptLanguage = "zh-CN,zh;q=0.8";
                _CtripServer.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                //_CtripServer.HeaderCollection.Add("If-Modified-Since", "Thu, 01 Jan 1970 00:00:00 GMT");
                _CtripServer.IfModifiedSince = DateTime.Parse("1970 01-01 01:00:00");
                _Result = _CtripServer.GetHttpResult();
                //string html2 = CompareHtml(hid, date1, date2);
                html = _Result.Html;
            }
            catch (Exception ex)
            {
                info = ex.ToString();
            }
            return html;
        }

        public override string QueryPriceHtml(string hid, DateTime date1, DateTime date2, out string info)
        {
            string html = QueryPriceHtml(hid, date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"), out info);
            return html;
        }

        public override string QueryPriceHtml(string hid, string date1, out string info)
        {
            DateTime d = Convert.ToDateTime(date1);
            return QueryPriceHtml(hid, d, d.AddDays(1), out info);
        }

        public override string QueryPriceHtml(string hid, DateTime date1, out string info)
        {
            return QueryPriceHtml(hid, date1, date1.AddDays(1), out info);
        }

        public override string InitRequest(string hid, DateTime date1, params string[] paras)
        {
            throw new NotImplementedException();
        }

        public override List<RoomTypeEx> RunRequest(string hid, DateTime date1,out string info ,params string[] paras)
        {
            
            string html = this.GetRequest("http://hotels.ctrip.com/hotel/" + hid + ".html#ctm_ref=hod_hp_hot_dl_n_2_1", "");
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            string name = doc.DocumentNode.SelectSingleNode("//*[@id=\"J_htl_info\"]/div[2]/h2[1]")?.InnerText;
            string html7 = this.QueryPriceHtml(hid, date1, date1.AddDays(1), out info);
            var rrrrr = this.AnalysePriceHtml(html7, hid, out info);
            rrrrr.ForEach(x => x.HotelName = name);
            return rrrrr;
        }
    }
    public class CtripCityJson
    {
        public string key { get; set; }
        public string data { get; set; }
    }
    public class CtripRoom
    {
        public string RoomType { get; set; }
        public List<CtripRoomlist> roomlist { get; set; } = new List<CtripRoomlist>();
    }
}
