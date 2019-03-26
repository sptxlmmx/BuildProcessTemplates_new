
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Withdraw
	/// </summary>
	public partial class Dal_Withdraw
	{
		public Dal_Withdraw()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Withdraw"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Withdraw");
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
		public int Add(WebSite.Model.Mod_Withdraw model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Withdraw(");
			strSql.Append("Model,OrderNo,UserID,UserNickName,UserRealName,UserBankID,UserBankName,UserBankNum,WithdrawImage,BankID,Money,GetMoney,AddDate,ProcessDate,WeiXinPaymentNo,WeiXinDeviceIinfo,WithdrawID,Content1,WithdrawCount,OrderBy,IsLook,IsProcess,IsLookUser,State,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@UserID,@UserNickName,@UserRealName,@UserBankID,@UserBankName,@UserBankNum,@WithdrawImage,@BankID,@Money,@GetMoney,@AddDate,@ProcessDate,@WeiXinPaymentNo,@WeiXinDeviceIinfo,@WithdrawID,@Content1,@WithdrawCount,@OrderBy,@IsLook,@IsProcess,@IsLookUser,@State,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserRealName", SqlDbType.VarChar,200),
					new SqlParameter("@UserBankID", SqlDbType.Int,4),
					new SqlParameter("@UserBankName", SqlDbType.VarChar,50),
					new SqlParameter("@UserBankNum", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawImage", SqlDbType.VarChar,500),
					new SqlParameter("@BankID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@GetMoney", SqlDbType.Decimal,9),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ProcessDate", SqlDbType.DateTime),
					new SqlParameter("@WeiXinPaymentNo", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXinDeviceIinfo", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawID", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@WithdrawCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsProcess", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserNickName;
			parameters[4].Value = model.UserRealName;
			parameters[5].Value = model.UserBankID;
			parameters[6].Value = model.UserBankName;
			parameters[7].Value = model.UserBankNum;
			parameters[8].Value = model.WithdrawImage;
			parameters[9].Value = model.BankID;
			parameters[10].Value = model.Money;
			parameters[11].Value = model.GetMoney;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.ProcessDate;
			parameters[14].Value = model.WeiXinPaymentNo;
			parameters[15].Value = model.WeiXinDeviceIinfo;
			parameters[16].Value = model.WithdrawID;
			parameters[17].Value = model.Content1;
			parameters[18].Value = model.WithdrawCount;
			parameters[19].Value = model.OrderBy;
			parameters[20].Value = model.IsLook;
			parameters[21].Value = model.IsProcess;
			parameters[22].Value = model.IsLookUser;
			parameters[23].Value = model.State;
			parameters[24].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Withdraw model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Withdraw set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("UserRealName=@UserRealName,");
			strSql.Append("UserBankID=@UserBankID,");
			strSql.Append("UserBankName=@UserBankName,");
			strSql.Append("UserBankNum=@UserBankNum,");
			strSql.Append("WithdrawImage=@WithdrawImage,");
			strSql.Append("BankID=@BankID,");
			strSql.Append("Money=@Money,");
			strSql.Append("GetMoney=@GetMoney,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ProcessDate=@ProcessDate,");
			strSql.Append("WeiXinPaymentNo=@WeiXinPaymentNo,");
			strSql.Append("WeiXinDeviceIinfo=@WeiXinDeviceIinfo,");
			strSql.Append("WithdrawID=@WithdrawID,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("WithdrawCount=@WithdrawCount,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("IsProcess=@IsProcess,");
			strSql.Append("IsLookUser=@IsLookUser,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserRealName", SqlDbType.VarChar,200),
					new SqlParameter("@UserBankID", SqlDbType.Int,4),
					new SqlParameter("@UserBankName", SqlDbType.VarChar,50),
					new SqlParameter("@UserBankNum", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawImage", SqlDbType.VarChar,500),
					new SqlParameter("@BankID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@GetMoney", SqlDbType.Decimal,9),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ProcessDate", SqlDbType.DateTime),
					new SqlParameter("@WeiXinPaymentNo", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXinDeviceIinfo", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawID", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@WithdrawCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsProcess", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserNickName;
			parameters[4].Value = model.UserRealName;
			parameters[5].Value = model.UserBankID;
			parameters[6].Value = model.UserBankName;
			parameters[7].Value = model.UserBankNum;
			parameters[8].Value = model.WithdrawImage;
			parameters[9].Value = model.BankID;
			parameters[10].Value = model.Money;
			parameters[11].Value = model.GetMoney;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.ProcessDate;
			parameters[14].Value = model.WeiXinPaymentNo;
			parameters[15].Value = model.WeiXinDeviceIinfo;
			parameters[16].Value = model.WithdrawID;
			parameters[17].Value = model.Content1;
			parameters[18].Value = model.WithdrawCount;
			parameters[19].Value = model.OrderBy;
			parameters[20].Value = model.IsLook;
			parameters[21].Value = model.IsProcess;
			parameters[22].Value = model.IsLookUser;
			parameters[23].Value = model.State;
			parameters[24].Value = model.WebSiteID;
			parameters[25].Value = model.ID;

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
			strSql.Append("delete from SW_Withdraw ");
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
			strSql.Append("delete from SW_Withdraw ");
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
		public WebSite.Model.Mod_Withdraw GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserNickName,UserRealName,UserBankID,UserBankName,UserBankNum,WithdrawImage,BankID,Money,GetMoney,AddDate,ProcessDate,WeiXinPaymentNo,WeiXinDeviceIinfo,WithdrawID,Content1,WithdrawCount,OrderBy,IsLook,IsProcess,IsLookUser,State,WebSiteID from SW_Withdraw ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Withdraw model=new WebSite.Model.Mod_Withdraw();
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
		public WebSite.Model.Mod_Withdraw DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Withdraw model=new WebSite.Model.Mod_Withdraw();
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
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["UserRealName"]!=null)
				{
					model.UserRealName=row["UserRealName"].ToString();
				}
				if(row["UserBankID"]!=null && row["UserBankID"].ToString()!="")
				{
					model.UserBankID=int.Parse(row["UserBankID"].ToString());
				}
				if(row["UserBankName"]!=null)
				{
					model.UserBankName=row["UserBankName"].ToString();
				}
				if(row["UserBankNum"]!=null)
				{
					model.UserBankNum=row["UserBankNum"].ToString();
				}
				if(row["WithdrawImage"]!=null)
				{
					model.WithdrawImage=row["WithdrawImage"].ToString();
				}
				if(row["BankID"]!=null && row["BankID"].ToString()!="")
				{
					model.BankID=int.Parse(row["BankID"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["GetMoney"]!=null && row["GetMoney"].ToString()!="")
				{
					model.GetMoney=decimal.Parse(row["GetMoney"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ProcessDate"]!=null && row["ProcessDate"].ToString()!="")
				{
					model.ProcessDate=DateTime.Parse(row["ProcessDate"].ToString());
				}
				if(row["WeiXinPaymentNo"]!=null)
				{
					model.WeiXinPaymentNo=row["WeiXinPaymentNo"].ToString();
				}
				if(row["WeiXinDeviceIinfo"]!=null)
				{
					model.WeiXinDeviceIinfo=row["WeiXinDeviceIinfo"].ToString();
				}
				if(row["WithdrawID"]!=null && row["WithdrawID"].ToString()!="")
				{
					model.WithdrawID=int.Parse(row["WithdrawID"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["WithdrawCount"]!=null && row["WithdrawCount"].ToString()!="")
				{
					model.WithdrawCount=int.Parse(row["WithdrawCount"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["IsProcess"]!=null && row["IsProcess"].ToString()!="")
				{
					model.IsProcess=int.Parse(row["IsProcess"].ToString());
				}
				if(row["IsLookUser"]!=null && row["IsLookUser"].ToString()!="")
				{
					model.IsLookUser=int.Parse(row["IsLookUser"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select ID,Model,OrderNo,UserID,UserNickName,UserRealName,UserBankID,UserBankName,UserBankNum,WithdrawImage,BankID,Money,GetMoney,AddDate,ProcessDate,WeiXinPaymentNo,WeiXinDeviceIinfo,WithdrawID,Content1,WithdrawCount,OrderBy,IsLook,IsProcess,IsLookUser,State,WebSiteID ");
			strSql.Append(" FROM SW_Withdraw ");
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
			strSql.Append(" ID,Model,OrderNo,UserID,UserNickName,UserRealName,UserBankID,UserBankName,UserBankNum,WithdrawImage,BankID,Money,GetMoney,AddDate,ProcessDate,WeiXinPaymentNo,WeiXinDeviceIinfo,WithdrawID,Content1,WithdrawCount,OrderBy,IsLook,IsProcess,IsLookUser,State,WebSiteID ");
			strSql.Append(" FROM SW_Withdraw ");
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
			strSql.Append("select count(1) FROM SW_Withdraw ");
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
                strSql = "select top " + endIndex + " * from SW_Withdraw where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Withdraw where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Withdraw where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Withdraw";
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

