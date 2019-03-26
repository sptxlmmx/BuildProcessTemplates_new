using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_BaseType
	/// </summary>
	public partial class Dal_BaseType
	{
		public Dal_BaseType()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_BaseType");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_BaseType");
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
        public int Add(WebSite.Model.Mod_BaseType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_BaseType(");
            strSql.Append("Model,Title,AddDate,OrderBy,ParentID,IDPath,WebSiteID,Link,Info,Content,State,Image,DisplayMode,IncludeType,ColumnID,Decimals,IsChocie,IsAttribute,IsTemplate,IsImageTemplate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9)");
            strSql.Append(" values (");
            strSql.Append("@Model,@Title,@AddDate,@OrderBy,@ParentID,@IDPath,@WebSiteID,@Link,@Info,@Content,@State,@Image,@DisplayMode,@IncludeType,@ColumnID,@Decimals,@IsChocie,@IsAttribute,@IsTemplate,@IsImageTemplate,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6,@Attr7,@Attr8,@Attr9)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,300),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@Link", SqlDbType.VarChar,500),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@DisplayMode", SqlDbType.Int,4),
					new SqlParameter("@IncludeType", SqlDbType.VarChar,200),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@Decimals", SqlDbType.Decimal,9),
					new SqlParameter("@IsChocie", SqlDbType.Int,4),
					new SqlParameter("@IsAttribute", SqlDbType.Int,4),
					new SqlParameter("@IsTemplate", SqlDbType.Int,4),
					new SqlParameter("@IsImageTemplate", SqlDbType.Int,4),
					new SqlParameter("@Attr1", SqlDbType.VarChar,500),
					new SqlParameter("@Attr2", SqlDbType.VarChar,500),
					new SqlParameter("@Attr3", SqlDbType.VarChar,200),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.Int,4),
					new SqlParameter("@Attr6", SqlDbType.Int,4),
					new SqlParameter("@Attr7", SqlDbType.Decimal,9),
					new SqlParameter("@Attr8", SqlDbType.Decimal,9),
					new SqlParameter("@Attr9", SqlDbType.Text)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.AddDate;
            parameters[3].Value = model.OrderBy;
            parameters[4].Value = model.ParentID;
            parameters[5].Value = model.IDPath;
            parameters[6].Value = model.WebSiteID;
            parameters[7].Value = model.Link;
            parameters[8].Value = model.Info;
            parameters[9].Value = model.Content;
            parameters[10].Value = model.State;
            parameters[11].Value = model.Image;
            parameters[12].Value = model.DisplayMode;
            parameters[13].Value = model.IncludeType;
            parameters[14].Value = model.ColumnID;
            parameters[15].Value = model.Decimals;
            parameters[16].Value = model.IsChocie;
            parameters[17].Value = model.IsAttribute;
            parameters[18].Value = model.IsTemplate;
            parameters[19].Value = model.IsImageTemplate;
            parameters[20].Value = model.Attr1;
            parameters[21].Value = model.Attr2;
            parameters[22].Value = model.Attr3;
            parameters[23].Value = model.Attr4;
            parameters[24].Value = model.Attr5;
            parameters[25].Value = model.Attr6;
            parameters[26].Value = model.Attr7;
            parameters[27].Value = model.Attr8;
            parameters[28].Value = model.Attr9;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                model.ID = Convert.ToInt32(obj);
                if (model.ParentID == 0)
                {
                    model.ColumnID = 1;
                    model.IDPath = model.ID.ToString();
                }
                else
                {
                    WebSite.Model.Mod_BaseType MBaseType = GetModel(model.ParentID);
                    model.ColumnID = MBaseType.ColumnID + 1;
                    model.IDPath = MBaseType.IDPath + "," + model.ID.ToString();
                }
                Update(model);
                return model.ID;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WebSite.Model.Mod_BaseType model)
        {
            string OldIDPath = model.IDPath;
            if (model.ParentID == 0)
            {
                model.ColumnID = 1;
                model.IDPath = model.ID.ToString();
            }
            else
            {
                WebSite.Model.Mod_BaseType MBaseType = GetModel(model.ParentID);
                model.ColumnID = MBaseType.ColumnID + 1;
                model.IDPath = MBaseType.IDPath + "," + model.ID.ToString();
            }

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_BaseType set ");
            strSql.Append("Model=@Model,");
            strSql.Append("Title=@Title,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("IDPath=@IDPath,");
            strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("Link=@Link,");
            strSql.Append("Info=@Info,");
            strSql.Append("Content=@Content,");
            strSql.Append("State=@State,");
            strSql.Append("Image=@Image,");
            strSql.Append("DisplayMode=@DisplayMode,");
            strSql.Append("IncludeType=@IncludeType,");
            strSql.Append("ColumnID=@ColumnID,");
            strSql.Append("Decimals=@Decimals,");
            strSql.Append("IsChocie=@IsChocie,");
            strSql.Append("IsAttribute=@IsAttribute,");
            strSql.Append("IsTemplate=@IsTemplate,");
            strSql.Append("IsImageTemplate=@IsImageTemplate,");
            strSql.Append("Attr1=@Attr1,");
            strSql.Append("Attr2=@Attr2,");
            strSql.Append("Attr3=@Attr3,");
            strSql.Append("Attr4=@Attr4,");
            strSql.Append("Attr5=@Attr5,");
            strSql.Append("Attr6=@Attr6,");
            strSql.Append("Attr7=@Attr7,");
            strSql.Append("Attr8=@Attr8,");
            strSql.Append("Attr9=@Attr9");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,300),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@Link", SqlDbType.VarChar,500),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@DisplayMode", SqlDbType.Int,4),
					new SqlParameter("@IncludeType", SqlDbType.VarChar,200),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@Decimals", SqlDbType.Decimal,9),
					new SqlParameter("@IsChocie", SqlDbType.Int,4),
					new SqlParameter("@IsAttribute", SqlDbType.Int,4),
					new SqlParameter("@IsTemplate", SqlDbType.Int,4),
					new SqlParameter("@IsImageTemplate", SqlDbType.Int,4),
					new SqlParameter("@Attr1", SqlDbType.VarChar,500),
					new SqlParameter("@Attr2", SqlDbType.VarChar,500),
					new SqlParameter("@Attr3", SqlDbType.VarChar,200),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.Int,4),
					new SqlParameter("@Attr6", SqlDbType.Int,4),
					new SqlParameter("@Attr7", SqlDbType.Decimal,9),
					new SqlParameter("@Attr8", SqlDbType.Decimal,9),
					new SqlParameter("@Attr9", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.AddDate;
            parameters[3].Value = model.OrderBy;
            parameters[4].Value = model.ParentID;
            parameters[5].Value = model.IDPath;
            parameters[6].Value = model.WebSiteID;
            parameters[7].Value = model.Link;
            parameters[8].Value = model.Info;
            parameters[9].Value = model.Content;
            parameters[10].Value = model.State;
            parameters[11].Value = model.Image;
            parameters[12].Value = model.DisplayMode;
            parameters[13].Value = model.IncludeType;
            parameters[14].Value = model.ColumnID;
            parameters[15].Value = model.Decimals;
            parameters[16].Value = model.IsChocie;
            parameters[17].Value = model.IsAttribute;
            parameters[18].Value = model.IsTemplate;
            parameters[19].Value = model.IsImageTemplate;
            parameters[20].Value = model.Attr1;
            parameters[21].Value = model.Attr2;
            parameters[22].Value = model.Attr3;
            parameters[23].Value = model.Attr4;
            parameters[24].Value = model.Attr5;
            parameters[25].Value = model.Attr6;
            parameters[26].Value = model.Attr7;
            parameters[27].Value = model.Attr8;
            parameters[28].Value = model.Attr9;
            parameters[29].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                //修改子类路径
                ModifyIDPath(model, OldIDPath);
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
            strSql.Append("delete from SW_BaseType ");
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
            strSql.Append("delete from SW_BaseType ");
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
        public WebSite.Model.Mod_BaseType GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,Title,AddDate,OrderBy,ParentID,IDPath,WebSiteID,Link,Info,Content,State,Image,DisplayMode,IncludeType,ColumnID,Decimals,IsChocie,IsAttribute,IsTemplate,IsImageTemplate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9 from SW_BaseType ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_BaseType model = new WebSite.Model.Mod_BaseType();
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
        public WebSite.Model.Mod_BaseType DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_BaseType model = new WebSite.Model.Mod_BaseType();
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
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["ParentID"] != null && row["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(row["ParentID"].ToString());
                }
                if (row["IDPath"] != null)
                {
                    model.IDPath = row["IDPath"].ToString();
                }
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
                if (row["Link"] != null)
                {
                    model.Link = row["Link"].ToString();
                }
                if (row["Info"] != null)
                {
                    model.Info = row["Info"].ToString();
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["Image"] != null)
                {
                    model.Image = row["Image"].ToString();
                }
                if (row["DisplayMode"] != null && row["DisplayMode"].ToString() != "")
                {
                    model.DisplayMode = int.Parse(row["DisplayMode"].ToString());
                }
                if (row["IncludeType"] != null)
                {
                    model.IncludeType = row["IncludeType"].ToString();
                }
                if (row["ColumnID"] != null && row["ColumnID"].ToString() != "")
                {
                    model.ColumnID = int.Parse(row["ColumnID"].ToString());
                }
                if (row["Decimals"] != null && row["Decimals"].ToString() != "")
                {
                    model.Decimals = decimal.Parse(row["Decimals"].ToString());
                }
                if (row["IsChocie"] != null && row["IsChocie"].ToString() != "")
                {
                    model.IsChocie = int.Parse(row["IsChocie"].ToString());
                }
                if (row["IsAttribute"] != null && row["IsAttribute"].ToString() != "")
                {
                    model.IsAttribute = int.Parse(row["IsAttribute"].ToString());
                }
                if (row["IsTemplate"] != null && row["IsTemplate"].ToString() != "")
                {
                    model.IsTemplate = int.Parse(row["IsTemplate"].ToString());
                }
                if (row["IsImageTemplate"] != null && row["IsImageTemplate"].ToString() != "")
                {
                    model.IsImageTemplate = int.Parse(row["IsImageTemplate"].ToString());
                }
                if (row["Attr1"] != null)
                {
                    model.Attr1 = row["Attr1"].ToString();
                }
                if (row["Attr2"] != null)
                {
                    model.Attr2 = row["Attr2"].ToString();
                }
                if (row["Attr3"] != null)
                {
                    model.Attr3 = row["Attr3"].ToString();
                }
                if (row["Attr4"] != null)
                {
                    model.Attr4 = row["Attr4"].ToString();
                }
                if (row["Attr5"] != null && row["Attr5"].ToString() != "")
                {
                    model.Attr5 = int.Parse(row["Attr5"].ToString());
                }
                if (row["Attr6"] != null && row["Attr6"].ToString() != "")
                {
                    model.Attr6 = int.Parse(row["Attr6"].ToString());
                }
                if (row["Attr7"] != null && row["Attr7"].ToString() != "")
                {
                    model.Attr7 = decimal.Parse(row["Attr7"].ToString());
                }
                if (row["Attr8"] != null && row["Attr8"].ToString() != "")
                {
                    model.Attr8 = decimal.Parse(row["Attr8"].ToString());
                }
                if (row["Attr9"] != null)
                {
                    model.Attr9 = row["Attr9"].ToString();
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
            strSql.Append("select ID,Model,Title,AddDate,OrderBy,ParentID,IDPath,WebSiteID,Link,Info,Content,State,Image,DisplayMode,IncludeType,ColumnID,Decimals,IsChocie,IsAttribute,IsTemplate,IsImageTemplate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9 ");            
            strSql.Append(" FROM SW_BaseType ");
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
            strSql.Append(" ID,Model,Title,AddDate,OrderBy,ParentID,IDPath,WebSiteID,Link,Info,Content,State,Image,DisplayMode,IncludeType,ColumnID,Decimals,IsChocie,IsAttribute,IsTemplate,IsImageTemplate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9 ");            
            strSql.Append(" FROM SW_BaseType ");
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
            strSql.Append("select count(1) FROM SW_BaseType ");
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
                strSql = "select top " + endIndex + " * from SW_BaseType where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_BaseType where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_BaseType where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_BaseType";
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string WhereStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_BaseType ");
            strSql.Append(" where " + WhereStr + " ");
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
        /// 修改子类路径
        /// </summary>
        public bool ModifyIDPath(WebSite.Model.Mod_BaseType model, string OldIDPath)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("select * from SW_BaseType where IDPath like '" + OldIDPath + "%'");
                        DataSet ds = DbHelperSQL.Query(conn, trans, strSql.ToString());
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                strSql = new StringBuilder();
                                string IDPath = ("," + dr["IDPath"].ToString()).Replace("," + OldIDPath + ",", model.IDPath + ",").Trim(',');
                                strSql.Append("update SW_BaseType set ");
                                strSql.Append("IDPath=@IDPath,");
                                strSql.Append("ColumnID=@ColumnID");
                                strSql.Append(" where ID=@ID");
                                SqlParameter[] parameters = {
					                        new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					                        new SqlParameter("@ColumnID", SqlDbType.Int,4),
					                        new SqlParameter("@ID", SqlDbType.Int,4)};
                                parameters[0].Value = IDPath;
                                parameters[1].Value = IDPath.Split(',').Length;
                                parameters[2].Value = int.Parse(dr["ID"].ToString());
                                DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                            }
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }
		#endregion  ExtensionMethod
	}
}

