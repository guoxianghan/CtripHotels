using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpHotelServer;
using HttpHelper;
using Maticsoft.DAL;
using HtmlAgilityPack;
using System.Data;
using CommonHelper;
using System.Text.RegularExpressions;
using System.Threading;
using Maticsoft.Model;
using Newtonsoft.Json;
namespace HotelServerLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            PlatServer platserver = new PlatServer();
            var ds = platserver.GetList("");
            CtripHotelHttpServer ctrip = new CtripHotelHttpServer();
            HotelDetailViewServer h = new HotelDetailViewServer();
            HotelPriceServer priceserver = new HotelPriceServer();
            RoomsServer roomsserver = new RoomsServer();
            Logger.WriteLog("请输入要查询的ID范围,日期范围,用半角逗号分隔:");
            string v = Console.ReadLine();
            Logger.WriteLog(v,false);
            string city = "北京";
            string area = "北京西城区酒店";
            int count = h.GetRecordCount("[PlatID]=1 AND [City]='" + city + "'");
            Logger.WriteLog("正在加载所选酒店....");
            List<HotelDetailViewModel> list = h.GetModelList($"[PlatID]=1 AND [City]='北京' and id>=" + v.Split(',')[0] + " AND ID<=" + v.Split(',')[1]);//AND [AREA]='北京西城区酒店'
            //List<HotelDetailViewModel> list = h.GetModelList("hotelplatid ='439773'");//AND [AREA]='北京西城区酒店'
            Logger.WriteLog($"所选酒店{list.Count}条加载完毕");
            DataTable dtprice = DbHelperSQLEx.GetDataTable("SELECT TOP 1 * FROM HotelPrice");
            DataTable dtclone = dtprice.Clone();
            DataTable dtroom = DbHelperSQLEx.GetDataTable("SELECT TOP 1 * FROM Rooms");
            DataTable dtroomclone = dtroom.Clone();
            DateTime dtbegin = Convert.ToDateTime(v.Split(',')[2]);
            int days = (Convert.ToDateTime(v.Split(',')[3])-dtbegin).Days;
            Random ran = new Random(DateTime.Now.Millisecond);
            HotelDetailViewModel m = null;
            string parse_hotelid = "";
            DateTime parse_date;
            for (int i = 0; i < list.Count; i++)
            {
                m = list[i];
                for (int j = 0; j < days; j++)
                {
                    DateTime indate = dtbegin.AddDays(j);
                    DateTime outdate = dtbegin.AddDays(j + 1);
                    /*
                     *如果这个酒店天前更新过价格，则跳过
                     */
                    int cou = priceserver.GetRecordCount($"HotelPlatID='{m.HotelPlatID}' AND  PlatID={m.PlatID} AND InDate='{indate.ToString("yyyy-MM-dd")}' AND (UpdateDate>='{DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd")}'  or createdate>='{DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd")}' )");//SELECT COUNT(1)  FROM [HotelPrice] HP  WHERE HP.HotelPlatID='' AND HP.PlatID=1 AND HP.InDate='' AND UpdateDate>=''
                    if (cou != 0)
                    {
                        Console.WriteLine(m.HotelName + "," + indate.ToShortDateString() + ",3天内已更新过");
                        continue;
                    }
                    //Thread.Sleep(ran.Next(1000, 4000));
                    #region 模拟请求
                    string url = "http://hotels.ctrip.com/Domestic/tool/AjaxHote1RoomListForDetai1.aspx?psid=&MasterHotelID=" + m.HotelPlatID
                           + "&hotel=" + m.HotelPlatID + "&EDM=F&roomId=&IncludeRoom=&city=1&supplier=&showspothotel=T&IsDecoupleSpotHotelAndGroup=F&contrast=0&brand=614"
                           + "&startDate=" + indate.ToString("yyyy-MM-dd") + "&depDate=" + outdate.ToString("yyyy-MM-dd")
                           + "&IsFlash=F&RequestTravelMoney=F&hsids=&IsJustConfirm=&contyped=0&priceInfo=-1"
                           + "&equip=&filter=bed|0,bf|0,network|0,policy|0,hourroom|0,&productcode=&couponList=&abForHuaZhu=&defaultLoad=F"
                           + "&eleven=510e429809230c4b002cb9b567b407adb56118e161f3dbe20d2855dc652ff6a6&callback=CASJacaauulJVNspCzn&_=1506613336689"; ;
                    string referer = "http://hotels.ctrip.com/hotel/" + m.HotelPlatID + ".html";
                    string log = m.HotelName + "," + referer + "," + indate.ToString("yyyy-MM-dd");
                    //Console.WriteLine(log);
                    Thread.Sleep(ran.Next(2000, 5000));
                    string html = ctrip.GetRequest(url, referer);
                    CtripHotelPriceJSON json = null;
                    try
                    {
                        json = Newtonsoft.Json.JsonConvert.DeserializeObject<CtripHotelPriceJSON>(html);
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(JsonConvert.SerializeObject(m));
                        Thread.Sleep(ran.Next(5000, 10000));
                        Logger.WriteLog(referer);
                        continue;
                    }
                    #endregion
                    string d = json.html.Replace("\\/", "/").Replace("\\u000a", "").Replace("\\u0009", "");

                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(d);
                    List<RoomsModel> rooms = new List<RoomsModel>();

                    var room_types = doc.DocumentNode.SelectNodes("//td[contains(@class,'room_type')]");
                    RoomsModel r = null;
                    HotelPriceModel p = null;
                    if (room_types == null)
                    {
                        Logger.WriteLog(log + "  没有查询到房间");
                        continue;
                    }
                    else
                    {
                        Logger.WriteLog(log + "");
                    }
                    foreach (var item in room_types)
                    {
                        List<HotelPriceModel> prices = new List<HotelPriceModel>();
                        #region 所有房型
                        r = new RoomsModel();
                        r.PlatID = 1;
                        r.CreateDate = DateTime.Now;
                        r.HotelID = m.HotelID;
                        r.HotelPlatID = m.HotelPlatID;
                        r.BaseRoomID = item.ParentNode.SelectSingleNode("td").Id;
                        r.RoomName = item.InnerText.Trim().Split('\n')[0];
                        var c = DbHelperSQL.GetSingle("SELECT   COUNT(1)  FROM [Rooms]  WHERE [HotelPlatID]='" + m.HotelPlatID + "' AND PlatID=" + m.PlatID + " AND BaseRoomID='" + r.BaseRoomID + "'");
                        if (Convert.ToInt32(c.ToString()) == 0)
                        {
                            roomsserver.Add(r);
                        }
                        rooms.Add(r);
                        var roomprices = doc.DocumentNode.SelectNodes("//tr[@brid=" + r.BaseRoomID + "]");
                        //roomprices.RemoveAt(0);
                        int coun = 0;
                        foreach (var node in roomprices)
                        {//子房型
                            #region 子房型以及价格
                            p = new HotelPriceModel();
                            p.CreateDate = DateTime.Now;
                            p.HotelID = m.HotelID;
                            p.HotelPlatID = r.HotelPlatID;
                            p.PlatID = m.PlatID;
                            p.BaseRoomID = r.BaseRoomID;
                            p.InDate = indate;
                            p.OutDate = outdate;

                            var nodeprice = node.SelectSingleNode("td/div/a");
                            if (nodeprice == null)
                                continue;
                            string price = "";
                            try
                            {
                                price = nodeprice.Attributes["data-order"].Value;
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }
                            string[] pp = price.Split(',');
                            decimal ppp = Convert.ToDecimal(nodeprice.Attributes["data-price"].Value);
                            p.RoomID = pp[0];
                            p.Price = ppp - Convert.ToDecimal(pp[6]);
                            var t = node.SelectSingleNode("td/span[@class='room_type_name']");
                            if (t != null)
                                p.SaleTitle = t.InnerText;
                            if (string.IsNullOrEmpty(p.SaleTitle))
                            {
                                p.SaleTitle = t.SelectSingleNode("span[@class=\"supplier_logo\"]").Attributes["style"].Value;//.Replace("", "").Replace("","");
                            }
                            if (node.SelectSingleNode("td/span[2]") != null)
                                p.SaleTitle = p.SaleTitle + node.SelectSingleNode("td/span[2]").InnerText;
                            p.Tag = nodeprice.InnerText;// nodeprice.ParentNode.ParentNode.ParentNode.SelectSingleNode("//div[@class=\"btns_base22_skin02\"]").InnerText;

                            p.IsCancel = pp[11];
                            p.BedType = pp[9];
                            p.BreakfirstType = Convert.ToInt32(pp[10]);
                            p.RoomCount = node.SelectSingleNode("td/div/div").InnerText;
                            var modellist = priceserver.GetModelList($@"SaleTitle='{p.SaleTitle}' and BedType='{p.BedType}' and BreakfirstType='{p.BreakfirstType}' and InDate='{p.InDate.ToString("yyyy-MM-dd")}' and OutDate='{p.OutDate.ToString("yyyy-MM-dd")}'
and PlatID={p.PlatID} and RoomID='{p.RoomID}' and HotelPlatID='{p.HotelPlatID}' and BaseRoomID='{p.BaseRoomID}'");
                            coun++;
                            if (coun <= 4)
                            {
                                if (!p.SaleTitle.Contains("代理") && !p.Tag.Contains("担保") && !p.Tag.Contains("到店付"))
                                    p.IsAgentPrivate = true;
                            }
                            prices.Add(p);
                            if (modellist.Count > 0)
                            {//更新价格 
                                priceserver.UpdatePrice(p.Price, modellist[0].ID);
                            }
                            else
                            {//添加 
                                if (p.IsAgentPrivate)//只保存携程自营的价格
                                    try
                                    {
                                        priceserver.Add(p);
                                    }
                                    catch (Exception e)
                                    {
                                        Logger.WriteException(e);
                                        Logger.WriteLog(e.Message);
                                    }
                            }
                            #endregion
                            Logger.WriteLog("携程自营价格" + prices.FindAll(x => x.IsAgentPrivate).Count() + "条," + m.HotelPlatName + "," + r.RoomName + ",[" + indate.ToShortDateString() + "," + m.HotelPlatID +","+m.ID+ "]");
                        }
                        #endregion

                    }
                }
                Console.WriteLine("=========================================");
                Console.WriteLine("查询完毕");
                Console.WriteLine("=========================================");
            }
            Console.WriteLine("所有酒店查询完毕");
            Console.ReadKey();
        }
    }
}
