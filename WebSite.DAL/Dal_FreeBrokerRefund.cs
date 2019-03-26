using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_FreeBrokerRefund
	/// </summary>
	public partial class Dal_FreeBrokerRefund
	{
		public Dal_FreeBrokerRefund()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_FreeBrokerRefund"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_FreeBrokerRefund");
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
		public int Add(WebSite.Model.Mod_FreeBrokerRefund model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_FreeBrokerRefund(");
			strSql.Append("Model,OrderNo,UserID,FreeBrokerName,FreeBrokerTel,LevelID,LevelIDTitle,Money,PayID,PayName,Info,Content1,IsLookUser,IsProcess,WithdrawImage,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@UserID,@FreeBrokerName,@FreeBrokerTel,@LevelID,@LevelIDTitle,@Money,@PayID,@PayName,@Info,@Content1,@IsLookUser,@IsProcess,@WithdrawImage,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,150),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerName", SqlDbType.NVarChar,200),
					new SqlParameter("@FreeBrokerTel", SqlDbType.NVarChar,50),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelIDTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.NVarChar,150),
					new SqlParameter("@Info", SqlDbType.NVarChar,1000),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@IsProcess", SqlDbType.Int,4),
					new SqlParameter("@WithdrawImage", SqlDbType.NVarChar,250),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.FreeBrokerName;
			parameters[4].Value = model.FreeBrokerTel;
			parameters[5].Value = model.LevelID;
			parameters[6].Value = model.LevelIDTitle;
			parameters[7].Value = model.Money;
			parameters[8].Value = model.PayID;
			parameters[9].Value = model.PayName;
			parameters[10].Value = model.Info;
			parameters[11].Value = model.Content1;
			parameters[12].Value = model.IsLookUser;
			parameters[13].Value = model.IsProcess;
			parameters[14].Value = model.WithdrawImage;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.ModifyDate;
			parameters[19].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_FreeBrokerRefund model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_FreeBrokerRefund set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("FreeBrokerName=@FreeBrokerName,");
			strSql.Append("FreeBrokerTel=@FreeBrokerTel,");
			strSql.Append("LevelID=@LevelID,");
			strSql.Append("LevelIDTitle=@LevelIDTitle,");
			strSql.Append("Money=@Money,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("Info=@Info,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("IsLookUser=@IsLookUser,");
			strSql.Append("IsProcess=@IsProcess,");
			strSql.Append("WithdrawImage=@WithdrawImage,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,150),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerName", SqlDbType.NVarChar,200),
					new SqlParameter("@FreeBrokerTel", SqlDbType.NVarChar,50),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelIDTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.NVarChar,150),
					new SqlParameter("@Info", SqlDbType.NVarChar,1000),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@IsProcess", SqlDbType.Int,4),
					new SqlParameter("@WithdrawImage", SqlDbType.NVarChar,250),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.FreeBrokerName;
			parameters[4].Value = model.FreeBrokerTel;
			parameters[5].Value = model.LevelID;
			parameters[6].Value = model.LevelIDTitle;
			parameters[7].Value = model.Money;
			parameters[8].Value = model.PayID;
			parameters[9].Value = model.PayName;
			parameters[10].Value = model.Info;
			parameters[11].Value = model.Content1;
			parameters[12].Value = model.IsLookUser;
			parameters[13].Value = model.IsProcess;
			parameters[14].Value = model.WithdrawImage;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.ModifyDate;
			parameters[19].Value = model.WebSiteID;
			parameters[20].Value = model.ID;

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
			strSql.Append("delete from SW_FreeBrokerRefund ");
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
			strSql.Append("delete from SW_FreeBrokerRefund ");
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
		public WebSite.Model.Mod_FreeBrokerRefund GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,UserID,FreeBrokerName,FreeBrokerTel,LevelID,LevelIDTitle,Money,PayID,PayName,Info,Content1,IsLookUser,IsProcess,WithdrawImage,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_FreeBrokerRefund ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_FreeBrokerRefund model=new WebSite.Model.Mod_FreeBrokerRefund();
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
		public WebSite.Model.Mod_FreeBrokerRefund DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_FreeBrokerRefund model=new WebSite.Model.Mod_FreeBrokerRefund();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["FreeBrokerName"]!=null)
				{
					model.FreeBrokerName=row["FreeBrokerName"].ToString();
				}
				if(row["FreeBrokerTel"]!=null)
				{
					model.FreeBrokerTel=row["FreeBrokerTel"].ToString();
				}
				if(row["LevelID"]!=null && row["LevelID"].ToString()!="")
				{
					model.LevelID=int.Parse(row["LevelID"].ToString());
				}
				if(row["LevelIDTitle"]!=null)
				{
					model.LevelIDTitle=row["LevelIDTitle"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["PayID"]!=null && row["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(row["PayID"].ToString());
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["IsLookUser"]!=null && row["IsLookUser"].ToString()!="")
				{
					model.IsLookUser=int.Parse(row["IsLookUser"].ToString());
				}
				if(row["IsProcess"]!=null && row["IsProcess"].ToString()!="")
				{
					model.IsProcess=int.Parse(row["IsProcess"].ToString());
				}
				if(row["WithdrawImage"]!=null)
				{
					model.WithdrawImage=row["WithdrawImage"].ToString();
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
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
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
			strSql.Append("select ID,Model,OrderNo,UserID,FreeBrokerName,FreeBrokerTel,LevelID,LevelIDTitle,Money,PayID,PayName,Info,Content1,IsLookUser,IsProcess,WithdrawImage,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerRefund ");
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
			strSql.Append(" ID,Model,OrderNo,UserID,FreeBrokerName,FreeBrokerTel,LevelID,LevelIDTitle,Money,PayID,PayName,Info,Content1,IsLookUser,IsProcess,WithdrawImage,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerRefund ");
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
			strSql.Append("select count(1) FROM SW_FreeBrokerRefund ");
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
                strSql = "select top " + endIndex + " * from SW_FreeBrokerRefund where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_FreeBrokerRefund where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_FreeBrokerRefund where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_FreeBrokerRefund";
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
        public WebSite.Model.Mod_FreeBrokerRefund GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,FreeBrokerName,FreeBrokerTel,LevelID,LevelIDTitle,Money,PayID,PayName,Info,Content1,IsLookUser,IsProcess,WithdrawImage,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_FreeBrokerRefund ");            
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_FreeBrokerRefund model = new WebSite.Model.Mod_FreeBrokerRefund();
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

