/**  版本信息模板在安装目录下，可自行修改。
* HotelDetailView.cs
*
* 功 能： N/A
* 类 名： HotelDetailView
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
    /// 数据访问类:HotelDetailView
    /// </summary>
    public partial class HotelDetailViewServer
    {
        public HotelDetailViewServer()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.HotelDetailViewModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into HotelDetailView(");
            strSql.Append("HotelPlatName,HotelPlatID,HotelID,HotelName,PlatName,PlatID)");
            strSql.Append(" values (");
            strSql.Append("HotelPlatName,HotelPlatID,HotelID,HotelName,PlatName,PlatID)");
            SqlParameter[] parameters = {
                    new SqlParameter("HotelPlatName", SqlDbType.NVarChar,100),
                    new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100),
                    new SqlParameter("HotelID", SqlDbType.Int,4),
                    new SqlParameter("HotelName", SqlDbType.VarChar,20),
                    new SqlParameter("PlatName", SqlDbType.NVarChar,20),
                    new SqlParameter("PlatID", SqlDbType.Int,4)};
            parameters[0].Value = model.HotelPlatName;
            parameters[1].Value = model.HotelPlatID;
            parameters[2].Value = model.HotelID;
            parameters[3].Value = model.HotelName;
            parameters[4].Value = model.PlatName;
            parameters[5].Value = model.PlatID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<HotelDetailViewModel> GetModelList(string sqlwhere)
        {
            var ds = GetList(sqlwhere);
            List<HotelDetailViewModel> list = null;
            var dt = ds.Tables[0];
            list = new List<HotelDetailViewModel>();
            HotelDetailViewModel p = null;
            foreach (DataRow item in dt.Rows)
            {
                p = DataRowToModel(item);
                list.Add(p);
            }
            return list;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.HotelDetailViewModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HotelDetailView set ");
            strSql.Append("HotelPlatName=HotelPlatName,");
            strSql.Append("HotelPlatID=HotelPlatID,");
            strSql.Append("HotelID=HotelID,");
            strSql.Append("HotelName=HotelName,");
            strSql.Append("PlatName=PlatName,");
            strSql.Append("PlatID=PlatID");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
                    new SqlParameter("HotelPlatName", SqlDbType.NVarChar,100),
                    new SqlParameter("HotelPlatID", SqlDbType.NVarChar,100),
                    new SqlParameter("HotelID", SqlDbType.Int,4),
                    new SqlParameter("HotelName", SqlDbType.VarChar,20),
                    new SqlParameter("PlatName", SqlDbType.NVarChar,20),
                    new SqlParameter("PlatID", SqlDbType.Int,4)};
            parameters[0].Value = model.HotelPlatName;
            parameters[1].Value = model.HotelPlatID;
            parameters[2].Value = model.HotelID;
            parameters[3].Value = model.HotelName;
            parameters[4].Value = model.PlatName;
            parameters[5].Value = model.PlatID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HotelDetailView ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
            };

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public Maticsoft.Model.HotelDetailViewModel GetModel(string id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from HotelDetailView ");
            strSql.Append(" where id=" + id);
            SqlParameter[] parameters = {
            };

            Maticsoft.Model.HotelDetailViewModel model = new Maticsoft.Model.HotelDetailViewModel();
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
        public Maticsoft.Model.HotelDetailViewModel DataRowToModel(DataRow row)
        {
            Maticsoft.Model.HotelDetailViewModel model = new Maticsoft.Model.HotelDetailViewModel();
            if (row != null)
            {
                if (row["HotelPlatName"] != null)
                {
                    model.HotelPlatName = row["HotelPlatName"].ToString();
                }
                if (row["HotelPlatID"] != null)
                {
                    model.HotelPlatID = row["HotelPlatID"].ToString();
                }
                if (row["HotelID"] != null && row["HotelID"].ToString() != "")
                {
                    model.HotelID = int.Parse(row["HotelID"].ToString());
                }
                if (row["HotelName"] != null)
                {
                    model.HotelName = row["HotelName"].ToString();
                }
                if (row["PlatName"] != null)
                {
                    model.PlatName = row["PlatName"].ToString();
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["Area"] != null)
                {
                    model.Area = row["Area"].ToString();
                }
                if (row["PlatID"] != null && row["PlatID"].ToString() != "")
                {
                    model.PlatID = int.Parse(row["PlatID"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
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
            strSql.Append(" FROM HotelDetailView ");
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
            strSql.Append(" HotelPlatName,HotelPlatID,HotelID,HotelName,PlatName,PlatID ");
            strSql.Append(" FROM HotelDetailView ");
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
            strSql.Append("select count(1) FROM HotelDetailView ");
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

        public List<HotelDetailViewModel> GetListModelByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            DataSet ds = GetListByPage(strWhere, orderby, startIndex, endIndex);
            var dt = ds.Tables[0];
            var list = new List<HotelDetailViewModel>();
            HotelDetailViewModel p = null;
            foreach (DataRow item in dt.Rows)
            {
                p = DataRowToModel(item);
                list.Add(p);
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
            strSql.Append(")AS Row, T.*  from HotelDetailView T ");
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
			parameters[0].Value = "HotelDetailView";
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

