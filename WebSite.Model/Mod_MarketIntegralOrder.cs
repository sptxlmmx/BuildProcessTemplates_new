
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MarketIntegralOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MarketIntegralOrder
	{
		public Mod_MarketIntegralOrder()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _username;
		private string _nickname;
		private string _userimage;
		private string _userclass;
		private int _marketid;
		private string _markettitle;
		private int _buserid;
		private string _busername;
		private string _busernickname;
		private int _typeid;
		private string _typename;
		private int _commentcount;
		private int _reportcount;
		private int _fabulouscount;
		private int _integral;
		private decimal _money;
		private int _payid;
		private string _payname;
		private int _ispay;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
		private int _islook;
		private int _islookuser;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
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
		/// 类别模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 提交订单用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 提交订单用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 提交订单用户昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 提交订单用户头像
		/// </summary>
		public string UserImage
		{
			set{ _userimage=value;}
			get{return _userimage;}
		}
		/// <summary>
		/// 提交订单用户头像认证样式
		/// </summary>
		public string UserClass
		{
			set{ _userclass=value;}
			get{return _userclass;}
		}
		/// <summary>
		/// 积分市场ID
		/// </summary>
		public int MarketID
		{
			set{ _marketid=value;}
			get{return _marketid;}
		}
		/// <summary>
		/// 积分市场名
		/// </summary>
		public string MarketTitle
		{
			set{ _markettitle=value;}
			get{return _markettitle;}
		}
		/// <summary>
		/// 市场用户ID
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 市场用户名
		/// </summary>
		public string BUserName
		{
			set{ _busername=value;}
			get{return _busername;}
		}
		/// <summary>
		/// 市场用户昵称
		/// </summary>
		public string BUserNickName
		{
			set{ _busernickname=value;}
			get{return _busernickname;}
		}
		/// <summary>
		/// 订单类型ID
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 订单类型名
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 订单被评论次数
		/// </summary>
		public int CommentCount
		{
			set{ _commentcount=value;}
			get{return _commentcount;}
		}
		/// <summary>
		/// 订单被举报次数
		/// </summary>
		public int ReportCount
		{
			set{ _reportcount=value;}
			get{return _reportcount;}
		}
		/// <summary>
		/// 订单被点赞次数
		/// </summary>
		public int FabulousCount
		{
			set{ _fabulouscount=value;}
			get{return _fabulouscount;}
		}
		/// <summary>
		/// 订单买卖积分
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 订单总额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 行动支付方式id
		/// </summary>
		public int Payid
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 行动支付方式名称
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 是否支付
		/// </summary>
		public int IsPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
		}
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime PayDate
		{
			set{ _paydate=value;}
			get{return _paydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PayAmount
		{
			set{ _payamount=value;}
			get{return _payamount;}
		}
		/// <summary>
		/// 是否看过
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
		}
		/// <summary>
		/// 显示状态
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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

