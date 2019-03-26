using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_MallShopBondOder
	/// </summary>
	public partial class Dal_MallShopBondOder
	{
		public Dal_MallShopBondOder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_MallShopBondOder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_MallShopBondOder");
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
		public int Add(WebSite.Model.Mod_MallShopBondOder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_MallShopBondOder(");
			strSql.Append("Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@UserID,@UserName,@Phone,@Money,@PayID,@PayName,@IsPay,@PayDate,@PayNo,@PayAmount,@IsThaw,@IsLook,@State,@OrderBy,@AddDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,100),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.NVarChar,200),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsThaw", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.PayID;
			parameters[7].Value = model.PayName;
			parameters[8].Value = model.IsPay;
			parameters[9].Value = model.PayDate;
			parameters[10].Value = model.PayNo;
			parameters[11].Value = model.PayAmount;
			parameters[12].Value = model.IsThaw;
			parameters[13].Value = model.IsLook;
			parameters[14].Value = model.State;
			parameters[15].Value = model.OrderBy;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.ModifyDate;
			parameters[18].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_MallShopBondOder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_MallShopBondOder set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Money=@Money,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("IsThaw=@IsThaw,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,100),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.NVarChar,200),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsThaw", SqlDbType.Int,4),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.PayID;
			parameters[7].Value = model.PayName;
			parameters[8].Value = model.IsPay;
			parameters[9].Value = model.PayDate;
			parameters[10].Value = model.PayNo;
			parameters[11].Value = model.PayAmount;
			parameters[12].Value = model.IsThaw;
			parameters[13].Value = model.IsLook;
			parameters[14].Value = model.State;
			parameters[15].Value = model.OrderBy;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.ModifyDate;
			parameters[18].Value = model.WebSiteID;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from SW_MallShopBondOder ");
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
			strSql.Append("delete from SW_MallShopBondOder ");
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
		public WebSite.Model.Mod_MallShopBondOder GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_MallShopBondOder ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_MallShopBondOder model=new WebSite.Model.Mod_MallShopBondOder();
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
		public WebSite.Model.Mod_MallShopBondOder DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_MallShopBondOder model=new WebSite.Model.Mod_MallShopBondOder();
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
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["PayID"]!=null && row["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(row["PayID"].ToString());
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
				}
				if(row["IsPay"]!=null && row["IsPay"].ToString()!="")
				{
					model.IsPay=int.Parse(row["IsPay"].ToString());
				}
				if(row["PayDate"]!=null && row["PayDate"].ToString()!="")
				{
					model.PayDate=DateTime.Parse(row["PayDate"].ToString());
				}
				if(row["PayNo"]!=null)
				{
					model.PayNo=row["PayNo"].ToString();
				}
				if(row["PayAmount"]!=null && row["PayAmount"].ToString()!="")
				{
					model.PayAmount=decimal.Parse(row["PayAmount"].ToString());
				}
				if(row["IsThaw"]!=null && row["IsThaw"].ToString()!="")
				{
					model.IsThaw=int.Parse(row["IsThaw"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
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
			strSql.Append("select ID,Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_MallShopBondOder ");
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
			strSql.Append(" ID,Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_MallShopBondOder ");
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
			strSql.Append("select count(1) FROM SW_MallShopBondOder ");
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
                strSql = "select top " + endIndex + " * from SW_MallShopBondOder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_MallShopBondOder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MallShopBondOder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_MallShopBondOder";
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
        public WebSite.Model.Mod_MallShopBondOder GetModelUserID(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_MallShopBondOder ");
            strSql.Append(" where UserID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_MallShopBondOder model = new WebSite.Model.Mod_MallShopBondOder();
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
        public WebSite.Model.Mod_MallShopBondOder GetModelOrderNo(string OrderNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,Phone,Money,PayID,PayName,IsPay,PayDate,PayNo,PayAmount,IsThaw,IsLook,State,OrderBy,AddDate,ModifyDate,WebSiteID from SW_MallShopBondOder ");
            strSql.Append(" where OrderNo=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.NVarChar,200)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_MallShopBondOder model = new WebSite.Model.Mod_MallShopBondOder();
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

