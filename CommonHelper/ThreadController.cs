using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonHelper;
using System.Data;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Configuration;
using System.Diagnostics;

namespace CommonHelper
{

    /// <summary>
    /// 
    /// </summary> 
    public class ThreadController
    {
        public ThreadController()
        {
        }

        #region 定义事件
        /// <summary>
        /// 回调通知进度
        /// </summary>
        public event ShowProgressCallBack OnShowProgress;
        /// <summary>
        /// 回调显示文本
        /// </summary>
        public event ShowTextCallback OnShowText;
        /// <summary>
        /// 开始运行时的通知
        /// </summary>
        public event StartWorkerNotifyCallback OnStartWorkerNotify;
        /// <summary>
        /// 结束运行时的通知
        /// </summary>
        public event StopWorkerNotifyCallback OnStopWorkerNotify;
        /// <summary>
        /// 回调显示验证码
        /// </summary>
        public event VerifyCodeCallBack OnVerifyCode;
        //public event CookieCallBack OnCookie;
        public event ShowWebPageCallBack OnShowWebPage;
        #endregion

        /// <summary>
        /// 公共Cookie
        /// </summary>
        public CookieContainer Cookies { get; set; }

        #region 事件包装器. 检测事件是否已订阅.
        public void ShowText(string Msg)
        { if (OnShowText != null) OnShowText(Msg); }

        private void ShowProgress(int ProgressValue, string msg)
        { if (OnShowProgress != null) OnShowProgress(ProgressValue, msg); }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="memoryStream"></param>
        /// <returns></returns>
        public string VerifyCode(MemoryStream memoryStream, string webName)
        {
            string verycode = "";
            if (OnVerifyCode != null)
                verycode = OnVerifyCode(memoryStream, webName);
            return verycode;
        }
        /// <summary>
        ///工作开始. 先通知主线程任务已经开始.
        /// </summary>
        private void StartWorkerNotify()
        { if (OnStartWorkerNotify != null) OnStartWorkerNotify(); }

        /// <summary>
        /// 通知主线程.工作任务已经停止.
        /// </summary>
        private void StopWorkerNotify()
        { if (OnStopWorkerNotify != null) OnStopWorkerNotify(); }

        #endregion


        #region  公共属性

        public string UserName { get; set; }
        public string Pwd { get; set; }


        /// <summary>
        /// 主控标志
        /// </summary>
        private bool ctsFlag = false;

        /// <summary>
        /// 主控标志
        /// </summary>
        public bool CtsFlag
        {
            get { return ctsFlag; }
            set { ctsFlag = value; }
        }





        #endregion

        #region 控制线程的方法
        //定义工作线程.
        Thread m_Worker = null;
        /// <summary>
        /// 开始工作线程
        /// </summary>
        public void StartWork()
        {
            //置取消标识. 设置线程启动.
            ctsFlag = true;
            m_Worker = new Thread(WrokerThread);
            m_Worker.IsBackground = true;
            m_Worker.Start();
        }
        /// <summary>
        /// 停止线程
        /// </summary>
        public void StopWork()
        {
            ctsFlag = false;
        }
        #endregion
        bool isRunning = false;
        public bool IsRunning { get { return isRunning; } }


        public int UserID { get; set; }

        /// <summary> 
        /// 保证所有的工作线程的执行.都来自于类内部.
        /// </summary>
        private void WrokerThread()
        {
            StartWorkerNotify();
            isRunning = true;

            ShowText("当前状态->运行中...");

            try
            {
                if (_RunAction != null)
                {
                    try
                    {
                        //_RunAction.Invoke();
                        _RunAction();
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(ex);
                        throw;
                    }
                }
                else
                {
                    throw new NotImplementedException("尚未实现_RunAction方法");
                }
            }
            catch (Exception ex)
            {
                var c = new EventInstance(0, 0);
                c.EntryType = EventLogEntryType.Error;
                EventLog.WriteEvent("携程代驾", c, ex);
                ShowText(ex.Message);
            }

            ctsFlag = false;
            isRunning = false;
            ShowText("任务停止");
            StopWorkerNotify();
        }

        public Action _RunAction = null;
    }
}
