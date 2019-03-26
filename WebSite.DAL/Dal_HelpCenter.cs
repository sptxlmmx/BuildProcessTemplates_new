using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_HelpCenter
    /// </summary>
    public partial class Dal_HelpCenter
    {
        public Dal_HelpCenter()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_HelpCenter");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_HelpCenter");
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
        public int Add(WebSite.Model.Mod_HelpCenter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_HelpCenter(");
            strSql.Append("Model,UserID,Title,Content1,Content2,Introduction,TypeID,STypeID,AddDate,ModifyDate,BrowseCount,CommendDate,State,Tags,Image,IsCommend,IsTop,IsEssence,IsPermissions,WebSiteID,Author,Source,CommentCount,UserName,FileURL,FileName,IsCrawl,IsAudit,AuditDate,AuditMember,OrderBy,CitationTitle,SubTitle,Link,TitleColor,IsComment)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@Title,@Content1,@Content2,@Introduction,@TypeID,@STypeID,@AddDate,@ModifyDate,@BrowseCount,@CommendDate,@State,@Tags,@Image,@IsCommend,@IsTop,@IsEssence,@IsPermissions,@WebSiteID,@Author,@Source,@CommentCount,@UserName,@FileURL,@FileName,@IsCrawl,@IsAudit,@AuditDate,@AuditMember,@OrderBy,@CitationTitle,@SubTitle,@Link,@TitleColor,@IsComment)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@Introduction", SqlDbType.VarChar,2000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommendDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.Text),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsEssence", SqlDbType.Int,4),
					new SqlParameter("@IsPermissions", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@Author", SqlDbType.VarChar,200),
					new SqlParameter("@Source", SqlDbType.VarChar,200),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@FileURL", SqlDbType.VarChar,500),
					new SqlParameter("@FileName", SqlDbType.NVarChar,200),
					new SqlParameter("@IsCrawl", SqlDbType.Int,4),
					new SqlParameter("@IsAudit", SqlDbType.Int,4),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@AuditMember", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@CitationTitle", SqlDbType.VarChar,500),
					new SqlParameter("@SubTitle", SqlDbType.VarChar,500),
					new SqlParameter("@Link", SqlDbType.VarChar,500),
					new SqlParameter("@TitleColor", SqlDbType.VarChar,20),
					new SqlParameter("@IsComment", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.Content1;
            parameters[4].Value = model.Content2;
            parameters[5].Value = model.Introduction;
            parameters[6].Value = model.TypeID;
            parameters[7].Value = model.STypeID;
            parameters[8].Value = model.AddDate;
            parameters[9].Value = model.ModifyDate;
            parameters[10].Value = model.BrowseCount;
            parameters[11].Value = model.CommendDate;
            parameters[12].Value = model.State;
            parameters[13].Value = model.Tags;
            parameters[14].Value = model.Image;
            parameters[15].Value = model.IsCommend;
            parameters[16].Value = model.IsTop;
            parameters[17].Value = model.IsEssence;
            parameters[18].Value = model.IsPermissions;
            parameters[19].Value = model.WebSiteID;
            parameters[20].Value = model.Author;
            parameters[21].Value = model.Source;
            parameters[22].Value = model.CommentCount;
            parameters[23].Value = model.UserName;
            parameters[24].Value = model.FileURL;
            parameters[25].Value = model.FileName;
            parameters[26].Value = model.IsCrawl;
            parameters[27].Value = model.IsAudit;
            parameters[28].Value = model.AuditDate;
            parameters[29].Value = model.AuditMember;
            parameters[30].Value = model.OrderBy;
            parameters[31].Value = model.CitationTitle;
            parameters[32].Value = model.SubTitle;
            parameters[33].Value = model.Link;
            parameters[34].Value = model.TitleColor;
            parameters[35].Value = model.IsComment;

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
        public bool Update(WebSite.Model.Mod_HelpCenter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_HelpCenter set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("Title=@Title,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("Content2=@Content2,");
            strSql.Append("Introduction=@Introduction,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("STypeID=@STypeID,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("BrowseCount=@BrowseCount,");
            strSql.Append("CommendDate=@CommendDate,");
            strSql.Append("State=@State,");
            strSql.Append("Tags=@Tags,");
            strSql.Append("Image=@Image,");
            strSql.Append("IsCommend=@IsCommend,");
            strSql.Append("IsTop=@IsTop,");
            strSql.Append("IsEssence=@IsEssence,");
            strSql.Append("IsPermissions=@IsPermissions,");
            strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("Author=@Author,");
            strSql.Append("Source=@Source,");
            strSql.Append("CommentCount=@CommentCount,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("FileURL=@FileURL,");
            strSql.Append("FileName=@FileName,");
            strSql.Append("IsCrawl=@IsCrawl,");
            strSql.Append("IsAudit=@IsAudit,");
            strSql.Append("AuditDate=@AuditDate,");
            strSql.Append("AuditMember=@AuditMember,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("CitationTitle=@CitationTitle,");
            strSql.Append("SubTitle=@SubTitle,");
            strSql.Append("Link=@Link,");
            strSql.Append("TitleColor=@TitleColor,");
            strSql.Append("IsComment=@IsComment");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@Introduction", SqlDbType.VarChar,2000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommendDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.Text),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsEssence", SqlDbType.Int,4),
					new SqlParameter("@IsPermissions", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@Author", SqlDbType.VarChar,200),
					new SqlParameter("@Source", SqlDbType.VarChar,200),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@FileURL", SqlDbType.VarChar,500),
					new SqlParameter("@FileName", SqlDbType.NVarChar,200),
					new SqlParameter("@IsCrawl", SqlDbType.Int,4),
					new SqlParameter("@IsAudit", SqlDbType.Int,4),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@AuditMember", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@CitationTitle", SqlDbType.VarChar,500),
					new SqlParameter("@SubTitle", SqlDbType.VarChar,500),
					new SqlParameter("@Link", SqlDbType.VarChar,500),
					new SqlParameter("@TitleColor", SqlDbType.VarChar,20),
					new SqlParameter("@IsComment", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.Content1;
            parameters[4].Value = model.Content2;
            parameters[5].Value = model.Introduction;
            parameters[6].Value = model.TypeID;
            parameters[7].Value = model.STypeID;
            parameters[8].Value = model.AddDate;
            parameters[9].Value = model.ModifyDate;
            parameters[10].Value = model.BrowseCount;
            parameters[11].Value = model.CommendDate;
            parameters[12].Value = model.State;
            parameters[13].Value = model.Tags;
            parameters[14].Value = model.Image;
            parameters[15].Value = model.IsCommend;
            parameters[16].Value = model.IsTop;
            parameters[17].Value = model.IsEssence;
            parameters[18].Value = model.IsPermissions;
            parameters[19].Value = model.WebSiteID;
            parameters[20].Value = model.Author;
            parameters[21].Value = model.Source;
            parameters[22].Value = model.CommentCount;
            parameters[23].Value = model.UserName;
            parameters[24].Value = model.FileURL;
            parameters[25].Value = model.FileName;
            parameters[26].Value = model.IsCrawl;
            parameters[27].Value = model.IsAudit;
            parameters[28].Value = model.AuditDate;
            parameters[29].Value = model.AuditMember;
            parameters[30].Value = model.OrderBy;
            parameters[31].Value = model.CitationTitle;
            parameters[32].Value = model.SubTitle;
            parameters[33].Value = model.Link;
            parameters[34].Value = model.TitleColor;
            parameters[35].Value = model.IsComment;
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
            strSql.Append("delete from SW_HelpCenter ");
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
            strSql.Append("delete from SW_HelpCenter ");
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
        public WebSite.Model.Mod_HelpCenter GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,Title,Content1,Content2,Introduction,TypeID,STypeID,AddDate,ModifyDate,BrowseCount,CommendDate,State,Tags,Image,IsCommend,IsTop,IsEssence,IsPermissions,WebSiteID,Author,Source,CommentCount,UserName,FileURL,FileName,IsCrawl,IsAudit,AuditDate,AuditMember,OrderBy,CitationTitle,SubTitle,Link,TitleColor,IsComment from SW_HelpCenter ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_HelpCenter model = new WebSite.Model.Mod_HelpCenter();
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
        public WebSite.Model.Mod_HelpCenter DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_HelpCenter model = new WebSite.Model.Mod_HelpCenter();
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
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["Content1"] != null)
                {
                    model.Content1 = row["Content1"].ToString();
                }
                if (row["Content2"] != null)
                {
                    model.Content2 = row["Content2"].ToString();
                }
                if (row["Introduction"] != null)
                {
                    model.Introduction = row["Introduction"].ToString();
                }
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["STypeID"] != null && row["STypeID"].ToString() != "")
                {
                    model.STypeID = int.Parse(row["STypeID"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
                {
                    model.ModifyDate = DateTime.Parse(row["ModifyDate"].ToString());
                }
                if (row["BrowseCount"] != null && row["BrowseCount"].ToString() != "")
                {
                    model.BrowseCount = int.Parse(row["BrowseCount"].ToString());
                }
                if (row["CommendDate"] != null && row["CommendDate"].ToString() != "")
                {
                    model.CommendDate = DateTime.Parse(row["CommendDate"].ToString());
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["Tags"] != null)
                {
                    model.Tags = row["Tags"].ToString();
                }
                if (row["Image"] != null)
                {
                    model.Image = row["Image"].ToString();
                }
                if (row["IsCommend"] != null && row["IsCommend"].ToString() != "")
                {
                    model.IsCommend = int.Parse(row["IsCommend"].ToString());
                }
                if (row["IsTop"] != null && row["IsTop"].ToString() != "")
                {
                    model.IsTop = int.Parse(row["IsTop"].ToString());
                }
                if (row["IsEssence"] != null && row["IsEssence"].ToString() != "")
                {
                    model.IsEssence = int.Parse(row["IsEssence"].ToString());
                }
                if (row["IsPermissions"] != null && row["IsPermissions"].ToString() != "")
                {
                    model.IsPermissions = int.Parse(row["IsPermissions"].ToString());
                }
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
                if (row["Author"] != null)
                {
                    model.Author = row["Author"].ToString();
                }
                if (row["Source"] != null)
                {
                    model.Source = row["Source"].ToString();
                }
                if (row["CommentCount"] != null && row["CommentCount"].ToString() != "")
                {
                    model.CommentCount = int.Parse(row["CommentCount"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["FileURL"] != null)
                {
                    model.FileURL = row["FileURL"].ToString();
                }
                if (row["FileName"] != null)
                {
                    model.FileName = row["FileName"].ToString();
                }
                if (row["IsCrawl"] != null && row["IsCrawl"].ToString() != "")
                {
                    model.IsCrawl = int.Parse(row["IsCrawl"].ToString());
                }
                if (row["IsAudit"] != null && row["IsAudit"].ToString() != "")
                {
                    model.IsAudit = int.Parse(row["IsAudit"].ToString());
                }
                if (row["AuditDate"] != null && row["AuditDate"].ToString() != "")
                {
                    model.AuditDate = DateTime.Parse(row["AuditDate"].ToString());
                }
                if (row["AuditMember"] != null && row["AuditMember"].ToString() != "")
                {
                    model.AuditMember = int.Parse(row["AuditMember"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["CitationTitle"] != null)
                {
                    model.CitationTitle = row["CitationTitle"].ToString();
                }
                if (row["SubTitle"] != null)
                {
                    model.SubTitle = row["SubTitle"].ToString();
                }
                if (row["Link"] != null)
                {
                    model.Link = row["Link"].ToString();
                }
                if (row["TitleColor"] != null)
                {
                    model.TitleColor = row["TitleColor"].ToString();
                }
                if (row["IsComment"] != null && row["IsComment"].ToString() != "")
                {
                    model.IsComment = int.Parse(row["IsComment"].ToString());
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
            strSql.Append("select ID,Model,UserID,Title,Content1,Content2,Introduction,TypeID,STypeID,AddDate,ModifyDate,BrowseCount,CommendDate,State,Tags,Image,IsCommend,IsTop,IsEssence,IsPermissions,WebSiteID,Author,Source,CommentCount,UserName,FileURL,FileName,IsCrawl,IsAudit,AuditDate,AuditMember,OrderBy,CitationTitle,SubTitle,Link,TitleColor,IsComment ");
            strSql.Append(" FROM SW_HelpCenter ");
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
            strSql.Append(" ID,Model,UserID,Title,Content1,Content2,Introduction,TypeID,STypeID,AddDate,ModifyDate,BrowseCount,CommendDate,State,Tags,Image,IsCommend,IsTop,IsEssence,IsPermissions,WebSiteID,Author,Source,CommentCount,UserName,FileURL,FileName,IsCrawl,IsAudit,AuditDate,AuditMember,OrderBy,CitationTitle,SubTitle,Link,TitleColor,IsComment ");
            strSql.Append(" FROM SW_HelpCenter ");
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
            strSql.Append("select count(1) FROM SW_HelpCenter ");
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
                strSql = "select top " + endIndex + " * from SW_HelpCenter where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_HelpCenter where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_HelpCenter where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_HelpCenter";
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
        public WebSite.Model.Mod_HelpCenter GetModelType(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,Title,Content1,Content2,Introduction,TypeID,STypeID,AddDate,ModifyDate,BrowseCount,CommendDate,State,Tags,Image,IsCommend,IsTop,IsEssence,IsPermissions,WebSiteID,Author,Source,CommentCount,UserName,FileURL,FileName,IsCrawl,IsAudit,AuditDate,AuditMember,OrderBy,CitationTitle,SubTitle,Link,TitleColor,IsComment from SW_HelpCenter ");
            strSql.Append(" where TypeID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_HelpCenter model = new WebSite.Model.Mod_HelpCenter();
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
        /// 获取下一篇
        /// </summary>
        /// <param name="ModelInfo"></param>
        /// <returns></returns>
        public WebSite.Model.Mod_HelpCenter GetNextInfo(WebSite.Model.Mod_HelpCenter ModelInfo)
        {
            //按时间来
            //string strSql = "Select top 1 * from SW_HelpCenter WHERE AddDate>'" + ModelInfo.AddDate + "' and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " order by AddDate ASC";
            //按ID来
            string strSql = "Select top 1 * from SW_HelpCenter WHERE ID>" + ModelInfo.ID + " and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " And Model='" + ModelInfo.Model + "' order by ID ASC";

            WebSite.Model.Mod_HelpCenter model = new WebSite.Model.Mod_HelpCenter();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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
        /// 获取上一篇
        /// </summary>
        /// <param name="ModelInfo"></param>
        /// <returns></returns>
        public WebSite.Model.Mod_HelpCenter GetLastInfo(WebSite.Model.Mod_HelpCenter ModelInfo)
        {
            //按时间来
            //string strSql = "Select top 1 * from SW_HelpCenter WHERE AddDate<'" + ModelInfo.AddDate + "' and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " order by AddDate DESC";
            //按ID来
            string strSql = "Select top 1 * from SW_HelpCenter WHERE ID<" + ModelInfo.ID + " and ID!=" + ModelInfo.ID + " AND  TypeID=" + ModelInfo.TypeID + " And Model='" + ModelInfo.Model + "' order by ID DESC";

            WebSite.Model.Mod_HelpCenter model = new WebSite.Model.Mod_HelpCenter();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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

