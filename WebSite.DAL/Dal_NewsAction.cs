
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_NewsAction
	/// </summary>
	public partial class Dal_NewsAction
	{
		public Dal_NewsAction()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_NewsAction");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_NewsAction");
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
        public int Add(WebSite.Model.Mod_NewsAction model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_NewsAction(");
            strSql.Append("Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,NewsID,NewsTitle,BUserID,BUserName,BUserNickName,STypeID,STypeName,OtherTypeID,OtherTypeName,AName,AGender,ABirthday,ATelphone,AAddress,AAddressDetail,AContent,BrowseCount,ActionCount,CommentCount,ReportCount,FabulousCount,AIntegral,AMoney,Apayid,ApayName,IsOpen,IsPay,PayDate,PayNo,PayAmount,IsLook,IsReview,IsLookUser,State,OrderBy,AddDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@OrderNo,@UserID,@UserName,@NickName,@UserImage,@UserClass,@NewsID,@NewsTitle,@BUserID,@BUserName,@BUserNickName,@STypeID,@STypeName,@OtherTypeID,@OtherTypeName,@AName,@AGender,@ABirthday,@ATelphone,@AAddress,@AAddressDetail,@AContent,@BrowseCount,@ActionCount,@CommentCount,@ReportCount,@FabulousCount,@AIntegral,@AMoney,@Apayid,@ApayName,@IsOpen,@IsPay,@PayDate,@PayNo,@PayAmount,@IsLook,@IsReview,@IsLookUser,@State,@OrderBy,@AddDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,200),
					new SqlParameter("@UserClass", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeName", SqlDbType.VarChar,100),
					new SqlParameter("@OtherTypeID", SqlDbType.Int,4),
					new SqlParameter("@OtherTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@AName", SqlDbType.VarChar,200),
					new SqlParameter("@AGender", SqlDbType.VarChar,50),
					new SqlParameter("@ABirthday", SqlDbType.DateTime),
					new SqlParameter("@ATelphone", SqlDbType.VarChar,200),
					new SqlParameter("@AAddress", SqlDbType.VarChar,100),
					new SqlParameter("@AAddressDetail", SqlDbType.VarChar,200),
					new SqlParameter("@AContent", SqlDbType.NText),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@AIntegral", SqlDbType.Int,4),
					new SqlParameter("@AMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Apayid", SqlDbType.Int,4),
					new SqlParameter("@ApayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsOpen", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
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
            parameters[7].Value = model.NewsID;
            parameters[8].Value = model.NewsTitle;
            parameters[9].Value = model.BUserID;
            parameters[10].Value = model.BUserName;
            parameters[11].Value = model.BUserNickName;
            parameters[12].Value = model.STypeID;
            parameters[13].Value = model.STypeName;
            parameters[14].Value = model.OtherTypeID;
            parameters[15].Value = model.OtherTypeName;
            parameters[16].Value = model.AName;
            parameters[17].Value = model.AGender;
            parameters[18].Value = model.ABirthday;
            parameters[19].Value = model.ATelphone;
            parameters[20].Value = model.AAddress;
            parameters[21].Value = model.AAddressDetail;
            parameters[22].Value = model.AContent;
            parameters[23].Value = model.BrowseCount;
            parameters[24].Value = model.ActionCount;
            parameters[25].Value = model.CommentCount;
            parameters[26].Value = model.ReportCount;
            parameters[27].Value = model.FabulousCount;
            parameters[28].Value = model.AIntegral;
            parameters[29].Value = model.AMoney;
            parameters[30].Value = model.Apayid;
            parameters[31].Value = model.ApayName;
            parameters[32].Value = model.IsOpen;
            parameters[33].Value = model.IsPay;
            parameters[34].Value = model.PayDate;
            parameters[35].Value = model.PayNo;
            parameters[36].Value = model.PayAmount;
            parameters[37].Value = model.IsLook;
            parameters[38].Value = model.IsReview;
            parameters[39].Value = model.IsLookUser;
            parameters[40].Value = model.State;
            parameters[41].Value = model.OrderBy;
            parameters[42].Value = model.AddDate;
            parameters[43].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_NewsAction model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_NewsAction set ");
            strSql.Append("Model=@Model,");
            strSql.Append("OrderNo=@OrderNo,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("NickName=@NickName,");
            strSql.Append("UserImage=@UserImage,");
            strSql.Append("UserClass=@UserClass,");
            strSql.Append("NewsID=@NewsID,");
            strSql.Append("NewsTitle=@NewsTitle,");
            strSql.Append("BUserID=@BUserID,");
            strSql.Append("BUserName=@BUserName,");
            strSql.Append("BUserNickName=@BUserNickName,");
            strSql.Append("STypeID=@STypeID,");
            strSql.Append("STypeName=@STypeName,");
            strSql.Append("OtherTypeID=@OtherTypeID,");
            strSql.Append("OtherTypeName=@OtherTypeName,");
            strSql.Append("AName=@AName,");
            strSql.Append("AGender=@AGender,");
            strSql.Append("ABirthday=@ABirthday,");
            strSql.Append("ATelphone=@ATelphone,");
            strSql.Append("AAddress=@AAddress,");
            strSql.Append("AAddressDetail=@AAddressDetail,");
            strSql.Append("AContent=@AContent,");
            strSql.Append("BrowseCount=@BrowseCount,");
            strSql.Append("ActionCount=@ActionCount,");
            strSql.Append("CommentCount=@CommentCount,");
            strSql.Append("ReportCount=@ReportCount,");
            strSql.Append("FabulousCount=@FabulousCount,");
            strSql.Append("AIntegral=@AIntegral,");
            strSql.Append("AMoney=@AMoney,");
            strSql.Append("Apayid=@Apayid,");
            strSql.Append("ApayName=@ApayName,");
            strSql.Append("IsOpen=@IsOpen,");
            strSql.Append("IsPay=@IsPay,");
            strSql.Append("PayDate=@PayDate,");
            strSql.Append("PayNo=@PayNo,");
            strSql.Append("PayAmount=@PayAmount,");
            strSql.Append("IsLook=@IsLook,");
            strSql.Append("IsReview=@IsReview,");
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
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@BUserID", SqlDbType.Int,4),
					new SqlParameter("@BUserName", SqlDbType.VarChar,200),
					new SqlParameter("@BUserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeName", SqlDbType.VarChar,100),
					new SqlParameter("@OtherTypeID", SqlDbType.Int,4),
					new SqlParameter("@OtherTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@AName", SqlDbType.VarChar,200),
					new SqlParameter("@AGender", SqlDbType.VarChar,50),
					new SqlParameter("@ABirthday", SqlDbType.DateTime),
					new SqlParameter("@ATelphone", SqlDbType.VarChar,200),
					new SqlParameter("@AAddress", SqlDbType.VarChar,100),
					new SqlParameter("@AAddressDetail", SqlDbType.VarChar,200),
					new SqlParameter("@AContent", SqlDbType.NText),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@AIntegral", SqlDbType.Int,4),
					new SqlParameter("@AMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Apayid", SqlDbType.Int,4),
					new SqlParameter("@ApayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsOpen", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
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
            parameters[7].Value = model.NewsID;
            parameters[8].Value = model.NewsTitle;
            parameters[9].Value = model.BUserID;
            parameters[10].Value = model.BUserName;
            parameters[11].Value = model.BUserNickName;
            parameters[12].Value = model.STypeID;
            parameters[13].Value = model.STypeName;
            parameters[14].Value = model.OtherTypeID;
            parameters[15].Value = model.OtherTypeName;
            parameters[16].Value = model.AName;
            parameters[17].Value = model.AGender;
            parameters[18].Value = model.ABirthday;
            parameters[19].Value = model.ATelphone;
            parameters[20].Value = model.AAddress;
            parameters[21].Value = model.AAddressDetail;
            parameters[22].Value = model.AContent;
            parameters[23].Value = model.BrowseCount;
            parameters[24].Value = model.ActionCount;
            parameters[25].Value = model.CommentCount;
            parameters[26].Value = model.ReportCount;
            parameters[27].Value = model.FabulousCount;
            parameters[28].Value = model.AIntegral;
            parameters[29].Value = model.AMoney;
            parameters[30].Value = model.Apayid;
            parameters[31].Value = model.ApayName;
            parameters[32].Value = model.IsOpen;
            parameters[33].Value = model.IsPay;
            parameters[34].Value = model.PayDate;
            parameters[35].Value = model.PayNo;
            parameters[36].Value = model.PayAmount;
            parameters[37].Value = model.IsLook;
            parameters[38].Value = model.IsReview;
            parameters[39].Value = model.IsLookUser;
            parameters[40].Value = model.State;
            parameters[41].Value = model.OrderBy;
            parameters[42].Value = model.AddDate;
            parameters[43].Value = model.WebSiteID;
            parameters[44].Value = model.ID;

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
            strSql.Append("delete from SW_NewsAction ");
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
            strSql.Append("delete from SW_NewsAction ");
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
        public WebSite.Model.Mod_NewsAction GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,NewsID,NewsTitle,BUserID,BUserName,BUserNickName,STypeID,STypeName,OtherTypeID,OtherTypeName,AName,AGender,ABirthday,ATelphone,AAddress,AAddressDetail,AContent,BrowseCount,ActionCount,CommentCount,ReportCount,FabulousCount,AIntegral,AMoney,Apayid,ApayName,IsOpen,IsPay,PayDate,PayNo,PayAmount,IsLook,IsReview,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_NewsAction ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_NewsAction model = new WebSite.Model.Mod_NewsAction();
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
        public WebSite.Model.Mod_NewsAction DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_NewsAction model = new WebSite.Model.Mod_NewsAction();
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
                if (row["NewsID"] != null && row["NewsID"].ToString() != "")
                {
                    model.NewsID = int.Parse(row["NewsID"].ToString());
                }
                if (row["NewsTitle"] != null)
                {
                    model.NewsTitle = row["NewsTitle"].ToString();
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
                if (row["STypeID"] != null && row["STypeID"].ToString() != "")
                {
                    model.STypeID = int.Parse(row["STypeID"].ToString());
                }
                if (row["STypeName"] != null)
                {
                    model.STypeName = row["STypeName"].ToString();
                }
                if (row["OtherTypeID"] != null && row["OtherTypeID"].ToString() != "")
                {
                    model.OtherTypeID = int.Parse(row["OtherTypeID"].ToString());
                }
                if (row["OtherTypeName"] != null)
                {
                    model.OtherTypeName = row["OtherTypeName"].ToString();
                }
                if (row["AName"] != null)
                {
                    model.AName = row["AName"].ToString();
                }
                if (row["AGender"] != null)
                {
                    model.AGender = row["AGender"].ToString();
                }
                if (row["ABirthday"] != null && row["ABirthday"].ToString() != "")
                {
                    model.ABirthday = DateTime.Parse(row["ABirthday"].ToString());
                }
                if (row["ATelphone"] != null)
                {
                    model.ATelphone = row["ATelphone"].ToString();
                }
                if (row["AAddress"] != null)
                {
                    model.AAddress = row["AAddress"].ToString();
                }
                if (row["AAddressDetail"] != null)
                {
                    model.AAddressDetail = row["AAddressDetail"].ToString();
                }
                if (row["AContent"] != null)
                {
                    model.AContent = row["AContent"].ToString();
                }
                if (row["BrowseCount"] != null && row["BrowseCount"].ToString() != "")
                {
                    model.BrowseCount = int.Parse(row["BrowseCount"].ToString());
                }
                if (row["ActionCount"] != null && row["ActionCount"].ToString() != "")
                {
                    model.ActionCount = int.Parse(row["ActionCount"].ToString());
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
                if (row["AIntegral"] != null && row["AIntegral"].ToString() != "")
                {
                    model.AIntegral = int.Parse(row["AIntegral"].ToString());
                }
                if (row["AMoney"] != null && row["AMoney"].ToString() != "")
                {
                    model.AMoney = decimal.Parse(row["AMoney"].ToString());
                }
                if (row["Apayid"] != null && row["Apayid"].ToString() != "")
                {
                    model.Apayid = int.Parse(row["Apayid"].ToString());
                }
                if (row["ApayName"] != null)
                {
                    model.ApayName = row["ApayName"].ToString();
                }
                if (row["IsOpen"] != null && row["IsOpen"].ToString() != "")
                {
                    model.IsOpen = int.Parse(row["IsOpen"].ToString());
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
                if (row["IsReview"] != null && row["IsReview"].ToString() != "")
                {
                    model.IsReview = int.Parse(row["IsReview"].ToString());
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
            strSql.Append("select ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,NewsID,NewsTitle,BUserID,BUserName,BUserNickName,STypeID,STypeName,OtherTypeID,OtherTypeName,AName,AGender,ABirthday,ATelphone,AAddress,AAddressDetail,AContent,BrowseCount,ActionCount,CommentCount,ReportCount,FabulousCount,AIntegral,AMoney,Apayid,ApayName,IsOpen,IsPay,PayDate,PayNo,PayAmount,IsLook,IsReview,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_NewsAction ");
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
            strSql.Append(" ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,NewsID,NewsTitle,BUserID,BUserName,BUserNickName,STypeID,STypeName,OtherTypeID,OtherTypeName,AName,AGender,ABirthday,ATelphone,AAddress,AAddressDetail,AContent,BrowseCount,ActionCount,CommentCount,ReportCount,FabulousCount,AIntegral,AMoney,Apayid,ApayName,IsOpen,IsPay,PayDate,PayNo,PayAmount,IsLook,IsReview,IsLookUser,State,OrderBy,AddDate,WebSiteID ");
            strSql.Append(" FROM SW_NewsAction ");
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
            strSql.Append("select count(1) FROM SW_NewsAction ");
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
                strSql = "select top " + endIndex + " * from SW_NewsAction where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_NewsAction where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_NewsAction where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_NewsAction";
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
        /// 根据订单号得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_NewsAction GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,NickName,UserImage,UserClass,NewsID,NewsTitle,BUserID,BUserName,BUserNickName,STypeID,STypeName,OtherTypeID,OtherTypeName,AName,AGender,ABirthday,ATelphone,AAddress,AAddressDetail,AContent,BrowseCount,ActionCount,CommentCount,ReportCount,FabulousCount,AIntegral,AMoney,Apayid,ApayName,IsOpen,IsPay,PayDate,PayNo,PayAmount,IsLook,IsReview,IsLookUser,State,OrderBy,AddDate,WebSiteID from SW_NewsAction  ");
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_NewsAction model = new WebSite.Model.Mod_NewsAction();
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

