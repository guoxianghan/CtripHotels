using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace CommonHelper
{
    /// <summary>
    /// 日志记录类
    /// </summary>
    public static class Logger
    {
        delegate void LogHandler(LogLevel level);
        public static readonly string AppPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        public static string GetClassName()
        {
            string className = MethodBase.GetCurrentMethod().ReflectedType.Name;
            StackTrace trace = new StackTrace();
            string conntent = className + " | " + (((trace.GetFrame(3).GetMethod())).ReflectedType).FullName + " | ";
            return conntent;
        }

        public static void Debug(WebType webType, string msg)
        {
            string className = MethodBase.GetCurrentMethod().ReflectedType.Name;
            LogTxt(webType, LogLevel.Debug, GetClassName() + msg);
        }
        public static void Info(WebType webType, string msg)
        {
            LogTxt(webType, LogLevel.Info, msg);
        }
        public static void Warn(WebType webType, string msg)
        {
            LogTxt(webType, LogLevel.Warn, msg);
        }
        public static void Error(WebType webType, string msg)
        {
            LogTxt(webType, LogLevel.Error, msg);
        }
        public static void Fatal(WebType webType, string msg)
        {
            LogTxt(webType, LogLevel.Fatal, msg);
        }


        public static void LogTxt(WebType webType, LogLevel level, string content)
        {
            string classname = GetClassName();
            switch (level)
            {
                case LogLevel.Debug:
                    WriteLog(webType, content);
                    break;//Debug
                case LogLevel.Error:
                    WriteLog(webType, content);
                    break;//Error
                case LogLevel.Fatal:
                    WriteLog(webType, content);
                    break;//Fatal
                case LogLevel.Info:
                    WriteLog(webType, content);
                    break;//Info
                case LogLevel.Warn:
                    WriteLog(webType, content);
                    break;//Warn
                default: break;
            }
        }

        public static void WriteLog(WebType webType, string content)
        {
            DateTime dt = DateTime.Now;
            string filename = dt.Year.ToString() + dt.Month.ToString().PadLeft(2, '0') + dt.Day.ToString().PadLeft(2, '0') + dt.Hour.ToString().PadLeft(2, '0') + ".txt";
            string path = AppPath;
            string fullpath = path + "log\\" + webType.ToString() + "\\" + filename;

            try
            {
                StreamWriter sw = new StreamWriter(fullpath, true, Encoding.Default);
                sw.Write(dt.ToString() + " | " + content + Environment.NewLine);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void WriteLog(string filesname, string content)
        {
            DateTime dt = DateTime.Now;
            string filename = dt.ToString("yyyy-MM-dd") + "\\" + dt.ToString("yyyyMMddHH") + ".txt";
            string path = AppPath;
            string fullpath = path + "log\\" + filesname.ToString() + "\\" + filename;
            DirectoryInfo dir = new DirectoryInfo(path + "log\\" + filesname.ToString());
            bool r = dir.Exists;
            if (!r)
                dir.Create();
            try
            {
                StreamWriter sw = new StreamWriter(fullpath, true, Encoding.Default);
                sw.Write(dt.ToString() + " | " + content + Environment.NewLine);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        public static void WriteException(string content)
        {
            WriteLog("Exception", content);
        }
        public static void WriteException(Exception ex)
        {
            WriteLog("Exception", "Message:" + ex.Message + Environment.NewLine + "Source:" + ex.Source + Environment.NewLine
                + "StackTrace:" + ex.StackTrace + Environment.NewLine + "TargetSite:" + ex.TargetSite.Name);
        }
        public static void WriteLog(Exception ex)
        {
            WriteLog("Message:" + ex.Message + Environment.NewLine + "Source:" + ex.Source + Environment.NewLine
                + "StackTrace:" + ex.StackTrace + Environment.NewLine + "TargetSite:" + ex.TargetSite.Name);
        }
        public static void WriteLog(string path, string filesname, string content)
        {
            DateTime dt = DateTime.Now;
            string filename = filesname + ".txt";
            string fullpath = path + "\\" + filename.ToString();
            DirectoryInfo dir = new DirectoryInfo(path);
            bool r = dir.Exists;
            if (!r)
                dir.Create();
            try
            {
                StreamWriter sw = new StreamWriter(fullpath, true, Encoding.Default);
                sw.Write(dt.ToString() + " | " + content + Environment.NewLine);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        public static void WriteLog(string content, bool isconsolewrite = true)
        {
            DateTime dt = DateTime.Now;
            string filename = dt.ToString("yyyy-MM-dd") + "\\" + dt.ToString("yyyyMMddHH") + ".txt";
            string path = AppPath;
            string fullpath = path + "log\\" + filename;
            string info = dt.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + content + Environment.NewLine;
            if (isconsolewrite)
                Console.Write(info);
            try
            {
                if (!Directory.Exists(fullpath.Replace("\\" + dt.ToString("yyyyMMddHH") + ".txt", "")))
                    Directory.CreateDirectory(fullpath.Replace("\\" + dt.ToString("yyyyMMddHH") + ".txt", ""));
                //if (!File.Exists(fullpath))
                //    File.Create(fullpath);
                StreamWriter sw = new StreamWriter(fullpath, true, Encoding.Default);
                sw.Write(info);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }

    /// <summary>
    /// 日志记录级别
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
    }

}