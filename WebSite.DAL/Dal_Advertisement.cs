
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Advertisement
	/// </summary>
	public partial class Dal_Advertisement
	{
		public Dal_Advertisement()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Advertisement"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Advertisement");
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
		public int Add(WebSite.Model.Mod_Advertisement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Advertisement(");
			strSql.Append("Model,State,AuditState,OrderBy,AddDate,ModifyDate,BeginDate,EndDate,IsCommend,IsTop,IsHot,UserID,UserName,RealName,AdSponsor,UserLevelID,UserLevelName,Title,ImageUrl,WebUrl,AdCateID,AdCateName,AdTypeID,AdTypeName,AdPayType,AdPositionid,AdPosition,Integral,AdInfo,AdContent,BrowseCount,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSite,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@State,@AuditState,@OrderBy,@AddDate,@ModifyDate,@BeginDate,@EndDate,@IsCommend,@IsTop,@IsHot,@UserID,@UserName,@RealName,@AdSponsor,@UserLevelID,@UserLevelName,@Title,@ImageUrl,@WebUrl,@AdCateID,@AdCateName,@AdTypeID,@AdTypeName,@AdPayType,@AdPositionid,@AdPosition,@Integral,@AdInfo,@AdContent,@BrowseCount,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherInt5,@OtherInt6,@OtherInt7,@OtherInt8,@OtherInt9,@OtherInt10,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@OtherString5,@OtherString6,@OtherString7,@OtherString8,@OtherString9,@OtherString10,@OtherText1,@OtherText2,@OtherText3,@OtherText4,@OtherText5,@WebSite,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@BeginDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@AdSponsor", SqlDbType.VarChar,200),
					new SqlParameter("@UserLevelID", SqlDbType.Int,4),
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@AdCateID", SqlDbType.Int,4),
					new SqlParameter("@AdCateName", SqlDbType.VarChar,200),
					new SqlParameter("@AdTypeID", SqlDbType.Int,4),
					new SqlParameter("@AdTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@AdPayType", SqlDbType.VarChar,200),
					new SqlParameter("@AdPositionid", SqlDbType.Int,4),
					new SqlParameter("@AdPosition", SqlDbType.VarChar,200),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@AdInfo", SqlDbType.Text),
					new SqlParameter("@AdContent", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherInt6", SqlDbType.Int,4),
					new SqlParameter("@OtherInt7", SqlDbType.Int,4),
					new SqlParameter("@OtherInt8", SqlDbType.Int,4),
					new SqlParameter("@OtherInt9", SqlDbType.Int,4),
					new SqlParameter("@OtherInt10", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.Text),
					new SqlParameter("@OtherText5", SqlDbType.Text),
					new SqlParameter("@WebSite", SqlDbType.VarChar,200),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.State;
			parameters[2].Value = model.AuditState;
			parameters[3].Value = model.OrderBy;
			parameters[4].Value = model.AddDate;
			parameters[5].Value = model.ModifyDate;
			parameters[6].Value = model.BeginDate;
			parameters[7].Value = model.EndDate;
			parameters[8].Value = model.IsCommend;
			parameters[9].Value = model.IsTop;
			parameters[10].Value = model.IsHot;
			parameters[11].Value = model.UserID;
			parameters[12].Value = model.UserName;
			parameters[13].Value = model.RealName;
			parameters[14].Value = model.AdSponsor;
			parameters[15].Value = model.UserLevelID;
			parameters[16].Value = model.UserLevelName;
			parameters[17].Value = model.Title;
			parameters[18].Value = model.ImageUrl;
			parameters[19].Value = model.WebUrl;
			parameters[20].Value = model.AdCateID;
			parameters[21].Value = model.AdCateName;
			parameters[22].Value = model.AdTypeID;
			parameters[23].Value = model.AdTypeName;
			parameters[24].Value = model.AdPayType;
			parameters[25].Value = model.AdPositionid;
			parameters[26].Value = model.AdPosition;
			parameters[27].Value = model.Integral;
			parameters[28].Value = model.AdInfo;
			parameters[29].Value = model.AdContent;
			parameters[30].Value = model.BrowseCount;
			parameters[31].Value = model.OtherInt1;
			parameters[32].Value = model.OtherInt2;
			parameters[33].Value = model.OtherInt3;
			parameters[34].Value = model.OtherInt4;
			parameters[35].Value = model.OtherInt5;
			parameters[36].Value = model.OtherInt6;
			parameters[37].Value = model.OtherInt7;
			parameters[38].Value = model.OtherInt8;
			parameters[39].Value = model.OtherInt9;
			parameters[40].Value = model.OtherInt10;
			parameters[41].Value = model.OtherString1;
			parameters[42].Value = model.OtherString2;
			parameters[43].Value = model.OtherString3;
			parameters[44].Value = model.OtherString4;
			parameters[45].Value = model.OtherString5;
			parameters[46].Value = model.OtherString6;
			parameters[47].Value = model.OtherString7;
			parameters[48].Value = model.OtherString8;
			parameters[49].Value = model.OtherString9;
			parameters[50].Value = model.OtherString10;
			parameters[51].Value = model.OtherText1;
			parameters[52].Value = model.OtherText2;
			parameters[53].Value = model.OtherText3;
			parameters[54].Value = model.OtherText4;
			parameters[55].Value = model.OtherText5;
			parameters[56].Value = model.WebSite;
			parameters[57].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Advertisement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Advertisement set ");
			strSql.Append("Model=@Model,");
			strSql.Append("State=@State,");
			strSql.Append("AuditState=@AuditState,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("BeginDate=@BeginDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("IsCommend=@IsCommend,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsHot=@IsHot,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("AdSponsor=@AdSponsor,");
			strSql.Append("UserLevelID=@UserLevelID,");
			strSql.Append("UserLevelName=@UserLevelName,");
			strSql.Append("Title=@Title,");
			strSql.Append("ImageUrl=@ImageUrl,");
			strSql.Append("WebUrl=@WebUrl,");
			strSql.Append("AdCateID=@AdCateID,");
			strSql.Append("AdCateName=@AdCateName,");
			strSql.Append("AdTypeID=@AdTypeID,");
			strSql.Append("AdTypeName=@AdTypeName,");
			strSql.Append("AdPayType=@AdPayType,");
			strSql.Append("AdPositionid=@AdPositionid,");
			strSql.Append("AdPosition=@AdPosition,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("AdInfo=@AdInfo,");
			strSql.Append("AdContent=@AdContent,");
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherInt3=@OtherInt3,");
			strSql.Append("OtherInt4=@OtherInt4,");
			strSql.Append("OtherInt5=@OtherInt5,");
			strSql.Append("OtherInt6=@OtherInt6,");
			strSql.Append("OtherInt7=@OtherInt7,");
			strSql.Append("OtherInt8=@OtherInt8,");
			strSql.Append("OtherInt9=@OtherInt9,");
			strSql.Append("OtherInt10=@OtherInt10,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("OtherString3=@OtherString3,");
			strSql.Append("OtherString4=@OtherString4,");
			strSql.Append("OtherString5=@OtherString5,");
			strSql.Append("OtherString6=@OtherString6,");
			strSql.Append("OtherString7=@OtherString7,");
			strSql.Append("OtherString8=@OtherString8,");
			strSql.Append("OtherString9=@OtherString9,");
			strSql.Append("OtherString10=@OtherString10,");
			strSql.Append("OtherText1=@OtherText1,");
			strSql.Append("OtherText2=@OtherText2,");
			strSql.Append("OtherText3=@OtherText3,");
			strSql.Append("OtherText4=@OtherText4,");
			strSql.Append("OtherText5=@OtherText5,");
			strSql.Append("WebSite=@WebSite,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@BeginDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@AdSponsor", SqlDbType.VarChar,200),
					new SqlParameter("@UserLevelID", SqlDbType.Int,4),
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@AdCateID", SqlDbType.Int,4),
					new SqlParameter("@AdCateName", SqlDbType.VarChar,200),
					new SqlParameter("@AdTypeID", SqlDbType.Int,4),
					new SqlParameter("@AdTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@AdPayType", SqlDbType.VarChar,200),
					new SqlParameter("@AdPositionid", SqlDbType.Int,4),
					new SqlParameter("@AdPosition", SqlDbType.VarChar,200),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@AdInfo", SqlDbType.Text),
					new SqlParameter("@AdContent", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherInt6", SqlDbType.Int,4),
					new SqlParameter("@OtherInt7", SqlDbType.Int,4),
					new SqlParameter("@OtherInt8", SqlDbType.Int,4),
					new SqlParameter("@OtherInt9", SqlDbType.Int,4),
					new SqlParameter("@OtherInt10", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.Text),
					new SqlParameter("@OtherText5", SqlDbType.Text),
					new SqlParameter("@WebSite", SqlDbType.VarChar,200),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.State;
			parameters[2].Value = model.AuditState;
			parameters[3].Value = model.OrderBy;
			parameters[4].Value = model.AddDate;
			parameters[5].Value = model.ModifyDate;
			parameters[6].Value = model.BeginDate;
			parameters[7].Value = model.EndDate;
			parameters[8].Value = model.IsCommend;
			parameters[9].Value = model.IsTop;
			parameters[10].Value = model.IsHot;
			parameters[11].Value = model.UserID;
			parameters[12].Value = model.UserName;
			parameters[13].Value = model.RealName;
			parameters[14].Value = model.AdSponsor;
			parameters[15].Value = model.UserLevelID;
			parameters[16].Value = model.UserLevelName;
			parameters[17].Value = model.Title;
			parameters[18].Value = model.ImageUrl;
			parameters[19].Value = model.WebUrl;
			parameters[20].Value = model.AdCateID;
			parameters[21].Value = model.AdCateName;
			parameters[22].Value = model.AdTypeID;
			parameters[23].Value = model.AdTypeName;
			parameters[24].Value = model.AdPayType;
			parameters[25].Value = model.AdPositionid;
			parameters[26].Value = model.AdPosition;
			parameters[27].Value = model.Integral;
			parameters[28].Value = model.AdInfo;
			parameters[29].Value = model.AdContent;
			parameters[30].Value = model.BrowseCount;
			parameters[31].Value = model.OtherInt1;
			parameters[32].Value = model.OtherInt2;
			parameters[33].Value = model.OtherInt3;
			parameters[34].Value = model.OtherInt4;
			parameters[35].Value = model.OtherInt5;
			parameters[36].Value = model.OtherInt6;
			parameters[37].Value = model.OtherInt7;
			parameters[38].Value = model.OtherInt8;
			parameters[39].Value = model.OtherInt9;
			parameters[40].Value = model.OtherInt10;
			parameters[41].Value = model.OtherString1;
			parameters[42].Value = model.OtherString2;
			parameters[43].Value = model.OtherString3;
			parameters[44].Value = model.OtherString4;
			parameters[45].Value = model.OtherString5;
			parameters[46].Value = model.OtherString6;
			parameters[47].Value = model.OtherString7;
			parameters[48].Value = model.OtherString8;
			parameters[49].Value = model.OtherString9;
			parameters[50].Value = model.OtherString10;
			parameters[51].Value = model.OtherText1;
			parameters[52].Value = model.OtherText2;
			parameters[53].Value = model.OtherText3;
			parameters[54].Value = model.OtherText4;
			parameters[55].Value = model.OtherText5;
			parameters[56].Value = model.WebSite;
			parameters[57].Value = model.WebSiteID;
			parameters[58].Value = model.ID;

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
			strSql.Append("delete from SW_Advertisement ");
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
			strSql.Append("delete from SW_Advertisement ");
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
		public WebSite.Model.Mod_Advertisement GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,State,AuditState,OrderBy,AddDate,ModifyDate,BeginDate,EndDate,IsCommend,IsTop,IsHot,UserID,UserName,RealName,AdSponsor,UserLevelID,UserLevelName,Title,ImageUrl,WebUrl,AdCateID,AdCateName,AdTypeID,AdTypeName,AdPayType,AdPositionid,AdPosition,Integral,AdInfo,AdContent,BrowseCount,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSite,WebSiteID from SW_Advertisement ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Advertisement model=new WebSite.Model.Mod_Advertisement();
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
		public WebSite.Model.Mod_Advertisement DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Advertisement model=new WebSite.Model.Mod_Advertisement();
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
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AuditState"]!=null && row["AuditState"].ToString()!="")
				{
					model.AuditState=int.Parse(row["AuditState"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["BeginDate"]!=null && row["BeginDate"].ToString()!="")
				{
					model.BeginDate=DateTime.Parse(row["BeginDate"].ToString());
				}
				if(row["EndDate"]!=null && row["EndDate"].ToString()!="")
				{
					model.EndDate=DateTime.Parse(row["EndDate"].ToString());
				}
				if(row["IsCommend"]!=null && row["IsCommend"].ToString()!="")
				{
					model.IsCommend=int.Parse(row["IsCommend"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["RealName"]!=null)
				{
					model.RealName=row["RealName"].ToString();
				}
				if(row["AdSponsor"]!=null)
				{
					model.AdSponsor=row["AdSponsor"].ToString();
				}
				if(row["UserLevelID"]!=null && row["UserLevelID"].ToString()!="")
				{
					model.UserLevelID=int.Parse(row["UserLevelID"].ToString());
				}
				if(row["UserLevelName"]!=null)
				{
					model.UserLevelName=row["UserLevelName"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["ImageUrl"]!=null)
				{
					model.ImageUrl=row["ImageUrl"].ToString();
				}
				if(row["WebUrl"]!=null)
				{
					model.WebUrl=row["WebUrl"].ToString();
				}
				if(row["AdCateID"]!=null && row["AdCateID"].ToString()!="")
				{
					model.AdCateID=int.Parse(row["AdCateID"].ToString());
				}
				if(row["AdCateName"]!=null)
				{
					model.AdCateName=row["AdCateName"].ToString();
				}
				if(row["AdTypeID"]!=null && row["AdTypeID"].ToString()!="")
				{
					model.AdTypeID=int.Parse(row["AdTypeID"].ToString());
				}
				if(row["AdTypeName"]!=null)
				{
					model.AdTypeName=row["AdTypeName"].ToString();
				}
				if(row["AdPayType"]!=null)
				{
					model.AdPayType=row["AdPayType"].ToString();
				}
				if(row["AdPositionid"]!=null && row["AdPositionid"].ToString()!="")
				{
					model.AdPositionid=int.Parse(row["AdPositionid"].ToString());
				}
				if(row["AdPosition"]!=null)
				{
					model.AdPosition=row["AdPosition"].ToString();
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["AdInfo"]!=null)
				{
					model.AdInfo=row["AdInfo"].ToString();
				}
				if(row["AdContent"]!=null)
				{
					model.AdContent=row["AdContent"].ToString();
				}
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["OtherInt1"]!=null && row["OtherInt1"].ToString()!="")
				{
					model.OtherInt1=int.Parse(row["OtherInt1"].ToString());
				}
				if(row["OtherInt2"]!=null && row["OtherInt2"].ToString()!="")
				{
					model.OtherInt2=int.Parse(row["OtherInt2"].ToString());
				}
				if(row["OtherInt3"]!=null && row["OtherInt3"].ToString()!="")
				{
					model.OtherInt3=int.Parse(row["OtherInt3"].ToString());
				}
				if(row["OtherInt4"]!=null && row["OtherInt4"].ToString()!="")
				{
					model.OtherInt4=int.Parse(row["OtherInt4"].ToString());
				}
				if(row["OtherInt5"]!=null && row["OtherInt5"].ToString()!="")
				{
					model.OtherInt5=int.Parse(row["OtherInt5"].ToString());
				}
				if(row["OtherInt6"]!=null && row["OtherInt6"].ToString()!="")
				{
					model.OtherInt6=int.Parse(row["OtherInt6"].ToString());
				}
				if(row["OtherInt7"]!=null && row["OtherInt7"].ToString()!="")
				{
					model.OtherInt7=int.Parse(row["OtherInt7"].ToString());
				}
				if(row["OtherInt8"]!=null && row["OtherInt8"].ToString()!="")
				{
					model.OtherInt8=int.Parse(row["OtherInt8"].ToString());
				}
				if(row["OtherInt9"]!=null && row["OtherInt9"].ToString()!="")
				{
					model.OtherInt9=int.Parse(row["OtherInt9"].ToString());
				}
				if(row["OtherInt10"]!=null && row["OtherInt10"].ToString()!="")
				{
					model.OtherInt10=int.Parse(row["OtherInt10"].ToString());
				}
				if(row["OtherString1"]!=null)
				{
					model.OtherString1=row["OtherString1"].ToString();
				}
				if(row["OtherString2"]!=null)
				{
					model.OtherString2=row["OtherString2"].ToString();
				}
				if(row["OtherString3"]!=null)
				{
					model.OtherString3=row["OtherString3"].ToString();
				}
				if(row["OtherString4"]!=null)
				{
					model.OtherString4=row["OtherString4"].ToString();
				}
				if(row["OtherString5"]!=null)
				{
					model.OtherString5=row["OtherString5"].ToString();
				}
				if(row["OtherString6"]!=null)
				{
					model.OtherString6=row["OtherString6"].ToString();
				}
				if(row["OtherString7"]!=null)
				{
					model.OtherString7=row["OtherString7"].ToString();
				}
				if(row["OtherString8"]!=null)
				{
					model.OtherString8=row["OtherString8"].ToString();
				}
				if(row["OtherString9"]!=null)
				{
					model.OtherString9=row["OtherString9"].ToString();
				}
				if(row["OtherString10"]!=null)
				{
					model.OtherString10=row["OtherString10"].ToString();
				}
				if(row["OtherText1"]!=null)
				{
					model.OtherText1=row["OtherText1"].ToString();
				}
				if(row["OtherText2"]!=null)
				{
					model.OtherText2=row["OtherText2"].ToString();
				}
				if(row["OtherText3"]!=null)
				{
					model.OtherText3=row["OtherText3"].ToString();
				}
				if(row["OtherText4"]!=null)
				{
					model.OtherText4=row["OtherText4"].ToString();
				}
				if(row["OtherText5"]!=null)
				{
					model.OtherText5=row["OtherText5"].ToString();
				}
				if(row["WebSite"]!=null)
				{
					model.WebSite=row["WebSite"].ToString();
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
			strSql.Append("select ID,Model,State,AuditState,OrderBy,AddDate,ModifyDate,BeginDate,EndDate,IsCommend,IsTop,IsHot,UserID,UserName,RealName,AdSponsor,UserLevelID,UserLevelName,Title,ImageUrl,WebUrl,AdCateID,AdCateName,AdTypeID,AdTypeName,AdPayType,AdPositionid,AdPosition,Integral,AdInfo,AdContent,BrowseCount,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSite,WebSiteID ");
			strSql.Append(" FROM SW_Advertisement ");
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
			strSql.Append(" ID,Model,State,AuditState,OrderBy,AddDate,ModifyDate,BeginDate,EndDate,IsCommend,IsTop,IsHot,UserID,UserName,RealName,AdSponsor,UserLevelID,UserLevelName,Title,ImageUrl,WebUrl,AdCateID,AdCateName,AdTypeID,AdTypeName,AdPayType,AdPositionid,AdPosition,Integral,AdInfo,AdContent,BrowseCount,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSite,WebSiteID ");
			strSql.Append(" FROM SW_Advertisement ");
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
			strSql.Append("select count(1) FROM SW_Advertisement ");
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
                strSql = "select top " + endIndex + " * from SW_Advertisement where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Advertisement where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Advertisement where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Advertisement";
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

