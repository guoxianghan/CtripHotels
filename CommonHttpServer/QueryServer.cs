using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpHelper;
using System.Net;
using CommonHelper;

namespace CommonHttpServer
{
    /// <summary>
    /// 
    /// </summary> 
    /// <summary>
    /// 
    /// </summary> 
    public abstract class QueryServer //: IQueryServer 
    {
        public QueryServer(CookieContainer cookie)
        {
            _QueryServer = new HttpServer();
            _QueryServer.Cookies = cookie;
        }
        public QueryServer()
        {
            _QueryServer = new HttpServer();
        }
        public AirCompanyModel _AirCompany { get; set; }
        public QueryServer(CookieContainer cookie, AirCompanyModel aircompany)
        {
            _QueryServer = new HttpServer();
            _QueryServer.Cookies = cookie;
            _AirCompany = aircompany;
            switch (aircompany.DateType)
            {
                case "0":
                    this.SDate = aircompany.QueryBeginDate;
                    this.EDate = aircompany.QueryEndDate;
                    break;
                case "1":
                    this.SDate = DateTime.Now.AddDays(-1);
                    this.EDate = DateTime.Now.AddDays(-1);
                    break;
                case "2":
                    this.SDate = DateTime.Now.AddDays(-2);
                    this.EDate = DateTime.Now.AddDays(-2);
                    break;
                case "3":
                    this.SDate = DateTime.Now.AddDays(-7);
                    this.EDate = DateTime.Now.AddDays(-7);
                    break;
                default:
                    try
                    {
                        string[] ss = aircompany.DateType.Split('|');
                        this.SDate = DateTime.Parse(ss[0]);
                        this.EDate = DateTime.Parse(ss[1]);
                    }
                    catch (Exception)
                    {
                        Logger.WriteLog("错误的日期:" + aircompany.DateType);
                    }
                    break;
            }
        }

        public DateTime? SDate = DateTime.Now;
        public DateTime? EDate = DateTime.Now;
        #region 公共属性

        public HttpServer _QueryServer;
        public HttpResult _Result;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
        CookieContainer Cookies { get { return this._QueryServer.Cookies; } }
        public string Post { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int AllCount { get; set; }
        public string ViewState { get; set; }


        //D policyData;

        #endregion

        public abstract System.IO.MemoryStream DownloadExcel(string excelname, out string info);
        public abstract string CreateExcel(string parent, string sonagent, out string info);
        /// <summary>
        /// 下载退审报表的方法,该方法需重写实现
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="sonagent"></param>
        /// <param name="datetype">0申请日期,2退款日期</param>
        /// <param name="info"></param>
        /// <returns></returns>
        public virtual string CreateRetTicExcel(string parent, string sonagent, DateTime d1, DateTime d2,string datetype, out string info)
        {
            throw new NotImplementedException("创建退审报表的方法,该方法需重写实现");
        }
        /// <summary>
        /// 下载退审报表的方法,该方法需重写实现
        /// </summary>
        /// <param name="excelname"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public virtual System.IO.MemoryStream DownloadRetTicExcel(string excelname, out string info)
        {
            return DownloadExcel(excelname, out info);
        }

        public virtual string CreatePost(int pageno)
        {
            throw new NotImplementedException("该方法需重写实现");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class QueryServer<T> //: IQueryServer 
    where T : class
    {
        public T _Target = null;
        public QueryServer(T target)
        {
            _Target = target;
            _QueryServer = new HttpServer();
            //_QueryServer.Content_Length = 1L;
        }
        public QueryServer(CookieContainer cookie, T target, int datetype)
        {
            _QueryServer = new HttpServer();
            _QueryServer.Cookies = cookie;
            //_QueryServer.Content_Length = 1L;
            _Target = target;

            switch (datetype)
            {
                case 0:

                    break;
                case 1:
                    SDate = DateTime.Now.AddDays(-1);
                    EDate = DateTime.Now.AddDays(-1);
                    break;
                case 2:
                    SDate = DateTime.Now.AddDays(-2);
                    EDate = DateTime.Now.AddDays(-2);
                    break;
            }
        }

        public DateTime? SDate = DateTime.Now;
        public DateTime? EDate = DateTime.Now;
        #region 公共属性

        public HttpServer _QueryServer;
        public HttpResult _Result;

        public abstract System.IO.MemoryStream DownloadExcel(string excelname, out string info);
        public abstract string CreateExcel(string parent, string sonagent, out string info);
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
        CookieContainer Cookies { get; set; }
        public string Post { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int AllCount { get; set; }
        public string ViewState { get; set; }


        //D policyData;

        #endregion
        public virtual string CreatePost(int pageno)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="W">W,和网站对应的数据对象</typeparam>
    /// <typeparam name="D">D,数据库里的数据对象</typeparam>
    public abstract class QueryServer<W, D> : IQueryServer<W, D>
        where W : class, new()
        where D : class, new()
    {
        #region 公共属性

        public HttpServer _QueryServer;
        public HttpResult _QueryResult;
        /// <summary>
        /// 可比较的政策值
        /// </summary>
        public decimal ComValue { get; set; }
        /// <summary>
        /// 当前最大值
        /// </summary>
        public decimal MaxValue { get; set; }
        /// <summary>
        /// 自家限制值
        /// </summary>
        public decimal LimitValue { get; set; }
        /// <summary>
        /// 当前值
        /// </summary>
        public decimal CurrentValue { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
        public CookieContainer Cookies { get; set; }
        public string FirstPost { get; set; }
        public string Post { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int AllCount { get; set; }
        public string ViewState { get; set; }

        public string __EVENTVALIDATION { get; set; }

        //D policyData;

        /// <summary>
        ///数据库里的数据对象, 用于接着查询条件的post
        /// </summary>
        public D Policy
        {
            get;
            set;
        }
        #endregion

        public QueryServer(D policy)
        {
            this.Policy = policy;
            _QueryServer = new HttpServer();
        }

        public QueryServer(D policy, CookieContainer cookies)
        {
            this.Policy = policy;
            _QueryServer = new HttpServer();
            _QueryServer.Cookies = cookies;
            this.Cookies = cookies;
        }
        /// <summary>
        /// 整体查询结果,从第二页开始
        /// </summary>
        /// <returns></returns>
        public W MainQuery(out string err, out bool isgoing)
        {
            err = "";
            W webpolicy = null;
            isgoing = true;
            int pageno = 2;
            while (pageno <= PageCount)
            {
                webpolicy = this.QueryResult(pageno, out err, out isgoing);
                if (webpolicy != null || !string.IsNullOrEmpty(err))
                    break;
                pageno++;
            }
            return webpolicy;
        }



        public virtual string CreatePost(int pageno)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        public abstract W FirstPage(out string err, out bool isgoing);

        public virtual W QueryResult(int pageno, out string err, out bool isgoing)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        public virtual string CreatePostString(int pageno)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        public virtual List<W> TrimHtml(string html, out string err)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        public virtual void ShowDetail(W webpolicy, out string err)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        public abstract W FindPolicy(IList<W> listW);

        /// <summary>
        /// 没有显式返回修改结果时,用此方法再查一次
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public virtual W ModifyResult(W policy, out string err)
        {
            throw new NotImplementedException("该方法需重写实现");
        }

        //public virtual W FirstPage(D policy, out string err, out bool isgoing)
        //{
        //    throw new NotImplementedException("该方法需重写实现");
        //}

        //public virtual W QueryResult(int pageno, D policy, out string err, out bool isgoing)
        //{
        //    throw new NotImplementedException("该方法需重写实现");
        //}
    }
}
