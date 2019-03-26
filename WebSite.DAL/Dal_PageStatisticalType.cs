﻿
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_PageStatisticalType
	/// </summary>
	public partial class Dal_PageStatisticalType
	{
		public Dal_PageStatisticalType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_PageStatisticalType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_PageStatisticalType");
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
		public int Add(WebSite.Model.Mod_PageStatisticalType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_PageStatisticalType(");
			strSql.Append("Model,Title,ParentID,IDPath,ColumnID,UnionID,UnionTitle,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Title,@ParentID,@IDPath,@ColumnID,@UnionID,@UnionTitle,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.VarChar,100),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,100),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@UnionID", SqlDbType.Int,4),
					new SqlParameter("@UnionTitle", SqlDbType.VarChar,100),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.ParentID;
			parameters[3].Value = model.IDPath;
			parameters[4].Value = model.ColumnID;
			parameters[5].Value = model.UnionID;
			parameters[6].Value = model.UnionTitle;
			parameters[7].Value = model.State;
			parameters[8].Value = model.OrderBy;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.ModifyDate;
			parameters[11].Value = model.WebSiteID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
                    WebSite.Model.Mod_PageStatisticalType MPageStatisticalType = GetModel(model.ParentID);
                    model.ColumnID = MPageStatisticalType.ColumnID + 1;
                    model.IDPath = MPageStatisticalType.IDPath + "," + model.ID.ToString();
                }
                Update(model);
                return model.ID;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_PageStatisticalType model)
		{
            string OldIDPath = model.IDPath;
            if (model.ParentID == 0)
            {
                model.ColumnID = 1;
                model.IDPath = model.ID.ToString();
            }
            else
            {
                WebSite.Model.Mod_PageStatisticalType MPageStatisticalType = GetModel(model.ParentID);
                model.ColumnID = MPageStatisticalType.ColumnID + 1;
                model.IDPath = MPageStatisticalType.IDPath + "," + model.ID.ToString();
            }
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_PageStatisticalType set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Title=@Title,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("IDPath=@IDPath,");
			strSql.Append("ColumnID=@ColumnID,");
			strSql.Append("UnionID=@UnionID,");
			strSql.Append("UnionTitle=@UnionTitle,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.VarChar,100),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,100),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@UnionID", SqlDbType.Int,4),
					new SqlParameter("@UnionTitle", SqlDbType.VarChar,100),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.ParentID;
			parameters[3].Value = model.IDPath;
			parameters[4].Value = model.ColumnID;
			parameters[5].Value = model.UnionID;
			parameters[6].Value = model.UnionTitle;
			parameters[7].Value = model.State;
			parameters[8].Value = model.OrderBy;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.ModifyDate;
			parameters[11].Value = model.WebSiteID;
			parameters[12].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SW_PageStatisticalType ");
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
			strSql.Append("delete from SW_PageStatisticalType ");
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
		public WebSite.Model.Mod_PageStatisticalType GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Title,ParentID,IDPath,ColumnID,UnionID,UnionTitle,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_PageStatisticalType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_PageStatisticalType model=new WebSite.Model.Mod_PageStatisticalType();
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
		public WebSite.Model.Mod_PageStatisticalType DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_PageStatisticalType model=new WebSite.Model.Mod_PageStatisticalType();
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
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["IDPath"]!=null)
				{
					model.IDPath=row["IDPath"].ToString();
				}
				if(row["ColumnID"]!=null && row["ColumnID"].ToString()!="")
				{
					model.ColumnID=int.Parse(row["ColumnID"].ToString());
				}
				if(row["UnionID"]!=null && row["UnionID"].ToString()!="")
				{
					model.UnionID=int.Parse(row["UnionID"].ToString());
				}
				if(row["UnionTitle"]!=null)
				{
					model.UnionTitle=row["UnionTitle"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
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
			strSql.Append("select ID,Model,Title,ParentID,IDPath,ColumnID,UnionID,UnionTitle,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_PageStatisticalType ");
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
			strSql.Append(" ID,Model,Title,ParentID,IDPath,ColumnID,UnionID,UnionTitle,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_PageStatisticalType ");
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
			strSql.Append("select count(1) FROM SW_PageStatisticalType ");
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
                strSql = "select top " + endIndex + " * from SW_PageStatisticalType where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_PageStatisticalType where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_PageStatisticalType where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_PageStatisticalType";
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
            strSql.Append("delete from SW_PageStatisticalType ");
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
        public bool ModifyIDPath(WebSite.Model.Mod_PageStatisticalType model, string OldIDPath)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("select * from SW_PageStatisticalType where IDPath like '" + OldIDPath + "%'");
                        DataSet ds = DbHelperSQL.Query(conn, trans, strSql.ToString());
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                strSql = new StringBuilder();
                                string IDPath = ("," + dr["IDPath"].ToString()).Replace("," + OldIDPath + ",", model.IDPath + ",").Trim(',');
                                strSql.Append("update SW_PageStatisticalType set ");
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

