/**  版本信息模板在安装目录下，可自行修改。
* HotelPriceView.cs
*
* 功 能： N/A
* 类 名： HotelPriceView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/9/29 21:23:24   N/A    初版
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
	/// HotelPriceView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HotelPriceViewModel
	{
		public HotelPriceViewModel()
		{}
		#region Model
		private string _hotelname;
		private decimal? _price;
		private DateTime? _createdate;
		private int? _hotelid;
		private int? _platid;
		private string _platcode;
		private int? _roomid;
		private string _roomtypename;
		private DateTime? _indate;
		private DateTime? _outdate;
		private string _hotelplatid;
        public int ID { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string HotelName
		{
			set{ _hotelname=value;}
			get{return _hotelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HotelID
		{
			set{ _hotelid=value;}
			get{return _hotelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlatID
		{
			set{ _platid=value;}
			get{return _platid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlatCode
		{
			set{ _platcode=value;}
			get{return _platcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoomID
		{
			set{ _roomid=value;}
			get{return _roomid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomTypeName
		{
			set{ _roomtypename=value;}
			get{return _roomtypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InDate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OutDate
		{
			set{ _outdate=value;}
			get{return _outdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HotelPlatID
		{
			set{ _hotelplatid=value;}
			get{return _hotelplatid;}
		}
		#endregion Model

	}
}

