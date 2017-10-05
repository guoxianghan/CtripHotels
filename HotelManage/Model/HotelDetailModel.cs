/**  版本信息模板在安装目录下，可自行修改。
* HotelDetail.cs
*
* 功 能： N/A
* 类 名： HotelDetail
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
	/// HotelDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HotelDetailModel
	{
		public HotelDetailModel()
		{}
		#region Model
		private int _id;
		private int? _hotelid;
		private int? _platid;
		private string _hotelplatid;
		private string _hotelname;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public string HotelPlatID
		{
			set{ _hotelplatid=value;}
			get{return _hotelplatid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HotelName
		{
			set{ _hotelname=value;}
			get{return _hotelname;}
		}
		#endregion Model

	}
}

