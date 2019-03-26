using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
using WebSite.Model;
using System.Collections.Generic;
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_ProductSku
    /// </summary>
    public partial class Dal_ProductSku
    {
        public Dal_ProductSku()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_ProductSku");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_ProductSku");
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
        public int Add(WebSite.Model.Mod_ProductSku model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_ProductSku(");
            strSql.Append("SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay)");
            strSql.Append(" values (");
            strSql.Append("@SkuNo,@ManufacturerNo,@ProductID,@SpecValueID,@SpecConfigID,@SpecConfigValue,@Price,@MarketPrice,@StockCount,@AddDate,@IsDisplay)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
                    new SqlParameter("@ManufacturerNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@SpecValueID", SqlDbType.VarChar,200),
					new SqlParameter("@SpecConfigID", SqlDbType.VarChar,200),
					new SqlParameter("@SpecConfigValue", SqlDbType.VarChar,2000),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IsDisplay", SqlDbType.Int,4)};
            parameters[0].Value = model.SkuNo;
            parameters[1].Value = model.ManufacturerNo;
            parameters[2].Value = model.ProductID;
            parameters[3].Value = model.SpecValueID;
            parameters[4].Value = model.SpecConfigID;
            parameters[5].Value = model.SpecConfigValue;
            parameters[6].Value = model.Price;
            parameters[7].Value = model.MarketPrice;
            parameters[8].Value = model.StockCount;
            parameters[9].Value = model.AddDate;
            parameters[10].Value = model.IsDisplay;

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
        public bool Update(WebSite.Model.Mod_ProductSku model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_ProductSku set ");
            strSql.Append("SkuNo=@SkuNo,");
            strSql.Append("ManufacturerNo=@ManufacturerNo,");
            strSql.Append("ProductID=@ProductID,");
            strSql.Append("SpecValueID=@SpecValueID,");
            strSql.Append("SpecConfigID=@SpecConfigID,");
            strSql.Append("SpecConfigValue=@SpecConfigValue,");
            strSql.Append("Price=@Price,");
            strSql.Append("MarketPrice=@MarketPrice,");
            strSql.Append("StockCount=@StockCount,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("IsDisplay=@IsDisplay");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
                    new SqlParameter("@ManufacturerNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@SpecValueID", SqlDbType.VarChar,200),
					new SqlParameter("@SpecConfigID", SqlDbType.VarChar,200),
					new SqlParameter("@SpecConfigValue", SqlDbType.VarChar,2000),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IsDisplay", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.SkuNo;
            parameters[1].Value = model.ManufacturerNo;
            parameters[2].Value = model.ProductID;
            parameters[3].Value = model.SpecValueID;
            parameters[4].Value = model.SpecConfigID;
            parameters[5].Value = model.SpecConfigValue;
            parameters[6].Value = model.Price;
            parameters[7].Value = model.MarketPrice;
            parameters[8].Value = model.StockCount;
            parameters[9].Value = model.AddDate;
            parameters[10].Value = model.IsDisplay;
            parameters[11].Value = model.ID;

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
            strSql.Append("delete from SW_ProductSku ");
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
            strSql.Append("delete from SW_ProductSku ");
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
        public WebSite.Model.Mod_ProductSku GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay from SW_ProductSku ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_ProductSku model = new WebSite.Model.Mod_ProductSku();
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
        public WebSite.Model.Mod_ProductSku DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_ProductSku model = new WebSite.Model.Mod_ProductSku();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["SkuNo"] != null)
                {
                    model.SkuNo = row["SkuNo"].ToString();
                }
                if (row["ManufacturerNo"] != null)
                {
                    model.ManufacturerNo = row["ManufacturerNo"].ToString();
                }
                if (row["ProductID"] != null && row["ProductID"].ToString() != "")
                {
                    model.ProductID = int.Parse(row["ProductID"].ToString());
                }
                if (row["SpecValueID"] != null)
                {
                    model.SpecValueID = row["SpecValueID"].ToString();
                }
                if (row["SpecConfigID"] != null)
                {
                    model.SpecConfigID = row["SpecConfigID"].ToString();
                }
                if (row["SpecConfigValue"] != null)
                {
                    model.SpecConfigValue = row["SpecConfigValue"].ToString();
                }
                if (row["Price"] != null && row["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(row["Price"].ToString());
                }
                if (row["MarketPrice"] != null && row["MarketPrice"].ToString() != "")
                {
                    model.MarketPrice = decimal.Parse(row["MarketPrice"].ToString());
                }
                if (row["StockCount"] != null && row["StockCount"].ToString() != "")
                {
                    model.StockCount = int.Parse(row["StockCount"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["IsDisplay"] != null && row["IsDisplay"].ToString() != "")
                {
                    model.IsDisplay = int.Parse(row["IsDisplay"].ToString());
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
            strSql.Append("select ID,SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay ");
            strSql.Append(" FROM SW_ProductSku ");
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
            strSql.Append(" ID,SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay ");
            strSql.Append(" FROM SW_ProductSku ");
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
            strSql.Append("select count(1) FROM SW_ProductSku ");
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
                strSql = "select top " + endIndex + " * from SW_ProductSku where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductSku where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductSku where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_ProductSku";
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
        /// 删除数据
        /// </summary>
        public bool Delete(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_ProductSku ");
            strSql.Append(" where " + strWhere + " ");
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
        public WebSite.Model.Mod_ProductSku GetModel(int ProductID, string SpecConfigValue)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay from SW_ProductSku ");
            strSql.Append(" where ProductID=@ProductID and SpecConfigValue=@SpecConfigValue ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
                    new SqlParameter("@SpecConfigValue", SqlDbType.VarChar,500)
			};
            parameters[0].Value = ProductID;
            parameters[1].Value = SpecConfigValue;

            WebSite.Model.Mod_ProductSku model = new WebSite.Model.Mod_ProductSku();
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
        /// 修改数据，有的就更新没有的就添加
        /// </summary>
        public bool OperateList(List<Mod_ProductSku> models, int ProductID)
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
        public void ModifyList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductSku> models, int ProductID)
        {
            if (models != null)
            {
                StringBuilder strSql;
                foreach (Mod_ProductSku model in models)
                {
                    strSql = new StringBuilder();
                    if (model.ID > 0)
                    {
                        strSql.Append("update SW_ProductSku set ");
                        strSql.Append("SkuNo=@SkuNo,");
                        strSql.Append("ManufacturerNo=@ManufacturerNo,");
                        strSql.Append("ProductID=@ProductID,");
                        strSql.Append("SpecValueID=@SpecValueID,");
                        strSql.Append("SpecConfigID=@SpecConfigID,");
                        strSql.Append("SpecConfigValue=@SpecConfigValue,");
                        strSql.Append("Price=@Price,");
                        strSql.Append("MarketPrice=@MarketPrice,");
                        strSql.Append("StockCount=@StockCount,");
                        strSql.Append("AddDate=@AddDate,");
                        strSql.Append("IsDisplay=@IsDisplay");
                        strSql.Append(" where ID=@ID");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
                                            new SqlParameter("@ManufacturerNo", SqlDbType.VarChar,50),
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@SpecValueID", SqlDbType.VarChar,200),
					                        new SqlParameter("@SpecConfigID", SqlDbType.VarChar,200),
					                        new SqlParameter("@SpecConfigValue", SqlDbType.VarChar,2000),
					                        new SqlParameter("@Price", SqlDbType.Decimal,9),
					                        new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					                        new SqlParameter("@StockCount", SqlDbType.Int,4),
					                        new SqlParameter("@AddDate", SqlDbType.DateTime),
					                        new SqlParameter("@IsDisplay", SqlDbType.Int,4),
					                        new SqlParameter("@ID", SqlDbType.Int,4)};
                        parameters[0].Value = model.SkuNo;
                        parameters[1].Value = model.ManufacturerNo;
                        parameters[2].Value = ProductID;
                        parameters[3].Value = model.SpecValueID;
                        parameters[4].Value = model.SpecConfigID;
                        parameters[5].Value = model.SpecConfigValue;
                        parameters[6].Value = model.Price;
                        parameters[7].Value = model.MarketPrice;
                        parameters[8].Value = model.StockCount;
                        parameters[9].Value = model.AddDate;
                        parameters[10].Value = model.IsDisplay;
                        parameters[11].Value = model.ID;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                    else
                    {
                        strSql.Append("insert into SW_ProductSku(");
                        strSql.Append("SkuNo,ManufacturerNo,ProductID,SpecValueID,SpecConfigID,SpecConfigValue,Price,MarketPrice,StockCount,AddDate,IsDisplay)");
                        strSql.Append(" values (");
                        strSql.Append("@SkuNo,@ManufacturerNo,@ProductID,@SpecValueID,@SpecConfigID,@SpecConfigValue,@Price,@MarketPrice,@StockCount,@AddDate,@IsDisplay)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters = {
					                        new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
                                            new SqlParameter("@ManufacturerNo", SqlDbType.VarChar,50),
					                        new SqlParameter("@ProductID", SqlDbType.Int,4),
					                        new SqlParameter("@SpecValueID", SqlDbType.VarChar,200),
					                        new SqlParameter("@SpecConfigID", SqlDbType.VarChar,200),
					                        new SqlParameter("@SpecConfigValue", SqlDbType.VarChar,2000),
					                        new SqlParameter("@Price", SqlDbType.Decimal,9),
					                        new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					                        new SqlParameter("@StockCount", SqlDbType.Int,4),
					                        new SqlParameter("@AddDate", SqlDbType.DateTime),
					                        new SqlParameter("@IsDisplay", SqlDbType.Int,4)};
                        parameters[0].Value = model.SkuNo;
                        parameters[1].Value = model.ManufacturerNo;
                        parameters[2].Value = ProductID;
                        parameters[3].Value = model.SpecValueID;
                        parameters[4].Value = model.SpecConfigID;
                        parameters[5].Value = model.SpecConfigValue;
                        parameters[6].Value = model.Price;
                        parameters[7].Value = model.MarketPrice;
                        parameters[8].Value = model.StockCount;
                        parameters[9].Value = model.AddDate;
                        parameters[10].Value = model.IsDisplay;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                }
            }
        }
        /// <summary>
        /// 查找不存在的并删除
        /// </summary>
        public void DeleteList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductSku> models, int ProductID)
        {
            StringBuilder idList = new StringBuilder();
            if (models != null)
            {
                foreach (Mod_ProductSku modelt in models)
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
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductSku where id not in(" + id_list + ") and ProductID=" + ProductID + " ");
            }
            else
            {
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductSku where ProductID=" + ProductID + " ");
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string WhereStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_ProductSku ");
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

