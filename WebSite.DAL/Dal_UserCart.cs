using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserCart
	/// </summary>
	public partial class Dal_UserCart
	{
		public Dal_UserCart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserCart"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserCart");
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
		public int Add(WebSite.Model.Mod_UserCart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserCart(");
            strSql.Append("Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID)");
			strSql.Append(" values (");
            strSql.Append("@Model,@TypeID,@CartID,@ProductID,@ProductNo,@ProductName,@ProductPic,@StockCount,@MinCount,@SkuID,@SkuNo,@SkuSpec,@Price1,@Price2,@Price3,@Price4,@Weight,@IsFreeFreight,@BuyCount,@UserID,@State,@AddDate,@ProductUrl,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@CartID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductPic", SqlDbType.VarChar,500),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@MinCount", SqlDbType.Int,4),
					new SqlParameter("@SkuID", SqlDbType.Int,4),
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
					new SqlParameter("@SkuSpec", SqlDbType.VarChar,500),
					new SqlParameter("@Price1", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@IsFreeFreight", SqlDbType.Int,4),
					new SqlParameter("@BuyCount", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
                    new SqlParameter("@ProductUrl", SqlDbType.VarChar,500),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.CartID;
			parameters[3].Value = model.ProductID;
			parameters[4].Value = model.ProductNo;
			parameters[5].Value = model.ProductName;
			parameters[6].Value = model.ProductPic;
			parameters[7].Value = model.StockCount;
			parameters[8].Value = model.MinCount;
			parameters[9].Value = model.SkuID;
			parameters[10].Value = model.SkuNo;
			parameters[11].Value = model.SkuSpec;
			parameters[12].Value = model.Price1;
			parameters[13].Value = model.Price2;
			parameters[14].Value = model.Price3;
			parameters[15].Value = model.Price4;
			parameters[16].Value = model.Weight;
			parameters[17].Value = model.IsFreeFreight;
			parameters[18].Value = model.BuyCount;
			parameters[19].Value = model.UserID;
			parameters[20].Value = model.State;
			parameters[21].Value = model.AddDate;
            parameters[22].Value = model.ProductUrl;
			parameters[23].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_UserCart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserCart set ");
			strSql.Append("Model=@Model,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("CartID=@CartID,");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("ProductNo=@ProductNo,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductPic=@ProductPic,");
			strSql.Append("StockCount=@StockCount,");
			strSql.Append("MinCount=@MinCount,");
			strSql.Append("SkuID=@SkuID,");
			strSql.Append("SkuNo=@SkuNo,");
			strSql.Append("SkuSpec=@SkuSpec,");
			strSql.Append("Price1=@Price1,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("Price4=@Price4,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("IsFreeFreight=@IsFreeFreight,");
			strSql.Append("BuyCount=@BuyCount,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("State=@State,");
			strSql.Append("AddDate=@AddDate,");
            strSql.Append("ProductUrl=@ProductUrl,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@CartID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductPic", SqlDbType.VarChar,500),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@MinCount", SqlDbType.Int,4),
					new SqlParameter("@SkuID", SqlDbType.Int,4),
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
					new SqlParameter("@SkuSpec", SqlDbType.VarChar,500),
					new SqlParameter("@Price1", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@IsFreeFreight", SqlDbType.Int,4),
					new SqlParameter("@BuyCount", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
                    new SqlParameter("@ProductUrl", SqlDbType.VarChar,500),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.CartID;
			parameters[3].Value = model.ProductID;
			parameters[4].Value = model.ProductNo;
			parameters[5].Value = model.ProductName;
			parameters[6].Value = model.ProductPic;
			parameters[7].Value = model.StockCount;
			parameters[8].Value = model.MinCount;
			parameters[9].Value = model.SkuID;
			parameters[10].Value = model.SkuNo;
			parameters[11].Value = model.SkuSpec;
			parameters[12].Value = model.Price1;
			parameters[13].Value = model.Price2;
			parameters[14].Value = model.Price3;
			parameters[15].Value = model.Price4;
			parameters[16].Value = model.Weight;
			parameters[17].Value = model.IsFreeFreight;
			parameters[18].Value = model.BuyCount;
			parameters[19].Value = model.UserID;
			parameters[20].Value = model.State;
			parameters[21].Value = model.AddDate;
            parameters[22].Value = model.ProductUrl;
			parameters[23].Value = model.WebSiteID;
			parameters[24].Value = model.ID;

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
			strSql.Append("delete from SW_UserCart ");
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
			strSql.Append("delete from SW_UserCart ");
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
		public WebSite.Model.Mod_UserCart GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID from SW_UserCart ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserCart model=new WebSite.Model.Mod_UserCart();
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
		public WebSite.Model.Mod_UserCart DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserCart model=new WebSite.Model.Mod_UserCart();
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
				if(row["CartID"]!=null && row["CartID"].ToString()!="")
				{
					model.CartID=int.Parse(row["CartID"].ToString());
				}
				if(row["ProductID"]!=null && row["ProductID"].ToString()!="")
				{
					model.ProductID=int.Parse(row["ProductID"].ToString());
				}
				if(row["ProductNo"]!=null)
				{
					model.ProductNo=row["ProductNo"].ToString();
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["ProductPic"]!=null)
				{
					model.ProductPic=row["ProductPic"].ToString();
				}
				if(row["StockCount"]!=null && row["StockCount"].ToString()!="")
				{
					model.StockCount=int.Parse(row["StockCount"].ToString());
				}
				if(row["MinCount"]!=null && row["MinCount"].ToString()!="")
				{
					model.MinCount=int.Parse(row["MinCount"].ToString());
				}
				if(row["SkuID"]!=null && row["SkuID"].ToString()!="")
				{
					model.SkuID=int.Parse(row["SkuID"].ToString());
				}
				if(row["SkuNo"]!=null)
				{
					model.SkuNo=row["SkuNo"].ToString();
				}
				if(row["SkuSpec"]!=null)
				{
					model.SkuSpec=row["SkuSpec"].ToString();
				}
				if(row["Price1"]!=null && row["Price1"].ToString()!="")
				{
					model.Price1=decimal.Parse(row["Price1"].ToString());
				}
				if(row["Price2"]!=null && row["Price2"].ToString()!="")
				{
					model.Price2=decimal.Parse(row["Price2"].ToString());
				}
				if(row["Price3"]!=null && row["Price3"].ToString()!="")
				{
					model.Price3=decimal.Parse(row["Price3"].ToString());
				}
				if(row["Price4"]!=null && row["Price4"].ToString()!="")
				{
					model.Price4=decimal.Parse(row["Price4"].ToString());
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(row["Weight"].ToString());
				}
				if(row["IsFreeFreight"]!=null && row["IsFreeFreight"].ToString()!="")
				{
					model.IsFreeFreight=int.Parse(row["IsFreeFreight"].ToString());
				}
				if(row["BuyCount"]!=null && row["BuyCount"].ToString()!="")
				{
					model.BuyCount=int.Parse(row["BuyCount"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
                if (row["ProductUrl"] != null)
                {
                    model.ProductUrl = row["ProductUrl"].ToString();
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
            strSql.Append("select ID,Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID ");
			strSql.Append(" FROM SW_UserCart ");
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
            strSql.Append(" ID,Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID ");
			strSql.Append(" FROM SW_UserCart ");
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
			strSql.Append("select count(1) FROM SW_UserCart ");
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
                strSql = "select top " + endIndex + " * from SW_UserCart where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserCart where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserCart where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserCart";
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
        /// 删除数据
        /// </summary>
        public bool Delete(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_UserCart ");
            strSql.Append(" where " + strWhere + " ");
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
        /// 获取货品总数
        /// </summary>
        public int GetBuyCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(BuyCount) FROM SW_UserCart ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_UserCart GetModel(int ProductID, int UserID, int WebSiteID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID from SW_UserCart ");
            strSql.Append(" where ProductID=@ProductID and UserID=@UserID and WebSiteID=@WebSiteID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
                    new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@WebSiteID", SqlDbType.Int,4)
			};
            parameters[0].Value = ProductID;
            parameters[1].Value = UserID;
            parameters[2].Value = WebSiteID;

            WebSite.Model.Mod_UserCart model = new WebSite.Model.Mod_UserCart();
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
        public WebSite.Model.Mod_UserCart GetModel(int ProductID, int SkuID, int UserID, int WebSiteID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,TypeID,CartID,ProductID,ProductNo,ProductName,ProductPic,StockCount,MinCount,SkuID,SkuNo,SkuSpec,Price1,Price2,Price3,Price4,Weight,IsFreeFreight,BuyCount,UserID,State,AddDate,ProductUrl,WebSiteID from SW_UserCart ");
            strSql.Append(" where ProductID=@ProductID and SkuID=@SkuID and UserID=@UserID and WebSiteID=@WebSiteID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
                    new SqlParameter("@SkuID", SqlDbType.Int,4),
                    new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@WebSiteID", SqlDbType.Int,4)
			};
            parameters[0].Value = ProductID;
            parameters[1].Value = SkuID;
            parameters[2].Value = UserID;
            parameters[3].Value = WebSiteID;

            WebSite.Model.Mod_UserCart model = new WebSite.Model.Mod_UserCart();
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

