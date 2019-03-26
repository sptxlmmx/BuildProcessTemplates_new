
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Admin_WebSite
	/// </summary>
	public partial class Dal_Admin_WebSite
	{
		public Dal_Admin_WebSite()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Admin_WebSite"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Admin_WebSite");
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
		public int Add(WebSite.Model.Mod_Admin_WebSite model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Admin_WebSite(");
			strSql.Append("ParentID,IDPath,WebState,CloseInfo,WebName,WebUrl,HomePage,Title,Keywords,Description,EmailSmtp,EmailName,EmailPwd,ReceiveEmail,Mobile,Telephone,Address,Copyright,OrderBy,State,IsIntegral,IsAdvertisement,IntegralConversion,IntegralAll,MoneyAll,IntegralSeeking,IntegralShare,IntegralRecommend,IntegralRegister,IntegralReNews,IntegralRemoveReNews,IntegralAttend,IntegralContact,IntegrallimitSell,IntegrallimitMoney,IntegralReRatio,PayRecRatio,MarketReRatio,NewsActionReRatio,ContactReRatio,UserAttendRecRatio,NewsRecRatio,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9,TechnicaServiceFee,SecurityFee,WithdrawRed,DownloadAppRed,DownloadAppRedCount,IsOpenRed,IsOpenRecommendAPPRed,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherDecimal1,OtherDecimal2,OtherDecimal3,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5)");
			strSql.Append(" values (");
			strSql.Append("@ParentID,@IDPath,@WebState,@CloseInfo,@WebName,@WebUrl,@HomePage,@Title,@Keywords,@Description,@EmailSmtp,@EmailName,@EmailPwd,@ReceiveEmail,@Mobile,@Telephone,@Address,@Copyright,@OrderBy,@State,@IsIntegral,@IsAdvertisement,@IntegralConversion,@IntegralAll,@MoneyAll,@IntegralSeeking,@IntegralShare,@IntegralRecommend,@IntegralRegister,@IntegralReNews,@IntegralRemoveReNews,@IntegralAttend,@IntegralContact,@IntegrallimitSell,@IntegrallimitMoney,@IntegralReRatio,@PayRecRatio,@MarketReRatio,@NewsActionReRatio,@ContactReRatio,@UserAttendRecRatio,@NewsRecRatio,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6,@Attr7,@Attr8,@Attr9,@TechnicaServiceFee,@SecurityFee,@WithdrawRed,@DownloadAppRed,@DownloadAppRedCount,@IsOpenRed,@IsOpenRecommendAPPRed,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherInt5,@OtherDecimal1,@OtherDecimal2,@OtherDecimal3,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@OtherString5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@WebState", SqlDbType.Int,4),
					new SqlParameter("@CloseInfo", SqlDbType.Text),
					new SqlParameter("@WebName", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@HomePage", SqlDbType.VarChar,100),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@Keywords", SqlDbType.Text),
					new SqlParameter("@Description", SqlDbType.Text),
					new SqlParameter("@EmailSmtp", SqlDbType.VarChar,100),
					new SqlParameter("@EmailName", SqlDbType.VarChar,100),
					new SqlParameter("@EmailPwd", SqlDbType.VarChar,100),
					new SqlParameter("@ReceiveEmail", SqlDbType.VarChar,100),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Copyright", SqlDbType.Text),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsIntegral", SqlDbType.Int,4),
					new SqlParameter("@IsAdvertisement", SqlDbType.Int,4),
					new SqlParameter("@IntegralConversion", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralAll", SqlDbType.Int,4),
					new SqlParameter("@MoneyAll", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralSeeking", SqlDbType.Int,4),
					new SqlParameter("@IntegralShare", SqlDbType.Int,4),
					new SqlParameter("@IntegralRecommend", SqlDbType.Int,4),
					new SqlParameter("@IntegralRegister", SqlDbType.Int,4),
					new SqlParameter("@IntegralReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralRemoveReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralAttend", SqlDbType.Int,4),
					new SqlParameter("@IntegralContact", SqlDbType.Int,4),
					new SqlParameter("@IntegrallimitSell", SqlDbType.Int,4),
					new SqlParameter("@IntegrallimitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@PayRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@MarketReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@NewsActionReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@ContactReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@UserAttendRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@NewsRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@Attr1", SqlDbType.VarChar,500),
					new SqlParameter("@Attr2", SqlDbType.VarChar,500),
					new SqlParameter("@Attr3", SqlDbType.VarChar,200),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.Int,4),
					new SqlParameter("@Attr6", SqlDbType.Int,4),
					new SqlParameter("@Attr7", SqlDbType.Decimal,9),
					new SqlParameter("@Attr8", SqlDbType.Decimal,9),
					new SqlParameter("@Attr9", SqlDbType.Text),
					new SqlParameter("@TechnicaServiceFee", SqlDbType.Decimal,9),
					new SqlParameter("@SecurityFee", SqlDbType.Decimal,9),
					new SqlParameter("@WithdrawRed", SqlDbType.Decimal,9),
					new SqlParameter("@DownloadAppRed", SqlDbType.Decimal,9),
					new SqlParameter("@DownloadAppRedCount", SqlDbType.Int,4),
					new SqlParameter("@IsOpenRed", SqlDbType.Int,4),
					new SqlParameter("@IsOpenRecommendAPPRed", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherDecimal1", SqlDbType.Decimal,9),
					new SqlParameter("@OtherDecimal2", SqlDbType.Decimal,9),
					new SqlParameter("@OtherDecimal3", SqlDbType.Decimal,9),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString5", SqlDbType.Text)};
			parameters[0].Value = model.ParentID;
			parameters[1].Value = model.IDPath;
			parameters[2].Value = model.WebState;
			parameters[3].Value = model.CloseInfo;
			parameters[4].Value = model.WebName;
			parameters[5].Value = model.WebUrl;
			parameters[6].Value = model.HomePage;
			parameters[7].Value = model.Title;
			parameters[8].Value = model.Keywords;
			parameters[9].Value = model.Description;
			parameters[10].Value = model.EmailSmtp;
			parameters[11].Value = model.EmailName;
			parameters[12].Value = model.EmailPwd;
			parameters[13].Value = model.ReceiveEmail;
			parameters[14].Value = model.Mobile;
			parameters[15].Value = model.Telephone;
			parameters[16].Value = model.Address;
			parameters[17].Value = model.Copyright;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.State;
			parameters[20].Value = model.IsIntegral;
			parameters[21].Value = model.IsAdvertisement;
			parameters[22].Value = model.IntegralConversion;
			parameters[23].Value = model.IntegralAll;
			parameters[24].Value = model.MoneyAll;
			parameters[25].Value = model.IntegralSeeking;
			parameters[26].Value = model.IntegralShare;
			parameters[27].Value = model.IntegralRecommend;
			parameters[28].Value = model.IntegralRegister;
			parameters[29].Value = model.IntegralReNews;
			parameters[30].Value = model.IntegralRemoveReNews;
			parameters[31].Value = model.IntegralAttend;
			parameters[32].Value = model.IntegralContact;
			parameters[33].Value = model.IntegrallimitSell;
			parameters[34].Value = model.IntegrallimitMoney;
			parameters[35].Value = model.IntegralReRatio;
			parameters[36].Value = model.PayRecRatio;
			parameters[37].Value = model.MarketReRatio;
			parameters[38].Value = model.NewsActionReRatio;
			parameters[39].Value = model.ContactReRatio;
			parameters[40].Value = model.UserAttendRecRatio;
			parameters[41].Value = model.NewsRecRatio;
			parameters[42].Value = model.Attr1;
			parameters[43].Value = model.Attr2;
			parameters[44].Value = model.Attr3;
			parameters[45].Value = model.Attr4;
			parameters[46].Value = model.Attr5;
			parameters[47].Value = model.Attr6;
			parameters[48].Value = model.Attr7;
			parameters[49].Value = model.Attr8;
			parameters[50].Value = model.Attr9;
			parameters[51].Value = model.TechnicaServiceFee;
			parameters[52].Value = model.SecurityFee;
			parameters[53].Value = model.WithdrawRed;
			parameters[54].Value = model.DownloadAppRed;
			parameters[55].Value = model.DownloadAppRedCount;
			parameters[56].Value = model.IsOpenRed;
			parameters[57].Value = model.IsOpenRecommendAPPRed;
			parameters[58].Value = model.OtherInt1;
			parameters[59].Value = model.OtherInt2;
			parameters[60].Value = model.OtherInt3;
			parameters[61].Value = model.OtherInt4;
			parameters[62].Value = model.OtherInt5;
			parameters[63].Value = model.OtherDecimal1;
			parameters[64].Value = model.OtherDecimal2;
			parameters[65].Value = model.OtherDecimal3;
			parameters[66].Value = model.OtherString1;
			parameters[67].Value = model.OtherString2;
			parameters[68].Value = model.OtherString3;
			parameters[69].Value = model.OtherString4;
			parameters[70].Value = model.OtherString5;

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
		public bool Update(WebSite.Model.Mod_Admin_WebSite model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Admin_WebSite set ");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("IDPath=@IDPath,");
			strSql.Append("WebState=@WebState,");
			strSql.Append("CloseInfo=@CloseInfo,");
			strSql.Append("WebName=@WebName,");
			strSql.Append("WebUrl=@WebUrl,");
			strSql.Append("HomePage=@HomePage,");
			strSql.Append("Title=@Title,");
			strSql.Append("Keywords=@Keywords,");
			strSql.Append("Description=@Description,");
			strSql.Append("EmailSmtp=@EmailSmtp,");
			strSql.Append("EmailName=@EmailName,");
			strSql.Append("EmailPwd=@EmailPwd,");
			strSql.Append("ReceiveEmail=@ReceiveEmail,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Telephone=@Telephone,");
			strSql.Append("Address=@Address,");
			strSql.Append("Copyright=@Copyright,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("State=@State,");
			strSql.Append("IsIntegral=@IsIntegral,");
			strSql.Append("IsAdvertisement=@IsAdvertisement,");
			strSql.Append("IntegralConversion=@IntegralConversion,");
			strSql.Append("IntegralAll=@IntegralAll,");
			strSql.Append("MoneyAll=@MoneyAll,");
			strSql.Append("IntegralSeeking=@IntegralSeeking,");
			strSql.Append("IntegralShare=@IntegralShare,");
			strSql.Append("IntegralRecommend=@IntegralRecommend,");
			strSql.Append("IntegralRegister=@IntegralRegister,");
			strSql.Append("IntegralReNews=@IntegralReNews,");
			strSql.Append("IntegralRemoveReNews=@IntegralRemoveReNews,");
			strSql.Append("IntegralAttend=@IntegralAttend,");
			strSql.Append("IntegralContact=@IntegralContact,");
			strSql.Append("IntegrallimitSell=@IntegrallimitSell,");
			strSql.Append("IntegrallimitMoney=@IntegrallimitMoney,");
			strSql.Append("IntegralReRatio=@IntegralReRatio,");
			strSql.Append("PayRecRatio=@PayRecRatio,");
			strSql.Append("MarketReRatio=@MarketReRatio,");
			strSql.Append("NewsActionReRatio=@NewsActionReRatio,");
			strSql.Append("ContactReRatio=@ContactReRatio,");
			strSql.Append("UserAttendRecRatio=@UserAttendRecRatio,");
			strSql.Append("NewsRecRatio=@NewsRecRatio,");
			strSql.Append("Attr1=@Attr1,");
			strSql.Append("Attr2=@Attr2,");
			strSql.Append("Attr3=@Attr3,");
			strSql.Append("Attr4=@Attr4,");
			strSql.Append("Attr5=@Attr5,");
			strSql.Append("Attr6=@Attr6,");
			strSql.Append("Attr7=@Attr7,");
			strSql.Append("Attr8=@Attr8,");
			strSql.Append("Attr9=@Attr9,");
			strSql.Append("TechnicaServiceFee=@TechnicaServiceFee,");
			strSql.Append("SecurityFee=@SecurityFee,");
			strSql.Append("WithdrawRed=@WithdrawRed,");
			strSql.Append("DownloadAppRed=@DownloadAppRed,");
			strSql.Append("DownloadAppRedCount=@DownloadAppRedCount,");
			strSql.Append("IsOpenRed=@IsOpenRed,");
			strSql.Append("IsOpenRecommendAPPRed=@IsOpenRecommendAPPRed,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherInt3=@OtherInt3,");
			strSql.Append("OtherInt4=@OtherInt4,");
			strSql.Append("OtherInt5=@OtherInt5,");
			strSql.Append("OtherDecimal1=@OtherDecimal1,");
			strSql.Append("OtherDecimal2=@OtherDecimal2,");
			strSql.Append("OtherDecimal3=@OtherDecimal3,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("OtherString3=@OtherString3,");
			strSql.Append("OtherString4=@OtherString4,");
			strSql.Append("OtherString5=@OtherString5");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.VarChar,200),
					new SqlParameter("@WebState", SqlDbType.Int,4),
					new SqlParameter("@CloseInfo", SqlDbType.Text),
					new SqlParameter("@WebName", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,500),
					new SqlParameter("@HomePage", SqlDbType.VarChar,100),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@Keywords", SqlDbType.Text),
					new SqlParameter("@Description", SqlDbType.Text),
					new SqlParameter("@EmailSmtp", SqlDbType.VarChar,100),
					new SqlParameter("@EmailName", SqlDbType.VarChar,100),
					new SqlParameter("@EmailPwd", SqlDbType.VarChar,100),
					new SqlParameter("@ReceiveEmail", SqlDbType.VarChar,100),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Copyright", SqlDbType.Text),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsIntegral", SqlDbType.Int,4),
					new SqlParameter("@IsAdvertisement", SqlDbType.Int,4),
					new SqlParameter("@IntegralConversion", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralAll", SqlDbType.Int,4),
					new SqlParameter("@MoneyAll", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralSeeking", SqlDbType.Int,4),
					new SqlParameter("@IntegralShare", SqlDbType.Int,4),
					new SqlParameter("@IntegralRecommend", SqlDbType.Int,4),
					new SqlParameter("@IntegralRegister", SqlDbType.Int,4),
					new SqlParameter("@IntegralReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralRemoveReNews", SqlDbType.Int,4),
					new SqlParameter("@IntegralAttend", SqlDbType.Int,4),
					new SqlParameter("@IntegralContact", SqlDbType.Int,4),
					new SqlParameter("@IntegrallimitSell", SqlDbType.Int,4),
					new SqlParameter("@IntegrallimitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@IntegralReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@PayRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@MarketReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@NewsActionReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@ContactReRatio", SqlDbType.Decimal,9),
					new SqlParameter("@UserAttendRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@NewsRecRatio", SqlDbType.Decimal,9),
					new SqlParameter("@Attr1", SqlDbType.VarChar,500),
					new SqlParameter("@Attr2", SqlDbType.VarChar,500),
					new SqlParameter("@Attr3", SqlDbType.VarChar,200),
					new SqlParameter("@Attr4", SqlDbType.VarChar,200),
					new SqlParameter("@Attr5", SqlDbType.Int,4),
					new SqlParameter("@Attr6", SqlDbType.Int,4),
					new SqlParameter("@Attr7", SqlDbType.Decimal,9),
					new SqlParameter("@Attr8", SqlDbType.Decimal,9),
					new SqlParameter("@Attr9", SqlDbType.Text),
					new SqlParameter("@TechnicaServiceFee", SqlDbType.Decimal,9),
					new SqlParameter("@SecurityFee", SqlDbType.Decimal,9),
					new SqlParameter("@WithdrawRed", SqlDbType.Decimal,9),
					new SqlParameter("@DownloadAppRed", SqlDbType.Decimal,9),
					new SqlParameter("@DownloadAppRedCount", SqlDbType.Int,4),
					new SqlParameter("@IsOpenRed", SqlDbType.Int,4),
					new SqlParameter("@IsOpenRecommendAPPRed", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherDecimal1", SqlDbType.Decimal,9),
					new SqlParameter("@OtherDecimal2", SqlDbType.Decimal,9),
					new SqlParameter("@OtherDecimal3", SqlDbType.Decimal,9),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString5", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ParentID;
			parameters[1].Value = model.IDPath;
			parameters[2].Value = model.WebState;
			parameters[3].Value = model.CloseInfo;
			parameters[4].Value = model.WebName;
			parameters[5].Value = model.WebUrl;
			parameters[6].Value = model.HomePage;
			parameters[7].Value = model.Title;
			parameters[8].Value = model.Keywords;
			parameters[9].Value = model.Description;
			parameters[10].Value = model.EmailSmtp;
			parameters[11].Value = model.EmailName;
			parameters[12].Value = model.EmailPwd;
			parameters[13].Value = model.ReceiveEmail;
			parameters[14].Value = model.Mobile;
			parameters[15].Value = model.Telephone;
			parameters[16].Value = model.Address;
			parameters[17].Value = model.Copyright;
			parameters[18].Value = model.OrderBy;
			parameters[19].Value = model.State;
			parameters[20].Value = model.IsIntegral;
			parameters[21].Value = model.IsAdvertisement;
			parameters[22].Value = model.IntegralConversion;
			parameters[23].Value = model.IntegralAll;
			parameters[24].Value = model.MoneyAll;
			parameters[25].Value = model.IntegralSeeking;
			parameters[26].Value = model.IntegralShare;
			parameters[27].Value = model.IntegralRecommend;
			parameters[28].Value = model.IntegralRegister;
			parameters[29].Value = model.IntegralReNews;
			parameters[30].Value = model.IntegralRemoveReNews;
			parameters[31].Value = model.IntegralAttend;
			parameters[32].Value = model.IntegralContact;
			parameters[33].Value = model.IntegrallimitSell;
			parameters[34].Value = model.IntegrallimitMoney;
			parameters[35].Value = model.IntegralReRatio;
			parameters[36].Value = model.PayRecRatio;
			parameters[37].Value = model.MarketReRatio;
			parameters[38].Value = model.NewsActionReRatio;
			parameters[39].Value = model.ContactReRatio;
			parameters[40].Value = model.UserAttendRecRatio;
			parameters[41].Value = model.NewsRecRatio;
			parameters[42].Value = model.Attr1;
			parameters[43].Value = model.Attr2;
			parameters[44].Value = model.Attr3;
			parameters[45].Value = model.Attr4;
			parameters[46].Value = model.Attr5;
			parameters[47].Value = model.Attr6;
			parameters[48].Value = model.Attr7;
			parameters[49].Value = model.Attr8;
			parameters[50].Value = model.Attr9;
			parameters[51].Value = model.TechnicaServiceFee;
			parameters[52].Value = model.SecurityFee;
			parameters[53].Value = model.WithdrawRed;
			parameters[54].Value = model.DownloadAppRed;
			parameters[55].Value = model.DownloadAppRedCount;
			parameters[56].Value = model.IsOpenRed;
			parameters[57].Value = model.IsOpenRecommendAPPRed;
			parameters[58].Value = model.OtherInt1;
			parameters[59].Value = model.OtherInt2;
			parameters[60].Value = model.OtherInt3;
			parameters[61].Value = model.OtherInt4;
			parameters[62].Value = model.OtherInt5;
			parameters[63].Value = model.OtherDecimal1;
			parameters[64].Value = model.OtherDecimal2;
			parameters[65].Value = model.OtherDecimal3;
			parameters[66].Value = model.OtherString1;
			parameters[67].Value = model.OtherString2;
			parameters[68].Value = model.OtherString3;
			parameters[69].Value = model.OtherString4;
			parameters[70].Value = model.OtherString5;
			parameters[71].Value = model.ID;

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
			strSql.Append("delete from SW_Admin_WebSite ");
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
			strSql.Append("delete from SW_Admin_WebSite ");
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
		public WebSite.Model.Mod_Admin_WebSite GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ParentID,IDPath,WebState,CloseInfo,WebName,WebUrl,HomePage,Title,Keywords,Description,EmailSmtp,EmailName,EmailPwd,ReceiveEmail,Mobile,Telephone,Address,Copyright,OrderBy,State,IsIntegral,IsAdvertisement,IntegralConversion,IntegralAll,MoneyAll,IntegralSeeking,IntegralShare,IntegralRecommend,IntegralRegister,IntegralReNews,IntegralRemoveReNews,IntegralAttend,IntegralContact,IntegrallimitSell,IntegrallimitMoney,IntegralReRatio,PayRecRatio,MarketReRatio,NewsActionReRatio,ContactReRatio,UserAttendRecRatio,NewsRecRatio,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9,TechnicaServiceFee,SecurityFee,WithdrawRed,DownloadAppRed,DownloadAppRedCount,IsOpenRed,IsOpenRecommendAPPRed,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherDecimal1,OtherDecimal2,OtherDecimal3,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5 from SW_Admin_WebSite ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Admin_WebSite model=new WebSite.Model.Mod_Admin_WebSite();
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
		public WebSite.Model.Mod_Admin_WebSite DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Admin_WebSite model=new WebSite.Model.Mod_Admin_WebSite();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["IDPath"]!=null)
				{
					model.IDPath=row["IDPath"].ToString();
				}
				if(row["WebState"]!=null && row["WebState"].ToString()!="")
				{
					model.WebState=int.Parse(row["WebState"].ToString());
				}
				if(row["CloseInfo"]!=null)
				{
					model.CloseInfo=row["CloseInfo"].ToString();
				}
				if(row["WebName"]!=null)
				{
					model.WebName=row["WebName"].ToString();
				}
				if(row["WebUrl"]!=null)
				{
					model.WebUrl=row["WebUrl"].ToString();
				}
				if(row["HomePage"]!=null)
				{
					model.HomePage=row["HomePage"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Keywords"]!=null)
				{
					model.Keywords=row["Keywords"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["EmailSmtp"]!=null)
				{
					model.EmailSmtp=row["EmailSmtp"].ToString();
				}
				if(row["EmailName"]!=null)
				{
					model.EmailName=row["EmailName"].ToString();
				}
				if(row["EmailPwd"]!=null)
				{
					model.EmailPwd=row["EmailPwd"].ToString();
				}
				if(row["ReceiveEmail"]!=null)
				{
					model.ReceiveEmail=row["ReceiveEmail"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Copyright"]!=null)
				{
					model.Copyright=row["Copyright"].ToString();
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsIntegral"]!=null && row["IsIntegral"].ToString()!="")
				{
					model.IsIntegral=int.Parse(row["IsIntegral"].ToString());
				}
				if(row["IsAdvertisement"]!=null && row["IsAdvertisement"].ToString()!="")
				{
					model.IsAdvertisement=int.Parse(row["IsAdvertisement"].ToString());
				}
				if(row["IntegralConversion"]!=null && row["IntegralConversion"].ToString()!="")
				{
					model.IntegralConversion=decimal.Parse(row["IntegralConversion"].ToString());
				}
				if(row["IntegralAll"]!=null && row["IntegralAll"].ToString()!="")
				{
					model.IntegralAll=int.Parse(row["IntegralAll"].ToString());
				}
				if(row["MoneyAll"]!=null && row["MoneyAll"].ToString()!="")
				{
					model.MoneyAll=decimal.Parse(row["MoneyAll"].ToString());
				}
				if(row["IntegralSeeking"]!=null && row["IntegralSeeking"].ToString()!="")
				{
					model.IntegralSeeking=int.Parse(row["IntegralSeeking"].ToString());
				}
				if(row["IntegralShare"]!=null && row["IntegralShare"].ToString()!="")
				{
					model.IntegralShare=int.Parse(row["IntegralShare"].ToString());
				}
				if(row["IntegralRecommend"]!=null && row["IntegralRecommend"].ToString()!="")
				{
					model.IntegralRecommend=int.Parse(row["IntegralRecommend"].ToString());
				}
				if(row["IntegralRegister"]!=null && row["IntegralRegister"].ToString()!="")
				{
					model.IntegralRegister=int.Parse(row["IntegralRegister"].ToString());
				}
				if(row["IntegralReNews"]!=null && row["IntegralReNews"].ToString()!="")
				{
					model.IntegralReNews=int.Parse(row["IntegralReNews"].ToString());
				}
				if(row["IntegralRemoveReNews"]!=null && row["IntegralRemoveReNews"].ToString()!="")
				{
					model.IntegralRemoveReNews=int.Parse(row["IntegralRemoveReNews"].ToString());
				}
				if(row["IntegralAttend"]!=null && row["IntegralAttend"].ToString()!="")
				{
					model.IntegralAttend=int.Parse(row["IntegralAttend"].ToString());
				}
				if(row["IntegralContact"]!=null && row["IntegralContact"].ToString()!="")
				{
					model.IntegralContact=int.Parse(row["IntegralContact"].ToString());
				}
				if(row["IntegrallimitSell"]!=null && row["IntegrallimitSell"].ToString()!="")
				{
					model.IntegrallimitSell=int.Parse(row["IntegrallimitSell"].ToString());
				}
				if(row["IntegrallimitMoney"]!=null && row["IntegrallimitMoney"].ToString()!="")
				{
					model.IntegrallimitMoney=decimal.Parse(row["IntegrallimitMoney"].ToString());
				}
				if(row["IntegralReRatio"]!=null && row["IntegralReRatio"].ToString()!="")
				{
					model.IntegralReRatio=decimal.Parse(row["IntegralReRatio"].ToString());
				}
				if(row["PayRecRatio"]!=null && row["PayRecRatio"].ToString()!="")
				{
					model.PayRecRatio=decimal.Parse(row["PayRecRatio"].ToString());
				}
				if(row["MarketReRatio"]!=null && row["MarketReRatio"].ToString()!="")
				{
					model.MarketReRatio=decimal.Parse(row["MarketReRatio"].ToString());
				}
				if(row["NewsActionReRatio"]!=null && row["NewsActionReRatio"].ToString()!="")
				{
					model.NewsActionReRatio=decimal.Parse(row["NewsActionReRatio"].ToString());
				}
				if(row["ContactReRatio"]!=null && row["ContactReRatio"].ToString()!="")
				{
					model.ContactReRatio=decimal.Parse(row["ContactReRatio"].ToString());
				}
				if(row["UserAttendRecRatio"]!=null && row["UserAttendRecRatio"].ToString()!="")
				{
					model.UserAttendRecRatio=decimal.Parse(row["UserAttendRecRatio"].ToString());
				}
				if(row["NewsRecRatio"]!=null && row["NewsRecRatio"].ToString()!="")
				{
					model.NewsRecRatio=decimal.Parse(row["NewsRecRatio"].ToString());
				}
				if(row["Attr1"]!=null)
				{
					model.Attr1=row["Attr1"].ToString();
				}
				if(row["Attr2"]!=null)
				{
					model.Attr2=row["Attr2"].ToString();
				}
				if(row["Attr3"]!=null)
				{
					model.Attr3=row["Attr3"].ToString();
				}
				if(row["Attr4"]!=null)
				{
					model.Attr4=row["Attr4"].ToString();
				}
				if(row["Attr5"]!=null && row["Attr5"].ToString()!="")
				{
					model.Attr5=int.Parse(row["Attr5"].ToString());
				}
				if(row["Attr6"]!=null && row["Attr6"].ToString()!="")
				{
					model.Attr6=int.Parse(row["Attr6"].ToString());
				}
				if(row["Attr7"]!=null && row["Attr7"].ToString()!="")
				{
					model.Attr7=decimal.Parse(row["Attr7"].ToString());
				}
				if(row["Attr8"]!=null && row["Attr8"].ToString()!="")
				{
					model.Attr8=decimal.Parse(row["Attr8"].ToString());
				}
				if(row["Attr9"]!=null)
				{
					model.Attr9=row["Attr9"].ToString();
				}
				if(row["TechnicaServiceFee"]!=null && row["TechnicaServiceFee"].ToString()!="")
				{
					model.TechnicaServiceFee=decimal.Parse(row["TechnicaServiceFee"].ToString());
				}
				if(row["SecurityFee"]!=null && row["SecurityFee"].ToString()!="")
				{
					model.SecurityFee=decimal.Parse(row["SecurityFee"].ToString());
				}
				if(row["WithdrawRed"]!=null && row["WithdrawRed"].ToString()!="")
				{
					model.WithdrawRed=decimal.Parse(row["WithdrawRed"].ToString());
				}
				if(row["DownloadAppRed"]!=null && row["DownloadAppRed"].ToString()!="")
				{
					model.DownloadAppRed=decimal.Parse(row["DownloadAppRed"].ToString());
				}
				if(row["DownloadAppRedCount"]!=null && row["DownloadAppRedCount"].ToString()!="")
				{
					model.DownloadAppRedCount=int.Parse(row["DownloadAppRedCount"].ToString());
				}
				if(row["IsOpenRed"]!=null && row["IsOpenRed"].ToString()!="")
				{
					model.IsOpenRed=int.Parse(row["IsOpenRed"].ToString());
				}
				if(row["IsOpenRecommendAPPRed"]!=null && row["IsOpenRecommendAPPRed"].ToString()!="")
				{
					model.IsOpenRecommendAPPRed=int.Parse(row["IsOpenRecommendAPPRed"].ToString());
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
				if(row["OtherDecimal1"]!=null && row["OtherDecimal1"].ToString()!="")
				{
					model.OtherDecimal1=decimal.Parse(row["OtherDecimal1"].ToString());
				}
				if(row["OtherDecimal2"]!=null && row["OtherDecimal2"].ToString()!="")
				{
					model.OtherDecimal2=decimal.Parse(row["OtherDecimal2"].ToString());
				}
				if(row["OtherDecimal3"]!=null && row["OtherDecimal3"].ToString()!="")
				{
					model.OtherDecimal3=decimal.Parse(row["OtherDecimal3"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ParentID,IDPath,WebState,CloseInfo,WebName,WebUrl,HomePage,Title,Keywords,Description,EmailSmtp,EmailName,EmailPwd,ReceiveEmail,Mobile,Telephone,Address,Copyright,OrderBy,State,IsIntegral,IsAdvertisement,IntegralConversion,IntegralAll,MoneyAll,IntegralSeeking,IntegralShare,IntegralRecommend,IntegralRegister,IntegralReNews,IntegralRemoveReNews,IntegralAttend,IntegralContact,IntegrallimitSell,IntegrallimitMoney,IntegralReRatio,PayRecRatio,MarketReRatio,NewsActionReRatio,ContactReRatio,UserAttendRecRatio,NewsRecRatio,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9,TechnicaServiceFee,SecurityFee,WithdrawRed,DownloadAppRed,DownloadAppRedCount,IsOpenRed,IsOpenRecommendAPPRed,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherDecimal1,OtherDecimal2,OtherDecimal3,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5 ");
			strSql.Append(" FROM SW_Admin_WebSite ");
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
			strSql.Append(" ID,ParentID,IDPath,WebState,CloseInfo,WebName,WebUrl,HomePage,Title,Keywords,Description,EmailSmtp,EmailName,EmailPwd,ReceiveEmail,Mobile,Telephone,Address,Copyright,OrderBy,State,IsIntegral,IsAdvertisement,IntegralConversion,IntegralAll,MoneyAll,IntegralSeeking,IntegralShare,IntegralRecommend,IntegralRegister,IntegralReNews,IntegralRemoveReNews,IntegralAttend,IntegralContact,IntegrallimitSell,IntegrallimitMoney,IntegralReRatio,PayRecRatio,MarketReRatio,NewsActionReRatio,ContactReRatio,UserAttendRecRatio,NewsRecRatio,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8,Attr9,TechnicaServiceFee,SecurityFee,WithdrawRed,DownloadAppRed,DownloadAppRedCount,IsOpenRed,IsOpenRecommendAPPRed,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherDecimal1,OtherDecimal2,OtherDecimal3,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5 ");
			strSql.Append(" FROM SW_Admin_WebSite ");
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
			strSql.Append("select count(1) FROM SW_Admin_WebSite ");
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
                strSql = "select top " + endIndex + " * from SW_Admin_WebSite where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Admin_WebSite where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Admin_WebSite where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Admin_WebSite";
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

