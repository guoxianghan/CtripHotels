using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtripHotelServer
{
    

    public class RoomListJSON
    {
        public int Rcode { get; set; }
        public string Msg { get; set; }
        public string Script { get; set; }
        public Datum_[] Data { get; set; }
        public int TotalPage { get; set; }
        public int TotalRecords { get; set; }
        public object SupplierContractNoList { get; set; }
        public bool SupplierAutomaticPriceStatus { get; set; }
    }

    public class Datum_
    {
        public int HotelId { get; set; }
        public int BasicRoomId { get; set; }
        public string BasicRoomName { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public Roomdynamiclist[] RoomDynamicList { get; set; }
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

    public class Roomdynamiclist
    {
        public string EffectDate { get; set; }
        public string RoomStatus { get; set; }
        public int IsOnline { get; set; }
        public float Price { get; set; }
        public int Breakfast { get; set; }
        public string BreakfastStr { get; set; }
        public int TotleQuantity { get; set; }
        public int BookQuantity { get; set; }
        public int QuotaQuantity { get; set; }
        public int RecycleAheadDays { get; set; }
        public int CanUseQuantity { get; set; }
        public int ContractRooms { get; set; }
        public string PrepayStr { get; set; }
        public int LowestRoomId { get; set; }
        public int LowestRoomPrice { get; set; }
        public object LowestRoomPriceCurrency { get; set; }
        public string GiftDesc { get; set; }
        public string GiftIds { get; set; }
        public int IsOrderClose { get; set; }
        public int LateReserveTime { get; set; }
        public int ReserveTime { get; set; }
        public object AutomaticModifyRoomPriceRecords { get; set; }
        public string AutomaticModifyRoomPriceRecordDes { get; set; }
    }

}
