
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
    public partial class HotelPricePolicy : EntityBase
    {
        public HotelPricePolicy()
        {
            TableName = "HotelPricePolicy";
            Schema = "dbo";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");


        }
        public HotelPricePolicy(string tag) : this()
        {
            Guid = System.Guid.NewGuid();

            IsDelete = false;
            CreateTime = DateTime.Now;
            CheckInDate = DateTime.Now.AddDays(2);
            CheckOutDate = DateTime.Now.AddDays(3);
        }

        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "FoodType", "BedType", "LowPrice", "UpdateTime", "CheckInDate", "CreateTime", "CheckOutDate", "IsDelete", "HotelID", "RoomTypeID" };
        }



        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Guid Guid
        {
            get { return getProperty<System.Guid>("Guid"); }
            set { setProperty("Guid", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("入住日期", true)]
        public System.DateTime CheckInDate
        {
            get { return getProperty<System.DateTime>("CheckInDate"); }
            set { setProperty("CheckInDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("离店日期", true)]
        public System.DateTime CheckOutDate
        {
            get { return getProperty<System.DateTime>("CheckOutDate"); }
            set { setProperty("CheckOutDate", value); }
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
        public System.Guid HotelID
        {
            get { return getProperty<System.Guid>("HotelID"); }
            set { setProperty("HotelID", value); }
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
        [AttrbuteColumn("", false)]
        public System.Guid RoomTypeID
        {
            get { return getProperty<System.Guid>("RoomTypeID"); }
            set { setProperty("RoomTypeID", value); }
        }

        [AttrbuteColumn("", false)]
        public DateTime CreateTime
        {
            get { return getProperty<System.DateTime>("CreateTime"); }
            set { setProperty("CreateTime", value); }
        }
        [AttrbuteColumn("", false)]
        public DateTime UpdateTime
        {
            get { return getProperty<System.DateTime>("UpdateTime"); }
            set { setProperty("UpdateTime", value); }
        }


        /// <summary>
        /// 床型
        /// </summary>
        [AttrbuteColumn("床型", true)]
        public System.String BedType
        {
            get { return getProperty<System.String>("BedType"); }
            set { setProperty("BedType", value, 20); }
        }

        /// <summary>
        /// 早饭类型
        /// </summary>
        [AttrbuteColumn("早餐类型", true)]
        public System.String FoodType
        {
            get { return getProperty<System.String>("FoodType"); }
            set { setProperty("FoodType", value, 20); }
        }
        [AttrbuteColumn("平台", false)]
        public List<HotelPlatPolicy> _HotelPlatPolicys { get; set; } = new List<HotelPlatPolicy>();
    }
}
