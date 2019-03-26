using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_ProductComment
	/// </summary>
	public partial class Dal_ProductComment
	{
		public Dal_ProductComment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_ProductComment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_ProductComment");
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
		public int Add(WebSite.Model.Mod_ProductComment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_ProductComment(");
			strSql.Append("Model,ProductID,ProductNo,ProductName,ProductImg,SkuID,SkuNo,SkuSpec,Price,MarketPrice,OrderID,OrderNo,Content,StarNum,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,IsTop,OrderBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8)");
			strSql.Append(" values (");
			strSql.Append("@Model,@ProductID,@ProductNo,@ProductName,@ProductImg,@SkuID,@SkuNo,@SkuSpec,@Price,@MarketPrice,@OrderID,@OrderNo,@Content,@StarNum,@UserID,@UserName,@Name,@Sex,@Email,@Tel,@Company,@Zip,@Address,@AddDate,@WebSiteID,@State,@ReplyContent,@ReplyDate,@IsLook,@IsTop,@OrderBy,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6,@Attr7,@Attr8)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductImg", SqlDbType.VarChar,500),
					new SqlParameter("@SkuID", SqlDbType.Int,4),
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
					new SqlParameter("@SkuSpec", SqlDbType.VarChar,1500),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@StarNum", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Char,10),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@Zip", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ReplyContent", SqlDbType.Text),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Attr1", SqlDbType.Int,4),
					new SqlParameter("@Attr2", SqlDbType.Int,4),
					new SqlParameter("@Attr3", SqlDbType.Int,4),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.VarChar,200),
					new SqlParameter("@Attr6", SqlDbType.Decimal,9),
					new SqlParameter("@Attr7", SqlDbType.VarChar,500),
					new SqlParameter("@Attr8", SqlDbType.VarChar,500)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductID;
			parameters[2].Value = model.ProductNo;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ProductImg;
			parameters[5].Value = model.SkuID;
			parameters[6].Value = model.SkuNo;
			parameters[7].Value = model.SkuSpec;
			parameters[8].Value = model.Price;
			parameters[9].Value = model.MarketPrice;
			parameters[10].Value = model.OrderID;
			parameters[11].Value = model.OrderNo;
			parameters[12].Value = model.Content;
			parameters[13].Value = model.StarNum;
			parameters[14].Value = model.UserID;
			parameters[15].Value = model.UserName;
			parameters[16].Value = model.Name;
			parameters[17].Value = model.Sex;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.Tel;
			parameters[20].Value = model.Company;
			parameters[21].Value = model.Zip;
			parameters[22].Value = model.Address;
			parameters[23].Value = model.AddDate;
			parameters[24].Value = model.WebSiteID;
			parameters[25].Value = model.State;
			parameters[26].Value = model.ReplyContent;
			parameters[27].Value = model.ReplyDate;
			parameters[28].Value = model.IsLook;
			parameters[29].Value = model.IsTop;
			parameters[30].Value = model.OrderBy;
			parameters[31].Value = model.Attr1;
			parameters[32].Value = model.Attr2;
			parameters[33].Value = model.Attr3;
			parameters[34].Value = model.Attr4;
			parameters[35].Value = model.Attr5;
			parameters[36].Value = model.Attr6;
			parameters[37].Value = model.Attr7;
			parameters[38].Value = model.Attr8;

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
		public bool Update(WebSite.Model.Mod_ProductComment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_ProductComment set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("ProductNo=@ProductNo,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductImg=@ProductImg,");
			strSql.Append("SkuID=@SkuID,");
			strSql.Append("SkuNo=@SkuNo,");
			strSql.Append("SkuSpec=@SkuSpec,");
			strSql.Append("Price=@Price,");
			strSql.Append("MarketPrice=@MarketPrice,");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("Content=@Content,");
			strSql.Append("StarNum=@StarNum,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Email=@Email,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Company=@Company,");
			strSql.Append("Zip=@Zip,");
			strSql.Append("Address=@Address,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("State=@State,");
			strSql.Append("ReplyContent=@ReplyContent,");
			strSql.Append("ReplyDate=@ReplyDate,");
			strSql.Append("IsLook=@IsLook,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("Attr1=@Attr1,");
			strSql.Append("Attr2=@Attr2,");
			strSql.Append("Attr3=@Attr3,");
			strSql.Append("Attr4=@Attr4,");
			strSql.Append("Attr5=@Attr5,");
			strSql.Append("Attr6=@Attr6,");
			strSql.Append("Attr7=@Attr7,");
			strSql.Append("Attr8=@Attr8");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductImg", SqlDbType.VarChar,500),
					new SqlParameter("@SkuID", SqlDbType.Int,4),
					new SqlParameter("@SkuNo", SqlDbType.VarChar,50),
					new SqlParameter("@SkuSpec", SqlDbType.VarChar,1500),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@StarNum", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Char,10),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@Zip", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ReplyContent", SqlDbType.Text),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@IsLook", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Attr1", SqlDbType.Int,4),
					new SqlParameter("@Attr2", SqlDbType.Int,4),
					new SqlParameter("@Attr3", SqlDbType.Int,4),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.VarChar,200),
					new SqlParameter("@Attr6", SqlDbType.Decimal,9),
					new SqlParameter("@Attr7", SqlDbType.VarChar,500),
					new SqlParameter("@Attr8", SqlDbType.VarChar,500),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductID;
			parameters[2].Value = model.ProductNo;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ProductImg;
			parameters[5].Value = model.SkuID;
			parameters[6].Value = model.SkuNo;
			parameters[7].Value = model.SkuSpec;
			parameters[8].Value = model.Price;
			parameters[9].Value = model.MarketPrice;
			parameters[10].Value = model.OrderID;
			parameters[11].Value = model.OrderNo;
			parameters[12].Value = model.Content;
			parameters[13].Value = model.StarNum;
			parameters[14].Value = model.UserID;
			parameters[15].Value = model.UserName;
			parameters[16].Value = model.Name;
			parameters[17].Value = model.Sex;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.Tel;
			parameters[20].Value = model.Company;
			parameters[21].Value = model.Zip;
			parameters[22].Value = model.Address;
			parameters[23].Value = model.AddDate;
			parameters[24].Value = model.WebSiteID;
			parameters[25].Value = model.State;
			parameters[26].Value = model.ReplyContent;
			parameters[27].Value = model.ReplyDate;
			parameters[28].Value = model.IsLook;
			parameters[29].Value = model.IsTop;
			parameters[30].Value = model.OrderBy;
			parameters[31].Value = model.Attr1;
			parameters[32].Value = model.Attr2;
			parameters[33].Value = model.Attr3;
			parameters[34].Value = model.Attr4;
			parameters[35].Value = model.Attr5;
			parameters[36].Value = model.Attr6;
			parameters[37].Value = model.Attr7;
			parameters[38].Value = model.Attr8;
			parameters[39].Value = model.ID;

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
			strSql.Append("delete from SW_ProductComment ");
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
			strSql.Append("delete from SW_ProductComment ");
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
		public WebSite.Model.Mod_ProductComment GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,ProductID,ProductNo,ProductName,ProductImg,SkuID,SkuNo,SkuSpec,Price,MarketPrice,OrderID,OrderNo,Content,StarNum,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,IsTop,OrderBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8 from SW_ProductComment ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_ProductComment model=new WebSite.Model.Mod_ProductComment();
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
		public WebSite.Model.Mod_ProductComment DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_ProductComment model=new WebSite.Model.Mod_ProductComment();
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
				if(row["ProductImg"]!=null)
				{
					model.ProductImg=row["ProductImg"].ToString();
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
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["MarketPrice"]!=null && row["MarketPrice"].ToString()!="")
				{
					model.MarketPrice=decimal.Parse(row["MarketPrice"].ToString());
				}
				if(row["OrderID"]!=null && row["OrderID"].ToString()!="")
				{
					model.OrderID=int.Parse(row["OrderID"].ToString());
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["StarNum"]!=null && row["StarNum"].ToString()!="")
				{
					model.StarNum=int.Parse(row["StarNum"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["Zip"]!=null)
				{
					model.Zip=row["Zip"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["ReplyContent"]!=null)
				{
					model.ReplyContent=row["ReplyContent"].ToString();
				}
				if(row["ReplyDate"]!=null && row["ReplyDate"].ToString()!="")
				{
					model.ReplyDate=DateTime.Parse(row["ReplyDate"].ToString());
				}
				if(row["IsLook"]!=null && row["IsLook"].ToString()!="")
				{
					model.IsLook=int.Parse(row["IsLook"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["Attr1"]!=null && row["Attr1"].ToString()!="")
				{
					model.Attr1=int.Parse(row["Attr1"].ToString());
				}
				if(row["Attr2"]!=null && row["Attr2"].ToString()!="")
				{
					model.Attr2=int.Parse(row["Attr2"].ToString());
				}
				if(row["Attr3"]!=null && row["Attr3"].ToString()!="")
				{
					model.Attr3=int.Parse(row["Attr3"].ToString());
				}
				if(row["Attr4"]!=null)
				{
					model.Attr4=row["Attr4"].ToString();
				}
				if(row["Attr5"]!=null)
				{
					model.Attr5=row["Attr5"].ToString();
				}
				if(row["Attr6"]!=null && row["Attr6"].ToString()!="")
				{
					model.Attr6=decimal.Parse(row["Attr6"].ToString());
				}
				if(row["Attr7"]!=null)
				{
					model.Attr7=row["Attr7"].ToString();
				}
				if(row["Attr8"]!=null)
				{
					model.Attr8=row["Attr8"].ToString();
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
			strSql.Append("select ID,Model,ProductID,ProductNo,ProductName,ProductImg,SkuID,SkuNo,SkuSpec,Price,MarketPrice,OrderID,OrderNo,Content,StarNum,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,IsTop,OrderBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8 ");
			strSql.Append(" FROM SW_ProductComment ");
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
			strSql.Append(" ID,Model,ProductID,ProductNo,ProductName,ProductImg,SkuID,SkuNo,SkuSpec,Price,MarketPrice,OrderID,OrderNo,Content,StarNum,UserID,UserName,Name,Sex,Email,Tel,Company,Zip,Address,AddDate,WebSiteID,State,ReplyContent,ReplyDate,IsLook,IsTop,OrderBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8 ");
			strSql.Append(" FROM SW_ProductComment ");
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
			strSql.Append("select count(1) FROM SW_ProductComment ");
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
                strSql = "select top " + endIndex + " * from SW_ProductComment where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductComment where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductComment where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_ProductComment";
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

