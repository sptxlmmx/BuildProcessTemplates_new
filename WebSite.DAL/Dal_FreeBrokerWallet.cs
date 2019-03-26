
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_FreeBrokerWallet
	/// </summary>
	public partial class Dal_FreeBrokerWallet
	{
		public Dal_FreeBrokerWallet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_FreeBrokerWallet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_FreeBrokerWallet");
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
		public int Add(WebSite.Model.Mod_FreeBrokerWallet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_FreeBrokerWallet(");
			strSql.Append("Title,UserID,UserNickName,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,MoneyTotal,MoneyTotalFrozen,Money,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Title,@UserID,@UserNickName,@FreeBrokerInvitationActionID,@FreeBrokerInvitationActionTitle,@MoneyTotal,@MoneyTotalFrozen,@Money,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationActionID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationActionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@MoneyTotal", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyTotalFrozen", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.UserNickName;
			parameters[3].Value = model.FreeBrokerInvitationActionID;
			parameters[4].Value = model.FreeBrokerInvitationActionTitle;
			parameters[5].Value = model.MoneyTotal;
			parameters[6].Value = model.MoneyTotalFrozen;
			parameters[7].Value = model.Money;
			parameters[8].Value = model.State;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.AddDate;
			parameters[11].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_FreeBrokerWallet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_FreeBrokerWallet set ");
			strSql.Append("Title=@Title,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("FreeBrokerInvitationActionID=@FreeBrokerInvitationActionID,");
			strSql.Append("FreeBrokerInvitationActionTitle=@FreeBrokerInvitationActionTitle,");
			strSql.Append("MoneyTotal=@MoneyTotal,");
			strSql.Append("MoneyTotalFrozen=@MoneyTotalFrozen,");
			strSql.Append("Money=@Money,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationActionID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationActionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@MoneyTotal", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyTotalFrozen", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.UserNickName;
			parameters[3].Value = model.FreeBrokerInvitationActionID;
			parameters[4].Value = model.FreeBrokerInvitationActionTitle;
			parameters[5].Value = model.MoneyTotal;
			parameters[6].Value = model.MoneyTotalFrozen;
			parameters[7].Value = model.Money;
			parameters[8].Value = model.State;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.AddDate;
			parameters[11].Value = model.WebSiteID;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from SW_FreeBrokerWallet ");
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
			strSql.Append("delete from SW_FreeBrokerWallet ");
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
		public WebSite.Model.Mod_FreeBrokerWallet GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,UserID,UserNickName,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,MoneyTotal,MoneyTotalFrozen,Money,State,OrderBy,AddDate,WebSiteID from SW_FreeBrokerWallet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_FreeBrokerWallet model=new WebSite.Model.Mod_FreeBrokerWallet();
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
		public WebSite.Model.Mod_FreeBrokerWallet DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_FreeBrokerWallet model=new WebSite.Model.Mod_FreeBrokerWallet();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["FreeBrokerInvitationActionID"]!=null && row["FreeBrokerInvitationActionID"].ToString()!="")
				{
					model.FreeBrokerInvitationActionID=int.Parse(row["FreeBrokerInvitationActionID"].ToString());
				}
				if(row["FreeBrokerInvitationActionTitle"]!=null)
				{
					model.FreeBrokerInvitationActionTitle=row["FreeBrokerInvitationActionTitle"].ToString();
				}
				if(row["MoneyTotal"]!=null && row["MoneyTotal"].ToString()!="")
				{
					model.MoneyTotal=decimal.Parse(row["MoneyTotal"].ToString());
				}
				if(row["MoneyTotalFrozen"]!=null && row["MoneyTotalFrozen"].ToString()!="")
				{
					model.MoneyTotalFrozen=decimal.Parse(row["MoneyTotalFrozen"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
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
			strSql.Append("select ID,Title,UserID,UserNickName,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,MoneyTotal,MoneyTotalFrozen,Money,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerWallet ");
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
			strSql.Append(" ID,Title,UserID,UserNickName,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,MoneyTotal,MoneyTotalFrozen,Money,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerWallet ");
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
			strSql.Append("select count(1) FROM SW_FreeBrokerWallet ");
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
                strSql = "select top " + endIndex + " * from SW_FreeBrokerWallet where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_FreeBrokerWallet where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_FreeBrokerWallet where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_FreeBrokerWallet";
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
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_FreeBrokerWallet GetUserIDModel(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Title,UserID,UserNickName,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,MoneyTotal,MoneyTotalFrozen,Money,State,OrderBy,AddDate,WebSiteID from SW_FreeBrokerWallet ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            WebSite.Model.Mod_FreeBrokerWallet model = new WebSite.Model.Mod_FreeBrokerWallet();
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
		#endregion  ExtensionMethod
	}
}

