using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references

namespace WebSite.DAL
{
    public class Dal_VegetarianAuthen
    {
        public Dal_VegetarianAuthen()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_VegetarianAuthen");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_VegetarianAuthen");
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
        public int Add(WebSite.Model.Mod_VegetarianAuthen model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_VegetarianAuthen(");
            strSql.Append("Model,UserID,NiceName,VegetarianID,Title,Contacts,CardImage,CardConImage,BusinessImage,Mobile,Province,City,Region,Address,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@NiceName,@VegetarianID,@Title,@Contacts,@CardImage,@CardConImage,@BusinessImage,@Mobile,@Province,@City,@Region,@Address,@Remarks,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@State,@AuditState,@AddDate,@ModifyDate,@OrderBy,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@VegetarianID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,150),
					new SqlParameter("@Contacts", SqlDbType.NVarChar,50),
					new SqlParameter("@CardImage", SqlDbType.NVarChar,200),
					new SqlParameter("@CardConImage", SqlDbType.NVarChar,200),
					new SqlParameter("@BusinessImage", SqlDbType.NVarChar,200),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
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
            parameters[3].Value = model.VegetarianID;
            parameters[4].Value = model.Title;
            parameters[5].Value = model.Contacts;
            parameters[6].Value = model.CardImage;
            parameters[7].Value = model.CardConImage;
            parameters[8].Value = model.BusinessImage;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Province;
            parameters[11].Value = model.City;
            parameters[12].Value = model.Region;
            parameters[13].Value = model.Address;
            parameters[14].Value = model.Remarks;
            parameters[15].Value = model.OtherInt1;
            parameters[16].Value = model.OtherInt2;
            parameters[17].Value = model.OtherInt3;
            parameters[18].Value = model.OtherInt4;
            parameters[19].Value = model.OtherString1;
            parameters[20].Value = model.OtherString2;
            parameters[21].Value = model.OtherString3;
            parameters[22].Value = model.OtherString4;
            parameters[23].Value = model.State;
            parameters[24].Value = model.AuditState;
            parameters[25].Value = model.AddDate;
            parameters[26].Value = model.ModifyDate;
            parameters[27].Value = model.OrderBy;
            parameters[28].Value = model.WebSiteID;

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
        public bool Update(WebSite.Model.Mod_VegetarianAuthen model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_VegetarianAuthen set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("NiceName=@NiceName,");
            strSql.Append("VegetarianID=@VegetarianID,");
            strSql.Append("Title=@Title,");
            strSql.Append("Contacts=@Contacts,");
            strSql.Append("CardImage=@CardImage,");
            strSql.Append("CardConImage=@CardConImage,");
            strSql.Append("BusinessImage=@BusinessImage,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Region=@Region,");
            strSql.Append("Address=@Address,");
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
					new SqlParameter("@VegetarianID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,150),
					new SqlParameter("@Contacts", SqlDbType.NVarChar,50),
					new SqlParameter("@CardImage", SqlDbType.NVarChar,200),
					new SqlParameter("@CardConImage", SqlDbType.NVarChar,200),
					new SqlParameter("@BusinessImage", SqlDbType.NVarChar,200),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
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
            parameters[3].Value = model.VegetarianID;
            parameters[4].Value = model.Title;
            parameters[5].Value = model.Contacts;
            parameters[6].Value = model.CardImage;
            parameters[7].Value = model.CardConImage;
            parameters[8].Value = model.BusinessImage;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Province;
            parameters[11].Value = model.City;
            parameters[12].Value = model.Region;
            parameters[13].Value = model.Address;
            parameters[14].Value = model.Remarks;
            parameters[15].Value = model.OtherInt1;
            parameters[16].Value = model.OtherInt2;
            parameters[17].Value = model.OtherInt3;
            parameters[18].Value = model.OtherInt4;
            parameters[19].Value = model.OtherString1;
            parameters[20].Value = model.OtherString2;
            parameters[21].Value = model.OtherString3;
            parameters[22].Value = model.OtherString4;
            parameters[23].Value = model.State;
            parameters[24].Value = model.AuditState;
            parameters[25].Value = model.AddDate;
            parameters[26].Value = model.ModifyDate;
            parameters[27].Value = model.OrderBy;
            parameters[28].Value = model.WebSiteID;
            parameters[29].Value = model.ID;

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
            strSql.Append("delete from SW_VegetarianAuthen ");
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
            strSql.Append("delete from SW_VegetarianAuthen ");
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
        public WebSite.Model.Mod_VegetarianAuthen GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,NiceName,VegetarianID,Title,Contacts,CardImage,CardConImage,BusinessImage,Mobile,Province,City,Region,Address,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID from SW_VegetarianAuthen ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_VegetarianAuthen model = new WebSite.Model.Mod_VegetarianAuthen();
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
        public WebSite.Model.Mod_VegetarianAuthen DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_VegetarianAuthen model = new WebSite.Model.Mod_VegetarianAuthen();
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
                if (row["VegetarianID"] != null && row["VegetarianID"].ToString() != "")
                {
                    model.VegetarianID = int.Parse(row["VegetarianID"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["Contacts"] != null)
                {
                    model.Contacts = row["Contacts"].ToString();
                }
                if (row["CardImage"] != null)
                {
                    model.CardImage = row["CardImage"].ToString();
                }
                if (row["CardConImage"] != null)
                {
                    model.CardConImage = row["CardConImage"].ToString();
                }
                if (row["BusinessImage"] != null)
                {
                    model.BusinessImage = row["BusinessImage"].ToString();
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
            strSql.Append("select ID,Model,UserID,NiceName,VegetarianID,Title,Contacts,CardImage,CardConImage,BusinessImage,Mobile,Province,City,Region,Address,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_VegetarianAuthen ");
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
            strSql.Append(" ID,Model,UserID,NiceName,VegetarianID,Title,Contacts,CardImage,CardConImage,BusinessImage,Mobile,Province,City,Region,Address,Remarks,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherString1,OtherString2,OtherString3,OtherString4,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_VegetarianAuthen ");
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
            strSql.Append("select count(1) FROM SW_VegetarianAuthen ");
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
                strSql = "select top " + endIndex + " * from SW_VegetarianAuthen where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_VegetarianAuthen where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_VegetarianAuthen where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_VegetarianAuthen";
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
