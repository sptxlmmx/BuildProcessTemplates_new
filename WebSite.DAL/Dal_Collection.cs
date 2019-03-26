
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Collection
	/// </summary>
	public partial class Dal_Collection
	{
		public Dal_Collection()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Collection"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Collection");
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
		public int Add(WebSite.Model.Mod_Collection model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Collection(");
			strSql.Append("Model,UserID,BUserID,BUserName,BUserNickName,BUserImage,BUserClass,NewsID,NewsTitle,NewsTypeID,NewsTypeName,NewsImage,NewsAuthor,NewsIntroduction,NewsBrowseCount,NewsCommentCount,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@BUserID,@BUserName,@BUserNickName,@BUserImage,@BUserClass,@NewsID,@NewsTitle,@NewsTypeID,@NewsTypeName,@NewsImage,@NewsAuthor,@NewsIntroduction,@NewsBrowseCount,@NewsCommentCount,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserImage", SqlDbType.VarChar,200),
					new SqlParameter("@BUserClass", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4),
					new SqlParameter("@NewsTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@NewsImage", SqlDbType.VarChar,500),
					new SqlParameter("@NewsAuthor", SqlDbType.VarChar,200),
					new SqlParameter("@NewsIntroduction", SqlDbType.VarChar,2000),
					new SqlParameter("@NewsBrowseCount", SqlDbType.Int,4),
					new SqlParameter("@NewsCommentCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.BUserID;
			parameters[3].Value = model.BUserName;
			parameters[4].Value = model.BUserNickName;
			parameters[5].Value = model.BUserImage;
			parameters[6].Value = model.BUserClass;
			parameters[7].Value = model.NewsID;
			parameters[8].Value = model.NewsTitle;
			parameters[9].Value = model.NewsTypeID;
			parameters[10].Value = model.NewsTypeName;
			parameters[11].Value = model.NewsImage;
			parameters[12].Value = model.NewsAuthor;
			parameters[13].Value = model.NewsIntroduction;
			parameters[14].Value = model.NewsBrowseCount;
			parameters[15].Value = model.NewsCommentCount;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
			parameters[19].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Collection model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Collection set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("BUserID=@BUserID,");
			strSql.Append("BUserName=@BUserName,");
			strSql.Append("BUserNickName=@BUserNickName,");
			strSql.Append("BUserImage=@BUserImage,");
			strSql.Append("BUserClass=@BUserClass,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("NewsTitle=@NewsTitle,");
			strSql.Append("NewsTypeID=@NewsTypeID,");
			strSql.Append("NewsTypeName=@NewsTypeName,");
			strSql.Append("NewsImage=@NewsImage,");
			strSql.Append("NewsAuthor=@NewsAuthor,");
			strSql.Append("NewsIntroduction=@NewsIntroduction,");
			strSql.Append("NewsBrowseCount=@NewsBrowseCount,");
			strSql.Append("NewsCommentCount=@NewsCommentCount,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserImage", SqlDbType.VarChar,200),
					new SqlParameter("@BUserClass", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4),
					new SqlParameter("@NewsTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@NewsImage", SqlDbType.VarChar,500),
					new SqlParameter("@NewsAuthor", SqlDbType.VarChar,200),
					new SqlParameter("@NewsIntroduction", SqlDbType.VarChar,2000),
					new SqlParameter("@NewsBrowseCount", SqlDbType.Int,4),
					new SqlParameter("@NewsCommentCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.BUserID;
			parameters[3].Value = model.BUserName;
			parameters[4].Value = model.BUserNickName;
			parameters[5].Value = model.BUserImage;
			parameters[6].Value = model.BUserClass;
			parameters[7].Value = model.NewsID;
			parameters[8].Value = model.NewsTitle;
			parameters[9].Value = model.NewsTypeID;
			parameters[10].Value = model.NewsTypeName;
			parameters[11].Value = model.NewsImage;
			parameters[12].Value = model.NewsAuthor;
			parameters[13].Value = model.NewsIntroduction;
			parameters[14].Value = model.NewsBrowseCount;
			parameters[15].Value = model.NewsCommentCount;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
			parameters[19].Value = model.WebSiteID;
			parameters[20].Value = model.ID;

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
			strSql.Append("delete from SW_Collection ");
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
			strSql.Append("delete from SW_Collection ");
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
		public WebSite.Model.Mod_Collection GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,BUserID,BUserName,BUserNickName,BUserImage,BUserClass,NewsID,NewsTitle,NewsTypeID,NewsTypeName,NewsImage,NewsAuthor,NewsIntroduction,NewsBrowseCount,NewsCommentCount,State,OrderBy,AddDate,WebSiteID from SW_Collection ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Collection model=new WebSite.Model.Mod_Collection();
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
		public WebSite.Model.Mod_Collection DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Collection model=new WebSite.Model.Mod_Collection();
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
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["BUserID"]!=null && row["BUserID"].ToString()!="")
				{
					model.BUserID=int.Parse(row["BUserID"].ToString());
				}
				if(row["BUserName"]!=null)
				{
					model.BUserName=row["BUserName"].ToString();
				}
				if(row["BUserNickName"]!=null)
				{
					model.BUserNickName=row["BUserNickName"].ToString();
				}
				if(row["BUserImage"]!=null)
				{
					model.BUserImage=row["BUserImage"].ToString();
				}
				if(row["BUserClass"]!=null)
				{
					model.BUserClass=row["BUserClass"].ToString();
				}
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["NewsTitle"]!=null)
				{
					model.NewsTitle=row["NewsTitle"].ToString();
				}
				if(row["NewsTypeID"]!=null && row["NewsTypeID"].ToString()!="")
				{
					model.NewsTypeID=int.Parse(row["NewsTypeID"].ToString());
				}
				if(row["NewsTypeName"]!=null)
				{
					model.NewsTypeName=row["NewsTypeName"].ToString();
				}
				if(row["NewsImage"]!=null)
				{
					model.NewsImage=row["NewsImage"].ToString();
				}
				if(row["NewsAuthor"]!=null)
				{
					model.NewsAuthor=row["NewsAuthor"].ToString();
				}
				if(row["NewsIntroduction"]!=null)
				{
					model.NewsIntroduction=row["NewsIntroduction"].ToString();
				}
				if(row["NewsBrowseCount"]!=null && row["NewsBrowseCount"].ToString()!="")
				{
					model.NewsBrowseCount=int.Parse(row["NewsBrowseCount"].ToString());
				}
				if(row["NewsCommentCount"]!=null && row["NewsCommentCount"].ToString()!="")
				{
					model.NewsCommentCount=int.Parse(row["NewsCommentCount"].ToString());
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
			strSql.Append("select ID,Model,UserID,BUserID,BUserName,BUserNickName,BUserImage,BUserClass,NewsID,NewsTitle,NewsTypeID,NewsTypeName,NewsImage,NewsAuthor,NewsIntroduction,NewsBrowseCount,NewsCommentCount,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Collection ");
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
			strSql.Append(" ID,Model,UserID,BUserID,BUserName,BUserNickName,BUserImage,BUserClass,NewsID,NewsTitle,NewsTypeID,NewsTypeName,NewsImage,NewsAuthor,NewsIntroduction,NewsBrowseCount,NewsCommentCount,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Collection ");
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
			strSql.Append("select count(1) FROM SW_Collection ");
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
                strSql = "select top " + endIndex + " * from SW_Collection where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Collection where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Collection where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Collection";
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

