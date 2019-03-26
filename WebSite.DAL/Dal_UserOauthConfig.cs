
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserOauthConfig
	/// </summary>
	public partial class Dal_UserOauthConfig
	{
		public Dal_UserOauthConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserOauthConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserOauthConfig");
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
		public int Add(WebSite.Model.Mod_UserOauthConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserOauthConfig(");
			strSql.Append("Model,Oauth_Name,Oauth_appid,Oauth_key,Oauth_returnurl,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Oauth_Name,@Oauth_appid,@Oauth_key,@Oauth_returnurl,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Oauth_Name", SqlDbType.VarChar,50),
					new SqlParameter("@Oauth_appid", SqlDbType.VarChar,200),
					new SqlParameter("@Oauth_key", SqlDbType.VarChar,200),
					new SqlParameter("@Oauth_returnurl", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Oauth_Name;
			parameters[2].Value = model.Oauth_appid;
			parameters[3].Value = model.Oauth_key;
			parameters[4].Value = model.Oauth_returnurl;
			parameters[5].Value = model.AddDate;
			parameters[6].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_UserOauthConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserOauthConfig set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Oauth_Name=@Oauth_Name,");
			strSql.Append("Oauth_appid=@Oauth_appid,");
			strSql.Append("Oauth_key=@Oauth_key,");
			strSql.Append("Oauth_returnurl=@Oauth_returnurl,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Oauth_Name", SqlDbType.VarChar,50),
					new SqlParameter("@Oauth_appid", SqlDbType.VarChar,200),
					new SqlParameter("@Oauth_key", SqlDbType.VarChar,200),
					new SqlParameter("@Oauth_returnurl", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Oauth_Name;
			parameters[2].Value = model.Oauth_appid;
			parameters[3].Value = model.Oauth_key;
			parameters[4].Value = model.Oauth_returnurl;
			parameters[5].Value = model.AddDate;
			parameters[6].Value = model.WebSiteID;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from SW_UserOauthConfig ");
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
			strSql.Append("delete from SW_UserOauthConfig ");
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
		public WebSite.Model.Mod_UserOauthConfig GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Oauth_Name,Oauth_appid,Oauth_key,Oauth_returnurl,AddDate,WebSiteID from SW_UserOauthConfig ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserOauthConfig model=new WebSite.Model.Mod_UserOauthConfig();
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
		public WebSite.Model.Mod_UserOauthConfig DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserOauthConfig model=new WebSite.Model.Mod_UserOauthConfig();
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
				if(row["Oauth_Name"]!=null)
				{
					model.Oauth_Name=row["Oauth_Name"].ToString();
				}
				if(row["Oauth_appid"]!=null)
				{
					model.Oauth_appid=row["Oauth_appid"].ToString();
				}
				if(row["Oauth_key"]!=null)
				{
					model.Oauth_key=row["Oauth_key"].ToString();
				}
				if(row["Oauth_returnurl"]!=null)
				{
					model.Oauth_returnurl=row["Oauth_returnurl"].ToString();
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
			strSql.Append("select ID,Model,Oauth_Name,Oauth_appid,Oauth_key,Oauth_returnurl,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_UserOauthConfig ");
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
			strSql.Append(" ID,Model,Oauth_Name,Oauth_appid,Oauth_key,Oauth_returnurl,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_UserOauthConfig ");
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
			strSql.Append("select count(1) FROM SW_UserOauthConfig ");
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
                strSql = "select top " + endIndex + " * from SW_UserOauthConfig where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserOauthConfig where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserOauthConfig where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserOauthConfig";
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
        public WebSite.Model.Mod_UserOauthConfig GetModel(string Oauth_Name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,Oauth_Name,Oauth_appid,Oauth_key,Oauth_returnurl,AddDate,WebSiteID from SW_UserOauthConfig ");
            strSql.Append(" where Oauth_Name=@Oauth_Name");
            SqlParameter[] parameters = {
				new SqlParameter("@Oauth_Name", SqlDbType.VarChar,50),
			};
            parameters[0].Value = Oauth_Name;

            WebSite.Model.Mod_UserOauthConfig model = new WebSite.Model.Mod_UserOauthConfig();
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

