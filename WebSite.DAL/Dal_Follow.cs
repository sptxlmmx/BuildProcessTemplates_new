
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Follow
	/// </summary>
	public partial class Dal_Follow
	{
		public Dal_Follow()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Follow"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Follow");
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
		public int Add(WebSite.Model.Mod_Follow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Follow(");
			strSql.Append("Model,UserID,BuserID,TypeID,TypeName,IsTop,IsFollowEach,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@BuserID,@TypeID,@TypeName,@IsTop,@IsFollowEach,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BuserID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,200),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsFollowEach", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.BuserID;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.TypeName;
			parameters[5].Value = model.IsTop;
			parameters[6].Value = model.IsFollowEach;
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
		public bool Update(WebSite.Model.Mod_Follow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Follow set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("BuserID=@BuserID,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsFollowEach=@IsFollowEach,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BuserID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,200),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsFollowEach", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.BuserID;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.TypeName;
			parameters[5].Value = model.IsTop;
			parameters[6].Value = model.IsFollowEach;
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
			strSql.Append("delete from SW_Follow ");
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
			strSql.Append("delete from SW_Follow ");
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
		public WebSite.Model.Mod_Follow GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,BuserID,TypeID,TypeName,IsTop,IsFollowEach,State,OrderBy,AddDate,WebSiteID from SW_Follow ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Follow model=new WebSite.Model.Mod_Follow();
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
		public WebSite.Model.Mod_Follow DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Follow model=new WebSite.Model.Mod_Follow();
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
				if(row["BuserID"]!=null && row["BuserID"].ToString()!="")
				{
					model.BuserID=int.Parse(row["BuserID"].ToString());
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsFollowEach"]!=null && row["IsFollowEach"].ToString()!="")
				{
					model.IsFollowEach=int.Parse(row["IsFollowEach"].ToString());
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
			strSql.Append("select ID,Model,UserID,BuserID,TypeID,TypeName,IsTop,IsFollowEach,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Follow ");
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
			strSql.Append(" ID,Model,UserID,BuserID,TypeID,TypeName,IsTop,IsFollowEach,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Follow ");
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
			strSql.Append("select count(1) FROM SW_Follow ");
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
                strSql = "select top " + endIndex + " * from SW_Follow where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Follow where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Follow where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Follow";
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
        /// 分页获取数据列表我的关注
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
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_Follow.* from SW_Follow left join SW_User on SW_Follow.BuserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_Follow.* from SW_Follow left join SW_User on SW_Follow.BuserID=SW_User.ID where  " + strWhere + " and  SW_Follow.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_Follow.ID from SW_Follow where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }


        /// <summary>
        /// 分页获取数据列表粉丝
        /// </summary>
        public DataSet GetListByPageFans(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_Follow.* from SW_Follow left join SW_User on SW_Follow.UserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_Follow.* from SW_Follow left join SW_User on SW_Follow.UserID=SW_User.ID where  " + strWhere + " and  SW_Follow.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_Follow.ID from SW_Follow where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_Follow GetModelUserID(int UserID, int BuserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,BuserID,TypeID,TypeName,IsTop,IsFollowEach,State,OrderBy,AddDate,WebSiteID from SW_Follow ");
            strSql.Append(" where UserID=@UserID and BuserID=@BuserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@BuserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            parameters[1].Value = BuserID;

            WebSite.Model.Mod_Follow model = new WebSite.Model.Mod_Follow();
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
        /// <summary>
        /// 取消关注（删除）
        /// </summary>
        public bool DeleteUserID(int UserID, int BuserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_Follow ");
            strSql.Append(" where (UserID=@UserID and BuserID=@BuserID) ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@BuserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            parameters[1].Value = BuserID;

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
		#endregion  ExtensionMethod
	}
}

