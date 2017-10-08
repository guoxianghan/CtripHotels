/**  版本信息模板在安装目录下，可自行修改。
* HotelPrice.cs
*
* 功 能： N/A
* 类 名： HotelPrice
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
    /// 数据访问类:HotelPrice
    /// </summary>
    public partial class HotelPriceServer
    {
        public HotelPriceServer()
        { }
        #region
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.HotelPriceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into HotelPrice(");
            strSql.Append("PlatID,HotelID,RoomID,BaseRoomID,InDate,OutDate,BreakfirstType,BedType,Price,CreateDate,UpdateDate,Tag,IsAgentPrivate,SaleTitle,HotelPlatID,IsCancel,RoomCount,SalesPromotionPrice)");
            strSql.Append(" values (");
            strSql.Append("@PlatID,@HotelID,@RoomID,@BaseRoomID,@InDate,@OutDate,@BreakfirstType,@BedType,@Price,@CreateDate,@UpdateDate,@Tag,@IsAgentPrivate,@SaleTitle,@HotelPlatID,@IsCancel,@RoomCount,@SalesPromotionPrice)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@PlatID", SqlDbType.Int,4),
                    new SqlParameter("@HotelID", SqlDbType.Int,4),
                    new SqlParameter("@RoomID", SqlDbType.VarChar,50),
                    new SqlParameter("@BaseRoomID", SqlDbType.VarChar,50),
                    new SqlParameter("@InDate", SqlDbType.Date,3),
                    new SqlParameter("@OutDate", SqlDbType.Date,3),
                    new SqlParameter("@BreakfirstType", SqlDbType.Int,4),
                    new SqlParameter("@BedType", SqlDbType.VarChar,50),
                    new SqlParameter("@Price", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime),
                    new SqlParameter("@Tag", SqlDbType.VarChar,1000),
                    new SqlParameter("@IsAgentPrivate", SqlDbType.Bit,1),
                    new SqlParameter("@SaleTitle", SqlDbType.VarChar,500),
                    new SqlParameter("@HotelPlatID", SqlDbType.VarChar,50),
                    new SqlParameter("@IsCancel", SqlDbType.NVarChar,50),
                    new SqlParameter("@RoomCount", SqlDbType.NVarChar,50),
                    new SqlParameter("@SalesPromotionPrice", SqlDbType.Decimal,9)};
            parameters[0].Value = model.PlatID;
            parameters[1].Value = model.HotelID;
            parameters[2].Value = model.RoomID;
            parameters[3].Value = model.BaseRoomID;
            parameters[4].Value = model.InDate;
            parameters[5].Value = model.OutDate;
            parameters[6].Value = model.BreakfirstType;
            parameters[7].Value = model.BedType;
            parameters[8].Value = model.Price;
            parameters[9].Value = model.CreateDate;
            parameters[10].Value = model.UpdateDate;
            parameters[11].Value = model.Tag;
            parameters[12].Value = model.IsAgentPrivate;
            parameters[13].Value = model.SaleTitle;
            parameters[14].Value = model.HotelPlatID;
            parameters[15].Value = model.IsCancel;
            parameters[16].Value = model.RoomCount;
            parameters[17].Value = model.SalesPromotionPrice;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.HotelPriceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HotelPrice set ");
            strSql.Append("PlatID=@PlatID,");
            strSql.Append("HotelID=@HotelID,");
            strSql.Append("RoomID=@RoomID,");
            strSql.Append("BaseRoomID=@BaseRoomID,");
            strSql.Append("InDate=@InDate,");
            strSql.Append("OutDate=@OutDate,");
            strSql.Append("BreakfirstType=@BreakfirstType,");
            strSql.Append("BedType=@BedType,");
            strSql.Append("Price=@Price,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("UpdateDate=@UpdateDate,");
            strSql.Append("Tag=@Tag,");
            strSql.Append("IsAgentPrivate=@IsAgentPrivate,");
            strSql.Append("SaleTitle=@SaleTitle,");
            strSql.Append("HotelPlatID=@HotelPlatID,");
            strSql.Append("IsCancel=@IsCancel,");
            strSql.Append("RoomCount=@RoomCount,");
            strSql.Append("SalesPromotionPrice=@SalesPromotionPrice");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@PlatID", SqlDbType.Int,4),
                    new SqlParameter("@HotelID", SqlDbType.Int,4),
                    new SqlParameter("@RoomID", SqlDbType.VarChar,50),
                    new SqlParameter("@BaseRoomID", SqlDbType.VarChar,50),
                    new SqlParameter("@InDate", SqlDbType.Date,3),
                    new SqlParameter("@OutDate", SqlDbType.Date,3),
                    new SqlParameter("@BreakfirstType", SqlDbType.Int,4),
                    new SqlParameter("@BedType", SqlDbType.VarChar,50),
                    new SqlParameter("@Price", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime),
                    new SqlParameter("@Tag", SqlDbType.VarChar,1000),
                    new SqlParameter("@IsAgentPrivate", SqlDbType.Bit,1),
                    new SqlParameter("@SaleTitle", SqlDbType.VarChar,50),
                    new SqlParameter("@HotelPlatID", SqlDbType.VarChar,50),
                    new SqlParameter("@IsCancel", SqlDbType.NVarChar,50),
                    new SqlParameter("@RoomCount", SqlDbType.NVarChar,50),
                    new SqlParameter("@SalesPromotionPrice", SqlDbType.Decimal,9),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.PlatID;
            parameters[1].Value = model.HotelID;
            parameters[2].Value = model.RoomID;
            parameters[3].Value = model.BaseRoomID;
            parameters[4].Value = model.InDate;
            parameters[5].Value = model.OutDate;
            parameters[6].Value = model.BreakfirstType;
            parameters[7].Value = model.BedType;
            parameters[8].Value = model.Price;
            parameters[9].Value = model.CreateDate;
            parameters[10].Value = model.UpdateDate;
            parameters[11].Value = model.Tag;
            parameters[12].Value = model.IsAgentPrivate;
            parameters[13].Value = model.SaleTitle;
            parameters[14].Value = model.HotelPlatID;
            parameters[15].Value = model.IsCancel;
            parameters[16].Value = model.RoomCount;
            parameters[17].Value = model.SalesPromotionPrice;
            parameters[18].Value = model.ID;

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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HotelPrice ");
            strSql.Append(" where ID=ID");
            SqlParameter[] parameters = {
                    new SqlParameter("ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HotelPrice ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Maticsoft.Model.HotelPriceModel GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,PlatID,HotelID,RoomID,BaseRoomID,InDate,OutDate,BreakfirstType,BedType,Price,CreateDate,UpdateDate,Tag,IsAgentPrivate,SaleTitle,HotelPlatID,IsCancel,RoomCount,SalesPromotionPrice from HotelPrice ");
            strSql.Append(" where ID=ID");
            SqlParameter[] parameters = {
                    new SqlParameter("ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            Maticsoft.Model.HotelPriceModel model = new Maticsoft.Model.HotelPriceModel();
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
        public Maticsoft.Model.HotelPriceModel DataRowToModel(DataRow row)
        {
            Maticsoft.Model.HotelPriceModel model = new Maticsoft.Model.HotelPriceModel();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["PlatID"] != null && row["PlatID"].ToString() != "")
                {
                    model.PlatID = int.Parse(row["PlatID"].ToString());
                }
                if (row["HotelID"] != null && row["HotelID"].ToString() != "")
                {
                    model.HotelID = int.Parse(row["HotelID"].ToString());
                }
                if (row["RoomID"] != null)
                {
                    model.RoomID = row["RoomID"].ToString();
                }
                if (row["BaseRoomID"] != null)
                {
                    model.BaseRoomID = row["BaseRoomID"].ToString();
                }
                if (row["InDate"] != null && row["InDate"].ToString() != "")
                {
                    model.InDate = DateTime.Parse(row["InDate"].ToString());
                }
                if (row["OutDate"] != null && row["OutDate"].ToString() != "")
                {
                    model.OutDate = DateTime.Parse(row["OutDate"].ToString());
                }
                if (row["BreakfirstType"] != null && row["BreakfirstType"].ToString() != "")
                {
                    model.BreakfirstType = int.Parse(row["BreakfirstType"].ToString());
                }
                if (row["BedType"] != null)
                {
                    model.BedType = row["BedType"].ToString();
                }
                if (row["Price"] != null && row["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(row["Price"].ToString());
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["UpdateDate"] != null && row["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(row["UpdateDate"].ToString());
                }
                if (row["Tag"] != null)
                {
                    model.Tag = row["Tag"].ToString();
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
                if (row["HotelPlatID"] != null)
                {
                    model.HotelPlatID = row["HotelPlatID"].ToString();
                }
                if (row["IsCancel"] != null)
                {
                    model.IsCancel = row["IsCancel"].ToString();
                }
                if (row["RoomCount"] != null)
                {
                    model.RoomCount = row["RoomCount"].ToString();
                }
                if (row["SalesPromotionPrice"] != null && row["SalesPromotionPrice"].ToString() != "")
                {
                    model.SalesPromotionPrice = decimal.Parse(row["SalesPromotionPrice"].ToString());
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
            strSql.Append("select ID,PlatID,HotelID,RoomID,BaseRoomID,InDate,OutDate,BreakfirstType,BedType,Price,CreateDate,UpdateDate,Tag,IsAgentPrivate,SaleTitle,HotelPlatID,IsCancel,RoomCount,SalesPromotionPrice ");
            strSql.Append(" FROM HotelPrice ");
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
            strSql.Append(" ID,PlatID,HotelID,RoomID,BaseRoomID,InDate,OutDate,BreakfirstType,BedType,Price,CreateDate,UpdateDate,Tag,IsAgentPrivate,SaleTitle,HotelPlatID,IsCancel,RoomCount,SalesPromotionPrice ");
            strSql.Append(" FROM HotelPrice ");
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
            strSql.Append("select count(1) FROM HotelPrice ");
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
            strSql.Append(")AS Row, T.*  from HotelPrice T ");
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
			parameters[0].Value = "HotelPrice";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

#endregion  BasicMethod
        public List<HotelPriceModel> GetModelList(string sqlwhere)
        {
            var ds = GetList(sqlwhere);
            List<HotelPriceModel> list = null;
            var dt = ds.Tables[0];
            list = new List<HotelPriceModel>();
            HotelPriceModel p = null;
            foreach (DataRow item in dt.Rows)
            {
                p = GetModel(Convert.ToInt32(item["ID"].ToString()));
                list.Add(p);
            }
            return list;
        }
        public void UpdatePrice(decimal price, int id)
        {
            DbHelperSQL.ExecuteSql("UPDATE HotelPrice SET PRICE=" + price + ",[UpdateDate]='"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"'  where id=" + id);
        }
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

