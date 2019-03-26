
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_RedEnvelopes
	/// </summary>
	public partial class Dal_RedEnvelopes
	{
		public Dal_RedEnvelopes()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_RedEnvelopes"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_RedEnvelopes");
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
		public int Add(WebSite.Model.Mod_RedEnvelopes model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_RedEnvelopes(");
			strSql.Append("Model,TypeID,TypeName,RedEnvelopesNum,Money,NewsID,UserOpenID,UserID,UserName,IsBig,IsReceive,ReceiveDate,State,AddDate)");
			strSql.Append(" values (");
			strSql.Append("@Model,@TypeID,@TypeName,@RedEnvelopesNum,@Money,@NewsID,@UserOpenID,@UserID,@UserName,@IsBig,@IsReceive,@ReceiveDate,@State,@AddDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@RedEnvelopesNum", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserOpenID", SqlDbType.VarChar,100),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IsBig", SqlDbType.Int,4),
					new SqlParameter("@IsReceive", SqlDbType.Int,4),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.TypeName;
			parameters[3].Value = model.RedEnvelopesNum;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.NewsID;
			parameters[6].Value = model.UserOpenID;
			parameters[7].Value = model.UserID;
			parameters[8].Value = model.UserName;
			parameters[9].Value = model.IsBig;
			parameters[10].Value = model.IsReceive;
			parameters[11].Value = model.ReceiveDate;
			parameters[12].Value = model.State;
			parameters[13].Value = model.AddDate;

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
		public bool Update(WebSite.Model.Mod_RedEnvelopes model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_RedEnvelopes set ");
			strSql.Append("Model=@Model,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("RedEnvelopesNum=@RedEnvelopesNum,");
			strSql.Append("Money=@Money,");
			strSql.Append("NewsID=@NewsID,");
			strSql.Append("UserOpenID=@UserOpenID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("IsBig=@IsBig,");
			strSql.Append("IsReceive=@IsReceive,");
			strSql.Append("ReceiveDate=@ReceiveDate,");
			strSql.Append("State=@State,");
			strSql.Append("AddDate=@AddDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@RedEnvelopesNum", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@UserOpenID", SqlDbType.VarChar,100),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IsBig", SqlDbType.Int,4),
					new SqlParameter("@IsReceive", SqlDbType.Int,4),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.TypeName;
			parameters[3].Value = model.RedEnvelopesNum;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.NewsID;
			parameters[6].Value = model.UserOpenID;
			parameters[7].Value = model.UserID;
			parameters[8].Value = model.UserName;
			parameters[9].Value = model.IsBig;
			parameters[10].Value = model.IsReceive;
			parameters[11].Value = model.ReceiveDate;
			parameters[12].Value = model.State;
			parameters[13].Value = model.AddDate;
			parameters[14].Value = model.ID;

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
			strSql.Append("delete from SW_RedEnvelopes ");
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
			strSql.Append("delete from SW_RedEnvelopes ");
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
		public WebSite.Model.Mod_RedEnvelopes GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,TypeID,TypeName,RedEnvelopesNum,Money,NewsID,UserOpenID,UserID,UserName,IsBig,IsReceive,ReceiveDate,State,AddDate from SW_RedEnvelopes ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_RedEnvelopes model=new WebSite.Model.Mod_RedEnvelopes();
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
		public WebSite.Model.Mod_RedEnvelopes DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_RedEnvelopes model=new WebSite.Model.Mod_RedEnvelopes();
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
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["RedEnvelopesNum"]!=null)
				{
					model.RedEnvelopesNum=row["RedEnvelopesNum"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["UserOpenID"]!=null)
				{
					model.UserOpenID=row["UserOpenID"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["IsBig"]!=null && row["IsBig"].ToString()!="")
				{
					model.IsBig=int.Parse(row["IsBig"].ToString());
				}
				if(row["IsReceive"]!=null && row["IsReceive"].ToString()!="")
				{
					model.IsReceive=int.Parse(row["IsReceive"].ToString());
				}
				if(row["ReceiveDate"]!=null && row["ReceiveDate"].ToString()!="")
				{
					model.ReceiveDate=DateTime.Parse(row["ReceiveDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
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
			strSql.Append("select ID,Model,TypeID,TypeName,RedEnvelopesNum,Money,NewsID,UserOpenID,UserID,UserName,IsBig,IsReceive,ReceiveDate,State,AddDate ");
			strSql.Append(" FROM SW_RedEnvelopes ");
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
			strSql.Append(" ID,Model,TypeID,TypeName,RedEnvelopesNum,Money,NewsID,UserOpenID,UserID,UserName,IsBig,IsReceive,ReceiveDate,State,AddDate ");
			strSql.Append(" FROM SW_RedEnvelopes ");
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
			strSql.Append("select count(1) FROM SW_RedEnvelopes ");
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
                strSql = "select top " + endIndex + " * from SW_RedEnvelopes where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_RedEnvelopes where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_RedEnvelopes where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_RedEnvelopes";
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

