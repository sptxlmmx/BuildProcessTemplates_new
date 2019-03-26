
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MallShopUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MallShopUser
	{
		public Mod_MallShopUser()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _username;
		private string _realname;
		private string _nicename;
		private string _password;
		private string _paypassword;
		private string _problem;
		private string _answer;
		private string _sex;
		private string _company;
		private string _birthdate;
		private string _image;
		private string _picsmall;
		private string _picbig;
		private int _state;
		private int _isfreebroker;
		private int _isshop;
		private int _integral;
		private int _totalintegral;
		private int _freezeintegral;
		private int _integralsell;
		private int _integralsellfreeze;
		private decimal _money;
		private decimal _consumptionmoney;
		private decimal _freezemoney;
		private int _typeid;
		private int _levelid;
		private string _levelclass;
		private string _levelname;
		private int _levelintegral;
		private decimal _levelmoney;
		private DateTime _modifydate;
		private int _orderby=10;
		private string _email;
		private string _emailcode;
		private int _emailaudit;
		private DateTime _emailauditdate;
		private string _countries;
		private string _province;
		private string _city;
		private string _region;
		private string _address;
		private string _mobile;
		private string _contact;
		private string _homeurl;
		private string _newloginip;
		private DateTime _newlogindate;
		private string _loginip;
		private DateTime _logindate;
		private int _logincount;
		private string _registerip;
		private DateTime _registerdate;
		private string _unionid;
		private int _signcount;
		private DateTime _signdate;
		private int _browsecount;
		private int _commentcount;
		private int _fabulouscount;
		private int _reportcount;
		private int _followcount;
		private int _fanscount;
		private string _userremarks;
		private int _websiteid;
		private int _isneedaudit;
		private int _pointallmoney;
		private int _pointallintegral;
		private int _mboxallmoney;
		private int _mboxallintegral;
		private int _actioncount;
		private string _membermessageids;
		private string _icard;
		private string _icardurl;
		private string _icardurl2;
		private string _qq;
		private string _weixin;
		private string _currentresidence;
		private int _ispublic;
		private int _auditstate;
		private int _authenticationid;
		private string _authenticationname;
		private string _fahao;
		private string _gyshifu;
		private string _gydaochang;
		private string _gyyear;
		private string _enterprise;
		private string _enterprisenum;
		private string _enterpriseurl;
		private string _industry;
		private string _regaddress;
		private string _regurl;
		private string _header;
		private string _headermobile;
		private string _cjdaochang;
		private string _cjyear;
		private string _masters;
		private string _czdaochang;
		private string _xzdaochang;
		private int _isordained;
		private string _ordaineurl1;
		private string _ordaineurl2;
		private string _popularname;
		private string _dcaddress;
		private string _dcattribute;
		private string _qualificationsurl;
		private string _remarks;
		private string _abbot;
		private string _abboticard;
		private string _abboturl;
		private string _abboturl2;
		private string _abbotmobile;
		private string _dcusername;
		private string _dcmobile;
		private int _buddhistmonksm;
		private int _buddhistmonksw;
		private int _buddhistmonkscount;
		private string _bankname;
		private string _bankicard;
		private string _bank;
		private string _cardnum;
		private int _otherint1;
		private int _otherint2;
		private int _otherint3;
		private int _otherint4;
		private int _otherint5;
		private int _otherint6;
		private int _otherint7;
		private int _otherint8;
		private int _otherint9;
		private int _otherint10;
		private int _otherint11;
		private int _otherint12;
		private int _otherint13;
		private int _otherint14;
		private int _otherint15;
		private string _otherstring1;
		private string _otherstring2;
		private string _otherstring3;
		private string _otherstring4;
		private string _otherstring5;
		private string _otherstring6;
		private string _otherstring7;
		private string _otherstring8;
		private string _otherstring9;
		private string _otherstring10;
		private string _otherstring11;
		private string _otherstring12;
		private string _otherstring13;
		private string _otherstring14;
		private string _otherstring15;
		private string _othertext1;
		private string _othertext2;
		private string _othertext3;
		private string _othertext4;
		private string _othertext5;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NiceName
		{
			set{ _nicename=value;}
			get{return _nicename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayPassword
		{
			set{ _paypassword=value;}
			get{return _paypassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Problem
		{
			set{ _problem=value;}
			get{return _problem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Answer
		{
			set{ _answer=value;}
			get{return _answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BirthDate
		{
			set{ _birthdate=value;}
			get{return _birthdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicSmall
		{
			set{ _picsmall=value;}
			get{return _picsmall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicBig
		{
			set{ _picbig=value;}
			get{return _picbig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 是否为合伙人
		/// </summary>
		public int IsFreeBroker
		{
			set{ _isfreebroker=value;}
			get{return _isfreebroker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsShop
		{
			set{ _isshop=value;}
			get{return _isshop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TotalIntegral
		{
			set{ _totalintegral=value;}
			get{return _totalintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FreezeIntegral
		{
			set{ _freezeintegral=value;}
			get{return _freezeintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralSell
		{
			set{ _integralsell=value;}
			get{return _integralsell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralSellFreeze
		{
			set{ _integralsellfreeze=value;}
			get{return _integralsellfreeze;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ConsumptionMoney
		{
			set{ _consumptionmoney=value;}
			get{return _consumptionmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal FreezeMoney
		{
			set{ _freezemoney=value;}
			get{return _freezemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LevelID
		{
			set{ _levelid=value;}
			get{return _levelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelClass
		{
			set{ _levelclass=value;}
			get{return _levelclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelName
		{
			set{ _levelname=value;}
			get{return _levelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LevelIntegral
		{
			set{ _levelintegral=value;}
			get{return _levelintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LevelMoney
		{
			set{ _levelmoney=value;}
			get{return _levelmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmailCode
		{
			set{ _emailcode=value;}
			get{return _emailcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmailAudit
		{
			set{ _emailaudit=value;}
			get{return _emailaudit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EmailAuditDate
		{
			set{ _emailauditdate=value;}
			get{return _emailauditdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Countries
		{
			set{ _countries=value;}
			get{return _countries;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Region
		{
			set{ _region=value;}
			get{return _region;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HomeUrl
		{
			set{ _homeurl=value;}
			get{return _homeurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewLoginIP
		{
			set{ _newloginip=value;}
			get{return _newloginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime NewLoginDate
		{
			set{ _newlogindate=value;}
			get{return _newlogindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginIP
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LoginDate
		{
			set{ _logindate=value;}
			get{return _logindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LoginCount
		{
			set{ _logincount=value;}
			get{return _logincount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegisterIP
		{
			set{ _registerip=value;}
			get{return _registerip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RegisterDate
		{
			set{ _registerdate=value;}
			get{return _registerdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnionID
		{
			set{ _unionid=value;}
			get{return _unionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignCount
		{
			set{ _signcount=value;}
			get{return _signcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SignDate
		{
			set{ _signdate=value;}
			get{return _signdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CommentCount
		{
			set{ _commentcount=value;}
			get{return _commentcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FabulousCount
		{
			set{ _fabulouscount=value;}
			get{return _fabulouscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReportCount
		{
			set{ _reportcount=value;}
			get{return _reportcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FollowCount
		{
			set{ _followcount=value;}
			get{return _followcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FansCount
		{
			set{ _fanscount=value;}
			get{return _fanscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRemarks
		{
			set{ _userremarks=value;}
			get{return _userremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsNeedAudit
		{
			set{ _isneedaudit=value;}
			get{return _isneedaudit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PointAllmoney
		{
			set{ _pointallmoney=value;}
			get{return _pointallmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PointAllIntegral
		{
			set{ _pointallintegral=value;}
			get{return _pointallintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MboxAllmoney
		{
			set{ _mboxallmoney=value;}
			get{return _mboxallmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MboxAllIntegral
		{
			set{ _mboxallintegral=value;}
			get{return _mboxallintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ActionCount
		{
			set{ _actioncount=value;}
			get{return _actioncount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberMessageids
		{
			set{ _membermessageids=value;}
			get{return _membermessageids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Icard
		{
			set{ _icard=value;}
			get{return _icard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IcardUrl
		{
			set{ _icardurl=value;}
			get{return _icardurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IcardUrl2
		{
			set{ _icardurl2=value;}
			get{return _icardurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeiXin
		{
			set{ _weixin=value;}
			get{return _weixin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CurrentResidence
		{
			set{ _currentresidence=value;}
			get{return _currentresidence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsPublic
		{
			set{ _ispublic=value;}
			get{return _ispublic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuthenticationID
		{
			set{ _authenticationid=value;}
			get{return _authenticationid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuthenticationName
		{
			set{ _authenticationname=value;}
			get{return _authenticationname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FaHao
		{
			set{ _fahao=value;}
			get{return _fahao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GYShiFu
		{
			set{ _gyshifu=value;}
			get{return _gyshifu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GYDaoChang
		{
			set{ _gydaochang=value;}
			get{return _gydaochang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GYYear
		{
			set{ _gyyear=value;}
			get{return _gyyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Enterprise
		{
			set{ _enterprise=value;}
			get{return _enterprise;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterpriseNum
		{
			set{ _enterprisenum=value;}
			get{return _enterprisenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterpriseUrl
		{
			set{ _enterpriseurl=value;}
			get{return _enterpriseurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Industry
		{
			set{ _industry=value;}
			get{return _industry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegAddress
		{
			set{ _regaddress=value;}
			get{return _regaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegUrl
		{
			set{ _regurl=value;}
			get{return _regurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Header
		{
			set{ _header=value;}
			get{return _header;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeaderMobile
		{
			set{ _headermobile=value;}
			get{return _headermobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CJDaoChang
		{
			set{ _cjdaochang=value;}
			get{return _cjdaochang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CJYear
		{
			set{ _cjyear=value;}
			get{return _cjyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Masters
		{
			set{ _masters=value;}
			get{return _masters;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDaoChang
		{
			set{ _czdaochang=value;}
			get{return _czdaochang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XZDaoChang
		{
			set{ _xzdaochang=value;}
			get{return _xzdaochang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsOrdained
		{
			set{ _isordained=value;}
			get{return _isordained;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrdaineUrl1
		{
			set{ _ordaineurl1=value;}
			get{return _ordaineurl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrdaineUrl2
		{
			set{ _ordaineurl2=value;}
			get{return _ordaineurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PopularName
		{
			set{ _popularname=value;}
			get{return _popularname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DCAddress
		{
			set{ _dcaddress=value;}
			get{return _dcaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DCAttribute
		{
			set{ _dcattribute=value;}
			get{return _dcattribute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QualificationsUrl
		{
			set{ _qualificationsurl=value;}
			get{return _qualificationsurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Abbot
		{
			set{ _abbot=value;}
			get{return _abbot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AbbotIcard
		{
			set{ _abboticard=value;}
			get{return _abboticard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AbbotUrl
		{
			set{ _abboturl=value;}
			get{return _abboturl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AbbotUrl2
		{
			set{ _abboturl2=value;}
			get{return _abboturl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AbbotMobile
		{
			set{ _abbotmobile=value;}
			get{return _abbotmobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DCUserName
		{
			set{ _dcusername=value;}
			get{return _dcusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DCMobile
		{
			set{ _dcmobile=value;}
			get{return _dcmobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BuddhistMonksM
		{
			set{ _buddhistmonksm=value;}
			get{return _buddhistmonksm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BuddhistMonksW
		{
			set{ _buddhistmonksw=value;}
			get{return _buddhistmonksw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BuddhistMonksCount
		{
			set{ _buddhistmonkscount=value;}
			get{return _buddhistmonkscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankName
		{
			set{ _bankname=value;}
			get{return _bankname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankICard
		{
			set{ _bankicard=value;}
			get{return _bankicard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bank
		{
			set{ _bank=value;}
			get{return _bank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardNum
		{
			set{ _cardnum=value;}
			get{return _cardnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt1
		{
			set{ _otherint1=value;}
			get{return _otherint1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt2
		{
			set{ _otherint2=value;}
			get{return _otherint2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt3
		{
			set{ _otherint3=value;}
			get{return _otherint3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt4
		{
			set{ _otherint4=value;}
			get{return _otherint4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt5
		{
			set{ _otherint5=value;}
			get{return _otherint5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt6
		{
			set{ _otherint6=value;}
			get{return _otherint6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt7
		{
			set{ _otherint7=value;}
			get{return _otherint7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt8
		{
			set{ _otherint8=value;}
			get{return _otherint8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt9
		{
			set{ _otherint9=value;}
			get{return _otherint9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt10
		{
			set{ _otherint10=value;}
			get{return _otherint10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt11
		{
			set{ _otherint11=value;}
			get{return _otherint11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt12
		{
			set{ _otherint12=value;}
			get{return _otherint12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt13
		{
			set{ _otherint13=value;}
			get{return _otherint13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt14
		{
			set{ _otherint14=value;}
			get{return _otherint14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt15
		{
			set{ _otherint15=value;}
			get{return _otherint15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString1
		{
			set{ _otherstring1=value;}
			get{return _otherstring1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString2
		{
			set{ _otherstring2=value;}
			get{return _otherstring2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString3
		{
			set{ _otherstring3=value;}
			get{return _otherstring3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString4
		{
			set{ _otherstring4=value;}
			get{return _otherstring4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString5
		{
			set{ _otherstring5=value;}
			get{return _otherstring5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString6
		{
			set{ _otherstring6=value;}
			get{return _otherstring6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString7
		{
			set{ _otherstring7=value;}
			get{return _otherstring7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString8
		{
			set{ _otherstring8=value;}
			get{return _otherstring8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString9
		{
			set{ _otherstring9=value;}
			get{return _otherstring9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString10
		{
			set{ _otherstring10=value;}
			get{return _otherstring10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString11
		{
			set{ _otherstring11=value;}
			get{return _otherstring11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString12
		{
			set{ _otherstring12=value;}
			get{return _otherstring12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString13
		{
			set{ _otherstring13=value;}
			get{return _otherstring13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString14
		{
			set{ _otherstring14=value;}
			get{return _otherstring14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString15
		{
			set{ _otherstring15=value;}
			get{return _otherstring15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText1
		{
			set{ _othertext1=value;}
			get{return _othertext1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText2
		{
			set{ _othertext2=value;}
			get{return _othertext2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText3
		{
			set{ _othertext3=value;}
			get{return _othertext3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText4
		{
			set{ _othertext4=value;}
			get{return _othertext4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText5
		{
			set{ _othertext5=value;}
			get{return _othertext5;}
		}
		#endregion Model

	}
}

