/**  版本信息模板在安装目录下，可自行修改。
* Rooms.cs
*
* 功 能： N/A
* 类 名： Rooms
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/9/29 21:23:23   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Rooms:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RoomsModel
	{
		public RoomsModel()
		{}
        #region Model
        private int _id;
        private string _baseroomid;
        private int? _platid;
        private int? _hotelid;
        private string _roomname;
        private DateTime _createdate;
        private string _hotelplatid;
        private string _roomid;
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
        #endregion Model

    }
}

