
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
using System.Collections.Generic;

namespace HotelPriceModel
{
    [Serializable()]
    public partial class Hotels : EntityBase
    {
        public Hotels()
        {
            TableName = "Hotels";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");

        }
        public Hotels(string tag) : this()
        {
            Guid = System.Guid.NewGuid();
            CreateTime = DateTime.Now;
            IsDelete = false;
        }

        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "Name", "City", "PolicyPic", "StreetName", "Branches", "CreateTime", "UpdateTime", "IsDelete" };
        }

        public List<RoomTypes> _RoomTypes { get; set; } = new List<RoomTypes>();
        public List<HotelPlatform> _HotelPlatform { get; set; } = new List<HotelPlatform>();
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
        [AttrbuteColumn("酒店名称", true)]
        public System.String Name
        {
            get { return getProperty<System.String>("Name"); }
            set { setProperty("Name", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("城市", true)]
        public System.String City
        {
            get { return getProperty<System.String>("City"); }
            set { setProperty("City", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("PolicyPic", false)]
        public System.String PolicyPic
        {
            get { return getProperty<System.String>("PolicyPic"); }
            set { setProperty("PolicyPic", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("地址", true)]
        public System.String StreetName
        {
            get { return getProperty<System.String>("StreetName"); }
            set { setProperty("StreetName", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("分店", true)]
        public System.String Branches
        {
            get { return getProperty<System.String>("Branches"); }
            set { setProperty("Branches", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("创建时间", false)]
        public System.DateTime CreateTime
        {
            get { return getProperty<System.DateTime>("CreateTime"); }
            set { setProperty("CreateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("更新时间", false)]
        public System.DateTime UpdateTime
        {
            get { return getProperty<System.DateTime>("UpdateTime"); }
            set { setProperty("UpdateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("是否已删除", false)]
        public System.Boolean IsDelete
        {
            get { return getProperty<System.Boolean>("IsDelete"); }
            set { setProperty("IsDelete", value); }
        }


    }
}
