using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public abstract class IniConfig
    {

        private static int GetLastIndex(WebType webtype)
        {
            string lastindex = "";
            int value = 0;
            int r = IniFile._IniFile.ProfileIniRead(webtype.ToString(), "LastIndex", out lastindex);
            if (string.IsNullOrEmpty(lastindex.Trim()))
            { lastindex = "0"; }
            int.TryParse(lastindex, out value);
            return value;
        }

        public static int SetLastIndex(WebType webtype, int lastindex)
        {
            int r = IniFile._IniFile.ProfileIniWrite(webtype.ToString(), "LastIndex", lastindex.ToString());
            return r;
        }

        public static int GetModifyType(WebType webtype)
        {
            string lastindex = "";
            int value = 0;
            int r = IniFile._IniFile.ProfileIniRead(webtype.ToString(), "ModifyType", out lastindex);
            if (string.IsNullOrEmpty(lastindex.Trim()))
            { lastindex = "0"; }
            int.TryParse(lastindex, out value);
            return value;
        }

        public static int SetMotifyType(WebType webtype, int modifyTypeID)
        {
            int r = IniFile._IniFile.ProfileIniWrite(webtype.ToString(), "ModifyType", modifyTypeID.ToString());
            return r;
        }

        /// <summary>
        /// 获得或设置每次间隔时间 单位(毫秒)
        /// </summary>
        /// <returns></returns> 
        public static int TimeInterval
        {
            get
            {
                string value = "";
                int timeinterval = 0;
                int r = IniFile._IniFile.ProfileIniRead("TimeInterval", "value", out value);
                int.TryParse(value, out timeinterval);
                return timeinterval;
            }
            set
            {
                int r = IniFile._IniFile.ProfileIniWrite("TimeInterval", "value", value.ToString());
            }
        }

        public static int BookLastIndex
        {
            get { return GetLastIndex(WebType.Book); }
            set { SetLastIndex(WebType.Book, value); }
        }

        public static int JinRiLastIndex
        {
            get { return GetLastIndex(WebType.JinRi); }
            set { SetLastIndex(WebType.JinRi, value); }
        }

        public static int Na517LastIndex
        {
            get { return GetLastIndex(WebType.Na517); }
            set { SetLastIndex(WebType.Na517, value); }
        }

        public static int Yi8000LastIndex
        {
            get { return GetLastIndex(WebType.Yi8000); }
            set { SetLastIndex(WebType.Yi8000, value); }
        }

        //static DateTime d = new DateTime();
        public static DateTime LastDateTime
        {
            get
            {
                string outinfo = "";
                DateTime d = new DateTime();
                IniFile._IniFile.ProfileIniRead("LASTDATETIME", "LASTDATETIME", out outinfo);
                bool r = DateTime.TryParse(outinfo, out d);
                if (!r)
                    IniFile._IniFile.ProfileIniWrite("LASTDATETIME", "LASTDATETIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                return d;
            }
            set
            {
                string v = value.ToString("yyyy-MM-dd HH:mm:ss");
                IniFile._IniFile.ProfileIniWrite("LASTDATETIME", "LASTDATETIME", v);
            }
        }
    }
}
