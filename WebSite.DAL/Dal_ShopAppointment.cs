
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_ShopAppointment
	/// </summary>
	public partial class Dal_ShopAppointment
	{
		public Dal_ShopAppointment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_ShopAppointment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_ShopAppointment");
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
		public int Add(WebSite.Model.Mod_ShopAppointment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_ShopAppointment(");
			strSql.Append("Model,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,ShopUserName,ShopUserTel,ShopUserEmail,ProvinceID,Province,CityID,City,AreaID,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsMyself,MyselfID,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@ShopLevelID,@ShopLevelName,@ShopTypeID,@ShopTypeName,@ShopUserName,@ShopUserTel,@ShopUserEmail,@ProvinceID,@Province,@CityID,@City,@AreaID,@Area,@UserID,@UserNickName,@RecommenderID,@RecommenderName,@Content1,@IsLook,@IsMyself,@MyselfID,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@ShopLevelID", SqlDbType.Int,4),
					new SqlParameter("@ShopLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopTypeID", SqlDbType.Int,4),
					new SqlParameter("@ShopTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserTel", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserEmail", SqlDbType.VarChar,200),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@RecommenderID", SqlDbType.Int,4),
					new SqlParameter("@RecommenderName", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsMyself", SqlDbType.Int,4),
					new SqlParameter("@MyselfID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ShopLevelID;
			parameters[2].Value = model.ShopLevelName;
			parameters[3].Value = model.ShopTypeID;
			parameters[4].Value = model.ShopTypeName;
			parameters[5].Value = model.ShopUserName;
			parameters[6].Value = model.ShopUserTel;
			parameters[7].Value = model.ShopUserEmail;
			parameters[8].Value = model.ProvinceID;
			parameters[9].Value = model.Province;
			parameters[10].Value = model.CityID;
			parameters[11].Value = model.City;
			parameters[12].Value = model.AreaID;
			parameters[13].Value = model.Area;
			parameters[14].Value = model.UserID;
			parameters[15].Value = model.UserNickName;
			parameters[16].Value = model.RecommenderID;
			parameters[17].Value = model.RecommenderName;
			parameters[18].Value = model.Content1;
			parameters[19].Value = model.IsLook;
			parameters[20].Value = model.IsMyself;
			parameters[21].Value = model.MyselfID;
			parameters[22].Value = model.State;
			parameters[23].Value = model.OrderBy;
			parameters[24].Value = model.AddDate;
			parameters[25].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_ShopAppointment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_ShopAppointment set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ShopLevelID=@ShopLevelID,");
			strSql.Append("ShopLevelName=@ShopLevelName,");
			strSql.Append("ShopTypeID=@ShopTypeID,");
			strSql.Append("ShopTypeName=@ShopTypeName,");
			strSql.Append("ShopUserName=@ShopUserName,");
			strSql.Append("ShopUserTel=@ShopUserTel,");
			strSql.Append("ShopUserEmail=@ShopUserEmail,");
			strSql.Append("ProvinceID=@ProvinceID,");
			strSql.Append("Province=@Province,");
			strSql.Append("CityID=@CityID,");
			strSql.Append("City=@City,");
			strSql.Append("AreaID=@AreaID,");
			strSql.Append("Area=@Area,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("RecommenderID=@RecommenderID,");
			strSql.Append("RecommenderName=@RecommenderName,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("IsMyself=@IsMyself,");
			strSql.Append("MyselfID=@MyselfID,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,20),
					new SqlParameter("@ShopLevelID", SqlDbType.Int,4),
					new SqlParameter("@ShopLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopTypeID", SqlDbType.Int,4),
					new SqlParameter("@ShopTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserName", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserTel", SqlDbType.VarChar,200),
					new SqlParameter("@ShopUserEmail", SqlDbType.VarChar,200),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@Area", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@RecommenderID", SqlDbType.Int,4),
					new SqlParameter("@RecommenderName", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsMyself", SqlDbType.Int,4),
					new SqlParameter("@MyselfID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ShopLevelID;
			parameters[2].Value = model.ShopLevelName;
			parameters[3].Value = model.ShopTypeID;
			parameters[4].Value = model.ShopTypeName;
			parameters[5].Value = model.ShopUserName;
			parameters[6].Value = model.ShopUserTel;
			parameters[7].Value = model.ShopUserEmail;
			parameters[8].Value = model.ProvinceID;
			parameters[9].Value = model.Province;
			parameters[10].Value = model.CityID;
			parameters[11].Value = model.City;
			parameters[12].Value = model.AreaID;
			parameters[13].Value = model.Area;
			parameters[14].Value = model.UserID;
			parameters[15].Value = model.UserNickName;
			parameters[16].Value = model.RecommenderID;
			parameters[17].Value = model.RecommenderName;
			parameters[18].Value = model.Content1;
			parameters[19].Value = model.IsLook;
			parameters[20].Value = model.IsMyself;
			parameters[21].Value = model.MyselfID;
			parameters[22].Value = model.State;
			parameters[23].Value = model.OrderBy;
			parameters[24].Value = model.AddDate;
			parameters[25].Value = model.WebSiteID;
			parameters[26].Value = model.ID;

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
			strSql.Append("delete from SW_ShopAppointment ");
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
			strSql.Append("delete from SW_ShopAppointment ");
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
		public WebSite.Model.Mod_ShopAppointment GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,ShopUserName,ShopUserTel,ShopUserEmail,ProvinceID,Province,CityID,City,AreaID,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsMyself,MyselfID,State,OrderBy,AddDate,WebSiteID from SW_ShopAppointment ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_ShopAppointment model=new WebSite.Model.Mod_ShopAppointment();
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
		public WebSite.Model.Mod_ShopAppointment DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_ShopAppointment model=new WebSite.Model.Mod_ShopAppointment();
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
				if(row["ShopLevelID"]!=null && row["ShopLevelID"].ToString()!="")
				{
					model.ShopLevelID=int.Parse(row["ShopLevelID"].ToString());
				}
				if(row["ShopLevelName"]!=null)
				{
					model.ShopLevelName=row["ShopLevelName"].ToString();
				}
				if(row["ShopTypeID"]!=null && row["ShopTypeID"].ToString()!="")
				{
					model.ShopTypeID=int.Parse(row["ShopTypeID"].ToString());
				}
				if(row["ShopTypeName"]!=null)
				{
					model.ShopTypeName=row["ShopTypeName"].ToString();
				}
				if(row["ShopUserName"]!=null)
				{
					model.ShopUserName=row["ShopUserName"].ToString();
				}
				if(row["ShopUserTel"]!=null)
				{
					model.ShopUserTel=row["ShopUserTel"].ToString();
				}
				if(row["ShopUserEmail"]!=null)
				{
					model.ShopUserEmail=row["ShopUserEmail"].ToString();
				}
				if(row["ProvinceID"]!=null && row["ProvinceID"].ToString()!="")
				{
					model.ProvinceID=int.Parse(row["ProvinceID"].ToString());
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["CityID"]!=null && row["CityID"].ToString()!="")
				{
					model.CityID=int.Parse(row["CityID"].ToString());
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
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
				if(row["IsMyself"]!=null && row["IsMyself"].ToString()!="")
				{
					model.IsMyself=int.Parse(row["IsMyself"].ToString());
				}
				if(row["MyselfID"]!=null && row["MyselfID"].ToString()!="")
				{
					model.MyselfID=int.Parse(row["MyselfID"].ToString());
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
			strSql.Append("select ID,Model,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,ShopUserName,ShopUserTel,ShopUserEmail,ProvinceID,Province,CityID,City,AreaID,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsMyself,MyselfID,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_ShopAppointment ");
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
			strSql.Append(" ID,Model,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,ShopUserName,ShopUserTel,ShopUserEmail,ProvinceID,Province,CityID,City,AreaID,Area,UserID,UserNickName,RecommenderID,RecommenderName,Content1,IsLook,IsMyself,MyselfID,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_ShopAppointment ");
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
			strSql.Append("select count(1) FROM SW_ShopAppointment ");
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
                strSql = "select top " + endIndex + " * from SW_ShopAppointment where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ShopAppointment where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ShopAppointment where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_ShopAppointment";
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

