
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Regionalpartner
	/// </summary>
	public partial class Dal_Regionalpartner
	{
		public Dal_Regionalpartner()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Regionalpartner"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Regionalpartner");
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
		public int Add(WebSite.Model.Mod_Regionalpartner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Regionalpartner(");
			strSql.Append("Type,Model,UserName,Password,RealName,Mobile,Email,ParentID,RegionPath,RegionName,RegionGrade,State,AddDate,LoginIP,LoginDate,LoginCount,OrderBy,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Type,@Model,@UserName,@Password,@RealName,@Mobile,@Email,@ParentID,@RegionPath,@RegionName,@RegionGrade,@State,@AddDate,@LoginIP,@LoginDate,@LoginCount,@OrderBy,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,100),
					new SqlParameter("@Password", SqlDbType.VarChar,100),
					new SqlParameter("@RealName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@RegionPath", SqlDbType.VarChar,50),
					new SqlParameter("@RegionName", SqlDbType.VarChar,50),
					new SqlParameter("@RegionGrade", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Type;
			parameters[1].Value = model.Model;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.Password;
			parameters[4].Value = model.RealName;
			parameters[5].Value = model.Mobile;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.ParentID;
			parameters[8].Value = model.RegionPath;
			parameters[9].Value = model.RegionName;
			parameters[10].Value = model.RegionGrade;
			parameters[11].Value = model.State;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.LoginIP;
			parameters[14].Value = model.LoginDate;
			parameters[15].Value = model.LoginCount;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Regionalpartner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Regionalpartner set ");
			strSql.Append("Type=@Type,");
			strSql.Append("Model=@Model,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Password=@Password,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Email=@Email,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("RegionPath=@RegionPath,");
			strSql.Append("RegionName=@RegionName,");
			strSql.Append("RegionGrade=@RegionGrade,");
			strSql.Append("State=@State,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("LoginIP=@LoginIP,");
			strSql.Append("LoginDate=@LoginDate,");
			strSql.Append("LoginCount=@LoginCount,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,100),
					new SqlParameter("@Password", SqlDbType.VarChar,100),
					new SqlParameter("@RealName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@RegionPath", SqlDbType.VarChar,50),
					new SqlParameter("@RegionName", SqlDbType.VarChar,50),
					new SqlParameter("@RegionGrade", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Type;
			parameters[1].Value = model.Model;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.Password;
			parameters[4].Value = model.RealName;
			parameters[5].Value = model.Mobile;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.ParentID;
			parameters[8].Value = model.RegionPath;
			parameters[9].Value = model.RegionName;
			parameters[10].Value = model.RegionGrade;
			parameters[11].Value = model.State;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.LoginIP;
			parameters[14].Value = model.LoginDate;
			parameters[15].Value = model.LoginCount;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.WebSiteID;
			parameters[18].Value = model.ID;

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
			strSql.Append("delete from SW_Regionalpartner ");
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
			strSql.Append("delete from SW_Regionalpartner ");
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
		public WebSite.Model.Mod_Regionalpartner GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Type,Model,UserName,Password,RealName,Mobile,Email,ParentID,RegionPath,RegionName,RegionGrade,State,AddDate,LoginIP,LoginDate,LoginCount,OrderBy,WebSiteID from SW_Regionalpartner ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Regionalpartner model=new WebSite.Model.Mod_Regionalpartner();
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
		public WebSite.Model.Mod_Regionalpartner DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Regionalpartner model=new WebSite.Model.Mod_Regionalpartner();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Type"]!=null && row["Type"].ToString()!="")
				{
					model.Type=int.Parse(row["Type"].ToString());
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["RealName"]!=null)
				{
					model.RealName=row["RealName"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["RegionPath"]!=null)
				{
					model.RegionPath=row["RegionPath"].ToString();
				}
				if(row["RegionName"]!=null)
				{
					model.RegionName=row["RegionName"].ToString();
				}
				if(row["RegionGrade"]!=null && row["RegionGrade"].ToString()!="")
				{
					model.RegionGrade=int.Parse(row["RegionGrade"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["LoginIP"]!=null)
				{
					model.LoginIP=row["LoginIP"].ToString();
				}
				if(row["LoginDate"]!=null && row["LoginDate"].ToString()!="")
				{
					model.LoginDate=DateTime.Parse(row["LoginDate"].ToString());
				}
				if(row["LoginCount"]!=null && row["LoginCount"].ToString()!="")
				{
					model.LoginCount=int.Parse(row["LoginCount"].ToString());
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
			strSql.Append("select ID,Type,Model,UserName,Password,RealName,Mobile,Email,ParentID,RegionPath,RegionName,RegionGrade,State,AddDate,LoginIP,LoginDate,LoginCount,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_Regionalpartner ");
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
			strSql.Append(" ID,Type,Model,UserName,Password,RealName,Mobile,Email,ParentID,RegionPath,RegionName,RegionGrade,State,AddDate,LoginIP,LoginDate,LoginCount,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_Regionalpartner ");
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
			strSql.Append("select count(1) FROM SW_Regionalpartner ");
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
                strSql = "select top " + endIndex + " * from SW_Regionalpartner where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Regionalpartner where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Regionalpartner where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Regionalpartner";
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

