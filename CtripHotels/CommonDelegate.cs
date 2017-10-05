using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HttpHotelServer
{
    #region 定义委托原型

    /// <summary>
    /// 下载完成时回调
    /// </summary>
    /// <param name="downloadstream">下载完成时返回的流文件</param>
    /// <param name="airname">航司名称</param>
    /// <param name="accountname">账户</param>
    /// <param name="filetype">要下载的文件类型</param>
    /// <param name="message">消息</param>
    /// <param name="step">第几步</param>
    public delegate void DownloadCompletedCallBack(MemoryStream downloadstream, string airname, string accountname,string filetype, string message, int step);
    //更新进度时回调
    public delegate void ShowProgressCallBack(int ProgressValue,string message);
    //public delegate void ShowProgressCallBack(int ProgressValue);
    //更新文本时回调
    public delegate void ShowTextCallback(string Msg);
    //开始工作时的回调通知. 从这个可以知道线程已经开始运行.
    public delegate void StartWorkerNotifyCallback();
    //停止时回调.作用同上.
    public delegate void StopWorkerNotifyCallback();
    /// <summary>
    /// 回调显示验证码
    /// </summary>
    /// <param name="memoryStream">验证码</param>
    /// <param name="webName"></param>
    /// <returns></returns>
    public delegate string VerifyCodeCallBack(MemoryStream memoryStream, string webName);
    //public delegate string VerifyCodeCallBack(MemoryStream memoryStream, string webName,out int codeid);
    public delegate string ShowWebPageCallBack(string webname, string loginurl, string resulturl, out string err);
    #endregion
}
