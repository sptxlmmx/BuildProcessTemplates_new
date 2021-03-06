﻿
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_NewsActionDetail
	/// </summary>
	public partial class Dal_NewsActionDetail
	{
		public Dal_NewsActionDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_NewsActionDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_NewsActionDetail");
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
		public int Add(WebSite.Model.Mod_NewsActionDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_NewsActionDetail(");
			strSql.Append("Model,UserID,NewsID,NewsTitle,NewsSTypeID,NewsSTypeName,NewsActionID,OrderNo,ActionAttrID,ActionAttrTitle,ActionAttrImage,Count,Integral,TotalIntegral,Money,TotalMoney,IsPay,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@NewsID,@NewsTitle,@NewsSTypeID,@NewsSTypeName,@NewsActionID,@OrderNo,@ActionAttrID,@ActionAttrTitle,@ActionAttrImage,@Count,@Integral,@TotalIntegral,@Money,@TotalMoney,@IsPay,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@NewsSTypeID", SqlDbType.Int,4),
					new SqlParameter("@NewsSTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@NewsActionID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@ActionAttrID", SqlDbType.Int,4),
					new SqlParameter("@ActionAttrTitle", SqlDbType.VarChar,200),
					new SqlParameter("@ActionAttrImage", SqlDbType.VarChar,200),
					new SqlParameter("@Count", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.NewsID;
			parameters[3].Value = model.NewsTitle;
			parameters[4].Value = model.NewsSTypeID;
			parameters[5].Value = model.NewsSTypeName;
			parameters[6].Value = model.NewsActionID;
			parameters[7].Value = model.OrderNo;
			parameters[8].Value = model.ActionAttrID;
			parameters[9].Value = model.ActionAttrTitle;
			parameters[10].Value = model.ActionAttrImage;
			parameters[11].Value = model.Count;
			parameters[12].Value = model.Integral;
			parameters[13].Value = model.TotalIntegral;
			parameters[14].Value = model.Money;
			parameters[15].Value = model.TotalMoney;
			parameters[16].Value = model.IsPay;
			parameters[17].Value = model.State;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.AddDate;
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
		public bool Update(WebSite.Model.Mod_NewsActionDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_NewsActionDetail set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("NewsTitle=@NewsTitle,");
			strSql.Append("NewsSTypeID=@NewsSTypeID,");
			strSql.Append("NewsSTypeName=@NewsSTypeName,");
			strSql.Append("NewsActionID=@NewsActionID,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("ActionAttrID=@ActionAttrID,");
			strSql.Append("ActionAttrTitle=@ActionAttrTitle,");
			strSql.Append("ActionAttrImage=@ActionAttrImage,");
			strSql.Append("Count=@Count,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("TotalIntegral=@TotalIntegral,");
			strSql.Append("Money=@Money,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,500),
					new SqlParameter("@NewsSTypeID", SqlDbType.Int,4),
					new SqlParameter("@NewsSTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@NewsActionID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@ActionAttrID", SqlDbType.Int,4),
					new SqlParameter("@ActionAttrTitle", SqlDbType.VarChar,200),
					new SqlParameter("@ActionAttrImage", SqlDbType.VarChar,200),
					new SqlParameter("@Count", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.NewsID;
			parameters[3].Value = model.NewsTitle;
			parameters[4].Value = model.NewsSTypeID;
			parameters[5].Value = model.NewsSTypeName;
			parameters[6].Value = model.NewsActionID;
			parameters[7].Value = model.OrderNo;
			parameters[8].Value = model.ActionAttrID;
			parameters[9].Value = model.ActionAttrTitle;
			parameters[10].Value = model.ActionAttrImage;
			parameters[11].Value = model.Count;
			parameters[12].Value = model.Integral;
			parameters[13].Value = model.TotalIntegral;
			parameters[14].Value = model.Money;
			parameters[15].Value = model.TotalMoney;
			parameters[16].Value = model.IsPay;
			parameters[17].Value = model.State;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.AddDate;
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
			strSql.Append("delete from SW_NewsActionDetail ");
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
			strSql.Append("delete from SW_NewsActionDetail ");
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
		public WebSite.Model.Mod_NewsActionDetail GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,NewsID,NewsTitle,NewsSTypeID,NewsSTypeName,NewsActionID,OrderNo,ActionAttrID,ActionAttrTitle,ActionAttrImage,Count,Integral,TotalIntegral,Money,TotalMoney,IsPay,State,OrderBy,AddDate,WebSiteID from SW_NewsActionDetail ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_NewsActionDetail model=new WebSite.Model.Mod_NewsActionDetail();
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
		public WebSite.Model.Mod_NewsActionDetail DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_NewsActionDetail model=new WebSite.Model.Mod_NewsActionDetail();
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
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["NewsTitle"]!=null)
				{
					model.NewsTitle=row["NewsTitle"].ToString();
				}
				if(row["NewsSTypeID"]!=null && row["NewsSTypeID"].ToString()!="")
				{
					model.NewsSTypeID=int.Parse(row["NewsSTypeID"].ToString());
				}
				if(row["NewsSTypeName"]!=null)
				{
					model.NewsSTypeName=row["NewsSTypeName"].ToString();
				}
				if(row["NewsActionID"]!=null && row["NewsActionID"].ToString()!="")
				{
					model.NewsActionID=int.Parse(row["NewsActionID"].ToString());
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["ActionAttrID"]!=null && row["ActionAttrID"].ToString()!="")
				{
					model.ActionAttrID=int.Parse(row["ActionAttrID"].ToString());
				}
				if(row["ActionAttrTitle"]!=null)
				{
					model.ActionAttrTitle=row["ActionAttrTitle"].ToString();
				}
				if(row["ActionAttrImage"]!=null)
				{
					model.ActionAttrImage=row["ActionAttrImage"].ToString();
				}
				if(row["Count"]!=null && row["Count"].ToString()!="")
				{
					model.Count=int.Parse(row["Count"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["TotalIntegral"]!=null && row["TotalIntegral"].ToString()!="")
				{
					model.TotalIntegral=int.Parse(row["TotalIntegral"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=int.Parse(row["Money"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=int.Parse(row["TotalMoney"].ToString());
				}
				if(row["IsPay"]!=null && row["IsPay"].ToString()!="")
				{
					model.IsPay=int.Parse(row["IsPay"].ToString());
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
			strSql.Append("select ID,Model,UserID,NewsID,NewsTitle,NewsSTypeID,NewsSTypeName,NewsActionID,OrderNo,ActionAttrID,ActionAttrTitle,ActionAttrImage,Count,Integral,TotalIntegral,Money,TotalMoney,IsPay,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_NewsActionDetail ");
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
			strSql.Append(" ID,Model,UserID,NewsID,NewsTitle,NewsSTypeID,NewsSTypeName,NewsActionID,OrderNo,ActionAttrID,ActionAttrTitle,ActionAttrImage,Count,Integral,TotalIntegral,Money,TotalMoney,IsPay,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_NewsActionDetail ");
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
			strSql.Append("select count(1) FROM SW_NewsActionDetail ");
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
                strSql = "select top " + endIndex + " * from SW_NewsActionDetail where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_NewsActionDetail where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_NewsActionDetail where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_NewsActionDetail";
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

