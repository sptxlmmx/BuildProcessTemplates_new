using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
using WebSite.Model;
using System.Collections.Generic;
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_ProductAttrValue
    /// </summary>
    public partial class Dal_ProductAttrValue
    {
        public Dal_ProductAttrValue()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_ProductAttrValue");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_ProductAttrValue");
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
        public int Add(WebSite.Model.Mod_ProductAttrValue model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_ProductAttrValue(");
            strSql.Append("ProductID,ProductAttrID,AttrTitle,AttrValue)");
            strSql.Append(" values (");
            strSql.Append("@ProductID,@ProductAttrID,@AttrTitle,@AttrValue)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductAttrID", SqlDbType.Int,4),
                    new SqlParameter("@AttrTitle", SqlDbType.VarChar,200),
					new SqlParameter("@AttrValue", SqlDbType.Text)};
            parameters[0].Value = model.ProductID;
            parameters[1].Value = model.ProductAttrID;
            parameters[2].Value = model.AttrTitle;
            parameters[3].Value = model.AttrValue;

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
        public bool Update(WebSite.Model.Mod_ProductAttrValue model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_ProductAttrValue set ");
            strSql.Append("ProductID=@ProductID,");
            strSql.Append("ProductAttrID=@ProductAttrID,");
            strSql.Append("AttrTitle=@AttrTitle,");
            strSql.Append("AttrValue=@AttrValue");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductAttrID", SqlDbType.Int,4),
                    new SqlParameter("@AttrTitle", SqlDbType.VarChar,200),
					new SqlParameter("@AttrValue", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ProductID;
            parameters[1].Value = model.ProductAttrID;
            parameters[2].Value = model.AttrTitle;
            parameters[3].Value = model.AttrValue;
            parameters[4].Value = model.ID;

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
            strSql.Append("delete from SW_ProductAttrValue ");
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
            strSql.Append("delete from SW_ProductAttrValue ");
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
        public WebSite.Model.Mod_ProductAttrValue GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ProductID,ProductAttrID,AttrTitle,AttrValue from SW_ProductAttrValue ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_ProductAttrValue model = new WebSite.Model.Mod_ProductAttrValue();
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
        public WebSite.Model.Mod_ProductAttrValue DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_ProductAttrValue model = new WebSite.Model.Mod_ProductAttrValue();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["ProductID"] != null && row["ProductID"].ToString() != "")
                {
                    model.ProductID = int.Parse(row["ProductID"].ToString());
                }
                if (row["ProductAttrID"] != null && row["ProductAttrID"].ToString() != "")
                {
                    model.ProductAttrID = int.Parse(row["ProductAttrID"].ToString());
                }
                if (row["AttrTitle"] != null)
                {
                    model.AttrTitle = row["AttrTitle"].ToString();
                }
                if (row["AttrValue"] != null)
                {
                    model.AttrValue = row["AttrValue"].ToString();
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
            strSql.Append("select ID,ProductID,ProductAttrID,AttrTitle,AttrValue ");
            strSql.Append(" FROM SW_ProductAttrValue ");
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
            strSql.Append(" ID,ProductID,ProductAttrID,AttrTitle,AttrValue ");
            strSql.Append(" FROM SW_ProductAttrValue ");
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
            strSql.Append("select count(1) FROM SW_ProductAttrValue ");
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
                strSql = "select top " + endIndex + " * from SW_ProductAttrValue where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductAttrValue where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductAttrValue where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_ProductAttrValue";
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
        /// 修改数据，有的就更新没有的就添加
        /// </summary>
        public bool OperateList(List<Mod_ProductAttrValue> models, int ProductID)
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
                            //删除已删除的
                            DeleteList(conn, trans, models, ProductID);
                            //添加/修改
                            ModifyList(conn, trans, models, ProductID);
                        }
                        else 
                        {
                            DeleteWhere(" ProductID=" + ProductID);
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
        /// 修改数据，有的就更新没有的就添加
        /// </summary>
        public void ModifyList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductAttrValue> models, int ProductID)
        {
            if (models != null)
            {
                StringBuilder strSql;
                foreach (Mod_ProductAttrValue model in models)
                {
                    strSql = new StringBuilder();
                    if (model.ID > 0)
                    {
                        strSql.Append("update SW_ProductAttrValue set ");
                        strSql.Append("ProductID=@ProductID,");
                        strSql.Append("ProductAttrID=@ProductAttrID,");
                        strSql.Append("AttrTitle=@AttrTitle,");
                        strSql.Append("AttrValue=@AttrValue");
                        strSql.Append(" where ID=@ID");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@ProductAttrID", SqlDbType.Int,4),
                                            new SqlParameter("@AttrTitle", SqlDbType.VarChar,200),
					                        new SqlParameter("@AttrValue", SqlDbType.Text),
					                        new SqlParameter("@ID", SqlDbType.Int,4)};
                        parameters[0].Value = ProductID;
                        parameters[1].Value = model.ProductAttrID;
                        parameters[2].Value = model.AttrTitle;
                        parameters[3].Value = model.AttrValue;
                        parameters[4].Value = model.ID;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                    else
                    {
                        strSql.Append("insert into SW_ProductAttrValue(");
                        strSql.Append("ProductID,ProductAttrID,AttrTitle,AttrValue)");
                        strSql.Append(" values (");
                        strSql.Append("@ProductID,@ProductAttrID,@AttrTitle,@AttrValue)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@ProductAttrID", SqlDbType.Int,4),
                                            new SqlParameter("@AttrTitle", SqlDbType.VarChar,200),
					                        new SqlParameter("@AttrValue", SqlDbType.Text)};
                        parameters[0].Value = ProductID;
                        parameters[1].Value = model.ProductAttrID;
                        parameters[2].Value = model.AttrTitle;
                        parameters[3].Value = model.AttrValue;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                }
            }
        }
        /// <summary>
        /// 查找不存在的并删除
        /// </summary>
        public void DeleteList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductAttrValue> models, int ProductID)
        {
            StringBuilder idList = new StringBuilder();
            if (models != null)
            {
                foreach (Mod_ProductAttrValue modelt in models)
                {
                    if (modelt.ID > 0)
                    {
                        idList.Append(modelt.ID + ",");
                    }
                }
            }
            string id_list = idList.ToString().Trim(',');
            if (!string.IsNullOrEmpty(id_list))
            {
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductAttrValue where id not in(" + id_list + ") and ProductID=" + ProductID + " ");
            }
            else
            {
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductAttrValue where ProductID=" + ProductID + " ");
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string WhereStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_ProductAttrValue ");
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
        #endregion  ExtensionMethod
    }
}

