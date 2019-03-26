
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_SupportTemple
	/// </summary>
	public partial class Dal_SupportTemple
	{
		public Dal_SupportTemple()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_SupportTemple"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_SupportTemple");
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
		public int Add(WebSite.Model.Mod_SupportTemple model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_SupportTemple(");
			strSql.Append("Model,UserID,EnName,TUserID,TempleName,ApplyText,RefuseText,OtherInt1,OtherInt2,OtherString1,OtherString2,AgreeState,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@EnName,@TUserID,@TempleName,@ApplyText,@RefuseText,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@AgreeState,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EnName", SqlDbType.NVarChar,200),
					new SqlParameter("@TUserID", SqlDbType.Int,4),
					new SqlParameter("@TempleName", SqlDbType.NVarChar,200),
					new SqlParameter("@ApplyText", SqlDbType.NText),
					new SqlParameter("@RefuseText", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@AgreeState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.TUserID;
			parameters[4].Value = model.TempleName;
			parameters[5].Value = model.ApplyText;
			parameters[6].Value = model.RefuseText;
			parameters[7].Value = model.OtherInt1;
			parameters[8].Value = model.OtherInt2;
			parameters[9].Value = model.OtherString1;
			parameters[10].Value = model.OtherString2;
			parameters[11].Value = model.AgreeState;
			parameters[12].Value = model.State;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.AddDate;
			parameters[15].Value = model.ModifyDate;
			parameters[16].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_SupportTemple model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_SupportTemple set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("EnName=@EnName,");
			strSql.Append("TUserID=@TUserID,");
			strSql.Append("TempleName=@TempleName,");
			strSql.Append("ApplyText=@ApplyText,");
			strSql.Append("RefuseText=@RefuseText,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("AgreeState=@AgreeState,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EnName", SqlDbType.NVarChar,200),
					new SqlParameter("@TUserID", SqlDbType.Int,4),
					new SqlParameter("@TempleName", SqlDbType.NVarChar,200),
					new SqlParameter("@ApplyText", SqlDbType.NText),
					new SqlParameter("@RefuseText", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@AgreeState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.TUserID;
			parameters[4].Value = model.TempleName;
			parameters[5].Value = model.ApplyText;
			parameters[6].Value = model.RefuseText;
			parameters[7].Value = model.OtherInt1;
			parameters[8].Value = model.OtherInt2;
			parameters[9].Value = model.OtherString1;
			parameters[10].Value = model.OtherString2;
			parameters[11].Value = model.AgreeState;
			parameters[12].Value = model.State;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.AddDate;
			parameters[15].Value = model.ModifyDate;
			parameters[16].Value = model.WebSiteID;
			parameters[17].Value = model.ID;

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
			strSql.Append("delete from SW_SupportTemple ");
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
			strSql.Append("delete from SW_SupportTemple ");
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
		public WebSite.Model.Mod_SupportTemple GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,EnName,TUserID,TempleName,ApplyText,RefuseText,OtherInt1,OtherInt2,OtherString1,OtherString2,AgreeState,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_SupportTemple ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_SupportTemple model=new WebSite.Model.Mod_SupportTemple();
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
		public WebSite.Model.Mod_SupportTemple DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_SupportTemple model=new WebSite.Model.Mod_SupportTemple();
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
				if(row["EnName"]!=null)
				{
					model.EnName=row["EnName"].ToString();
				}
				if(row["TUserID"]!=null && row["TUserID"].ToString()!="")
				{
					model.TUserID=int.Parse(row["TUserID"].ToString());
				}
				if(row["TempleName"]!=null)
				{
					model.TempleName=row["TempleName"].ToString();
				}
				if(row["ApplyText"]!=null)
				{
					model.ApplyText=row["ApplyText"].ToString();
				}
				if(row["RefuseText"]!=null)
				{
					model.RefuseText=row["RefuseText"].ToString();
				}
				if(row["OtherInt1"]!=null && row["OtherInt1"].ToString()!="")
				{
					model.OtherInt1=int.Parse(row["OtherInt1"].ToString());
				}
				if(row["OtherInt2"]!=null && row["OtherInt2"].ToString()!="")
				{
					model.OtherInt2=int.Parse(row["OtherInt2"].ToString());
				}
				if(row["OtherString1"]!=null)
				{
					model.OtherString1=row["OtherString1"].ToString();
				}
				if(row["OtherString2"]!=null)
				{
					model.OtherString2=row["OtherString2"].ToString();
				}
				if(row["AgreeState"]!=null && row["AgreeState"].ToString()!="")
				{
					model.AgreeState=int.Parse(row["AgreeState"].ToString());
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
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
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
			strSql.Append("select ID,Model,UserID,EnName,TUserID,TempleName,ApplyText,RefuseText,OtherInt1,OtherInt2,OtherString1,OtherString2,AgreeState,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportTemple ");
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
			strSql.Append(" ID,Model,UserID,EnName,TUserID,TempleName,ApplyText,RefuseText,OtherInt1,OtherInt2,OtherString1,OtherString2,AgreeState,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportTemple ");
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
			strSql.Append("select count(1) FROM SW_SupportTemple ");
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
                strSql = "select top " + endIndex + " * from SW_SupportTemple where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_SupportTemple where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_SupportTemple where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_SupportTemple";
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
        public WebSite.Model.Mod_SupportTemple GetModel(int UserID, int TUserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,EnName,TUserID,TempleName,ApplyText,RefuseText,OtherInt1,OtherInt2,OtherString1,OtherString2,AgreeState,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_SupportTemple ");
            strSql.Append(" where UserID=@UserID and TUserID=@TUserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@TUserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            parameters[1].Value = TUserID;

            WebSite.Model.Mod_SupportTemple model = new WebSite.Model.Mod_SupportTemple();
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteListALL(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_SupportTemple ");
            strSql.Append(" where " + IDlist + " ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 分页获取数据列表企业中的寺院
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
                strSql = "select top " + endIndex + " SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportTemple.* from SW_SupportTemple left join SW_User on SW_SupportTemple.TUserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";

            }
            else
            {
                strSql = "select top " + endIndex + " SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportTemple.* from SW_SupportTemple left join SW_User on SW_SupportTemple.TUserID=SW_User.ID where  " + strWhere + " and  SW_SupportTemple.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_SupportTemple.ID from SW_SupportTemple where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";

            }
            return DbHelperSQL.Query(strSql);
        }


        /// <summary>
        /// 分页获取数据列表寺院中的企业
        /// </summary>
        public DataSet GetListByPageEnterprise(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportTemple.* from SW_SupportTemple left join SW_User on SW_SupportTemple.UserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";

            }
            else
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportTemple.* from SW_SupportTemple left join SW_User on SW_SupportTemple.UserID=SW_User.ID where  " + strWhere + " and  SW_SupportTemple.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_SupportTemple.ID from SW_SupportTemple where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";

            }
            return DbHelperSQL.Query(strSql);
        }
		#endregion  ExtensionMethod
	}
}

