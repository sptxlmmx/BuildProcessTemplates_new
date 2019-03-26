
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Statistics
	/// </summary>
	public partial class Dal_Statistics
	{
		public Dal_Statistics()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Statistics"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Statistics");
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
		public int Add(WebSite.Model.Mod_Statistics model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Statistics(");
			strSql.Append("Model,StatisticsDate,IntegralAll,IntegralAllCurrent,IntegralOutputDay,IntegralInputDay,IntegralInvitationTotal,IntegralNoInvitationTotal,IntegralShareTotal,IntegralShareProductTotal,IntegralNewsTotal,IntegralVideoTotal,IntegralMusicTotal,IntegralBestAnswer,IntegralTips,IntegralSell,IntegralNewsModify,IntegralMarketSell,IntegralProductSell,IntegralProductSellOut,IntegralAdvertisement,IntegralContact,IntegralReNews,IntegralAttend,IntegralDistribution,IntegralDistributionIn,MoneyWithdraw,MoneySell,MoneyOutputDay,MoneyInputDay,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@StatisticsDate,@IntegralAll,@IntegralAllCurrent,@IntegralOutputDay,@IntegralInputDay,@IntegralInvitationTotal,@IntegralNoInvitationTotal,@IntegralShareTotal,@IntegralShareProductTotal,@IntegralNewsTotal,@IntegralVideoTotal,@IntegralMusicTotal,@IntegralBestAnswer,@IntegralTips,@IntegralSell,@IntegralNewsModify,@IntegralMarketSell,@IntegralProductSell,@IntegralProductSellOut,@IntegralAdvertisement,@IntegralContact,@IntegralReNews,@IntegralAttend,@IntegralDistribution,@IntegralDistributionIn,@MoneyWithdraw,@MoneySell,@MoneyOutputDay,@MoneyInputDay,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@StatisticsDate", SqlDbType.VarChar,50),
					new SqlParameter("@IntegralAll", SqlDbType.Int,4),
					new SqlParameter("@IntegralAllCurrent", SqlDbType.Int,4),
					new SqlParameter("@IntegralOutputDay", SqlDbType.Int,4),
					new SqlParameter("@IntegralInputDay", SqlDbType.Int,4),
					new SqlParameter("@IntegralInvitationTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralNoInvitationTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralShareTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralShareProductTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralNewsTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralVideoTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralMusicTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralBestAnswer", SqlDbType.Int,4),
					new SqlParameter("@IntegralTips", SqlDbType.Int,4),
					new SqlParameter("@IntegralSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralNewsModify", SqlDbType.Int,4),
					new SqlParameter("@IntegralMarketSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralProductSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralProductSellOut", SqlDbType.Int,4),
					new SqlParameter("@IntegralAdvertisement", SqlDbType.Int,4),
					new SqlParameter("@IntegralContact", SqlDbType.Int,4),
					new SqlParameter("@IntegralReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralAttend", SqlDbType.Int,4),
					new SqlParameter("@IntegralDistribution", SqlDbType.Int,4),
					new SqlParameter("@IntegralDistributionIn", SqlDbType.Int,4),
					new SqlParameter("@MoneyWithdraw", SqlDbType.Decimal,9),
					new SqlParameter("@MoneySell", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyOutputDay", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyInputDay", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.StatisticsDate;
			parameters[2].Value = model.IntegralAll;
			parameters[3].Value = model.IntegralAllCurrent;
			parameters[4].Value = model.IntegralOutputDay;
			parameters[5].Value = model.IntegralInputDay;
			parameters[6].Value = model.IntegralInvitationTotal;
			parameters[7].Value = model.IntegralNoInvitationTotal;
			parameters[8].Value = model.IntegralShareTotal;
			parameters[9].Value = model.IntegralShareProductTotal;
			parameters[10].Value = model.IntegralNewsTotal;
			parameters[11].Value = model.IntegralVideoTotal;
			parameters[12].Value = model.IntegralMusicTotal;
			parameters[13].Value = model.IntegralBestAnswer;
			parameters[14].Value = model.IntegralTips;
			parameters[15].Value = model.IntegralSell;
			parameters[16].Value = model.IntegralNewsModify;
			parameters[17].Value = model.IntegralMarketSell;
			parameters[18].Value = model.IntegralProductSell;
			parameters[19].Value = model.IntegralProductSellOut;
			parameters[20].Value = model.IntegralAdvertisement;
			parameters[21].Value = model.IntegralContact;
			parameters[22].Value = model.IntegralReNews;
			parameters[23].Value = model.IntegralAttend;
			parameters[24].Value = model.IntegralDistribution;
			parameters[25].Value = model.IntegralDistributionIn;
			parameters[26].Value = model.MoneyWithdraw;
			parameters[27].Value = model.MoneySell;
			parameters[28].Value = model.MoneyOutputDay;
			parameters[29].Value = model.MoneyInputDay;
			parameters[30].Value = model.State;
			parameters[31].Value = model.OrderBy;
			parameters[32].Value = model.AddDate;
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
		public bool Update(WebSite.Model.Mod_Statistics model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Statistics set ");
			strSql.Append("Model=@Model,");
			strSql.Append("StatisticsDate=@StatisticsDate,");
			strSql.Append("IntegralAll=@IntegralAll,");
			strSql.Append("IntegralAllCurrent=@IntegralAllCurrent,");
			strSql.Append("IntegralOutputDay=@IntegralOutputDay,");
			strSql.Append("IntegralInputDay=@IntegralInputDay,");
			strSql.Append("IntegralInvitationTotal=@IntegralInvitationTotal,");
			strSql.Append("IntegralNoInvitationTotal=@IntegralNoInvitationTotal,");
			strSql.Append("IntegralShareTotal=@IntegralShareTotal,");
			strSql.Append("IntegralShareProductTotal=@IntegralShareProductTotal,");
			strSql.Append("IntegralNewsTotal=@IntegralNewsTotal,");
			strSql.Append("IntegralVideoTotal=@IntegralVideoTotal,");
			strSql.Append("IntegralMusicTotal=@IntegralMusicTotal,");
			strSql.Append("IntegralBestAnswer=@IntegralBestAnswer,");
			strSql.Append("IntegralTips=@IntegralTips,");
			strSql.Append("IntegralSell=@IntegralSell,");
			strSql.Append("IntegralNewsModify=@IntegralNewsModify,");
			strSql.Append("IntegralMarketSell=@IntegralMarketSell,");
			strSql.Append("IntegralProductSell=@IntegralProductSell,");
			strSql.Append("IntegralProductSellOut=@IntegralProductSellOut,");
			strSql.Append("IntegralAdvertisement=@IntegralAdvertisement,");
			strSql.Append("IntegralContact=@IntegralContact,");
			strSql.Append("IntegralReNews=@IntegralReNews,");
			strSql.Append("IntegralAttend=@IntegralAttend,");
			strSql.Append("IntegralDistribution=@IntegralDistribution,");
			strSql.Append("IntegralDistributionIn=@IntegralDistributionIn,");
			strSql.Append("MoneyWithdraw=@MoneyWithdraw,");
			strSql.Append("MoneySell=@MoneySell,");
			strSql.Append("MoneyOutputDay=@MoneyOutputDay,");
			strSql.Append("MoneyInputDay=@MoneyInputDay,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@StatisticsDate", SqlDbType.VarChar,50),
					new SqlParameter("@IntegralAll", SqlDbType.Int,4),
					new SqlParameter("@IntegralAllCurrent", SqlDbType.Int,4),
					new SqlParameter("@IntegralOutputDay", SqlDbType.Int,4),
					new SqlParameter("@IntegralInputDay", SqlDbType.Int,4),
					new SqlParameter("@IntegralInvitationTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralNoInvitationTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralShareTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralShareProductTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralNewsTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralVideoTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralMusicTotal", SqlDbType.Int,4),
					new SqlParameter("@IntegralBestAnswer", SqlDbType.Int,4),
					new SqlParameter("@IntegralTips", SqlDbType.Int,4),
					new SqlParameter("@IntegralSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralNewsModify", SqlDbType.Int,4),
					new SqlParameter("@IntegralMarketSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralProductSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralProductSellOut", SqlDbType.Int,4),
					new SqlParameter("@IntegralAdvertisement", SqlDbType.Int,4),
					new SqlParameter("@IntegralContact", SqlDbType.Int,4),
					new SqlParameter("@IntegralReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralAttend", SqlDbType.Int,4),
					new SqlParameter("@IntegralDistribution", SqlDbType.Int,4),
					new SqlParameter("@IntegralDistributionIn", SqlDbType.Int,4),
					new SqlParameter("@MoneyWithdraw", SqlDbType.Decimal,9),
					new SqlParameter("@MoneySell", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyOutputDay", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyInputDay", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.StatisticsDate;
			parameters[2].Value = model.IntegralAll;
			parameters[3].Value = model.IntegralAllCurrent;
			parameters[4].Value = model.IntegralOutputDay;
			parameters[5].Value = model.IntegralInputDay;
			parameters[6].Value = model.IntegralInvitationTotal;
			parameters[7].Value = model.IntegralNoInvitationTotal;
			parameters[8].Value = model.IntegralShareTotal;
			parameters[9].Value = model.IntegralShareProductTotal;
			parameters[10].Value = model.IntegralNewsTotal;
			parameters[11].Value = model.IntegralVideoTotal;
			parameters[12].Value = model.IntegralMusicTotal;
			parameters[13].Value = model.IntegralBestAnswer;
			parameters[14].Value = model.IntegralTips;
			parameters[15].Value = model.IntegralSell;
			parameters[16].Value = model.IntegralNewsModify;
			parameters[17].Value = model.IntegralMarketSell;
			parameters[18].Value = model.IntegralProductSell;
			parameters[19].Value = model.IntegralProductSellOut;
			parameters[20].Value = model.IntegralAdvertisement;
			parameters[21].Value = model.IntegralContact;
			parameters[22].Value = model.IntegralReNews;
			parameters[23].Value = model.IntegralAttend;
			parameters[24].Value = model.IntegralDistribution;
			parameters[25].Value = model.IntegralDistributionIn;
			parameters[26].Value = model.MoneyWithdraw;
			parameters[27].Value = model.MoneySell;
			parameters[28].Value = model.MoneyOutputDay;
			parameters[29].Value = model.MoneyInputDay;
			parameters[30].Value = model.State;
			parameters[31].Value = model.OrderBy;
			parameters[32].Value = model.AddDate;
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
			strSql.Append("delete from SW_Statistics ");
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
			strSql.Append("delete from SW_Statistics ");
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
		public WebSite.Model.Mod_Statistics GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,StatisticsDate,IntegralAll,IntegralAllCurrent,IntegralOutputDay,IntegralInputDay,IntegralInvitationTotal,IntegralNoInvitationTotal,IntegralShareTotal,IntegralShareProductTotal,IntegralNewsTotal,IntegralVideoTotal,IntegralMusicTotal,IntegralBestAnswer,IntegralTips,IntegralSell,IntegralNewsModify,IntegralMarketSell,IntegralProductSell,IntegralProductSellOut,IntegralAdvertisement,IntegralContact,IntegralReNews,IntegralAttend,IntegralDistribution,IntegralDistributionIn,MoneyWithdraw,MoneySell,MoneyOutputDay,MoneyInputDay,State,OrderBy,AddDate,WebSiteID from SW_Statistics ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Statistics model=new WebSite.Model.Mod_Statistics();
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
		public WebSite.Model.Mod_Statistics DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Statistics model=new WebSite.Model.Mod_Statistics();
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
				if(row["StatisticsDate"]!=null)
				{
					model.StatisticsDate=row["StatisticsDate"].ToString();
				}
				if(row["IntegralAll"]!=null && row["IntegralAll"].ToString()!="")
				{
					model.IntegralAll=int.Parse(row["IntegralAll"].ToString());
				}
				if(row["IntegralAllCurrent"]!=null && row["IntegralAllCurrent"].ToString()!="")
				{
					model.IntegralAllCurrent=int.Parse(row["IntegralAllCurrent"].ToString());
				}
				if(row["IntegralOutputDay"]!=null && row["IntegralOutputDay"].ToString()!="")
				{
					model.IntegralOutputDay=int.Parse(row["IntegralOutputDay"].ToString());
				}
				if(row["IntegralInputDay"]!=null && row["IntegralInputDay"].ToString()!="")
				{
					model.IntegralInputDay=int.Parse(row["IntegralInputDay"].ToString());
				}
				if(row["IntegralInvitationTotal"]!=null && row["IntegralInvitationTotal"].ToString()!="")
				{
					model.IntegralInvitationTotal=int.Parse(row["IntegralInvitationTotal"].ToString());
				}
				if(row["IntegralNoInvitationTotal"]!=null && row["IntegralNoInvitationTotal"].ToString()!="")
				{
					model.IntegralNoInvitationTotal=int.Parse(row["IntegralNoInvitationTotal"].ToString());
				}
				if(row["IntegralShareTotal"]!=null && row["IntegralShareTotal"].ToString()!="")
				{
					model.IntegralShareTotal=int.Parse(row["IntegralShareTotal"].ToString());
				}
				if(row["IntegralShareProductTotal"]!=null && row["IntegralShareProductTotal"].ToString()!="")
				{
					model.IntegralShareProductTotal=int.Parse(row["IntegralShareProductTotal"].ToString());
				}
				if(row["IntegralNewsTotal"]!=null && row["IntegralNewsTotal"].ToString()!="")
				{
					model.IntegralNewsTotal=int.Parse(row["IntegralNewsTotal"].ToString());
				}
				if(row["IntegralVideoTotal"]!=null && row["IntegralVideoTotal"].ToString()!="")
				{
					model.IntegralVideoTotal=int.Parse(row["IntegralVideoTotal"].ToString());
				}
				if(row["IntegralMusicTotal"]!=null && row["IntegralMusicTotal"].ToString()!="")
				{
					model.IntegralMusicTotal=int.Parse(row["IntegralMusicTotal"].ToString());
				}
				if(row["IntegralBestAnswer"]!=null && row["IntegralBestAnswer"].ToString()!="")
				{
					model.IntegralBestAnswer=int.Parse(row["IntegralBestAnswer"].ToString());
				}
				if(row["IntegralTips"]!=null && row["IntegralTips"].ToString()!="")
				{
					model.IntegralTips=int.Parse(row["IntegralTips"].ToString());
				}
				if(row["IntegralSell"]!=null && row["IntegralSell"].ToString()!="")
				{
					model.IntegralSell=int.Parse(row["IntegralSell"].ToString());
				}
				if(row["IntegralNewsModify"]!=null && row["IntegralNewsModify"].ToString()!="")
				{
					model.IntegralNewsModify=int.Parse(row["IntegralNewsModify"].ToString());
				}
				if(row["IntegralMarketSell"]!=null && row["IntegralMarketSell"].ToString()!="")
				{
					model.IntegralMarketSell=int.Parse(row["IntegralMarketSell"].ToString());
				}
				if(row["IntegralProductSell"]!=null && row["IntegralProductSell"].ToString()!="")
				{
					model.IntegralProductSell=int.Parse(row["IntegralProductSell"].ToString());
				}
				if(row["IntegralProductSellOut"]!=null && row["IntegralProductSellOut"].ToString()!="")
				{
					model.IntegralProductSellOut=int.Parse(row["IntegralProductSellOut"].ToString());
				}
				if(row["IntegralAdvertisement"]!=null && row["IntegralAdvertisement"].ToString()!="")
				{
					model.IntegralAdvertisement=int.Parse(row["IntegralAdvertisement"].ToString());
				}
				if(row["IntegralContact"]!=null && row["IntegralContact"].ToString()!="")
				{
					model.IntegralContact=int.Parse(row["IntegralContact"].ToString());
				}
				if(row["IntegralReNews"]!=null && row["IntegralReNews"].ToString()!="")
				{
					model.IntegralReNews=int.Parse(row["IntegralReNews"].ToString());
				}
				if(row["IntegralAttend"]!=null && row["IntegralAttend"].ToString()!="")
				{
					model.IntegralAttend=int.Parse(row["IntegralAttend"].ToString());
				}
				if(row["IntegralDistribution"]!=null && row["IntegralDistribution"].ToString()!="")
				{
					model.IntegralDistribution=int.Parse(row["IntegralDistribution"].ToString());
				}
				if(row["IntegralDistributionIn"]!=null && row["IntegralDistributionIn"].ToString()!="")
				{
					model.IntegralDistributionIn=int.Parse(row["IntegralDistributionIn"].ToString());
				}
				if(row["MoneyWithdraw"]!=null && row["MoneyWithdraw"].ToString()!="")
				{
					model.MoneyWithdraw=decimal.Parse(row["MoneyWithdraw"].ToString());
				}
				if(row["MoneySell"]!=null && row["MoneySell"].ToString()!="")
				{
					model.MoneySell=decimal.Parse(row["MoneySell"].ToString());
				}
				if(row["MoneyOutputDay"]!=null && row["MoneyOutputDay"].ToString()!="")
				{
					model.MoneyOutputDay=decimal.Parse(row["MoneyOutputDay"].ToString());
				}
				if(row["MoneyInputDay"]!=null && row["MoneyInputDay"].ToString()!="")
				{
					model.MoneyInputDay=decimal.Parse(row["MoneyInputDay"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Model,StatisticsDate,IntegralAll,IntegralAllCurrent,IntegralOutputDay,IntegralInputDay,IntegralInvitationTotal,IntegralNoInvitationTotal,IntegralShareTotal,IntegralShareProductTotal,IntegralNewsTotal,IntegralVideoTotal,IntegralMusicTotal,IntegralBestAnswer,IntegralTips,IntegralSell,IntegralNewsModify,IntegralMarketSell,IntegralProductSell,IntegralProductSellOut,IntegralAdvertisement,IntegralContact,IntegralReNews,IntegralAttend,IntegralDistribution,IntegralDistributionIn,MoneyWithdraw,MoneySell,MoneyOutputDay,MoneyInputDay,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Statistics ");
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
			strSql.Append(" ID,Model,StatisticsDate,IntegralAll,IntegralAllCurrent,IntegralOutputDay,IntegralInputDay,IntegralInvitationTotal,IntegralNoInvitationTotal,IntegralShareTotal,IntegralShareProductTotal,IntegralNewsTotal,IntegralVideoTotal,IntegralMusicTotal,IntegralBestAnswer,IntegralTips,IntegralSell,IntegralNewsModify,IntegralMarketSell,IntegralProductSell,IntegralProductSellOut,IntegralAdvertisement,IntegralContact,IntegralReNews,IntegralAttend,IntegralDistribution,IntegralDistributionIn,MoneyWithdraw,MoneySell,MoneyOutputDay,MoneyInputDay,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_Statistics ");
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
			strSql.Append("select count(1) FROM SW_Statistics ");
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
                strSql = "select top " + endIndex + " * from SW_Statistics where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Statistics where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Statistics where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Statistics";
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

