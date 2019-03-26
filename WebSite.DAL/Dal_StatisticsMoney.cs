
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_StatisticsMoney
	/// </summary>
	public partial class Dal_StatisticsMoney
	{
		public Dal_StatisticsMoney()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_StatisticsMoney"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_StatisticsMoney");
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
		public int Add(WebSite.Model.Mod_StatisticsMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_StatisticsMoney(");
			strSql.Append("Model,StatisticsDate,MoneyAllCurrent,MoneyToDay,Tips,Point_incense,Merit_box,Light_candle,Release,XuYuan,HuanYuan,Help_India,Building_blocks,BaiTaiShui,FlagsHung,Support,TenSupport,TempleSupport,Charitable,Poverty_financing,Help,MarketIntegral,Contact,NewsRecommend,UserAttend,Exc_Rec,Exc_buy,Dbalance,RemoveRecommend,Exc_Wit,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,State,OrderBy,AddDate,WebSiteID)");
			strSql.Append(" values (");
			strSql.Append("@Model,@StatisticsDate,@MoneyAllCurrent,@MoneyToDay,@Tips,@Point_incense,@Merit_box,@Light_candle,@Release,@XuYuan,@HuanYuan,@Help_India,@Building_blocks,@BaiTaiShui,@FlagsHung,@Support,@TenSupport,@TempleSupport,@Charitable,@Poverty_financing,@Help,@MarketIntegral,@Contact,@NewsRecommend,@UserAttend,@Exc_Rec,@Exc_buy,@Dbalance,@RemoveRecommend,@Exc_Wit,@Other1,@Other2,@Other3,@Other4,@Other5,@Other6,@Other7,@Other8,@Other9,@Other10,@State,@OrderBy,@AddDate,@WebSiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@StatisticsDate", SqlDbType.VarChar,50),
					new SqlParameter("@MoneyAllCurrent", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyToDay", SqlDbType.Decimal,9),
					new SqlParameter("@Tips", SqlDbType.Decimal,9),
					new SqlParameter("@Point_incense", SqlDbType.Decimal,9),
					new SqlParameter("@Merit_box", SqlDbType.Decimal,9),
					new SqlParameter("@Light_candle", SqlDbType.Decimal,9),
					new SqlParameter("@Release", SqlDbType.Decimal,9),
					new SqlParameter("@XuYuan", SqlDbType.Decimal,9),
					new SqlParameter("@HuanYuan", SqlDbType.Decimal,9),
					new SqlParameter("@Help_India", SqlDbType.Decimal,9),
					new SqlParameter("@Building_blocks", SqlDbType.Decimal,9),
					new SqlParameter("@BaiTaiShui", SqlDbType.Decimal,9),
					new SqlParameter("@FlagsHung", SqlDbType.Decimal,9),
					new SqlParameter("@Support", SqlDbType.Decimal,9),
					new SqlParameter("@TenSupport", SqlDbType.Decimal,9),
					new SqlParameter("@TempleSupport", SqlDbType.Decimal,9),
					new SqlParameter("@Charitable", SqlDbType.Decimal,9),
					new SqlParameter("@Poverty_financing", SqlDbType.Decimal,9),
					new SqlParameter("@Help", SqlDbType.Decimal,9),
					new SqlParameter("@MarketIntegral", SqlDbType.Decimal,9),
					new SqlParameter("@Contact", SqlDbType.Decimal,9),
					new SqlParameter("@NewsRecommend", SqlDbType.Decimal,9),
					new SqlParameter("@UserAttend", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_Rec", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_buy", SqlDbType.Decimal,9),
					new SqlParameter("@Dbalance", SqlDbType.Decimal,9),
					new SqlParameter("@RemoveRecommend", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_Wit", SqlDbType.Decimal,9),
					new SqlParameter("@Other1", SqlDbType.Decimal,9),
					new SqlParameter("@Other2", SqlDbType.Decimal,9),
					new SqlParameter("@Other3", SqlDbType.Decimal,9),
					new SqlParameter("@Other4", SqlDbType.Decimal,9),
					new SqlParameter("@Other5", SqlDbType.Decimal,9),
					new SqlParameter("@Other6", SqlDbType.Decimal,9),
					new SqlParameter("@Other7", SqlDbType.Decimal,9),
					new SqlParameter("@Other8", SqlDbType.Decimal,9),
					new SqlParameter("@Other9", SqlDbType.Decimal,9),
					new SqlParameter("@Other10", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.StatisticsDate;
			parameters[2].Value = model.MoneyAllCurrent;
			parameters[3].Value = model.MoneyToDay;
			parameters[4].Value = model.Tips;
			parameters[5].Value = model.Point_incense;
			parameters[6].Value = model.Merit_box;
			parameters[7].Value = model.Light_candle;
			parameters[8].Value = model.Release;
			parameters[9].Value = model.XuYuan;
			parameters[10].Value = model.HuanYuan;
			parameters[11].Value = model.Help_India;
			parameters[12].Value = model.Building_blocks;
			parameters[13].Value = model.BaiTaiShui;
			parameters[14].Value = model.FlagsHung;
			parameters[15].Value = model.Support;
			parameters[16].Value = model.TenSupport;
			parameters[17].Value = model.TempleSupport;
			parameters[18].Value = model.Charitable;
			parameters[19].Value = model.Poverty_financing;
			parameters[20].Value = model.Help;
			parameters[21].Value = model.MarketIntegral;
			parameters[22].Value = model.Contact;
			parameters[23].Value = model.NewsRecommend;
			parameters[24].Value = model.UserAttend;
			parameters[25].Value = model.Exc_Rec;
			parameters[26].Value = model.Exc_buy;
			parameters[27].Value = model.Dbalance;
			parameters[28].Value = model.RemoveRecommend;
			parameters[29].Value = model.Exc_Wit;
			parameters[30].Value = model.Other1;
			parameters[31].Value = model.Other2;
			parameters[32].Value = model.Other3;
			parameters[33].Value = model.Other4;
			parameters[34].Value = model.Other5;
			parameters[35].Value = model.Other6;
			parameters[36].Value = model.Other7;
			parameters[37].Value = model.Other8;
			parameters[38].Value = model.Other9;
			parameters[39].Value = model.Other10;
			parameters[40].Value = model.State;
			parameters[41].Value = model.OrderBy;
			parameters[42].Value = model.AddDate;
			parameters[43].Value = model.WebSiteID;

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
		public bool Update(WebSite.Model.Mod_StatisticsMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_StatisticsMoney set ");
			strSql.Append("Model=@Model,");
			strSql.Append("StatisticsDate=@StatisticsDate,");
			strSql.Append("MoneyAllCurrent=@MoneyAllCurrent,");
			strSql.Append("MoneyToDay=@MoneyToDay,");
			strSql.Append("Tips=@Tips,");
			strSql.Append("Point_incense=@Point_incense,");
			strSql.Append("Merit_box=@Merit_box,");
			strSql.Append("Light_candle=@Light_candle,");
			strSql.Append("Release=@Release,");
			strSql.Append("XuYuan=@XuYuan,");
			strSql.Append("HuanYuan=@HuanYuan,");
			strSql.Append("Help_India=@Help_India,");
			strSql.Append("Building_blocks=@Building_blocks,");
			strSql.Append("BaiTaiShui=@BaiTaiShui,");
			strSql.Append("FlagsHung=@FlagsHung,");
			strSql.Append("Support=@Support,");
			strSql.Append("TenSupport=@TenSupport,");
			strSql.Append("TempleSupport=@TempleSupport,");
			strSql.Append("Charitable=@Charitable,");
			strSql.Append("Poverty_financing=@Poverty_financing,");
			strSql.Append("Help=@Help,");
			strSql.Append("MarketIntegral=@MarketIntegral,");
			strSql.Append("Contact=@Contact,");
			strSql.Append("NewsRecommend=@NewsRecommend,");
			strSql.Append("UserAttend=@UserAttend,");
			strSql.Append("Exc_Rec=@Exc_Rec,");
			strSql.Append("Exc_buy=@Exc_buy,");
			strSql.Append("Dbalance=@Dbalance,");
			strSql.Append("RemoveRecommend=@RemoveRecommend,");
			strSql.Append("Exc_Wit=@Exc_Wit,");
			strSql.Append("Other1=@Other1,");
			strSql.Append("Other2=@Other2,");
			strSql.Append("Other3=@Other3,");
			strSql.Append("Other4=@Other4,");
			strSql.Append("Other5=@Other5,");
			strSql.Append("Other6=@Other6,");
			strSql.Append("Other7=@Other7,");
			strSql.Append("Other8=@Other8,");
			strSql.Append("Other9=@Other9,");
			strSql.Append("Other10=@Other10,");
			strSql.Append("State=@State,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@StatisticsDate", SqlDbType.VarChar,50),
					new SqlParameter("@MoneyAllCurrent", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyToDay", SqlDbType.Decimal,9),
					new SqlParameter("@Tips", SqlDbType.Decimal,9),
					new SqlParameter("@Point_incense", SqlDbType.Decimal,9),
					new SqlParameter("@Merit_box", SqlDbType.Decimal,9),
					new SqlParameter("@Light_candle", SqlDbType.Decimal,9),
					new SqlParameter("@Release", SqlDbType.Decimal,9),
					new SqlParameter("@XuYuan", SqlDbType.Decimal,9),
					new SqlParameter("@HuanYuan", SqlDbType.Decimal,9),
					new SqlParameter("@Help_India", SqlDbType.Decimal,9),
					new SqlParameter("@Building_blocks", SqlDbType.Decimal,9),
					new SqlParameter("@BaiTaiShui", SqlDbType.Decimal,9),
					new SqlParameter("@FlagsHung", SqlDbType.Decimal,9),
					new SqlParameter("@Support", SqlDbType.Decimal,9),
					new SqlParameter("@TenSupport", SqlDbType.Decimal,9),
					new SqlParameter("@TempleSupport", SqlDbType.Decimal,9),
					new SqlParameter("@Charitable", SqlDbType.Decimal,9),
					new SqlParameter("@Poverty_financing", SqlDbType.Decimal,9),
					new SqlParameter("@Help", SqlDbType.Decimal,9),
					new SqlParameter("@MarketIntegral", SqlDbType.Decimal,9),
					new SqlParameter("@Contact", SqlDbType.Decimal,9),
					new SqlParameter("@NewsRecommend", SqlDbType.Decimal,9),
					new SqlParameter("@UserAttend", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_Rec", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_buy", SqlDbType.Decimal,9),
					new SqlParameter("@Dbalance", SqlDbType.Decimal,9),
					new SqlParameter("@RemoveRecommend", SqlDbType.Decimal,9),
					new SqlParameter("@Exc_Wit", SqlDbType.Decimal,9),
					new SqlParameter("@Other1", SqlDbType.Decimal,9),
					new SqlParameter("@Other2", SqlDbType.Decimal,9),
					new SqlParameter("@Other3", SqlDbType.Decimal,9),
					new SqlParameter("@Other4", SqlDbType.Decimal,9),
					new SqlParameter("@Other5", SqlDbType.Decimal,9),
					new SqlParameter("@Other6", SqlDbType.Decimal,9),
					new SqlParameter("@Other7", SqlDbType.Decimal,9),
					new SqlParameter("@Other8", SqlDbType.Decimal,9),
					new SqlParameter("@Other9", SqlDbType.Decimal,9),
					new SqlParameter("@Other10", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.StatisticsDate;
			parameters[2].Value = model.MoneyAllCurrent;
			parameters[3].Value = model.MoneyToDay;
			parameters[4].Value = model.Tips;
			parameters[5].Value = model.Point_incense;
			parameters[6].Value = model.Merit_box;
			parameters[7].Value = model.Light_candle;
			parameters[8].Value = model.Release;
			parameters[9].Value = model.XuYuan;
			parameters[10].Value = model.HuanYuan;
			parameters[11].Value = model.Help_India;
			parameters[12].Value = model.Building_blocks;
			parameters[13].Value = model.BaiTaiShui;
			parameters[14].Value = model.FlagsHung;
			parameters[15].Value = model.Support;
			parameters[16].Value = model.TenSupport;
			parameters[17].Value = model.TempleSupport;
			parameters[18].Value = model.Charitable;
			parameters[19].Value = model.Poverty_financing;
			parameters[20].Value = model.Help;
			parameters[21].Value = model.MarketIntegral;
			parameters[22].Value = model.Contact;
			parameters[23].Value = model.NewsRecommend;
			parameters[24].Value = model.UserAttend;
			parameters[25].Value = model.Exc_Rec;
			parameters[26].Value = model.Exc_buy;
			parameters[27].Value = model.Dbalance;
			parameters[28].Value = model.RemoveRecommend;
			parameters[29].Value = model.Exc_Wit;
			parameters[30].Value = model.Other1;
			parameters[31].Value = model.Other2;
			parameters[32].Value = model.Other3;
			parameters[33].Value = model.Other4;
			parameters[34].Value = model.Other5;
			parameters[35].Value = model.Other6;
			parameters[36].Value = model.Other7;
			parameters[37].Value = model.Other8;
			parameters[38].Value = model.Other9;
			parameters[39].Value = model.Other10;
			parameters[40].Value = model.State;
			parameters[41].Value = model.OrderBy;
			parameters[42].Value = model.AddDate;
			parameters[43].Value = model.WebSiteID;
			parameters[44].Value = model.ID;

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
			strSql.Append("delete from SW_StatisticsMoney ");
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
			strSql.Append("delete from SW_StatisticsMoney ");
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
		public WebSite.Model.Mod_StatisticsMoney GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,StatisticsDate,MoneyAllCurrent,MoneyToDay,Tips,Point_incense,Merit_box,Light_candle,Release,XuYuan,HuanYuan,Help_India,Building_blocks,BaiTaiShui,FlagsHung,Support,TenSupport,TempleSupport,Charitable,Poverty_financing,Help,MarketIntegral,Contact,NewsRecommend,UserAttend,Exc_Rec,Exc_buy,Dbalance,RemoveRecommend,Exc_Wit,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,State,OrderBy,AddDate,WebSiteID from SW_StatisticsMoney ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_StatisticsMoney model=new WebSite.Model.Mod_StatisticsMoney();
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
		public WebSite.Model.Mod_StatisticsMoney DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_StatisticsMoney model=new WebSite.Model.Mod_StatisticsMoney();
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
				if(row["MoneyAllCurrent"]!=null && row["MoneyAllCurrent"].ToString()!="")
				{
					model.MoneyAllCurrent=decimal.Parse(row["MoneyAllCurrent"].ToString());
				}
				if(row["MoneyToDay"]!=null && row["MoneyToDay"].ToString()!="")
				{
					model.MoneyToDay=decimal.Parse(row["MoneyToDay"].ToString());
				}
				if(row["Tips"]!=null && row["Tips"].ToString()!="")
				{
					model.Tips=decimal.Parse(row["Tips"].ToString());
				}
				if(row["Point_incense"]!=null && row["Point_incense"].ToString()!="")
				{
					model.Point_incense=decimal.Parse(row["Point_incense"].ToString());
				}
				if(row["Merit_box"]!=null && row["Merit_box"].ToString()!="")
				{
					model.Merit_box=decimal.Parse(row["Merit_box"].ToString());
				}
				if(row["Light_candle"]!=null && row["Light_candle"].ToString()!="")
				{
					model.Light_candle=decimal.Parse(row["Light_candle"].ToString());
				}
				if(row["Release"]!=null && row["Release"].ToString()!="")
				{
					model.Release=decimal.Parse(row["Release"].ToString());
				}
				if(row["XuYuan"]!=null && row["XuYuan"].ToString()!="")
				{
					model.XuYuan=decimal.Parse(row["XuYuan"].ToString());
				}
				if(row["HuanYuan"]!=null && row["HuanYuan"].ToString()!="")
				{
					model.HuanYuan=decimal.Parse(row["HuanYuan"].ToString());
				}
				if(row["Help_India"]!=null && row["Help_India"].ToString()!="")
				{
					model.Help_India=decimal.Parse(row["Help_India"].ToString());
				}
				if(row["Building_blocks"]!=null && row["Building_blocks"].ToString()!="")
				{
					model.Building_blocks=decimal.Parse(row["Building_blocks"].ToString());
				}
				if(row["BaiTaiShui"]!=null && row["BaiTaiShui"].ToString()!="")
				{
					model.BaiTaiShui=decimal.Parse(row["BaiTaiShui"].ToString());
				}
				if(row["FlagsHung"]!=null && row["FlagsHung"].ToString()!="")
				{
					model.FlagsHung=decimal.Parse(row["FlagsHung"].ToString());
				}
				if(row["Support"]!=null && row["Support"].ToString()!="")
				{
					model.Support=decimal.Parse(row["Support"].ToString());
				}
				if(row["TenSupport"]!=null && row["TenSupport"].ToString()!="")
				{
					model.TenSupport=decimal.Parse(row["TenSupport"].ToString());
				}
				if(row["TempleSupport"]!=null && row["TempleSupport"].ToString()!="")
				{
					model.TempleSupport=decimal.Parse(row["TempleSupport"].ToString());
				}
				if(row["Charitable"]!=null && row["Charitable"].ToString()!="")
				{
					model.Charitable=decimal.Parse(row["Charitable"].ToString());
				}
				if(row["Poverty_financing"]!=null && row["Poverty_financing"].ToString()!="")
				{
					model.Poverty_financing=decimal.Parse(row["Poverty_financing"].ToString());
				}
				if(row["Help"]!=null && row["Help"].ToString()!="")
				{
					model.Help=decimal.Parse(row["Help"].ToString());
				}
				if(row["MarketIntegral"]!=null && row["MarketIntegral"].ToString()!="")
				{
					model.MarketIntegral=decimal.Parse(row["MarketIntegral"].ToString());
				}
				if(row["Contact"]!=null && row["Contact"].ToString()!="")
				{
					model.Contact=decimal.Parse(row["Contact"].ToString());
				}
				if(row["NewsRecommend"]!=null && row["NewsRecommend"].ToString()!="")
				{
					model.NewsRecommend=decimal.Parse(row["NewsRecommend"].ToString());
				}
				if(row["UserAttend"]!=null && row["UserAttend"].ToString()!="")
				{
					model.UserAttend=decimal.Parse(row["UserAttend"].ToString());
				}
				if(row["Exc_Rec"]!=null && row["Exc_Rec"].ToString()!="")
				{
					model.Exc_Rec=decimal.Parse(row["Exc_Rec"].ToString());
				}
				if(row["Exc_buy"]!=null && row["Exc_buy"].ToString()!="")
				{
					model.Exc_buy=decimal.Parse(row["Exc_buy"].ToString());
				}
				if(row["Dbalance"]!=null && row["Dbalance"].ToString()!="")
				{
					model.Dbalance=decimal.Parse(row["Dbalance"].ToString());
				}
				if(row["RemoveRecommend"]!=null && row["RemoveRecommend"].ToString()!="")
				{
					model.RemoveRecommend=decimal.Parse(row["RemoveRecommend"].ToString());
				}
				if(row["Exc_Wit"]!=null && row["Exc_Wit"].ToString()!="")
				{
					model.Exc_Wit=decimal.Parse(row["Exc_Wit"].ToString());
				}
				if(row["Other1"]!=null && row["Other1"].ToString()!="")
				{
					model.Other1=decimal.Parse(row["Other1"].ToString());
				}
				if(row["Other2"]!=null && row["Other2"].ToString()!="")
				{
					model.Other2=decimal.Parse(row["Other2"].ToString());
				}
				if(row["Other3"]!=null && row["Other3"].ToString()!="")
				{
					model.Other3=decimal.Parse(row["Other3"].ToString());
				}
				if(row["Other4"]!=null && row["Other4"].ToString()!="")
				{
					model.Other4=decimal.Parse(row["Other4"].ToString());
				}
				if(row["Other5"]!=null && row["Other5"].ToString()!="")
				{
					model.Other5=decimal.Parse(row["Other5"].ToString());
				}
				if(row["Other6"]!=null && row["Other6"].ToString()!="")
				{
					model.Other6=decimal.Parse(row["Other6"].ToString());
				}
				if(row["Other7"]!=null && row["Other7"].ToString()!="")
				{
					model.Other7=decimal.Parse(row["Other7"].ToString());
				}
				if(row["Other8"]!=null && row["Other8"].ToString()!="")
				{
					model.Other8=decimal.Parse(row["Other8"].ToString());
				}
				if(row["Other9"]!=null && row["Other9"].ToString()!="")
				{
					model.Other9=decimal.Parse(row["Other9"].ToString());
				}
				if(row["Other10"]!=null && row["Other10"].ToString()!="")
				{
					model.Other10=decimal.Parse(row["Other10"].ToString());
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
			strSql.Append("select ID,Model,StatisticsDate,MoneyAllCurrent,MoneyToDay,Tips,Point_incense,Merit_box,Light_candle,Release,XuYuan,HuanYuan,Help_India,Building_blocks,BaiTaiShui,FlagsHung,Support,TenSupport,TempleSupport,Charitable,Poverty_financing,Help,MarketIntegral,Contact,NewsRecommend,UserAttend,Exc_Rec,Exc_buy,Dbalance,RemoveRecommend,Exc_Wit,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_StatisticsMoney ");
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
			strSql.Append(" ID,Model,StatisticsDate,MoneyAllCurrent,MoneyToDay,Tips,Point_incense,Merit_box,Light_candle,Release,XuYuan,HuanYuan,Help_India,Building_blocks,BaiTaiShui,FlagsHung,Support,TenSupport,TempleSupport,Charitable,Poverty_financing,Help,MarketIntegral,Contact,NewsRecommend,UserAttend,Exc_Rec,Exc_buy,Dbalance,RemoveRecommend,Exc_Wit,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,State,OrderBy,AddDate,WebSiteID ");
			strSql.Append(" FROM SW_StatisticsMoney ");
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
			strSql.Append("select count(1) FROM SW_StatisticsMoney ");
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
                strSql = "select top " + endIndex + " * from SW_StatisticsMoney where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_StatisticsMoney where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_StatisticsMoney where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_StatisticsMoney";
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

