using CommonHelper;
using PWMIS.Common;
using PWMIS.DataMap.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelPriceModel
{
    public class HotelPlatPolicy : EntityBase
    {
        public HotelPlatPolicy()
        {
            TableName = "HotelPlatPolicy";
            Schema = "";
            EntityMap = EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
            PrimaryKeys.Add("Guid");

        }

        public HotelPlatPolicy(string tag) : this()
        {
            CreateTime = DateTime.Now;
            Guid = System.Guid.NewGuid();
            IsRun = true;
            IsDelete = false;

        }
        protected override void SetFieldNames()
        {
            PropertyNames = new string[] { "Guid", "CreateTime", "IsDelete", "PlatformID", "HotelPricePolicyID", "HotelID", "RoomTypeID", "IsRun" };
        }

        protected override string[] SetFieldDescriptions()
        {
            //字段对应的描述
            return new string[] { "", "", "", "", "", "", "", "" };
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
        public System.Boolean IsDelete
        {
            get { return getProperty<System.Boolean>("IsDelete"); }
            set { setProperty("IsDelete", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Int32 PlatformID
        {
            get { return getProperty<System.Int32>("PlatformID"); }
            set { setProperty("PlatformID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("", false)]
        public System.Guid HotelPricePolicyID
        {
            get { return getProperty<System.Guid>("HotelPricePolicyID"); }
            set { setProperty("HotelPricePolicyID", value); }
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
        /// 
        [AttrbuteColumn("", false)]
        public System.Guid RoomTypeID
        {
            get { return getProperty<System.Guid>("RoomTypeID"); }
            set { setProperty("RoomTypeID", value); }
        }

        [AttrbuteColumn("平台名称", true)]
        public System.String _PlatName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AttrbuteColumn("是否有效", true)]
        public System.Boolean IsRun
        {
            get { return getProperty<System.Boolean>("IsRun"); }
            set { setProperty("IsRun", value); }
        }



    }
}
