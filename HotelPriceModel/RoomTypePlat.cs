
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
    public partial class RoomTypePlat : EntityBase
    {
        public RoomTypePlat()
        {
            TableName = "RoomTypePlat";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");
        }

        public RoomTypePlat(string tag) : this()
        {
            Guid = System.Guid.NewGuid();
            CreateTime = DateTime.Now;
            IsDelete = false;
        }
        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "CreateTime", "UpdateTime", "IsDelete", "PlatformsID", "PlatRoomType", "RoomTypeID", "LowPrice", "HotelID" };
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
        [AttrbuteColumn("CreateTime", false)]
        public System.DateTime CreateTime
        {
            get { return getProperty<System.DateTime>("CreateTime"); }
            set { setProperty("CreateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.DateTime UpdateTime
        {
            get { return getProperty<System.DateTime>("UpdateTime"); }
            set { setProperty("UpdateTime", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Boolean IsDelete
        {
            get { return getProperty<System.Boolean>("IsDelete"); }
            set { setProperty("IsDelete", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Int32 PlatformsID
        {
            get { return getProperty<System.Int32>("PlatformsID"); }
            set { setProperty("PlatformsID", value); }
        }
        [AttrbuteColumn("渠道", true)]
        public string PlatformName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("房型名称", true)]
        public System.String PlatRoomType
        {
            get { return getProperty<System.String>("PlatRoomType"); }
            set { setProperty("PlatRoomType", value, 40); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("房型ID", false)]
        public System.Guid RoomTypeID
        {
            get { return getProperty<System.Guid>("RoomTypeID"); }
            set { setProperty("RoomTypeID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("底价", true)]
        public System.Decimal LowPrice
        {
            get { return getProperty<System.Decimal>("LowPrice"); }
            set { setProperty("LowPrice", value); }
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


    }
}
