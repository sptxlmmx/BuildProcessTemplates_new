using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_Payment
    /// </summary>
    public partial class Dal_Payment
    {
        public Dal_Payment()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_Payment");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_Payment");
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
        public int Add(WebSite.Model.Mod_Payment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_Payment(");
            strSql.Append("DllName,Name,Description,QueryArray,IsDisplay,OrderBy,WebSiteID,State)");
            strSql.Append(" values (");
            strSql.Append("@DllName,@Name,@Description,@QueryArray,@IsDisplay,@OrderBy,@WebSiteID,@State)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DllName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Description", SqlDbType.VarChar,1000),
					new SqlParameter("@QueryArray", SqlDbType.VarChar,2000),
					new SqlParameter("@IsDisplay", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4)};
            parameters[0].Value = model.DllName;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Description;
            parameters[3].Value = model.QueryArray;
            parameters[4].Value = model.IsDisplay;
            parameters[5].Value = model.OrderBy;
            parameters[6].Value = model.WebSiteID;
            parameters[7].Value = model.State;

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
        public bool Update(WebSite.Model.Mod_Payment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Payment set ");
            strSql.Append("DllName=@DllName,");
            strSql.Append("Name=@Name,");
            strSql.Append("Description=@Description,");
            strSql.Append("QueryArray=@QueryArray,");
            strSql.Append("IsDisplay=@IsDisplay,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("State=@State");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DllName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Description", SqlDbType.VarChar,1000),
					new SqlParameter("@QueryArray", SqlDbType.VarChar,2000),
					new SqlParameter("@IsDisplay", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.DllName;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Description;
            parameters[3].Value = model.QueryArray;
            parameters[4].Value = model.IsDisplay;
            parameters[5].Value = model.OrderBy;
            parameters[6].Value = model.WebSiteID;
            parameters[7].Value = model.State;
            parameters[8].Value = model.ID;

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
            strSql.Append("delete from SW_Payment ");
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
            strSql.Append("delete from SW_Payment ");
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
        public WebSite.Model.Mod_Payment GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DllName,Name,Description,QueryArray,IsDisplay,OrderBy,WebSiteID,State from SW_Payment ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_Payment model = new WebSite.Model.Mod_Payment();
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
        public WebSite.Model.Mod_Payment DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_Payment model = new WebSite.Model.Mod_Payment();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["DllName"] != null)
                {
                    model.DllName = row["DllName"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Description"] != null)
                {
                    model.Description = row["Description"].ToString();
                }
                if (row["QueryArray"] != null)
                {
                    model.QueryArray = row["QueryArray"].ToString();
                }
                if (row["IsDisplay"] != null && row["IsDisplay"].ToString() != "")
                {
                    model.IsDisplay = int.Parse(row["IsDisplay"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
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
            strSql.Append("select ID,DllName,Name,Description,QueryArray,IsDisplay,OrderBy,WebSiteID,State ");
            strSql.Append(" FROM SW_Payment ");
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
            strSql.Append(" ID,DllName,Name,Description,QueryArray,IsDisplay,OrderBy,WebSiteID,State ");
            strSql.Append(" FROM SW_Payment ");
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
            strSql.Append("select count(1) FROM SW_Payment ");
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
                strSql = "select top " + endIndex + " * from SW_Payment where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Payment where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Payment where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Payment";
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
            strSql.Append("delete from SW_Payment ");
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
        public WebSite.Model.Mod_Payment GetModel(string DllName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DllName,Name,Description,QueryArray,IsDisplay,OrderBy,WebSiteID,State from SW_Payment ");
            strSql.Append(" where DllName=@DllName");
            SqlParameter[] parameters = {
					new SqlParameter("@DllName", SqlDbType.VarChar,50)
			};
            parameters[0].Value = DllName;

            WebSite.Model.Mod_Payment model = new WebSite.Model.Mod_Payment();
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

