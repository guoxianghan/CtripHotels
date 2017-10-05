
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/12/15 10:40:27
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;
using CommonHelper;

namespace HotelPriceModel
{
    [Serializable()]
    public partial class Platforms : EntityBase
    {
        public Platforms()
        {
            TableName = "Platforms";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";
            IdentityName = "ID";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("ID");

        }


        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "ID", "Code", "PlatformName", "Commission" };
        }



        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Int32 ID
        {
            get { return getProperty<System.Int32>("ID"); }
            set { setProperty("ID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("渠道", true)]
        public System.String PlatformName
        {
            get { return getProperty<System.String>("PlatformName"); }
            set { setProperty("PlatformName", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("渠道代码", true)]
        public System.String Code
        {
            get { return getProperty<System.String>("Code"); }
            set { setProperty("Code", value, 2147483647); }
        }
        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("佣金", false)]
        public System.Double Commission
        {
            get { return getProperty<System.Double>("Commission"); }
            set { setProperty("Commission", value); }
        }

        [AttrbuteColumn("网站ID", true)]
        public string WebID { get; set; }

        [AttrbuteColumn("酒店房型名称", true)]
        public string RoomTypeName { get; set; }
    }
}
