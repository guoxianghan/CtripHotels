using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public static class ObjectUti 
    {
        /// <summary>
        /// 获取公有属性的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetProperty(this object obj, string property)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(property).GetValue(obj, null);
                string Value = Convert.ToString(o);
                if (string.IsNullOrEmpty(Value)) return null;
                return Value;
            }
            catch
            {
                return null;
            }
        }
    }
}
