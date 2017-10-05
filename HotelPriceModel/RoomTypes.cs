
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
    public partial class RoomTypes : EntityBase
    {
        public RoomTypes()
        {
            TableName = "RoomTypes";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");

        }
        public RoomTypes(string tag) : this()
        {
            Guid = System.Guid.NewGuid();
            CreateTime = DateTime.Now;
            IsDelete = false;
        }

        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "Name", "Hotel_ID", "CreateTime", "UpdateTime", "IsDelete" };
        }



        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.Guid Guid
        {
            get { return getProperty<System.Guid>("Guid"); }
            set { setProperty("Guid", value); }
        }

        public List<RoomTypePlat> _RoomTypePlat { get; set; } = new List<RoomTypePlat>();
        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.String Name
        {
            get { return getProperty<System.String>("Name"); }
            set { setProperty("Name", value, 2147483647); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.Guid Hotel_ID
        {
            get { return getProperty<System.Guid>("Hotel_ID"); }
            set { setProperty("Hotel_ID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.DateTime CreateTime
        {
            get { return getProperty<System.DateTime>("CreateTime"); }
            set { setProperty("CreateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.DateTime UpdateTime
        {
            get { return getProperty<System.DateTime>("UpdateTime"); }
            set { setProperty("UpdateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", true)]
        public System.Boolean IsDelete
        {
            get { return getProperty<System.Boolean>("IsDelete"); }
            set { setProperty("IsDelete", value); }
        }

        public string BedType { get; set; }
        public string Breadfast { get; set; }
        public int Price { get; set; }
    }
}
