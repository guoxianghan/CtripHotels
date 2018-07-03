using HttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommonHttpServer
{
    public abstract class IQueryTicket
    {
        protected HttpServer _LoginServer;
        protected HttpResult _Result;
        public IQueryTicket()
        {
            _LoginServer = new HttpServer();
        }
        public IQueryTicket(CookieContainer coo)
        {
            _LoginServer = new HttpServer() { Cookies = coo };
        }
        public virtual void Init()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go">出发</param>
        /// <param name="at">到达</param>
        /// <param name="isoneway">是否单程</param>
        /// <param name="date1">出发日期</param>
        /// <param name="date2">返程日期</param>
        /// <returns></returns>
        public abstract string QueryTicket(string go, string at, bool isoneway, DateTime date1, DateTime date2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="go">出发</param>
        /// <param name="at">到达</param>
        /// <param name="isoneway">是否单程</param>
        /// <param name="date1">出发日期</param>
        /// <param name="date2">返程日期</param>
        /// <returns></returns>
        public abstract string QueryTicket(string[] go, bool isoneway, DateTime date1, DateTime date2);
    }
}
