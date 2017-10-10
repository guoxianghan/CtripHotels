/**  版本信息模板在安装目录下，可自行修改。
* HotelDetailView.cs
*
* 功 能： N/A
* 类 名： HotelDetailView
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
	/// HotelDetailView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HotelDetailViewModel
	{
		public HotelDetailViewModel()
		{}
        public int ID { get; set; }
        #region Model
        private string _hotelplatname;
		private string _hotelplatid;
		private int _hotelid;
		private string _hotelname;
		private string _platname;
		private int _platid;
		/// <summary>
		/// 
		/// </summary>
		public string HotelPlatName
		{
			set{ _hotelplatname=value;}
			get{return _hotelplatname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HotelPlatID
		{
			set{ _hotelplatid=value;}
			get{return _hotelplatid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int HotelID
		{
			set{ _hotelid=value;}
			get{return _hotelid;}
		}
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
		public string PlatName
		{
			set{ _platname=value;}
			get{return _platname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PlatID
		{
			set{ _platid=value;}
			get{return _platid;}
		}
        public string City { get; set; }
        public string Area { get; set; }
		#endregion Model

	}
}

