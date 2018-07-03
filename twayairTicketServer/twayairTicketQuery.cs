using CommonHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twayairTicketServer
{
    public class twayairTicketQuery : IQueryTicket
    {
        public twayairTicketQuery()
        {
            this._LoginServer.Url = "https://www.twayair.com/main.do?_langCode=ZH";
            this._LoginServer.Host = "www.twayair.com";
        }
        public override void Init()
        {
            this._LoginServer.Url = "https://www.twayair.com/main.do?_langCode=ZH";
            this._LoginServer.Host = "www.twayair.com";
            this._LoginServer.Method = "get";
            this._Result = this._LoginServer.GetHttpResult();
            base.Init();
        }
        public override string QueryTicket(string[] go, bool isoneway, DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public override string QueryTicket(string go, string at, bool isoneway, DateTime date1, DateTime date2)
        {
            this._LoginServer.Cookies = this._Result.Cookies;
            this._LoginServer.Allowautoredirect = true;
            this._LoginServer.Url = "https://www.twayair.com/booking/searchAvailability.do";
            this._LoginServer.PostData = "origin=KIX&destination=ICN"
                +"&onwardDateStr=20180728&returnDateStr=&pointOfPurchase=JP&paxTypeCountStr=1%2C0%2C0"
                +"&today=20180704"
                +"&domesticYn=N&currencyCode=JPY&routeCls=AS&travelType=OW&dpturArprtCode=GMP&arrivArprtCode=CJU&dpturCntryCode=KR&arrivCntryCode=KR&routeTypeCode=01&dpturCrncyCode=KRW&arrivCrncyCode=KRW&hidRouteCls=DO&dpturArprtCode=TAE&arrivArprtCode=CJU&dpturCntryCode=KR&arrivCntryCode=KR&routeTypeCode=01&dpturCrncyCode=KRW&arrivCrncyCode=KRW&hidRouteCls=DO&dpturArprtCode=KWJ&arrivArprtCode=CJU&dpturCntryCode=KR&arrivCntryCode=KR&routeTypeCode=01&dpturCrncyCode=KRW&arrivCrncyCode=KRW&hidRouteCls=DO&dpturArprtCode=MWX&arrivArprtCode=CJU&dpturCntryCode=KR&arrivCntryCode=KR&routeTypeCode=01&dpturCrncyCode=KRW&arrivCrncyCode=KRW&hidRouteCls=DO&dpturArprtCode=KMJ&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=NGO&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=NRT&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=HSG&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=CTS&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=KIX&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=OIT&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=OKA&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=FUK&arrivArprtCode=ICN&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=NRT&arrivArprtCode=TAE&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=KIX&arrivArprtCode=TAE&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=OKA&arrivArprtCode=TAE&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=FUK&arrivArprtCode=TAE&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=NRT&arrivArprtCode=CJU&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=KIX&arrivArprtCode=CJU&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=KIX&arrivArprtCode=PUS&dpturCntryCode=JP&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=JPY&arrivCrncyCode=KRW&hidRouteCls=AS&dpturArprtCode=TSA&arrivArprtCode=GMP&dpturCntryCode=TW&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=TWD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=KHH&arrivArprtCode=ICN&dpturCntryCode=TW&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=TWD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=MFM&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=MOP&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=WNZ&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=TNA&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=TAO&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=RMQ&arrivArprtCode=ICN&dpturCntryCode=TW&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=TWD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=TPE&arrivArprtCode=TAE&dpturCntryCode=TW&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=TWD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=HKG&arrivArprtCode=TAE&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=HKD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=NNG&arrivArprtCode=CJU&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=TPE&arrivArprtCode=PUS&dpturCntryCode=TW&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=TWD&arrivCrncyCode=KRW&hidRouteCls=AM&dpturArprtCode=DAD&arrivArprtCode=ICN&dpturCntryCode=VN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=BKK&arrivArprtCode=ICN&dpturCntryCode=TH&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=THB&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=VTE&arrivArprtCode=ICN&dpturCntryCode=LA&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=SYX&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=HAK&arrivArprtCode=ICN&dpturCntryCode=CN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=CNY&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=SGN&arrivArprtCode=ICN&dpturCntryCode=VN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=DAD&arrivArprtCode=TAE&dpturCntryCode=VN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=BKK&arrivArprtCode=TAE&dpturCntryCode=TH&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=THB&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=CEB&arrivArprtCode=TAE&dpturCntryCode=PH&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=DAD&arrivArprtCode=PUS&dpturCntryCode=VN&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=AL&dpturArprtCode=GUM&arrivArprtCode=ICN&dpturCntryCode=US&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=ET&dpturArprtCode=SPN&arrivArprtCode=ICN&dpturCntryCode=US&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=ET&dpturArprtCode=GUM&arrivArprtCode=TAE&dpturCntryCode=US&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=KRW&hidRouteCls=ET&dpturArprtCode=GUM&arrivArprtCode=KIX&dpturCntryCode=US&arrivCntryCode=JP&routeTypeCode=02&dpturCrncyCode=USD&arrivCrncyCode=JPY&hidRouteCls=ET&dpturArprtCode=VVO&arrivArprtCode=TAE&dpturCntryCode=RU&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=EUR&arrivCrncyCode=KRW&hidRouteCls=ET&dpturArprtCode=KHV&arrivArprtCode=TAE&dpturCntryCode=RU&arrivCntryCode=KR&routeTypeCode=02&dpturCrncyCode=EUR&arrivCrncyCode=KRW&hidRouteCls=ET&bType1=JP&paxTypeAdult=1&paxTypeChild=0&paxTypeInfant=0&promotionCode=";
            this._LoginServer.Method = "post";
            this._LoginServer.Origin = "https://www.twayair.com";
            this._LoginServer.Referer = "https://www.twayair.com/main.do?_langCode=ZH";
            this._LoginServer.ContentType = "application/x-www-form-urlencoded";
            this._Result = this._LoginServer.GetHttpResult();
            return _Result.Html;
        }
    }
}
