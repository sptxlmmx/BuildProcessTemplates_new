
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_SupportComment
	/// </summary>
	public partial class Dal_SupportComment
	{
		public Dal_SupportComment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_SupportComment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_SupportComment");
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
		public int Add(WebSite.Model.Mod_SupportComment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_SupportComment(");
			strSql.Append("Model,NewsID,NewsTitle,ReuserID,ReuserName,ReuserNickName,ReuserLevelID,ReuserImage,ReuserClass,UserParentsID,ReplyUserID,ReplyUserName,ReplyNickName,ReplyID,Content1,Explanation,IsReport,ColumnID,ReColumnID,BestThanks,FabulousCount,ReplyCount,State,IsReview,IsBest,IsLook,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@NewsID,@NewsTitle,@ReuserID,@ReuserName,@ReuserNickName,@ReuserLevelID,@ReuserImage,@ReuserClass,@UserParentsID,@ReplyUserID,@ReplyUserName,@ReplyNickName,@ReplyID,@Content1,@Explanation,@IsReport,@ColumnID,@ReColumnID,@BestThanks,@FabulousCount,@ReplyCount,@State,@IsReview,@IsBest,@IsLook,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserID", SqlDbType.Int,4),
					new SqlParameter("@ReuserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserLevelID", SqlDbType.Int,4),
					new SqlParameter("@ReuserImage", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserClass", SqlDbType.VarChar,50),
					new SqlParameter("@UserParentsID", SqlDbType.Int,4),
					new SqlParameter("@ReplyUserID", SqlDbType.Int,4),
					new SqlParameter("@ReplyUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReplyNickName", SqlDbType.VarChar,200),
					new SqlParameter("@ReplyID", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@Explanation", SqlDbType.VarChar,200),
					new SqlParameter("@IsReport", SqlDbType.Int,4),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@ReColumnID", SqlDbType.Int,4),
					new SqlParameter("@BestThanks", SqlDbType.Text),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReplyCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@IsBest", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.NewsID;
			parameters[2].Value = model.NewsTitle;
			parameters[3].Value = model.ReuserID;
			parameters[4].Value = model.ReuserName;
			parameters[5].Value = model.ReuserNickName;
			parameters[6].Value = model.ReuserLevelID;
			parameters[7].Value = model.ReuserImage;
			parameters[8].Value = model.ReuserClass;
			parameters[9].Value = model.UserParentsID;
			parameters[10].Value = model.ReplyUserID;
			parameters[11].Value = model.ReplyUserName;
			parameters[12].Value = model.ReplyNickName;
			parameters[13].Value = model.ReplyID;
			parameters[14].Value = model.Content1;
			parameters[15].Value = model.Explanation;
			parameters[16].Value = model.IsReport;
			parameters[17].Value = model.ColumnID;
			parameters[18].Value = model.ReColumnID;
			parameters[19].Value = model.BestThanks;
			parameters[20].Value = model.FabulousCount;
			parameters[21].Value = model.ReplyCount;
			parameters[22].Value = model.State;
			parameters[23].Value = model.IsReview;
			parameters[24].Value = model.IsBest;
			parameters[25].Value = model.IsLook;
			parameters[26].Value = model.OrderBy;
			parameters[27].Value = model.AddDate;
			parameters[28].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_SupportComment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_SupportComment set ");
			strSql.Append("Model=@Model,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("NewsTitle=@NewsTitle,");
			strSql.Append("ReuserID=@ReuserID,");
			strSql.Append("ReuserName=@ReuserName,");
			strSql.Append("ReuserNickName=@ReuserNickName,");
			strSql.Append("ReuserLevelID=@ReuserLevelID,");
			strSql.Append("ReuserImage=@ReuserImage,");
			strSql.Append("ReuserClass=@ReuserClass,");
			strSql.Append("UserParentsID=@UserParentsID,");
			strSql.Append("ReplyUserID=@ReplyUserID,");
			strSql.Append("ReplyUserName=@ReplyUserName,");
			strSql.Append("ReplyNickName=@ReplyNickName,");
			strSql.Append("ReplyID=@ReplyID,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("Explanation=@Explanation,");
			strSql.Append("IsReport=@IsReport,");
			strSql.Append("ColumnID=@ColumnID,");
			strSql.Append("ReColumnID=@ReColumnID,");
			strSql.Append("BestThanks=@BestThanks,");
			strSql.Append("FabulousCount=@FabulousCount,");
			strSql.Append("ReplyCount=@ReplyCount,");
			strSql.Append("State=@State,");
			strSql.Append("IsReview=@IsReview,");
			strSql.Append("IsBest=@IsBest,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserID", SqlDbType.Int,4),
					new SqlParameter("@ReuserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserLevelID", SqlDbType.Int,4),
					new SqlParameter("@ReuserImage", SqlDbType.VarChar,200),
					new SqlParameter("@ReuserClass", SqlDbType.VarChar,50),
					new SqlParameter("@UserParentsID", SqlDbType.Int,4),
					new SqlParameter("@ReplyUserID", SqlDbType.Int,4),
					new SqlParameter("@ReplyUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ReplyNickName", SqlDbType.VarChar,200),
					new SqlParameter("@ReplyID", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@Explanation", SqlDbType.VarChar,200),
					new SqlParameter("@IsReport", SqlDbType.Int,4),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@ReColumnID", SqlDbType.Int,4),
					new SqlParameter("@BestThanks", SqlDbType.Text),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReplyCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@IsBest", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.NewsID;
			parameters[2].Value = model.NewsTitle;
			parameters[3].Value = model.ReuserID;
			parameters[4].Value = model.ReuserName;
			parameters[5].Value = model.ReuserNickName;
			parameters[6].Value = model.ReuserLevelID;
			parameters[7].Value = model.ReuserImage;
			parameters[8].Value = model.ReuserClass;
			parameters[9].Value = model.UserParentsID;
			parameters[10].Value = model.ReplyUserID;
			parameters[11].Value = model.ReplyUserName;
			parameters[12].Value = model.ReplyNickName;
			parameters[13].Value = model.ReplyID;
			parameters[14].Value = model.Content1;
			parameters[15].Value = model.Explanation;
			parameters[16].Value = model.IsReport;
			parameters[17].Value = model.ColumnID;
			parameters[18].Value = model.ReColumnID;
			parameters[19].Value = model.BestThanks;
			parameters[20].Value = model.FabulousCount;
			parameters[21].Value = model.ReplyCount;
			parameters[22].Value = model.State;
			parameters[23].Value = model.IsReview;
			parameters[24].Value = model.IsBest;
			parameters[25].Value = model.IsLook;
			parameters[26].Value = model.OrderBy;
			parameters[27].Value = model.AddDate;
			parameters[28].Value = model.WebSiteID;
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
			strSql.Append("delete from SW_SupportComment ");
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
			strSql.Append("delete from SW_SupportComment ");
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
		public WebSite.Model.Mod_SupportComment GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,NewsID,NewsTitle,ReuserID,ReuserName,ReuserNickName,ReuserLevelID,ReuserImage,ReuserClass,UserParentsID,ReplyUserID,ReplyUserName,ReplyNickName,ReplyID,Content1,Explanation,IsReport,ColumnID,ReColumnID,BestThanks,FabulousCount,ReplyCount,State,IsReview,IsBest,IsLook,OrderBy,AddDate,WebSiteID from SW_SupportComment ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_SupportComment model=new WebSite.Model.Mod_SupportComment();
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
		public WebSite.Model.Mod_SupportComment DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_SupportComment model=new WebSite.Model.Mod_SupportComment();
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
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["NewsTitle"]!=null)
				{
					model.NewsTitle=row["NewsTitle"].ToString();
				}
				if(row["ReuserID"]!=null && row["ReuserID"].ToString()!="")
				{
					model.ReuserID=int.Parse(row["ReuserID"].ToString());
				}
				if(row["ReuserName"]!=null)
				{
					model.ReuserName=row["ReuserName"].ToString();
				}
				if(row["ReuserNickName"]!=null)
				{
					model.ReuserNickName=row["ReuserNickName"].ToString();
				}
				if(row["ReuserLevelID"]!=null && row["ReuserLevelID"].ToString()!="")
				{
					model.ReuserLevelID=int.Parse(row["ReuserLevelID"].ToString());
				}
				if(row["ReuserImage"]!=null)
				{
					model.ReuserImage=row["ReuserImage"].ToString();
				}
				if(row["ReuserClass"]!=null)
				{
					model.ReuserClass=row["ReuserClass"].ToString();
				}
				if(row["UserParentsID"]!=null && row["UserParentsID"].ToString()!="")
				{
					model.UserParentsID=int.Parse(row["UserParentsID"].ToString());
				}
				if(row["ReplyUserID"]!=null && row["ReplyUserID"].ToString()!="")
				{
					model.ReplyUserID=int.Parse(row["ReplyUserID"].ToString());
				}
				if(row["ReplyUserName"]!=null)
				{
					model.ReplyUserName=row["ReplyUserName"].ToString();
				}
				if(row["ReplyNickName"]!=null)
				{
					model.ReplyNickName=row["ReplyNickName"].ToString();
				}
				if(row["ReplyID"]!=null && row["ReplyID"].ToString()!="")
				{
					model.ReplyID=int.Parse(row["ReplyID"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["Explanation"]!=null)
				{
					model.Explanation=row["Explanation"].ToString();
				}
				if(row["IsReport"]!=null && row["IsReport"].ToString()!="")
				{
					model.IsReport=int.Parse(row["IsReport"].ToString());
				}
				if(row["ColumnID"]!=null && row["ColumnID"].ToString()!="")
				{
					model.ColumnID=int.Parse(row["ColumnID"].ToString());
				}
				if(row["ReColumnID"]!=null && row["ReColumnID"].ToString()!="")
				{
					model.ReColumnID=int.Parse(row["ReColumnID"].ToString());
				}
				if(row["BestThanks"]!=null)
				{
					model.BestThanks=row["BestThanks"].ToString();
				}
				if(row["FabulousCount"]!=null && row["FabulousCount"].ToString()!="")
				{
					model.FabulousCount=int.Parse(row["FabulousCount"].ToString());
				}
				if(row["ReplyCount"]!=null && row["ReplyCount"].ToString()!="")
				{
					model.ReplyCount=int.Parse(row["ReplyCount"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsReview"]!=null && row["IsReview"].ToString()!="")
				{
					model.IsReview=int.Parse(row["IsReview"].ToString());
				}
				if(row["IsBest"]!=null && row["IsBest"].ToString()!="")
				{
					model.IsBest=int.Parse(row["IsBest"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
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
			strSql.Append("select ID,Model,NewsID,NewsTitle,ReuserID,ReuserName,ReuserNickName,ReuserLevelID,ReuserImage,ReuserClass,UserParentsID,ReplyUserID,ReplyUserName,ReplyNickName,ReplyID,Content1,Explanation,IsReport,ColumnID,ReColumnID,BestThanks,FabulousCount,ReplyCount,State,IsReview,IsBest,IsLook,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportComment ");
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
			strSql.Append(" ID,Model,NewsID,NewsTitle,ReuserID,ReuserName,ReuserNickName,ReuserLevelID,ReuserImage,ReuserClass,UserParentsID,ReplyUserID,ReplyUserName,ReplyNickName,ReplyID,Content1,Explanation,IsReport,ColumnID,ReColumnID,BestThanks,FabulousCount,ReplyCount,State,IsReview,IsBest,IsLook,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportComment ");
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
			strSql.Append("select count(1) FROM SW_SupportComment ");
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
                strSql = "select top " + endIndex + " * from SW_SupportComment where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_SupportComment where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_SupportComment where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_SupportComment";
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

