
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserAuthentication
	/// </summary>
	public partial class Dal_UserAuthentication
	{
		public Dal_UserAuthentication()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_UserAuthentication");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_UserAuthentication");
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
        public int Add(WebSite.Model.Mod_UserAuthentication model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_UserAuthentication(");
            strSql.Append("Model,UserID,UserNickName,UserRealName,IdentityNum,ImageIdentity1,ImageIdentity2,Remarks,IsReview,State,OrderBy,AddDate,ModifyDate,ReviewDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@UserNickName,@UserRealName,@IdentityNum,@ImageIdentity1,@ImageIdentity2,@Remarks,@IsReview,@State,@OrderBy,@AddDate,@ModifyDate,@ReviewDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserRealName", SqlDbType.NVarChar,20),
					new SqlParameter("@IdentityNum", SqlDbType.VarChar,50),
					new SqlParameter("@ImageIdentity1", SqlDbType.VarChar,200),
					new SqlParameter("@ImageIdentity2", SqlDbType.VarChar,200),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@ReviewDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserNickName;
            parameters[3].Value = model.UserRealName;
            parameters[4].Value = model.IdentityNum;
            parameters[5].Value = model.ImageIdentity1;
            parameters[6].Value = model.ImageIdentity2;
            parameters[7].Value = model.Remarks;
            parameters[8].Value = model.IsReview;
            parameters[9].Value = model.State;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.AddDate;
            parameters[12].Value = model.ModifyDate;
            parameters[13].Value = model.ReviewDate;
            parameters[14].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_UserAuthentication model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_UserAuthentication set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("UserRealName=@UserRealName,");
            strSql.Append("IdentityNum=@IdentityNum,");
            strSql.Append("ImageIdentity1=@ImageIdentity1,");
            strSql.Append("ImageIdentity2=@ImageIdentity2,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("IsReview=@IsReview,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("ReviewDate=@ReviewDate,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserRealName", SqlDbType.NVarChar,20),
					new SqlParameter("@IdentityNum", SqlDbType.VarChar,50),
					new SqlParameter("@ImageIdentity1", SqlDbType.VarChar,200),
					new SqlParameter("@ImageIdentity2", SqlDbType.VarChar,200),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@ReviewDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserNickName;
            parameters[3].Value = model.UserRealName;
            parameters[4].Value = model.IdentityNum;
            parameters[5].Value = model.ImageIdentity1;
            parameters[6].Value = model.ImageIdentity2;
            parameters[7].Value = model.Remarks;
            parameters[8].Value = model.IsReview;
            parameters[9].Value = model.State;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.AddDate;
            parameters[12].Value = model.ModifyDate;
            parameters[13].Value = model.ReviewDate;
            parameters[14].Value = model.WebSiteID;
            parameters[15].Value = model.ID;

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
            strSql.Append("delete from SW_UserAuthentication ");
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
            strSql.Append("delete from SW_UserAuthentication ");
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
        public WebSite.Model.Mod_UserAuthentication GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserNickName,UserRealName,IdentityNum,ImageIdentity1,ImageIdentity2,Remarks,IsReview,State,OrderBy,AddDate,ModifyDate,ReviewDate,WebSiteID from SW_UserAuthentication ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_UserAuthentication model = new WebSite.Model.Mod_UserAuthentication();
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
        public WebSite.Model.Mod_UserAuthentication DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_UserAuthentication model = new WebSite.Model.Mod_UserAuthentication();
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
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["UserNickName"] != null)
                {
                    model.UserNickName = row["UserNickName"].ToString();
                }
                if (row["UserRealName"] != null)
                {
                    model.UserRealName = row["UserRealName"].ToString();
                }
                if (row["IdentityNum"] != null)
                {
                    model.IdentityNum = row["IdentityNum"].ToString();
                }
                if (row["ImageIdentity1"] != null)
                {
                    model.ImageIdentity1 = row["ImageIdentity1"].ToString();
                }
                if (row["ImageIdentity2"] != null)
                {
                    model.ImageIdentity2 = row["ImageIdentity2"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
                }
                if (row["IsReview"] != null && row["IsReview"].ToString() != "")
                {
                    model.IsReview = int.Parse(row["IsReview"].ToString());
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
                if (row["ReviewDate"] != null && row["ReviewDate"].ToString() != "")
                {
                    model.ReviewDate = DateTime.Parse(row["ReviewDate"].ToString());
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
            strSql.Append("select ID,Model,UserID,UserNickName,UserRealName,IdentityNum,ImageIdentity1,ImageIdentity2,Remarks,IsReview,State,OrderBy,AddDate,ModifyDate,ReviewDate,WebSiteID ");
            strSql.Append(" FROM SW_UserAuthentication ");
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
            strSql.Append(" ID,Model,UserID,UserNickName,UserRealName,IdentityNum,ImageIdentity1,ImageIdentity2,Remarks,IsReview,State,OrderBy,AddDate,ModifyDate,ReviewDate,WebSiteID ");
            strSql.Append(" FROM SW_UserAuthentication ");
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
            strSql.Append("select count(1) FROM SW_UserAuthentication ");
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
                strSql = "select top " + endIndex + " * from SW_UserAuthentication where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserAuthentication where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserAuthentication where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_UserAuthentication";
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
        public WebSite.Model.Mod_UserAuthentication GetModelbyUserID(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from SW_UserAuthentication ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            WebSite.Model.Mod_MallShop model = new WebSite.Model.Mod_MallShop();
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

