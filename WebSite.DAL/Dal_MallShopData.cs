using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_MallShopData
	/// </summary>
	public partial class Dal_MallShopData
	{
		public Dal_MallShopData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_MallShopData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_MallShopData");
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
		public int Add(WebSite.Model.Mod_MallShopData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_MallShopData(");
			strSql.Append("Model,Name,UserID,ShopID,QualificationsName,Image,StartExpirationDate,ExpirationDate,Explain,Remarks,OtherInt1,OtherInt2,OtherString1,OtherString2,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Name,@UserID,@ShopID,@QualificationsName,@Image,@StartExpirationDate,@ExpirationDate,@Explain,@Remarks,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@State,@AuditState,@AddDate,@ModifyDate,@OrderBy,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@QualificationsName", SqlDbType.NVarChar,200),
					new SqlParameter("@Image", SqlDbType.NVarChar,200),
					new SqlParameter("@StartExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@ExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@Explain", SqlDbType.NText),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.ShopID;
			parameters[4].Value = model.QualificationsName;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.StartExpirationDate;
			parameters[7].Value = model.ExpirationDate;
			parameters[8].Value = model.Explain;
			parameters[9].Value = model.Remarks;
			parameters[10].Value = model.OtherInt1;
			parameters[11].Value = model.OtherInt2;
			parameters[12].Value = model.OtherString1;
			parameters[13].Value = model.OtherString2;
			parameters[14].Value = model.State;
			parameters[15].Value = model.AuditState;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.ModifyDate;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_MallShopData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_MallShopData set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Name=@Name,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("QualificationsName=@QualificationsName,");
			strSql.Append("Image=@Image,");
			strSql.Append("StartExpirationDate=@StartExpirationDate,");
			strSql.Append("ExpirationDate=@ExpirationDate,");
			strSql.Append("Explain=@Explain,");
			strSql.Append("Remarks=@Remarks,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("State=@State,");
			strSql.Append("AuditState=@AuditState,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@QualificationsName", SqlDbType.NVarChar,200),
					new SqlParameter("@Image", SqlDbType.NVarChar,200),
					new SqlParameter("@StartExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@ExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@Explain", SqlDbType.NText),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.ShopID;
			parameters[4].Value = model.QualificationsName;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.StartExpirationDate;
			parameters[7].Value = model.ExpirationDate;
			parameters[8].Value = model.Explain;
			parameters[9].Value = model.Remarks;
			parameters[10].Value = model.OtherInt1;
			parameters[11].Value = model.OtherInt2;
			parameters[12].Value = model.OtherString1;
			parameters[13].Value = model.OtherString2;
			parameters[14].Value = model.State;
			parameters[15].Value = model.AuditState;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.ModifyDate;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.WebSiteID;
			parameters[20].Value = model.ID;

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
			strSql.Append("delete from SW_MallShopData ");
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
			strSql.Append("delete from SW_MallShopData ");
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
		public WebSite.Model.Mod_MallShopData GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Name,UserID,ShopID,QualificationsName,Image,StartExpirationDate,ExpirationDate,Explain,Remarks,OtherInt1,OtherInt2,OtherString1,OtherString2,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID from SW_MallShopData ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_MallShopData model=new WebSite.Model.Mod_MallShopData();
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
		public WebSite.Model.Mod_MallShopData DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_MallShopData model=new WebSite.Model.Mod_MallShopData();
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
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["QualificationsName"]!=null)
				{
					model.QualificationsName=row["QualificationsName"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["StartExpirationDate"]!=null && row["StartExpirationDate"].ToString()!="")
				{
					model.StartExpirationDate=DateTime.Parse(row["StartExpirationDate"].ToString());
				}
				if(row["ExpirationDate"]!=null && row["ExpirationDate"].ToString()!="")
				{
					model.ExpirationDate=DateTime.Parse(row["ExpirationDate"].ToString());
				}
				if(row["Explain"]!=null)
				{
					model.Explain=row["Explain"].ToString();
				}
				if(row["Remarks"]!=null)
				{
					model.Remarks=row["Remarks"].ToString();
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
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AuditState"]!=null && row["AuditState"].ToString()!="")
				{
					model.AuditState=int.Parse(row["AuditState"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
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
			strSql.Append("select ID,Model,Name,UserID,ShopID,QualificationsName,Image,StartExpirationDate,ExpirationDate,Explain,Remarks,OtherInt1,OtherInt2,OtherString1,OtherString2,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_MallShopData ");
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
			strSql.Append(" ID,Model,Name,UserID,ShopID,QualificationsName,Image,StartExpirationDate,ExpirationDate,Explain,Remarks,OtherInt1,OtherInt2,OtherString1,OtherString2,State,AuditState,AddDate,ModifyDate,OrderBy,WebSiteID ");
			strSql.Append(" FROM SW_MallShopData ");
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
			strSql.Append("select count(1) FROM SW_MallShopData ");
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
                strSql = "select top " + endIndex + " * from SW_MallShopData where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_MallShopData where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MallShopData where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_MallShopData";
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
        public bool DeleteUserList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_MallShopData ");
            strSql.Append(" where UserID in(" + IDlist + ")  ");
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

