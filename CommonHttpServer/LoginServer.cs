using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpHelper;
using CommonHelper;
using System.IO;
using System.Net;

namespace CommonHttpServer
{
    //public delegate void ShowNotifyCallBack(string msg);
    public abstract class LoginServer //: 
    {
        //public event ShowNotifyCallBack OnShowNotify;
        protected HttpServer _LoginServer;
        protected HttpResult _Result;
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public CookieContainer Cookies { get; set; }
        public LoginServer() { }
        public LoginServer(string _webtype)
        {
            this.Webtype = _webtype;
            _LoginServer = new HttpServer();
        }
        public LoginServer(string username, string pwd)
        {
            this.UserName = username;
            this.Pwd = pwd;
            _LoginServer = new HttpServer();
        }
        public LoginServer(string username, string pwd, string _webtype)
        {
            this.UserName = username;
            this.Pwd = pwd;
            this.Webtype = _webtype;
            _LoginServer = new HttpServer();
        }
        #region 公共属性

        //string webtype;
        /// <summary>
        /// 网站类型
        /// </summary>
        public string Webtype
        {
            get;
            set;
        }
        #endregion

        /// <summary>
        /// 登陆的方法,登陆成功后要写Cookie
        /// </summary>
        /// <param name="err"></param>
        /// <returns></returns>
        public virtual bool Login(out string err)
        {
            throw new NotImplementedException("没有重写该方法");
        }
        public virtual void InitLogin()
        { 
        }

        /// <summary>
        ///验证是否跳过或登陆 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public virtual bool Login(string code, out string err)
        {
            err = "";
            if (code == "跳过" || code == "TIMEOUT")
            { 
                err = code; 
                return false; }
            else { return true; }
        }

        public virtual bool Login(string username, string pwd, string code, out string err)
        {
            this.Cookies = this._LoginServer.Cookies;
            throw new NotImplementedException("没有重写该方法");
        }

        public virtual bool Login(string username, string pwd, out string err)
        {
            this.Cookies = this._LoginServer.Cookies;
            throw new NotImplementedException("没有重写该方法");
        }
        public virtual MemoryStream CheckCode(CookieContainer cookies, out string err)
        {
            throw new NotImplementedException("没有重写该方法");
        }

        public abstract MemoryStream CheckCode();
    }
}
