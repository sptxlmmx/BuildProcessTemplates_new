using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_OrderAction
	/// </summary>
	public partial class Dal_OrderAction
	{
		public Dal_OrderAction()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_OrderAction"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_OrderAction");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebSite.Model.Mod_OrderAction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_OrderAction(");
			strSql.Append("OrderID,OrderNo,OperatorModel,OperatorID,OperatorName,OrderState,LogisticsState,PayState,Reason,AddDate)");
			strSql.Append(" values (");
			strSql.Append("@OrderID,@OrderNo,@OperatorModel,@OperatorID,@OperatorName,@OrderState,@LogisticsState,@PayState,@Reason,@AddDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorModel", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderState", SqlDbType.Int,4),
					new SqlParameter("@LogisticsState", SqlDbType.Int,4),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@Reason", SqlDbType.VarChar,1000),
					new SqlParameter("@AddDate", SqlDbType.DateTime)};
			parameters[0].Value = model.OrderID;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.OperatorModel;
			parameters[3].Value = model.OperatorID;
			parameters[4].Value = model.OperatorName;
			parameters[5].Value = model.OrderState;
			parameters[6].Value = model.LogisticsState;
			parameters[7].Value = model.PayState;
			parameters[8].Value = model.Reason;
			parameters[9].Value = model.AddDate;

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
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_OrderAction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_OrderAction set ");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("OperatorModel=@OperatorModel,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("OperatorName=@OperatorName,");
			strSql.Append("OrderState=@OrderState,");
			strSql.Append("LogisticsState=@LogisticsState,");
			strSql.Append("PayState=@PayState,");
			strSql.Append("Reason=@Reason,");
			strSql.Append("AddDate=@AddDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorModel", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderState", SqlDbType.Int,4),
					new SqlParameter("@LogisticsState", SqlDbType.Int,4),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@Reason", SqlDbType.VarChar,1000),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderID;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.OperatorModel;
			parameters[3].Value = model.OperatorID;
			parameters[4].Value = model.OperatorName;
			parameters[5].Value = model.OrderState;
			parameters[6].Value = model.LogisticsState;
			parameters[7].Value = model.PayState;
			parameters[8].Value = model.Reason;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from SW_OrderAction ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
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
			strSql.Append("delete from SW_OrderAction ");
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
		public WebSite.Model.Mod_OrderAction GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OrderID,OrderNo,OperatorModel,OperatorID,OperatorName,OrderState,LogisticsState,PayState,Reason,AddDate from SW_OrderAction ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_OrderAction model=new WebSite.Model.Mod_OrderAction();
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
		public WebSite.Model.Mod_OrderAction DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_OrderAction model=new WebSite.Model.Mod_OrderAction();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["OrderID"]!=null && row["OrderID"].ToString()!="")
				{
					model.OrderID=int.Parse(row["OrderID"].ToString());
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["OperatorModel"]!=null)
				{
					model.OperatorModel=row["OperatorModel"].ToString();
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["OrderState"]!=null && row["OrderState"].ToString()!="")
				{
					model.OrderState=int.Parse(row["OrderState"].ToString());
				}
				if(row["LogisticsState"]!=null && row["LogisticsState"].ToString()!="")
				{
					model.LogisticsState=int.Parse(row["LogisticsState"].ToString());
				}
				if(row["PayState"]!=null && row["PayState"].ToString()!="")
				{
					model.PayState=int.Parse(row["PayState"].ToString());
				}
				if(row["Reason"]!=null)
				{
					model.Reason=row["Reason"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
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
			strSql.Append("select ID,OrderID,OrderNo,OperatorModel,OperatorID,OperatorName,OrderState,LogisticsState,PayState,Reason,AddDate ");
			strSql.Append(" FROM SW_OrderAction ");
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
			strSql.Append(" ID,OrderID,OrderNo,OperatorModel,OperatorID,OperatorName,OrderState,LogisticsState,PayState,Reason,AddDate ");
			strSql.Append(" FROM SW_OrderAction ");
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
			strSql.Append("select count(1) FROM SW_OrderAction ");
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
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " * from SW_OrderAction where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_OrderAction where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_OrderAction where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "SW_OrderAction";
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
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string Where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_OrderAction ");
            strSql.Append(" where " + Where + " ");
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
		#endregion  ExtensionMethod
	}
}

