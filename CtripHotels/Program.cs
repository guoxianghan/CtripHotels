using System;
using System.Collections.Generic;
using HttpHelper;
using Maticsoft.DAL;
using HtmlAgilityPack;
using System.Data;
using CommonHelper;
using System.Text.RegularExpressions;
using System.Threading;

namespace CtripHotelServer
{
    class Program
    {
        static void Main(string[] args)
        {
            FindHotelStar("sitemap-beijing1", "3");
            FindHotelStar("sitemap-beijing1", "4");
            FindHotelStar("sitemap-beijing1", "5");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="citymap"></param>
        /// <param name=""></param>
        /// <param name="star"></param>
        private static void FindHotelStar(string citymap = "sitemap-beijing1", string star = "3")
        {
            HotelServer server = new Maticsoft.DAL.HotelServer();
            HotelDetailViewServer vserver = new HotelDetailViewServer();
            HotelDetailServer dserver = new HotelDetailServer();
            HttpServer http = new HttpServer();
            HttpResult result;
            //string star = "5";//星级,3,4,5
            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
            http.Host = "m.ctrip.com";
            http.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            http.AcceptEncoding = "gzip,deflate,sdch";
            http.AcceptLanguage = "zh-CN,zh;q=0.8";
            http.Method = "get";
            http.Referer = "http://m.ctrip.com/html5/hotel/" + citymap + "/star" + star;
            http.Url = "http://m.ctrip.com/html5/hotel/" + citymap + "/star" + star + "/1";
            result = http.GetHttpResult();
            doc.LoadHtml(result.Html);
            var nodes = doc.DocumentNode.SelectNodes("//a[@class=\"noramla ainfooter\"]");
            if (nodes == null || nodes.Count == 0)
            {
                Console.WriteLine("获取的HTML有错误");
            }
            for (int i = 1; i <= nodes.Count; i++)
            {
                Random ran = new Random(DateTime.Now.Millisecond);
                Thread.Sleep(ran.Next(2000, 5000));
                http.Url = "http://m.ctrip.com/html5/hotel/"+ citymap + "/star" + star + "/" + i;
                result = http.GetHttpResult();
                doc.LoadHtml(result.Html);
                var hotelnodes = doc.DocumentNode.SelectNodes("//a[@class=\"noramla line2items\"]");//j获取酒店节点
                if (hotelnodes == null || hotelnodes.Count == 0)
                {
                    Console.WriteLine("获取的HTML有错误");
                    continue;
                }
                foreach (var item in hotelnodes)
                {
                    string id = Regex.Match(item.Attributes["href"].Value, @"/(?<id>\d+)\.").Groups[1].Value;
                    var list = vserver.GetModelList($"HotelPlatID='{id}' and PlatID='1'");
                    if (list.Count == 0)
                    {
                        int newid = server.Add(new Maticsoft.Model.HotelModel() { City = "北京", HotelName = item.InnerText, Star = Convert.ToInt32(star), CreateDate = DateTime.Now });
                        int nid = dserver.Add(new Maticsoft.Model.HotelDetailModel() { HotelPlatID = id, PlatID = 1, HotelID = newid, HotelName = item.InnerText, CreateDate = DateTime.Now });
                    }
                    list = vserver.GetModelList($"HotelPlatID='{id}' and PlatID='1'");
                    int cou = DbHelperSQL.ExecuteSql("UPDATE [Hotel] set [Star]=" + star + "WHERE ID=" + list[0].HotelID);
                    Console.WriteLine($"{id},{item.InnerText}");
                }
                Console.WriteLine($"北京{star}星级,第{i}页查询完毕");
            }
        }
        private static void GetAllHotelInfo()
        {
            PlatServer p = new PlatServer();
            var ds = p.GetList("");
            HttpServer http = new HttpServer();
            HttpResult result;
            http.Host = "hotels.ctrip.com";
            http.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            http.AcceptEncoding = "gzip,deflate,sdch";
            http.AcceptLanguage = "zh-CN,zh;q=0.8";
            http.Method = "get";
            //http.Url = "http://hotels.ctrip.com/hotel/511769.html#ctm_ref=hod_hp_hv_def_n_1";
            http.Url = "http://hotels.ctrip.com/hotel/473871.html#ctm_ref=hod_hp_hv_def_n_1";
            result = http.GetHttpResult();
            http.Referer = "http://hotels.ctrip.com/hotel/6074225.html";
            http.Url = "http://hotels.ctrip.com/Domestic/tool/AjaxHote1RoomListForDetai1.aspx?psid=&MasterHotelID=6074225"
                + "&hotel=6074225&EDM=F&roomId=&IncludeRoom=&city=1&supplier=&showspothotel=T&IsDecoupleSpotHotelAndGroup=F&contrast=0&brand=614"
                + "&startDate=2017-10-03&depDate=2017-10-04"
                + "&IsFlash=F&RequestTravelMoney=F&hsids=&IsJustConfirm=&contyped=0&priceInfo=-1"
                + "&equip=&filter=bed|0,bf|0,network|0,policy|0,hourroom|0,&productcode=&couponList=&abForHuaZhu=&defaultLoad=F"
                + "&eleven=510e429809230c4b002cb9b567b407adb56118e161f3dbe20d2855dc652ff6a6&callback=CASJacaauulJVNspCzn&_=1506613336689";
            result = http.GetHttpResult();

            CtripAppHttpServer c = new CtripAppHttpServer();
            string city = "青岛";
            List<string> listurl = c.Index("sitemap-qingdao7");
            DataTable dtHotelDetail = DbHelperSQLEx.GetDataTable("SELECT TOP (1) * FROM HotelDetail");

            DataTable dtHotel = DbHelperSQLEx.GetDataTable("SELECT TOP (1) * FROM Hotel");
            List<string> idlist = new List<string>();
            foreach (var item in listurl)
            {
                DataTable dtcHotelDetail = dtHotelDetail.Clone();
                var dtcHotel = dtHotel.Clone();
                string html = c.GetHotelUrls("http://m.ctrip.com" + item);
                Console.WriteLine("http://m.ctrip.com" + item);
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                var nodes = doc.DocumentNode.SelectNodes("//a[@class=\"noramla ainfooter\"]");
                //*[@id="client_id_viewport_239538_1506702718553"]/div[3]/a[1]
                List<string> pagehotel = new List<string>();

                if (pagehotel.Count == 0)
                {

                }
                if (nodes != null)
                {
                    //foreach (var url in nodes)
                    //{
                    //    pagehotel.Add("http://m.ctrip.com" + url.Attributes["href"].Value);
                    //}
                }
                else
                {
                    pagehotel.Add("http://m.ctrip.com" + item);
                    foreach (var url in pagehotel)
                    {
                        //每一页酒店列表
                        string area = "";
                        html = c.GetHotelUrls(url);

                        Console.WriteLine(url);

                        Console.Write(html);
                        doc = new HtmlDocument();
                        doc.LoadHtml(html);
                        nodes = doc.DocumentNode.SelectNodes("//a[@class=\"noramla line2items\"]");//j获取酒店节点
                        if (nodes == null)
                        {
                            Logger.WriteLog(url);
                            continue;
                        }
                        area = doc.DocumentNode.SelectSingleNode("//h2").InnerText;
                        //nodes.ToList().ForEach(x => { });
                        foreach (var hotel in nodes)
                        {
                            #region MyRegion
                            string id = "";
                            try
                            {
                                id = Regex.Match(hotel.Attributes["href"].Value, @"/(?<id>\d+)\.").Groups[1].Value;
                            }
                            catch (ArgumentException ex)
                            {
                                // Syntax error in the regular expression
                                continue;
                            }

                            string name = hotel.InnerText;
                            var count = DbHelperSQL.GetSingle("SELECT   COUNT(1)  FROM [HotelDetail]  WHERE [HotelPlatID]='" + id + "' AND PlatID=1");
                            if (Convert.ToInt32(count.ToString()) > 0)
                                continue;
                            var row = dtcHotelDetail.NewRow();
                            var r = dtcHotel.NewRow();
                            r["HotelName"] = name;
                            r["City"] = city;
                            r["Area"] = area;
                            r["Star"] = 0;
                            r["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            row["HotelID"] = id;
                            row["PlatID"] = 1;
                            row["HotelPlatID"] = id;
                            row["HotelName"] = name;
                            row["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            dtcHotelDetail.Rows.Add(row);
                            dtcHotel.Rows.Add(r);
                            #endregion
                        }
                        DbHelperSQLEx.SqlBuckCopy(dtcHotelDetail, "HotelDetail");
                        DbHelperSQLEx.SqlBuckCopy(dtcHotel, "Hotel");
                        dtcHotelDetail.Rows.Clear();
                        dtcHotel.Rows.Clear();
                    }
                    continue;
                }
                //page
                foreach (var url in nodes)
                {//每一页酒店列表
                    Random ran = new Random(DateTime.Now.Millisecond);
                    Thread.Sleep(ran.Next(5000, 10000));
                    string area = "";
                    html = c.GetHotelUrls("http://m.ctrip.com" + url.Attributes["href"].Value);
                    doc = new HtmlDocument();
                    doc.LoadHtml(html);

                    Console.WriteLine("http://m.ctrip.com" + url.Attributes["href"].Value);

                    Console.Write(html);
                    var nodes2 = doc.DocumentNode.SelectNodes("//a[@class=\"noramla line2items\"]");//j获取酒店节点//noramla line2items
                    if (nodes2 == null)
                    {
                        Logger.WriteLog("http://m.ctrip.com" + url.Attributes["href"].Value);
                        continue;
                    }
                    area = doc.DocumentNode.SelectSingleNode("//h2").InnerText;
                    //nodes.ToList().ForEach(x => { });
                    foreach (var hotel in nodes2)
                    {
                        #region MyRegion
                        string id = "";
                        try
                        {
                            id = Regex.Match(hotel.Attributes["href"].Value, @"/(?<id>\d+)\.").Groups[1].Value;
                        }
                        catch (ArgumentException ex)
                        {
                            // Syntax error in the regular expression
                            continue;
                        }
                        var count = DbHelperSQL.GetSingle("SELECT   COUNT(1)  FROM [HotelDetail]  WHERE [HotelPlatID]='" + id + "' AND PlatID=1");
                        if (Convert.ToInt32(count.ToString()) > 0)
                            continue;
                        string name = hotel.InnerText;

                        var row = dtcHotelDetail.NewRow();
                        var r = dtcHotel.NewRow();
                        r["HotelName"] = name;
                        r["City"] = city;
                        r["Area"] = area;
                        r["Star"] = 0;
                        r["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                        row["HotelID"] = id;
                        row["PlatID"] = 1;
                        row["HotelPlatID"] = id;
                        row["HotelName"] = name;
                        row["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dtcHotelDetail.Rows.Add(row);
                        dtcHotel.Rows.Add(r);
                        #endregion
                    }
                    DbHelperSQLEx.SqlBuckCopy(dtcHotelDetail, "HotelDetail");
                    DbHelperSQLEx.SqlBuckCopy(dtcHotel, "Hotel");
                    dtcHotelDetail.Rows.Clear();
                    dtcHotel.Rows.Clear();
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine(city + "查询完毕");
            Console.WriteLine("=========================================");
        }
    }
}
