using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Vegetarian
	/// </summary>
	public partial class Dal_Vegetarian
	{
		public Dal_Vegetarian()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_Vegetarian");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Vegetarian");
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
        public int Add(WebSite.Model.Mod_Vegetarian model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_Vegetarian(");
            strSql.Append("Model,UserID,NiceName,UserName,Mobile,Province,City,Region,Address,LongLat,Money,Characteristic,Score,IsRecommend,IsAuthen,AuthenID,AuthenNiceName,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@NiceName,@UserName,@Mobile,@Province,@City,@Region,@Address,@LongLat,@Money,@Characteristic,@Score,@IsRecommend,@IsAuthen,@AuthenID,@AuthenNiceName,@Remarks,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@State,@AuditState,@AddDate,@ModifyDate,@OrderBy,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
					new SqlParameter("@LongLat", SqlDbType.NVarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Characteristic", SqlDbType.NVarChar,500),
					new SqlParameter("@Score", SqlDbType.Decimal,9),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@IsAuthen", SqlDbType.Int,4),
					new SqlParameter("@AuthenID", SqlDbType.Int,4),
					new SqlParameter("@AuthenNiceName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.NVarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.NiceName;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.Mobile;
            parameters[5].Value = model.Province;
            parameters[6].Value = model.City;
            parameters[7].Value = model.Region;
            parameters[8].Value = model.Address;
            parameters[9].Value = model.LongLat;
            parameters[10].Value = model.Money;
            parameters[11].Value = model.Characteristic;
            parameters[12].Value = model.Score;
            parameters[13].Value = model.IsRecommend;
            parameters[14].Value = model.IsAuthen;
            parameters[15].Value = model.AuthenID;
            parameters[16].Value = model.AuthenNiceName;
            parameters[17].Value = model.Remarks;
            parameters[18].Value = model.OtherInt1;
            parameters[19].Value = model.OtherInt2;
            parameters[20].Value = model.OtherInt3;
            parameters[21].Value = model.OtherInt4;
            parameters[22].Value = model.OtherString1;
            parameters[23].Value = model.OtherString2;
            parameters[24].Value = model.OtherString3;
            parameters[25].Value = model.OtherString4;
            parameters[26].Value = model.State;
            parameters[27].Value = model.AuditState;
            parameters[28].Value = model.AddDate;
            parameters[29].Value = model.ModifyDate;
            parameters[30].Value = model.OrderBy;
            parameters[31].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_Vegetarian model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Vegetarian set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("NiceName=@NiceName,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Region=@Region,");
            strSql.Append("Address=@Address,");
            strSql.Append("LongLat=@LongLat,");
            strSql.Append("Money=@Money,");
            strSql.Append("Characteristic=@Characteristic,");
            strSql.Append("Score=@Score,");
            strSql.Append("IsRecommend=@IsRecommend,");
            strSql.Append("IsAuthen=@IsAuthen,");
            strSql.Append("AuthenID=@AuthenID,");
            strSql.Append("AuthenNiceName=@AuthenNiceName,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("OtherInt1=@OtherInt1,");
            strSql.Append("OtherInt2=@OtherInt2,");
            strSql.Append("OtherInt3=@OtherInt3,");
            strSql.Append("OtherInt4=@OtherInt4,");
            strSql.Append("OtherString1=@OtherString1,");
            strSql.Append("OtherString2=@OtherString2,");
            strSql.Append("OtherString3=@OtherString3,");
            strSql.Append("OtherString4=@OtherString4,");
            strSql.Append("State=@State,");
            strSql.Append("AuditState=@AuditState,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
					new SqlParameter("@LongLat", SqlDbType.NVarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Characteristic", SqlDbType.NVarChar,500),
					new SqlParameter("@Score", SqlDbType.Decimal,9),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@IsAuthen", SqlDbType.Int,4),
					new SqlParameter("@AuthenID", SqlDbType.Int,4),
					new SqlParameter("@AuthenNiceName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.NVarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.NiceName;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.Mobile;
            parameters[5].Value = model.Province;
            parameters[6].Value = model.City;
            parameters[7].Value = model.Region;
            parameters[8].Value = model.Address;
            parameters[9].Value = model.LongLat;
            parameters[10].Value = model.Money;
            parameters[11].Value = model.Characteristic;
            parameters[12].Value = model.Score;
            parameters[13].Value = model.IsRecommend;
            parameters[14].Value = model.IsAuthen;
            parameters[15].Value = model.AuthenID;
            parameters[16].Value = model.AuthenNiceName;
            parameters[17].Value = model.Remarks;
            parameters[18].Value = model.OtherInt1;
            parameters[19].Value = model.OtherInt2;
            parameters[20].Value = model.OtherInt3;
            parameters[21].Value = model.OtherInt4;
            parameters[22].Value = model.OtherString1;
            parameters[23].Value = model.OtherString2;
            parameters[24].Value = model.OtherString3;
            parameters[25].Value = model.OtherString4;
            parameters[26].Value = model.State;
            parameters[27].Value = model.AuditState;
            parameters[28].Value = model.AddDate;
            parameters[29].Value = model.ModifyDate;
            parameters[30].Value = model.OrderBy;
            parameters[31].Value = model.WebSiteID;
            parameters[32].Value = model.ID;

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
            strSql.Append("delete from SW_Vegetarian ");
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
            strSql.Append("delete from SW_Vegetarian ");
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
        public WebSite.Model.Mod_Vegetarian GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,NiceName,UserName,Mobile,Province,City,Region,Address,LongLat,Money,Characteristic,Score,IsRecommend,IsAuthen,AuthenID,AuthenNiceName,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID from SW_Vegetarian ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_Vegetarian model = new WebSite.Model.Mod_Vegetarian();
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
        public WebSite.Model.Mod_Vegetarian DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_Vegetarian model = new WebSite.Model.Mod_Vegetarian();
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
                if (row["NiceName"] != null)
                {
                    model.NiceName = row["NiceName"].ToString();
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Mobile"] != null)
                {
                    model.Mobile = row["Mobile"].ToString();
                }
                if (row["Province"] != null)
                {
                    model.Province = row["Province"].ToString();
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["Region"] != null)
                {
                    model.Region = row["Region"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["LongLat"] != null)
                {
                    model.LongLat = row["LongLat"].ToString();
                }
                if (row["Money"] != null && row["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(row["Money"].ToString());
                }
                if (row["Characteristic"] != null)
                {
                    model.Characteristic = row["Characteristic"].ToString();
                }
                if (row["Score"] != null && row["Score"].ToString() != "")
                {
                    model.Score = decimal.Parse(row["Score"].ToString());
                }
                if (row["IsRecommend"] != null && row["IsRecommend"].ToString() != "")
                {
                    model.IsRecommend = int.Parse(row["IsRecommend"].ToString());
                }
                if (row["IsAuthen"] != null && row["IsAuthen"].ToString() != "")
                {
                    model.IsAuthen = int.Parse(row["IsAuthen"].ToString());
                }
                if (row["AuthenID"] != null && row["AuthenID"].ToString() != "")
                {
                    model.AuthenID = int.Parse(row["AuthenID"].ToString());
                }
                if (row["AuthenNiceName"] != null)
                {
                    model.AuthenNiceName = row["AuthenNiceName"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
                }
                if (row["OtherInt1"] != null && row["OtherInt1"].ToString() != "")
                {
                    model.OtherInt1 = int.Parse(row["OtherInt1"].ToString());
                }
                if (row["OtherInt2"] != null && row["OtherInt2"].ToString() != "")
                {
                    model.OtherInt2 = int.Parse(row["OtherInt2"].ToString());
                }
                if (row["OtherInt3"] != null && row["OtherInt3"].ToString() != "")
                {
                    model.OtherInt3 = int.Parse(row["OtherInt3"].ToString());
                }
                if (row["OtherInt4"] != null && row["OtherInt4"].ToString() != "")
                {
                    model.OtherInt4 = int.Parse(row["OtherInt4"].ToString());
                }
                if (row["OtherString1"] != null)
                {
                    model.OtherString1 = row["OtherString1"].ToString();
                }
                if (row["OtherString2"] != null)
                {
                    model.OtherString2 = row["OtherString2"].ToString();
                }
                if (row["OtherString3"] != null)
                {
                    model.OtherString3 = row["OtherString3"].ToString();
                }
                if (row["OtherString4"] != null)
                {
                    model.OtherString4 = row["OtherString4"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["AuditState"] != null && row["AuditState"].ToString() != "")
                {
                    model.AuditState = int.Parse(row["AuditState"].ToString());
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
            strSql.Append("select ID,Model,UserID,NiceName,UserName,Mobile,Province,City,Region,Address,LongLat,Money,Characteristic,Score,IsRecommend,IsAuthen,AuthenID,AuthenNiceName,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_Vegetarian ");
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
            strSql.Append(" ID,Model,UserID,NiceName,UserName,Mobile,Province,City,Region,Address,LongLat,Money,Characteristic,Score,IsRecommend,IsAuthen,AuthenID,AuthenNiceName,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_Vegetarian ");
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
            strSql.Append("select count(1) FROM SW_Vegetarian ");
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
                strSql = "select top " + endIndex + " * from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Vegetarian where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_Vegetarian";
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
        public DataSet GetListByPageThree(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " (select COUNT(*) from SW_VegetarianAuthen where Model='VegetarianAuthen' and State=1 and AuditState=1 and VegetarianID=SW_Vegetarian.ID) as counts ,* from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " (select COUNT(*) from SW_VegetarianAuthen where Model='VegetarianAuthen' and State=1 and AuditState=1 and VegetarianID=SW_Vegetarian.ID) as counts ,* from SW_Vegetarian where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageTwo(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " ID,UserID,UserName,Mobile,Address,OtherString1,IsRecommend from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " ID,UserID,UserName,Mobile,Address,OtherString1,IsRecommend from SW_Vegetarian where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Vegetarian where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
       
        /// <summary>
        /// 是否存在该相同素食名称
        /// </summary>
        public bool ExistsTitleName(String UserName, int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Vegetarian");
            strSql.Append(" where UserName=@UserName and ID!=@ID");
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", SqlDbType.NVarChar,200),
                 new SqlParameter("@ID", SqlDbType.Int,4)
                                        };
            parameters[0].Value = UserName;
            parameters[1].Value = ID;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该相同素食名称
        /// </summary>
        public bool ExistsTitleName(String UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Vegetarian");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", SqlDbType.NVarChar,200)};
            parameters[0].Value = UserName;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		#endregion  ExtensionMethod
	}
}

