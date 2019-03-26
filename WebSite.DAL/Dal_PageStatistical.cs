
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_PageStatistical
	/// </summary>
	public partial class Dal_PageStatistical
	{
		public Dal_PageStatistical()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_PageStatistical");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_PageStatistical");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(WebSite.Model.Mod_PageStatistical model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_PageStatistical(");
            strSql.Append("Model,TypeID,TypeTitle,TypeParentID,TypeParentTitle,PageUrl,UrlReferrer,PageID,PageTitle,UserID,UserNickName,IP,PcOrMobile,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@TypeID,@TypeTitle,@TypeParentID,@TypeParentTitle,@PageUrl,@UrlReferrer,@PageID,@PageTitle,@UserID,@UserNickName,@IP,@PcOrMobile,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeTitle", SqlDbType.VarChar,100),
					new SqlParameter("@TypeParentID", SqlDbType.Int,4),
					new SqlParameter("@TypeParentTitle", SqlDbType.VarChar,50),
					new SqlParameter("@PageUrl", SqlDbType.VarChar,200),
					new SqlParameter("@UrlReferrer", SqlDbType.VarChar,200),
					new SqlParameter("@PageID", SqlDbType.Int,4),
					new SqlParameter("@PageTitle", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@IP", SqlDbType.VarChar,100),
					new SqlParameter("@PcOrMobile", SqlDbType.VarChar,10),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.TypeTitle;
            parameters[3].Value = model.TypeParentID;
            parameters[4].Value = model.TypeParentTitle;
            parameters[5].Value = model.PageUrl;
            parameters[6].Value = model.UrlReferrer;
            parameters[7].Value = model.PageID;
            parameters[8].Value = model.PageTitle;
            parameters[9].Value = model.UserID;
            parameters[10].Value = model.UserNickName;
            parameters[11].Value = model.IP;
            parameters[12].Value = model.PcOrMobile;
            parameters[13].Value = model.State;
            parameters[14].Value = model.OrderBy;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.ModifyDate;
            parameters[17].Value = model.WebSiteID;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(WebSite.Model.Mod_PageStatistical model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_PageStatistical set ");
            strSql.Append("Model=@Model,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeTitle=@TypeTitle,");
            strSql.Append("TypeParentID=@TypeParentID,");
            strSql.Append("TypeParentTitle=@TypeParentTitle,");
            strSql.Append("PageUrl=@PageUrl,");
            strSql.Append("UrlReferrer=@UrlReferrer,");
            strSql.Append("PageID=@PageID,");
            strSql.Append("PageTitle=@PageTitle,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("IP=@IP,");
            strSql.Append("PcOrMobile=@PcOrMobile,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeTitle", SqlDbType.VarChar,100),
					new SqlParameter("@TypeParentID", SqlDbType.Int,4),
					new SqlParameter("@TypeParentTitle", SqlDbType.VarChar,50),
					new SqlParameter("@PageUrl", SqlDbType.VarChar,200),
					new SqlParameter("@UrlReferrer", SqlDbType.VarChar,200),
					new SqlParameter("@PageID", SqlDbType.Int,4),
					new SqlParameter("@PageTitle", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@IP", SqlDbType.VarChar,100),
					new SqlParameter("@PcOrMobile", SqlDbType.VarChar,10),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.TypeTitle;
            parameters[3].Value = model.TypeParentID;
            parameters[4].Value = model.TypeParentTitle;
            parameters[5].Value = model.PageUrl;
            parameters[6].Value = model.UrlReferrer;
            parameters[7].Value = model.PageID;
            parameters[8].Value = model.PageTitle;
            parameters[9].Value = model.UserID;
            parameters[10].Value = model.UserNickName;
            parameters[11].Value = model.IP;
            parameters[12].Value = model.PcOrMobile;
            parameters[13].Value = model.State;
            parameters[14].Value = model.OrderBy;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.ModifyDate;
            parameters[17].Value = model.WebSiteID;
            parameters[18].Value = model.ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_PageStatistical ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_PageStatistical ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_PageStatistical GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,TypeID,TypeTitle,TypeParentID,TypeParentTitle,PageUrl,UrlReferrer,PageID,PageTitle,UserID,UserNickName,IP,PcOrMobile,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_PageStatistical ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_PageStatistical model = new WebSite.Model.Mod_PageStatistical();
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
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_PageStatistical DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_PageStatistical model = new WebSite.Model.Mod_PageStatistical();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Model"] != null)
                {
                    model.Model = row["Model"].ToString();
                }
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["TypeTitle"] != null)
                {
                    model.TypeTitle = row["TypeTitle"].ToString();
                }
                if (row["TypeParentID"] != null && row["TypeParentID"].ToString() != "")
                {
                    model.TypeParentID = int.Parse(row["TypeParentID"].ToString());
                }
                if (row["TypeParentTitle"] != null)
                {
                    model.TypeParentTitle = row["TypeParentTitle"].ToString();
                }
                if (row["PageUrl"] != null)
                {
                    model.PageUrl = row["PageUrl"].ToString();
                }
                if (row["UrlReferrer"] != null)
                {
                    model.UrlReferrer = row["UrlReferrer"].ToString();
                }
                if (row["PageID"] != null && row["PageID"].ToString() != "")
                {
                    model.PageID = int.Parse(row["PageID"].ToString());
                }
                if (row["PageTitle"] != null)
                {
                    model.PageTitle = row["PageTitle"].ToString();
                }
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["UserNickName"] != null)
                {
                    model.UserNickName = row["UserNickName"].ToString();
                }
                if (row["IP"] != null)
                {
                    model.IP = row["IP"].ToString();
                }
                if (row["PcOrMobile"] != null)
                {
                    model.PcOrMobile = row["PcOrMobile"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
                {
                    model.ModifyDate = DateTime.Parse(row["ModifyDate"].ToString());
                }
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Model,TypeID,TypeTitle,TypeParentID,TypeParentTitle,PageUrl,UrlReferrer,PageID,PageTitle,UserID,UserNickName,IP,PcOrMobile,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
            strSql.Append(" FROM SW_PageStatistical ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,Model,TypeID,TypeTitle,TypeParentID,TypeParentTitle,PageUrl,UrlReferrer,PageID,PageTitle,UserID,UserNickName,IP,PcOrMobile,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
            strSql.Append(" FROM SW_PageStatistical ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM SW_PageStatistical ");
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
                strSql = "select top " + endIndex + " * from SW_PageStatistical where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_PageStatistical where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_PageStatistical where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_PageStatistical";
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

