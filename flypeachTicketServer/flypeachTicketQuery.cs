using CommonHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace flypeachTicketServer
{
    public class flypeachTicketQuery : IQueryTicket
    {
        public flypeachTicketQuery(CookieContainer coo) : base(coo)
        {
            this._LoginServer.Cookies = coo;
            this._LoginServer.Host = "booking.flypeach.com";
        }
        public flypeachTicketQuery()
        {
            this._LoginServer.Host = "booking.flypeach.com";
        }
        public override void Init()
        {
            this._LoginServer.Url = "https://booking.flypeach.com/cn";
            this._LoginServer.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            this._LoginServer.AcceptEncoding = "gzip, deflate, br";
            this._LoginServer.AcceptLanguage = "zh-CN,zh;q=0.9";
            this._LoginServer.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.87 Safari/537.36";
            this._LoginServer.HeaderCollection.Add("Upgrade-Insecure-Requests", "1");
            base.Init();
            this._Result = this._LoginServer.GetHttpResult();
        }

        public override string QueryTicket(string[] go, bool isoneway, DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public override string QueryTicket(string go, string at, bool isoneway, DateTime date1, DateTime date2)
        {
            this._LoginServer.Cookies = this._Result.Cookies;
            this._LoginServer.Allowautoredirect = true;
            this._LoginServer.Url = "https://booking.flypeach.com/cn";
            this._LoginServer.PostData = "flight_search_parameter%5B0%5D%5Bdeparture_date%5D=2018%2F07%2F27&flight_search_parameter%5B0%5D%5Bdeparture_airport_code%5D=KIX&flight_search_parameter%5B0%5D%5Barrival_airport_code%5D=HKG&flight_search_parameter%5B0%5D%5Bis_return%5D=false&flight_search_parameter%5B0%5D%5Breturn_date%5D=&adult_count=1&child_count=0&infant_count=0";
            this._LoginServer.Method = "post";
            this._LoginServer.Origin = "https://booking.flypeach.com";
            this._LoginServer.Referer = "https://booking.flypeach.com/cn";
            this._Result = this._LoginServer.GetHttpResult();
            return _Result.Html;
        }
    }
}
