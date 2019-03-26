
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_MarketIntegral
	/// </summary>
	public partial class Dal_MarketIntegral
	{
		public Dal_MarketIntegral()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_MarketIntegral"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_MarketIntegral");
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
		public int Add(WebSite.Model.Mod_MarketIntegral model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_MarketIntegral(");
			strSql.Append("Model,ProductName,UserID,UserNickName,UserName,Phone,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@ProductName,@UserID,@UserNickName,@UserName,@Phone,@Discount,@Integral,@IntegralCount,@TypeID,@TypeIDPath,@AreaID,@AreaIDPath,@Content1,@BrowseCount,@IsTop,@IsNew,@IsRecommend,@OrderBy,@AddDate,@ModifyDate,@State,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@OtherString3,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@IntegralCount", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString3", SqlDbType.Text),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserNickName;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.Discount;
			parameters[7].Value = model.Integral;
			parameters[8].Value = model.IntegralCount;
			parameters[9].Value = model.TypeID;
			parameters[10].Value = model.TypeIDPath;
			parameters[11].Value = model.AreaID;
			parameters[12].Value = model.AreaIDPath;
			parameters[13].Value = model.Content1;
			parameters[14].Value = model.BrowseCount;
			parameters[15].Value = model.IsTop;
			parameters[16].Value = model.IsNew;
			parameters[17].Value = model.IsRecommend;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.AddDate;
			parameters[20].Value = model.ModifyDate;
			parameters[21].Value = model.State;
			parameters[22].Value = model.OtherInt1;
			parameters[23].Value = model.OtherInt2;
			parameters[24].Value = model.OtherString1;
			parameters[25].Value = model.OtherString2;
			parameters[26].Value = model.OtherString3;
			parameters[27].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_MarketIntegral model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_MarketIntegral set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("IntegralCount=@IntegralCount,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeIDPath=@TypeIDPath,");
			strSql.Append("AreaID=@AreaID,");
			strSql.Append("AreaIDPath=@AreaIDPath,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsNew=@IsNew,");
			strSql.Append("IsRecommend=@IsRecommend,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("State=@State,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("OtherString3=@OtherString3,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@IntegralCount", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString3", SqlDbType.Text),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserNickName;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.Discount;
			parameters[7].Value = model.Integral;
			parameters[8].Value = model.IntegralCount;
			parameters[9].Value = model.TypeID;
			parameters[10].Value = model.TypeIDPath;
			parameters[11].Value = model.AreaID;
			parameters[12].Value = model.AreaIDPath;
			parameters[13].Value = model.Content1;
			parameters[14].Value = model.BrowseCount;
			parameters[15].Value = model.IsTop;
			parameters[16].Value = model.IsNew;
			parameters[17].Value = model.IsRecommend;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.AddDate;
			parameters[20].Value = model.ModifyDate;
			parameters[21].Value = model.State;
			parameters[22].Value = model.OtherInt1;
			parameters[23].Value = model.OtherInt2;
			parameters[24].Value = model.OtherString1;
			parameters[25].Value = model.OtherString2;
			parameters[26].Value = model.OtherString3;
			parameters[27].Value = model.WebSiteID;
			parameters[28].Value = model.ID;

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
			strSql.Append("delete from SW_MarketIntegral ");
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
			strSql.Append("delete from SW_MarketIntegral ");
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
		public WebSite.Model.Mod_MarketIntegral GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,ProductName,UserID,UserNickName,UserName,Phone,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3,WebSiteID from SW_MarketIntegral ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_MarketIntegral model=new WebSite.Model.Mod_MarketIntegral();
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
		public WebSite.Model.Mod_MarketIntegral DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_MarketIntegral model=new WebSite.Model.Mod_MarketIntegral();
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
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Discount"]!=null && row["Discount"].ToString()!="")
				{
					model.Discount=decimal.Parse(row["Discount"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["IntegralCount"]!=null && row["IntegralCount"].ToString()!="")
				{
					model.IntegralCount=int.Parse(row["IntegralCount"].ToString());
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeIDPath"]!=null)
				{
					model.TypeIDPath=row["TypeIDPath"].ToString();
				}
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
				}
				if(row["AreaIDPath"]!=null)
				{
					model.AreaIDPath=row["AreaIDPath"].ToString();
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsNew"]!=null && row["IsNew"].ToString()!="")
				{
					model.IsNew=int.Parse(row["IsNew"].ToString());
				}
				if(row["IsRecommend"]!=null && row["IsRecommend"].ToString()!="")
				{
					model.IsRecommend=int.Parse(row["IsRecommend"].ToString());
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
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
				if(row["OtherString3"]!=null)
				{
					model.OtherString3=row["OtherString3"].ToString();
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
			strSql.Append("select ID,Model,ProductName,UserID,UserNickName,UserName,Phone,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3,WebSiteID ");
			strSql.Append(" FROM SW_MarketIntegral ");
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
			strSql.Append(" ID,Model,ProductName,UserID,UserNickName,UserName,Phone,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3,WebSiteID ");
			strSql.Append(" FROM SW_MarketIntegral ");
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
			strSql.Append("select count(1) FROM SW_MarketIntegral ");
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
                strSql = "select top " + endIndex + " * from SW_MarketIntegral where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_MarketIntegral where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MarketIntegral where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_MarketIntegral";
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
        public WebSite.Model.Mod_MarketIntegral GetModelUserID(int UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,ProductName,UserID,UserNickName,UserName,Phone,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3,WebSiteID from SW_MarketIntegral ");
            strSql.Append(" where UserID=@UserID order by ID desc");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;

            WebSite.Model.Mod_MarketIntegral model = new WebSite.Model.Mod_MarketIntegral();
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageALL(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " ID,Model,ProductName,UserID,UserNickName,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3 from SW_MarketIntegral where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " ID,Model,ProductName,UserID,UserNickName,Discount,Integral,IntegralCount,TypeID,TypeIDPath,AreaID,AreaIDPath,Content1,BrowseCount,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherString3 from SW_MarketIntegral where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MarketIntegral where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
		#endregion  ExtensionMethod
	}
}

