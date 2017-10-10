using CommonHelper;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Maticsoft.Server
{
    public class HotelRoomViewServer
    {
        public HotelRoomViewServer()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID, string BaseRoomID, int PlatID, int HotelID, string RoomName, DateTime CreateDate, string HotelPlatID, string RoomID, string PlatName, string HotelName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from HotelRoomView");
            strSql.Append(" where ID=ID and BaseRoomID=BaseRoomID and PlatID=PlatID and HotelID=HotelID and RoomName=RoomName and CreateDate=CreateDate and HotelPlatID=HotelPlatID and RoomID=RoomID and PlatName=PlatName and HotelName=HotelName ");
            SqlParameter[] parameters = {
                    new SqlParameter("ID", SqlDbType.Int,4),
                    new SqlParameter("BaseRoomID", SqlDbType.NVarChar,100),
                    new SqlParameter("PlatID", SqlDbType.Int,4),
                    new SqlParameter("HotelID", SqlDbType.Int,4),
                    new SqlParameter("RoomName", SqlDbType.NVarChar,100),
                    new SqlParameter("CreateDate", SqlDbType.DateTime),
                    new SqlParameter("HotelPlatID", SqlDbType.VarChar,50),
                    new SqlParameter("RoomID", SqlDbType.NVarChar,100),
                    new SqlParameter("PlatName", SqlDbType.NVarChar,20),
                    new SqlParameter("HotelName", SqlDbType.NVarChar,100)            };
            parameters[0].Value = ID;
            parameters[1].Value = BaseRoomID;
            parameters[2].Value = PlatID;
            parameters[3].Value = HotelID;
            parameters[4].Value = RoomName;
            parameters[5].Value = CreateDate;
            parameters[6].Value = HotelPlatID;
            parameters[7].Value = RoomID;
            parameters[8].Value = PlatName;
            parameters[9].Value = HotelName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


      


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.HotelRoomViewModel GetModel(int ID, string BaseRoomID, int PlatID, int HotelID, string RoomName, DateTime CreateDate, string HotelPlatID, string RoomID, string PlatName, string HotelName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,BaseRoomID,PlatID,HotelID,RoomName,CreateDate,HotelPlatID,RoomID,PlatName,HotelName from HotelRoomView ");
            strSql.Append(" where ID=@ID and BaseRoomID=@BaseRoomID and PlatID=@PlatID and HotelID=@HotelID and RoomName=@RoomName and CreateDate=@CreateDate and HotelPlatID=@HotelPlatID and RoomID=@RoomID and PlatName=@PlatName and HotelName=@HotelName ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@BaseRoomID", SqlDbType.NVarChar,100),
                    new SqlParameter("@PlatID", SqlDbType.Int,4),
                    new SqlParameter("@HotelID", SqlDbType.Int,4),
                    new SqlParameter("@RoomName", SqlDbType.NVarChar,100),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@HotelPlatID", SqlDbType.VarChar,50),
                    new SqlParameter("@RoomID", SqlDbType.NVarChar,100),
                    new SqlParameter("@PlatName", SqlDbType.NVarChar,20),
                    new SqlParameter("@HotelName", SqlDbType.NVarChar,100)            };
            parameters[0].Value = ID;
            parameters[1].Value = BaseRoomID;
            parameters[2].Value = PlatID;
            parameters[3].Value = HotelID;
            parameters[4].Value = RoomName;
            parameters[5].Value = CreateDate;
            parameters[6].Value = HotelPlatID;
            parameters[7].Value = RoomID;
            parameters[8].Value = PlatName;
            parameters[9].Value = HotelName;

            Maticsoft.Model.HotelRoomViewModel model = new Maticsoft.Model.HotelRoomViewModel();
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
        public List<HotelRoomViewModel> GetModelList(string sqlwhere)
        {
            var ds = GetList(sqlwhere);
            List<HotelRoomViewModel> list = new List<HotelRoomViewModel>();
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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.HotelRoomViewModel DataRowToModel(DataRow row)
        {
            Maticsoft.Model.HotelRoomViewModel model = new Maticsoft.Model.HotelRoomViewModel();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["BaseRoomID"] != null)
                {
                    model.BaseRoomID = row["BaseRoomID"].ToString();
                }
                if (row["PlatID"] != null && row["PlatID"].ToString() != "")
                {
                    model.PlatID = int.Parse(row["PlatID"].ToString());
                }
                if (row["HotelID"] != null && row["HotelID"].ToString() != "")
                {
                    model.HotelID = int.Parse(row["HotelID"].ToString());
                }
                if (row["RoomName"] != null)
                {
                    model.RoomName = row["RoomName"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["HotelPlatID"] != null)
                {
                    model.HotelPlatID = row["HotelPlatID"].ToString();
                }
                if (row["RoomID"] != null)
                {
                    model.RoomID = row["RoomID"].ToString();
                }
                if (row["PlatName"] != null)
                {
                    model.PlatName = row["PlatName"].ToString();
                }
                if (row["HotelName"] != null)
                {
                    model.HotelName = row["HotelName"].ToString();
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
            strSql.Append("select ID,BaseRoomID,PlatID,HotelID,RoomName,CreateDate,HotelPlatID,RoomID,PlatName,HotelName ");
            strSql.Append(" FROM HotelRoomView ");
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
            strSql.Append(" ID,BaseRoomID,PlatID,HotelID,RoomName,CreateDate,HotelPlatID,RoomID,PlatName,HotelName ");
            strSql.Append(" FROM HotelRoomView ");
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
            strSql.Append("select count(1) FROM HotelRoomView ");
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

        public List<HotelRoomViewModel> GetModelList(string sqlwhere, string orderby, int startIndex, int endIndex)
        {
            var ds = GetListByPage(sqlwhere, orderby, startIndex, endIndex);
            List<HotelRoomViewModel> list = new List<HotelRoomViewModel>();
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
                strSql.Append("order by T.HotelName desc");
            }
            strSql.Append(")AS Row, T.*  from HotelRoomView T ");
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
			parameters[0].Value = "HotelRoomView";
			parameters[1].Value = "HotelName";
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
