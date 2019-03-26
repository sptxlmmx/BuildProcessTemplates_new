
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_RedEnvelopesDetails
	/// </summary>
	public partial class Dal_RedEnvelopesDetails
	{
		public Dal_RedEnvelopesDetails()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_RedEnvelopesDetails"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_RedEnvelopesDetails");
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
		public int Add(WebSite.Model.Mod_RedEnvelopesDetails model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_RedEnvelopesDetails(");
			strSql.Append("Model,TypeID,TypeName,UserID,NickName,BUserID,BNickName,Newsid,OrderNo,Money,PayID,PayName,Info,IsBIg,Content1,AddDate,OrderBy,MoneyState,IsLookUser,State,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@TypeID,@TypeName,@UserID,@NickName,@BUserID,@BNickName,@Newsid,@OrderNo,@Money,@PayID,@PayName,@Info,@IsBIg,@Content1,@AddDate,@OrderBy,@MoneyState,@IsLookUser,@State,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BNickName", SqlDbType.VarChar,200),
					new SqlParameter("@Newsid", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@Info", SqlDbType.VarChar,2000),
					new SqlParameter("@IsBIg", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@MoneyState", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.TypeName;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.NickName;
			parameters[5].Value = model.BUserID;
			parameters[6].Value = model.BNickName;
			parameters[7].Value = model.Newsid;
			parameters[8].Value = model.OrderNo;
			parameters[9].Value = model.Money;
			parameters[10].Value = model.PayID;
			parameters[11].Value = model.PayName;
			parameters[12].Value = model.Info;
			parameters[13].Value = model.IsBIg;
			parameters[14].Value = model.Content1;
			parameters[15].Value = model.AddDate;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.MoneyState;
			parameters[18].Value = model.IsLookUser;
			parameters[19].Value = model.State;
			parameters[20].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_RedEnvelopesDetails model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_RedEnvelopesDetails set ");
			strSql.Append("Model=@Model,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("NickName=@NickName,");
			strSql.Append("BUserID=@BUserID,");
			strSql.Append("BNickName=@BNickName,");
			strSql.Append("Newsid=@Newsid,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("Money=@Money,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("Info=@Info,");
			strSql.Append("IsBIg=@IsBIg,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("MoneyState=@MoneyState,");
			strSql.Append("IsLookUser=@IsLookUser,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BNickName", SqlDbType.VarChar,200),
					new SqlParameter("@Newsid", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@Info", SqlDbType.VarChar,2000),
					new SqlParameter("@IsBIg", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@MoneyState", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.TypeName;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.NickName;
			parameters[5].Value = model.BUserID;
			parameters[6].Value = model.BNickName;
			parameters[7].Value = model.Newsid;
			parameters[8].Value = model.OrderNo;
			parameters[9].Value = model.Money;
			parameters[10].Value = model.PayID;
			parameters[11].Value = model.PayName;
			parameters[12].Value = model.Info;
			parameters[13].Value = model.IsBIg;
			parameters[14].Value = model.Content1;
			parameters[15].Value = model.AddDate;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.MoneyState;
			parameters[18].Value = model.IsLookUser;
			parameters[19].Value = model.State;
			parameters[20].Value = model.WebSiteID;
			parameters[21].Value = model.ID;

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
			strSql.Append("delete from SW_RedEnvelopesDetails ");
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
			strSql.Append("delete from SW_RedEnvelopesDetails ");
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
		public WebSite.Model.Mod_RedEnvelopesDetails GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,TypeID,TypeName,UserID,NickName,BUserID,BNickName,Newsid,OrderNo,Money,PayID,PayName,Info,IsBIg,Content1,AddDate,OrderBy,MoneyState,IsLookUser,State,WebSiteID from SW_RedEnvelopesDetails ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_RedEnvelopesDetails model=new WebSite.Model.Mod_RedEnvelopesDetails();
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
		public WebSite.Model.Mod_RedEnvelopesDetails DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_RedEnvelopesDetails model=new WebSite.Model.Mod_RedEnvelopesDetails();
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
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["NickName"]!=null)
				{
					model.NickName=row["NickName"].ToString();
				}
				if(row["BUserID"]!=null && row["BUserID"].ToString()!="")
				{
					model.BUserID=int.Parse(row["BUserID"].ToString());
				}
				if(row["BNickName"]!=null)
				{
					model.BNickName=row["BNickName"].ToString();
				}
				if(row["Newsid"]!=null && row["Newsid"].ToString()!="")
				{
					model.Newsid=int.Parse(row["Newsid"].ToString());
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
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["IsBIg"]!=null && row["IsBIg"].ToString()!="")
				{
					model.IsBIg=int.Parse(row["IsBIg"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["MoneyState"]!=null && row["MoneyState"].ToString()!="")
				{
					model.MoneyState=int.Parse(row["MoneyState"].ToString());
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
			strSql.Append("select ID,Model,TypeID,TypeName,UserID,NickName,BUserID,BNickName,Newsid,OrderNo,Money,PayID,PayName,Info,IsBIg,Content1,AddDate,OrderBy,MoneyState,IsLookUser,State,WebSiteID ");
			strSql.Append(" FROM SW_RedEnvelopesDetails ");
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
			strSql.Append(" ID,Model,TypeID,TypeName,UserID,NickName,BUserID,BNickName,Newsid,OrderNo,Money,PayID,PayName,Info,IsBIg,Content1,AddDate,OrderBy,MoneyState,IsLookUser,State,WebSiteID ");
			strSql.Append(" FROM SW_RedEnvelopesDetails ");
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
			strSql.Append("select count(1) FROM SW_RedEnvelopesDetails ");
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
                strSql = "select top " + endIndex + " * from SW_RedEnvelopesDetails where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_RedEnvelopesDetails where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_RedEnvelopesDetails where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_RedEnvelopesDetails";
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

