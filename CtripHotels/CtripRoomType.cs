using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpHotelServer
{
     
    public class CtripRoomList
    {
        public int Rcode { get; set; }
        public string Msg { get; set; }
        public string Script { get; set; }
        public CtripRoomType[] Data { get; set; }
        public int TotalPage { get; set; }
        public int TotalRecords { get; set; }
        public object SupplierContractNoList { get; set; }
        public bool SupplierAutomaticPriceStatus { get; set; }
    }
    public class CtripPricePolicy
    {
        public string hotelid { get; set; }
        public string roomid { get; set; }
        public string basicroomid { get; set; }
        public string checkin { get; set; }
        public string checkout { get; set; }
        public string roomsort { get; set; }
        public string roomsum { get; set; }
        public string roomctype { get; set; }
        public string lowerprice { get; set; }
        public string type { get; set; }
        public string agentname { get; set; }
        public string supplyid { get; set; }
        public string shadowid { get; set; }
        public string cityid { get; set; }
    }
    public class CtripRoomType
    {
        public int HotelId { get; set; }
        public int BasicRoomId { get; set; }
        public string BasicRoomName { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public _Roomdynamiclist[] RoomDynamicList { get; set; }
        public int IsOnline { get; set; }
        public int RateCodeId { get; set; }
        public string PropertyValue { get; set; }
        public int Person { get; set; }
        public int BasicPerson { get; set; }
        public int Breakfast { get; set; }
        public int RoomPriceType { get; set; }
        public int RoomClassID { get; set; }
        public int PriceRuleID { get; set; }
        public bool IsCanCopy { get; set; }
        public string Currency { get; set; }
        public int MasterRoomId { get; set; }
        public int IsVendor { get; set; }
        public string SendName { get; set; }
        public string QunarName { get; set; }
        public string ElongName { get; set; }
    }

    public class _Roomdynamiclist
    {
        public string EffectDate { get; set; }
        public string RoomStatus { get; set; }
        public int IsOnline { get; set; }
        public decimal Price { get; set; }
        public int Breakfast { get; set; }
        public string BreakfastStr { get; set; }
        public int TotleQuantity { get; set; }
        public int CanUseQuantity { get; set; }
        public int ContractRooms { get; set; }
        public string PrepayStr { get; set; }
        public int LowestRoomId { get; set; }
        public int LowestRoomPrice { get; set; }
        public string GiftDesc { get; set; }
    }

}
