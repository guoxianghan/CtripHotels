﻿/**  版本信息模板在安装目录下，可自行修改。
* HotelDetail.cs
*
* 功 能： N/A
* 类 名： HotelDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/9/29 21:33:12   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CommonHelper;
using Maticsoft.Model;
using System.Collections.Generic;

namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:HotelDetail
	/// </summary>
	public partial class HotelDetailServer
	{
		public HotelDetailServer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "HotelDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HotelDetail");
			strSql.Append(" where ID=ID");
			SqlParameter[] parameters = {
					new SqlParameter("ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.HotelDetailModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HotelDetail(");
			strSql.Append("HotelID,PlatID,HotelPlatID,HotelName)");
			strSql.Append(" values (");
			strSql.Append("HotelID,PlatID,HotelPlatID,HotelName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("HotelID", SqlDbType.Int,4),
					new SqlParameter("PlatID", SqlDbType.Int,4),
					new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100),
					new SqlParameter("HotelName", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.HotelID;
			parameters[1].Value = model.PlatID;
			parameters[2].Value = model.HotelPlatID;
			parameters[3].Value = model.HotelName;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

        public List<HotelDetailModel> GetModelList(string sqlwhere)
        {
            var ds = GetList(sqlwhere);
            List<HotelDetailModel> list = null;
            var dt = ds.Tables[0];
            list = new List<HotelDetailModel>();
            HotelDetailModel p = null;
            foreach (DataRow item in dt.Rows)
            {
                p = GetModel(Convert.ToInt32(item["ID"].ToString()));
                list.Add(p);
            }
            return list;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.HotelDetailModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HotelDetail set ");
			strSql.Append("HotelID=HotelID,");
			strSql.Append("PlatID=PlatID,");
			strSql.Append("HotelPlatID=HotelPlatID,");
			strSql.Append("HotelName=HotelName");
			strSql.Append(" where ID=ID");
			SqlParameter[] parameters = {
					new SqlParameter("HotelID", SqlDbType.Int,4),
					new SqlParameter("PlatID", SqlDbType.Int,4),
					new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100),
					new SqlParameter("HotelName", SqlDbType.NVarChar,100),
					new SqlParameter("ID", SqlDbType.Int,4)};
			parameters[0].Value = model.HotelID;
			parameters[1].Value = model.PlatID;
			parameters[2].Value = model.HotelPlatID;
			parameters[3].Value = model.HotelName;
			parameters[4].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HotelDetail ");
			strSql.Append(" where ID=ID");
			SqlParameter[] parameters = {
					new SqlParameter("ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HotelDetail ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.HotelDetailModel GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,HotelID,PlatID,HotelPlatID,HotelName from HotelDetail ");
			strSql.Append(" where ID=ID");
			SqlParameter[] parameters = {
					new SqlParameter("ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.HotelDetailModel model=new Maticsoft.Model.HotelDetailModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.HotelDetailModel DataRowToModel(DataRow row)
		{
			Maticsoft.Model.HotelDetailModel model=new Maticsoft.Model.HotelDetailModel();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["HotelID"]!=null && row["HotelID"].ToString()!="")
				{
					model.HotelID=int.Parse(row["HotelID"].ToString());
				}
				if(row["PlatID"]!=null && row["PlatID"].ToString()!="")
				{
					model.PlatID=int.Parse(row["PlatID"].ToString());
				}
				if(row["HotelPlatID"]!=null)
				{
					model.HotelPlatID=row["HotelPlatID"].ToString();
				}
				if(row["HotelName"]!=null)
				{
					model.HotelName=row["HotelName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HotelID,PlatID,HotelPlatID,HotelName ");
			strSql.Append(" FROM HotelDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,HotelID,PlatID,HotelPlatID,HotelName ");
			strSql.Append(" FROM HotelDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM HotelDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from HotelDetail T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("tblName", SqlDbType.VarChar, 255),
					new SqlParameter("fldName", SqlDbType.VarChar, 255),
					new SqlParameter("PageSize", SqlDbType.Int),
					new SqlParameter("PageIndex", SqlDbType.Int),
					new SqlParameter("IsReCount", SqlDbType.Bit),
					new SqlParameter("OrderType", SqlDbType.Bit),
					new SqlParameter("strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "HotelDetail";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
