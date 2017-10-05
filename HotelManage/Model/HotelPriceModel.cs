/**  版本信息模板在安装目录下，可自行修改。
* HotelPrice.cs
*
* 功 能： N/A
* 类 名： HotelPrice
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/9/29 21:23:22   N/A    初版
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
	/// HotelPrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HotelPriceModel
	{
        public HotelPriceModel()
        { }
        #region Model
        private int _id;
        private int? _platid;
        private int? _hotelid;
        private string _roomid;
        private string _baseroomid;
        private DateTime _indate;
        private DateTime _outdate;
        private int? _breakfirsttype = 0;
        private string _bedtype;
        private decimal _price;
        private DateTime? _createdate;
        private DateTime? _updatedate;
        private string _tag;
        private bool _isagentprivate = false;
        private string _saletitle;
        private string _hotelplatid;
        private string _iscancel;
        private string _roomcount;
        private decimal _salespromotionprice;
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
        public string RoomID
        {
            set { _roomid = value; }
            get { return _roomid; }
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
        public DateTime InDate
        {
            set { _indate = value; }
            get { return _indate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OutDate
        {
            set { _outdate = value; }
            get { return _outdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BreakfirstType
        {
            set { _breakfirsttype = value; }
            get { return _breakfirsttype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BedType
        {
            set { _bedtype = value; }
            get { return _bedtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tag
        {
            set { _tag = value; }
            get { return _tag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsAgentPrivate
        {
            set { _isagentprivate = value; }
            get { return _isagentprivate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaleTitle
        {
            set { _saletitle = value; }
            get { return _saletitle; }
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
        public string IsCancel
        {
            set { _iscancel = value; }
            get { return _iscancel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoomCount
        {
            set { _roomcount = value; }
            get { return _roomcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SalesPromotionPrice
        {
            set { _salespromotionprice = value; }
            get { return _salespromotionprice; }
        }
        #endregion Model
    }
}

