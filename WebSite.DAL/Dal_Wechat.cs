
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Wechat
	/// </summary>
	public partial class Dal_Wechat
	{
		public Dal_Wechat()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Wechat"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Wechat");
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
		public int Add(WebSite.Model.Mod_Wechat model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Wechat(");
			strSql.Append("Wechat_name,Wechat_key,Wechat_url,Wechat_token,Wechat_appid,Wechat_appsecret,Wechat_originalid,Content1,AddDate,State,UserID,Wechat_type,Wechat_typename,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Wechat_name,@Wechat_key,@Wechat_url,@Wechat_token,@Wechat_appid,@Wechat_appsecret,@Wechat_originalid,@Content1,@AddDate,@State,@UserID,@Wechat_type,@Wechat_typename,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Wechat_name", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_key", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_url", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_token", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_appid", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_appsecret", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_originalid", SqlDbType.VarChar,250),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Wechat_type", SqlDbType.Int,4),
					new SqlParameter("@Wechat_typename", SqlDbType.VarChar,250),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Wechat_name;
			parameters[1].Value = model.Wechat_key;
			parameters[2].Value = model.Wechat_url;
			parameters[3].Value = model.Wechat_token;
			parameters[4].Value = model.Wechat_appid;
			parameters[5].Value = model.Wechat_appsecret;
			parameters[6].Value = model.Wechat_originalid;
			parameters[7].Value = model.Content1;
			parameters[8].Value = model.AddDate;
			parameters[9].Value = model.State;
			parameters[10].Value = model.UserID;
			parameters[11].Value = model.Wechat_type;
			parameters[12].Value = model.Wechat_typename;
			parameters[13].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Wechat model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Wechat set ");
			strSql.Append("Wechat_name=@Wechat_name,");
			strSql.Append("Wechat_key=@Wechat_key,");
			strSql.Append("Wechat_url=@Wechat_url,");
			strSql.Append("Wechat_token=@Wechat_token,");
			strSql.Append("Wechat_appid=@Wechat_appid,");
			strSql.Append("Wechat_appsecret=@Wechat_appsecret,");
			strSql.Append("Wechat_originalid=@Wechat_originalid,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("State=@State,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("Wechat_type=@Wechat_type,");
			strSql.Append("Wechat_typename=@Wechat_typename,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Wechat_name", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_key", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_url", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_token", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_appid", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_appsecret", SqlDbType.VarChar,250),
					new SqlParameter("@Wechat_originalid", SqlDbType.VarChar,250),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Wechat_type", SqlDbType.Int,4),
					new SqlParameter("@Wechat_typename", SqlDbType.VarChar,250),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Wechat_name;
			parameters[1].Value = model.Wechat_key;
			parameters[2].Value = model.Wechat_url;
			parameters[3].Value = model.Wechat_token;
			parameters[4].Value = model.Wechat_appid;
			parameters[5].Value = model.Wechat_appsecret;
			parameters[6].Value = model.Wechat_originalid;
			parameters[7].Value = model.Content1;
			parameters[8].Value = model.AddDate;
			parameters[9].Value = model.State;
			parameters[10].Value = model.UserID;
			parameters[11].Value = model.Wechat_type;
			parameters[12].Value = model.Wechat_typename;
			parameters[13].Value = model.WebSiteID;
			parameters[14].Value = model.ID;

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
			strSql.Append("delete from SW_Wechat ");
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
			strSql.Append("delete from SW_Wechat ");
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
		public WebSite.Model.Mod_Wechat GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Wechat_name,Wechat_key,Wechat_url,Wechat_token,Wechat_appid,Wechat_appsecret,Wechat_originalid,Content1,AddDate,State,UserID,Wechat_type,Wechat_typename,WebSiteID from SW_Wechat ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Wechat model=new WebSite.Model.Mod_Wechat();
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
		public WebSite.Model.Mod_Wechat DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Wechat model=new WebSite.Model.Mod_Wechat();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Wechat_name"]!=null)
				{
					model.Wechat_name=row["Wechat_name"].ToString();
				}
				if(row["Wechat_key"]!=null)
				{
					model.Wechat_key=row["Wechat_key"].ToString();
				}
				if(row["Wechat_url"]!=null)
				{
					model.Wechat_url=row["Wechat_url"].ToString();
				}
				if(row["Wechat_token"]!=null)
				{
					model.Wechat_token=row["Wechat_token"].ToString();
				}
				if(row["Wechat_appid"]!=null)
				{
					model.Wechat_appid=row["Wechat_appid"].ToString();
				}
				if(row["Wechat_appsecret"]!=null)
				{
					model.Wechat_appsecret=row["Wechat_appsecret"].ToString();
				}
				if(row["Wechat_originalid"]!=null)
				{
					model.Wechat_originalid=row["Wechat_originalid"].ToString();
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["Wechat_type"]!=null && row["Wechat_type"].ToString()!="")
				{
					model.Wechat_type=int.Parse(row["Wechat_type"].ToString());
				}
				if(row["Wechat_typename"]!=null)
				{
					model.Wechat_typename=row["Wechat_typename"].ToString();
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
			strSql.Append("select ID,Wechat_name,Wechat_key,Wechat_url,Wechat_token,Wechat_appid,Wechat_appsecret,Wechat_originalid,Content1,AddDate,State,UserID,Wechat_type,Wechat_typename,WebSiteID ");
			strSql.Append(" FROM SW_Wechat ");
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
			strSql.Append(" ID,Wechat_name,Wechat_key,Wechat_url,Wechat_token,Wechat_appid,Wechat_appsecret,Wechat_originalid,Content1,AddDate,State,UserID,Wechat_type,Wechat_typename,WebSiteID ");
			strSql.Append(" FROM SW_Wechat ");
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
			strSql.Append("select count(1) FROM SW_Wechat ");
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
                strSql = "select top " + endIndex + " * from SW_Wechat where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Wechat where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Wechat where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Wechat";
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

