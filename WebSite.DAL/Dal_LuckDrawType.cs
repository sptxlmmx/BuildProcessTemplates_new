/**  版本信息模板在安装目录下，可自行修改。
* Dal_LuckDrawType.cs
*
* 功 能： N/A
* 类 名： Dal_LuckDrawType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/6 16:37:02   N/A    初版
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
	/// 数据访问类:Dal_LuckDrawType
	/// </summary>
	public partial class Dal_LuckDrawType
	{
		public Dal_LuckDrawType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_LuckDrawType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_LuckDrawType");
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
		public int Add(WebSite.Model.Mod_LuckDrawType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_LuckDrawType(");
			strSql.Append("Model,TypeName,Money,Integral,Content1,State,OrderBy,AddDate,TotalTimes,TotalIntergral,TotalMoney)");
			strSql.Append(" values (");
			strSql.Append("@Model,@TypeName,@Money,@Integral,@Content1,@State,@OrderBy,@AddDate,@TotalTimes,@TotalIntergral,@TotalMoney)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@TotalTimes", SqlDbType.Int,4),
					new SqlParameter("@TotalIntergral", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeName;
			parameters[2].Value = model.Money;
			parameters[3].Value = model.Integral;
			parameters[4].Value = model.Content1;
			parameters[5].Value = model.State;
			parameters[6].Value = model.OrderBy;
			parameters[7].Value = model.AddDate;
			parameters[8].Value = model.TotalTimes;
			parameters[9].Value = model.TotalIntergral;
			parameters[10].Value = model.TotalMoney;

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
		public bool Update(WebSite.Model.Mod_LuckDrawType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_LuckDrawType set ");
			strSql.Append("Model=@Model,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Money=@Money,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("TotalTimes=@TotalTimes,");
			strSql.Append("TotalIntergral=@TotalIntergral,");
			strSql.Append("TotalMoney=@TotalMoney");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@TotalTimes", SqlDbType.Int,4),
					new SqlParameter("@TotalIntergral", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeName;
			parameters[2].Value = model.Money;
			parameters[3].Value = model.Integral;
			parameters[4].Value = model.Content1;
			parameters[5].Value = model.State;
			parameters[6].Value = model.OrderBy;
			parameters[7].Value = model.AddDate;
			parameters[8].Value = model.TotalTimes;
			parameters[9].Value = model.TotalIntergral;
			parameters[10].Value = model.TotalMoney;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from SW_LuckDrawType ");
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
			strSql.Append("delete from SW_LuckDrawType ");
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
		public WebSite.Model.Mod_LuckDrawType GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,TypeName,Money,Integral,Content1,State,OrderBy,AddDate,TotalTimes,TotalIntergral,TotalMoney from SW_LuckDrawType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_LuckDrawType model=new WebSite.Model.Mod_LuckDrawType();
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
		public WebSite.Model.Mod_LuckDrawType DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_LuckDrawType model=new WebSite.Model.Mod_LuckDrawType();
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
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
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
				if(row["TotalTimes"]!=null && row["TotalTimes"].ToString()!="")
				{
					model.TotalTimes=int.Parse(row["TotalTimes"].ToString());
				}
				if(row["TotalIntergral"]!=null && row["TotalIntergral"].ToString()!="")
				{
					model.TotalIntergral=int.Parse(row["TotalIntergral"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
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
			strSql.Append("select ID,Model,TypeName,Money,Integral,Content1,State,OrderBy,AddDate,TotalTimes,TotalIntergral,TotalMoney ");
			strSql.Append(" FROM SW_LuckDrawType ");
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
			strSql.Append(" ID,Model,TypeName,Money,Integral,Content1,State,OrderBy,AddDate,TotalTimes,TotalIntergral,TotalMoney ");
			strSql.Append(" FROM SW_LuckDrawType ");
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
			strSql.Append("select count(1) FROM SW_LuckDrawType ");
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
                strSql = "select top " + endIndex + " * from SW_LuckDrawType where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_LuckDrawType where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_LuckDrawType where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_LuckDrawType";
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

