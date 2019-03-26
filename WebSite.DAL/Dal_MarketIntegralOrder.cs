
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_MarketIntegralOrder
	/// </summary>
	public partial class Dal_MarketIntegralOrder
	{
		public Dal_MarketIntegralOrder()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_MarketIntegralOrder");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_MarketIntegralOrder");
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
        public int Add(WebSite.Model.Mod_MarketIntegralOrder model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_MarketIntegralOrder(");
            strSql.Append("Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserName,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@OrderNo,@UserID,@UserName,@NickName,@UserImage,@UserClass,@MarketID,@MarketTitle,@BUserID,@BUserName,@BUserNickName,@TypeID,@TypeName,@CommentCount,@ReportCount,@FabulousCount,@Integral,@Money,@Payid,@PayName,@IsPay,@PayDate,@PayNo,@PayAmount,@IsLook,@IsLookUser,@State,@OrderBy,@AddDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,200),
					new SqlParameter("@UserClass", SqlDbType.VarChar,50),
					new SqlParameter("@MarketID", SqlDbType.Int,4),
					new SqlParameter("@MarketTitle", SqlDbType.VarChar,200),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,100),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Payid", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.OrderNo;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.NickName;
            parameters[5].Value = model.UserImage;
            parameters[6].Value = model.UserClass;
            parameters[7].Value = model.MarketID;
            parameters[8].Value = model.MarketTitle;
            parameters[9].Value = model.BUserID;
            parameters[10].Value = model.BUserName;
            parameters[11].Value = model.BUserNickName;
            parameters[12].Value = model.TypeID;
            parameters[13].Value = model.TypeName;
            parameters[14].Value = model.CommentCount;
            parameters[15].Value = model.ReportCount;
            parameters[16].Value = model.FabulousCount;
            parameters[17].Value = model.Integral;
            parameters[18].Value = model.Money;
            parameters[19].Value = model.Payid;
            parameters[20].Value = model.PayName;
            parameters[21].Value = model.IsPay;
            parameters[22].Value = model.PayDate;
            parameters[23].Value = model.PayNo;
            parameters[24].Value = model.PayAmount;
            parameters[25].Value = model.IsLook;
            parameters[26].Value = model.IsLookUser;
            parameters[27].Value = model.State;
            parameters[28].Value = model.OrderBy;
            parameters[29].Value = model.AddDate;
            parameters[30].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_MarketIntegralOrder model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_MarketIntegralOrder set ");
            strSql.Append("Model=@Model,");
            strSql.Append("OrderNo=@OrderNo,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("NickName=@NickName,");
            strSql.Append("UserImage=@UserImage,");
            strSql.Append("UserClass=@UserClass,");
            strSql.Append("MarketID=@MarketID,");
            strSql.Append("MarketTitle=@MarketTitle,");
            strSql.Append("BUserID=@BUserID,");
            strSql.Append("BUserName=@BUserName,");
            strSql.Append("BUserNickName=@BUserNickName,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("CommentCount=@CommentCount,");
            strSql.Append("ReportCount=@ReportCount,");
            strSql.Append("FabulousCount=@FabulousCount,");
            strSql.Append("Integral=@Integral,");
            strSql.Append("Money=@Money,");
            strSql.Append("Payid=@Payid,");
            strSql.Append("PayName=@PayName,");
            strSql.Append("IsPay=@IsPay,");
            strSql.Append("PayDate=@PayDate,");
            strSql.Append("PayNo=@PayNo,");
            strSql.Append("PayAmount=@PayAmount,");
            strSql.Append("IsLook=@IsLook,");
            strSql.Append("IsLookUser=@IsLookUser,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,200),
					new SqlParameter("@UserClass", SqlDbType.VarChar,50),
					new SqlParameter("@MarketID", SqlDbType.Int,4),
					new SqlParameter("@MarketTitle", SqlDbType.VarChar,200),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,100),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Payid", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsLookUser", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.OrderNo;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.NickName;
            parameters[5].Value = model.UserImage;
            parameters[6].Value = model.UserClass;
            parameters[7].Value = model.MarketID;
            parameters[8].Value = model.MarketTitle;
            parameters[9].Value = model.BUserID;
            parameters[10].Value = model.BUserName;
            parameters[11].Value = model.BUserNickName;
            parameters[12].Value = model.TypeID;
            parameters[13].Value = model.TypeName;
            parameters[14].Value = model.CommentCount;
            parameters[15].Value = model.ReportCount;
            parameters[16].Value = model.FabulousCount;
            parameters[17].Value = model.Integral;
            parameters[18].Value = model.Money;
            parameters[19].Value = model.Payid;
            parameters[20].Value = model.PayName;
            parameters[21].Value = model.IsPay;
            parameters[22].Value = model.PayDate;
            parameters[23].Value = model.PayNo;
            parameters[24].Value = model.PayAmount;
            parameters[25].Value = model.IsLook;
            parameters[26].Value = model.IsLookUser;
            parameters[27].Value = model.State;
            parameters[28].Value = model.OrderBy;
            parameters[29].Value = model.AddDate;
            parameters[30].Value = model.WebSiteID;
            parameters[31].Value = model.ID;

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
            strSql.Append("delete from SW_MarketIntegralOrder ");
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
            strSql.Append("delete from SW_MarketIntegralOrder ");
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
        public WebSite.Model.Mod_MarketIntegralOrder GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserName,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_MarketIntegralOrder ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_MarketIntegralOrder model = new WebSite.Model.Mod_MarketIntegralOrder();
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
        public WebSite.Model.Mod_MarketIntegralOrder DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_MarketIntegralOrder model = new WebSite.Model.Mod_MarketIntegralOrder();
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
                if (row["OrderNo"] != null)
                {
                    model.OrderNo = row["OrderNo"].ToString();
                }
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["NickName"] != null)
                {
                    model.NickName = row["NickName"].ToString();
                }
                if (row["UserImage"] != null)
                {
                    model.UserImage = row["UserImage"].ToString();
                }
                if (row["UserClass"] != null)
                {
                    model.UserClass = row["UserClass"].ToString();
                }
                if (row["MarketID"] != null && row["MarketID"].ToString() != "")
                {
                    model.MarketID = int.Parse(row["MarketID"].ToString());
                }
                if (row["MarketTitle"] != null)
                {
                    model.MarketTitle = row["MarketTitle"].ToString();
                }
                if (row["BUserID"] != null && row["BUserID"].ToString() != "")
                {
                    model.BUserID = int.Parse(row["BUserID"].ToString());
                }
                if (row["BUserName"] != null)
                {
                    model.BUserName = row["BUserName"].ToString();
                }
                if (row["BUserNickName"] != null)
                {
                    model.BUserNickName = row["BUserNickName"].ToString();
                }
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["TypeName"] != null)
                {
                    model.TypeName = row["TypeName"].ToString();
                }
                if (row["CommentCount"] != null && row["CommentCount"].ToString() != "")
                {
                    model.CommentCount = int.Parse(row["CommentCount"].ToString());
                }
                if (row["ReportCount"] != null && row["ReportCount"].ToString() != "")
                {
                    model.ReportCount = int.Parse(row["ReportCount"].ToString());
                }
                if (row["FabulousCount"] != null && row["FabulousCount"].ToString() != "")
                {
                    model.FabulousCount = int.Parse(row["FabulousCount"].ToString());
                }
                if (row["Integral"] != null && row["Integral"].ToString() != "")
                {
                    model.Integral = int.Parse(row["Integral"].ToString());
                }
                if (row["Money"] != null && row["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(row["Money"].ToString());
                }
                if (row["Payid"] != null && row["Payid"].ToString() != "")
                {
                    model.Payid = int.Parse(row["Payid"].ToString());
                }
                if (row["PayName"] != null)
                {
                    model.PayName = row["PayName"].ToString();
                }
                if (row["IsPay"] != null && row["IsPay"].ToString() != "")
                {
                    model.IsPay = int.Parse(row["IsPay"].ToString());
                }
                if (row["PayDate"] != null && row["PayDate"].ToString() != "")
                {
                    model.PayDate = DateTime.Parse(row["PayDate"].ToString());
                }
                if (row["PayNo"] != null)
                {
                    model.PayNo = row["PayNo"].ToString();
                }
                if (row["PayAmount"] != null && row["PayAmount"].ToString() != "")
                {
                    model.PayAmount = decimal.Parse(row["PayAmount"].ToString());
                }
                if (row["IsLook"] != null && row["IsLook"].ToString() != "")
                {
                    model.IsLook = int.Parse(row["IsLook"].ToString());
                }
                if (row["IsLookUser"] != null && row["IsLookUser"].ToString() != "")
                {
                    model.IsLookUser = int.Parse(row["IsLookUser"].ToString());
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
            strSql.Append("select ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserName,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_MarketIntegralOrder ");
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
            strSql.Append(" ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserName,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_MarketIntegralOrder ");
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
            strSql.Append("select count(1) FROM SW_MarketIntegralOrder ");
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
                strSql = "select top " + endIndex + " * from SW_MarketIntegralOrder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_MarketIntegralOrder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MarketIntegralOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_MarketIntegralOrder";
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
                strSql = "select top " + endIndex + " ID,Model,OrderNo,UserID,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_MarketIntegralOrder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " ID,Model,OrderNo,UserID,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_MarketIntegralOrder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MarketIntegralOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// 卖家的订单积分和
        /// </summary>
        public int GetListByPageAllIntegral(string strWhere)
        {
            string strSql = "";
            strSql = "select  SUM(Integral) from SW_MarketIntegralOrder where  " + strWhere + "";
            object obj = DbHelperSQL.GetSingle(strSql);
            int cmdresult = int.Parse(obj.ToString());
            return cmdresult;
        }
        /// <summary>
        /// 卖家的订单条数
        /// </summary>
        public int GetListByPageAllIntegralCount(string strWhere)
        {
            string strSql = "";
            strSql = "select  count(*) from SW_MarketIntegralOrder where  " + strWhere + "";
            object obj = DbHelperSQL.GetSingle(strSql);
            int cmdresult = int.Parse(obj.ToString());
            return cmdresult;
        }
        /// <summary>
        /// 根据订单号得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_MarketIntegralOrder GetModel(string OrderNo)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,MarketID,MarketTitle,BUserID,BUserName,BUserNickName,TypeID,TypeName,CommentCount,ReportCount,FabulousCount,Integral,Money,Payid,PayName,IsPay,PayDate,PayNo,PayAmount,IsLook,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_MarketIntegralOrder ");
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_MarketIntegralOrder model = new WebSite.Model.Mod_MarketIntegralOrder();
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

