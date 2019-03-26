using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Spec
	/// </summary>
	public partial class Dal_Spec
	{
		public Dal_Spec()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Spec"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Spec");
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
		public int Add(WebSite.Model.Mod_Spec model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Spec(");
			strSql.Append("SpecName,Alias,DisplayType,DisplayMode,Note,OrderBy,State,WebSiteID,UserID)");
			strSql.Append(" values (");
            strSql.Append("@SpecName,@Alias,@DisplayType,@DisplayMode,@Note,@OrderBy,@State,@WebSiteID,@UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SpecName", SqlDbType.VarChar,200),
					new SqlParameter("@Alias", SqlDbType.VarChar,200),
					new SqlParameter("@DisplayType", SqlDbType.Int,4),
					new SqlParameter("@DisplayMode", SqlDbType.Int,4),
					new SqlParameter("@Note", SqlDbType.VarChar,500),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
                    new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.SpecName;
			parameters[1].Value = model.Alias;
			parameters[2].Value = model.DisplayType;
			parameters[3].Value = model.DisplayMode;
			parameters[4].Value = model.Note;
			parameters[5].Value = model.OrderBy;
			parameters[6].Value = model.State;
			parameters[7].Value = model.WebSiteID;
            parameters[8].Value = model.UserID;

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
		public bool Update(WebSite.Model.Mod_Spec model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Spec set ");
			strSql.Append("SpecName=@SpecName,");
			strSql.Append("Alias=@Alias,");
			strSql.Append("DisplayType=@DisplayType,");
			strSql.Append("DisplayMode=@DisplayMode,");
			strSql.Append("Note=@Note,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("UserID=@UserID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SpecName", SqlDbType.VarChar,200),
					new SqlParameter("@Alias", SqlDbType.VarChar,200),
					new SqlParameter("@DisplayType", SqlDbType.Int,4),
					new SqlParameter("@DisplayMode", SqlDbType.Int,4),
					new SqlParameter("@Note", SqlDbType.VarChar,500),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
                    new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.SpecName;
			parameters[1].Value = model.Alias;
			parameters[2].Value = model.DisplayType;
			parameters[3].Value = model.DisplayMode;
			parameters[4].Value = model.Note;
			parameters[5].Value = model.OrderBy;
			parameters[6].Value = model.State;
			parameters[7].Value = model.WebSiteID;
            parameters[8].Value = model.UserID;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from SW_Spec ");
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
			strSql.Append("delete from SW_Spec ");
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
		public WebSite.Model.Mod_Spec GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,SpecName,Alias,DisplayType,DisplayMode,Note,OrderBy,State,WebSiteID,UserID from SW_Spec ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Spec model=new WebSite.Model.Mod_Spec();
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
		public WebSite.Model.Mod_Spec DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Spec model=new WebSite.Model.Mod_Spec();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["SpecName"]!=null)
				{
					model.SpecName=row["SpecName"].ToString();
				}
				if(row["Alias"]!=null)
				{
					model.Alias=row["Alias"].ToString();
				}
				if(row["DisplayType"]!=null && row["DisplayType"].ToString()!="")
				{
					model.DisplayType=int.Parse(row["DisplayType"].ToString());
				}
				if(row["DisplayMode"]!=null && row["DisplayMode"].ToString()!="")
				{
					model.DisplayMode=int.Parse(row["DisplayMode"].ToString());
				}
				if(row["Note"]!=null)
				{
					model.Note=row["Note"].ToString();
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
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
            strSql.Append("select ID,SpecName,Alias,DisplayType,DisplayMode,Note,OrderBy,State,WebSiteID,UserID ");
			strSql.Append(" FROM SW_Spec ");
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
            strSql.Append(" ID,SpecName,Alias,DisplayType,DisplayMode,Note,OrderBy,State,WebSiteID,UserID ");
			strSql.Append(" FROM SW_Spec ");
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
			strSql.Append("select count(1) FROM SW_Spec ");
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
                strSql = "select top " + endIndex + " * from SW_Spec where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Spec where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Spec where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Spec";
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

