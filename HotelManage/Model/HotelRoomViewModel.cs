using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Model
{
  public  class HotelRoomViewModel
    {
        public HotelRoomViewModel()
        { }
        #region Model
        private int _id;
        private string _baseroomid;
        private int? _platid;
        private int? _hotelid;
        private string _roomname;
        private DateTime _createdate;
        private string _hotelplatid;
        private string _roomid;
        private string _platname;
        private string _hotelname;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BaseRoomID
        {
            set { _baseroomid = value; }
            get { return _baseroomid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PlatID
        {
            set { _platid = value; }
            get { return _platid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? HotelID
        {
            set { _hotelid = value; }
            get { return _hotelid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoomName
        {
            set { _roomname = value; }
            get { return _roomname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HotelPlatID
        {
            set { _hotelplatid = value; }
            get { return _hotelplatid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoomID
        {
            set { _roomid = value; }
            get { return _roomid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PlatName
        {
            set { _platname = value; }
            get { return _platname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HotelName
        {
            set { _hotelname = value; }
            get { return _hotelname; }
        }
        #endregion Model
    }
}
