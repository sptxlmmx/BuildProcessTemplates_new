using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserAddress
	/// </summary>
	public partial class Dal_UserAddress
	{
		public Dal_UserAddress()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserAddress"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserAddress");
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
		public int Add(WebSite.Model.Mod_UserAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserAddress(");
			strSql.Append("UserID,Consignee,Countries,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,AddDate,IsDefault,State)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@Consignee,@Countries,@Province,@City,@Region,@Address,@Zipcode,@Tel,@Mobile,@SignBuilding,@BestTime,@AddDate,@IsDefault,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Consignee", SqlDbType.VarChar,50),
					new SqlParameter("@Countries", SqlDbType.VarChar,200),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Zipcode", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@SignBuilding", SqlDbType.VarChar,200),
					new SqlParameter("@BestTime", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.Consignee;
			parameters[2].Value = model.Countries;
			parameters[3].Value = model.Province;
			parameters[4].Value = model.City;
			parameters[5].Value = model.Region;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Zipcode;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.Mobile;
			parameters[10].Value = model.SignBuilding;
			parameters[11].Value = model.BestTime;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.IsDefault;
			parameters[14].Value = model.State;

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
		public bool Update(WebSite.Model.Mod_UserAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserAddress set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("Consignee=@Consignee,");
			strSql.Append("Countries=@Countries,");
			strSql.Append("Province=@Province,");
			strSql.Append("City=@City,");
			strSql.Append("Region=@Region,");
			strSql.Append("Address=@Address,");
			strSql.Append("Zipcode=@Zipcode,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("SignBuilding=@SignBuilding,");
			strSql.Append("BestTime=@BestTime,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("IsDefault=@IsDefault,");
			strSql.Append("State=@State");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Consignee", SqlDbType.VarChar,50),
					new SqlParameter("@Countries", SqlDbType.VarChar,200),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Zipcode", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@SignBuilding", SqlDbType.VarChar,200),
					new SqlParameter("@BestTime", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.Consignee;
			parameters[2].Value = model.Countries;
			parameters[3].Value = model.Province;
			parameters[4].Value = model.City;
			parameters[5].Value = model.Region;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Zipcode;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.Mobile;
			parameters[10].Value = model.SignBuilding;
			parameters[11].Value = model.BestTime;
			parameters[12].Value = model.AddDate;
			parameters[13].Value = model.IsDefault;
			parameters[14].Value = model.State;
			parameters[15].Value = model.ID;

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
			strSql.Append("delete from SW_UserAddress ");
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
			strSql.Append("delete from SW_UserAddress ");
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
		public WebSite.Model.Mod_UserAddress GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserID,Consignee,Countries,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,AddDate,IsDefault,State from SW_UserAddress ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserAddress model=new WebSite.Model.Mod_UserAddress();
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
		public WebSite.Model.Mod_UserAddress DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserAddress model=new WebSite.Model.Mod_UserAddress();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["Consignee"]!=null)
				{
					model.Consignee=row["Consignee"].ToString();
				}
				if(row["Countries"]!=null)
				{
					model.Countries=row["Countries"].ToString();
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["Region"]!=null)
				{
					model.Region=row["Region"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Zipcode"]!=null)
				{
					model.Zipcode=row["Zipcode"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["SignBuilding"]!=null)
				{
					model.SignBuilding=row["SignBuilding"].ToString();
				}
				if(row["BestTime"]!=null)
				{
					model.BestTime=row["BestTime"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["IsDefault"]!=null && row["IsDefault"].ToString()!="")
				{
					model.IsDefault=int.Parse(row["IsDefault"].ToString());
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
			strSql.Append("select ID,UserID,Consignee,Countries,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,AddDate,IsDefault,State ");
			strSql.Append(" FROM SW_UserAddress ");
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
			strSql.Append(" ID,UserID,Consignee,Countries,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,AddDate,IsDefault,State ");
			strSql.Append(" FROM SW_UserAddress ");
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
			strSql.Append("select count(1) FROM SW_UserAddress ");
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
                strSql = "select top " + endIndex + " * from SW_UserAddress where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserAddress where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserAddress where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserAddress";
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
        /// 更新一条数据
        /// </summary>
        public bool Update(int IsDefault, int uid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_UserAddress set ");
            strSql.Append("IsDefault=@IsDefault");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
                    new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
            parameters[0].Value = IsDefault;
            parameters[1].Value = uid;
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
		#endregion  ExtensionMethod
	}
}

