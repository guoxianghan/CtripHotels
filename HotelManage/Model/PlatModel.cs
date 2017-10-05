/**  版本信息模板在安装目录下，可自行修改。
* Plat.cs
*
* 功 能： N/A
* 类 名： Plat
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
	/// Plat:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PlatModel
	{
		public PlatModel()
		{}
		#region Model
		private int _id;
		private string _platcode;
		private string _platname;
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
		public string PlatCode
		{
			set{ _platcode=value;}
			get{return _platcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlatName
		{
			set{ _platname=value;}
			get{return _platname;}
		}
		#endregion Model

	}
}

