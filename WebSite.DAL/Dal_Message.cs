using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Message
	/// </summary>
	public partial class Dal_Message
	{
		public Dal_Message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Message");
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
		public int Add(WebSite.Model.Mod_Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Message(");
			strSql.Append("Model,Title,Content,Content2,TypeID,ParentID,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,FromID,FromName,IsFromLook,ToID,ToName,IsToLook,IsTop,OrderBy)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Title,@Content,@Content2,@TypeID,@ParentID,@UserID,@UserName,@Name,@Sex,@Email,@Tel,@Company,@Zip,@Address,@AddDate,@WebSiteID,@State,@ReplyContent,@ReplyDate,@IsLook,@FromID,@FromName,@IsFromLook,@ToID,@ToName,@IsToLook,@IsTop,@OrderBy)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Char,10),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@Zip", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ReplyContent", SqlDbType.Text),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@FromID", SqlDbType.Int,4),
					new SqlParameter("@FromName", SqlDbType.VarChar,200),
					new SqlParameter("@IsFromLook", SqlDbType.Int,4),
					new SqlParameter("@ToID", SqlDbType.Int,4),
					new SqlParameter("@ToName", SqlDbType.VarChar,200),
					new SqlParameter("@IsToLook", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Content2;
			parameters[4].Value = model.TypeID;
			parameters[5].Value = model.ParentID;
			parameters[6].Value = model.UserID;
			parameters[7].Value = model.UserName;
			parameters[8].Value = model.Name;
			parameters[9].Value = model.Sex;
			parameters[10].Value = model.Email;
			parameters[11].Value = model.Tel;
			parameters[12].Value = model.Company;
			parameters[13].Value = model.Zip;
			parameters[14].Value = model.Address;
			parameters[15].Value = model.AddDate;
			parameters[16].Value = model.WebSiteID;
			parameters[17].Value = model.State;
			parameters[18].Value = model.ReplyContent;
			parameters[19].Value = model.ReplyDate;
			parameters[20].Value = model.IsLook;
			parameters[21].Value = model.FromID;
			parameters[22].Value = model.FromName;
			parameters[23].Value = model.IsFromLook;
			parameters[24].Value = model.ToID;
			parameters[25].Value = model.ToName;
			parameters[26].Value = model.IsToLook;
			parameters[27].Value = model.IsTop;
			parameters[28].Value = model.OrderBy;

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
		public bool Update(WebSite.Model.Mod_Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Message set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Title=@Title,");
			strSql.Append("Content=@Content,");
			strSql.Append("Content2=@Content2,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Email=@Email,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Company=@Company,");
			strSql.Append("Zip=@Zip,");
			strSql.Append("Address=@Address,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("State=@State,");
			strSql.Append("ReplyContent=@ReplyContent,");
			strSql.Append("ReplyDate=@ReplyDate,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("FromID=@FromID,");
			strSql.Append("FromName=@FromName,");
			strSql.Append("IsFromLook=@IsFromLook,");
			strSql.Append("ToID=@ToID,");
			strSql.Append("ToName=@ToName,");
			strSql.Append("IsToLook=@IsToLook,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("OrderBy=@OrderBy");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Char,10),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@Zip", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ReplyContent", SqlDbType.Text),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@FromID", SqlDbType.Int,4),
					new SqlParameter("@FromName", SqlDbType.VarChar,200),
					new SqlParameter("@IsFromLook", SqlDbType.Int,4),
					new SqlParameter("@ToID", SqlDbType.Int,4),
					new SqlParameter("@ToName", SqlDbType.VarChar,200),
					new SqlParameter("@IsToLook", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Content2;
			parameters[4].Value = model.TypeID;
			parameters[5].Value = model.ParentID;
			parameters[6].Value = model.UserID;
			parameters[7].Value = model.UserName;
			parameters[8].Value = model.Name;
			parameters[9].Value = model.Sex;
			parameters[10].Value = model.Email;
			parameters[11].Value = model.Tel;
			parameters[12].Value = model.Company;
			parameters[13].Value = model.Zip;
			parameters[14].Value = model.Address;
			parameters[15].Value = model.AddDate;
			parameters[16].Value = model.WebSiteID;
			parameters[17].Value = model.State;
			parameters[18].Value = model.ReplyContent;
			parameters[19].Value = model.ReplyDate;
			parameters[20].Value = model.IsLook;
			parameters[21].Value = model.FromID;
			parameters[22].Value = model.FromName;
			parameters[23].Value = model.IsFromLook;
			parameters[24].Value = model.ToID;
			parameters[25].Value = model.ToName;
			parameters[26].Value = model.IsToLook;
			parameters[27].Value = model.IsTop;
			parameters[28].Value = model.OrderBy;
			parameters[29].Value = model.ID;

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
			strSql.Append("delete from SW_Message ");
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
			strSql.Append("delete from SW_Message ");
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
		public WebSite.Model.Mod_Message GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Title,Content,Content2,TypeID,ParentID,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,FromID,FromName,IsFromLook,ToID,ToName,IsToLook,IsTop,OrderBy from SW_Message ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Message model=new WebSite.Model.Mod_Message();
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
		public WebSite.Model.Mod_Message DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Message model=new WebSite.Model.Mod_Message();
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
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["Content2"]!=null)
				{
					model.Content2=row["Content2"].ToString();
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["Zip"]!=null)
				{
					model.Zip=row["Zip"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["ReplyContent"]!=null)
				{
					model.ReplyContent=row["ReplyContent"].ToString();
				}
				if(row["ReplyDate"]!=null && row["ReplyDate"].ToString()!="")
				{
					model.ReplyDate=DateTime.Parse(row["ReplyDate"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["FromID"]!=null && row["FromID"].ToString()!="")
				{
					model.FromID=int.Parse(row["FromID"].ToString());
				}
				if(row["FromName"]!=null)
				{
					model.FromName=row["FromName"].ToString();
				}
				if(row["IsFromLook"]!=null && row["IsFromLook"].ToString()!="")
				{
					model.IsFromLook=int.Parse(row["IsFromLook"].ToString());
				}
				if(row["ToID"]!=null && row["ToID"].ToString()!="")
				{
					model.ToID=int.Parse(row["ToID"].ToString());
				}
				if(row["ToName"]!=null)
				{
					model.ToName=row["ToName"].ToString();
				}
				if(row["IsToLook"]!=null && row["IsToLook"].ToString()!="")
				{
					model.IsToLook=int.Parse(row["IsToLook"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
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
			strSql.Append("select ID,Model,Title,Content,Content2,TypeID,ParentID,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,FromID,FromName,IsFromLook,ToID,ToName,IsToLook,IsTop,OrderBy ");
			strSql.Append(" FROM SW_Message ");
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
			strSql.Append(" ID,Model,Title,Content,Content2,TypeID,ParentID,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,FromID,FromName,IsFromLook,ToID,ToName,IsToLook,IsTop,OrderBy ");
			strSql.Append(" FROM SW_Message ");
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
			strSql.Append("select count(1) FROM SW_Message ");
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
                strSql = "select top " + endIndex + " * from SW_Message where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Message where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Message where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Message";
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsEmail(string Email)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Message");
            strSql.Append(" where Email=@Email");
            SqlParameter[] parameters = {
					new SqlParameter("@Email", SqlDbType.VarChar,200)
			};
            parameters[0].Value = Email;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获取下一篇
        /// </summary>
        /// <param name="ModelInfo"></param>
        /// <returns></returns>
        public WebSite.Model.Mod_Message GetNextInfo(WebSite.Model.Mod_Message ModelInfo)
        {
            //按时间来
            //string strSql = "Select top 1 * from SW_Information WHERE AddDate>'" + ModelInfo.AddDate + "' and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " order by AddDate ASC";
            //按ID来
            string strSql = "Select top 1 * from SW_Message WHERE ID>" + ModelInfo.ID + " and ID!=" + ModelInfo.ID + "  And Model='" + ModelInfo.Model + "' order by ID ASC";

            WebSite.Model.Mod_Message model = new WebSite.Model.Mod_Message();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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
        /// 获取上一篇
        /// </summary>
        /// <param name="ModelInfo"></param>
        /// <returns></returns>
        public WebSite.Model.Mod_Message GetLastInfo(WebSite.Model.Mod_Message ModelInfo)
        {
            //按时间来
            //string strSql = "Select top 1 * from SW_Information WHERE AddDate<'" + ModelInfo.AddDate + "' and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " order by AddDate DESC";
            //按ID来
            string strSql = "Select top 1 * from SW_Message WHERE ID<" + ModelInfo.ID + " and ID!=" + ModelInfo.ID + "  And Model='" + ModelInfo.Model + "' order by ID DESC";

            WebSite.Model.Mod_Message model = new WebSite.Model.Mod_Message();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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

