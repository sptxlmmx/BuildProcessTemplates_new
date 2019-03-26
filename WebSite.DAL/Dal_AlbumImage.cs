
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
using WebSite.Common;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_AlbumImage
	/// </summary>
	public partial class Dal_AlbumImage
	{
		public Dal_AlbumImage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_AlbumImage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_AlbumImage");
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
		public int Add(WebSite.Model.Mod_AlbumImage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_AlbumImage(");
			strSql.Append("Model,TypeID,AlbumTypeID,UserID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,FabulousCount,BrowseCount,OrderBy,IsReview,State,IsDefault,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@TypeID,@AlbumTypeID,@UserID,@ImgUrl,@Title,@ViceTitle,@Info,@ThumbUrl,@MidUrl,@OriginalUrl,@FabulousCount,@BrowseCount,@OrderBy,@IsReview,@State,@IsDefault,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@AlbumTypeID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.AlbumTypeID;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.ImgUrl;
			parameters[5].Value = model.Title;
			parameters[6].Value = model.ViceTitle;
			parameters[7].Value = model.Info;
			parameters[8].Value = model.ThumbUrl;
			parameters[9].Value = model.MidUrl;
			parameters[10].Value = model.OriginalUrl;
			parameters[11].Value = model.FabulousCount;
			parameters[12].Value = model.BrowseCount;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.IsReview;
			parameters[15].Value = model.State;
			parameters[16].Value = model.IsDefault;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_AlbumImage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_AlbumImage set ");
			strSql.Append("Model=@Model,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("AlbumTypeID=@AlbumTypeID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("Title=@Title,");
			strSql.Append("ViceTitle=@ViceTitle,");
			strSql.Append("Info=@Info,");
			strSql.Append("ThumbUrl=@ThumbUrl,");
			strSql.Append("MidUrl=@MidUrl,");
			strSql.Append("OriginalUrl=@OriginalUrl,");
			strSql.Append("FabulousCount=@FabulousCount,");
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("IsReview=@IsReview,");
			strSql.Append("State=@State,");
			strSql.Append("IsDefault=@IsDefault,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@AlbumTypeID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.AlbumTypeID;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.ImgUrl;
			parameters[5].Value = model.Title;
			parameters[6].Value = model.ViceTitle;
			parameters[7].Value = model.Info;
			parameters[8].Value = model.ThumbUrl;
			parameters[9].Value = model.MidUrl;
			parameters[10].Value = model.OriginalUrl;
			parameters[11].Value = model.FabulousCount;
			parameters[12].Value = model.BrowseCount;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.IsReview;
			parameters[15].Value = model.State;
			parameters[16].Value = model.IsDefault;
			parameters[17].Value = model.AddDate;
			parameters[18].Value = model.WebSiteID;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from SW_AlbumImage ");
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
			strSql.Append("delete from SW_AlbumImage ");
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
		public WebSite.Model.Mod_AlbumImage GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,TypeID,AlbumTypeID,UserID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,FabulousCount,BrowseCount,OrderBy,IsReview,State,IsDefault,AddDate,WebSiteID from SW_AlbumImage ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_AlbumImage model=new WebSite.Model.Mod_AlbumImage();
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
		public WebSite.Model.Mod_AlbumImage DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_AlbumImage model=new WebSite.Model.Mod_AlbumImage();
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
				if(row["AlbumTypeID"]!=null && row["AlbumTypeID"].ToString()!="")
				{
					model.AlbumTypeID=int.Parse(row["AlbumTypeID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["ViceTitle"]!=null)
				{
					model.ViceTitle=row["ViceTitle"].ToString();
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["ThumbUrl"]!=null)
				{
					model.ThumbUrl=row["ThumbUrl"].ToString();
				}
				if(row["MidUrl"]!=null)
				{
					model.MidUrl=row["MidUrl"].ToString();
				}
				if(row["OriginalUrl"]!=null)
				{
					model.OriginalUrl=row["OriginalUrl"].ToString();
				}
				if(row["FabulousCount"]!=null && row["FabulousCount"].ToString()!="")
				{
					model.FabulousCount=int.Parse(row["FabulousCount"].ToString());
				}
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["IsReview"]!=null && row["IsReview"].ToString()!="")
				{
					model.IsReview=int.Parse(row["IsReview"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsDefault"]!=null && row["IsDefault"].ToString()!="")
				{
					model.IsDefault=int.Parse(row["IsDefault"].ToString());
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
			strSql.Append("select ID,Model,TypeID,AlbumTypeID,UserID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,FabulousCount,BrowseCount,OrderBy,IsReview,State,IsDefault,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_AlbumImage ");
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
			strSql.Append(" ID,Model,TypeID,AlbumTypeID,UserID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,FabulousCount,BrowseCount,OrderBy,IsReview,State,IsDefault,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_AlbumImage ");
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
			strSql.Append("select count(1) FROM SW_AlbumImage ");
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
                strSql = "select top " + endIndex + " * from SW_AlbumImage where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_AlbumImage where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_AlbumImage where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_AlbumImage";
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageALL(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " convert(varchar(10),AddDate,120) as AddDate from SW_AlbumImage where  " + strWhere + " group by convert(varchar(10),AddDate,120)  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " convert(varchar(10),AddDate,120) as AddDate from SW_AlbumImage where  " + strWhere + " and  convert(varchar(10),AddDate,120) not in ( select top " + endIndex * (startIndex - 1) + " convert(varchar(10),AddDate,120) as AddDate from SW_AlbumImage where  " + strWhere + " group by convert(varchar(10),AddDate,120)  order by " + orderby + " ) group by convert(varchar(10),AddDate,120) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        public bool UpdateAlbum(int AlbumTypeID, string ID, int UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_AlbumImage set AlbumTypeID=@AlbumTypeID");
            strSql.Append(" where  UserID=@UserID and ID in (" + ID + ") ");
            SqlParameter[] parameters = {
                    new SqlParameter("@AlbumTypeID", SqlDbType.Int,4),
					
                    new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = AlbumTypeID;

            parameters[1].Value = UserID;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除相册图片和数据
        /// </summary>
        public bool DeleteFile(string CommentIDStr, bool IsDel)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        //删除相册图片和数据
                        DeleteFile(conn, trans, CommentIDStr, IsDel);
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 删除相册图片
        /// </summary>
        public void DeleteFile(SqlConnection conn, SqlTransaction trans, string CommentIDStr, bool IsDel)
        {

            if (!string.IsNullOrEmpty(CommentIDStr))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * from  SW_AlbumImage where " + CommentIDStr + "");
                DataSet ds = DbHelperSQL.Query(conn, trans, strSql.ToString());
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int rows = DbHelperSQL.ExecuteSql(conn, trans, "delete from  SW_AlbumImage where id in (" + dr["id"].ToString() + ")"); //删除数据库
                    if (rows > 0)
                    {
                        if (IsDel)
                        {
                            FileOperate.DeleteFile(dr["ThumbUrl"].ToString()); //删除缩略图
                            FileOperate.DeleteFile(dr["OriginalUrl"].ToString()); //删除原图
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCountALL(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM dbo.SW_AlbumImage left join SW_AlbumType on SW_AlbumImage.AlbumTypeID=SW_AlbumType.ID left join SW_User on SW_AlbumImage.UserID=SW_User.ID ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        /// 后台分页获取数据列表
        /// </sum
        public DataSet GetListByPageLeftJoin(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " SW_User.NiceName,SW_User.UserName,SW_User.Mobile,SW_User.LevelName, SW_AlbumType.AlbumTypeName,SW_AlbumImage.* from SW_AlbumImage left join SW_AlbumType on SW_AlbumImage.AlbumTypeID=SW_AlbumType.ID left join SW_User on SW_AlbumImage.UserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " SW_User.NiceName,SW_User.UserName,SW_User.Mobile,SW_User.LevelName, SW_AlbumType.AlbumTypeName,SW_AlbumImage.* from SW_AlbumImage left join SW_AlbumType on SW_AlbumImage.AlbumTypeID=SW_AlbumType.ID left join SW_User on SW_AlbumImage.UserID=SW_User.ID where  " + strWhere + " and  SW_AlbumImage.ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_AlbumImage where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }

		#endregion  ExtensionMethod
	}
}

