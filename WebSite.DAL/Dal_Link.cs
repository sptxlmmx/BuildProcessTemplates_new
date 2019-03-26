using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Link
	/// </summary>
	public partial class Dal_Link
	{
		public Dal_Link()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Link"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Link");
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
		public int Add(WebSite.Model.Mod_Link model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Link(");
			strSql.Append("Model,Title,Content,Info,Tage,Image,WebUrl,LinkType,TypeID,ProductID,UserID,FileName,FileUrl,FileSize,FileSuffix,WebSiteID,OrderBy,IsPermissions,IsCommend,IsTop,BrowseCount,DownloadCount,AddDate,ModifyDate,State)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Title,@Content,@Info,@Tage,@Image,@WebUrl,@LinkType,@TypeID,@ProductID,@UserID,@FileName,@FileUrl,@FileSize,@FileSuffix,@WebSiteID,@OrderBy,@IsPermissions,@IsCommend,@IsTop,@BrowseCount,@DownloadCount,@AddDate,@ModifyDate,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@Tage", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@LinkType", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,200),
					new SqlParameter("@FileUrl", SqlDbType.VarChar,500),
					new SqlParameter("@FileSize", SqlDbType.VarChar,50),
					new SqlParameter("@FileSuffix", SqlDbType.VarChar,50),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsPermissions", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@DownloadCount", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Info;
			parameters[4].Value = model.Tage;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.WebUrl;
			parameters[7].Value = model.LinkType;
			parameters[8].Value = model.TypeID;
			parameters[9].Value = model.ProductID;
			parameters[10].Value = model.UserID;
			parameters[11].Value = model.FileName;
			parameters[12].Value = model.FileUrl;
			parameters[13].Value = model.FileSize;
			parameters[14].Value = model.FileSuffix;
			parameters[15].Value = model.WebSiteID;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.IsPermissions;
			parameters[18].Value = model.IsCommend;
			parameters[19].Value = model.IsTop;
			parameters[20].Value = model.BrowseCount;
			parameters[21].Value = model.DownloadCount;
			parameters[22].Value = model.AddDate;
			parameters[23].Value = model.ModifyDate;
			parameters[24].Value = model.State;

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
		public bool Update(WebSite.Model.Mod_Link model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Link set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Title=@Title,");
			strSql.Append("Content=@Content,");
			strSql.Append("Info=@Info,");
			strSql.Append("Tage=@Tage,");
			strSql.Append("Image=@Image,");
			strSql.Append("WebUrl=@WebUrl,");
			strSql.Append("LinkType=@LinkType,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("FileUrl=@FileUrl,");
			strSql.Append("FileSize=@FileSize,");
			strSql.Append("FileSuffix=@FileSuffix,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("IsPermissions=@IsPermissions,");
			strSql.Append("IsCommend=@IsCommend,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("DownloadCount=@DownloadCount,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("State=@State");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@Tage", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@LinkType", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,200),
					new SqlParameter("@FileUrl", SqlDbType.VarChar,500),
					new SqlParameter("@FileSize", SqlDbType.VarChar,50),
					new SqlParameter("@FileSuffix", SqlDbType.VarChar,50),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsPermissions", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@DownloadCount", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Info;
			parameters[4].Value = model.Tage;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.WebUrl;
			parameters[7].Value = model.LinkType;
			parameters[8].Value = model.TypeID;
			parameters[9].Value = model.ProductID;
			parameters[10].Value = model.UserID;
			parameters[11].Value = model.FileName;
			parameters[12].Value = model.FileUrl;
			parameters[13].Value = model.FileSize;
			parameters[14].Value = model.FileSuffix;
			parameters[15].Value = model.WebSiteID;
			parameters[16].Value = model.OrderBy;
			parameters[17].Value = model.IsPermissions;
			parameters[18].Value = model.IsCommend;
			parameters[19].Value = model.IsTop;
			parameters[20].Value = model.BrowseCount;
			parameters[21].Value = model.DownloadCount;
			parameters[22].Value = model.AddDate;
			parameters[23].Value = model.ModifyDate;
			parameters[24].Value = model.State;
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
			strSql.Append("delete from SW_Link ");
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
			strSql.Append("delete from SW_Link ");
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
		public WebSite.Model.Mod_Link GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Title,Content,Info,Tage,Image,WebUrl,LinkType,TypeID,ProductID,UserID,FileName,FileUrl,FileSize,FileSuffix,WebSiteID,OrderBy,IsPermissions,IsCommend,IsTop,BrowseCount,DownloadCount,AddDate,ModifyDate,State from SW_Link ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Link model=new WebSite.Model.Mod_Link();
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
		public WebSite.Model.Mod_Link DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Link model=new WebSite.Model.Mod_Link();
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
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["Tage"]!=null)
				{
					model.Tage=row["Tage"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["WebUrl"]!=null)
				{
					model.WebUrl=row["WebUrl"].ToString();
				}
				if(row["LinkType"]!=null && row["LinkType"].ToString()!="")
				{
					model.LinkType=int.Parse(row["LinkType"].ToString());
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["ProductID"]!=null && row["ProductID"].ToString()!="")
				{
					model.ProductID=int.Parse(row["ProductID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["FileName"]!=null)
				{
					model.FileName=row["FileName"].ToString();
				}
				if(row["FileUrl"]!=null)
				{
					model.FileUrl=row["FileUrl"].ToString();
				}
				if(row["FileSize"]!=null)
				{
					model.FileSize=row["FileSize"].ToString();
				}
				if(row["FileSuffix"]!=null)
				{
					model.FileSuffix=row["FileSuffix"].ToString();
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["IsPermissions"]!=null && row["IsPermissions"].ToString()!="")
				{
					model.IsPermissions=int.Parse(row["IsPermissions"].ToString());
				}
				if(row["IsCommend"]!=null && row["IsCommend"].ToString()!="")
				{
					model.IsCommend=int.Parse(row["IsCommend"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["DownloadCount"]!=null && row["DownloadCount"].ToString()!="")
				{
					model.DownloadCount=int.Parse(row["DownloadCount"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select ID,Model,Title,Content,Info,Tage,Image,WebUrl,LinkType,TypeID,ProductID,UserID,FileName,FileUrl,FileSize,FileSuffix,WebSiteID,OrderBy,IsPermissions,IsCommend,IsTop,BrowseCount,DownloadCount,AddDate,ModifyDate,State ");
			strSql.Append(" FROM SW_Link ");
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
			strSql.Append(" ID,Model,Title,Content,Info,Tage,Image,WebUrl,LinkType,TypeID,ProductID,UserID,FileName,FileUrl,FileSize,FileSuffix,WebSiteID,OrderBy,IsPermissions,IsCommend,IsTop,BrowseCount,DownloadCount,AddDate,ModifyDate,State ");
			strSql.Append(" FROM SW_Link ");
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
			strSql.Append("select count(1) FROM SW_Link ");
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
                strSql = "select top " + endIndex + " * from SW_Link where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Link where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Link where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Link";
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
        public WebSite.Model.Mod_Link GetTypeModel(int TypeID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,Title,Content,Info,Tage,Image,WebUrl,LinkType,TypeID,ProductID,UserID,FileName,FileUrl,FileSize,FileSuffix,WebSiteID,OrderBy,IsPermissions,IsCommend,IsTop,BrowseCount,DownloadCount,AddDate,ModifyDate,State from SW_Link ");
            strSql.Append(" where TypeID=@TypeID");
            SqlParameter[] parameters = {
					new SqlParameter("@TypeID", SqlDbType.Int,4)
			};
            parameters[0].Value = TypeID;

            WebSite.Model.Mod_Link model = new WebSite.Model.Mod_Link();
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

