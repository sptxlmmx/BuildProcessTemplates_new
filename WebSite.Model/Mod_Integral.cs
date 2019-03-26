
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Integral:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Integral
	{
		public Mod_Integral()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _paytype;
		private int _userid;
		private string _nickname;
		private int _userlevelid;
		private int _buserid;
		private string _bnickname;
		private int _buserlevelid;
		private int _newsid;
		private int _productid;
		private string _orderno;
		private int _integral1;
		private int _integral2;
		private int _integral3;
		private decimal _money;
		private decimal _moneyres;
		private decimal _payrec;
		private decimal _websiterec;
		private int _payid;
		private string _payname;
		private int _typeid;
		private string _typename;
		private string _info;
		private string _content1;
		private DateTime _adddate;
		private int _orderby;
		private int _integralstate;
		private int _islookuser;
		private int _state;
		private int _websiteid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 积分表模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 支付模型
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserLevelID
		{
			set{ _userlevelid=value;}
			get{return _userlevelid;}
		}
		/// <summary>
		/// 参加用户ID
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 参加用户昵称
		/// </summary>
		public string BNickName
		{
			set{ _bnickname=value;}
			get{return _bnickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BUserLevelID
		{
			set{ _buserlevelid=value;}
			get{return _buserlevelid;}
		}
		/// <summary>
		/// 新闻id
		/// </summary>
		public int Newsid
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 产品id
		/// </summary>
		public int Productid
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 交易单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int Integral1
		{
			set{ _integral1=value;}
			get{return _integral1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Integral2
		{
			set{ _integral2=value;}
			get{return _integral2;}
		}
		/// <summary>
		/// 剩余积分
		/// </summary>
		public int Integral3
		{
			set{ _integral3=value;}
			get{return _integral3;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 剩余零钱
		/// </summary>
		public decimal MoneyRes
		{
			set{ _moneyres=value;}
			get{return _moneyres;}
		}
		/// <summary>
		/// 第三方支付回扣金额
		/// </summary>
		public decimal PayRec
		{
			set{ _payrec=value;}
			get{return _payrec;}
		}
		/// <summary>
		/// 平台回扣
		/// </summary>
		public decimal WebsiteRec
		{
			set{ _websiterec=value;}
			get{return _websiterec;}
		}
		/// <summary>
		/// 支付ID
		/// </summary>
		public int PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 支付名
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 支付类型
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 支付类型名称
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 积分详情
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 积分说明
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
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
		/// 积分加减状态
		/// </summary>
		public int IntegralState
		{
			set{ _integralstate=value;}
			get{return _integralstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsLookUser
		{
			set{ _islookuser=value;}
			get{return _islookuser;}
		}
		/// <summary>
		/// 显示状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 网站ID
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

