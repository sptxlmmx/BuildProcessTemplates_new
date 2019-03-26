
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
using System.Collections.Generic;
using WebSite.Model;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_ProductColourType
	/// </summary>
	public partial class Dal_ProductColourType
	{
		public Dal_ProductColourType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_ProductColourType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_ProductColourType");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebSite.Model.Mod_ProductColourType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_ProductColourType(");
			strSql.Append("Model,ProductID,Title,Image,Integral,Integral2,Sum,IsRecommend,AddDate,OrderBy,State,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@ProductID,@Title,@Image,@Integral,@Integral2,@Sum,@IsRecommend,@AddDate,@OrderBy,@State,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,150),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,300),
					new SqlParameter("@Image", SqlDbType.NVarChar,500),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductID;
			parameters[2].Value = model.Title;
			parameters[3].Value = model.Image;
			parameters[4].Value = model.Integral;
			parameters[5].Value = model.Integral2;
			parameters[6].Value = model.Sum;
			parameters[7].Value = model.IsRecommend;
			parameters[8].Value = model.AddDate;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.State;
			parameters[11].Value = model.WebSiteID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(WebSite.Model.Mod_ProductColourType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_ProductColourType set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("Title=@Title,");
			strSql.Append("Image=@Image,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("Integral2=@Integral2,");
			strSql.Append("Sum=@Sum,");
			strSql.Append("IsRecommend=@IsRecommend,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,150),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,300),
					new SqlParameter("@Image", SqlDbType.NVarChar,500),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductID;
			parameters[2].Value = model.Title;
			parameters[3].Value = model.Image;
			parameters[4].Value = model.Integral;
			parameters[5].Value = model.Integral2;
			parameters[6].Value = model.Sum;
			parameters[7].Value = model.IsRecommend;
			parameters[8].Value = model.AddDate;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.State;
			parameters[11].Value = model.WebSiteID;
			parameters[12].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SW_ProductColourType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SW_ProductColourType ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public WebSite.Model.Mod_ProductColourType GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,ProductID,Title,Image,Integral,Integral2,Sum,IsRecommend,AddDate,OrderBy,State,WebSiteID from SW_ProductColourType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_ProductColourType model=new WebSite.Model.Mod_ProductColourType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public WebSite.Model.Mod_ProductColourType DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_ProductColourType model=new WebSite.Model.Mod_ProductColourType();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["ProductID"]!=null && row["ProductID"].ToString()!="")
				{
					model.ProductID=int.Parse(row["ProductID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["Integral2"]!=null && row["Integral2"].ToString()!="")
				{
					model.Integral2=int.Parse(row["Integral2"].ToString());
				}
				if(row["Sum"]!=null && row["Sum"].ToString()!="")
				{
					model.Sum=int.Parse(row["Sum"].ToString());
				}
				if(row["IsRecommend"]!=null && row["IsRecommend"].ToString()!="")
				{
					model.IsRecommend=int.Parse(row["IsRecommend"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Model,ProductID,Title,Image,Integral,Integral2,Sum,IsRecommend,AddDate,OrderBy,State,WebSiteID ");
			strSql.Append(" FROM SW_ProductColourType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Model,ProductID,Title,Image,Integral,Integral2,Sum,IsRecommend,AddDate,OrderBy,State,WebSiteID ");
			strSql.Append(" FROM SW_ProductColourType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SW_ProductColourType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
                strSql = "select top " + endIndex + " * from SW_ProductColourType where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductColourType where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductColourType where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_ProductColourType";
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListMAX(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(Integral)as maxs,MIN(Integral)as mins");
            strSql.Append(" FROM SW_ProductColourType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 修改数据，有的就更新没有的就添加
        /// </summary>
        public bool OperateList(List<Mod_ProductColourType> models, int ProductID)
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
        public void ModifyList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductColourType> models, int ProductID)
        {
            if (models != null)
            {
                StringBuilder strSql;
                foreach (Mod_ProductColourType model in models)
                {
                    strSql = new StringBuilder();
                    if (model.ID > 0)
                    {
                        strSql.Append("update SW_ProductColourType set ");
                        strSql.Append("Model=@Model,");
                        strSql.Append("ProductID=@ProductID,");
                        strSql.Append("Title=@Title,");
                        strSql.Append("Image=@Image,");
                        strSql.Append("Integral=@Integral,");
                        strSql.Append("Integral2=@Integral2,");
                        strSql.Append("Sum=@Sum,");
                        strSql.Append("IsRecommend=@IsRecommend,");
                        strSql.Append("AddDate=@AddDate,");
                        strSql.Append("OrderBy=@OrderBy,");
                        strSql.Append("State=@State,");
                        strSql.Append("WebSiteID=@WebSiteID");
                        strSql.Append(" where ID=@ID");
                        SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,150),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,300),
					new SqlParameter("@Image", SqlDbType.NVarChar,500),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
                        parameters[0].Value = model.Model;
                        parameters[1].Value = model.ProductID;
                        parameters[2].Value = model.Title;
                        parameters[3].Value = model.Image;
                        parameters[4].Value = model.Integral;
                        parameters[5].Value = model.Integral2;
                        parameters[6].Value = model.Sum;
                        parameters[7].Value = model.IsRecommend;
                        parameters[8].Value = model.AddDate;
                        parameters[9].Value = model.OrderBy;
                        parameters[10].Value = model.State;
                        parameters[11].Value = model.WebSiteID;
                        parameters[12].Value = model.ID;

                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                    else
                    {
                        strSql.Append("insert into SW_ProductColourType(");
                        strSql.Append("Model,ProductID,Title,Image,Integral,Integral2,Sum,IsRecommend,AddDate,OrderBy,State,WebSiteID)");
                        strSql.Append(" values (");
                        strSql.Append("@Model,@ProductID,@Title,@Image,@Integral,@Integral2,@Sum,@IsRecommend,@AddDate,@OrderBy,@State,@WebSiteID)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,150),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,300),
					new SqlParameter("@Image", SqlDbType.NVarChar,500),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
                        parameters[0].Value = model.Model;
                        parameters[1].Value = model.ProductID;
                        parameters[2].Value = model.Title;
                        parameters[3].Value = model.Image;
                        parameters[4].Value = model.Integral;
                        parameters[5].Value = model.Integral2;
                        parameters[6].Value = model.Sum;
                        parameters[7].Value = model.IsRecommend;
                        parameters[8].Value = model.AddDate;
                        parameters[9].Value = model.OrderBy;
                        parameters[10].Value = model.State;
                        parameters[11].Value = model.WebSiteID;
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
                    }
                }
            }
        }
        /// <summary>
        /// 查找不存在的并删除
        /// </summary>
        public void DeleteList(SqlConnection conn, SqlTransaction trans, List<Mod_ProductColourType> models, int ProductID)
        {
            StringBuilder idList = new StringBuilder();
            if (models != null)
            {
                foreach (Mod_ProductColourType modelt in models)
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
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductColourType where id not in(" + id_list + ") and ProductID=" + ProductID + " ");
            }
            else
            {
                DbHelperSQL.ExecuteSql(conn, trans, "delete from SW_ProductColourType where ProductID=" + ProductID + " ");
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string WhereStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_ProductColourType ");
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

