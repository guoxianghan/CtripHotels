using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelHttpBase
{
    public enum Platform
    {
        None = 0,
        [Description("携程")]
        Ctrip = 2,
        [Description("去哪儿")]
        Qunar = 3,
        [Description("淘宝")]
        TaoBao = 4,
        [Description("美团")]
        MeiTuan = 5,
        [Description("艺龙")]
        YiLong = 6,
        [Description("房仓")]
        FangCang = 7,
        [Description("去哪儿移动端")]
        QunarTouch = 8,
        /// <summary>
        /// 代理通携程后台
        /// </summary>
        [Description("携程后台")]
        CtripConsole = 9,

        [Description("携程App")]
        CtripApp = 10,
        [Description("希尔顿")]
        Hilton = 11
    }
    public static class EnumDescription
    {
        /// <summary>
        /// 获取描述信息
        /// </summary>
        /// <param name="en">枚举</param>
        /// <returns></returns>
        public static string GetPlatName(this Platform en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }
    }
}
