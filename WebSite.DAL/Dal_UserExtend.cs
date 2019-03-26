
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserExtend
	/// </summary>
	public partial class Dal_UserExtend
	{
		public Dal_UserExtend()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_UserExtend");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_UserExtend");
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
        public int Add(WebSite.Model.Mod_UserExtend model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_UserExtend(");
            strSql.Append("Model,UserID,Aboutus,Qualifications,Notice,QRcodeImage,LogoImage,Copyright,Hotline,Mobile,Email,ZipCode,Address,Manager,Domain,ELogoImage,MainProducts,BLogoImage,LogoTitle,LogoTitleEn,Edition,SelfAdaption,HeadImage,PageBanner1,PageBanner2,PageBanner3,PageBanner4,PageBanner5,PageBanner6,PageBanner7,PageBanner8,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@Aboutus,@Qualifications,@Notice,@QRcodeImage,@LogoImage,@Copyright,@Hotline,@Mobile,@Email,@ZipCode,@Address,@Manager,@Domain,@ELogoImage,@MainProducts,@BLogoImage,@LogoTitle,@LogoTitleEn,@Edition,@SelfAdaption,@HeadImage,@PageBanner1,@PageBanner2,@PageBanner3,@PageBanner4,@PageBanner5,@PageBanner6,@PageBanner7,@PageBanner8,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Aboutus", SqlDbType.NText),
					new SqlParameter("@Qualifications", SqlDbType.NText),
					new SqlParameter("@Notice", SqlDbType.NVarChar,2000),
					new SqlParameter("@QRcodeImage", SqlDbType.VarChar,200),
					new SqlParameter("@LogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@Copyright", SqlDbType.VarChar,500),
					new SqlParameter("@Hotline", SqlDbType.VarChar,30),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@ZipCode", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.NVarChar,2000),
					new SqlParameter("@Manager", SqlDbType.VarChar,20),
					new SqlParameter("@Domain", SqlDbType.VarChar,200),
					new SqlParameter("@ELogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@MainProducts", SqlDbType.NText),
					new SqlParameter("@BLogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@LogoTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@LogoTitleEn", SqlDbType.NVarChar,200),
					new SqlParameter("@Edition", SqlDbType.Int,4),
					new SqlParameter("@SelfAdaption", SqlDbType.Int,4),
					new SqlParameter("@HeadImage", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner1", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner2", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner3", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner4", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner5", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner6", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner7", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner8", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.Aboutus;
            parameters[3].Value = model.Qualifications;
            parameters[4].Value = model.Notice;
            parameters[5].Value = model.QRcodeImage;
            parameters[6].Value = model.LogoImage;
            parameters[7].Value = model.Copyright;
            parameters[8].Value = model.Hotline;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Email;
            parameters[11].Value = model.ZipCode;
            parameters[12].Value = model.Address;
            parameters[13].Value = model.Manager;
            parameters[14].Value = model.Domain;
            parameters[15].Value = model.ELogoImage;
            parameters[16].Value = model.MainProducts;
            parameters[17].Value = model.BLogoImage;
            parameters[18].Value = model.LogoTitle;
            parameters[19].Value = model.LogoTitleEn;
            parameters[20].Value = model.Edition;
            parameters[21].Value = model.SelfAdaption;
            parameters[22].Value = model.HeadImage;
            parameters[23].Value = model.PageBanner1;
            parameters[24].Value = model.PageBanner2;
            parameters[25].Value = model.PageBanner3;
            parameters[26].Value = model.PageBanner4;
            parameters[27].Value = model.PageBanner5;
            parameters[28].Value = model.PageBanner6;
            parameters[29].Value = model.PageBanner7;
            parameters[30].Value = model.PageBanner8;
            parameters[31].Value = model.State;
            parameters[32].Value = model.OrderBy;
            parameters[33].Value = model.AddDate;
            parameters[34].Value = model.ModifyDate;
            parameters[35].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_UserExtend model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_UserExtend set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("Aboutus=@Aboutus,");
            strSql.Append("Qualifications=@Qualifications,");
            strSql.Append("Notice=@Notice,");
            strSql.Append("QRcodeImage=@QRcodeImage,");
            strSql.Append("LogoImage=@LogoImage,");
            strSql.Append("Copyright=@Copyright,");
            strSql.Append("Hotline=@Hotline,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Email=@Email,");
            strSql.Append("ZipCode=@ZipCode,");
            strSql.Append("Address=@Address,");
            strSql.Append("Manager=@Manager,");
            strSql.Append("Domain=@Domain,");
            strSql.Append("ELogoImage=@ELogoImage,");
            strSql.Append("MainProducts=@MainProducts,");
            strSql.Append("BLogoImage=@BLogoImage,");
            strSql.Append("LogoTitle=@LogoTitle,");
            strSql.Append("LogoTitleEn=@LogoTitleEn,");
            strSql.Append("Edition=@Edition,");
            strSql.Append("SelfAdaption=@SelfAdaption,");
            strSql.Append("HeadImage=@HeadImage,");
            strSql.Append("PageBanner1=@PageBanner1,");
            strSql.Append("PageBanner2=@PageBanner2,");
            strSql.Append("PageBanner3=@PageBanner3,");
            strSql.Append("PageBanner4=@PageBanner4,");
            strSql.Append("PageBanner5=@PageBanner5,");
            strSql.Append("PageBanner6=@PageBanner6,");
            strSql.Append("PageBanner7=@PageBanner7,");
            strSql.Append("PageBanner8=@PageBanner8,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Aboutus", SqlDbType.NText),
					new SqlParameter("@Qualifications", SqlDbType.NText),
					new SqlParameter("@Notice", SqlDbType.NVarChar,2000),
					new SqlParameter("@QRcodeImage", SqlDbType.VarChar,200),
					new SqlParameter("@LogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@Copyright", SqlDbType.VarChar,500),
					new SqlParameter("@Hotline", SqlDbType.VarChar,30),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@ZipCode", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.NVarChar,2000),
					new SqlParameter("@Manager", SqlDbType.VarChar,20),
					new SqlParameter("@Domain", SqlDbType.VarChar,200),
					new SqlParameter("@ELogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@MainProducts", SqlDbType.NText),
					new SqlParameter("@BLogoImage", SqlDbType.VarChar,200),
					new SqlParameter("@LogoTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@LogoTitleEn", SqlDbType.NVarChar,200),
					new SqlParameter("@Edition", SqlDbType.Int,4),
					new SqlParameter("@SelfAdaption", SqlDbType.Int,4),
					new SqlParameter("@HeadImage", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner1", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner2", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner3", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner4", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner5", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner6", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner7", SqlDbType.VarChar,200),
					new SqlParameter("@PageBanner8", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.Aboutus;
            parameters[3].Value = model.Qualifications;
            parameters[4].Value = model.Notice;
            parameters[5].Value = model.QRcodeImage;
            parameters[6].Value = model.LogoImage;
            parameters[7].Value = model.Copyright;
            parameters[8].Value = model.Hotline;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Email;
            parameters[11].Value = model.ZipCode;
            parameters[12].Value = model.Address;
            parameters[13].Value = model.Manager;
            parameters[14].Value = model.Domain;
            parameters[15].Value = model.ELogoImage;
            parameters[16].Value = model.MainProducts;
            parameters[17].Value = model.BLogoImage;
            parameters[18].Value = model.LogoTitle;
            parameters[19].Value = model.LogoTitleEn;
            parameters[20].Value = model.Edition;
            parameters[21].Value = model.SelfAdaption;
            parameters[22].Value = model.HeadImage;
            parameters[23].Value = model.PageBanner1;
            parameters[24].Value = model.PageBanner2;
            parameters[25].Value = model.PageBanner3;
            parameters[26].Value = model.PageBanner4;
            parameters[27].Value = model.PageBanner5;
            parameters[28].Value = model.PageBanner6;
            parameters[29].Value = model.PageBanner7;
            parameters[30].Value = model.PageBanner8;
            parameters[31].Value = model.State;
            parameters[32].Value = model.OrderBy;
            parameters[33].Value = model.AddDate;
            parameters[34].Value = model.ModifyDate;
            parameters[35].Value = model.WebSiteID;
            parameters[36].Value = model.ID;

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
            strSql.Append("delete from SW_UserExtend ");
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
            strSql.Append("delete from SW_UserExtend ");
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
        public WebSite.Model.Mod_UserExtend GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,Aboutus,Qualifications,Notice,QRcodeImage,LogoImage,Copyright,Hotline,Mobile,Email,ZipCode,Address,Manager,Domain,ELogoImage,MainProducts,BLogoImage,LogoTitle,LogoTitleEn,Edition,SelfAdaption,HeadImage,PageBanner1,PageBanner2,PageBanner3,PageBanner4,PageBanner5,PageBanner6,PageBanner7,PageBanner8,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_UserExtend ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_UserExtend model = new WebSite.Model.Mod_UserExtend();
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
        public WebSite.Model.Mod_UserExtend DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_UserExtend model = new WebSite.Model.Mod_UserExtend();
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
                if (row["Aboutus"] != null)
                {
                    model.Aboutus = row["Aboutus"].ToString();
                }
                if (row["Qualifications"] != null)
                {
                    model.Qualifications = row["Qualifications"].ToString();
                }
                if (row["Notice"] != null)
                {
                    model.Notice = row["Notice"].ToString();
                }
                if (row["QRcodeImage"] != null)
                {
                    model.QRcodeImage = row["QRcodeImage"].ToString();
                }
                if (row["LogoImage"] != null)
                {
                    model.LogoImage = row["LogoImage"].ToString();
                }
                if (row["Copyright"] != null)
                {
                    model.Copyright = row["Copyright"].ToString();
                }
                if (row["Hotline"] != null)
                {
                    model.Hotline = row["Hotline"].ToString();
                }
                if (row["Mobile"] != null)
                {
                    model.Mobile = row["Mobile"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["ZipCode"] != null)
                {
                    model.ZipCode = row["ZipCode"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Manager"] != null)
                {
                    model.Manager = row["Manager"].ToString();
                }
                if (row["Domain"] != null)
                {
                    model.Domain = row["Domain"].ToString();
                }
                if (row["ELogoImage"] != null)
                {
                    model.ELogoImage = row["ELogoImage"].ToString();
                }
                if (row["MainProducts"] != null)
                {
                    model.MainProducts = row["MainProducts"].ToString();
                }
                if (row["BLogoImage"] != null)
                {
                    model.BLogoImage = row["BLogoImage"].ToString();
                }
                if (row["LogoTitle"] != null)
                {
                    model.LogoTitle = row["LogoTitle"].ToString();
                }
                if (row["LogoTitleEn"] != null)
                {
                    model.LogoTitleEn = row["LogoTitleEn"].ToString();
                }
                if (row["Edition"] != null && row["Edition"].ToString() != "")
                {
                    model.Edition = int.Parse(row["Edition"].ToString());
                }
                if (row["SelfAdaption"] != null && row["SelfAdaption"].ToString() != "")
                {
                    model.SelfAdaption = int.Parse(row["SelfAdaption"].ToString());
                }
                if (row["HeadImage"] != null)
                {
                    model.HeadImage = row["HeadImage"].ToString();
                }
                if (row["PageBanner1"] != null)
                {
                    model.PageBanner1 = row["PageBanner1"].ToString();
                }
                if (row["PageBanner2"] != null)
                {
                    model.PageBanner2 = row["PageBanner2"].ToString();
                }
                if (row["PageBanner3"] != null)
                {
                    model.PageBanner3 = row["PageBanner3"].ToString();
                }
                if (row["PageBanner4"] != null)
                {
                    model.PageBanner4 = row["PageBanner4"].ToString();
                }
                if (row["PageBanner5"] != null)
                {
                    model.PageBanner5 = row["PageBanner5"].ToString();
                }
                if (row["PageBanner6"] != null)
                {
                    model.PageBanner6 = row["PageBanner6"].ToString();
                }
                if (row["PageBanner7"] != null)
                {
                    model.PageBanner7 = row["PageBanner7"].ToString();
                }
                if (row["PageBanner8"] != null)
                {
                    model.PageBanner8 = row["PageBanner8"].ToString();
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
            strSql.Append("select ID,Model,UserID,Aboutus,Qualifications,Notice,QRcodeImage,LogoImage,Copyright,Hotline,Mobile,Email,ZipCode,Address,Manager,Domain,ELogoImage,MainProducts,BLogoImage,LogoTitle,LogoTitleEn,Edition,SelfAdaption,HeadImage,PageBanner1,PageBanner2,PageBanner3,PageBanner4,PageBanner5,PageBanner6,PageBanner7,PageBanner8,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
            strSql.Append(" FROM SW_UserExtend ");
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
            strSql.Append(" ID,Model,UserID,Aboutus,Qualifications,Notice,QRcodeImage,LogoImage,Copyright,Hotline,Mobile,Email,ZipCode,Address,Manager,Domain,ELogoImage,MainProducts,BLogoImage,LogoTitle,LogoTitleEn,Edition,SelfAdaption,HeadImage,PageBanner1,PageBanner2,PageBanner3,PageBanner4,PageBanner5,PageBanner6,PageBanner7,PageBanner8,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
            strSql.Append(" FROM SW_UserExtend ");
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
            strSql.Append("select count(1) FROM SW_UserExtend ");
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
                strSql = "select top " + endIndex + " * from SW_UserExtend where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserExtend where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserExtend where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserExtend";
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
        public WebSite.Model.Mod_UserExtend GetModelUserID(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,Aboutus,Qualifications,Notice,QRcodeImage,LogoImage,Copyright,Hotline,Mobile,Email,ZipCode,Address,Manager,Domain,ELogoImage,MainProducts,BLogoImage,LogoTitle,LogoTitleEn,Edition,SelfAdaption,HeadImage,PageBanner1,PageBanner2,PageBanner3,PageBanner4,PageBanner5,PageBanner6,PageBanner7,PageBanner8,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_UserExtend");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_UserExtend model = new WebSite.Model.Mod_UserExtend();
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

