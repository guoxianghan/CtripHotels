/**  版本信息模板在安装目录下，可自行修改。
* HotelPriceView.cs
*
* 功 能： N/A
* 类 名： HotelPriceView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/9/29 21:33:13   N/A    初版
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
	/// 数据访问类:HotelPriceView
	/// </summary>
	public partial class HotelPriceViewServer
	{
		public HotelPriceViewServer()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.HotelPriceViewModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HotelPriceView(");
			strSql.Append("HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID)");
			strSql.Append(" values (");
			strSql.Append("HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID)");
			SqlParameter[] parameters = {
					new SqlParameter("HotelName", SqlDbType.VarChar,20),
					new SqlParameter("Price", SqlDbType.Decimal,9),
					new SqlParameter("CreateDate", SqlDbType.DateTime),
					new SqlParameter("HotelID", SqlDbType.Int,4),
					new SqlParameter("PlatID", SqlDbType.Int,4),
					new SqlParameter("PlatCode", SqlDbType.NVarChar,20),
					new SqlParameter("RoomID", SqlDbType.Int,4),
					new SqlParameter("RoomTypeName", SqlDbType.NVarChar,100),
					new SqlParameter("InDate", SqlDbType.Date,3),
					new SqlParameter("OutDate", SqlDbType.Date,3),
					new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.HotelName;
			parameters[1].Value = model.Price;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.HotelID;
			parameters[4].Value = model.PlatID;
			parameters[5].Value = model.PlatCode;
			parameters[6].Value = model.RoomID;
			parameters[7].Value = model.RoomTypeName;
			parameters[8].Value = model.InDate;
			parameters[9].Value = model.OutDate;
			parameters[10].Value = model.HotelPlatID;

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
        public List<HotelPriceViewModel> GetModelList(string sqlwhere)
        {
            var ds = GetList(sqlwhere);
            List<HotelPriceViewModel> list = null;
            var dt = ds.Tables[0];
            list = new List<HotelPriceViewModel>();
            HotelPriceViewModel p = null;
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
        public bool Update(Maticsoft.Model.HotelPriceViewModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HotelPriceView set ");
			strSql.Append("HotelName=HotelName,");
			strSql.Append("Price=Price,");
			strSql.Append("CreateDate=CreateDate,");
			strSql.Append("HotelID=HotelID,");
			strSql.Append("PlatID=PlatID,");
			strSql.Append("PlatCode=PlatCode,");
			strSql.Append("RoomID=RoomID,");
			strSql.Append("RoomTypeName=RoomTypeName,");
			strSql.Append("InDate=InDate,");
			strSql.Append("OutDate=OutDate,");
			strSql.Append("HotelPlatID=HotelPlatID");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("HotelName", SqlDbType.VarChar,20),
					new SqlParameter("Price", SqlDbType.Decimal,9),
					new SqlParameter("CreateDate", SqlDbType.DateTime),
					new SqlParameter("HotelID", SqlDbType.Int,4),
					new SqlParameter("PlatID", SqlDbType.Int,4),
					new SqlParameter("PlatCode", SqlDbType.NVarChar,20),
					new SqlParameter("RoomID", SqlDbType.Int,4),
					new SqlParameter("RoomTypeName", SqlDbType.NVarChar,100),
					new SqlParameter("InDate", SqlDbType.Date,3),
					new SqlParameter("OutDate", SqlDbType.Date,3),
					new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.HotelName;
			parameters[1].Value = model.Price;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.HotelID;
			parameters[4].Value = model.PlatID;
			parameters[5].Value = model.PlatCode;
			parameters[6].Value = model.RoomID;
			parameters[7].Value = model.RoomTypeName;
			parameters[8].Value = model.InDate;
			parameters[9].Value = model.OutDate;
			parameters[10].Value = model.HotelPlatID;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HotelPriceView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.HotelPriceViewModel GetModel(int id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID from HotelPriceView ");
			strSql.Append(" where id="+id.ToString());
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.HotelPriceViewModel model=new Maticsoft.Model.HotelPriceViewModel();
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
		public Maticsoft.Model.HotelPriceViewModel DataRowToModel(DataRow row)
		{
			Maticsoft.Model.HotelPriceViewModel model=new Maticsoft.Model.HotelPriceViewModel();
			if (row != null)
			{
				if(row["HotelName"]!=null)
				{
					model.HotelName=row["HotelName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["HotelID"]!=null && row["HotelID"].ToString()!="")
				{
					model.HotelID=int.Parse(row["HotelID"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["PlatID"]!=null && row["PlatID"].ToString()!="")
				{
					model.PlatID=int.Parse(row["PlatID"].ToString());
				}
				if(row["PlatCode"]!=null)
				{
					model.PlatCode=row["PlatCode"].ToString();
				}
				if(row["RoomID"]!=null && row["RoomID"].ToString()!="")
				{
					model.RoomID=int.Parse(row["RoomID"].ToString());
				}
				if(row["RoomTypeName"]!=null)
				{
					model.RoomTypeName=row["RoomTypeName"].ToString();
				}
				if(row["InDate"]!=null && row["InDate"].ToString()!="")
				{
					model.InDate=DateTime.Parse(row["InDate"].ToString());
				}
				if(row["OutDate"]!=null && row["OutDate"].ToString()!="")
				{
					model.OutDate=DateTime.Parse(row["OutDate"].ToString());
				}
				if(row["HotelPlatID"]!=null)
				{
					model.HotelPlatID=row["HotelPlatID"].ToString();
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
			strSql.Append("select HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID ");
			strSql.Append(" FROM HotelPriceView ");
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
			strSql.Append(" HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID ");
			strSql.Append(" FROM HotelPriceView ");
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
			strSql.Append("select count(1) FROM HotelPriceView ");
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
			strSql.Append(")AS Row, T.*  from HotelPriceView T ");
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
			parameters[0].Value = "HotelPriceView";
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

