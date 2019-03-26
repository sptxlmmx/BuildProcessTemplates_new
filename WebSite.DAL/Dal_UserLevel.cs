
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserLevel
	/// </summary>
	public partial class Dal_UserLevel
	{
		public Dal_UserLevel()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserLevel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserLevel");
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
		public int Add(WebSite.Model.Mod_UserLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserLevel(");
			strSql.Append("UserLevelName,UserLeveNicelName,STypeIDs,STypeNames,Image,LevelClass,Model,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@UserLevelName,@UserLeveNicelName,@STypeIDs,@STypeNames,@Image,@LevelClass,@Model,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,50),
					new SqlParameter("@UserLeveNicelName", SqlDbType.VarChar,50),
					new SqlParameter("@STypeIDs", SqlDbType.VarChar,200),
					new SqlParameter("@STypeNames", SqlDbType.VarChar,500),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@LevelClass", SqlDbType.VarChar,50),
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserLevelName;
			parameters[1].Value = model.UserLeveNicelName;
			parameters[2].Value = model.STypeIDs;
			parameters[3].Value = model.STypeNames;
			parameters[4].Value = model.Image;
			parameters[5].Value = model.LevelClass;
			parameters[6].Value = model.Model;
			parameters[7].Value = model.State;
			parameters[8].Value = model.OrderBy;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_UserLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserLevel set ");
			strSql.Append("UserLevelName=@UserLevelName,");
			strSql.Append("UserLeveNicelName=@UserLeveNicelName,");
			strSql.Append("STypeIDs=@STypeIDs,");
			strSql.Append("STypeNames=@STypeNames,");
			strSql.Append("Image=@Image,");
			strSql.Append("LevelClass=@LevelClass,");
			strSql.Append("Model=@Model,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,50),
					new SqlParameter("@UserLeveNicelName", SqlDbType.VarChar,50),
					new SqlParameter("@STypeIDs", SqlDbType.VarChar,200),
					new SqlParameter("@STypeNames", SqlDbType.VarChar,500),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@LevelClass", SqlDbType.VarChar,50),
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserLevelName;
			parameters[1].Value = model.UserLeveNicelName;
			parameters[2].Value = model.STypeIDs;
			parameters[3].Value = model.STypeNames;
			parameters[4].Value = model.Image;
			parameters[5].Value = model.LevelClass;
			parameters[6].Value = model.Model;
			parameters[7].Value = model.State;
			parameters[8].Value = model.OrderBy;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.WebSiteID;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from SW_UserLevel ");
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
			strSql.Append("delete from SW_UserLevel ");
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
		public WebSite.Model.Mod_UserLevel GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserLevelName,UserLeveNicelName,STypeIDs,STypeNames,Image,LevelClass,Model,State,OrderBy,AddDate,WebSiteID from SW_UserLevel ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserLevel model=new WebSite.Model.Mod_UserLevel();
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
		public WebSite.Model.Mod_UserLevel DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserLevel model=new WebSite.Model.Mod_UserLevel();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UserLevelName"]!=null)
				{
					model.UserLevelName=row["UserLevelName"].ToString();
				}
				if(row["UserLeveNicelName"]!=null)
				{
					model.UserLeveNicelName=row["UserLeveNicelName"].ToString();
				}
				if(row["STypeIDs"]!=null)
				{
					model.STypeIDs=row["STypeIDs"].ToString();
				}
				if(row["STypeNames"]!=null)
				{
					model.STypeNames=row["STypeNames"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["LevelClass"]!=null)
				{
					model.LevelClass=row["LevelClass"].ToString();
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
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
			strSql.Append("select ID,UserLevelName,UserLeveNicelName,STypeIDs,STypeNames,Image,LevelClass,Model,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_UserLevel ");
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
			strSql.Append(" ID,UserLevelName,UserLeveNicelName,STypeIDs,STypeNames,Image,LevelClass,Model,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_UserLevel ");
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
			strSql.Append("select count(1) FROM SW_UserLevel ");
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
                strSql = "select top " + endIndex + " * from SW_UserLevel where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserLevel where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserLevel where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserLevel";
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListALL(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select (select COUNT(*) from SW_User where WebSiteID=10001 and State=1 and AuditState=1 and AuthenticationID=sw_UserLevel.ID) as counts, * ");
            strSql.Append(" FROM SW_UserLevel ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

