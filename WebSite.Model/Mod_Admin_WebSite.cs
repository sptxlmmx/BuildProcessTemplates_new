
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Admin_WebSite:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Admin_WebSite
	{
		public Mod_Admin_WebSite()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _parentid;
		private string _idpath;
		private int _webstate;
		private string _closeinfo;
		private string _webname;
		private string _weburl;
		private string _homepage;
		private string _title;
		private string _keywords;
		private string _description;
		private string _emailsmtp;
		private string _emailname;
		private string _emailpwd;
		private string _receiveemail;
		private string _mobile;
		private string _telephone;
		private string _address;
		private string _copyright;
		private int _orderby;
		private int _state;
		private int _isintegral;
		private int _isadvertisement;
		private decimal _integralconversion;
		private int _integralall;
		private decimal _moneyall;
		private int _integralseeking;
		private int _integralshare;
		private int _integralrecommend;
		private int _integralregister;
		private int _integralrenews;
		private int _integralremoverenews;
		private int _integralattend;
		private int _integralcontact;
		private int _integrallimitsell;
		private decimal _integrallimitmoney;
		private decimal _integralreratio;
		private decimal _payrecratio;
		private decimal _marketreratio;
		private decimal _newsactionreratio;
		private decimal _contactreratio;
		private decimal _userattendrecratio;
		private decimal _newsrecratio;
		private string _attr1;
		private string _attr2;
		private string _attr3;
		private string _attr4;
		private int _attr5;
		private int _attr6;
		private decimal _attr7;
		private decimal _attr8;
		private string _attr9;
		private decimal _technicaservicefee;
		private decimal _securityfee;
		private decimal _withdrawred;
		private decimal _downloadappred;
		private int _downloadappredcount;
		private int _isopenred;
		private int _isopenrecommendappred;
		private int _otherint1;
		private int _otherint2;
		private int _otherint3;
		private int _otherint4;
		private int _otherint5;
		private decimal _otherdecimal1;
		private decimal _otherdecimal2;
		private decimal _otherdecimal3;
		private string _otherstring1;
		private string _otherstring2;
		private string _otherstring3;
		private string _otherstring4;
		private string _otherstring5;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 父类ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// ID路径
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
		}
		/// <summary>
		/// 网站状态
		/// </summary>
		public int WebState
		{
			set{ _webstate=value;}
			get{return _webstate;}
		}
		/// <summary>
		/// 关闭提示信息
		/// </summary>
		public string CloseInfo
		{
			set{ _closeinfo=value;}
			get{return _closeinfo;}
		}
		/// <summary>
		/// 网站名称
		/// </summary>
		public string WebName
		{
			set{ _webname=value;}
			get{return _webname;}
		}
		/// <summary>
		/// 网站访问地址
		/// </summary>
		public string WebUrl
		{
			set{ _weburl=value;}
			get{return _weburl;}
		}
		/// <summary>
		/// 首页文件
		/// </summary>
		public string HomePage
		{
			set{ _homepage=value;}
			get{return _homepage;}
		}
		/// <summary>
		/// 网站标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// SEO关键字
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// SEO描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 邮箱smtp服务器
		/// </summary>
		public string EmailSmtp
		{
			set{ _emailsmtp=value;}
			get{return _emailsmtp;}
		}
		/// <summary>
		/// 邮箱用户名
		/// </summary>
		public string EmailName
		{
			set{ _emailname=value;}
			get{return _emailname;}
		}
		/// <summary>
		/// 邮箱密码
		/// </summary>
		public string EmailPwd
		{
			set{ _emailpwd=value;}
			get{return _emailpwd;}
		}
		/// <summary>
		/// 接收的邮箱
		/// </summary>
		public string ReceiveEmail
		{
			set{ _receiveemail=value;}
			get{return _receiveemail;}
		}
		/// <summary>
		/// 网站联系手机号
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 网站联系电话
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 网站联系地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 网站版权说明
		/// </summary>
		public string Copyright
		{
			set{ _copyright=value;}
			get{return _copyright;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 是否积分兑现
		/// </summary>
		public int IsIntegral
		{
			set{ _isintegral=value;}
			get{return _isintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsAdvertisement
		{
			set{ _isadvertisement=value;}
			get{return _isadvertisement;}
		}
		/// <summary>
		/// 积分换算
		/// </summary>
		public decimal IntegralConversion
		{
			set{ _integralconversion=value;}
			get{return _integralconversion;}
		}
		/// <summary>
		/// 网站总积分
		/// </summary>
		public int IntegralAll
		{
			set{ _integralall=value;}
			get{return _integralall;}
		}
		/// <summary>
		/// 网站总金额
		/// </summary>
		public decimal MoneyAll
		{
			set{ _moneyall=value;}
			get{return _moneyall;}
		}
		/// <summary>
		/// 求师问法最佳答案奖励积分
		/// </summary>
		public int IntegralSeeking
		{
			set{ _integralseeking=value;}
			get{return _integralseeking;}
		}
		/// <summary>
		/// 分享文章所需积分
		/// </summary>
		public int IntegralShare
		{
			set{ _integralshare=value;}
			get{return _integralshare;}
		}
		/// <summary>
		/// 推荐会员所需积分
		/// </summary>
		public int IntegralRecommend
		{
			set{ _integralrecommend=value;}
			get{return _integralrecommend;}
		}
		/// <summary>
		/// 新闻推荐到频道所需积分
		/// </summary>
		public int IntegralRegister
		{
			set{ _integralregister=value;}
			get{return _integralregister;}
		}
		/// <summary>
		/// 新闻推荐到频道所需积分
		/// </summary>
		public int IntegralReNews
		{
			set{ _integralrenews=value;}
			get{return _integralrenews;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralRemoveReNews
		{
			set{ _integralremoverenews=value;}
			get{return _integralremoverenews;}
		}
		/// <summary>
		/// 旁听所需积分
		/// </summary>
		public int IntegralAttend
		{
			set{ _integralattend=value;}
			get{return _integralattend;}
		}
		/// <summary>
		/// 查看会员联系方式积分
		/// </summary>
		public int IntegralContact
		{
			set{ _integralcontact=value;}
			get{return _integralcontact;}
		}
		/// <summary>
		/// 卖家限制出售积分
		/// </summary>
		public int IntegrallimitSell
		{
			set{ _integrallimitsell=value;}
			get{return _integrallimitsell;}
		}
		/// <summary>
		/// 用户提现金额限制
		/// </summary>
		public decimal IntegrallimitMoney
		{
			set{ _integrallimitmoney=value;}
			get{return _integrallimitmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal IntegralReRatio
		{
			set{ _integralreratio=value;}
			get{return _integralreratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PayRecRatio
		{
			set{ _payrecratio=value;}
			get{return _payrecratio;}
		}
		/// <summary>
		/// 积分市场平台回收比例
		/// </summary>
		public decimal MarketReRatio
		{
			set{ _marketreratio=value;}
			get{return _marketreratio;}
		}
		/// <summary>
		/// 打赏心动平台回收比例
		/// </summary>
		public decimal NewsActionReRatio
		{
			set{ _newsactionreratio=value;}
			get{return _newsactionreratio;}
		}
		/// <summary>
		/// 查看联系方式回收比例
		/// </summary>
		public decimal ContactReRatio
		{
			set{ _contactreratio=value;}
			get{return _contactreratio;}
		}
		/// <summary>
		/// 旁听法师回收比例
		/// </summary>
		public decimal UserAttendRecRatio
		{
			set{ _userattendrecratio=value;}
			get{return _userattendrecratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NewsRecRatio
		{
			set{ _newsrecratio=value;}
			get{return _newsrecratio;}
		}
		/// <summary>
		/// 扩展string1
		/// </summary>
		public string Attr1
		{
			set{ _attr1=value;}
			get{return _attr1;}
		}
		/// <summary>
		/// 扩展string2
		/// </summary>
		public string Attr2
		{
			set{ _attr2=value;}
			get{return _attr2;}
		}
		/// <summary>
		/// 扩展string3
		/// </summary>
		public string Attr3
		{
			set{ _attr3=value;}
			get{return _attr3;}
		}
		/// <summary>
		/// 扩展string4
		/// </summary>
		public string Attr4
		{
			set{ _attr4=value;}
			get{return _attr4;}
		}
		/// <summary>
		/// 扩展int1
		/// </summary>
		public int Attr5
		{
			set{ _attr5=value;}
			get{return _attr5;}
		}
		/// <summary>
		/// 扩展int2
		/// </summary>
		public int Attr6
		{
			set{ _attr6=value;}
			get{return _attr6;}
		}
		/// <summary>
		/// 扩展decimal1
		/// </summary>
		public decimal Attr7
		{
			set{ _attr7=value;}
			get{return _attr7;}
		}
		/// <summary>
		/// 扩展decimal2
		/// </summary>
		public decimal Attr8
		{
			set{ _attr8=value;}
			get{return _attr8;}
		}
		/// <summary>
		/// 扩展text1
		/// </summary>
		public string Attr9
		{
			set{ _attr9=value;}
			get{return _attr9;}
		}
		/// <summary>
		/// 店铺技术服务费
		/// </summary>
		public decimal TechnicaServiceFee
		{
			set{ _technicaservicefee=value;}
			get{return _technicaservicefee;}
		}
		/// <summary>
		/// 店铺担保费
		/// </summary>
		public decimal SecurityFee
		{
			set{ _securityfee=value;}
			get{return _securityfee;}
		}
		/// <summary>
		/// 红包提现限制金额
		/// </summary>
		public decimal WithdrawRed
		{
			set{ _withdrawred=value;}
			get{return _withdrawred;}
		}
		/// <summary>
		/// 下载App获取红包金额
		/// </summary>
		public decimal DownloadAppRed
		{
			set{ _downloadappred=value;}
			get{return _downloadappred;}
		}
		/// <summary>
		/// 下载App获取红包个数
		/// </summary>
		public int DownloadAppRedCount
		{
			set{ _downloadappredcount=value;}
			get{return _downloadappredcount;}
		}
		/// <summary>
		/// 是否开启系统红包按钮
		/// </summary>
		public int IsOpenRed
		{
			set{ _isopenred=value;}
			get{return _isopenred;}
		}
		/// <summary>
		/// 是否开启推荐下载app送红包功能
		/// </summary>
		public int IsOpenRecommendAPPRed
		{
			set{ _isopenrecommendappred=value;}
			get{return _isopenrecommendappred;}
		}
		/// <summary>
		/// 赠送零钱红包个数
		/// </summary>
		public int OtherInt1
		{
			set{ _otherint1=value;}
			get{return _otherint1;}
		}
		/// <summary>
		/// 是否开启推荐下载app送红包
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
		public decimal OtherDecimal1
		{
			set{ _otherdecimal1=value;}
			get{return _otherdecimal1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OtherDecimal2
		{
			set{ _otherdecimal2=value;}
			get{return _otherdecimal2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OtherDecimal3
		{
			set{ _otherdecimal3=value;}
			get{return _otherdecimal3;}
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
		#endregion Model

	}
}

