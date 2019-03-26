using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Admin_User
	/// </summary>
	public partial class Dal_Admin_User
	{
		public Dal_Admin_User()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_Admin_User");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Admin_User");
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
        public int Add(WebSite.Model.Mod_Admin_User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_Admin_User(");
            strSql.Append("RoleID,UserName,Password,PasswordChangeCode,RealName,Sex,Tel,Mobile,QQ,Email,Department,Job,UserIDs,OtherIDs,State,AddDate,CreateIP,OrderBy,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@RoleID,@UserName,@Password,@PasswordChangeCode,@RealName,@Sex,@Tel,@Mobile,@QQ,@Email,@Department,@Job,@UserIDs,@OtherIDs,@State,@AddDate,@CreateIP,@OrderBy,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PasswordChangeCode", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@QQ", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@Job", SqlDbType.VarChar,200),
					new SqlParameter("@UserIDs", SqlDbType.Text),
					new SqlParameter("@OtherIDs", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@CreateIP", SqlDbType.VarChar,50),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.RoleID;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.Password;
            parameters[3].Value = model.PasswordChangeCode;
            parameters[4].Value = model.RealName;
            parameters[5].Value = model.Sex;
            parameters[6].Value = model.Tel;
            parameters[7].Value = model.Mobile;
            parameters[8].Value = model.QQ;
            parameters[9].Value = model.Email;
            parameters[10].Value = model.Department;
            parameters[11].Value = model.Job;
            parameters[12].Value = model.UserIDs;
            parameters[13].Value = model.OtherIDs;
            parameters[14].Value = model.State;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.CreateIP;
            parameters[17].Value = model.OrderBy;
            parameters[18].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_Admin_User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Admin_User set ");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Password=@Password,");
            strSql.Append("PasswordChangeCode=@PasswordChangeCode,");
            strSql.Append("RealName=@RealName,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("Email=@Email,");
            strSql.Append("Department=@Department,");
            strSql.Append("Job=@Job,");
            strSql.Append("UserIDs=@UserIDs,");
            strSql.Append("OtherIDs=@OtherIDs,");
            strSql.Append("State=@State,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("CreateIP=@CreateIP,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PasswordChangeCode", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@QQ", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@Job", SqlDbType.VarChar,200),
					new SqlParameter("@UserIDs", SqlDbType.Text),
					new SqlParameter("@OtherIDs", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@CreateIP", SqlDbType.VarChar,50),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.RoleID;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.Password;
            parameters[3].Value = model.PasswordChangeCode;
            parameters[4].Value = model.RealName;
            parameters[5].Value = model.Sex;
            parameters[6].Value = model.Tel;
            parameters[7].Value = model.Mobile;
            parameters[8].Value = model.QQ;
            parameters[9].Value = model.Email;
            parameters[10].Value = model.Department;
            parameters[11].Value = model.Job;
            parameters[12].Value = model.UserIDs;
            parameters[13].Value = model.OtherIDs;
            parameters[14].Value = model.State;
            parameters[15].Value = model.AddDate;
            parameters[16].Value = model.CreateIP;
            parameters[17].Value = model.OrderBy;
            parameters[18].Value = model.WebSiteID;
            parameters[19].Value = model.ID;

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
            strSql.Append("delete from SW_Admin_User ");
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
            strSql.Append("delete from SW_Admin_User ");
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
        public WebSite.Model.Mod_Admin_User GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,RoleID,UserName,Password,PasswordChangeCode,RealName,Sex,Tel,Mobile,QQ,Email,Department,Job,UserIDs,OtherIDs,State,AddDate,CreateIP,OrderBy,WebSiteID from SW_Admin_User ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_Admin_User model = new WebSite.Model.Mod_Admin_User();
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
        public WebSite.Model.Mod_Admin_User DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_Admin_User model = new WebSite.Model.Mod_Admin_User();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["RoleID"] != null && row["RoleID"].ToString() != "")
                {
                    model.RoleID = int.Parse(row["RoleID"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["PasswordChangeCode"] != null)
                {
                    model.PasswordChangeCode = row["PasswordChangeCode"].ToString();
                }
                if (row["RealName"] != null)
                {
                    model.RealName = row["RealName"].ToString();
                }
                if (row["Sex"] != null)
                {
                    model.Sex = row["Sex"].ToString();
                }
                if (row["Tel"] != null)
                {
                    model.Tel = row["Tel"].ToString();
                }
                if (row["Mobile"] != null)
                {
                    model.Mobile = row["Mobile"].ToString();
                }
                if (row["QQ"] != null)
                {
                    model.QQ = row["QQ"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["Department"] != null)
                {
                    model.Department = row["Department"].ToString();
                }
                if (row["Job"] != null)
                {
                    model.Job = row["Job"].ToString();
                }
                if (row["UserIDs"] != null)
                {
                    model.UserIDs = row["UserIDs"].ToString();
                }
                if (row["OtherIDs"] != null)
                {
                    model.OtherIDs = row["OtherIDs"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["CreateIP"] != null)
                {
                    model.CreateIP = row["CreateIP"].ToString();
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
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
            strSql.Append("select ID,RoleID,UserName,Password,PasswordChangeCode,RealName,Sex,Tel,Mobile,QQ,Email,Department,Job,UserIDs,OtherIDs,State,AddDate,CreateIP,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_Admin_User ");
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
            strSql.Append(" ID,RoleID,UserName,Password,PasswordChangeCode,RealName,Sex,Tel,Mobile,QQ,Email,Department,Job,UserIDs,OtherIDs,State,AddDate,CreateIP,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_Admin_User ");
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
            strSql.Append("select count(1) FROM SW_Admin_User ");
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
                strSql = "select top " + endIndex + " * from SW_Admin_User where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Admin_User where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Admin_User where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Admin_User";
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
        /// 登录验证
        /// </summary>
        public WebSite.Model.Mod_Admin_User ExistsLogin(string UserName, string Password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from SW_Admin_User ");
            strSql.Append(" where UserName=@UserName and Password=@Password ");
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", SqlDbType.VarChar,200),
                new SqlParameter("@Password", SqlDbType.VarChar,200)};
            parameters[0].Value = UserName;
            parameters[1].Value = Password;

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
        /// 是否存在该用户名
        /// </summary>
        public bool ExistsUserName(String UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Admin_User");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
				new SqlParameter("@UserName", SqlDbType.VarChar,200)};
            parameters[0].Value = UserName;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		#endregion  ExtensionMethod
	}
}

