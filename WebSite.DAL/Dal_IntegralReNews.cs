
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_IntegralReNews
	/// </summary>
	public partial class Dal_IntegralReNews
	{
		public Dal_IntegralReNews()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_IntegralReNews"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_IntegralReNews");
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
		public int Add(WebSite.Model.Mod_IntegralReNews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_IntegralReNews(");
			strSql.Append("Model,Payid,PayName,NewsID,UserID,NickName,OrderNo,Integral,Money,Content1,AddDate,OrderBy,IsPay,PayDate,PayNo,PayAmount,State,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@Payid,@PayName,@NewsID,@UserID,@NickName,@OrderNo,@Integral,@Money,@Content1,@AddDate,@OrderBy,@IsPay,@PayDate,@PayNo,@PayAmount,@State,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Payid", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Payid;
			parameters[2].Value = model.PayName;
			parameters[3].Value = model.NewsID;
			parameters[4].Value = model.UserID;
			parameters[5].Value = model.NickName;
			parameters[6].Value = model.OrderNo;
			parameters[7].Value = model.Integral;
			parameters[8].Value = model.Money;
			parameters[9].Value = model.Content1;
			parameters[10].Value = model.AddDate;
			parameters[11].Value = model.OrderBy;
			parameters[12].Value = model.IsPay;
			parameters[13].Value = model.PayDate;
			parameters[14].Value = model.PayNo;
			parameters[15].Value = model.PayAmount;
			parameters[16].Value = model.State;
			parameters[17].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_IntegralReNews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_IntegralReNews set ");
			strSql.Append("Model=@Model,");
			strSql.Append("Payid=@Payid,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("NickName=@NickName,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("Money=@Money,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Payid", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.Payid;
			parameters[2].Value = model.PayName;
			parameters[3].Value = model.NewsID;
			parameters[4].Value = model.UserID;
			parameters[5].Value = model.NickName;
			parameters[6].Value = model.OrderNo;
			parameters[7].Value = model.Integral;
			parameters[8].Value = model.Money;
			parameters[9].Value = model.Content1;
			parameters[10].Value = model.AddDate;
			parameters[11].Value = model.OrderBy;
			parameters[12].Value = model.IsPay;
			parameters[13].Value = model.PayDate;
			parameters[14].Value = model.PayNo;
			parameters[15].Value = model.PayAmount;
			parameters[16].Value = model.State;
			parameters[17].Value = model.WebSiteID;
			parameters[18].Value = model.ID;

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
			strSql.Append("delete from SW_IntegralReNews ");
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
			strSql.Append("delete from SW_IntegralReNews ");
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
		public WebSite.Model.Mod_IntegralReNews GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,Payid,PayName,NewsID,UserID,NickName,OrderNo,Integral,Money,Content1,AddDate,OrderBy,IsPay,PayDate,PayNo,PayAmount,State,WebSiteID from SW_IntegralReNews ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_IntegralReNews model=new WebSite.Model.Mod_IntegralReNews();
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
		public WebSite.Model.Mod_IntegralReNews DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_IntegralReNews model=new WebSite.Model.Mod_IntegralReNews();
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
				if(row["Payid"]!=null && row["Payid"].ToString()!="")
				{
					model.Payid=int.Parse(row["Payid"].ToString());
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
				}
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["NickName"]!=null)
				{
					model.NickName=row["NickName"].ToString();
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
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
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select ID,Model,Payid,PayName,NewsID,UserID,NickName,OrderNo,Integral,Money,Content1,AddDate,OrderBy,IsPay,PayDate,PayNo,PayAmount,State,WebSiteID ");
			strSql.Append(" FROM SW_IntegralReNews ");
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
			strSql.Append(" ID,Model,Payid,PayName,NewsID,UserID,NickName,OrderNo,Integral,Money,Content1,AddDate,OrderBy,IsPay,PayDate,PayNo,PayAmount,State,WebSiteID ");
			strSql.Append(" FROM SW_IntegralReNews ");
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
			strSql.Append("select count(1) FROM SW_IntegralReNews ");
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
                strSql = "select top " + endIndex + " * from SW_IntegralReNews where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_IntegralReNews where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_IntegralReNews where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_IntegralReNews";
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
        public WebSite.Model.Mod_IntegralReNews GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,Payid,PayName,NewsID,UserID,NickName,OrderNo,Integral,Money,Content1,AddDate,OrderBy,IsPay,PayDate,PayNo,PayAmount,State,WebSiteID from SW_IntegralReNews ");
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_IntegralReNews model = new WebSite.Model.Mod_IntegralReNews();
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

