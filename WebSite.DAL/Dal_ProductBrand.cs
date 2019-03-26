using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_ProductBrand
	/// </summary>
	public partial class Dal_ProductBrand
	{
		public Dal_ProductBrand()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_ProductBrand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_ProductBrand");
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
		public int Add(WebSite.Model.Mod_ProductBrand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_ProductBrand(");
			strSql.Append("BrandName,BrandNameEn,BrandNamePinYin,Company,LogoImg,Image,WebUrl,Keywords,Description,Content,IsTop,IsCommend,State,OrderBy,AddDate,WebSiteID,UserID)");
			strSql.Append(" values (");
			strSql.Append("@BrandName,@BrandNameEn,@BrandNamePinYin,@Company,@LogoImg,@Image,@WebUrl,@Keywords,@Description,@Content,@IsTop,@IsCommend,@State,@OrderBy,@AddDate,@WebSiteID,@UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandName", SqlDbType.VarChar,200),
					new SqlParameter("@BrandNameEn", SqlDbType.VarChar,200),
					new SqlParameter("@BrandNamePinYin", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@LogoImg", SqlDbType.VarChar,500),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Keywords", SqlDbType.VarChar,1000),
					new SqlParameter("@Description", SqlDbType.VarChar,1000),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.BrandName;
			parameters[1].Value = model.BrandNameEn;
			parameters[2].Value = model.BrandNamePinYin;
			parameters[3].Value = model.Company;
			parameters[4].Value = model.LogoImg;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.WebUrl;
			parameters[7].Value = model.Keywords;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.Content;
			parameters[10].Value = model.IsTop;
			parameters[11].Value = model.IsCommend;
			parameters[12].Value = model.State;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.AddDate;
			parameters[15].Value = model.WebSiteID;
			parameters[16].Value = model.UserID;

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
		public bool Update(WebSite.Model.Mod_ProductBrand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_ProductBrand set ");
			strSql.Append("BrandName=@BrandName,");
			strSql.Append("BrandNameEn=@BrandNameEn,");
			strSql.Append("BrandNamePinYin=@BrandNamePinYin,");
			strSql.Append("Company=@Company,");
			strSql.Append("LogoImg=@LogoImg,");
			strSql.Append("Image=@Image,");
			strSql.Append("WebUrl=@WebUrl,");
			strSql.Append("Keywords=@Keywords,");
			strSql.Append("Description=@Description,");
			strSql.Append("Content=@Content,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsCommend=@IsCommend,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("UserID=@UserID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandName", SqlDbType.VarChar,200),
					new SqlParameter("@BrandNameEn", SqlDbType.VarChar,200),
					new SqlParameter("@BrandNamePinYin", SqlDbType.VarChar,200),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@LogoImg", SqlDbType.VarChar,500),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Keywords", SqlDbType.VarChar,1000),
					new SqlParameter("@Description", SqlDbType.VarChar,1000),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.BrandName;
			parameters[1].Value = model.BrandNameEn;
			parameters[2].Value = model.BrandNamePinYin;
			parameters[3].Value = model.Company;
			parameters[4].Value = model.LogoImg;
			parameters[5].Value = model.Image;
			parameters[6].Value = model.WebUrl;
			parameters[7].Value = model.Keywords;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.Content;
			parameters[10].Value = model.IsTop;
			parameters[11].Value = model.IsCommend;
			parameters[12].Value = model.State;
			parameters[13].Value = model.OrderBy;
			parameters[14].Value = model.AddDate;
			parameters[15].Value = model.WebSiteID;
			parameters[16].Value = model.UserID;
			parameters[17].Value = model.ID;

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
			strSql.Append("delete from SW_ProductBrand ");
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
			strSql.Append("delete from SW_ProductBrand ");
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
		public WebSite.Model.Mod_ProductBrand GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,BrandName,BrandNameEn,BrandNamePinYin,Company,LogoImg,Image,WebUrl,Keywords,Description,Content,IsTop,IsCommend,State,OrderBy,AddDate,WebSiteID,UserID from SW_ProductBrand ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_ProductBrand model=new WebSite.Model.Mod_ProductBrand();
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
		public WebSite.Model.Mod_ProductBrand DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_ProductBrand model=new WebSite.Model.Mod_ProductBrand();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["BrandName"]!=null)
				{
					model.BrandName=row["BrandName"].ToString();
				}
				if(row["BrandNameEn"]!=null)
				{
					model.BrandNameEn=row["BrandNameEn"].ToString();
				}
				if(row["BrandNamePinYin"]!=null)
				{
					model.BrandNamePinYin=row["BrandNamePinYin"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["LogoImg"]!=null)
				{
					model.LogoImg=row["LogoImg"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["WebUrl"]!=null)
				{
					model.WebUrl=row["WebUrl"].ToString();
				}
				if(row["Keywords"]!=null)
				{
					model.Keywords=row["Keywords"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsCommend"]!=null && row["IsCommend"].ToString()!="")
				{
					model.IsCommend=int.Parse(row["IsCommend"].ToString());
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
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
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
			strSql.Append("select ID,BrandName,BrandNameEn,BrandNamePinYin,Company,LogoImg,Image,WebUrl,Keywords,Description,Content,IsTop,IsCommend,State,OrderBy,AddDate,WebSiteID,UserID ");
			strSql.Append(" FROM SW_ProductBrand ");
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
			strSql.Append(" ID,BrandName,BrandNameEn,BrandNamePinYin,Company,LogoImg,Image,WebUrl,Keywords,Description,Content,IsTop,IsCommend,State,OrderBy,AddDate,WebSiteID,UserID ");
			strSql.Append(" FROM SW_ProductBrand ");
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
			strSql.Append("select count(1) FROM SW_ProductBrand ");
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
                strSql = "select top " + endIndex + " * from SW_ProductBrand where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_ProductBrand where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_ProductBrand where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_ProductBrand";
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

