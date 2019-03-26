
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserHistory
	/// </summary>
	public partial class Dal_UserHistory
	{
		public Dal_UserHistory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserHistory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserHistory");
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
		public int Add(WebSite.Model.Mod_UserHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserHistory(");
			strSql.Append("Userid,Model,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,State,Integral,TotalIntegral,FreezeIntegral,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,WebSiteID,MemberMessageids,Icard,IcardUrl,Qq,CurrentResidence,IsPublic,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAttribute,QualificationsUrl,Abbot,AbbotUrl,AbbotMobile,BuddhistMonks,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5)");
			strSql.Append(" values (");
			strSql.Append("@Userid,@Model,@UserName,@RealName,@NiceName,@Password,@PayPassword,@Problem,@Answer,@Sex,@Company,@BirthDate,@Image,@State,@Integral,@TotalIntegral,@FreezeIntegral,@Money,@ConsumptionMoney,@FreezeMoney,@TypeID,@LevelID,@LevelName,@LevelIntegral,@LevelMoney,@ModifyDate,@OrderBy,@Email,@EmailCode,@EmailAudit,@EmailAuditDate,@Countries,@Province,@City,@Region,@Address,@Mobile,@Contact,@NewLoginIP,@NewLoginDate,@LoginIP,@LoginDate,@LoginCount,@RegisterIP,@RegisterDate,@UnionID,@SignCount,@SignDate,@WebSiteID,@MemberMessageids,@Icard,@IcardUrl,@Qq,@CurrentResidence,@IsPublic,@FaHao,@GYShiFu,@GYDaoChang,@GYYear,@Enterprise,@EnterpriseNum,@Industry,@RegAddress,@RegUrl,@Header,@HeaderMobile,@CJDaoChang,@CJYear,@Masters,@CZDaoChang,@XZDaoChang,@IsOrdained,@OrdaineUrl1,@OrdaineUrl2,@PopularName,@DCAttribute,@QualificationsUrl,@Abbot,@AbbotUrl,@AbbotMobile,@BuddhistMonks,@BuddhistMonksCount,@BankName,@BankICard,@Bank,@CardNum,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherInt5,@OtherInt6,@OtherInt7,@OtherInt8,@OtherInt9,@OtherInt10,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@OtherString5,@OtherString6,@OtherString7,@OtherString8,@OtherString9,@OtherString10,@OtherText1,@OtherText2,@OtherText3,@OtherText4,@OtherText5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Userid", SqlDbType.Int,4),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@NiceName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PayPassword", SqlDbType.VarChar,200),
					new SqlParameter("@Problem", SqlDbType.VarChar,200),
					new SqlParameter("@Answer", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@BirthDate", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@FreezeIntegral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ConsumptionMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FreezeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelName", SqlDbType.VarChar,50),
					new SqlParameter("@LevelIntegral", SqlDbType.Int,4),
					new SqlParameter("@LevelMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@EmailCode", SqlDbType.VarChar,200),
					new SqlParameter("@EmailAudit", SqlDbType.Int,4),
					new SqlParameter("@EmailAuditDate", SqlDbType.DateTime),
					new SqlParameter("@Countries", SqlDbType.VarChar,200),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Contact", SqlDbType.VarChar,200),
					new SqlParameter("@NewLoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@NewLoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginCount", SqlDbType.Int,4),
					new SqlParameter("@RegisterIP", SqlDbType.VarChar,50),
					new SqlParameter("@RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@UnionID", SqlDbType.VarChar,50),
					new SqlParameter("@SignCount", SqlDbType.Int,4),
					new SqlParameter("@SignDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@MemberMessageids", SqlDbType.VarChar,500),
					new SqlParameter("@Icard", SqlDbType.VarChar,50),
					new SqlParameter("@IcardUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@CurrentResidence", SqlDbType.VarChar,200),
					new SqlParameter("@IsPublic", SqlDbType.Int,4),
					new SqlParameter("@FaHao", SqlDbType.VarChar,200),
					new SqlParameter("@GYShiFu", SqlDbType.VarChar,100),
					new SqlParameter("@GYDaoChang", SqlDbType.VarChar,200),
					new SqlParameter("@GYYear", SqlDbType.VarChar,50),
					new SqlParameter("@Enterprise", SqlDbType.VarChar,200),
					new SqlParameter("@EnterpriseNum", SqlDbType.VarChar,200),
					new SqlParameter("@Industry", SqlDbType.VarChar,100),
					new SqlParameter("@RegAddress", SqlDbType.VarChar,200),
					new SqlParameter("@RegUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Header", SqlDbType.VarChar,200),
					new SqlParameter("@HeaderMobile", SqlDbType.VarChar,100),
					new SqlParameter("@CJDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@CJYear", SqlDbType.VarChar,50),
					new SqlParameter("@Masters", SqlDbType.VarChar,50),
					new SqlParameter("@CZDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@XZDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@IsOrdained", SqlDbType.Int,4),
					new SqlParameter("@OrdaineUrl1", SqlDbType.VarChar,200),
					new SqlParameter("@OrdaineUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@PopularName", SqlDbType.VarChar,100),
					new SqlParameter("@DCAttribute", SqlDbType.VarChar,100),
					new SqlParameter("@QualificationsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Abbot", SqlDbType.VarChar,100),
					new SqlParameter("@AbbotUrl", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotMobile", SqlDbType.VarChar,100),
					new SqlParameter("@BuddhistMonks", SqlDbType.VarChar,50),
					new SqlParameter("@BuddhistMonksCount", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@BankICard", SqlDbType.VarChar,100),
					new SqlParameter("@Bank", SqlDbType.VarChar,100),
					new SqlParameter("@CardNum", SqlDbType.VarChar,100),
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
					new SqlParameter("@OtherText5", SqlDbType.Text)};
			parameters[0].Value = model.Userid;
			parameters[1].Value = model.Model;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.RealName;
			parameters[4].Value = model.NiceName;
			parameters[5].Value = model.Password;
			parameters[6].Value = model.PayPassword;
			parameters[7].Value = model.Problem;
			parameters[8].Value = model.Answer;
			parameters[9].Value = model.Sex;
			parameters[10].Value = model.Company;
			parameters[11].Value = model.BirthDate;
			parameters[12].Value = model.Image;
			parameters[13].Value = model.State;
			parameters[14].Value = model.Integral;
			parameters[15].Value = model.TotalIntegral;
			parameters[16].Value = model.FreezeIntegral;
			parameters[17].Value = model.Money;
			parameters[18].Value = model.ConsumptionMoney;
			parameters[19].Value = model.FreezeMoney;
			parameters[20].Value = model.TypeID;
			parameters[21].Value = model.LevelID;
			parameters[22].Value = model.LevelName;
			parameters[23].Value = model.LevelIntegral;
			parameters[24].Value = model.LevelMoney;
			parameters[25].Value = model.ModifyDate;
			parameters[26].Value = model.OrderBy;
			parameters[27].Value = model.Email;
			parameters[28].Value = model.EmailCode;
			parameters[29].Value = model.EmailAudit;
			parameters[30].Value = model.EmailAuditDate;
			parameters[31].Value = model.Countries;
			parameters[32].Value = model.Province;
			parameters[33].Value = model.City;
			parameters[34].Value = model.Region;
			parameters[35].Value = model.Address;
			parameters[36].Value = model.Mobile;
			parameters[37].Value = model.Contact;
			parameters[38].Value = model.NewLoginIP;
			parameters[39].Value = model.NewLoginDate;
			parameters[40].Value = model.LoginIP;
			parameters[41].Value = model.LoginDate;
			parameters[42].Value = model.LoginCount;
			parameters[43].Value = model.RegisterIP;
			parameters[44].Value = model.RegisterDate;
			parameters[45].Value = model.UnionID;
			parameters[46].Value = model.SignCount;
			parameters[47].Value = model.SignDate;
			parameters[48].Value = model.WebSiteID;
			parameters[49].Value = model.MemberMessageids;
			parameters[50].Value = model.Icard;
			parameters[51].Value = model.IcardUrl;
			parameters[52].Value = model.Qq;
			parameters[53].Value = model.CurrentResidence;
			parameters[54].Value = model.IsPublic;
			parameters[55].Value = model.FaHao;
			parameters[56].Value = model.GYShiFu;
			parameters[57].Value = model.GYDaoChang;
			parameters[58].Value = model.GYYear;
			parameters[59].Value = model.Enterprise;
			parameters[60].Value = model.EnterpriseNum;
			parameters[61].Value = model.Industry;
			parameters[62].Value = model.RegAddress;
			parameters[63].Value = model.RegUrl;
			parameters[64].Value = model.Header;
			parameters[65].Value = model.HeaderMobile;
			parameters[66].Value = model.CJDaoChang;
			parameters[67].Value = model.CJYear;
			parameters[68].Value = model.Masters;
			parameters[69].Value = model.CZDaoChang;
			parameters[70].Value = model.XZDaoChang;
			parameters[71].Value = model.IsOrdained;
			parameters[72].Value = model.OrdaineUrl1;
			parameters[73].Value = model.OrdaineUrl2;
			parameters[74].Value = model.PopularName;
			parameters[75].Value = model.DCAttribute;
			parameters[76].Value = model.QualificationsUrl;
			parameters[77].Value = model.Abbot;
			parameters[78].Value = model.AbbotUrl;
			parameters[79].Value = model.AbbotMobile;
			parameters[80].Value = model.BuddhistMonks;
			parameters[81].Value = model.BuddhistMonksCount;
			parameters[82].Value = model.BankName;
			parameters[83].Value = model.BankICard;
			parameters[84].Value = model.Bank;
			parameters[85].Value = model.CardNum;
			parameters[86].Value = model.OtherInt1;
			parameters[87].Value = model.OtherInt2;
			parameters[88].Value = model.OtherInt3;
			parameters[89].Value = model.OtherInt4;
			parameters[90].Value = model.OtherInt5;
			parameters[91].Value = model.OtherInt6;
			parameters[92].Value = model.OtherInt7;
			parameters[93].Value = model.OtherInt8;
			parameters[94].Value = model.OtherInt9;
			parameters[95].Value = model.OtherInt10;
			parameters[96].Value = model.OtherString1;
			parameters[97].Value = model.OtherString2;
			parameters[98].Value = model.OtherString3;
			parameters[99].Value = model.OtherString4;
			parameters[100].Value = model.OtherString5;
			parameters[101].Value = model.OtherString6;
			parameters[102].Value = model.OtherString7;
			parameters[103].Value = model.OtherString8;
			parameters[104].Value = model.OtherString9;
			parameters[105].Value = model.OtherString10;
			parameters[106].Value = model.OtherText1;
			parameters[107].Value = model.OtherText2;
			parameters[108].Value = model.OtherText3;
			parameters[109].Value = model.OtherText4;
			parameters[110].Value = model.OtherText5;

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
		public bool Update(WebSite.Model.Mod_UserHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserHistory set ");
			strSql.Append("Userid=@Userid,");
			strSql.Append("Model=@Model,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("NiceName=@NiceName,");
			strSql.Append("Password=@Password,");
			strSql.Append("PayPassword=@PayPassword,");
			strSql.Append("Problem=@Problem,");
			strSql.Append("Answer=@Answer,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Company=@Company,");
			strSql.Append("BirthDate=@BirthDate,");
			strSql.Append("Image=@Image,");
			strSql.Append("State=@State,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("TotalIntegral=@TotalIntegral,");
			strSql.Append("FreezeIntegral=@FreezeIntegral,");
			strSql.Append("Money=@Money,");
			strSql.Append("ConsumptionMoney=@ConsumptionMoney,");
			strSql.Append("FreezeMoney=@FreezeMoney,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("LevelID=@LevelID,");
			strSql.Append("LevelName=@LevelName,");
			strSql.Append("LevelIntegral=@LevelIntegral,");
			strSql.Append("LevelMoney=@LevelMoney,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("Email=@Email,");
			strSql.Append("EmailCode=@EmailCode,");
			strSql.Append("EmailAudit=@EmailAudit,");
			strSql.Append("EmailAuditDate=@EmailAuditDate,");
			strSql.Append("Countries=@Countries,");
			strSql.Append("Province=@Province,");
			strSql.Append("City=@City,");
			strSql.Append("Region=@Region,");
			strSql.Append("Address=@Address,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Contact=@Contact,");
			strSql.Append("NewLoginIP=@NewLoginIP,");
			strSql.Append("NewLoginDate=@NewLoginDate,");
			strSql.Append("LoginIP=@LoginIP,");
			strSql.Append("LoginDate=@LoginDate,");
			strSql.Append("LoginCount=@LoginCount,");
			strSql.Append("RegisterIP=@RegisterIP,");
			strSql.Append("RegisterDate=@RegisterDate,");
			strSql.Append("UnionID=@UnionID,");
			strSql.Append("SignCount=@SignCount,");
			strSql.Append("SignDate=@SignDate,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("MemberMessageids=@MemberMessageids,");
			strSql.Append("Icard=@Icard,");
			strSql.Append("IcardUrl=@IcardUrl,");
			strSql.Append("Qq=@Qq,");
			strSql.Append("CurrentResidence=@CurrentResidence,");
			strSql.Append("IsPublic=@IsPublic,");
			strSql.Append("FaHao=@FaHao,");
			strSql.Append("GYShiFu=@GYShiFu,");
			strSql.Append("GYDaoChang=@GYDaoChang,");
			strSql.Append("GYYear=@GYYear,");
			strSql.Append("Enterprise=@Enterprise,");
			strSql.Append("EnterpriseNum=@EnterpriseNum,");
			strSql.Append("Industry=@Industry,");
			strSql.Append("RegAddress=@RegAddress,");
			strSql.Append("RegUrl=@RegUrl,");
			strSql.Append("Header=@Header,");
			strSql.Append("HeaderMobile=@HeaderMobile,");
			strSql.Append("CJDaoChang=@CJDaoChang,");
			strSql.Append("CJYear=@CJYear,");
			strSql.Append("Masters=@Masters,");
			strSql.Append("CZDaoChang=@CZDaoChang,");
			strSql.Append("XZDaoChang=@XZDaoChang,");
			strSql.Append("IsOrdained=@IsOrdained,");
			strSql.Append("OrdaineUrl1=@OrdaineUrl1,");
			strSql.Append("OrdaineUrl2=@OrdaineUrl2,");
			strSql.Append("PopularName=@PopularName,");
			strSql.Append("DCAttribute=@DCAttribute,");
			strSql.Append("QualificationsUrl=@QualificationsUrl,");
			strSql.Append("Abbot=@Abbot,");
			strSql.Append("AbbotUrl=@AbbotUrl,");
			strSql.Append("AbbotMobile=@AbbotMobile,");
			strSql.Append("BuddhistMonks=@BuddhistMonks,");
			strSql.Append("BuddhistMonksCount=@BuddhistMonksCount,");
			strSql.Append("BankName=@BankName,");
			strSql.Append("BankICard=@BankICard,");
			strSql.Append("Bank=@Bank,");
			strSql.Append("CardNum=@CardNum,");
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
			strSql.Append("OtherText5=@OtherText5");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Userid", SqlDbType.Int,4),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@RealName", SqlDbType.VarChar,200),
					new SqlParameter("@NiceName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PayPassword", SqlDbType.VarChar,200),
					new SqlParameter("@Problem", SqlDbType.VarChar,200),
					new SqlParameter("@Answer", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.VarChar,200),
					new SqlParameter("@BirthDate", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@FreezeIntegral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ConsumptionMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FreezeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelName", SqlDbType.VarChar,50),
					new SqlParameter("@LevelIntegral", SqlDbType.Int,4),
					new SqlParameter("@LevelMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@EmailCode", SqlDbType.VarChar,200),
					new SqlParameter("@EmailAudit", SqlDbType.Int,4),
					new SqlParameter("@EmailAuditDate", SqlDbType.DateTime),
					new SqlParameter("@Countries", SqlDbType.VarChar,200),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Contact", SqlDbType.VarChar,200),
					new SqlParameter("@NewLoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@NewLoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@LoginCount", SqlDbType.Int,4),
					new SqlParameter("@RegisterIP", SqlDbType.VarChar,50),
					new SqlParameter("@RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@UnionID", SqlDbType.VarChar,50),
					new SqlParameter("@SignCount", SqlDbType.Int,4),
					new SqlParameter("@SignDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@MemberMessageids", SqlDbType.VarChar,500),
					new SqlParameter("@Icard", SqlDbType.VarChar,50),
					new SqlParameter("@IcardUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@CurrentResidence", SqlDbType.VarChar,200),
					new SqlParameter("@IsPublic", SqlDbType.Int,4),
					new SqlParameter("@FaHao", SqlDbType.VarChar,200),
					new SqlParameter("@GYShiFu", SqlDbType.VarChar,100),
					new SqlParameter("@GYDaoChang", SqlDbType.VarChar,200),
					new SqlParameter("@GYYear", SqlDbType.VarChar,50),
					new SqlParameter("@Enterprise", SqlDbType.VarChar,200),
					new SqlParameter("@EnterpriseNum", SqlDbType.VarChar,200),
					new SqlParameter("@Industry", SqlDbType.VarChar,100),
					new SqlParameter("@RegAddress", SqlDbType.VarChar,200),
					new SqlParameter("@RegUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Header", SqlDbType.VarChar,200),
					new SqlParameter("@HeaderMobile", SqlDbType.VarChar,100),
					new SqlParameter("@CJDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@CJYear", SqlDbType.VarChar,50),
					new SqlParameter("@Masters", SqlDbType.VarChar,50),
					new SqlParameter("@CZDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@XZDaoChang", SqlDbType.VarChar,100),
					new SqlParameter("@IsOrdained", SqlDbType.Int,4),
					new SqlParameter("@OrdaineUrl1", SqlDbType.VarChar,200),
					new SqlParameter("@OrdaineUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@PopularName", SqlDbType.VarChar,100),
					new SqlParameter("@DCAttribute", SqlDbType.VarChar,100),
					new SqlParameter("@QualificationsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Abbot", SqlDbType.VarChar,100),
					new SqlParameter("@AbbotUrl", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotMobile", SqlDbType.VarChar,100),
					new SqlParameter("@BuddhistMonks", SqlDbType.VarChar,50),
					new SqlParameter("@BuddhistMonksCount", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@BankICard", SqlDbType.VarChar,100),
					new SqlParameter("@Bank", SqlDbType.VarChar,100),
					new SqlParameter("@CardNum", SqlDbType.VarChar,100),
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
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Userid;
			parameters[1].Value = model.Model;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.RealName;
			parameters[4].Value = model.NiceName;
			parameters[5].Value = model.Password;
			parameters[6].Value = model.PayPassword;
			parameters[7].Value = model.Problem;
			parameters[8].Value = model.Answer;
			parameters[9].Value = model.Sex;
			parameters[10].Value = model.Company;
			parameters[11].Value = model.BirthDate;
			parameters[12].Value = model.Image;
			parameters[13].Value = model.State;
			parameters[14].Value = model.Integral;
			parameters[15].Value = model.TotalIntegral;
			parameters[16].Value = model.FreezeIntegral;
			parameters[17].Value = model.Money;
			parameters[18].Value = model.ConsumptionMoney;
			parameters[19].Value = model.FreezeMoney;
			parameters[20].Value = model.TypeID;
			parameters[21].Value = model.LevelID;
			parameters[22].Value = model.LevelName;
			parameters[23].Value = model.LevelIntegral;
			parameters[24].Value = model.LevelMoney;
			parameters[25].Value = model.ModifyDate;
			parameters[26].Value = model.OrderBy;
			parameters[27].Value = model.Email;
			parameters[28].Value = model.EmailCode;
			parameters[29].Value = model.EmailAudit;
			parameters[30].Value = model.EmailAuditDate;
			parameters[31].Value = model.Countries;
			parameters[32].Value = model.Province;
			parameters[33].Value = model.City;
			parameters[34].Value = model.Region;
			parameters[35].Value = model.Address;
			parameters[36].Value = model.Mobile;
			parameters[37].Value = model.Contact;
			parameters[38].Value = model.NewLoginIP;
			parameters[39].Value = model.NewLoginDate;
			parameters[40].Value = model.LoginIP;
			parameters[41].Value = model.LoginDate;
			parameters[42].Value = model.LoginCount;
			parameters[43].Value = model.RegisterIP;
			parameters[44].Value = model.RegisterDate;
			parameters[45].Value = model.UnionID;
			parameters[46].Value = model.SignCount;
			parameters[47].Value = model.SignDate;
			parameters[48].Value = model.WebSiteID;
			parameters[49].Value = model.MemberMessageids;
			parameters[50].Value = model.Icard;
			parameters[51].Value = model.IcardUrl;
			parameters[52].Value = model.Qq;
			parameters[53].Value = model.CurrentResidence;
			parameters[54].Value = model.IsPublic;
			parameters[55].Value = model.FaHao;
			parameters[56].Value = model.GYShiFu;
			parameters[57].Value = model.GYDaoChang;
			parameters[58].Value = model.GYYear;
			parameters[59].Value = model.Enterprise;
			parameters[60].Value = model.EnterpriseNum;
			parameters[61].Value = model.Industry;
			parameters[62].Value = model.RegAddress;
			parameters[63].Value = model.RegUrl;
			parameters[64].Value = model.Header;
			parameters[65].Value = model.HeaderMobile;
			parameters[66].Value = model.CJDaoChang;
			parameters[67].Value = model.CJYear;
			parameters[68].Value = model.Masters;
			parameters[69].Value = model.CZDaoChang;
			parameters[70].Value = model.XZDaoChang;
			parameters[71].Value = model.IsOrdained;
			parameters[72].Value = model.OrdaineUrl1;
			parameters[73].Value = model.OrdaineUrl2;
			parameters[74].Value = model.PopularName;
			parameters[75].Value = model.DCAttribute;
			parameters[76].Value = model.QualificationsUrl;
			parameters[77].Value = model.Abbot;
			parameters[78].Value = model.AbbotUrl;
			parameters[79].Value = model.AbbotMobile;
			parameters[80].Value = model.BuddhistMonks;
			parameters[81].Value = model.BuddhistMonksCount;
			parameters[82].Value = model.BankName;
			parameters[83].Value = model.BankICard;
			parameters[84].Value = model.Bank;
			parameters[85].Value = model.CardNum;
			parameters[86].Value = model.OtherInt1;
			parameters[87].Value = model.OtherInt2;
			parameters[88].Value = model.OtherInt3;
			parameters[89].Value = model.OtherInt4;
			parameters[90].Value = model.OtherInt5;
			parameters[91].Value = model.OtherInt6;
			parameters[92].Value = model.OtherInt7;
			parameters[93].Value = model.OtherInt8;
			parameters[94].Value = model.OtherInt9;
			parameters[95].Value = model.OtherInt10;
			parameters[96].Value = model.OtherString1;
			parameters[97].Value = model.OtherString2;
			parameters[98].Value = model.OtherString3;
			parameters[99].Value = model.OtherString4;
			parameters[100].Value = model.OtherString5;
			parameters[101].Value = model.OtherString6;
			parameters[102].Value = model.OtherString7;
			parameters[103].Value = model.OtherString8;
			parameters[104].Value = model.OtherString9;
			parameters[105].Value = model.OtherString10;
			parameters[106].Value = model.OtherText1;
			parameters[107].Value = model.OtherText2;
			parameters[108].Value = model.OtherText3;
			parameters[109].Value = model.OtherText4;
			parameters[110].Value = model.OtherText5;
			parameters[111].Value = model.ID;

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
			strSql.Append("delete from SW_UserHistory ");
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
			strSql.Append("delete from SW_UserHistory ");
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
		public WebSite.Model.Mod_UserHistory GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Userid,Model,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,State,Integral,TotalIntegral,FreezeIntegral,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,WebSiteID,MemberMessageids,Icard,IcardUrl,Qq,CurrentResidence,IsPublic,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAttribute,QualificationsUrl,Abbot,AbbotUrl,AbbotMobile,BuddhistMonks,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5 from SW_UserHistory ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserHistory model=new WebSite.Model.Mod_UserHistory();
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
		public WebSite.Model.Mod_UserHistory DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserHistory model=new WebSite.Model.Mod_UserHistory();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Userid"]!=null && row["Userid"].ToString()!="")
				{
					model.Userid=int.Parse(row["Userid"].ToString());
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["RealName"]!=null)
				{
					model.RealName=row["RealName"].ToString();
				}
				if(row["NiceName"]!=null)
				{
					model.NiceName=row["NiceName"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["PayPassword"]!=null)
				{
					model.PayPassword=row["PayPassword"].ToString();
				}
				if(row["Problem"]!=null)
				{
					model.Problem=row["Problem"].ToString();
				}
				if(row["Answer"]!=null)
				{
					model.Answer=row["Answer"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["BirthDate"]!=null)
				{
					model.BirthDate=row["BirthDate"].ToString();
				}
				if(row["Image"]!=null)
				{
					model.Image=row["Image"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["TotalIntegral"]!=null && row["TotalIntegral"].ToString()!="")
				{
					model.TotalIntegral=int.Parse(row["TotalIntegral"].ToString());
				}
				if(row["FreezeIntegral"]!=null && row["FreezeIntegral"].ToString()!="")
				{
					model.FreezeIntegral=int.Parse(row["FreezeIntegral"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["ConsumptionMoney"]!=null && row["ConsumptionMoney"].ToString()!="")
				{
					model.ConsumptionMoney=decimal.Parse(row["ConsumptionMoney"].ToString());
				}
				if(row["FreezeMoney"]!=null && row["FreezeMoney"].ToString()!="")
				{
					model.FreezeMoney=decimal.Parse(row["FreezeMoney"].ToString());
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["LevelID"]!=null && row["LevelID"].ToString()!="")
				{
					model.LevelID=int.Parse(row["LevelID"].ToString());
				}
				if(row["LevelName"]!=null)
				{
					model.LevelName=row["LevelName"].ToString();
				}
				if(row["LevelIntegral"]!=null && row["LevelIntegral"].ToString()!="")
				{
					model.LevelIntegral=int.Parse(row["LevelIntegral"].ToString());
				}
				if(row["LevelMoney"]!=null && row["LevelMoney"].ToString()!="")
				{
					model.LevelMoney=decimal.Parse(row["LevelMoney"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["EmailCode"]!=null)
				{
					model.EmailCode=row["EmailCode"].ToString();
				}
				if(row["EmailAudit"]!=null && row["EmailAudit"].ToString()!="")
				{
					model.EmailAudit=int.Parse(row["EmailAudit"].ToString());
				}
				if(row["EmailAuditDate"]!=null && row["EmailAuditDate"].ToString()!="")
				{
					model.EmailAuditDate=DateTime.Parse(row["EmailAuditDate"].ToString());
				}
				if(row["Countries"]!=null)
				{
					model.Countries=row["Countries"].ToString();
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["Region"]!=null)
				{
					model.Region=row["Region"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Contact"]!=null)
				{
					model.Contact=row["Contact"].ToString();
				}
				if(row["NewLoginIP"]!=null)
				{
					model.NewLoginIP=row["NewLoginIP"].ToString();
				}
				if(row["NewLoginDate"]!=null && row["NewLoginDate"].ToString()!="")
				{
					model.NewLoginDate=DateTime.Parse(row["NewLoginDate"].ToString());
				}
				if(row["LoginIP"]!=null)
				{
					model.LoginIP=row["LoginIP"].ToString();
				}
				if(row["LoginDate"]!=null && row["LoginDate"].ToString()!="")
				{
					model.LoginDate=DateTime.Parse(row["LoginDate"].ToString());
				}
				if(row["LoginCount"]!=null && row["LoginCount"].ToString()!="")
				{
					model.LoginCount=int.Parse(row["LoginCount"].ToString());
				}
				if(row["RegisterIP"]!=null)
				{
					model.RegisterIP=row["RegisterIP"].ToString();
				}
				if(row["RegisterDate"]!=null && row["RegisterDate"].ToString()!="")
				{
					model.RegisterDate=DateTime.Parse(row["RegisterDate"].ToString());
				}
				if(row["UnionID"]!=null)
				{
					model.UnionID=row["UnionID"].ToString();
				}
				if(row["SignCount"]!=null && row["SignCount"].ToString()!="")
				{
					model.SignCount=int.Parse(row["SignCount"].ToString());
				}
				if(row["SignDate"]!=null && row["SignDate"].ToString()!="")
				{
					model.SignDate=DateTime.Parse(row["SignDate"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["MemberMessageids"]!=null)
				{
					model.MemberMessageids=row["MemberMessageids"].ToString();
				}
				if(row["Icard"]!=null)
				{
					model.Icard=row["Icard"].ToString();
				}
				if(row["IcardUrl"]!=null)
				{
					model.IcardUrl=row["IcardUrl"].ToString();
				}
				if(row["Qq"]!=null)
				{
					model.Qq=row["Qq"].ToString();
				}
				if(row["CurrentResidence"]!=null)
				{
					model.CurrentResidence=row["CurrentResidence"].ToString();
				}
				if(row["IsPublic"]!=null && row["IsPublic"].ToString()!="")
				{
					model.IsPublic=int.Parse(row["IsPublic"].ToString());
				}
				if(row["FaHao"]!=null)
				{
					model.FaHao=row["FaHao"].ToString();
				}
				if(row["GYShiFu"]!=null)
				{
					model.GYShiFu=row["GYShiFu"].ToString();
				}
				if(row["GYDaoChang"]!=null)
				{
					model.GYDaoChang=row["GYDaoChang"].ToString();
				}
				if(row["GYYear"]!=null)
				{
					model.GYYear=row["GYYear"].ToString();
				}
				if(row["Enterprise"]!=null)
				{
					model.Enterprise=row["Enterprise"].ToString();
				}
				if(row["EnterpriseNum"]!=null)
				{
					model.EnterpriseNum=row["EnterpriseNum"].ToString();
				}
				if(row["Industry"]!=null)
				{
					model.Industry=row["Industry"].ToString();
				}
				if(row["RegAddress"]!=null)
				{
					model.RegAddress=row["RegAddress"].ToString();
				}
				if(row["RegUrl"]!=null)
				{
					model.RegUrl=row["RegUrl"].ToString();
				}
				if(row["Header"]!=null)
				{
					model.Header=row["Header"].ToString();
				}
				if(row["HeaderMobile"]!=null)
				{
					model.HeaderMobile=row["HeaderMobile"].ToString();
				}
				if(row["CJDaoChang"]!=null)
				{
					model.CJDaoChang=row["CJDaoChang"].ToString();
				}
				if(row["CJYear"]!=null)
				{
					model.CJYear=row["CJYear"].ToString();
				}
				if(row["Masters"]!=null)
				{
					model.Masters=row["Masters"].ToString();
				}
				if(row["CZDaoChang"]!=null)
				{
					model.CZDaoChang=row["CZDaoChang"].ToString();
				}
				if(row["XZDaoChang"]!=null)
				{
					model.XZDaoChang=row["XZDaoChang"].ToString();
				}
				if(row["IsOrdained"]!=null && row["IsOrdained"].ToString()!="")
				{
					model.IsOrdained=int.Parse(row["IsOrdained"].ToString());
				}
				if(row["OrdaineUrl1"]!=null)
				{
					model.OrdaineUrl1=row["OrdaineUrl1"].ToString();
				}
				if(row["OrdaineUrl2"]!=null)
				{
					model.OrdaineUrl2=row["OrdaineUrl2"].ToString();
				}
				if(row["PopularName"]!=null)
				{
					model.PopularName=row["PopularName"].ToString();
				}
				if(row["DCAttribute"]!=null)
				{
					model.DCAttribute=row["DCAttribute"].ToString();
				}
				if(row["QualificationsUrl"]!=null)
				{
					model.QualificationsUrl=row["QualificationsUrl"].ToString();
				}
				if(row["Abbot"]!=null)
				{
					model.Abbot=row["Abbot"].ToString();
				}
				if(row["AbbotUrl"]!=null)
				{
					model.AbbotUrl=row["AbbotUrl"].ToString();
				}
				if(row["AbbotMobile"]!=null)
				{
					model.AbbotMobile=row["AbbotMobile"].ToString();
				}
				if(row["BuddhistMonks"]!=null)
				{
					model.BuddhistMonks=row["BuddhistMonks"].ToString();
				}
				if(row["BuddhistMonksCount"]!=null && row["BuddhistMonksCount"].ToString()!="")
				{
					model.BuddhistMonksCount=int.Parse(row["BuddhistMonksCount"].ToString());
				}
				if(row["BankName"]!=null)
				{
					model.BankName=row["BankName"].ToString();
				}
				if(row["BankICard"]!=null)
				{
					model.BankICard=row["BankICard"].ToString();
				}
				if(row["Bank"]!=null)
				{
					model.Bank=row["Bank"].ToString();
				}
				if(row["CardNum"]!=null)
				{
					model.CardNum=row["CardNum"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Userid,Model,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,State,Integral,TotalIntegral,FreezeIntegral,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,WebSiteID,MemberMessageids,Icard,IcardUrl,Qq,CurrentResidence,IsPublic,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAttribute,QualificationsUrl,Abbot,AbbotUrl,AbbotMobile,BuddhistMonks,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5 ");
			strSql.Append(" FROM SW_UserHistory ");
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
			strSql.Append(" ID,Userid,Model,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,State,Integral,TotalIntegral,FreezeIntegral,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,WebSiteID,MemberMessageids,Icard,IcardUrl,Qq,CurrentResidence,IsPublic,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAttribute,QualificationsUrl,Abbot,AbbotUrl,AbbotMobile,BuddhistMonks,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5 ");
			strSql.Append(" FROM SW_UserHistory ");
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
			strSql.Append("select count(1) FROM SW_UserHistory ");
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
                strSql = "select top " + endIndex + " * from SW_UserHistory where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserHistory where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserHistory where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserHistory";
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

