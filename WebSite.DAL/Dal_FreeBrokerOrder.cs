
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_FreeBrokerOrder
	/// </summary>
	public partial class Dal_FreeBrokerOrder
	{
		public Dal_FreeBrokerOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_FreeBrokerOrder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_FreeBrokerOrder");
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
		public int Add(WebSite.Model.Mod_FreeBrokerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_FreeBrokerOrder(");
			strSql.Append("Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@UserNickName,@LevelActionID,@LevelActionName,@OrderNo,@Money,@PayID,@PayName,@IsPay,@PayDate,@PayNo,@PayAmount,@IsLook,@IsLookUser,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,50),
					new SqlParameter("@LevelActionID", SqlDbType.Int,4),
					new SqlParameter("@LevelActionName", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.UserNickName;
			parameters[3].Value = model.LevelActionID;
			parameters[4].Value = model.LevelActionName;
			parameters[5].Value = model.OrderNo;
			parameters[6].Value = model.Money;
			parameters[7].Value = model.PayID;
			parameters[8].Value = model.PayName;
			parameters[9].Value = model.IsPay;
			parameters[10].Value = model.PayDate;
			parameters[11].Value = model.PayNo;
			parameters[12].Value = model.PayAmount;
			parameters[13].Value = model.IsLook;
			parameters[14].Value = model.IsLookUser;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_FreeBrokerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_FreeBrokerOrder set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("LevelActionID=@LevelActionID,");
			strSql.Append("LevelActionName=@LevelActionName,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("Money=@Money,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("IsLookUser=@IsLookUser,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,50),
					new SqlParameter("@LevelActionID", SqlDbType.Int,4),
					new SqlParameter("@LevelActionName", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.UserNickName;
			parameters[3].Value = model.LevelActionID;
			parameters[4].Value = model.LevelActionName;
			parameters[5].Value = model.OrderNo;
			parameters[6].Value = model.Money;
			parameters[7].Value = model.PayID;
			parameters[8].Value = model.PayName;
			parameters[9].Value = model.IsPay;
			parameters[10].Value = model.PayDate;
			parameters[11].Value = model.PayNo;
			parameters[12].Value = model.PayAmount;
			parameters[13].Value = model.IsLook;
			parameters[14].Value = model.IsLookUser;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.WebSiteID;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from SW_FreeBrokerOrder ");
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
			strSql.Append("delete from SW_FreeBrokerOrder ");
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
		public WebSite.Model.Mod_FreeBrokerOrder GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_FreeBrokerOrder ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_FreeBrokerOrder model=new WebSite.Model.Mod_FreeBrokerOrder();
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
		public WebSite.Model.Mod_FreeBrokerOrder DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_FreeBrokerOrder model=new WebSite.Model.Mod_FreeBrokerOrder();
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
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["LevelActionID"]!=null && row["LevelActionID"].ToString()!="")
				{
					model.LevelActionID=int.Parse(row["LevelActionID"].ToString());
				}
				if(row["LevelActionName"]!=null)
				{
					model.LevelActionName=row["LevelActionName"].ToString();
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
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
				if(row["IsPay"]!=null && row["IsPay"].ToString()!="")
				{
					model.IsPay=int.Parse(row["IsPay"].ToString());
				}
				if(row["PayDate"]!=null && row["PayDate"].ToString()!="")
				{
					model.PayDate=DateTime.Parse(row["PayDate"].ToString());
				}
				if(row["PayNo"]!=null)
				{
					model.PayNo=row["PayNo"].ToString();
				}
				if(row["PayAmount"]!=null && row["PayAmount"].ToString()!="")
				{
					model.PayAmount=decimal.Parse(row["PayAmount"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["IsLookUser"]!=null && row["IsLookUser"].ToString()!="")
				{
					model.IsLookUser=int.Parse(row["IsLookUser"].ToString());
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
			strSql.Append("select ID,Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerOrder ");
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
			strSql.Append(" ID,Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerOrder ");
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
			strSql.Append("select count(1) FROM SW_FreeBrokerOrder ");
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
                strSql = "select top " + endIndex + " * from SW_FreeBrokerOrder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_FreeBrokerOrder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_FreeBrokerOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_FreeBrokerOrder";
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
        /// 根据订单号得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_FreeBrokerOrder GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_FreeBrokerOrder ");
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_FreeBrokerOrder model = new WebSite.Model.Mod_FreeBrokerOrder();
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
        public WebSite.Model.Mod_FreeBrokerOrder GetModelUserID(int ID,string Model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserNickName,LevelActionID,LevelActionName,OrderNo,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_FreeBrokerOrder ");
            strSql.Append(" where UserID=@ID and Model=@Model and State=1 order by ID desc");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@Model", SqlDbType.VarChar,50),
			};
            parameters[0].Value = ID;
            parameters[1].Value = Model;

            WebSite.Model.Mod_FreeBrokerOrder model = new WebSite.Model.Mod_FreeBrokerOrder();
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

