using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Coupon
	/// </summary>
	public partial class Dal_Coupon
	{
		public Dal_Coupon()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Coupon"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Coupon");
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
		public int Add(WebSite.Model.Mod_Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Coupon(");
			strSql.Append("CouponName,CouponNo,Amount,StartDate,EndDate,Introduction,Reason,IsDistribution,DistributionDate,UserID,UserName,OrderID,OrderNo,IsUsed,UsedDate,ModifyDate,AddDate,State,Email,Mobile,IsIntegral,Integral,MinProductNum,MaxProductNum,MinProductPrice,MaxProductPrice,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@CouponName,@CouponNo,@Amount,@StartDate,@EndDate,@Introduction,@Reason,@IsDistribution,@DistributionDate,@UserID,@UserName,@OrderID,@OrderNo,@IsUsed,@UsedDate,@ModifyDate,@AddDate,@State,@Email,@Mobile,@IsIntegral,@Integral,@MinProductNum,@MaxProductNum,@MinProductPrice,@MaxProductPrice,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CouponName", SqlDbType.VarChar,200),
					new SqlParameter("@CouponNo", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@StartDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@Introduction", SqlDbType.Text),
					new SqlParameter("@Reason", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDistribution", SqlDbType.Int,4),
					new SqlParameter("@DistributionDate", SqlDbType.DateTime),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@IsUsed", SqlDbType.Int,4),
					new SqlParameter("@UsedDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@IsIntegral", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@MinProductNum", SqlDbType.Int,4),
					new SqlParameter("@MaxProductNum", SqlDbType.Int,4),
					new SqlParameter("@MinProductPrice", SqlDbType.Decimal,9),
					new SqlParameter("@MaxProductPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.CouponName;
			parameters[1].Value = model.CouponNo;
			parameters[2].Value = model.Amount;
			parameters[3].Value = model.StartDate;
			parameters[4].Value = model.EndDate;
			parameters[5].Value = model.Introduction;
			parameters[6].Value = model.Reason;
			parameters[7].Value = model.IsDistribution;
			parameters[8].Value = model.DistributionDate;
			parameters[9].Value = model.UserID;
			parameters[10].Value = model.UserName;
			parameters[11].Value = model.OrderID;
			parameters[12].Value = model.OrderNo;
			parameters[13].Value = model.IsUsed;
			parameters[14].Value = model.UsedDate;
			parameters[15].Value = model.ModifyDate;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.State;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.Mobile;
			parameters[20].Value = model.IsIntegral;
			parameters[21].Value = model.Integral;
			parameters[22].Value = model.MinProductNum;
			parameters[23].Value = model.MaxProductNum;
			parameters[24].Value = model.MinProductPrice;
			parameters[25].Value = model.MaxProductPrice;
			parameters[26].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Coupon set ");
			strSql.Append("CouponName=@CouponName,");
			strSql.Append("CouponNo=@CouponNo,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("StartDate=@StartDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("Introduction=@Introduction,");
			strSql.Append("Reason=@Reason,");
			strSql.Append("IsDistribution=@IsDistribution,");
			strSql.Append("DistributionDate=@DistributionDate,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("IsUsed=@IsUsed,");
			strSql.Append("UsedDate=@UsedDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("State=@State,");
			strSql.Append("Email=@Email,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("IsIntegral=@IsIntegral,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("MinProductNum=@MinProductNum,");
			strSql.Append("MaxProductNum=@MaxProductNum,");
			strSql.Append("MinProductPrice=@MinProductPrice,");
			strSql.Append("MaxProductPrice=@MaxProductPrice,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CouponName", SqlDbType.VarChar,200),
					new SqlParameter("@CouponNo", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@StartDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@Introduction", SqlDbType.Text),
					new SqlParameter("@Reason", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDistribution", SqlDbType.Int,4),
					new SqlParameter("@DistributionDate", SqlDbType.DateTime),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@IsUsed", SqlDbType.Int,4),
					new SqlParameter("@UsedDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Mobile", SqlDbType.VarChar,200),
					new SqlParameter("@IsIntegral", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@MinProductNum", SqlDbType.Int,4),
					new SqlParameter("@MaxProductNum", SqlDbType.Int,4),
					new SqlParameter("@MinProductPrice", SqlDbType.Decimal,9),
					new SqlParameter("@MaxProductPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CouponName;
			parameters[1].Value = model.CouponNo;
			parameters[2].Value = model.Amount;
			parameters[3].Value = model.StartDate;
			parameters[4].Value = model.EndDate;
			parameters[5].Value = model.Introduction;
			parameters[6].Value = model.Reason;
			parameters[7].Value = model.IsDistribution;
			parameters[8].Value = model.DistributionDate;
			parameters[9].Value = model.UserID;
			parameters[10].Value = model.UserName;
			parameters[11].Value = model.OrderID;
			parameters[12].Value = model.OrderNo;
			parameters[13].Value = model.IsUsed;
			parameters[14].Value = model.UsedDate;
			parameters[15].Value = model.ModifyDate;
			parameters[16].Value = model.AddDate;
			parameters[17].Value = model.State;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.Mobile;
			parameters[20].Value = model.IsIntegral;
			parameters[21].Value = model.Integral;
			parameters[22].Value = model.MinProductNum;
			parameters[23].Value = model.MaxProductNum;
			parameters[24].Value = model.MinProductPrice;
			parameters[25].Value = model.MaxProductPrice;
			parameters[26].Value = model.WebSiteID;
			parameters[27].Value = model.ID;

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
			strSql.Append("delete from SW_Coupon ");
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
			strSql.Append("delete from SW_Coupon ");
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
		public WebSite.Model.Mod_Coupon GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CouponName,CouponNo,Amount,StartDate,EndDate,Introduction,Reason,IsDistribution,DistributionDate,UserID,UserName,OrderID,OrderNo,IsUsed,UsedDate,ModifyDate,AddDate,State,Email,Mobile,IsIntegral,Integral,MinProductNum,MaxProductNum,MinProductPrice,MaxProductPrice,WebSiteID from SW_Coupon ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Coupon model=new WebSite.Model.Mod_Coupon();
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
		public WebSite.Model.Mod_Coupon DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Coupon model=new WebSite.Model.Mod_Coupon();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CouponName"]!=null)
				{
					model.CouponName=row["CouponName"].ToString();
				}
				if(row["CouponNo"]!=null)
				{
					model.CouponNo=row["CouponNo"].ToString();
				}
				if(row["Amount"]!=null && row["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(row["Amount"].ToString());
				}
				if(row["StartDate"]!=null && row["StartDate"].ToString()!="")
				{
					model.StartDate=DateTime.Parse(row["StartDate"].ToString());
				}
				if(row["EndDate"]!=null && row["EndDate"].ToString()!="")
				{
					model.EndDate=DateTime.Parse(row["EndDate"].ToString());
				}
				if(row["Introduction"]!=null)
				{
					model.Introduction=row["Introduction"].ToString();
				}
				if(row["Reason"]!=null)
				{
					model.Reason=row["Reason"].ToString();
				}
				if(row["IsDistribution"]!=null && row["IsDistribution"].ToString()!="")
				{
					model.IsDistribution=int.Parse(row["IsDistribution"].ToString());
				}
				if(row["DistributionDate"]!=null && row["DistributionDate"].ToString()!="")
				{
					model.DistributionDate=DateTime.Parse(row["DistributionDate"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["OrderID"]!=null && row["OrderID"].ToString()!="")
				{
					model.OrderID=int.Parse(row["OrderID"].ToString());
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["IsUsed"]!=null && row["IsUsed"].ToString()!="")
				{
					model.IsUsed=int.Parse(row["IsUsed"].ToString());
				}
				if(row["UsedDate"]!=null && row["UsedDate"].ToString()!="")
				{
					model.UsedDate=DateTime.Parse(row["UsedDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["IsIntegral"]!=null && row["IsIntegral"].ToString()!="")
				{
					model.IsIntegral=int.Parse(row["IsIntegral"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["MinProductNum"]!=null && row["MinProductNum"].ToString()!="")
				{
					model.MinProductNum=int.Parse(row["MinProductNum"].ToString());
				}
				if(row["MaxProductNum"]!=null && row["MaxProductNum"].ToString()!="")
				{
					model.MaxProductNum=int.Parse(row["MaxProductNum"].ToString());
				}
				if(row["MinProductPrice"]!=null && row["MinProductPrice"].ToString()!="")
				{
					model.MinProductPrice=decimal.Parse(row["MinProductPrice"].ToString());
				}
				if(row["MaxProductPrice"]!=null && row["MaxProductPrice"].ToString()!="")
				{
					model.MaxProductPrice=decimal.Parse(row["MaxProductPrice"].ToString());
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
			strSql.Append("select ID,CouponName,CouponNo,Amount,StartDate,EndDate,Introduction,Reason,IsDistribution,DistributionDate,UserID,UserName,OrderID,OrderNo,IsUsed,UsedDate,ModifyDate,AddDate,State,Email,Mobile,IsIntegral,Integral,MinProductNum,MaxProductNum,MinProductPrice,MaxProductPrice,WebSiteID ");
			strSql.Append(" FROM SW_Coupon ");
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
			strSql.Append(" ID,CouponName,CouponNo,Amount,StartDate,EndDate,Introduction,Reason,IsDistribution,DistributionDate,UserID,UserName,OrderID,OrderNo,IsUsed,UsedDate,ModifyDate,AddDate,State,Email,Mobile,IsIntegral,Integral,MinProductNum,MaxProductNum,MinProductPrice,MaxProductPrice,WebSiteID ");
			strSql.Append(" FROM SW_Coupon ");
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
			strSql.Append("select count(1) FROM SW_Coupon ");
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
                strSql = "select top " + endIndex + " * from SW_Coupon where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Coupon where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Coupon where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Coupon";
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
        /// 更新数据
        /// </summary>
        public bool Update(string strSet, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Coupon ");
            strSql.Append("set " + strSet + " ");
            strSql.Append("where " + strWhere + " ");
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
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_Coupon GetModel(string CouponNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CouponName,CouponNo,Amount,StartDate,EndDate,Introduction,Reason,IsDistribution,DistributionDate,UserID,UserName,OrderID,OrderNo,IsUsed,UsedDate,ModifyDate,AddDate,State,Email,Mobile,IsIntegral,Integral,MinProductNum,MaxProductNum,MinProductPrice,MaxProductPrice,WebSiteID from SW_Coupon ");
            strSql.Append(" where CouponNo=@CouponNo");
            SqlParameter[] parameters = {
					new SqlParameter("@CouponNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = CouponNo;

            WebSite.Model.Mod_Coupon model = new WebSite.Model.Mod_Coupon();
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

