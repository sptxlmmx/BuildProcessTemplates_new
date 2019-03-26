using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_ProductAttr
	/// </summary>
	public partial class Dal_ProductAttr
	{
		public Dal_ProductAttr()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_ProductAttr"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_ProductAttr");
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
		public int Add(WebSite.Model.Mod_ProductAttr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_ProductAttr(");
			strSql.Append("AttrName,AttrValue,AttrType,AttrEntryType,Image,TypeID,ParentID,IDPath,IsImage,IsSearch,IsTop,OrderBy,State)");
			strSql.Append(" values (");
			strSql.Append("@AttrName,@AttrValue,@AttrType,@AttrEntryType,@Image,@TypeID,@ParentID,@IDPath,@IsImage,@IsSearch,@IsTop,@OrderBy,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AttrName", SqlDbType.VarChar,200),
					new SqlParameter("@AttrValue", SqlDbType.Text),
					new SqlParameter("@AttrType", SqlDbType.Int,4),
					new SqlParameter("@AttrEntryType", SqlDbType.Int,4),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@IsImage", SqlDbType.Int,4),
					new SqlParameter("@IsSearch", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4)};
			parameters[0].Value = model.AttrName;
			parameters[1].Value = model.AttrValue;
			parameters[2].Value = model.AttrType;
			parameters[3].Value = model.AttrEntryType;
			parameters[4].Value = model.Image;
			parameters[5].Value = model.TypeID;
			parameters[6].Value = model.ParentID;
			parameters[7].Value = model.IDPath;
			parameters[8].Value = model.IsImage;
			parameters[9].Value = model.IsSearch;
			parameters[10].Value = model.IsTop;
			parameters[11].Value = model.OrderBy;
			parameters[12].Value = model.State;

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
		public bool Update(WebSite.Model.Mod_ProductAttr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_ProductAttr set ");
			strSql.Append("AttrName=@AttrName,");
			strSql.Append("AttrValue=@AttrValue,");
			strSql.Append("AttrType=@AttrType,");
			strSql.Append("AttrEntryType=@AttrEntryType,");
			strSql.Append("Image=@Image,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("IDPath=@IDPath,");
			strSql.Append("IsImage=@IsImage,");
			strSql.Append("IsSearch=@IsSearch,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("State=@State");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AttrName", SqlDbType.VarChar,200),
					new SqlParameter("@AttrValue", SqlDbType.Text),
					new SqlParameter("@AttrType", SqlDbType.Int,4),
					new SqlParameter("@AttrEntryType", SqlDbType.Int,4),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@IsImage", SqlDbType.Int,4),
					new SqlParameter("@IsSearch", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AttrName;
			parameters[1].Value = model.AttrValue;
			parameters[2].Value = model.AttrType;
			parameters[3].Value = model.AttrEntryType;
			parameters[4].Value = model.Image;
			parameters[5].Value = model.TypeID;
			parameters[6].Value = model.ParentID;
			parameters[7].Value = model.IDPath;
			parameters[8].Value = model.IsImage;
			parameters[9].Value = model.IsSearch;
			parameters[10].Value = model.IsTop;
			parameters[11].Value = model.OrderBy;
			parameters[12].Value = model.State;
			parameters[13].Value = model.ID;

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
			strSql.Append("delete from SW_ProductAttr ");
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
			strSql.Append("delete from SW_ProductAttr ");
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
		public WebSite.Model.Mod_ProductAttr GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,AttrName,AttrValue,AttrType,AttrEntryType,Image,TypeID,ParentID,IDPath,IsImage,IsSearch,IsTop,OrderBy,State from SW_ProductAttr ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_ProductAttr model=new WebSite.Model.Mod_ProductAttr();
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
		public WebSite.Model.Mod_ProductAttr DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_ProductAttr model=new WebSite.Model.Mod_ProductAttr();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["AttrName"]!=null)
				{
					model.AttrName=row["AttrName"].ToString();
				}
				if(row["AttrValue"]!=null)
				{
					model.AttrValue=row["AttrValue"].ToString();
				}
				if(row["AttrType"]!=null && row["AttrType"].ToString()!="")
				{
					model.AttrType=int.Parse(row["AttrType"].ToString());
				}
				if(row["AttrEntryType"]!=null && row["AttrEntryType"].ToString()!="")
				{
					model.AttrEntryType=int.Parse(row["AttrEntryType"].ToString());
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["IDPath"]!=null)
				{
					model.IDPath=row["IDPath"].ToString();
				}
				if(row["IsImage"]!=null && row["IsImage"].ToString()!="")
				{
					model.IsImage=int.Parse(row["IsImage"].ToString());
				}
				if(row["IsSearch"]!=null && row["IsSearch"].ToString()!="")
				{
					model.IsSearch=int.Parse(row["IsSearch"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select ID,AttrName,AttrValue,AttrType,AttrEntryType,Image,TypeID,ParentID,IDPath,IsImage,IsSearch,IsTop,OrderBy,State ");
			strSql.Append(" FROM SW_ProductAttr ");
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
			strSql.Append(" ID,AttrName,AttrValue,AttrType,AttrEntryType,Image,TypeID,ParentID,IDPath,IsImage,IsSearch,IsTop,OrderBy,State ");
			strSql.Append(" FROM SW_ProductAttr ");
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
			strSql.Append("select count(1) FROM SW_ProductAttr ");
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
                strSql = "select top " + endIndex + " * from SW_ProductAttr where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductAttr where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductAttr where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_ProductAttr";
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

