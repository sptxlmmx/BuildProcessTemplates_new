
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_SupportOrder
	/// </summary>
	public partial class Dal_SupportOrder
	{
		public Dal_SupportOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_SupportOrder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_SupportOrder");
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
		public int Add(WebSite.Model.Mod_SupportOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_SupportOrder(");
			strSql.Append("Model,OrderNo,UserID,UserName,ProductID,ProductName,BigImage,SmallImage,EUserID,EnterName,TempleID,TempleName,Weight,Sum,Integral,TotalIntegral,Price,TotalPrice,Contents,IsPay,PayID,PayName,IsDelivery,PayDate,PayNo,PayAmount,OtherInt1,OtherInt2,OtherString1,OtherString2,Anonymous,OrderState,State,OrderBy,AddDate,SignDate,ModifyDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@UserID,@UserName,@ProductID,@ProductName,@BigImage,@SmallImage,@EUserID,@EnterName,@TempleID,@TempleName,@Weight,@Sum,@Integral,@TotalIntegral,@Price,@TotalPrice,@Contents,@IsPay,@PayID,@PayName,@IsDelivery,@PayDate,@PayNo,@PayAmount,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@Anonymous,@OrderState,@State,@OrderBy,@AddDate,@SignDate,@ModifyDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,200),
					new SqlParameter("@BigImage", SqlDbType.NVarChar,200),
					new SqlParameter("@SmallImage", SqlDbType.NVarChar,200),
					new SqlParameter("@EUserID", SqlDbType.Int,4),
					new SqlParameter("@EnterName", SqlDbType.NVarChar,200),
					new SqlParameter("@TempleID", SqlDbType.Int,4),
					new SqlParameter("@TempleName", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@TotalPrice", SqlDbType.Decimal,9),
					new SqlParameter("@Contents", SqlDbType.NText),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsDelivery", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@Anonymous", SqlDbType.Int,4),
					new SqlParameter("@OrderState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@SignDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.ProductID;
			parameters[5].Value = model.ProductName;
			parameters[6].Value = model.BigImage;
			parameters[7].Value = model.SmallImage;
			parameters[8].Value = model.EUserID;
			parameters[9].Value = model.EnterName;
			parameters[10].Value = model.TempleID;
			parameters[11].Value = model.TempleName;
			parameters[12].Value = model.Weight;
			parameters[13].Value = model.Sum;
			parameters[14].Value = model.Integral;
			parameters[15].Value = model.TotalIntegral;
			parameters[16].Value = model.Price;
			parameters[17].Value = model.TotalPrice;
			parameters[18].Value = model.Contents;
			parameters[19].Value = model.IsPay;
			parameters[20].Value = model.PayID;
			parameters[21].Value = model.PayName;
			parameters[22].Value = model.IsDelivery;
			parameters[23].Value = model.PayDate;
			parameters[24].Value = model.PayNo;
			parameters[25].Value = model.PayAmount;
			parameters[26].Value = model.OtherInt1;
			parameters[27].Value = model.OtherInt2;
			parameters[28].Value = model.OtherString1;
			parameters[29].Value = model.OtherString2;
			parameters[30].Value = model.Anonymous;
			parameters[31].Value = model.OrderState;
			parameters[32].Value = model.State;
			parameters[33].Value = model.OrderBy;
			parameters[34].Value = model.AddDate;
			parameters[35].Value = model.SignDate;
			parameters[36].Value = model.ModifyDate;
			parameters[37].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_SupportOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_SupportOrder set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("BigImage=@BigImage,");
			strSql.Append("SmallImage=@SmallImage,");
			strSql.Append("EUserID=@EUserID,");
			strSql.Append("EnterName=@EnterName,");
			strSql.Append("TempleID=@TempleID,");
			strSql.Append("TempleName=@TempleName,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("Sum=@Sum,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("TotalIntegral=@TotalIntegral,");
			strSql.Append("Price=@Price,");
			strSql.Append("TotalPrice=@TotalPrice,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("IsPay=@IsPay,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("IsDelivery=@IsDelivery,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("Anonymous=@Anonymous,");
			strSql.Append("OrderState=@OrderState,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("SignDate=@SignDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,200),
					new SqlParameter("@BigImage", SqlDbType.NVarChar,200),
					new SqlParameter("@SmallImage", SqlDbType.NVarChar,200),
					new SqlParameter("@EUserID", SqlDbType.Int,4),
					new SqlParameter("@EnterName", SqlDbType.NVarChar,200),
					new SqlParameter("@TempleID", SqlDbType.Int,4),
					new SqlParameter("@TempleName", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Sum", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@TotalPrice", SqlDbType.Decimal,9),
					new SqlParameter("@Contents", SqlDbType.NText),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PayName", SqlDbType.VarChar,200),
					new SqlParameter("@IsDelivery", SqlDbType.Int,4),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.NVarChar,200),
					new SqlParameter("@Anonymous", SqlDbType.Int,4),
					new SqlParameter("@OrderState", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@SignDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.ProductID;
			parameters[5].Value = model.ProductName;
			parameters[6].Value = model.BigImage;
			parameters[7].Value = model.SmallImage;
			parameters[8].Value = model.EUserID;
			parameters[9].Value = model.EnterName;
			parameters[10].Value = model.TempleID;
			parameters[11].Value = model.TempleName;
			parameters[12].Value = model.Weight;
			parameters[13].Value = model.Sum;
			parameters[14].Value = model.Integral;
			parameters[15].Value = model.TotalIntegral;
			parameters[16].Value = model.Price;
			parameters[17].Value = model.TotalPrice;
			parameters[18].Value = model.Contents;
			parameters[19].Value = model.IsPay;
			parameters[20].Value = model.PayID;
			parameters[21].Value = model.PayName;
			parameters[22].Value = model.IsDelivery;
			parameters[23].Value = model.PayDate;
			parameters[24].Value = model.PayNo;
			parameters[25].Value = model.PayAmount;
			parameters[26].Value = model.OtherInt1;
			parameters[27].Value = model.OtherInt2;
			parameters[28].Value = model.OtherString1;
			parameters[29].Value = model.OtherString2;
			parameters[30].Value = model.Anonymous;
			parameters[31].Value = model.OrderState;
			parameters[32].Value = model.State;
			parameters[33].Value = model.OrderBy;
			parameters[34].Value = model.AddDate;
			parameters[35].Value = model.SignDate;
			parameters[36].Value = model.ModifyDate;
			parameters[37].Value = model.WebSiteID;
			parameters[38].Value = model.ID;

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
			strSql.Append("delete from SW_SupportOrder ");
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
			strSql.Append("delete from SW_SupportOrder ");
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
		public WebSite.Model.Mod_SupportOrder GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,ProductID,ProductName,BigImage,SmallImage,EUserID,EnterName,TempleID,TempleName,Weight,Sum,Integral,TotalIntegral,Price,TotalPrice,Contents,IsPay,PayID,PayName,IsDelivery,PayDate,PayNo,PayAmount,OtherInt1,OtherInt2,OtherString1,OtherString2,Anonymous,OrderState,State,OrderBy,AddDate,SignDate,ModifyDate,WebSiteID from SW_SupportOrder ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_SupportOrder model=new WebSite.Model.Mod_SupportOrder();
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
		public WebSite.Model.Mod_SupportOrder DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_SupportOrder model=new WebSite.Model.Mod_SupportOrder();
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
				if(row["ProductID"]!=null && row["ProductID"].ToString()!="")
				{
					model.ProductID=int.Parse(row["ProductID"].ToString());
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["BigImage"]!=null)
				{
					model.BigImage=row["BigImage"].ToString();
				}
				if(row["SmallImage"]!=null)
				{
					model.SmallImage=row["SmallImage"].ToString();
				}
				if(row["EUserID"]!=null && row["EUserID"].ToString()!="")
				{
					model.EUserID=int.Parse(row["EUserID"].ToString());
				}
				if(row["EnterName"]!=null)
				{
					model.EnterName=row["EnterName"].ToString();
				}
				if(row["TempleID"]!=null && row["TempleID"].ToString()!="")
				{
					model.TempleID=int.Parse(row["TempleID"].ToString());
				}
				if(row["TempleName"]!=null)
				{
					model.TempleName=row["TempleName"].ToString();
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(row["Weight"].ToString());
				}
				if(row["Sum"]!=null && row["Sum"].ToString()!="")
				{
					model.Sum=int.Parse(row["Sum"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["TotalIntegral"]!=null && row["TotalIntegral"].ToString()!="")
				{
					model.TotalIntegral=int.Parse(row["TotalIntegral"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["TotalPrice"]!=null && row["TotalPrice"].ToString()!="")
				{
					model.TotalPrice=decimal.Parse(row["TotalPrice"].ToString());
				}
				if(row["Contents"]!=null)
				{
					model.Contents=row["Contents"].ToString();
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
				if(row["IsDelivery"]!=null && row["IsDelivery"].ToString()!="")
				{
					model.IsDelivery=int.Parse(row["IsDelivery"].ToString());
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
				if(row["OtherInt1"]!=null && row["OtherInt1"].ToString()!="")
				{
					model.OtherInt1=int.Parse(row["OtherInt1"].ToString());
				}
				if(row["OtherInt2"]!=null && row["OtherInt2"].ToString()!="")
				{
					model.OtherInt2=int.Parse(row["OtherInt2"].ToString());
				}
				if(row["OtherString1"]!=null)
				{
					model.OtherString1=row["OtherString1"].ToString();
				}
				if(row["OtherString2"]!=null)
				{
					model.OtherString2=row["OtherString2"].ToString();
				}
				if(row["Anonymous"]!=null && row["Anonymous"].ToString()!="")
				{
					model.Anonymous=int.Parse(row["Anonymous"].ToString());
				}
				if(row["OrderState"]!=null && row["OrderState"].ToString()!="")
				{
					model.OrderState=int.Parse(row["OrderState"].ToString());
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
				if(row["SignDate"]!=null && row["SignDate"].ToString()!="")
				{
					model.SignDate=DateTime.Parse(row["SignDate"].ToString());
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
			strSql.Append("select ID,Model,OrderNo,UserID,UserName,ProductID,ProductName,BigImage,SmallImage,EUserID,EnterName,TempleID,TempleName,Weight,Sum,Integral,TotalIntegral,Price,TotalPrice,Contents,IsPay,PayID,PayName,IsDelivery,PayDate,PayNo,PayAmount,OtherInt1,OtherInt2,OtherString1,OtherString2,Anonymous,OrderState,State,OrderBy,AddDate,SignDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportOrder ");
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
			strSql.Append(" ID,Model,OrderNo,UserID,UserName,ProductID,ProductName,BigImage,SmallImage,EUserID,EnterName,TempleID,TempleName,Weight,Sum,Integral,TotalIntegral,Price,TotalPrice,Contents,IsPay,PayID,PayName,IsDelivery,PayDate,PayNo,PayAmount,OtherInt1,OtherInt2,OtherString1,OtherString2,Anonymous,OrderState,State,OrderBy,AddDate,SignDate,ModifyDate,WebSiteID ");
			strSql.Append(" FROM SW_SupportOrder ");
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
			strSql.Append("select count(1) FROM SW_SupportOrder ");
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
                strSql = "select top " + endIndex + " * from SW_SupportOrder where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_SupportOrder where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_SupportOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_SupportOrder";
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
        /// 分页获取供养记录数据列表
        /// </summary>
        public DataSet GetListByPageALL(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportOrder.* from SW_SupportOrder left join SW_User on SW_SupportOrder.UserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";

            }
            else
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_SupportOrder.* from SW_SupportOrder left join SW_User on SW_SupportOrder.UserID=SW_User.ID where  " + strWhere + " and  SW_SupportOrder.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_SupportOrder.ID from SW_SupportOrder where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// 取寺院名称
        /// </summary>
        public DataSet GetListNiceName(string strWhere, int type)
        {
            string sq = "";
            if (type == 1)
            {
                sq = "TempleID,";
            }
            else if (type == 2)
            {
                sq = "EUserID,";
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + sq + "NiceName  ");
            strSql.Append(" FROM SW_SupportOrder ");
            if (type == 1)
            {
                strSql.Append(" left join SW_User on SW_SupportOrder.TempleID=SW_User.ID  ");//取寺院
            }
            else if (type == 2)
            {
                strSql.Append(" left join SW_User on SW_SupportOrder.EUserID=SW_User.ID  ");//取企业
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取寺院的产品
        /// </summary>
        public DataSet GetListProduct(string strWhere, int type)
        {
            string sq = "";
            if (type == 1)
            {
                sq = "TempleID,";
            }
            else if (type == 2)
            {
                sq = "EUserID,";
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + sq + "ProductName,sum(Weight) as Weight,Sum(TotalPrice) as TotalPrice ");
            strSql.Append(" FROM SW_SupportOrder  ");
            if (type == 1)
            {
                strSql.Append(" left join SW_User on SW_SupportOrder.TempleID=SW_User.ID  ");//取寺院
            }
            else if (type == 2)
            {
                strSql.Append(" left join SW_User on SW_SupportOrder.EUserID=SW_User.ID  ");//取企业
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_SupportOrder GetModel(string OrderNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,OrderNo,UserID,UserName,ProductID,ProductName,BigImage,SmallImage,EUserID,EnterName,TempleID,TempleName,Weight,Sum,Integral,TotalIntegral,Price,TotalPrice,Contents,IsPay,PayID,PayName,IsDelivery,PayDate,PayNo,PayAmount,OtherInt1,OtherInt2,OtherString1,OtherString2,Anonymous,OrderState,State,OrderBy,AddDate,SignDate,ModifyDate,WebSiteID from SW_SupportOrder ");
            strSql.Append(" where OrderNo=@OrderNo");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = OrderNo;

            WebSite.Model.Mod_SupportOrder model = new WebSite.Model.Mod_SupportOrder();
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

