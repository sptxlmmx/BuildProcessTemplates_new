
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_FreeBroker
	/// </summary>
	public partial class Dal_FreeBroker
	{
		public Dal_FreeBroker()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_FreeBroker");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_FreeBroker");
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
        public int Add(WebSite.Model.Mod_FreeBroker model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_FreeBroker(");
            strSql.Append("UserID,UserNickName,LevelID,LevelIDTitle,FreeBrokerName,FreeBrokerTel,FreeBrokerEmail,FreeBrokerWeiXin,ProvinceID,Province,CityID,City,AreaID,Area,Content1,IsFreeBroker,IsReview,ParentID,ParentIDTwo,ParentIDThree,IDPath,ShopCount,State,OrderBy,AddDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@UserID,@UserNickName,@LevelID,@LevelIDTitle,@FreeBrokerName,@FreeBrokerTel,@FreeBrokerEmail,@FreeBrokerWeiXin,@ProvinceID,@Province,@CityID,@City,@AreaID,@Area,@Content1,@IsFreeBroker,@IsReview,@ParentID,@ParentIDTwo,@ParentIDThree,@IDPath,@ShopCount,@State,@OrderBy,@AddDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelIDTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerName", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerTel", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerEmail", SqlDbType.VarChar,100),
					new SqlParameter("@FreeBrokerWeiXin", SqlDbType.VarChar,50),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsFreeBroker", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@ParentIDTwo", SqlDbType.Int,4),
					new SqlParameter("@ParentIDThree", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@ShopCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.UserNickName;
            parameters[2].Value = model.LevelID;
            parameters[3].Value = model.LevelIDTitle;
            parameters[4].Value = model.FreeBrokerName;
            parameters[5].Value = model.FreeBrokerTel;
            parameters[6].Value = model.FreeBrokerEmail;
            parameters[7].Value = model.FreeBrokerWeiXin;
            parameters[8].Value = model.ProvinceID;
            parameters[9].Value = model.Province;
            parameters[10].Value = model.CityID;
            parameters[11].Value = model.City;
            parameters[12].Value = model.AreaID;
            parameters[13].Value = model.Area;
            parameters[14].Value = model.Content1;
            parameters[15].Value = model.IsFreeBroker;
            parameters[16].Value = model.IsReview;
            parameters[17].Value = model.ParentID;
            parameters[18].Value = model.ParentIDTwo;
            parameters[19].Value = model.ParentIDThree;
            parameters[20].Value = model.IDPath;
            parameters[21].Value = model.ShopCount;
            parameters[22].Value = model.State;
            parameters[23].Value = model.OrderBy;
            parameters[24].Value = model.AddDate;
            parameters[25].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_FreeBroker model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_FreeBroker set ");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("LevelID=@LevelID,");
            strSql.Append("LevelIDTitle=@LevelIDTitle,");
            strSql.Append("FreeBrokerName=@FreeBrokerName,");
            strSql.Append("FreeBrokerTel=@FreeBrokerTel,");
            strSql.Append("FreeBrokerEmail=@FreeBrokerEmail,");
            strSql.Append("FreeBrokerWeiXin=@FreeBrokerWeiXin,");
            strSql.Append("ProvinceID=@ProvinceID,");
            strSql.Append("Province=@Province,");
            strSql.Append("CityID=@CityID,");
            strSql.Append("City=@City,");
            strSql.Append("AreaID=@AreaID,");
            strSql.Append("Area=@Area,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("IsFreeBroker=@IsFreeBroker,");
            strSql.Append("IsReview=@IsReview,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("ParentIDTwo=@ParentIDTwo,");
            strSql.Append("ParentIDThree=@ParentIDThree,");
            strSql.Append("IDPath=@IDPath,");
            strSql.Append("ShopCount=@ShopCount,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelIDTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerName", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerTel", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerEmail", SqlDbType.VarChar,100),
					new SqlParameter("@FreeBrokerWeiXin", SqlDbType.VarChar,50),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsFreeBroker", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@ParentIDTwo", SqlDbType.Int,4),
					new SqlParameter("@ParentIDThree", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@ShopCount", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.UserNickName;
            parameters[2].Value = model.LevelID;
            parameters[3].Value = model.LevelIDTitle;
            parameters[4].Value = model.FreeBrokerName;
            parameters[5].Value = model.FreeBrokerTel;
            parameters[6].Value = model.FreeBrokerEmail;
            parameters[7].Value = model.FreeBrokerWeiXin;
            parameters[8].Value = model.ProvinceID;
            parameters[9].Value = model.Province;
            parameters[10].Value = model.CityID;
            parameters[11].Value = model.City;
            parameters[12].Value = model.AreaID;
            parameters[13].Value = model.Area;
            parameters[14].Value = model.Content1;
            parameters[15].Value = model.IsFreeBroker;
            parameters[16].Value = model.IsReview;
            parameters[17].Value = model.ParentID;
            parameters[18].Value = model.ParentIDTwo;
            parameters[19].Value = model.ParentIDThree;
            parameters[20].Value = model.IDPath;
            parameters[21].Value = model.ShopCount;
            parameters[22].Value = model.State;
            parameters[23].Value = model.OrderBy;
            parameters[24].Value = model.AddDate;
            parameters[25].Value = model.WebSiteID;
            parameters[26].Value = model.ID;

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
            strSql.Append("delete from SW_FreeBroker ");
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
            strSql.Append("delete from SW_FreeBroker ");
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
        public WebSite.Model.Mod_FreeBroker GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,UserID,UserNickName,LevelID,LevelIDTitle,FreeBrokerName,FreeBrokerTel,FreeBrokerEmail,FreeBrokerWeiXin,ProvinceID,Province,CityID,City,AreaID,Area,Content1,IsFreeBroker,IsReview,ParentID,ParentIDTwo,ParentIDThree,IDPath,ShopCount,State,OrderBy,AddDate,WebSiteID from SW_FreeBroker ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_FreeBroker model = new WebSite.Model.Mod_FreeBroker();
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
        public WebSite.Model.Mod_FreeBroker DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_FreeBroker model = new WebSite.Model.Mod_FreeBroker();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["UserNickName"] != null)
                {
                    model.UserNickName = row["UserNickName"].ToString();
                }
                if (row["LevelID"] != null && row["LevelID"].ToString() != "")
                {
                    model.LevelID = int.Parse(row["LevelID"].ToString());
                }
                if (row["LevelIDTitle"] != null)
                {
                    model.LevelIDTitle = row["LevelIDTitle"].ToString();
                }
                if (row["FreeBrokerName"] != null)
                {
                    model.FreeBrokerName = row["FreeBrokerName"].ToString();
                }
                if (row["FreeBrokerTel"] != null)
                {
                    model.FreeBrokerTel = row["FreeBrokerTel"].ToString();
                }
                if (row["FreeBrokerEmail"] != null)
                {
                    model.FreeBrokerEmail = row["FreeBrokerEmail"].ToString();
                }
                if (row["FreeBrokerWeiXin"] != null)
                {
                    model.FreeBrokerWeiXin = row["FreeBrokerWeiXin"].ToString();
                }
                if (row["ProvinceID"] != null && row["ProvinceID"].ToString() != "")
                {
                    model.ProvinceID = int.Parse(row["ProvinceID"].ToString());
                }
                if (row["Province"] != null)
                {
                    model.Province = row["Province"].ToString();
                }
                if (row["CityID"] != null && row["CityID"].ToString() != "")
                {
                    model.CityID = int.Parse(row["CityID"].ToString());
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["AreaID"] != null && row["AreaID"].ToString() != "")
                {
                    model.AreaID = int.Parse(row["AreaID"].ToString());
                }
                if (row["Area"] != null)
                {
                    model.Area = row["Area"].ToString();
                }
                if (row["Content1"] != null)
                {
                    model.Content1 = row["Content1"].ToString();
                }
                if (row["IsFreeBroker"] != null && row["IsFreeBroker"].ToString() != "")
                {
                    model.IsFreeBroker = int.Parse(row["IsFreeBroker"].ToString());
                }
                if (row["IsReview"] != null && row["IsReview"].ToString() != "")
                {
                    model.IsReview = int.Parse(row["IsReview"].ToString());
                }
                if (row["ParentID"] != null && row["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(row["ParentID"].ToString());
                }
                if (row["ParentIDTwo"] != null && row["ParentIDTwo"].ToString() != "")
                {
                    model.ParentIDTwo = int.Parse(row["ParentIDTwo"].ToString());
                }
                if (row["ParentIDThree"] != null && row["ParentIDThree"].ToString() != "")
                {
                    model.ParentIDThree = int.Parse(row["ParentIDThree"].ToString());
                }
                if (row["IDPath"] != null)
                {
                    model.IDPath = row["IDPath"].ToString();
                }
                if (row["ShopCount"] != null && row["ShopCount"].ToString() != "")
                {
                    model.ShopCount = int.Parse(row["ShopCount"].ToString());
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserID,UserNickName,LevelID,LevelIDTitle,FreeBrokerName,FreeBrokerTel,FreeBrokerEmail,FreeBrokerWeiXin,ProvinceID,Province,CityID,City,AreaID,Area,Content1,IsFreeBroker,IsReview,ParentID,ParentIDTwo,ParentIDThree,IDPath,ShopCount,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_FreeBroker ");
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
            strSql.Append(" ID,UserID,UserNickName,LevelID,LevelIDTitle,FreeBrokerName,FreeBrokerTel,FreeBrokerEmail,FreeBrokerWeiXin,ProvinceID,Province,CityID,City,AreaID,Area,Content1,IsFreeBroker,IsReview,ParentID,ParentIDTwo,ParentIDThree,IDPath,ShopCount,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_FreeBroker ");
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
            strSql.Append("select count(1) FROM SW_FreeBroker ");
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
                strSql = "select top " + endIndex + " * from SW_FreeBroker where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_FreeBroker where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_FreeBroker where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_FreeBroker";
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
        public WebSite.Model.Mod_FreeBroker GetModelbyUserID(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,UserID,UserNickName,LevelID,LevelIDTitle,FreeBrokerName,FreeBrokerTel,FreeBrokerEmail,FreeBrokerWeiXin,ProvinceID,Province,CityID,City,AreaID,Area,Content1,IsFreeBroker,IsReview,ParentID,ParentIDTwo,ParentIDThree,IDPath,ShopCount,State,OrderBy,AddDate,WebSiteID from SW_FreeBroker ");            
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            WebSite.Model.Mod_FreeBroker model = new WebSite.Model.Mod_FreeBroker();
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
        /// 获取经纪人以及 经纪人邀请的经纪人
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
                strSql = "select top " + endIndex + "  SW_User.NiceName,SW_FreeBroker.* from SW_FreeBroker left join SW_User on SW_FreeBroker.ParentID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + "  SW_User.NiceName,SW_FreeBroker.*  from SW_FreeBroker left join SW_User on SW_FreeBroker.ParentID=SW_User.ID where  " + strWhere + " and  SW_FreeBroker.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_FreeBroker.ID from SW_FreeBroker where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
		#endregion  ExtensionMethod
	}
}

