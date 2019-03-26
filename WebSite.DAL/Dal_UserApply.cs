
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_UserApply
	/// </summary>
	public partial class Dal_UserApply
	{
		public Dal_UserApply()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_UserApply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_UserApply");
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
		public int Add(WebSite.Model.Mod_UserApply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_UserApply(");
			strSql.Append("Model,UserID,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,PicSmall,PicBig,State,IsFreeBroker,IsShop,Integral,TotalIntegral,FreezeIntegral,IntegralSell,IntegralSellFreeze,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelClass,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,HomeUrl,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,BrowseCount,CommentCount,FabulousCount,ReportCount,FollowCount,FansCount,UserRemarks,WebSiteID,IsNeedAudit,PointAllmoney,PointAllIntegral,MboxAllmoney,MboxAllIntegral,ActionCount,MemberMessageids,Icard,IcardUrl,IcardUrl2,Qq,WeiXin,CurrentResidence,IsPublic,AuditState,AuthenticationID,AuthenticationName,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,EnterpriseUrl,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAddress,DCAttribute,QualificationsUrl,Remarks,Abbot,AbbotIcard,AbbotUrl,AbbotUrl2,AbbotMobile,DCUserName,DCMobile,BuddhistMonksM,BuddhistMonksW,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherString11,OtherString12,OtherString13,OtherString14,OtherString15,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,MemTypeIDs1,MemTypeIDs2,MemTypeIDs3,MemTypeIDs4,MemTypeIDs5,MemTypeIDs6,MemTypeIDs7,MemTypeIDs8,MemTypeIDs9,MemTypeIDs10,MemTypeIDs11,MemTypeIDs12,MemTypeIDs13,MemTypeIDs14,MemTypeIDs15,MemTypeIDs,MemTypeIDCount,MemTypeIDs7AttrIDS)");
			strSql.Append(" values (");
			strSql.Append("@Model,@UserID,@UserName,@RealName,@NiceName,@Password,@PayPassword,@Problem,@Answer,@Sex,@Company,@BirthDate,@Image,@PicSmall,@PicBig,@State,@IsFreeBroker,@IsShop,@Integral,@TotalIntegral,@FreezeIntegral,@IntegralSell,@IntegralSellFreeze,@Money,@ConsumptionMoney,@FreezeMoney,@TypeID,@LevelID,@LevelClass,@LevelName,@LevelIntegral,@LevelMoney,@ModifyDate,@OrderBy,@Email,@EmailCode,@EmailAudit,@EmailAuditDate,@Countries,@Province,@City,@Region,@Address,@Mobile,@Contact,@HomeUrl,@NewLoginIP,@NewLoginDate,@LoginIP,@LoginDate,@LoginCount,@RegisterIP,@RegisterDate,@UnionID,@SignCount,@SignDate,@BrowseCount,@CommentCount,@FabulousCount,@ReportCount,@FollowCount,@FansCount,@UserRemarks,@WebSiteID,@IsNeedAudit,@PointAllmoney,@PointAllIntegral,@MboxAllmoney,@MboxAllIntegral,@ActionCount,@MemberMessageids,@Icard,@IcardUrl,@IcardUrl2,@Qq,@WeiXin,@CurrentResidence,@IsPublic,@AuditState,@AuthenticationID,@AuthenticationName,@FaHao,@GYShiFu,@GYDaoChang,@GYYear,@Enterprise,@EnterpriseNum,@EnterpriseUrl,@Industry,@RegAddress,@RegUrl,@Header,@HeaderMobile,@CJDaoChang,@CJYear,@Masters,@CZDaoChang,@XZDaoChang,@IsOrdained,@OrdaineUrl1,@OrdaineUrl2,@PopularName,@DCAddress,@DCAttribute,@QualificationsUrl,@Remarks,@Abbot,@AbbotIcard,@AbbotUrl,@AbbotUrl2,@AbbotMobile,@DCUserName,@DCMobile,@BuddhistMonksM,@BuddhistMonksW,@BuddhistMonksCount,@BankName,@BankICard,@Bank,@CardNum,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherInt5,@OtherInt6,@OtherInt7,@OtherInt8,@OtherInt9,@OtherInt10,@OtherInt11,@OtherInt12,@OtherInt13,@OtherInt14,@OtherInt15,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@OtherString5,@OtherString6,@OtherString7,@OtherString8,@OtherString9,@OtherString10,@OtherString11,@OtherString12,@OtherString13,@OtherString14,@OtherString15,@OtherText1,@OtherText2,@OtherText3,@OtherText4,@OtherText5,@MemTypeIDs1,@MemTypeIDs2,@MemTypeIDs3,@MemTypeIDs4,@MemTypeIDs5,@MemTypeIDs6,@MemTypeIDs7,@MemTypeIDs8,@MemTypeIDs9,@MemTypeIDs10,@MemTypeIDs11,@MemTypeIDs12,@MemTypeIDs13,@MemTypeIDs14,@MemTypeIDs15,@MemTypeIDs,@MemTypeIDCount,@MemTypeIDs7AttrIDS)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@RealName", SqlDbType.NVarChar,200),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PayPassword", SqlDbType.VarChar,200),
					new SqlParameter("@Problem", SqlDbType.VarChar,200),
					new SqlParameter("@Answer", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,200),
					new SqlParameter("@BirthDate", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@PicSmall", SqlDbType.VarChar,500),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsFreeBroker", SqlDbType.Int,4),
					new SqlParameter("@IsShop", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@FreezeIntegral", SqlDbType.Int,4),
					new SqlParameter("@IntegralSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralSellFreeze", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ConsumptionMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FreezeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelClass", SqlDbType.VarChar,50),
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
					new SqlParameter("@Address", SqlDbType.NVarChar,500),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Contact", SqlDbType.NVarChar,200),
					new SqlParameter("@HomeUrl", SqlDbType.VarChar,200),
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
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FollowCount", SqlDbType.Int,4),
					new SqlParameter("@FansCount", SqlDbType.Int,4),
					new SqlParameter("@UserRemarks", SqlDbType.Text),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@IsNeedAudit", SqlDbType.Int,4),
					new SqlParameter("@PointAllmoney", SqlDbType.Int,4),
					new SqlParameter("@PointAllIntegral", SqlDbType.Int,4),
					new SqlParameter("@MboxAllmoney", SqlDbType.Int,4),
					new SqlParameter("@MboxAllIntegral", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@MemberMessageids", SqlDbType.VarChar,500),
					new SqlParameter("@Icard", SqlDbType.VarChar,50),
					new SqlParameter("@IcardUrl", SqlDbType.VarChar,200),
					new SqlParameter("@IcardUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXin", SqlDbType.VarChar,200),
					new SqlParameter("@CurrentResidence", SqlDbType.VarChar,200),
					new SqlParameter("@IsPublic", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AuthenticationID", SqlDbType.Int,4),
					new SqlParameter("@AuthenticationName", SqlDbType.VarChar,50),
					new SqlParameter("@FaHao", SqlDbType.NVarChar,200),
					new SqlParameter("@GYShiFu", SqlDbType.NVarChar,100),
					new SqlParameter("@GYDaoChang", SqlDbType.NVarChar,200),
					new SqlParameter("@GYYear", SqlDbType.VarChar,50),
					new SqlParameter("@Enterprise", SqlDbType.NVarChar,200),
					new SqlParameter("@EnterpriseNum", SqlDbType.VarChar,200),
					new SqlParameter("@EnterpriseUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Industry", SqlDbType.VarChar,100),
					new SqlParameter("@RegAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@RegUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Header", SqlDbType.VarChar,200),
					new SqlParameter("@HeaderMobile", SqlDbType.VarChar,100),
					new SqlParameter("@CJDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@CJYear", SqlDbType.VarChar,50),
					new SqlParameter("@Masters", SqlDbType.NVarChar,50),
					new SqlParameter("@CZDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@XZDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@IsOrdained", SqlDbType.Int,4),
					new SqlParameter("@OrdaineUrl1", SqlDbType.VarChar,200),
					new SqlParameter("@OrdaineUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@PopularName", SqlDbType.NVarChar,100),
					new SqlParameter("@DCAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@DCAttribute", SqlDbType.VarChar,100),
					new SqlParameter("@QualificationsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,500),
					new SqlParameter("@Abbot", SqlDbType.NVarChar,100),
					new SqlParameter("@AbbotIcard", SqlDbType.VarChar,100),
					new SqlParameter("@AbbotUrl", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotMobile", SqlDbType.VarChar,100),
					new SqlParameter("@DCUserName", SqlDbType.NVarChar,100),
					new SqlParameter("@DCMobile", SqlDbType.VarChar,100),
					new SqlParameter("@BuddhistMonksM", SqlDbType.Int,4),
					new SqlParameter("@BuddhistMonksW", SqlDbType.Int,4),
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
					new SqlParameter("@OtherInt11", SqlDbType.Int,4),
					new SqlParameter("@OtherInt12", SqlDbType.Int,4),
					new SqlParameter("@OtherInt13", SqlDbType.Int,4),
					new SqlParameter("@OtherInt14", SqlDbType.Int,4),
					new SqlParameter("@OtherInt15", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.NText),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString11", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString12", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString13", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString14", SqlDbType.NVarChar,500),
					new SqlParameter("@OtherString15", SqlDbType.NVarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.Text),
					new SqlParameter("@OtherText5", SqlDbType.Text),
					new SqlParameter("@MemTypeIDs1", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs2", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs3", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs4", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs5", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs6", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs7", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs8", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs9", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs10", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs11", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs12", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs13", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs14", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs15", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs", SqlDbType.VarChar,500),
					new SqlParameter("@MemTypeIDCount", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs7AttrIDS", SqlDbType.VarChar,500)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
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
			parameters[13].Value = model.PicSmall;
			parameters[14].Value = model.PicBig;
			parameters[15].Value = model.State;
			parameters[16].Value = model.IsFreeBroker;
			parameters[17].Value = model.IsShop;
			parameters[18].Value = model.Integral;
			parameters[19].Value = model.TotalIntegral;
			parameters[20].Value = model.FreezeIntegral;
			parameters[21].Value = model.IntegralSell;
			parameters[22].Value = model.IntegralSellFreeze;
			parameters[23].Value = model.Money;
			parameters[24].Value = model.ConsumptionMoney;
			parameters[25].Value = model.FreezeMoney;
			parameters[26].Value = model.TypeID;
			parameters[27].Value = model.LevelID;
			parameters[28].Value = model.LevelClass;
			parameters[29].Value = model.LevelName;
			parameters[30].Value = model.LevelIntegral;
			parameters[31].Value = model.LevelMoney;
			parameters[32].Value = model.ModifyDate;
			parameters[33].Value = model.OrderBy;
			parameters[34].Value = model.Email;
			parameters[35].Value = model.EmailCode;
			parameters[36].Value = model.EmailAudit;
			parameters[37].Value = model.EmailAuditDate;
			parameters[38].Value = model.Countries;
			parameters[39].Value = model.Province;
			parameters[40].Value = model.City;
			parameters[41].Value = model.Region;
			parameters[42].Value = model.Address;
			parameters[43].Value = model.Mobile;
			parameters[44].Value = model.Contact;
			parameters[45].Value = model.HomeUrl;
			parameters[46].Value = model.NewLoginIP;
			parameters[47].Value = model.NewLoginDate;
			parameters[48].Value = model.LoginIP;
			parameters[49].Value = model.LoginDate;
			parameters[50].Value = model.LoginCount;
			parameters[51].Value = model.RegisterIP;
			parameters[52].Value = model.RegisterDate;
			parameters[53].Value = model.UnionID;
			parameters[54].Value = model.SignCount;
			parameters[55].Value = model.SignDate;
			parameters[56].Value = model.BrowseCount;
			parameters[57].Value = model.CommentCount;
			parameters[58].Value = model.FabulousCount;
			parameters[59].Value = model.ReportCount;
			parameters[60].Value = model.FollowCount;
			parameters[61].Value = model.FansCount;
			parameters[62].Value = model.UserRemarks;
			parameters[63].Value = model.WebSiteID;
			parameters[64].Value = model.IsNeedAudit;
			parameters[65].Value = model.PointAllmoney;
			parameters[66].Value = model.PointAllIntegral;
			parameters[67].Value = model.MboxAllmoney;
			parameters[68].Value = model.MboxAllIntegral;
			parameters[69].Value = model.ActionCount;
			parameters[70].Value = model.MemberMessageids;
			parameters[71].Value = model.Icard;
			parameters[72].Value = model.IcardUrl;
			parameters[73].Value = model.IcardUrl2;
			parameters[74].Value = model.Qq;
			parameters[75].Value = model.WeiXin;
			parameters[76].Value = model.CurrentResidence;
			parameters[77].Value = model.IsPublic;
			parameters[78].Value = model.AuditState;
			parameters[79].Value = model.AuthenticationID;
			parameters[80].Value = model.AuthenticationName;
			parameters[81].Value = model.FaHao;
			parameters[82].Value = model.GYShiFu;
			parameters[83].Value = model.GYDaoChang;
			parameters[84].Value = model.GYYear;
			parameters[85].Value = model.Enterprise;
			parameters[86].Value = model.EnterpriseNum;
			parameters[87].Value = model.EnterpriseUrl;
			parameters[88].Value = model.Industry;
			parameters[89].Value = model.RegAddress;
			parameters[90].Value = model.RegUrl;
			parameters[91].Value = model.Header;
			parameters[92].Value = model.HeaderMobile;
			parameters[93].Value = model.CJDaoChang;
			parameters[94].Value = model.CJYear;
			parameters[95].Value = model.Masters;
			parameters[96].Value = model.CZDaoChang;
			parameters[97].Value = model.XZDaoChang;
			parameters[98].Value = model.IsOrdained;
			parameters[99].Value = model.OrdaineUrl1;
			parameters[100].Value = model.OrdaineUrl2;
			parameters[101].Value = model.PopularName;
			parameters[102].Value = model.DCAddress;
			parameters[103].Value = model.DCAttribute;
			parameters[104].Value = model.QualificationsUrl;
			parameters[105].Value = model.Remarks;
			parameters[106].Value = model.Abbot;
			parameters[107].Value = model.AbbotIcard;
			parameters[108].Value = model.AbbotUrl;
			parameters[109].Value = model.AbbotUrl2;
			parameters[110].Value = model.AbbotMobile;
			parameters[111].Value = model.DCUserName;
			parameters[112].Value = model.DCMobile;
			parameters[113].Value = model.BuddhistMonksM;
			parameters[114].Value = model.BuddhistMonksW;
			parameters[115].Value = model.BuddhistMonksCount;
			parameters[116].Value = model.BankName;
			parameters[117].Value = model.BankICard;
			parameters[118].Value = model.Bank;
			parameters[119].Value = model.CardNum;
			parameters[120].Value = model.OtherInt1;
			parameters[121].Value = model.OtherInt2;
			parameters[122].Value = model.OtherInt3;
			parameters[123].Value = model.OtherInt4;
			parameters[124].Value = model.OtherInt5;
			parameters[125].Value = model.OtherInt6;
			parameters[126].Value = model.OtherInt7;
			parameters[127].Value = model.OtherInt8;
			parameters[128].Value = model.OtherInt9;
			parameters[129].Value = model.OtherInt10;
			parameters[130].Value = model.OtherInt11;
			parameters[131].Value = model.OtherInt12;
			parameters[132].Value = model.OtherInt13;
			parameters[133].Value = model.OtherInt14;
			parameters[134].Value = model.OtherInt15;
			parameters[135].Value = model.OtherString1;
			parameters[136].Value = model.OtherString2;
			parameters[137].Value = model.OtherString3;
			parameters[138].Value = model.OtherString4;
			parameters[139].Value = model.OtherString5;
			parameters[140].Value = model.OtherString6;
			parameters[141].Value = model.OtherString7;
			parameters[142].Value = model.OtherString8;
			parameters[143].Value = model.OtherString9;
			parameters[144].Value = model.OtherString10;
			parameters[145].Value = model.OtherString11;
			parameters[146].Value = model.OtherString12;
			parameters[147].Value = model.OtherString13;
			parameters[148].Value = model.OtherString14;
			parameters[149].Value = model.OtherString15;
			parameters[150].Value = model.OtherText1;
			parameters[151].Value = model.OtherText2;
			parameters[152].Value = model.OtherText3;
			parameters[153].Value = model.OtherText4;
			parameters[154].Value = model.OtherText5;
			parameters[155].Value = model.MemTypeIDs1;
			parameters[156].Value = model.MemTypeIDs2;
			parameters[157].Value = model.MemTypeIDs3;
			parameters[158].Value = model.MemTypeIDs4;
			parameters[159].Value = model.MemTypeIDs5;
			parameters[160].Value = model.MemTypeIDs6;
			parameters[161].Value = model.MemTypeIDs7;
			parameters[162].Value = model.MemTypeIDs8;
			parameters[163].Value = model.MemTypeIDs9;
			parameters[164].Value = model.MemTypeIDs10;
			parameters[165].Value = model.MemTypeIDs11;
			parameters[166].Value = model.MemTypeIDs12;
			parameters[167].Value = model.MemTypeIDs13;
			parameters[168].Value = model.MemTypeIDs14;
			parameters[169].Value = model.MemTypeIDs15;
			parameters[170].Value = model.MemTypeIDs;
			parameters[171].Value = model.MemTypeIDCount;
			parameters[172].Value = model.MemTypeIDs7AttrIDS;

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
		public bool Update(WebSite.Model.Mod_UserApply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_UserApply set ");
			strSql.Append("Model=@Model,");
			strSql.Append("UserID=@UserID,");
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
			strSql.Append("PicSmall=@PicSmall,");
			strSql.Append("PicBig=@PicBig,");
			strSql.Append("State=@State,");
			strSql.Append("IsFreeBroker=@IsFreeBroker,");
			strSql.Append("IsShop=@IsShop,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("TotalIntegral=@TotalIntegral,");
			strSql.Append("FreezeIntegral=@FreezeIntegral,");
			strSql.Append("IntegralSell=@IntegralSell,");
			strSql.Append("IntegralSellFreeze=@IntegralSellFreeze,");
			strSql.Append("Money=@Money,");
			strSql.Append("ConsumptionMoney=@ConsumptionMoney,");
			strSql.Append("FreezeMoney=@FreezeMoney,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("LevelID=@LevelID,");
			strSql.Append("LevelClass=@LevelClass,");
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
			strSql.Append("HomeUrl=@HomeUrl,");
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
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("CommentCount=@CommentCount,");
			strSql.Append("FabulousCount=@FabulousCount,");
			strSql.Append("ReportCount=@ReportCount,");
			strSql.Append("FollowCount=@FollowCount,");
			strSql.Append("FansCount=@FansCount,");
			strSql.Append("UserRemarks=@UserRemarks,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("IsNeedAudit=@IsNeedAudit,");
			strSql.Append("PointAllmoney=@PointAllmoney,");
			strSql.Append("PointAllIntegral=@PointAllIntegral,");
			strSql.Append("MboxAllmoney=@MboxAllmoney,");
			strSql.Append("MboxAllIntegral=@MboxAllIntegral,");
			strSql.Append("ActionCount=@ActionCount,");
			strSql.Append("MemberMessageids=@MemberMessageids,");
			strSql.Append("Icard=@Icard,");
			strSql.Append("IcardUrl=@IcardUrl,");
			strSql.Append("IcardUrl2=@IcardUrl2,");
			strSql.Append("Qq=@Qq,");
			strSql.Append("WeiXin=@WeiXin,");
			strSql.Append("CurrentResidence=@CurrentResidence,");
			strSql.Append("IsPublic=@IsPublic,");
			strSql.Append("AuditState=@AuditState,");
			strSql.Append("AuthenticationID=@AuthenticationID,");
			strSql.Append("AuthenticationName=@AuthenticationName,");
			strSql.Append("FaHao=@FaHao,");
			strSql.Append("GYShiFu=@GYShiFu,");
			strSql.Append("GYDaoChang=@GYDaoChang,");
			strSql.Append("GYYear=@GYYear,");
			strSql.Append("Enterprise=@Enterprise,");
			strSql.Append("EnterpriseNum=@EnterpriseNum,");
			strSql.Append("EnterpriseUrl=@EnterpriseUrl,");
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
			strSql.Append("DCAddress=@DCAddress,");
			strSql.Append("DCAttribute=@DCAttribute,");
			strSql.Append("QualificationsUrl=@QualificationsUrl,");
			strSql.Append("Remarks=@Remarks,");
			strSql.Append("Abbot=@Abbot,");
			strSql.Append("AbbotIcard=@AbbotIcard,");
			strSql.Append("AbbotUrl=@AbbotUrl,");
			strSql.Append("AbbotUrl2=@AbbotUrl2,");
			strSql.Append("AbbotMobile=@AbbotMobile,");
			strSql.Append("DCUserName=@DCUserName,");
			strSql.Append("DCMobile=@DCMobile,");
			strSql.Append("BuddhistMonksM=@BuddhistMonksM,");
			strSql.Append("BuddhistMonksW=@BuddhistMonksW,");
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
			strSql.Append("OtherInt11=@OtherInt11,");
			strSql.Append("OtherInt12=@OtherInt12,");
			strSql.Append("OtherInt13=@OtherInt13,");
			strSql.Append("OtherInt14=@OtherInt14,");
			strSql.Append("OtherInt15=@OtherInt15,");
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
			strSql.Append("OtherString11=@OtherString11,");
			strSql.Append("OtherString12=@OtherString12,");
			strSql.Append("OtherString13=@OtherString13,");
			strSql.Append("OtherString14=@OtherString14,");
			strSql.Append("OtherString15=@OtherString15,");
			strSql.Append("OtherText1=@OtherText1,");
			strSql.Append("OtherText2=@OtherText2,");
			strSql.Append("OtherText3=@OtherText3,");
			strSql.Append("OtherText4=@OtherText4,");
			strSql.Append("OtherText5=@OtherText5,");
			strSql.Append("MemTypeIDs1=@MemTypeIDs1,");
			strSql.Append("MemTypeIDs2=@MemTypeIDs2,");
			strSql.Append("MemTypeIDs3=@MemTypeIDs3,");
			strSql.Append("MemTypeIDs4=@MemTypeIDs4,");
			strSql.Append("MemTypeIDs5=@MemTypeIDs5,");
			strSql.Append("MemTypeIDs6=@MemTypeIDs6,");
			strSql.Append("MemTypeIDs7=@MemTypeIDs7,");
			strSql.Append("MemTypeIDs8=@MemTypeIDs8,");
			strSql.Append("MemTypeIDs9=@MemTypeIDs9,");
			strSql.Append("MemTypeIDs10=@MemTypeIDs10,");
			strSql.Append("MemTypeIDs11=@MemTypeIDs11,");
			strSql.Append("MemTypeIDs12=@MemTypeIDs12,");
			strSql.Append("MemTypeIDs13=@MemTypeIDs13,");
			strSql.Append("MemTypeIDs14=@MemTypeIDs14,");
			strSql.Append("MemTypeIDs15=@MemTypeIDs15,");
			strSql.Append("MemTypeIDs=@MemTypeIDs,");
			strSql.Append("MemTypeIDCount=@MemTypeIDCount,");
			strSql.Append("MemTypeIDs7AttrIDS=@MemTypeIDs7AttrIDS");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@RealName", SqlDbType.NVarChar,200),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@PayPassword", SqlDbType.VarChar,200),
					new SqlParameter("@Problem", SqlDbType.VarChar,200),
					new SqlParameter("@Answer", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,200),
					new SqlParameter("@BirthDate", SqlDbType.VarChar,50),
					new SqlParameter("@Image", SqlDbType.VarChar,500),
					new SqlParameter("@PicSmall", SqlDbType.VarChar,500),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsFreeBroker", SqlDbType.Int,4),
					new SqlParameter("@IsShop", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@TotalIntegral", SqlDbType.Int,4),
					new SqlParameter("@FreezeIntegral", SqlDbType.Int,4),
					new SqlParameter("@IntegralSell", SqlDbType.Int,4),
					new SqlParameter("@IntegralSellFreeze", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@ConsumptionMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FreezeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@LevelClass", SqlDbType.VarChar,50),
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
					new SqlParameter("@Address", SqlDbType.NVarChar,500),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Contact", SqlDbType.NVarChar,200),
					new SqlParameter("@HomeUrl", SqlDbType.VarChar,200),
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
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@FollowCount", SqlDbType.Int,4),
					new SqlParameter("@FansCount", SqlDbType.Int,4),
					new SqlParameter("@UserRemarks", SqlDbType.Text),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@IsNeedAudit", SqlDbType.Int,4),
					new SqlParameter("@PointAllmoney", SqlDbType.Int,4),
					new SqlParameter("@PointAllIntegral", SqlDbType.Int,4),
					new SqlParameter("@MboxAllmoney", SqlDbType.Int,4),
					new SqlParameter("@MboxAllIntegral", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@MemberMessageids", SqlDbType.VarChar,500),
					new SqlParameter("@Icard", SqlDbType.VarChar,50),
					new SqlParameter("@IcardUrl", SqlDbType.VarChar,200),
					new SqlParameter("@IcardUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXin", SqlDbType.VarChar,200),
					new SqlParameter("@CurrentResidence", SqlDbType.VarChar,200),
					new SqlParameter("@IsPublic", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@AuthenticationID", SqlDbType.Int,4),
					new SqlParameter("@AuthenticationName", SqlDbType.VarChar,50),
					new SqlParameter("@FaHao", SqlDbType.NVarChar,200),
					new SqlParameter("@GYShiFu", SqlDbType.NVarChar,100),
					new SqlParameter("@GYDaoChang", SqlDbType.NVarChar,200),
					new SqlParameter("@GYYear", SqlDbType.VarChar,50),
					new SqlParameter("@Enterprise", SqlDbType.NVarChar,200),
					new SqlParameter("@EnterpriseNum", SqlDbType.VarChar,200),
					new SqlParameter("@EnterpriseUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Industry", SqlDbType.VarChar,100),
					new SqlParameter("@RegAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@RegUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Header", SqlDbType.VarChar,200),
					new SqlParameter("@HeaderMobile", SqlDbType.VarChar,100),
					new SqlParameter("@CJDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@CJYear", SqlDbType.VarChar,50),
					new SqlParameter("@Masters", SqlDbType.NVarChar,50),
					new SqlParameter("@CZDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@XZDaoChang", SqlDbType.NVarChar,100),
					new SqlParameter("@IsOrdained", SqlDbType.Int,4),
					new SqlParameter("@OrdaineUrl1", SqlDbType.VarChar,200),
					new SqlParameter("@OrdaineUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@PopularName", SqlDbType.NVarChar,100),
					new SqlParameter("@DCAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@DCAttribute", SqlDbType.VarChar,100),
					new SqlParameter("@QualificationsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,500),
					new SqlParameter("@Abbot", SqlDbType.NVarChar,100),
					new SqlParameter("@AbbotIcard", SqlDbType.VarChar,100),
					new SqlParameter("@AbbotUrl", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotUrl2", SqlDbType.VarChar,200),
					new SqlParameter("@AbbotMobile", SqlDbType.VarChar,100),
					new SqlParameter("@DCUserName", SqlDbType.NVarChar,100),
					new SqlParameter("@DCMobile", SqlDbType.VarChar,100),
					new SqlParameter("@BuddhistMonksM", SqlDbType.Int,4),
					new SqlParameter("@BuddhistMonksW", SqlDbType.Int,4),
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
					new SqlParameter("@OtherInt11", SqlDbType.Int,4),
					new SqlParameter("@OtherInt12", SqlDbType.Int,4),
					new SqlParameter("@OtherInt13", SqlDbType.Int,4),
					new SqlParameter("@OtherInt14", SqlDbType.Int,4),
					new SqlParameter("@OtherInt15", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.NText),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString11", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString12", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString13", SqlDbType.NVarChar,200),
					new SqlParameter("@OtherString14", SqlDbType.NVarChar,500),
					new SqlParameter("@OtherString15", SqlDbType.NVarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.Text),
					new SqlParameter("@OtherText5", SqlDbType.Text),
					new SqlParameter("@MemTypeIDs1", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs2", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs3", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs4", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs5", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs6", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs7", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs8", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs9", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs10", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs11", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs12", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs13", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs14", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs15", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs", SqlDbType.VarChar,500),
					new SqlParameter("@MemTypeIDCount", SqlDbType.Int,4),
					new SqlParameter("@MemTypeIDs7AttrIDS", SqlDbType.VarChar,500),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.UserID;
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
			parameters[13].Value = model.PicSmall;
			parameters[14].Value = model.PicBig;
			parameters[15].Value = model.State;
			parameters[16].Value = model.IsFreeBroker;
			parameters[17].Value = model.IsShop;
			parameters[18].Value = model.Integral;
			parameters[19].Value = model.TotalIntegral;
			parameters[20].Value = model.FreezeIntegral;
			parameters[21].Value = model.IntegralSell;
			parameters[22].Value = model.IntegralSellFreeze;
			parameters[23].Value = model.Money;
			parameters[24].Value = model.ConsumptionMoney;
			parameters[25].Value = model.FreezeMoney;
			parameters[26].Value = model.TypeID;
			parameters[27].Value = model.LevelID;
			parameters[28].Value = model.LevelClass;
			parameters[29].Value = model.LevelName;
			parameters[30].Value = model.LevelIntegral;
			parameters[31].Value = model.LevelMoney;
			parameters[32].Value = model.ModifyDate;
			parameters[33].Value = model.OrderBy;
			parameters[34].Value = model.Email;
			parameters[35].Value = model.EmailCode;
			parameters[36].Value = model.EmailAudit;
			parameters[37].Value = model.EmailAuditDate;
			parameters[38].Value = model.Countries;
			parameters[39].Value = model.Province;
			parameters[40].Value = model.City;
			parameters[41].Value = model.Region;
			parameters[42].Value = model.Address;
			parameters[43].Value = model.Mobile;
			parameters[44].Value = model.Contact;
			parameters[45].Value = model.HomeUrl;
			parameters[46].Value = model.NewLoginIP;
			parameters[47].Value = model.NewLoginDate;
			parameters[48].Value = model.LoginIP;
			parameters[49].Value = model.LoginDate;
			parameters[50].Value = model.LoginCount;
			parameters[51].Value = model.RegisterIP;
			parameters[52].Value = model.RegisterDate;
			parameters[53].Value = model.UnionID;
			parameters[54].Value = model.SignCount;
			parameters[55].Value = model.SignDate;
			parameters[56].Value = model.BrowseCount;
			parameters[57].Value = model.CommentCount;
			parameters[58].Value = model.FabulousCount;
			parameters[59].Value = model.ReportCount;
			parameters[60].Value = model.FollowCount;
			parameters[61].Value = model.FansCount;
			parameters[62].Value = model.UserRemarks;
			parameters[63].Value = model.WebSiteID;
			parameters[64].Value = model.IsNeedAudit;
			parameters[65].Value = model.PointAllmoney;
			parameters[66].Value = model.PointAllIntegral;
			parameters[67].Value = model.MboxAllmoney;
			parameters[68].Value = model.MboxAllIntegral;
			parameters[69].Value = model.ActionCount;
			parameters[70].Value = model.MemberMessageids;
			parameters[71].Value = model.Icard;
			parameters[72].Value = model.IcardUrl;
			parameters[73].Value = model.IcardUrl2;
			parameters[74].Value = model.Qq;
			parameters[75].Value = model.WeiXin;
			parameters[76].Value = model.CurrentResidence;
			parameters[77].Value = model.IsPublic;
			parameters[78].Value = model.AuditState;
			parameters[79].Value = model.AuthenticationID;
			parameters[80].Value = model.AuthenticationName;
			parameters[81].Value = model.FaHao;
			parameters[82].Value = model.GYShiFu;
			parameters[83].Value = model.GYDaoChang;
			parameters[84].Value = model.GYYear;
			parameters[85].Value = model.Enterprise;
			parameters[86].Value = model.EnterpriseNum;
			parameters[87].Value = model.EnterpriseUrl;
			parameters[88].Value = model.Industry;
			parameters[89].Value = model.RegAddress;
			parameters[90].Value = model.RegUrl;
			parameters[91].Value = model.Header;
			parameters[92].Value = model.HeaderMobile;
			parameters[93].Value = model.CJDaoChang;
			parameters[94].Value = model.CJYear;
			parameters[95].Value = model.Masters;
			parameters[96].Value = model.CZDaoChang;
			parameters[97].Value = model.XZDaoChang;
			parameters[98].Value = model.IsOrdained;
			parameters[99].Value = model.OrdaineUrl1;
			parameters[100].Value = model.OrdaineUrl2;
			parameters[101].Value = model.PopularName;
			parameters[102].Value = model.DCAddress;
			parameters[103].Value = model.DCAttribute;
			parameters[104].Value = model.QualificationsUrl;
			parameters[105].Value = model.Remarks;
			parameters[106].Value = model.Abbot;
			parameters[107].Value = model.AbbotIcard;
			parameters[108].Value = model.AbbotUrl;
			parameters[109].Value = model.AbbotUrl2;
			parameters[110].Value = model.AbbotMobile;
			parameters[111].Value = model.DCUserName;
			parameters[112].Value = model.DCMobile;
			parameters[113].Value = model.BuddhistMonksM;
			parameters[114].Value = model.BuddhistMonksW;
			parameters[115].Value = model.BuddhistMonksCount;
			parameters[116].Value = model.BankName;
			parameters[117].Value = model.BankICard;
			parameters[118].Value = model.Bank;
			parameters[119].Value = model.CardNum;
			parameters[120].Value = model.OtherInt1;
			parameters[121].Value = model.OtherInt2;
			parameters[122].Value = model.OtherInt3;
			parameters[123].Value = model.OtherInt4;
			parameters[124].Value = model.OtherInt5;
			parameters[125].Value = model.OtherInt6;
			parameters[126].Value = model.OtherInt7;
			parameters[127].Value = model.OtherInt8;
			parameters[128].Value = model.OtherInt9;
			parameters[129].Value = model.OtherInt10;
			parameters[130].Value = model.OtherInt11;
			parameters[131].Value = model.OtherInt12;
			parameters[132].Value = model.OtherInt13;
			parameters[133].Value = model.OtherInt14;
			parameters[134].Value = model.OtherInt15;
			parameters[135].Value = model.OtherString1;
			parameters[136].Value = model.OtherString2;
			parameters[137].Value = model.OtherString3;
			parameters[138].Value = model.OtherString4;
			parameters[139].Value = model.OtherString5;
			parameters[140].Value = model.OtherString6;
			parameters[141].Value = model.OtherString7;
			parameters[142].Value = model.OtherString8;
			parameters[143].Value = model.OtherString9;
			parameters[144].Value = model.OtherString10;
			parameters[145].Value = model.OtherString11;
			parameters[146].Value = model.OtherString12;
			parameters[147].Value = model.OtherString13;
			parameters[148].Value = model.OtherString14;
			parameters[149].Value = model.OtherString15;
			parameters[150].Value = model.OtherText1;
			parameters[151].Value = model.OtherText2;
			parameters[152].Value = model.OtherText3;
			parameters[153].Value = model.OtherText4;
			parameters[154].Value = model.OtherText5;
			parameters[155].Value = model.MemTypeIDs1;
			parameters[156].Value = model.MemTypeIDs2;
			parameters[157].Value = model.MemTypeIDs3;
			parameters[158].Value = model.MemTypeIDs4;
			parameters[159].Value = model.MemTypeIDs5;
			parameters[160].Value = model.MemTypeIDs6;
			parameters[161].Value = model.MemTypeIDs7;
			parameters[162].Value = model.MemTypeIDs8;
			parameters[163].Value = model.MemTypeIDs9;
			parameters[164].Value = model.MemTypeIDs10;
			parameters[165].Value = model.MemTypeIDs11;
			parameters[166].Value = model.MemTypeIDs12;
			parameters[167].Value = model.MemTypeIDs13;
			parameters[168].Value = model.MemTypeIDs14;
			parameters[169].Value = model.MemTypeIDs15;
			parameters[170].Value = model.MemTypeIDs;
			parameters[171].Value = model.MemTypeIDCount;
			parameters[172].Value = model.MemTypeIDs7AttrIDS;
			parameters[173].Value = model.ID;

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
			strSql.Append("delete from SW_UserApply ");
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
			strSql.Append("delete from SW_UserApply ");
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
		public WebSite.Model.Mod_UserApply GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,UserID,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,PicSmall,PicBig,State,IsFreeBroker,IsShop,Integral,TotalIntegral,FreezeIntegral,IntegralSell,IntegralSellFreeze,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelClass,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,HomeUrl,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,BrowseCount,CommentCount,FabulousCount,ReportCount,FollowCount,FansCount,UserRemarks,WebSiteID,IsNeedAudit,PointAllmoney,PointAllIntegral,MboxAllmoney,MboxAllIntegral,ActionCount,MemberMessageids,Icard,IcardUrl,IcardUrl2,Qq,WeiXin,CurrentResidence,IsPublic,AuditState,AuthenticationID,AuthenticationName,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,EnterpriseUrl,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAddress,DCAttribute,QualificationsUrl,Remarks,Abbot,AbbotIcard,AbbotUrl,AbbotUrl2,AbbotMobile,DCUserName,DCMobile,BuddhistMonksM,BuddhistMonksW,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherString11,OtherString12,OtherString13,OtherString14,OtherString15,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,MemTypeIDs1,MemTypeIDs2,MemTypeIDs3,MemTypeIDs4,MemTypeIDs5,MemTypeIDs6,MemTypeIDs7,MemTypeIDs8,MemTypeIDs9,MemTypeIDs10,MemTypeIDs11,MemTypeIDs12,MemTypeIDs13,MemTypeIDs14,MemTypeIDs15,MemTypeIDs,MemTypeIDCount,MemTypeIDs7AttrIDS from SW_UserApply ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_UserApply model=new WebSite.Model.Mod_UserApply();
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
		public WebSite.Model.Mod_UserApply DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_UserApply model=new WebSite.Model.Mod_UserApply();
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
				if(row["PicSmall"]!=null)
				{
					model.PicSmall=row["PicSmall"].ToString();
				}
				if(row["PicBig"]!=null)
				{
					model.PicBig=row["PicBig"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsFreeBroker"]!=null && row["IsFreeBroker"].ToString()!="")
				{
					model.IsFreeBroker=int.Parse(row["IsFreeBroker"].ToString());
				}
				if(row["IsShop"]!=null && row["IsShop"].ToString()!="")
				{
					model.IsShop=int.Parse(row["IsShop"].ToString());
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
				if(row["IntegralSell"]!=null && row["IntegralSell"].ToString()!="")
				{
					model.IntegralSell=int.Parse(row["IntegralSell"].ToString());
				}
				if(row["IntegralSellFreeze"]!=null && row["IntegralSellFreeze"].ToString()!="")
				{
					model.IntegralSellFreeze=int.Parse(row["IntegralSellFreeze"].ToString());
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
				if(row["LevelClass"]!=null)
				{
					model.LevelClass=row["LevelClass"].ToString();
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
				if(row["HomeUrl"]!=null)
				{
					model.HomeUrl=row["HomeUrl"].ToString();
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
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["CommentCount"]!=null && row["CommentCount"].ToString()!="")
				{
					model.CommentCount=int.Parse(row["CommentCount"].ToString());
				}
				if(row["FabulousCount"]!=null && row["FabulousCount"].ToString()!="")
				{
					model.FabulousCount=int.Parse(row["FabulousCount"].ToString());
				}
				if(row["ReportCount"]!=null && row["ReportCount"].ToString()!="")
				{
					model.ReportCount=int.Parse(row["ReportCount"].ToString());
				}
				if(row["FollowCount"]!=null && row["FollowCount"].ToString()!="")
				{
					model.FollowCount=int.Parse(row["FollowCount"].ToString());
				}
				if(row["FansCount"]!=null && row["FansCount"].ToString()!="")
				{
					model.FansCount=int.Parse(row["FansCount"].ToString());
				}
				if(row["UserRemarks"]!=null)
				{
					model.UserRemarks=row["UserRemarks"].ToString();
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["IsNeedAudit"]!=null && row["IsNeedAudit"].ToString()!="")
				{
					model.IsNeedAudit=int.Parse(row["IsNeedAudit"].ToString());
				}
				if(row["PointAllmoney"]!=null && row["PointAllmoney"].ToString()!="")
				{
					model.PointAllmoney=int.Parse(row["PointAllmoney"].ToString());
				}
				if(row["PointAllIntegral"]!=null && row["PointAllIntegral"].ToString()!="")
				{
					model.PointAllIntegral=int.Parse(row["PointAllIntegral"].ToString());
				}
				if(row["MboxAllmoney"]!=null && row["MboxAllmoney"].ToString()!="")
				{
					model.MboxAllmoney=int.Parse(row["MboxAllmoney"].ToString());
				}
				if(row["MboxAllIntegral"]!=null && row["MboxAllIntegral"].ToString()!="")
				{
					model.MboxAllIntegral=int.Parse(row["MboxAllIntegral"].ToString());
				}
				if(row["ActionCount"]!=null && row["ActionCount"].ToString()!="")
				{
					model.ActionCount=int.Parse(row["ActionCount"].ToString());
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
				if(row["IcardUrl2"]!=null)
				{
					model.IcardUrl2=row["IcardUrl2"].ToString();
				}
				if(row["Qq"]!=null)
				{
					model.Qq=row["Qq"].ToString();
				}
				if(row["WeiXin"]!=null)
				{
					model.WeiXin=row["WeiXin"].ToString();
				}
				if(row["CurrentResidence"]!=null)
				{
					model.CurrentResidence=row["CurrentResidence"].ToString();
				}
				if(row["IsPublic"]!=null && row["IsPublic"].ToString()!="")
				{
					model.IsPublic=int.Parse(row["IsPublic"].ToString());
				}
				if(row["AuditState"]!=null && row["AuditState"].ToString()!="")
				{
					model.AuditState=int.Parse(row["AuditState"].ToString());
				}
				if(row["AuthenticationID"]!=null && row["AuthenticationID"].ToString()!="")
				{
					model.AuthenticationID=int.Parse(row["AuthenticationID"].ToString());
				}
				if(row["AuthenticationName"]!=null)
				{
					model.AuthenticationName=row["AuthenticationName"].ToString();
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
				if(row["EnterpriseUrl"]!=null)
				{
					model.EnterpriseUrl=row["EnterpriseUrl"].ToString();
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
				if(row["DCAddress"]!=null)
				{
					model.DCAddress=row["DCAddress"].ToString();
				}
				if(row["DCAttribute"]!=null)
				{
					model.DCAttribute=row["DCAttribute"].ToString();
				}
				if(row["QualificationsUrl"]!=null)
				{
					model.QualificationsUrl=row["QualificationsUrl"].ToString();
				}
				if(row["Remarks"]!=null)
				{
					model.Remarks=row["Remarks"].ToString();
				}
				if(row["Abbot"]!=null)
				{
					model.Abbot=row["Abbot"].ToString();
				}
				if(row["AbbotIcard"]!=null)
				{
					model.AbbotIcard=row["AbbotIcard"].ToString();
				}
				if(row["AbbotUrl"]!=null)
				{
					model.AbbotUrl=row["AbbotUrl"].ToString();
				}
				if(row["AbbotUrl2"]!=null)
				{
					model.AbbotUrl2=row["AbbotUrl2"].ToString();
				}
				if(row["AbbotMobile"]!=null)
				{
					model.AbbotMobile=row["AbbotMobile"].ToString();
				}
				if(row["DCUserName"]!=null)
				{
					model.DCUserName=row["DCUserName"].ToString();
				}
				if(row["DCMobile"]!=null)
				{
					model.DCMobile=row["DCMobile"].ToString();
				}
				if(row["BuddhistMonksM"]!=null && row["BuddhistMonksM"].ToString()!="")
				{
					model.BuddhistMonksM=int.Parse(row["BuddhistMonksM"].ToString());
				}
				if(row["BuddhistMonksW"]!=null && row["BuddhistMonksW"].ToString()!="")
				{
					model.BuddhistMonksW=int.Parse(row["BuddhistMonksW"].ToString());
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
				if(row["OtherInt11"]!=null && row["OtherInt11"].ToString()!="")
				{
					model.OtherInt11=int.Parse(row["OtherInt11"].ToString());
				}
				if(row["OtherInt12"]!=null && row["OtherInt12"].ToString()!="")
				{
					model.OtherInt12=int.Parse(row["OtherInt12"].ToString());
				}
				if(row["OtherInt13"]!=null && row["OtherInt13"].ToString()!="")
				{
					model.OtherInt13=int.Parse(row["OtherInt13"].ToString());
				}
				if(row["OtherInt14"]!=null && row["OtherInt14"].ToString()!="")
				{
					model.OtherInt14=int.Parse(row["OtherInt14"].ToString());
				}
				if(row["OtherInt15"]!=null && row["OtherInt15"].ToString()!="")
				{
					model.OtherInt15=int.Parse(row["OtherInt15"].ToString());
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
				if(row["OtherString11"]!=null)
				{
					model.OtherString11=row["OtherString11"].ToString();
				}
				if(row["OtherString12"]!=null)
				{
					model.OtherString12=row["OtherString12"].ToString();
				}
				if(row["OtherString13"]!=null)
				{
					model.OtherString13=row["OtherString13"].ToString();
				}
				if(row["OtherString14"]!=null)
				{
					model.OtherString14=row["OtherString14"].ToString();
				}
				if(row["OtherString15"]!=null)
				{
					model.OtherString15=row["OtherString15"].ToString();
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
				if(row["MemTypeIDs1"]!=null && row["MemTypeIDs1"].ToString()!="")
				{
					model.MemTypeIDs1=int.Parse(row["MemTypeIDs1"].ToString());
				}
				if(row["MemTypeIDs2"]!=null && row["MemTypeIDs2"].ToString()!="")
				{
					model.MemTypeIDs2=int.Parse(row["MemTypeIDs2"].ToString());
				}
				if(row["MemTypeIDs3"]!=null && row["MemTypeIDs3"].ToString()!="")
				{
					model.MemTypeIDs3=int.Parse(row["MemTypeIDs3"].ToString());
				}
				if(row["MemTypeIDs4"]!=null && row["MemTypeIDs4"].ToString()!="")
				{
					model.MemTypeIDs4=int.Parse(row["MemTypeIDs4"].ToString());
				}
				if(row["MemTypeIDs5"]!=null && row["MemTypeIDs5"].ToString()!="")
				{
					model.MemTypeIDs5=int.Parse(row["MemTypeIDs5"].ToString());
				}
				if(row["MemTypeIDs6"]!=null && row["MemTypeIDs6"].ToString()!="")
				{
					model.MemTypeIDs6=int.Parse(row["MemTypeIDs6"].ToString());
				}
				if(row["MemTypeIDs7"]!=null && row["MemTypeIDs7"].ToString()!="")
				{
					model.MemTypeIDs7=int.Parse(row["MemTypeIDs7"].ToString());
				}
				if(row["MemTypeIDs8"]!=null && row["MemTypeIDs8"].ToString()!="")
				{
					model.MemTypeIDs8=int.Parse(row["MemTypeIDs8"].ToString());
				}
				if(row["MemTypeIDs9"]!=null && row["MemTypeIDs9"].ToString()!="")
				{
					model.MemTypeIDs9=int.Parse(row["MemTypeIDs9"].ToString());
				}
				if(row["MemTypeIDs10"]!=null && row["MemTypeIDs10"].ToString()!="")
				{
					model.MemTypeIDs10=int.Parse(row["MemTypeIDs10"].ToString());
				}
				if(row["MemTypeIDs11"]!=null && row["MemTypeIDs11"].ToString()!="")
				{
					model.MemTypeIDs11=int.Parse(row["MemTypeIDs11"].ToString());
				}
				if(row["MemTypeIDs12"]!=null && row["MemTypeIDs12"].ToString()!="")
				{
					model.MemTypeIDs12=int.Parse(row["MemTypeIDs12"].ToString());
				}
				if(row["MemTypeIDs13"]!=null && row["MemTypeIDs13"].ToString()!="")
				{
					model.MemTypeIDs13=int.Parse(row["MemTypeIDs13"].ToString());
				}
				if(row["MemTypeIDs14"]!=null && row["MemTypeIDs14"].ToString()!="")
				{
					model.MemTypeIDs14=int.Parse(row["MemTypeIDs14"].ToString());
				}
				if(row["MemTypeIDs15"]!=null && row["MemTypeIDs15"].ToString()!="")
				{
					model.MemTypeIDs15=int.Parse(row["MemTypeIDs15"].ToString());
				}
				if(row["MemTypeIDs"]!=null)
				{
					model.MemTypeIDs=row["MemTypeIDs"].ToString();
				}
				if(row["MemTypeIDCount"]!=null && row["MemTypeIDCount"].ToString()!="")
				{
					model.MemTypeIDCount=int.Parse(row["MemTypeIDCount"].ToString());
				}
				if(row["MemTypeIDs7AttrIDS"]!=null)
				{
					model.MemTypeIDs7AttrIDS=row["MemTypeIDs7AttrIDS"].ToString();
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
			strSql.Append("select ID,Model,UserID,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,PicSmall,PicBig,State,IsFreeBroker,IsShop,Integral,TotalIntegral,FreezeIntegral,IntegralSell,IntegralSellFreeze,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelClass,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,HomeUrl,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,BrowseCount,CommentCount,FabulousCount,ReportCount,FollowCount,FansCount,UserRemarks,WebSiteID,IsNeedAudit,PointAllmoney,PointAllIntegral,MboxAllmoney,MboxAllIntegral,ActionCount,MemberMessageids,Icard,IcardUrl,IcardUrl2,Qq,WeiXin,CurrentResidence,IsPublic,AuditState,AuthenticationID,AuthenticationName,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,EnterpriseUrl,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAddress,DCAttribute,QualificationsUrl,Remarks,Abbot,AbbotIcard,AbbotUrl,AbbotUrl2,AbbotMobile,DCUserName,DCMobile,BuddhistMonksM,BuddhistMonksW,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherString11,OtherString12,OtherString13,OtherString14,OtherString15,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,MemTypeIDs1,MemTypeIDs2,MemTypeIDs3,MemTypeIDs4,MemTypeIDs5,MemTypeIDs6,MemTypeIDs7,MemTypeIDs8,MemTypeIDs9,MemTypeIDs10,MemTypeIDs11,MemTypeIDs12,MemTypeIDs13,MemTypeIDs14,MemTypeIDs15,MemTypeIDs,MemTypeIDCount,MemTypeIDs7AttrIDS ");
			strSql.Append(" FROM SW_UserApply ");
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
			strSql.Append(" ID,Model,UserID,UserName,RealName,NiceName,Password,PayPassword,Problem,Answer,Sex,Company,BirthDate,Image,PicSmall,PicBig,State,IsFreeBroker,IsShop,Integral,TotalIntegral,FreezeIntegral,IntegralSell,IntegralSellFreeze,Money,ConsumptionMoney,FreezeMoney,TypeID,LevelID,LevelClass,LevelName,LevelIntegral,LevelMoney,ModifyDate,OrderBy,Email,EmailCode,EmailAudit,EmailAuditDate,Countries,Province,City,Region,Address,Mobile,Contact,HomeUrl,NewLoginIP,NewLoginDate,LoginIP,LoginDate,LoginCount,RegisterIP,RegisterDate,UnionID,SignCount,SignDate,BrowseCount,CommentCount,FabulousCount,ReportCount,FollowCount,FansCount,UserRemarks,WebSiteID,IsNeedAudit,PointAllmoney,PointAllIntegral,MboxAllmoney,MboxAllIntegral,ActionCount,MemberMessageids,Icard,IcardUrl,IcardUrl2,Qq,WeiXin,CurrentResidence,IsPublic,AuditState,AuthenticationID,AuthenticationName,FaHao,GYShiFu,GYDaoChang,GYYear,Enterprise,EnterpriseNum,EnterpriseUrl,Industry,RegAddress,RegUrl,Header,HeaderMobile,CJDaoChang,CJYear,Masters,CZDaoChang,XZDaoChang,IsOrdained,OrdaineUrl1,OrdaineUrl2,PopularName,DCAddress,DCAttribute,QualificationsUrl,Remarks,Abbot,AbbotIcard,AbbotUrl,AbbotUrl2,AbbotMobile,DCUserName,DCMobile,BuddhistMonksM,BuddhistMonksW,BuddhistMonksCount,BankName,BankICard,Bank,CardNum,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherString11,OtherString12,OtherString13,OtherString14,OtherString15,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,MemTypeIDs1,MemTypeIDs2,MemTypeIDs3,MemTypeIDs4,MemTypeIDs5,MemTypeIDs6,MemTypeIDs7,MemTypeIDs8,MemTypeIDs9,MemTypeIDs10,MemTypeIDs11,MemTypeIDs12,MemTypeIDs13,MemTypeIDs14,MemTypeIDs15,MemTypeIDs,MemTypeIDCount,MemTypeIDs7AttrIDS ");
			strSql.Append(" FROM SW_UserApply ");
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
			strSql.Append("select count(1) FROM SW_UserApply ");
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
        ///<summary>
        ///分页获取数据列表
        ///</summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " * from SW_UserApply where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_UserApply where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_UserApply where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_UserApply";
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

