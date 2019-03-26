
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_SupportProduct
	/// </summary>
	public partial class Dal_SupportProduct
	{
		public Dal_SupportProduct()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_SupportProduct"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_SupportProduct");
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
		public int Add(WebSite.Model.Mod_SupportProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_SupportProduct(");
			strSql.Append("Model,UserID,EnName,ProductName,BigImage,SmallImage,Weight,Price,Contents,TempleUserIDStr,NotPassText,OtherInt1,OtherInt2,OtherString1,OtherString2,StatusState,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@EnName,@ProductName,@BigImage,@SmallImage,@Weight,@Price,@Contents,@TempleUserIDStr,@NotPassText,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@StatusState,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EnName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,300),
					new SqlParameter("@BigImage", SqlDbType.NVarChar,200),
					new SqlParameter("@SmallImage", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Contents", SqlDbType.NText),
					new SqlParameter("@TempleUserIDStr", SqlDbType.NText),
					new SqlParameter("@NotPassText", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@StatusState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.BigImage;
			parameters[5].Value = model.SmallImage;
			parameters[6].Value = model.Weight;
			parameters[7].Value = model.Price;
			parameters[8].Value = model.Contents;
			parameters[9].Value = model.TempleUserIDStr;
			parameters[10].Value = model.NotPassText;
			parameters[11].Value = model.OtherInt1;
			parameters[12].Value = model.OtherInt2;
			parameters[13].Value = model.OtherString1;
			parameters[14].Value = model.OtherString2;
			parameters[15].Value = model.StatusState;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
			parameters[19].Value = model.ModifyDate;
			parameters[20].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_SupportProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_SupportProduct set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("EnName=@EnName,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("BigImage=@BigImage,");
			strSql.Append("SmallImage=@SmallImage,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("Price=@Price,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("TempleUserIDStr=@TempleUserIDStr,");
			strSql.Append("NotPassText=@NotPassText,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("StatusState=@StatusState,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EnName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,300),
					new SqlParameter("@BigImage", SqlDbType.NVarChar,200),
					new SqlParameter("@SmallImage", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Contents", SqlDbType.NText),
					new SqlParameter("@TempleUserIDStr", SqlDbType.NText),
					new SqlParameter("@NotPassText", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@StatusState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.BigImage;
			parameters[5].Value = model.SmallImage;
			parameters[6].Value = model.Weight;
			parameters[7].Value = model.Price;
			parameters[8].Value = model.Contents;
			parameters[9].Value = model.TempleUserIDStr;
			parameters[10].Value = model.NotPassText;
			parameters[11].Value = model.OtherInt1;
			parameters[12].Value = model.OtherInt2;
			parameters[13].Value = model.OtherString1;
			parameters[14].Value = model.OtherString2;
			parameters[15].Value = model.StatusState;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
			parameters[19].Value = model.ModifyDate;
			parameters[20].Value = model.WebSiteID;
			parameters[21].Value = model.ID;

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
			strSql.Append("delete from SW_SupportProduct ");
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
			strSql.Append("delete from SW_SupportProduct ");
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
		public WebSite.Model.Mod_SupportProduct GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,EnName,ProductName,BigImage,SmallImage,Weight,Price,Contents,TempleUserIDStr,NotPassText,OtherInt1,OtherInt2,OtherString1,OtherString2,StatusState,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_SupportProduct ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_SupportProduct model=new WebSite.Model.Mod_SupportProduct();
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
		public WebSite.Model.Mod_SupportProduct DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_SupportProduct model=new WebSite.Model.Mod_SupportProduct();
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
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["EnName"]!=null)
				{
					model.EnName=row["EnName"].ToString();
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["BigImage"]!=null)
				{
					model.BigImage=row["BigImage"].ToString();
				}
				if(row["SmallImage"]!=null)
				{
					model.SmallImage=row["SmallImage"].ToString();
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(row["Weight"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Contents"]!=null)
				{
					model.Contents=row["Contents"].ToString();
				}
				if(row["TempleUserIDStr"]!=null)
				{
					model.TempleUserIDStr=row["TempleUserIDStr"].ToString();
				}
				if(row["NotPassText"]!=null)
				{
					model.NotPassText=row["NotPassText"].ToString();
				}
				if(row["OtherInt1"]!=null && row["OtherInt1"].ToString()!="")
				{
					model.OtherInt1=int.Parse(row["OtherInt1"].ToString());
				}
				if(row["OtherInt2"]!=null && row["OtherInt2"].ToString()!="")
				{
					model.OtherInt2=int.Parse(row["OtherInt2"].ToString());
				}
				if(row["OtherString1"]!=null)
				{
					model.OtherString1=row["OtherString1"].ToString();
				}
				if(row["OtherString2"]!=null)
				{
					model.OtherString2=row["OtherString2"].ToString();
				}
				if(row["StatusState"]!=null && row["StatusState"].ToString()!="")
				{
					model.StatusState=int.Parse(row["StatusState"].ToString());
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
			strSql.Append("select ID,Model,UserID,EnName,ProductName,BigImage,SmallImage,Weight,Price,Contents,TempleUserIDStr,NotPassText,OtherInt1,OtherInt2,OtherString1,OtherString2,StatusState,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportProduct ");
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
			strSql.Append(" ID,Model,UserID,EnName,ProductName,BigImage,SmallImage,Weight,Price,Contents,TempleUserIDStr,NotPassText,OtherInt1,OtherInt2,OtherString1,OtherString2,StatusState,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportProduct ");
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
			strSql.Append("select count(1) FROM SW_SupportProduct ");
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
                strSql = "select top " + endIndex + " * from SW_SupportProduct where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_SupportProduct where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_SupportProduct where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_SupportProduct";
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

