using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;

namespace WebSite.DAL
{/// <summary>
    /// 数据访问类:Dal_LiveUser
    /// </summary>
    public partial class Dal_LiveUser
    {
        public Dal_LiveUser()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_LiveUser");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_LiveUser");
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
        public int Add(WebSite.Model.Mod_LiveUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_LiveUser(");
            strSql.Append("userID,userName,niceName,token,roomid,cid,ctime,pushUrl,httpPullUrl,hlsPullUrl,rtmpPullUrl,type,esString1,esString2,esString3,esString4,State,AddDate,ModifyDate,OrderBy)");
            strSql.Append(" values (");
            strSql.Append("@userID,@userName,@niceName,@token,@roomid,@cid,@ctime,@pushUrl,@httpPullUrl,@hlsPullUrl,@rtmpPullUrl,@type,@esString1,@esString2,@esString3,@esString4,@State,@AddDate,@ModifyDate,@OrderBy)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,200),
					new SqlParameter("@niceName", SqlDbType.NVarChar,200),
					new SqlParameter("@token", SqlDbType.NVarChar,300),
					new SqlParameter("@roomid", SqlDbType.NVarChar,100),
					new SqlParameter("@cid", SqlDbType.NVarChar,100),
					new SqlParameter("@ctime", SqlDbType.NVarChar,100),
					new SqlParameter("@pushUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@httpPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@hlsPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@rtmpPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@esString1", SqlDbType.NVarChar,200),
					new SqlParameter("@esString2", SqlDbType.NVarChar,200),
					new SqlParameter("@esString3", SqlDbType.NVarChar,500),
					new SqlParameter("@esString4", SqlDbType.NVarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4)};
            parameters[0].Value = model.userID;
            parameters[1].Value = model.userName;
            parameters[2].Value = model.niceName;
            parameters[3].Value = model.token;
            parameters[4].Value = model.roomid;
            parameters[5].Value = model.cid;
            parameters[6].Value = model.ctime;
            parameters[7].Value = model.pushUrl;
            parameters[8].Value = model.httpPullUrl;
            parameters[9].Value = model.hlsPullUrl;
            parameters[10].Value = model.rtmpPullUrl;
            parameters[11].Value = model.type;
            parameters[12].Value = model.esString1;
            parameters[13].Value = model.esString2;
            parameters[14].Value = model.esString3;
            parameters[15].Value = model.esString4;
            parameters[16].Value = model.State;
            parameters[17].Value = model.AddDate;
            parameters[18].Value = model.ModifyDate;
            parameters[19].Value = model.OrderBy;

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
        public bool Update(WebSite.Model.Mod_LiveUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_LiveUser set ");
            strSql.Append("userID=@userID,");
            strSql.Append("userName=@userName,");
            strSql.Append("niceName=@niceName,");
            strSql.Append("token=@token,");
            strSql.Append("roomid=@roomid,");
            strSql.Append("cid=@cid,");
            strSql.Append("ctime=@ctime,");
            strSql.Append("pushUrl=@pushUrl,");
            strSql.Append("httpPullUrl=@httpPullUrl,");
            strSql.Append("hlsPullUrl=@hlsPullUrl,");
            strSql.Append("rtmpPullUrl=@rtmpPullUrl,");
            strSql.Append("type=@type,");
            strSql.Append("esString1=@esString1,");
            strSql.Append("esString2=@esString2,");
            strSql.Append("esString3=@esString3,");
            strSql.Append("esString4=@esString4,");
            strSql.Append("State=@State,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("OrderBy=@OrderBy");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,200),
					new SqlParameter("@niceName", SqlDbType.NVarChar,200),
					new SqlParameter("@token", SqlDbType.NVarChar,300),
					new SqlParameter("@roomid", SqlDbType.NVarChar,100),
					new SqlParameter("@cid", SqlDbType.NVarChar,100),
					new SqlParameter("@ctime", SqlDbType.NVarChar,100),
					new SqlParameter("@pushUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@httpPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@hlsPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@rtmpPullUrl", SqlDbType.NVarChar,300),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@esString1", SqlDbType.NVarChar,200),
					new SqlParameter("@esString2", SqlDbType.NVarChar,200),
					new SqlParameter("@esString3", SqlDbType.NVarChar,500),
					new SqlParameter("@esString4", SqlDbType.NVarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.userID;
            parameters[1].Value = model.userName;
            parameters[2].Value = model.niceName;
            parameters[3].Value = model.token;
            parameters[4].Value = model.roomid;
            parameters[5].Value = model.cid;
            parameters[6].Value = model.ctime;
            parameters[7].Value = model.pushUrl;
            parameters[8].Value = model.httpPullUrl;
            parameters[9].Value = model.hlsPullUrl;
            parameters[10].Value = model.rtmpPullUrl;
            parameters[11].Value = model.type;
            parameters[12].Value = model.esString1;
            parameters[13].Value = model.esString2;
            parameters[14].Value = model.esString3;
            parameters[15].Value = model.esString4;
            parameters[16].Value = model.State;
            parameters[17].Value = model.AddDate;
            parameters[18].Value = model.ModifyDate;
            parameters[19].Value = model.OrderBy;
            parameters[20].Value = model.ID;

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
            strSql.Append("delete from SW_LiveUser ");
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
            strSql.Append("delete from SW_LiveUser ");
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
        public WebSite.Model.Mod_LiveUser GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,userID,userName,niceName,token,roomid,cid,ctime,pushUrl,httpPullUrl,hlsPullUrl,rtmpPullUrl,type,esString1,esString2,esString3,esString4,State,AddDate,ModifyDate,OrderBy from SW_LiveUser ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_LiveUser model = new WebSite.Model.Mod_LiveUser();
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
        public WebSite.Model.Mod_LiveUser DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_LiveUser model = new WebSite.Model.Mod_LiveUser();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["userID"] != null && row["userID"].ToString() != "")
                {
                    model.userID = int.Parse(row["userID"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["niceName"] != null)
                {
                    model.niceName = row["niceName"].ToString();
                }
                if (row["token"] != null)
                {
                    model.token = row["token"].ToString();
                }
                if (row["roomid"] != null)
                {
                    model.roomid = row["roomid"].ToString();
                }
                if (row["cid"] != null)
                {
                    model.cid = row["cid"].ToString();
                }
                if (row["ctime"] != null)
                {
                    model.ctime = row["ctime"].ToString();
                }
                if (row["pushUrl"] != null)
                {
                    model.pushUrl = row["pushUrl"].ToString();
                }
                if (row["httpPullUrl"] != null)
                {
                    model.httpPullUrl = row["httpPullUrl"].ToString();
                }
                if (row["hlsPullUrl"] != null)
                {
                    model.hlsPullUrl = row["hlsPullUrl"].ToString();
                }
                if (row["rtmpPullUrl"] != null)
                {
                    model.rtmpPullUrl = row["rtmpPullUrl"].ToString();
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if (row["esString1"] != null)
                {
                    model.esString1 = row["esString1"].ToString();
                }
                if (row["esString2"] != null)
                {
                    model.esString2 = row["esString2"].ToString();
                }
                if (row["esString3"] != null)
                {
                    model.esString3 = row["esString3"].ToString();
                }
                if (row["esString4"] != null)
                {
                    model.esString4 = row["esString4"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
                {
                    model.ModifyDate = DateTime.Parse(row["ModifyDate"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
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
            strSql.Append("select ID,userID,userName,niceName,token,roomid,cid,ctime,pushUrl,httpPullUrl,hlsPullUrl,rtmpPullUrl,type,esString1,esString2,esString3,esString4,State,AddDate,ModifyDate,OrderBy ");
            strSql.Append(" FROM SW_LiveUser ");
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
            strSql.Append(" ID,userID,userName,niceName,token,roomid,cid,ctime,pushUrl,httpPullUrl,hlsPullUrl,rtmpPullUrl,type,esString1,esString2,esString3,esString4,State,AddDate,ModifyDate,OrderBy ");
            strSql.Append(" FROM SW_LiveUser ");
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
            strSql.Append("select count(1) FROM SW_LiveUser ");
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
                strSql = "select top " + endIndex + " * from SW_LiveUser where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_LiveUser where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_LiveUser where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_LiveUser";
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
        public WebSite.Model.Mod_LiveUser GetUserIDModel(int userID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,userID,userName,niceName,token,roomid,cid,ctime,pushUrl,httpPullUrl,hlsPullUrl,rtmpPullUrl,type,esString1,esString2,esString3,esString4,State,AddDate,ModifyDate,OrderBy from SW_LiveUser ");
            strSql.Append(" where userID=@userID");
            SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
			};
            parameters[0].Value = userID;

            WebSite.Model.Mod_LiveUser model = new WebSite.Model.Mod_LiveUser();
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
