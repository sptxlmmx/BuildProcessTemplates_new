/**  版本信息模板在安装目录下，可自行修改。
* Dal_FreeBrokerInvitationDetail.cs
*
* 功 能： N/A
* 类 名： Dal_FreeBrokerInvitationDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/11/15 11:16:55   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_FreeBrokerInvitationDetail
	/// </summary>
	public partial class Dal_FreeBrokerInvitationDetail
	{
		public Dal_FreeBrokerInvitationDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_FreeBrokerInvitationDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_FreeBrokerInvitationDetail");
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
		public int Add(WebSite.Model.Mod_FreeBrokerInvitationDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_FreeBrokerInvitationDetail(");
			strSql.Append("FreeBrokerLevelID,FreeBrokerLevelTItle,FreeBrokerInvitationLevelID,FreeBrokerInvitationLeveTitle,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,Money,ShopProfit,State,OrderBy,Adddate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@FreeBrokerLevelID,@FreeBrokerLevelTItle,@FreeBrokerInvitationLevelID,@FreeBrokerInvitationLeveTitle,@FreeBrokerInvitationActionID,@FreeBrokerInvitationActionTitle,@Money,@ShopProfit,@State,@OrderBy,@Adddate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FreeBrokerLevelID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerLevelTItle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationLevelID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationLeveTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationActionID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationActionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ShopProfit", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Adddate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.FreeBrokerLevelID;
			parameters[1].Value = model.FreeBrokerLevelTItle;
			parameters[2].Value = model.FreeBrokerInvitationLevelID;
			parameters[3].Value = model.FreeBrokerInvitationLeveTitle;
			parameters[4].Value = model.FreeBrokerInvitationActionID;
			parameters[5].Value = model.FreeBrokerInvitationActionTitle;
			parameters[6].Value = model.Money;
			parameters[7].Value = model.ShopProfit;
			parameters[8].Value = model.State;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.Adddate;
			parameters[11].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_FreeBrokerInvitationDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_FreeBrokerInvitationDetail set ");
			strSql.Append("FreeBrokerLevelID=@FreeBrokerLevelID,");
			strSql.Append("FreeBrokerLevelTItle=@FreeBrokerLevelTItle,");
			strSql.Append("FreeBrokerInvitationLevelID=@FreeBrokerInvitationLevelID,");
			strSql.Append("FreeBrokerInvitationLeveTitle=@FreeBrokerInvitationLeveTitle,");
			strSql.Append("FreeBrokerInvitationActionID=@FreeBrokerInvitationActionID,");
			strSql.Append("FreeBrokerInvitationActionTitle=@FreeBrokerInvitationActionTitle,");
			strSql.Append("Money=@Money,");
			strSql.Append("ShopProfit=@ShopProfit,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("Adddate=@Adddate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FreeBrokerLevelID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerLevelTItle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationLevelID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationLeveTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FreeBrokerInvitationActionID", SqlDbType.Int,4),
					new SqlParameter("@FreeBrokerInvitationActionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ShopProfit", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Adddate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FreeBrokerLevelID;
			parameters[1].Value = model.FreeBrokerLevelTItle;
			parameters[2].Value = model.FreeBrokerInvitationLevelID;
			parameters[3].Value = model.FreeBrokerInvitationLeveTitle;
			parameters[4].Value = model.FreeBrokerInvitationActionID;
			parameters[5].Value = model.FreeBrokerInvitationActionTitle;
			parameters[6].Value = model.Money;
			parameters[7].Value = model.ShopProfit;
			parameters[8].Value = model.State;
			parameters[9].Value = model.OrderBy;
			parameters[10].Value = model.Adddate;
			parameters[11].Value = model.WebSiteID;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from SW_FreeBrokerInvitationDetail ");
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
			strSql.Append("delete from SW_FreeBrokerInvitationDetail ");
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
		public WebSite.Model.Mod_FreeBrokerInvitationDetail GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FreeBrokerLevelID,FreeBrokerLevelTItle,FreeBrokerInvitationLevelID,FreeBrokerInvitationLeveTitle,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,Money,ShopProfit,State,OrderBy,Adddate,WebSiteID from SW_FreeBrokerInvitationDetail ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_FreeBrokerInvitationDetail model=new WebSite.Model.Mod_FreeBrokerInvitationDetail();
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
		public WebSite.Model.Mod_FreeBrokerInvitationDetail DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_FreeBrokerInvitationDetail model=new WebSite.Model.Mod_FreeBrokerInvitationDetail();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["FreeBrokerLevelID"]!=null && row["FreeBrokerLevelID"].ToString()!="")
				{
					model.FreeBrokerLevelID=int.Parse(row["FreeBrokerLevelID"].ToString());
				}
				if(row["FreeBrokerLevelTItle"]!=null)
				{
					model.FreeBrokerLevelTItle=row["FreeBrokerLevelTItle"].ToString();
				}
				if(row["FreeBrokerInvitationLevelID"]!=null && row["FreeBrokerInvitationLevelID"].ToString()!="")
				{
					model.FreeBrokerInvitationLevelID=int.Parse(row["FreeBrokerInvitationLevelID"].ToString());
				}
				if(row["FreeBrokerInvitationLeveTitle"]!=null)
				{
					model.FreeBrokerInvitationLeveTitle=row["FreeBrokerInvitationLeveTitle"].ToString();
				}
				if(row["FreeBrokerInvitationActionID"]!=null && row["FreeBrokerInvitationActionID"].ToString()!="")
				{
					model.FreeBrokerInvitationActionID=int.Parse(row["FreeBrokerInvitationActionID"].ToString());
				}
				if(row["FreeBrokerInvitationActionTitle"]!=null)
				{
					model.FreeBrokerInvitationActionTitle=row["FreeBrokerInvitationActionTitle"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["ShopProfit"]!=null && row["ShopProfit"].ToString()!="")
				{
					model.ShopProfit=decimal.Parse(row["ShopProfit"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["Adddate"]!=null && row["Adddate"].ToString()!="")
				{
					model.Adddate=DateTime.Parse(row["Adddate"].ToString());
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
			strSql.Append("select ID,FreeBrokerLevelID,FreeBrokerLevelTItle,FreeBrokerInvitationLevelID,FreeBrokerInvitationLeveTitle,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,Money,ShopProfit,State,OrderBy,Adddate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerInvitationDetail ");
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
			strSql.Append(" ID,FreeBrokerLevelID,FreeBrokerLevelTItle,FreeBrokerInvitationLevelID,FreeBrokerInvitationLeveTitle,FreeBrokerInvitationActionID,FreeBrokerInvitationActionTitle,Money,ShopProfit,State,OrderBy,Adddate,WebSiteID ");
			strSql.Append(" FROM SW_FreeBrokerInvitationDetail ");
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
			strSql.Append("select count(1) FROM SW_FreeBrokerInvitationDetail ");
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
                strSql = "select top " + endIndex + " * from SW_FreeBrokerInvitationDetail where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_FreeBrokerInvitationDetail where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_FreeBrokerInvitationDetail where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_FreeBrokerInvitationDetail";
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

