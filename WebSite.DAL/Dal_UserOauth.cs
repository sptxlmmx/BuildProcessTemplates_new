
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserOauth
	/// </summary>
	public partial class Dal_UserOauth
	{
		public Dal_UserOauth()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_UserOauth");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_UserOauth");
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
        public int Add(WebSite.Model.Mod_UserOauth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_UserOauth(");
            strSql.Append("Model,UserID,UserName,UserIDOld,OauthName,OauthUnionid,OauthOpenid,OauthOpenidMall,OauthAccesstoken,IsLoginonAPP,IsLoginonWeiXinClient,IsLoginonAPPMall,IsLoginonWeiXinClientMall,State,OrderBy,AddDate,WebSiteID,otherInt1,otherInt2,otherStriing1,otherStriing2)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@UserName,@UserIDOld,@OauthName,@OauthUnionid,@OauthOpenid,@OauthOpenidMall,@OauthAccesstoken,@IsLoginonAPP,@IsLoginonWeiXinClient,@IsLoginonAPPMall,@IsLoginonWeiXinClientMall,@State,@OrderBy,@AddDate,@WebSiteID,@otherInt1,@otherInt2,@otherStriing1,@otherStriing2)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserIDOld", SqlDbType.Int,4),
					new SqlParameter("@OauthName", SqlDbType.VarChar,200),
					new SqlParameter("@OauthUnionid", SqlDbType.VarChar,200),
					new SqlParameter("@OauthOpenid", SqlDbType.VarChar,200),
					new SqlParameter("@OauthOpenidMall", SqlDbType.VarChar,200),
					new SqlParameter("@OauthAccesstoken", SqlDbType.VarChar,200),
					new SqlParameter("@IsLoginonAPP", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonWeiXinClient", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonAPPMall", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonWeiXinClientMall", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@otherInt1", SqlDbType.Int,4),
					new SqlParameter("@otherInt2", SqlDbType.Int,4),
					new SqlParameter("@otherStriing1", SqlDbType.VarChar,200),
					new SqlParameter("@otherStriing2", SqlDbType.VarChar,200)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserIDOld;
            parameters[4].Value = model.OauthName;
            parameters[5].Value = model.OauthUnionid;
            parameters[6].Value = model.OauthOpenid;
            parameters[7].Value = model.OauthOpenidMall;
            parameters[8].Value = model.OauthAccesstoken;
            parameters[9].Value = model.IsLoginonAPP;
            parameters[10].Value = model.IsLoginonWeiXinClient;
            parameters[11].Value = model.IsLoginonAPPMall;
            parameters[12].Value = model.IsLoginonWeiXinClientMall;
            parameters[13].Value = model.State;
            parameters[14].Value = model.OrderBy;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.WebSiteID;
            parameters[17].Value = model.otherInt1;
            parameters[18].Value = model.otherInt2;
            parameters[19].Value = model.otherStriing1;
            parameters[20].Value = model.otherStriing2;

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
        public bool Update(WebSite.Model.Mod_UserOauth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_UserOauth set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserIDOld=@UserIDOld,");
            strSql.Append("OauthName=@OauthName,");
            strSql.Append("OauthUnionid=@OauthUnionid,");
            strSql.Append("OauthOpenid=@OauthOpenid,");
            strSql.Append("OauthOpenidMall=@OauthOpenidMall,");
            strSql.Append("OauthAccesstoken=@OauthAccesstoken,");
            strSql.Append("IsLoginonAPP=@IsLoginonAPP,");
            strSql.Append("IsLoginonWeiXinClient=@IsLoginonWeiXinClient,");
            strSql.Append("IsLoginonAPPMall=@IsLoginonAPPMall,");
            strSql.Append("IsLoginonWeiXinClientMall=@IsLoginonWeiXinClientMall,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("otherInt1=@otherInt1,");
            strSql.Append("otherInt2=@otherInt2,");
            strSql.Append("otherStriing1=@otherStriing1,");
            strSql.Append("otherStriing2=@otherStriing2");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserIDOld", SqlDbType.Int,4),
					new SqlParameter("@OauthName", SqlDbType.VarChar,200),
					new SqlParameter("@OauthUnionid", SqlDbType.VarChar,200),
					new SqlParameter("@OauthOpenid", SqlDbType.VarChar,200),
					new SqlParameter("@OauthOpenidMall", SqlDbType.VarChar,200),
					new SqlParameter("@OauthAccesstoken", SqlDbType.VarChar,200),
					new SqlParameter("@IsLoginonAPP", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonWeiXinClient", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonAPPMall", SqlDbType.Int,4),
					new SqlParameter("@IsLoginonWeiXinClientMall", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@otherInt1", SqlDbType.Int,4),
					new SqlParameter("@otherInt2", SqlDbType.Int,4),
					new SqlParameter("@otherStriing1", SqlDbType.VarChar,200),
					new SqlParameter("@otherStriing2", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserIDOld;
            parameters[4].Value = model.OauthName;
            parameters[5].Value = model.OauthUnionid;
            parameters[6].Value = model.OauthOpenid;
            parameters[7].Value = model.OauthOpenidMall;
            parameters[8].Value = model.OauthAccesstoken;
            parameters[9].Value = model.IsLoginonAPP;
            parameters[10].Value = model.IsLoginonWeiXinClient;
            parameters[11].Value = model.IsLoginonAPPMall;
            parameters[12].Value = model.IsLoginonWeiXinClientMall;
            parameters[13].Value = model.State;
            parameters[14].Value = model.OrderBy;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.WebSiteID;
            parameters[17].Value = model.otherInt1;
            parameters[18].Value = model.otherInt2;
            parameters[19].Value = model.otherStriing1;
            parameters[20].Value = model.otherStriing2;
            parameters[21].Value = model.ID;

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
            strSql.Append("delete from SW_UserOauth ");
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
            strSql.Append("delete from SW_UserOauth ");
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
        public WebSite.Model.Mod_UserOauth GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserName,UserIDOld,OauthName,OauthUnionid,OauthOpenid,OauthOpenidMall,OauthAccesstoken,IsLoginonAPP,IsLoginonWeiXinClient,IsLoginonAPPMall,IsLoginonWeiXinClientMall,State,OrderBy,AddDate,WebSiteID,otherInt1,otherInt2,otherStriing1,otherStriing2 from SW_UserOauth ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_UserOauth model = new WebSite.Model.Mod_UserOauth();
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
        public WebSite.Model.Mod_UserOauth DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_UserOauth model = new WebSite.Model.Mod_UserOauth();
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
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["UserIDOld"] != null && row["UserIDOld"].ToString() != "")
                {
                    model.UserIDOld = int.Parse(row["UserIDOld"].ToString());
                }
                if (row["OauthName"] != null)
                {
                    model.OauthName = row["OauthName"].ToString();
                }
                if (row["OauthUnionid"] != null)
                {
                    model.OauthUnionid = row["OauthUnionid"].ToString();
                }
                if (row["OauthOpenid"] != null)
                {
                    model.OauthOpenid = row["OauthOpenid"].ToString();
                }
                if (row["OauthOpenidMall"] != null)
                {
                    model.OauthOpenidMall = row["OauthOpenidMall"].ToString();
                }
                if (row["OauthAccesstoken"] != null)
                {
                    model.OauthAccesstoken = row["OauthAccesstoken"].ToString();
                }
                if (row["IsLoginonAPP"] != null && row["IsLoginonAPP"].ToString() != "")
                {
                    model.IsLoginonAPP = int.Parse(row["IsLoginonAPP"].ToString());
                }
                if (row["IsLoginonWeiXinClient"] != null && row["IsLoginonWeiXinClient"].ToString() != "")
                {
                    model.IsLoginonWeiXinClient = int.Parse(row["IsLoginonWeiXinClient"].ToString());
                }
                if (row["IsLoginonAPPMall"] != null && row["IsLoginonAPPMall"].ToString() != "")
                {
                    model.IsLoginonAPPMall = int.Parse(row["IsLoginonAPPMall"].ToString());
                }
                if (row["IsLoginonWeiXinClientMall"] != null && row["IsLoginonWeiXinClientMall"].ToString() != "")
                {
                    model.IsLoginonWeiXinClientMall = int.Parse(row["IsLoginonWeiXinClientMall"].ToString());
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
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
                if (row["otherInt1"] != null && row["otherInt1"].ToString() != "")
                {
                    model.otherInt1 = int.Parse(row["otherInt1"].ToString());
                }
                if (row["otherInt2"] != null && row["otherInt2"].ToString() != "")
                {
                    model.otherInt2 = int.Parse(row["otherInt2"].ToString());
                }
                if (row["otherStriing1"] != null)
                {
                    model.otherStriing1 = row["otherStriing1"].ToString();
                }
                if (row["otherStriing2"] != null)
                {
                    model.otherStriing2 = row["otherStriing2"].ToString();
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
            strSql.Append("select ID,Model,UserID,UserName,UserIDOld,OauthName,OauthUnionid,OauthOpenid,OauthOpenidMall,OauthAccesstoken,IsLoginonAPP,IsLoginonWeiXinClient,IsLoginonAPPMall,IsLoginonWeiXinClientMall,State,OrderBy,AddDate,WebSiteID,otherInt1,otherInt2,otherStriing1,otherStriing2 ");
            strSql.Append(" FROM SW_UserOauth ");
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
            strSql.Append(" ID,Model,UserID,UserName,UserIDOld,OauthName,OauthUnionid,OauthOpenid,OauthOpenidMall,OauthAccesstoken,IsLoginonAPP,IsLoginonWeiXinClient,IsLoginonAPPMall,IsLoginonWeiXinClientMall,State,OrderBy,AddDate,WebSiteID,otherInt1,otherInt2,otherStriing1,otherStriing2 ");
            strSql.Append(" FROM SW_UserOauth ");
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
            strSql.Append("select count(1) FROM SW_UserOauth ");
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
                strSql = "select top " + endIndex + " * from SW_UserOauth where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserOauth where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserOauth where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserOauth";
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
        public WebSite.Model.Mod_UserOauth GetModelByUserIDandmodel(int UserID, string Model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 ID,Model,UserID,UserName,UserIDOld,OauthName,OauthUnionid,OauthOpenid,OauthOpenidMall,OauthAccesstoken,IsLoginonAPP,IsLoginonWeiXinClient,IsLoginonAPPMall,IsLoginonWeiXinClientMall,State,OrderBy,AddDate,WebSiteID,otherInt1,otherInt2,otherStriing1,otherStriing2 from SW_UserOauth ");
            strSql.Append(" where UserID=@UserID and Model=@Model");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@Model", SqlDbType.VarChar,50)
			};
            parameters[0].Value = UserID;
            parameters[1].Value = Model;
            WebSite.Model.Mod_UserOauth model = new WebSite.Model.Mod_UserOauth();
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

