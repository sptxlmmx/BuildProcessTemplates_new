
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_CityPartner
	/// </summary>
	public partial class Dal_CityPartner
	{
		public Dal_CityPartner()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_CityPartner"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_CityPartner");
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
		public int Add(WebSite.Model.Mod_CityPartner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_CityPartner(");
			strSql.Append("Model,UserRealName,UserTel,UserEmail,Industry,CityID,Province,City,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsReview,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserRealName,@UserTel,@UserEmail,@Industry,@CityID,@Province,@City,@Area,@UserID,@UserNickName,@RecommenderID,@RecommenderName,@Content1,@IsLook,@IsReview,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@UserRealName", SqlDbType.VarChar,50),
					new SqlParameter("@UserTel", SqlDbType.VarChar,50),
					new SqlParameter("@UserEmail", SqlDbType.VarChar,100),
					new SqlParameter("@Industry", SqlDbType.VarChar,200),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@RecommenderID", SqlDbType.Int,4),
					new SqlParameter("@RecommenderName", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserRealName;
			parameters[2].Value = model.UserTel;
			parameters[3].Value = model.UserEmail;
			parameters[4].Value = model.Industry;
			parameters[5].Value = model.CityID;
			parameters[6].Value = model.Province;
			parameters[7].Value = model.City;
			parameters[8].Value = model.Area;
			parameters[9].Value = model.UserID;
			parameters[10].Value = model.UserNickName;
			parameters[11].Value = model.RecommenderID;
			parameters[12].Value = model.RecommenderName;
			parameters[13].Value = model.Content1;
			parameters[14].Value = model.IsLook;
			parameters[15].Value = model.IsReview;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
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
		public bool Update(WebSite.Model.Mod_CityPartner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_CityPartner set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserRealName=@UserRealName,");
			strSql.Append("UserTel=@UserTel,");
			strSql.Append("UserEmail=@UserEmail,");
			strSql.Append("Industry=@Industry,");
			strSql.Append("CityID=@CityID,");
			strSql.Append("Province=@Province,");
			strSql.Append("City=@City,");
			strSql.Append("Area=@Area,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("RecommenderID=@RecommenderID,");
			strSql.Append("RecommenderName=@RecommenderName,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("IsReview=@IsReview,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@UserRealName", SqlDbType.VarChar,50),
					new SqlParameter("@UserTel", SqlDbType.VarChar,50),
					new SqlParameter("@UserEmail", SqlDbType.VarChar,100),
					new SqlParameter("@Industry", SqlDbType.VarChar,200),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@RecommenderID", SqlDbType.Int,4),
					new SqlParameter("@RecommenderName", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserRealName;
			parameters[2].Value = model.UserTel;
			parameters[3].Value = model.UserEmail;
			parameters[4].Value = model.Industry;
			parameters[5].Value = model.CityID;
			parameters[6].Value = model.Province;
			parameters[7].Value = model.City;
			parameters[8].Value = model.Area;
			parameters[9].Value = model.UserID;
			parameters[10].Value = model.UserNickName;
			parameters[11].Value = model.RecommenderID;
			parameters[12].Value = model.RecommenderName;
			parameters[13].Value = model.Content1;
			parameters[14].Value = model.IsLook;
			parameters[15].Value = model.IsReview;
			parameters[16].Value = model.State;
			parameters[17].Value = model.OrderBy;
			parameters[18].Value = model.AddDate;
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
			strSql.Append("delete from SW_CityPartner ");
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
			strSql.Append("delete from SW_CityPartner ");
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
		public WebSite.Model.Mod_CityPartner GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserRealName,UserTel,UserEmail,Industry,CityID,Province,City,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsReview,State,OrderBy,AddDate,WebSiteID from SW_CityPartner ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_CityPartner model=new WebSite.Model.Mod_CityPartner();
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
		public WebSite.Model.Mod_CityPartner DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_CityPartner model=new WebSite.Model.Mod_CityPartner();
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
				if(row["UserRealName"]!=null)
				{
					model.UserRealName=row["UserRealName"].ToString();
				}
				if(row["UserTel"]!=null)
				{
					model.UserTel=row["UserTel"].ToString();
				}
				if(row["UserEmail"]!=null)
				{
					model.UserEmail=row["UserEmail"].ToString();
				}
				if(row["Industry"]!=null)
				{
					model.Industry=row["Industry"].ToString();
				}
				if(row["CityID"]!=null && row["CityID"].ToString()!="")
				{
					model.CityID=int.Parse(row["CityID"].ToString());
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["Area"]!=null)
				{
					model.Area=row["Area"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["RecommenderID"]!=null && row["RecommenderID"].ToString()!="")
				{
					model.RecommenderID=int.Parse(row["RecommenderID"].ToString());
				}
				if(row["RecommenderName"]!=null)
				{
					model.RecommenderName=row["RecommenderName"].ToString();
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["IsReview"]!=null && row["IsReview"].ToString()!="")
				{
					model.IsReview=int.Parse(row["IsReview"].ToString());
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
			strSql.Append("select ID,Model,UserRealName,UserTel,UserEmail,Industry,CityID,Province,City,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsReview,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_CityPartner ");
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
			strSql.Append(" ID,Model,UserRealName,UserTel,UserEmail,Industry,CityID,Province,City,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsReview,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_CityPartner ");
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
			strSql.Append("select count(1) FROM SW_CityPartner ");
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
                strSql = "select top " + endIndex + " * from SW_CityPartner where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_CityPartner where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_CityPartner where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_CityPartner";
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

