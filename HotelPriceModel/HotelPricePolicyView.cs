using CommonHelper;
using PWMIS.Common;
using PWMIS.DataMap.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelPriceModel
{
    public class HotelPricePolicyView : EntityBase
    {

        public HotelPricePolicyView()
        {
            TableName = "HotelPricePolicyView";
            Schema = "";
            EntityMap = EntityMapType.View;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");

        }


        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "FoodType", "BedType", "CheckInDate", "CheckOutDate", "LowPrice", "IsDelete", "HotelID", "RoomTypeID", "CreateTime", "UpdateTime", "HOTELNAME", "ROOMNAME" };
        }

        protected override string[] SetFieldDescriptions()
        {
            //字段对应的描述
            return new string[] { "", "", "", "", "", "", "", "", "", "" };
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
        [AttrbuteColumn("酒店", true)]
        public System.String HOTELNAME
        {
            get { return getProperty<System.String>("HOTELNAME"); }
            set { setProperty("HOTELNAME", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("房型", true)]
        public System.String ROOMNAME
        {
            get { return getProperty<System.String>("ROOMNAME"); }
            set { setProperty("ROOMNAME", value, 2147483647); }
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
        [AttrbuteColumn("", false)]
        public System.Guid RoomTypeID
        {
            get { return getProperty<System.Guid>("RoomTypeID"); }
            set { setProperty("RoomTypeID", value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("底价", true)]
        public System.Double LowPrice
        {
            get { return getProperty<System.Double> ("LowPrice"); }
            set { setProperty("LowPrice", value); }
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
        [AttrbuteColumn("", false)]
        public System.DateTime UpdateTime
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
        /// <summary>
        /// 所有平台政策
        /// </summary>
        [AttrbuteColumn("", false)]
        public List<HotelPlatPolicy> _PlatPolicy { get; set; } = new List<HotelPlatPolicy>();
        /// <summary>
        /// 各个平台对应的ID
        /// </summary>
        [AttrbuteColumn("", false)]
        public List<HotelPlatform> _HotelPlatform { get; set; } = new List<HotelPlatform>();
        /// <summary>
        /// 该政策房型
        /// </summary>
        [AttrbuteColumn("", false)]
        public RoomTypes _Room { get; set; } = new RoomTypes();
    }
}
