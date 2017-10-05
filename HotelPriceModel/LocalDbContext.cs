using CommonHelper;
using PWMIS.Core.Extensions;
using PWMIS.DataMap.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelPriceModel
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext()
           : base("local")
        {
            //local 是连接字符串名字 
        }

        static LocalDbContext _LocalDbContext = new LocalDbContext();
        public static LocalDbContext DbContext
        {
            get
            {
                if (_LocalDbContext == null)
                    _LocalDbContext = new LocalDbContext();
                return _LocalDbContext;
            }
        }
        protected override bool CheckAllTableExists()
        {
            return true;
        }
        public EntityQuery<HotelPlatform> HotelPlatform
        {
            get
            {
                return base.NewQuery<HotelPlatform>();
            }
        }
        public List<Hotels> GetHotels(string sqlwhere)
        {
            List<Hotels> list = EntityQuery<Hotels>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM Hotels WHERE " + sqlwhere));
            foreach (var item in list)
            {
                item._HotelPlatform = this.HotelPlatform.GetList(new OQL(new HotelPlatform() { HotelID = item.Guid }));

                var lf = EntityQuery<RoomTypes>.QueryList(DbHelperSQL.ExecuteReader("SELECT * FROM RoomTypes WHERE Hotel_ID='" + item.Guid + "'"));
                item._RoomTypes = lf;
            }

            return list;
        }
        public List<HotelPricePolicyView> GetHotelPricePolicyView(string sqlwhere)
        {
            StringBuilder sb = new StringBuilder(" (");
            StringBuilder sbhotelid = new StringBuilder(" (");
            StringBuilder sbroomid = new StringBuilder(" (");

            List<HotelPricePolicyView> list = EntityQuery<HotelPricePolicyView>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM HotelPricePolicyView WHERE " + sqlwhere));
            if (list.Count == 0)
                return list;
            List<HotelPriceModel.Platforms> plats = Platforms.GetList(new OQL(new HotelPriceModel.Platforms()));
            foreach (var item in list)
            {
                sb.Append("'" + item.Guid.ToString() + "',");
                sbhotelid.Append("'" + item.HotelID.ToString() + "',");
                sbroomid.Append("'" + item.RoomTypeID.ToString() + "',");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(")");
            sbhotelid.Remove(sbhotelid.Length - 1, 1);
            sbhotelid.Append(")");
            sbroomid.Remove(sbhotelid.Length - 1, 1);
            sbroomid.Append(")");
            List<HotelPlatPolicy> policyplat = new List<HotelPriceModel.HotelPlatPolicy>();
            List<HotelPlatform> hotelplatform = new List<HotelPriceModel.HotelPlatform>();
            List<RoomTypes> rooms = new List<HotelPriceModel.RoomTypes>();
            List<RoomTypePlat> roomplat = new List<HotelPriceModel.RoomTypePlat>();
            if (sb.Length == 2)
                sb.Clear();
            policyplat = EntityQuery<HotelPlatPolicy>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM HotelPlatPolicy WHERE IsDelete=0 AND HotelPricePolicyID IN" + sb.ToString()));
            hotelplatform = EntityQuery<HotelPlatform>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM HotelPlatform WHERE IsDelete=0 AND HotelID IN" + sbhotelid.ToString()));
            rooms = EntityQuery<RoomTypes>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM RoomTypes WHERE IsDelete=0 AND Guid IN" + sbroomid.ToString()));
            roomplat = EntityQuery<RoomTypePlat>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM RoomTypePlat WHERE IsDelete=0 AND RoomTypeID IN" + sbroomid.ToString()));
            foreach (var item in list)
            {
                item._PlatPolicy = policyplat.FindAll(x => x.HotelPricePolicyID == item.Guid);
                item._PlatPolicy.ForEach(x =>
                {
                    x._PlatName = plats.FirstOrDefault(c => c.ID == x.PlatformID)?.PlatformName;
                });

                item._HotelPlatform = hotelplatform.FindAll(x => x.HotelID == item.HotelID);
                item._Room = rooms.FirstOrDefault(x => x.Guid == item.RoomTypeID);
                if (item._Room != null)
                    item._Room._RoomTypePlat = roomplat.FindAll(x => x.RoomTypeID == item._Room.Guid);
            }

            return list;
        }
        public Hotels GetHotels(Guid guid)
        {
            var hotels = LocalDbContext.DbContext.GetHotels("Guid='" + guid + "'");
            if (hotels.Count == 0)
                return null;
            var h = hotels[0];
            h._HotelPlatform = EntityQuery<HotelPlatform>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM HotelPlatform WHERE IsDELETE=0 AND HotelID='" + guid + "'")); ;//HotelPlatform.GetList(new OQL(new HotelPricePolicy() { HotelID = guid }));
            h._RoomTypes = EntityQuery<RoomTypes>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM RoomTypes WHERE IsDELETE=0 AND Hotel_ID='" + guid + "'"));
            //RoomTypes.GetList(new OQL(new RoomTypes() { Hotel_ID = guid }));
            var roomtypeplat = RoomTypePlat.GetList(new OQL(new RoomTypePlat() { HotelID = guid }));
            foreach (var item in h._RoomTypes)
            {
                item._RoomTypePlat = roomtypeplat.FindAll(x => x.RoomTypeID == item.Guid);
            }
            return h;
        }
        public EntityQuery<HotelPricePolicy> HotelPricePolicy
        {
            get
            {
                return base.NewQuery<HotelPricePolicy>();
            }
        }
        public EntityQuery<Hotels> Hotels
        {
            get
            {
                return base.NewQuery<Hotels>();
            }
        }
        public EntityQuery<Platforms> Platforms
        {
            get
            {
                return base.NewQuery<Platforms>();
            }
        }
        public EntityQuery<RoomTypePlat> RoomTypePlat
        {
            get
            {
                return base.NewQuery<RoomTypePlat>();
            }
        }
        public EntityQuery<RoomTypes> RoomTypes
        {
            get
            {
                return base.NewQuery<RoomTypes>();
            }
        }

        public List<RoomTypes> GetRoomTypes(string sqlwhere)
        {
            var rooms = EntityQuery<RoomTypes>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM RoomTypes WHERE " + sqlwhere.ToString()));
            return rooms;
        }
        public List<RoomTypePlat> GetRoomTypePlat(string sqlwhere)
        {
            var rooms = EntityQuery<RoomTypePlat>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM RoomTypePlat WHERE " + sqlwhere.ToString()));
            return rooms;
        }
        public List<HotelPlatform> GetHotelPlatform(string sqlwhere)
        {
            var rooms = EntityQuery<HotelPlatform>.QueryList(DbHelperSQL.ExecuteReader("SELECT *  FROM HotelPlatform WHERE " + sqlwhere.ToString()));
            return rooms;
        }
        public EntityQuery<HotelPricePolicyView> HotelPricePolicyView
        {
            get
            {
                return base.NewQuery<HotelPricePolicyView>();
            }
        }
        public EntityQuery<HotelPlatPolicy> HotelPlatPolicy
        {
            get
            {
                return base.NewQuery<HotelPlatPolicy>();
            }
        }
    }
}
