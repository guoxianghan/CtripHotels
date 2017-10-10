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
    public  class HotelPriceViewServer
    {
        public HotelPriceViewServer()
        { }
        #region  BasicMethod




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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.HotelPriceViewModel GetModel(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from HotelPriceView ");
            strSql.Append(" where id=" + id.ToString());
            SqlParameter[] parameters = {
            };

            Maticsoft.Model.HotelPriceViewModel model = new Maticsoft.Model.HotelPriceViewModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
            Maticsoft.Model.HotelPriceViewModel model = new Maticsoft.Model.HotelPriceViewModel();
            if (row != null)
            {
                if (row["HotelName"] != null)
                {
                    model.HotelName = row["HotelName"].ToString();
                }
                if (row["Price"] != null && row["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(row["Price"].ToString());
                }
                if (row["HotelID"] != null && row["HotelID"].ToString() != "")
                {
                    model.HotelID = int.Parse(row["HotelID"].ToString());
                }
                if (row["PlatID"] != null && row["PlatID"].ToString() != "")
                {
                    model.PlatID = int.Parse(row["PlatID"].ToString());
                }
                if (row["RoomID"] != null)
                {
                    model.RoomID = row["RoomID"].ToString();
                }
                if (row["RoomName"] != null)
                {
                    model.RoomName = row["RoomName"].ToString();
                }
                if (row["InDate"] != null && row["InDate"].ToString() != "")
                {
                    model.InDate = DateTime.Parse(row["InDate"].ToString());
                }
                if (row["OutDate"] != null && row["OutDate"].ToString() != "")
                {
                    model.OutDate = DateTime.Parse(row["OutDate"].ToString());
                }
                if (row["HotelPlatID"] != null)
                {
                    model.HotelPlatID = row["HotelPlatID"].ToString();
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["BedType"] != null)
                {
                    model.BedType = row["BedType"].ToString();
                }
                if (row["BreakfirstType"] != null && row["BreakfirstType"].ToString() != "")
                {
                    model.BreakfirstType = int.Parse(row["BreakfirstType"].ToString());
                }
                if (row["BaseRoomID"] != null)
                {
                    model.BaseRoomID = row["BaseRoomID"].ToString();
                }
                if (row["IsAgentPrivate"] != null && row["IsAgentPrivate"].ToString() != "")
                {
                    if ((row["IsAgentPrivate"].ToString() == "1") || (row["IsAgentPrivate"].ToString().ToLower() == "true"))
                    {
                        model.IsAgentPrivate = true;
                    }
                    else
                    {
                        model.IsAgentPrivate = false;
                    }
                }
                if (row["SaleTitle"] != null)
                {
                    model.SaleTitle = row["SaleTitle"].ToString();
                }
                if (row["RoomCount"] != null)
                {
                    model.RoomCount = row["RoomCount"].ToString();
                }
                if (row["Tag"] != null)
                {
                    model.Tag = row["Tag"].ToString();
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["UpdateDate"] != null && row["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(row["UpdateDate"].ToString());
                }
                if (row["PlatName"] != null)
                {
                    model.PlatName = row["PlatName"].ToString();
                }
                if (row["Area"] != null)
                {
                    model.Area = row["Area"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM HotelPriceView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" HotelName,Price,CreateDate,HotelID,PlatID,PlatCode,RoomID,RoomTypeName,InDate,OutDate,HotelPlatID ");
            strSql.Append(" FROM HotelPriceView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM HotelPriceView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        public List<HotelPriceViewModel> GetModelList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var ds = GetListByPage(strWhere, orderby, startIndex, endIndex);
            List<HotelPriceViewModel> list = new List<HotelPriceViewModel>();
            if (ds != null && ds.Tables.Count != 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    list.Add(DataRowToModel(item));
                }
            }
            return list;
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
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

