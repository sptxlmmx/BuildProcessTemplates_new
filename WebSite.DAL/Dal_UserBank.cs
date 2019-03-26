

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
    /// <summary>
    /// 数据访问类:Dal_UserBank
    /// </summary>
    public partial class Dal_UserBank
    {
        public Dal_UserBank()
        { }
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserBank"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserBank");
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
		public int Add(WebSite.Model.Mod_UserBank model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserBank(");
			strSql.Append("Model,UserID,NickName,BankType,BankID,BankName,BankUserName,BankIcard,BankNum,AddDate,OrderBy,BankState,State,WebSiteID,BankOpen,Spare,Other1,Other2,Other3,Other4)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@NickName,@BankType,@BankID,@BankName,@BankUserName,@BankIcard,@BankNum,@AddDate,@OrderBy,@BankState,@State,@WebSiteID,@BankOpen,@Spare,@Other1,@Other2,@Other3,@Other4)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@BankType", SqlDbType.VarChar,50),
					new SqlParameter("@BankID", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@BankUserName", SqlDbType.VarChar,50),
					new SqlParameter("@BankIcard", SqlDbType.VarChar,50),
					new SqlParameter("@BankNum", SqlDbType.VarChar,50),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@BankState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@BankOpen", SqlDbType.VarChar,200),
					new SqlParameter("@Spare", SqlDbType.VarChar,200),
					new SqlParameter("@Other1", SqlDbType.Int,4),
					new SqlParameter("@Other2", SqlDbType.Int,4),
					new SqlParameter("@Other3", SqlDbType.VarChar,200),
					new SqlParameter("@Other4", SqlDbType.VarChar,200)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.NickName;
			parameters[3].Value = model.BankType;
			parameters[4].Value = model.BankID;
			parameters[5].Value = model.BankName;
			parameters[6].Value = model.BankUserName;
			parameters[7].Value = model.BankIcard;
			parameters[8].Value = model.BankNum;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.OrderBy;
			parameters[11].Value = model.BankState;
			parameters[12].Value = model.State;
			parameters[13].Value = model.WebSiteID;
			parameters[14].Value = model.BankOpen;
			parameters[15].Value = model.Spare;
			parameters[16].Value = model.Other1;
			parameters[17].Value = model.Other2;
			parameters[18].Value = model.Other3;
			parameters[19].Value = model.Other4;

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
		public bool Update(WebSite.Model.Mod_UserBank model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserBank set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("NickName=@NickName,");
			strSql.Append("BankType=@BankType,");
			strSql.Append("BankID=@BankID,");
			strSql.Append("BankName=@BankName,");
			strSql.Append("BankUserName=@BankUserName,");
			strSql.Append("BankIcard=@BankIcard,");
			strSql.Append("BankNum=@BankNum,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("BankState=@BankState,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("BankOpen=@BankOpen,");
			strSql.Append("Spare=@Spare,");
			strSql.Append("Other1=@Other1,");
			strSql.Append("Other2=@Other2,");
			strSql.Append("Other3=@Other3,");
			strSql.Append("Other4=@Other4");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NickName", SqlDbType.VarChar,200),
					new SqlParameter("@BankType", SqlDbType.VarChar,50),
					new SqlParameter("@BankID", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@BankUserName", SqlDbType.VarChar,50),
					new SqlParameter("@BankIcard", SqlDbType.VarChar,50),
					new SqlParameter("@BankNum", SqlDbType.VarChar,50),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@BankState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@BankOpen", SqlDbType.VarChar,200),
					new SqlParameter("@Spare", SqlDbType.VarChar,200),
					new SqlParameter("@Other1", SqlDbType.Int,4),
					new SqlParameter("@Other2", SqlDbType.Int,4),
					new SqlParameter("@Other3", SqlDbType.VarChar,200),
					new SqlParameter("@Other4", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.NickName;
			parameters[3].Value = model.BankType;
			parameters[4].Value = model.BankID;
			parameters[5].Value = model.BankName;
			parameters[6].Value = model.BankUserName;
			parameters[7].Value = model.BankIcard;
			parameters[8].Value = model.BankNum;
			parameters[9].Value = model.AddDate;
			parameters[10].Value = model.OrderBy;
			parameters[11].Value = model.BankState;
			parameters[12].Value = model.State;
			parameters[13].Value = model.WebSiteID;
			parameters[14].Value = model.BankOpen;
			parameters[15].Value = model.Spare;
			parameters[16].Value = model.Other1;
			parameters[17].Value = model.Other2;
			parameters[18].Value = model.Other3;
			parameters[19].Value = model.Other4;
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
			strSql.Append("delete from SW_UserBank ");
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
			strSql.Append("delete from SW_UserBank ");
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
		public WebSite.Model.Mod_UserBank GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,NickName,BankType,BankID,BankName,BankUserName,BankIcard,BankNum,AddDate,OrderBy,BankState,State,WebSiteID,BankOpen,Spare,Other1,Other2,Other3,Other4 from SW_UserBank ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserBank model=new WebSite.Model.Mod_UserBank();
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
		public WebSite.Model.Mod_UserBank DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserBank model=new WebSite.Model.Mod_UserBank();
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
				if(row["NickName"]!=null)
				{
					model.NickName=row["NickName"].ToString();
				}
				if(row["BankType"]!=null)
				{
					model.BankType=row["BankType"].ToString();
				}
				if(row["BankID"]!=null && row["BankID"].ToString()!="")
				{
					model.BankID=int.Parse(row["BankID"].ToString());
				}
				if(row["BankName"]!=null)
				{
					model.BankName=row["BankName"].ToString();
				}
				if(row["BankUserName"]!=null)
				{
					model.BankUserName=row["BankUserName"].ToString();
				}
				if(row["BankIcard"]!=null)
				{
					model.BankIcard=row["BankIcard"].ToString();
				}
				if(row["BankNum"]!=null)
				{
					model.BankNum=row["BankNum"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["BankState"]!=null && row["BankState"].ToString()!="")
				{
					model.BankState=int.Parse(row["BankState"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["BankOpen"]!=null)
				{
					model.BankOpen=row["BankOpen"].ToString();
				}
				if(row["Spare"]!=null)
				{
					model.Spare=row["Spare"].ToString();
				}
				if(row["Other1"]!=null && row["Other1"].ToString()!="")
				{
					model.Other1=int.Parse(row["Other1"].ToString());
				}
				if(row["Other2"]!=null && row["Other2"].ToString()!="")
				{
					model.Other2=int.Parse(row["Other2"].ToString());
				}
				if(row["Other3"]!=null)
				{
					model.Other3=row["Other3"].ToString();
				}
				if(row["Other4"]!=null)
				{
					model.Other4=row["Other4"].ToString();
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
			strSql.Append("select ID,Model,UserID,NickName,BankType,BankID,BankName,BankUserName,BankIcard,BankNum,AddDate,OrderBy,BankState,State,WebSiteID,BankOpen,Spare,Other1,Other2,Other3,Other4 ");
			strSql.Append(" FROM SW_UserBank ");
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
			strSql.Append(" ID,Model,UserID,NickName,BankType,BankID,BankName,BankUserName,BankIcard,BankNum,AddDate,OrderBy,BankState,State,WebSiteID,BankOpen,Spare,Other1,Other2,Other3,Other4 ");
			strSql.Append(" FROM SW_UserBank ");
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
			strSql.Append("select count(1) FROM SW_UserBank ");
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
                strSql = "select top " + endIndex + " * from SW_UserBank where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserBank where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserBank where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserBank";
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
        public WebSite.Model.Mod_UserBank GetBankNum(string BankNum)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,NickName,BankType,BankID,BankName,BankUserName,BankIcard,BankNum,AddDate,OrderBy,BankState,State,WebSiteID,BankOpen,Spare,Other1,Other2,Other3,Other4 from SW_UserBank ");
            strSql.Append(" where BankNum=@BankNum");
            SqlParameter[] parameters = {
					new SqlParameter("@BankNum", SqlDbType.VarChar,50)
			};
            parameters[0].Value = BankNum;

            WebSite.Model.Mod_UserBank model = new WebSite.Model.Mod_UserBank();
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

