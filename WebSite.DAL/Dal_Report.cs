
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Report
	/// </summary>
	public partial class Dal_Report
	{
		public Dal_Report()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Report"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Report");
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
		public int Add(WebSite.Model.Mod_Report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Report(");
			strSql.Append("Model,ReportInfoID,ReportInfoName,UserID,UserName,UserMobile,ReportUserID,ReportUserName,ReportUserMobile,ReportID,ReportIDs,ReportNames,ReportPlagiarismUrl,ReportNewsUrl,ReContent,ReportRemarks,AddDate,State,IsLook,OrderBy,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@ReportInfoID,@ReportInfoName,@UserID,@UserName,@UserMobile,@ReportUserID,@ReportUserName,@ReportUserMobile,@ReportID,@ReportIDs,@ReportNames,@ReportPlagiarismUrl,@ReportNewsUrl,@ReContent,@ReportRemarks,@AddDate,@State,@IsLook,@OrderBy,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ReportInfoID", SqlDbType.Int,4),
					new SqlParameter("@ReportInfoName", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserMobile", SqlDbType.VarChar,100),
					new SqlParameter("@ReportUserID", SqlDbType.Int,4),
					new SqlParameter("@ReportUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReportUserMobile", SqlDbType.VarChar,100),
					new SqlParameter("@ReportID", SqlDbType.Int,4),
					new SqlParameter("@ReportIDs", SqlDbType.VarChar,200),
					new SqlParameter("@ReportNames", SqlDbType.VarChar,500),
					new SqlParameter("@ReportPlagiarismUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReportNewsUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReContent", SqlDbType.Text),
					new SqlParameter("@ReportRemarks", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ReportInfoID;
			parameters[2].Value = model.ReportInfoName;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.UserMobile;
			parameters[6].Value = model.ReportUserID;
			parameters[7].Value = model.ReportUserName;
			parameters[8].Value = model.ReportUserMobile;
			parameters[9].Value = model.ReportID;
			parameters[10].Value = model.ReportIDs;
			parameters[11].Value = model.ReportNames;
			parameters[12].Value = model.ReportPlagiarismUrl;
			parameters[13].Value = model.ReportNewsUrl;
			parameters[14].Value = model.ReContent;
			parameters[15].Value = model.ReportRemarks;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.State;
			parameters[18].Value = model.IsLook;
			parameters[19].Value = model.OrderBy;
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
		public bool Update(WebSite.Model.Mod_Report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Report set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ReportInfoID=@ReportInfoID,");
			strSql.Append("ReportInfoName=@ReportInfoName,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserMobile=@UserMobile,");
			strSql.Append("ReportUserID=@ReportUserID,");
			strSql.Append("ReportUserName=@ReportUserName,");
			strSql.Append("ReportUserMobile=@ReportUserMobile,");
			strSql.Append("ReportID=@ReportID,");
			strSql.Append("ReportIDs=@ReportIDs,");
			strSql.Append("ReportNames=@ReportNames,");
			strSql.Append("ReportPlagiarismUrl=@ReportPlagiarismUrl,");
			strSql.Append("ReportNewsUrl=@ReportNewsUrl,");
			strSql.Append("ReContent=@ReContent,");
			strSql.Append("ReportRemarks=@ReportRemarks,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("State=@State,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ReportInfoID", SqlDbType.Int,4),
					new SqlParameter("@ReportInfoName", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserMobile", SqlDbType.VarChar,100),
					new SqlParameter("@ReportUserID", SqlDbType.Int,4),
					new SqlParameter("@ReportUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReportUserMobile", SqlDbType.VarChar,100),
					new SqlParameter("@ReportID", SqlDbType.Int,4),
					new SqlParameter("@ReportIDs", SqlDbType.VarChar,200),
					new SqlParameter("@ReportNames", SqlDbType.VarChar,500),
					new SqlParameter("@ReportPlagiarismUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReportNewsUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReContent", SqlDbType.Text),
					new SqlParameter("@ReportRemarks", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ReportInfoID;
			parameters[2].Value = model.ReportInfoName;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.UserMobile;
			parameters[6].Value = model.ReportUserID;
			parameters[7].Value = model.ReportUserName;
			parameters[8].Value = model.ReportUserMobile;
			parameters[9].Value = model.ReportID;
			parameters[10].Value = model.ReportIDs;
			parameters[11].Value = model.ReportNames;
			parameters[12].Value = model.ReportPlagiarismUrl;
			parameters[13].Value = model.ReportNewsUrl;
			parameters[14].Value = model.ReContent;
			parameters[15].Value = model.ReportRemarks;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.State;
			parameters[18].Value = model.IsLook;
			parameters[19].Value = model.OrderBy;
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
			strSql.Append("delete from SW_Report ");
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
			strSql.Append("delete from SW_Report ");
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
		public WebSite.Model.Mod_Report GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,ReportInfoID,ReportInfoName,UserID,UserName,UserMobile,ReportUserID,ReportUserName,ReportUserMobile,ReportID,ReportIDs,ReportNames,ReportPlagiarismUrl,ReportNewsUrl,ReContent,ReportRemarks,AddDate,State,IsLook,OrderBy,WebSiteID from SW_Report ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Report model=new WebSite.Model.Mod_Report();
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
		public WebSite.Model.Mod_Report DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Report model=new WebSite.Model.Mod_Report();
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
				if(row["ReportInfoID"]!=null && row["ReportInfoID"].ToString()!="")
				{
					model.ReportInfoID=int.Parse(row["ReportInfoID"].ToString());
				}
				if(row["ReportInfoName"]!=null)
				{
					model.ReportInfoName=row["ReportInfoName"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["UserMobile"]!=null)
				{
					model.UserMobile=row["UserMobile"].ToString();
				}
				if(row["ReportUserID"]!=null && row["ReportUserID"].ToString()!="")
				{
					model.ReportUserID=int.Parse(row["ReportUserID"].ToString());
				}
				if(row["ReportUserName"]!=null)
				{
					model.ReportUserName=row["ReportUserName"].ToString();
				}
				if(row["ReportUserMobile"]!=null)
				{
					model.ReportUserMobile=row["ReportUserMobile"].ToString();
				}
				if(row["ReportID"]!=null && row["ReportID"].ToString()!="")
				{
					model.ReportID=int.Parse(row["ReportID"].ToString());
				}
				if(row["ReportIDs"]!=null)
				{
					model.ReportIDs=row["ReportIDs"].ToString();
				}
				if(row["ReportNames"]!=null)
				{
					model.ReportNames=row["ReportNames"].ToString();
				}
				if(row["ReportPlagiarismUrl"]!=null)
				{
					model.ReportPlagiarismUrl=row["ReportPlagiarismUrl"].ToString();
				}
				if(row["ReportNewsUrl"]!=null)
				{
					model.ReportNewsUrl=row["ReportNewsUrl"].ToString();
				}
				if(row["ReContent"]!=null)
				{
					model.ReContent=row["ReContent"].ToString();
				}
				if(row["ReportRemarks"]!=null)
				{
					model.ReportRemarks=row["ReportRemarks"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
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
			strSql.Append("select ID,Model,ReportInfoID,ReportInfoName,UserID,UserName,UserMobile,ReportUserID,ReportUserName,ReportUserMobile,ReportID,ReportIDs,ReportNames,ReportPlagiarismUrl,ReportNewsUrl,ReContent,ReportRemarks,AddDate,State,IsLook,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_Report ");
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
			strSql.Append(" ID,Model,ReportInfoID,ReportInfoName,UserID,UserName,UserMobile,ReportUserID,ReportUserName,ReportUserMobile,ReportID,ReportIDs,ReportNames,ReportPlagiarismUrl,ReportNewsUrl,ReContent,ReportRemarks,AddDate,State,IsLook,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_Report ");
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
			strSql.Append("select count(1) FROM SW_Report ");
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
                strSql = "select top " + endIndex + " * from SW_Report where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Report where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Report where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Report";
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

