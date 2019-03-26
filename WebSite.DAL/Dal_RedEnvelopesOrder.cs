
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_RedEnvelopesOrder
	/// </summary>
	public partial class Dal_RedEnvelopesOrder
	{
		public Dal_RedEnvelopesOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_RedEnvelopesOrder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_RedEnvelopesOrder");
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
		public int Add(WebSite.Model.Mod_RedEnvelopesOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_RedEnvelopesOrder(");
			strSql.Append("Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@TypeID,@TypeName,@Total,@TotalSurplus,@MoneyAll,@MoneySurplus,@MoneyBigID,@MoneyBig,@IsBigReceive,@Blessings,@NewsID,@UserID,@UserNickName,@IsPay,@PayID,@PayName,@PayDate,@PayNo,@PayAmount,@State,@AddDate,@StartDate,@EndDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Total", SqlDbType.Int,4),
					new SqlParameter("@TotalSurplus", SqlDbType.Int,4),
					new SqlParameter("@MoneyAll", SqlDbType.Decimal,9),
					new SqlParameter("@MoneySurplus", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyBigID", SqlDbType.Int,4),
					new SqlParameter("@MoneyBig", SqlDbType.Decimal,9),
					new SqlParameter("@IsBigReceive", SqlDbType.Int,4),
					new SqlParameter("@Blessings", SqlDbType.VarChar,200),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.NVarChar,200),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@StartDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.TypeID;
			parameters[3].Value = model.TypeName;
			parameters[4].Value = model.Total;
			parameters[5].Value = model.TotalSurplus;
			parameters[6].Value = model.MoneyAll;
			parameters[7].Value = model.MoneySurplus;
			parameters[8].Value = model.MoneyBigID;
			parameters[9].Value = model.MoneyBig;
			parameters[10].Value = model.IsBigReceive;
			parameters[11].Value = model.Blessings;
			parameters[12].Value = model.NewsID;
			parameters[13].Value = model.UserID;
			parameters[14].Value = model.UserNickName;
			parameters[15].Value = model.IsPay;
			parameters[16].Value = model.PayID;
			parameters[17].Value = model.PayName;
			parameters[18].Value = model.PayDate;
			parameters[19].Value = model.PayNo;
			parameters[20].Value = model.PayAmount;
			parameters[21].Value = model.State;
			parameters[22].Value = model.AddDate;
			parameters[23].Value = model.StartDate;
			parameters[24].Value = model.EndDate;
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
		public bool Update(WebSite.Model.Mod_RedEnvelopesOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_RedEnvelopesOrder set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Total=@Total,");
			strSql.Append("TotalSurplus=@TotalSurplus,");
			strSql.Append("MoneyAll=@MoneyAll,");
			strSql.Append("MoneySurplus=@MoneySurplus,");
			strSql.Append("MoneyBigID=@MoneyBigID,");
			strSql.Append("MoneyBig=@MoneyBig,");
			strSql.Append("IsBigReceive=@IsBigReceive,");
			strSql.Append("Blessings=@Blessings,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserNickName=@UserNickName,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("State=@State,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("StartDate=@StartDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Total", SqlDbType.Int,4),
					new SqlParameter("@TotalSurplus", SqlDbType.Int,4),
					new SqlParameter("@MoneyAll", SqlDbType.Decimal,9),
					new SqlParameter("@MoneySurplus", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyBigID", SqlDbType.Int,4),
					new SqlParameter("@MoneyBig", SqlDbType.Decimal,9),
					new SqlParameter("@IsBigReceive", SqlDbType.Int,4),
					new SqlParameter("@Blessings", SqlDbType.VarChar,200),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.NVarChar,200),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@StartDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.TypeID;
			parameters[3].Value = model.TypeName;
			parameters[4].Value = model.Total;
			parameters[5].Value = model.TotalSurplus;
			parameters[6].Value = model.MoneyAll;
			parameters[7].Value = model.MoneySurplus;
			parameters[8].Value = model.MoneyBigID;
			parameters[9].Value = model.MoneyBig;
			parameters[10].Value = model.IsBigReceive;
			parameters[11].Value = model.Blessings;
			parameters[12].Value = model.NewsID;
			parameters[13].Value = model.UserID;
			parameters[14].Value = model.UserNickName;
			parameters[15].Value = model.IsPay;
			parameters[16].Value = model.PayID;
			parameters[17].Value = model.PayName;
			parameters[18].Value = model.PayDate;
			parameters[19].Value = model.PayNo;
			parameters[20].Value = model.PayAmount;
			parameters[21].Value = model.State;
			parameters[22].Value = model.AddDate;
			parameters[23].Value = model.StartDate;
			parameters[24].Value = model.EndDate;
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
			strSql.Append("delete from SW_RedEnvelopesOrder ");
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
			strSql.Append("delete from SW_RedEnvelopesOrder ");
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
		public WebSite.Model.Mod_RedEnvelopesOrder GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID from SW_RedEnvelopesOrder ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_RedEnvelopesOrder model=new WebSite.Model.Mod_RedEnvelopesOrder();
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
		public WebSite.Model.Mod_RedEnvelopesOrder DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_RedEnvelopesOrder model=new WebSite.Model.Mod_RedEnvelopesOrder();
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
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["Total"]!=null && row["Total"].ToString()!="")
				{
					model.Total=int.Parse(row["Total"].ToString());
				}
				if(row["TotalSurplus"]!=null && row["TotalSurplus"].ToString()!="")
				{
					model.TotalSurplus=int.Parse(row["TotalSurplus"].ToString());
				}
				if(row["MoneyAll"]!=null && row["MoneyAll"].ToString()!="")
				{
					model.MoneyAll=decimal.Parse(row["MoneyAll"].ToString());
				}
				if(row["MoneySurplus"]!=null && row["MoneySurplus"].ToString()!="")
				{
					model.MoneySurplus=decimal.Parse(row["MoneySurplus"].ToString());
				}
				if(row["MoneyBigID"]!=null && row["MoneyBigID"].ToString()!="")
				{
					model.MoneyBigID=int.Parse(row["MoneyBigID"].ToString());
				}
				if(row["MoneyBig"]!=null && row["MoneyBig"].ToString()!="")
				{
					model.MoneyBig=decimal.Parse(row["MoneyBig"].ToString());
				}
				if(row["IsBigReceive"]!=null && row["IsBigReceive"].ToString()!="")
				{
					model.IsBigReceive=int.Parse(row["IsBigReceive"].ToString());
				}
				if(row["Blessings"]!=null)
				{
					model.Blessings=row["Blessings"].ToString();
				}
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserNickName"]!=null)
				{
					model.UserNickName=row["UserNickName"].ToString();
				}
				if(row["IsPay"]!=null && row["IsPay"].ToString()!="")
				{
					model.IsPay=int.Parse(row["IsPay"].ToString());
				}
				if(row["PayID"]!=null && row["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(row["PayID"].ToString());
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
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
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["StartDate"]!=null && row["StartDate"].ToString()!="")
				{
					model.StartDate=DateTime.Parse(row["StartDate"].ToString());
				}
				if(row["EndDate"]!=null && row["EndDate"].ToString()!="")
				{
					model.EndDate=DateTime.Parse(row["EndDate"].ToString());
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
			strSql.Append("select ID,Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID ");
			strSql.Append(" FROM SW_RedEnvelopesOrder ");
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
			strSql.Append(" ID,Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID ");
			strSql.Append(" FROM SW_RedEnvelopesOrder ");
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
			strSql.Append("select count(1) FROM SW_RedEnvelopesOrder ");
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
                strSql = "select top " + endIndex + " * from SW_RedEnvelopesOrder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_RedEnvelopesOrder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_RedEnvelopesOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_RedEnvelopesOrder";
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
        /// 根据订单号得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_RedEnvelopesOrder GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID from SW_RedEnvelopesOrder ");            
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_RedEnvelopesOrder model = new WebSite.Model.Mod_RedEnvelopesOrder();
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
        public WebSite.Model.Mod_RedEnvelopesOrder GetModelByUserID(int UserID, string Model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,TypeID,TypeName,Total,TotalSurplus,MoneyAll,MoneySurplus,MoneyBigID,MoneyBig,IsBigReceive,Blessings,NewsID,UserID,UserNickName,IsPay,PayID,PayName,PayDate,PayNo,PayAmount,State,AddDate,StartDate,EndDate,WebSiteID from SW_RedEnvelopesOrder ");            
            strSql.Append(" where UserID=@UserID and Model=@Model");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@Model", SqlDbType.VarChar,50)
			};
            parameters[0].Value = UserID;
            parameters[1].Value = Model;
            WebSite.Model.Mod_RedEnvelopesOrder model = new WebSite.Model.Mod_RedEnvelopesOrder();
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

