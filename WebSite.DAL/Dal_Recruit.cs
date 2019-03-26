using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Recruit
	/// </summary>
	public partial class Dal_Recruit
	{
		public Dal_Recruit()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Recruit"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Recruit");
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
		public int Add(WebSite.Model.Mod_Recruit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Recruit(");
			strSql.Append("Model,UserID,JobName,TypeID,Department,Sex,JobType,LanguageAbility,Education,Experience,Address,Age,Salary,HiringNum,StartDate,EndDate,Nature,Responsibility,JobRequirements,Content,State,AddDate,OrderBy,IsEssence,IsCommend,IsTop,IsAudit,AuditDate,AuditMember,IsCrawl,FileName,FileURL,Clanguage,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@JobName,@TypeID,@Department,@Sex,@JobType,@LanguageAbility,@Education,@Experience,@Address,@Age,@Salary,@HiringNum,@StartDate,@EndDate,@Nature,@Responsibility,@JobRequirements,@Content,@State,@AddDate,@OrderBy,@IsEssence,@IsCommend,@IsTop,@IsAudit,@AuditDate,@AuditMember,@IsCrawl,@FileName,@FileURL,@Clanguage,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@JobName", SqlDbType.VarChar,200),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@JobType", SqlDbType.VarChar,200),
					new SqlParameter("@LanguageAbility", SqlDbType.VarChar,200),
					new SqlParameter("@Education", SqlDbType.VarChar,200),
					new SqlParameter("@Experience", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Age", SqlDbType.VarChar,200),
					new SqlParameter("@Salary", SqlDbType.VarChar,200),
					new SqlParameter("@HiringNum", SqlDbType.VarChar,200),
					new SqlParameter("@StartDate", SqlDbType.VarChar,50),
					new SqlParameter("@EndDate", SqlDbType.VarChar,50),
					new SqlParameter("@Nature", SqlDbType.VarChar,200),
					new SqlParameter("@Responsibility", SqlDbType.Text),
					new SqlParameter("@JobRequirements", SqlDbType.Text),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsEssence", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsAudit", SqlDbType.Int,4),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@AuditMember", SqlDbType.Int,4),
					new SqlParameter("@IsCrawl", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,200),
					new SqlParameter("@FileURL", SqlDbType.VarChar,500),
					new SqlParameter("@Clanguage", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.JobName;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.Department;
			parameters[5].Value = model.Sex;
			parameters[6].Value = model.JobType;
			parameters[7].Value = model.LanguageAbility;
			parameters[8].Value = model.Education;
			parameters[9].Value = model.Experience;
			parameters[10].Value = model.Address;
			parameters[11].Value = model.Age;
			parameters[12].Value = model.Salary;
			parameters[13].Value = model.HiringNum;
			parameters[14].Value = model.StartDate;
			parameters[15].Value = model.EndDate;
			parameters[16].Value = model.Nature;
			parameters[17].Value = model.Responsibility;
			parameters[18].Value = model.JobRequirements;
			parameters[19].Value = model.Content;
			parameters[20].Value = model.State;
			parameters[21].Value = model.AddDate;
			parameters[22].Value = model.OrderBy;
			parameters[23].Value = model.IsEssence;
			parameters[24].Value = model.IsCommend;
			parameters[25].Value = model.IsTop;
			parameters[26].Value = model.IsAudit;
			parameters[27].Value = model.AuditDate;
			parameters[28].Value = model.AuditMember;
			parameters[29].Value = model.IsCrawl;
			parameters[30].Value = model.FileName;
			parameters[31].Value = model.FileURL;
			parameters[32].Value = model.Clanguage;
			parameters[33].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_Recruit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Recruit set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("JobName=@JobName,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("Department=@Department,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("JobType=@JobType,");
			strSql.Append("LanguageAbility=@LanguageAbility,");
			strSql.Append("Education=@Education,");
			strSql.Append("Experience=@Experience,");
			strSql.Append("Address=@Address,");
			strSql.Append("Age=@Age,");
			strSql.Append("Salary=@Salary,");
			strSql.Append("HiringNum=@HiringNum,");
			strSql.Append("StartDate=@StartDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("Nature=@Nature,");
			strSql.Append("Responsibility=@Responsibility,");
			strSql.Append("JobRequirements=@JobRequirements,");
			strSql.Append("Content=@Content,");
			strSql.Append("State=@State,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("IsEssence=@IsEssence,");
			strSql.Append("IsCommend=@IsCommend,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsAudit=@IsAudit,");
			strSql.Append("AuditDate=@AuditDate,");
			strSql.Append("AuditMember=@AuditMember,");
			strSql.Append("IsCrawl=@IsCrawl,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("FileURL=@FileURL,");
			strSql.Append("Clanguage=@Clanguage,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@JobName", SqlDbType.VarChar,200),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@JobType", SqlDbType.VarChar,200),
					new SqlParameter("@LanguageAbility", SqlDbType.VarChar,200),
					new SqlParameter("@Education", SqlDbType.VarChar,200),
					new SqlParameter("@Experience", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Age", SqlDbType.VarChar,200),
					new SqlParameter("@Salary", SqlDbType.VarChar,200),
					new SqlParameter("@HiringNum", SqlDbType.VarChar,200),
					new SqlParameter("@StartDate", SqlDbType.VarChar,50),
					new SqlParameter("@EndDate", SqlDbType.VarChar,50),
					new SqlParameter("@Nature", SqlDbType.VarChar,200),
					new SqlParameter("@Responsibility", SqlDbType.Text),
					new SqlParameter("@JobRequirements", SqlDbType.Text),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@IsEssence", SqlDbType.Int,4),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsAudit", SqlDbType.Int,4),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@AuditMember", SqlDbType.Int,4),
					new SqlParameter("@IsCrawl", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,200),
					new SqlParameter("@FileURL", SqlDbType.VarChar,500),
					new SqlParameter("@Clanguage", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.JobName;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.Department;
			parameters[5].Value = model.Sex;
			parameters[6].Value = model.JobType;
			parameters[7].Value = model.LanguageAbility;
			parameters[8].Value = model.Education;
			parameters[9].Value = model.Experience;
			parameters[10].Value = model.Address;
			parameters[11].Value = model.Age;
			parameters[12].Value = model.Salary;
			parameters[13].Value = model.HiringNum;
			parameters[14].Value = model.StartDate;
			parameters[15].Value = model.EndDate;
			parameters[16].Value = model.Nature;
			parameters[17].Value = model.Responsibility;
			parameters[18].Value = model.JobRequirements;
			parameters[19].Value = model.Content;
			parameters[20].Value = model.State;
			parameters[21].Value = model.AddDate;
			parameters[22].Value = model.OrderBy;
			parameters[23].Value = model.IsEssence;
			parameters[24].Value = model.IsCommend;
			parameters[25].Value = model.IsTop;
			parameters[26].Value = model.IsAudit;
			parameters[27].Value = model.AuditDate;
			parameters[28].Value = model.AuditMember;
			parameters[29].Value = model.IsCrawl;
			parameters[30].Value = model.FileName;
			parameters[31].Value = model.FileURL;
			parameters[32].Value = model.Clanguage;
			parameters[33].Value = model.WebSiteID;
			parameters[34].Value = model.ID;

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
			strSql.Append("delete from SW_Recruit ");
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
			strSql.Append("delete from SW_Recruit ");
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
		public WebSite.Model.Mod_Recruit GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,JobName,TypeID,Department,Sex,JobType,LanguageAbility,Education,Experience,Address,Age,Salary,HiringNum,StartDate,EndDate,Nature,Responsibility,JobRequirements,Content,State,AddDate,OrderBy,IsEssence,IsCommend,IsTop,IsAudit,AuditDate,AuditMember,IsCrawl,FileName,FileURL,Clanguage,WebSiteID from SW_Recruit ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Recruit model=new WebSite.Model.Mod_Recruit();
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
		public WebSite.Model.Mod_Recruit DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Recruit model=new WebSite.Model.Mod_Recruit();
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
				if(row["JobName"]!=null)
				{
					model.JobName=row["JobName"].ToString();
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["Department"]!=null)
				{
					model.Department=row["Department"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["JobType"]!=null)
				{
					model.JobType=row["JobType"].ToString();
				}
				if(row["LanguageAbility"]!=null)
				{
					model.LanguageAbility=row["LanguageAbility"].ToString();
				}
				if(row["Education"]!=null)
				{
					model.Education=row["Education"].ToString();
				}
				if(row["Experience"]!=null)
				{
					model.Experience=row["Experience"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Age"]!=null)
				{
					model.Age=row["Age"].ToString();
				}
				if(row["Salary"]!=null)
				{
					model.Salary=row["Salary"].ToString();
				}
				if(row["HiringNum"]!=null)
				{
					model.HiringNum=row["HiringNum"].ToString();
				}
				if(row["StartDate"]!=null)
				{
					model.StartDate=row["StartDate"].ToString();
				}
				if(row["EndDate"]!=null)
				{
					model.EndDate=row["EndDate"].ToString();
				}
				if(row["Nature"]!=null)
				{
					model.Nature=row["Nature"].ToString();
				}
				if(row["Responsibility"]!=null)
				{
					model.Responsibility=row["Responsibility"].ToString();
				}
				if(row["JobRequirements"]!=null)
				{
					model.JobRequirements=row["JobRequirements"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["IsEssence"]!=null && row["IsEssence"].ToString()!="")
				{
					model.IsEssence=int.Parse(row["IsEssence"].ToString());
				}
				if(row["IsCommend"]!=null && row["IsCommend"].ToString()!="")
				{
					model.IsCommend=int.Parse(row["IsCommend"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsAudit"]!=null && row["IsAudit"].ToString()!="")
				{
					model.IsAudit=int.Parse(row["IsAudit"].ToString());
				}
				if(row["AuditDate"]!=null && row["AuditDate"].ToString()!="")
				{
					model.AuditDate=DateTime.Parse(row["AuditDate"].ToString());
				}
				if(row["AuditMember"]!=null && row["AuditMember"].ToString()!="")
				{
					model.AuditMember=int.Parse(row["AuditMember"].ToString());
				}
				if(row["IsCrawl"]!=null && row["IsCrawl"].ToString()!="")
				{
					model.IsCrawl=int.Parse(row["IsCrawl"].ToString());
				}
				if(row["FileName"]!=null)
				{
					model.FileName=row["FileName"].ToString();
				}
				if(row["FileURL"]!=null)
				{
					model.FileURL=row["FileURL"].ToString();
				}
				if(row["Clanguage"]!=null && row["Clanguage"].ToString()!="")
				{
					model.Clanguage=int.Parse(row["Clanguage"].ToString());
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
			strSql.Append("select ID,Model,UserID,JobName,TypeID,Department,Sex,JobType,LanguageAbility,Education,Experience,Address,Age,Salary,HiringNum,StartDate,EndDate,Nature,Responsibility,JobRequirements,Content,State,AddDate,OrderBy,IsEssence,IsCommend,IsTop,IsAudit,AuditDate,AuditMember,IsCrawl,FileName,FileURL,Clanguage,WebSiteID ");
			strSql.Append(" FROM SW_Recruit ");
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
			strSql.Append(" ID,Model,UserID,JobName,TypeID,Department,Sex,JobType,LanguageAbility,Education,Experience,Address,Age,Salary,HiringNum,StartDate,EndDate,Nature,Responsibility,JobRequirements,Content,State,AddDate,OrderBy,IsEssence,IsCommend,IsTop,IsAudit,AuditDate,AuditMember,IsCrawl,FileName,FileURL,Clanguage,WebSiteID ");
			strSql.Append(" FROM SW_Recruit ");
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
			strSql.Append("select count(1) FROM SW_Recruit ");
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
                strSql = "select top " + endIndex + " * from SW_Recruit where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Recruit where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Recruit where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Recruit";
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

