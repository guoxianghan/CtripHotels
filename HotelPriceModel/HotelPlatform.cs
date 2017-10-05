
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
    public partial class HotelPlatform : EntityBase
    {
        public HotelPlatform()
        {
            TableName = "HotelPlatform";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");

        }
        public HotelPlatform(string tag) : this()
        {
            Guid = System.Guid.NewGuid();

            IsDelete = false;
            CreateTime = DateTime.Now;
        }

        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "CreateTime", "UpdateTime", "IsDelete", "PlatWebID", "HotelID", "PlatformsID" };
        }



        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("Guid", false)]
        public System.Guid Guid
        {
            get { return getProperty<System.Guid>("Guid"); }
            set { setProperty("Guid", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.DateTime CreateTime
        {
            get { return getProperty<System.DateTime>("CreateTime"); }
            set { setProperty("CreateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("UpdateTime", false)]
        public System.DateTime UpdateTime
        {
            get { return getProperty<System.DateTime>("UpdateTime"); }
            set { setProperty("UpdateTime", value); }
        }
        [AttrbuteColumn("渠道名称", true)]
        public string PlatName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("IsDelete", false)]
        public System.Boolean IsDelete
        {
            get { return getProperty<System.Boolean>("IsDelete"); }
            set { setProperty("IsDelete", value); }
        }

        /// <summary>
        /// 该网站对应的ID
        /// </summary>
        [AttrbuteColumn("网站ID", true)]
        public System.String PlatWebID
        {
            get { return getProperty<System.String>("PlatWebID"); }
            set { setProperty("PlatWebID", value, 40); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("酒店ID", true)]
        public System.Guid HotelID
        {
            get { return getProperty<System.Guid>("HotelID"); }
            set { setProperty("HotelID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("PlatformsID", false)]
        public System.Int32 PlatformsID
        {
            get { return getProperty<System.Int32>("PlatformsID"); }
            set { setProperty("PlatformsID", value); }
        }


    }
}
