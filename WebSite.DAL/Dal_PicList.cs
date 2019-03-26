using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
using System.Collections.Generic;
using WebSite.Model;
using WebSite.Common;
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_PicList
    /// </summary>
    public partial class Dal_PicList
    {
        public Dal_PicList()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_PicList");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_PicList");
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
        public int Add(WebSite.Model.Mod_PicList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_PicList(");
            strSql.Append("Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault)");
            strSql.Append(" values (");
            strSql.Append("@Model,@TypeID,@ProductID,@ImgUrl,@Title,@ViceTitle,@Info,@ThumbUrl,@MidUrl,@OriginalUrl,@OrderBy,@State,@IsDefault)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.ProductID;
            parameters[3].Value = model.ImgUrl;
            parameters[4].Value = model.Title;
            parameters[5].Value = model.ViceTitle;
            parameters[6].Value = model.Info;
            parameters[7].Value = model.ThumbUrl;
            parameters[8].Value = model.MidUrl;
            parameters[9].Value = model.OriginalUrl;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.State;
            parameters[12].Value = model.IsDefault;

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
        public bool Update(WebSite.Model.Mod_PicList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_PicList set ");
            strSql.Append("Model=@Model,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("ProductID=@ProductID,");
            strSql.Append("ImgUrl=@ImgUrl,");
            strSql.Append("Title=@Title,");
            strSql.Append("ViceTitle=@ViceTitle,");
            strSql.Append("Info=@Info,");
            strSql.Append("ThumbUrl=@ThumbUrl,");
            strSql.Append("MidUrl=@MidUrl,");
            strSql.Append("OriginalUrl=@OriginalUrl,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("State=@State,");
            strSql.Append("IsDefault=@IsDefault");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.ProductID;
            parameters[3].Value = model.ImgUrl;
            parameters[4].Value = model.Title;
            parameters[5].Value = model.ViceTitle;
            parameters[6].Value = model.Info;
            parameters[7].Value = model.ThumbUrl;
            parameters[8].Value = model.MidUrl;
            parameters[9].Value = model.OriginalUrl;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.State;
            parameters[12].Value = model.IsDefault;
            parameters[13].Value = model.ID;

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
            strSql.Append("delete from SW_PicList ");
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
            strSql.Append("delete from SW_PicList ");
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
        public WebSite.Model.Mod_PicList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault from SW_PicList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_PicList model = new WebSite.Model.Mod_PicList();
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
        public WebSite.Model.Mod_PicList DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_PicList model = new WebSite.Model.Mod_PicList();
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
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["ProductID"] != null && row["ProductID"].ToString() != "")
                {
                    model.ProductID = int.Parse(row["ProductID"].ToString());
                }
                if (row["ImgUrl"] != null)
                {
                    model.ImgUrl = row["ImgUrl"].ToString();
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["ViceTitle"] != null)
                {
                    model.ViceTitle = row["ViceTitle"].ToString();
                }
                if (row["Info"] != null)
                {
                    model.Info = row["Info"].ToString();
                }
                if (row["ThumbUrl"] != null)
                {
                    model.ThumbUrl = row["ThumbUrl"].ToString();
                }
                if (row["MidUrl"] != null)
                {
                    model.MidUrl = row["MidUrl"].ToString();
                }
                if (row["OriginalUrl"] != null)
                {
                    model.OriginalUrl = row["OriginalUrl"].ToString();
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["IsDefault"] != null && row["IsDefault"].ToString() != "")
                {
                    model.IsDefault = int.Parse(row["IsDefault"].ToString());
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
            strSql.Append("select ID,Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault ");
            strSql.Append(" FROM SW_PicList ");
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
            strSql.Append(" ID,Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault ");
            strSql.Append(" FROM SW_PicList ");
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
            strSql.Append("select count(1) FROM SW_PicList ");
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
                strSql = "select top " + endIndex + " * from SW_PicList where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_PicList where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_PicList where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_PicList";
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
        /// 修改图片数据，有的就更新没有的就添加
        /// 查找不存在的图片并删除已删除的图片及数据
        /// </summary>
        public bool OperateList(List<Mod_PicList> models, int ProductID, bool IsDel)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        if (models != null)
                        {
                            //删除已删除的图片
                            DeleteList(conn, trans, models, ProductID, IsDel);
                            //添加/修改相册
                            ModifyList(conn, trans, models, ProductID);
                        }
                        else
                        {
                            DeleteFile(conn, trans, ProductID.ToString(), IsDel);
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

        /// <summary>
        /// 修改图片数据，有的就更新没有的就添加
        /// </summary>
        public void ModifyList(SqlConnection conn, SqlTransaction trans, List<Mod_PicList> models, int ProductID)
        {
            if (models != null)
            {
                StringBuilder strSql;
                foreach (Mod_PicList model in models)
                {
                    strSql = new StringBuilder();
                    if (model.ID > 0)
                    {
                        strSql.Append("update SW_PicList set ");
                        strSql.Append("Model=@Model,");
                        strSql.Append("TypeID=@TypeID,");
                        strSql.Append("ProductID=@ProductID,");
                        strSql.Append("ImgUrl=@ImgUrl,");
                        strSql.Append("Title=@Title,");
                        strSql.Append("ViceTitle=@ViceTitle,");
                        strSql.Append("Info=@Info,");
                        strSql.Append("ThumbUrl=@ThumbUrl,");
                        strSql.Append("MidUrl=@MidUrl,");
                        strSql.Append("OriginalUrl=@OriginalUrl,");
                        strSql.Append("OrderBy=@OrderBy,");
                        strSql.Append("State=@State,");
                        strSql.Append("IsDefault=@IsDefault");
                        strSql.Append(" where ID=@ID");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@Model", SqlDbType.VarChar,50),
					                        new SqlParameter("@TypeID", SqlDbType.Int,4),
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@Title", SqlDbType.VarChar,200),
					                        new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					                        new SqlParameter("@Info", SqlDbType.Text),
					                        new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@OrderBy", SqlDbType.Int,4),
					                        new SqlParameter("@State", SqlDbType.Int,4),
					                        new SqlParameter("@IsDefault", SqlDbType.Int,4),
					                        new SqlParameter("@ID", SqlDbType.Int,4)};
                        parameters[0].Value = model.Model;
                        parameters[1].Value = model.TypeID;
                        parameters[2].Value = ProductID;
                        parameters[3].Value = model.ImgUrl;
                        parameters[4].Value = model.Title;
                        parameters[5].Value = model.ViceTitle;
                        parameters[6].Value = model.Info;
                        parameters[7].Value = model.ThumbUrl;
                        parameters[8].Value = model.MidUrl;
                        parameters[9].Value = model.OriginalUrl;
                        parameters[10].Value = model.OrderBy;
                        parameters[11].Value = model.State;
                        parameters[12].Value = model.IsDefault;
                        parameters[13].Value = model.ID;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                    else
                    {
                        strSql.Append("insert into SW_PicList(");
                        strSql.Append("Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault)");
                        strSql.Append(" values (");
                        strSql.Append("@Model,@TypeID,@ProductID,@ImgUrl,@Title,@ViceTitle,@Info,@ThumbUrl,@MidUrl,@OriginalUrl,@OrderBy,@State,@IsDefault)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@Model", SqlDbType.VarChar,50),
					                        new SqlParameter("@TypeID", SqlDbType.Int,4),
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@ImgUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@Title", SqlDbType.VarChar,200),
					                        new SqlParameter("@ViceTitle", SqlDbType.VarChar,200),
					                        new SqlParameter("@Info", SqlDbType.Text),
					                        new SqlParameter("@ThumbUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@MidUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@OriginalUrl", SqlDbType.VarChar,500),
					                        new SqlParameter("@OrderBy", SqlDbType.Int,4),
					                        new SqlParameter("@State", SqlDbType.Int,4),
					                        new SqlParameter("@IsDefault", SqlDbType.Int,4)};
                        parameters[0].Value = model.Model;
                        parameters[1].Value = model.TypeID;
                        parameters[2].Value = ProductID;
                        parameters[3].Value = model.ImgUrl;
                        parameters[4].Value = model.Title;
                        parameters[5].Value = model.ViceTitle;
                        parameters[6].Value = model.Info;
                        parameters[7].Value = model.ThumbUrl;
                        parameters[8].Value = model.MidUrl;
                        parameters[9].Value = model.OriginalUrl;
                        parameters[10].Value = model.OrderBy;
                        parameters[11].Value = model.State;
                        parameters[12].Value = model.IsDefault;

                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                }
            }
        }
        /// <summary>
        /// 查找不存在的图片并删除已删除的图片及数据
        /// </summary>
        public void DeleteList(SqlConnection conn, SqlTransaction trans, List<Mod_PicList> models, int ProductID, bool IsDel)
        {
            StringBuilder idList = new StringBuilder();
            if (models != null)
            {
                foreach (Mod_PicList modelt in models)
                {
                    if (modelt.ID > 0)
                    {
                        idList.Append(modelt.ID + ",");
                    }
                }
            }
            string id_list = idList.ToString().Trim(',');
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault from SW_PicList where ProductID=" + ProductID);
            if (!string.IsNullOrEmpty(id_list))
            {
                strSql.Append(" and id not in(" + id_list + ")");
            }
            DataSet ds = DbHelperSQL.Query(conn, trans, strSql.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int rows = DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_PicList where id=" + dr["id"].ToString()); //删除数据库
                if (rows > 0)
                {
                    if (IsDel)
                    {
                        FileOperate.DeleteFile(dr["ThumbUrl"].ToString()); //删除缩略图
                        FileOperate.DeleteFile(dr["OriginalUrl"].ToString()); //删除原图
                    }
                }
            }
        }

        /// <summary>
        /// 删除相册图片和数据
        /// </summary>
        public bool DeleteFile(string ProductIDStr, bool IsDel)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        //删除相册图片和数据
                        DeleteFile(conn, trans, ProductIDStr, IsDel);
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
        /// <summary>
        /// 删除相册图片
        /// </summary>
        public void DeleteFile(SqlConnection conn, SqlTransaction trans, string ProductIDStr, bool IsDel)
        {

            if (!string.IsNullOrEmpty(ProductIDStr))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ID,Model,TypeID,ProductID,ImgUrl,Title,ViceTitle,Info,ThumbUrl,MidUrl,OriginalUrl,OrderBy,State,IsDefault from SW_PicList where ProductID in(" + ProductIDStr + ")");
                DataSet ds = DbHelperSQL.Query(conn, trans, strSql.ToString());
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int rows = DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_PicList where id=" + dr["id"].ToString()); //删除数据库
                    if (rows > 0)
                    {
                        if (IsDel)
                        {
                            FileOperate.DeleteFile(dr["ThumbUrl"].ToString()); //删除缩略图
                            FileOperate.DeleteFile(dr["OriginalUrl"].ToString()); //删除原图
                        }
                    }
                }
            }
        }

        #endregion  ExtensionMethod
    }
}

