
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_RedEnvelopesOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_RedEnvelopesOrder
	{
		public Mod_RedEnvelopesOrder()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _typeid;
		private string _typename;
		private int _total;
		private int _totalsurplus;
		private decimal _moneyall;
		private decimal _moneysurplus;
		private int _moneybigid;
		private decimal _moneybig;
		private int _isbigreceive;
		private string _blessings;
		private int _newsid;
		private int _userid;
		private string _usernickname;
		private int _ispay;
		private int _payid;
		private string _payname;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
		private int _state;
		private DateTime _adddate;
		private DateTime _startdate;
		private DateTime _enddate;
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
		/// 模型
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
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 红包总个数
		/// </summary>
		public int Total
		{
			set{ _total=value;}
			get{return _total;}
		}
		/// <summary>
		/// 剩余个数
		/// </summary>
		public int TotalSurplus
		{
			set{ _totalsurplus=value;}
			get{return _totalsurplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneyAll
		{
			set{ _moneyall=value;}
			get{return _moneyall;}
		}
		/// <summary>
		/// 红包剩余金额
		/// </summary>
		public decimal MoneySurplus
		{
			set{ _moneysurplus=value;}
			get{return _moneysurplus;}
		}
		/// <summary>
		/// 最大红包ID
		/// </summary>
		public int MoneyBigID
		{
			set{ _moneybigid=value;}
			get{return _moneybigid;}
		}
		/// <summary>
		/// 红包最大金额
		/// </summary>
		public decimal MoneyBig
		{
			set{ _moneybig=value;}
			get{return _moneybig;}
		}
		/// <summary>
		/// 最大红包是否被领取
		/// </summary>
		public int IsBigReceive
		{
			set{ _isbigreceive=value;}
			get{return _isbigreceive;}
		}
		/// <summary>
		/// 祝福语
		/// </summary>
		public string Blessings
		{
			set{ _blessings=value;}
			get{return _blessings;}
		}
		/// <summary>
		/// 新闻ID
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
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
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 支付状态
		/// </summary>
		public int IsPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
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
		/// 支付名称
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
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
		/// 支付返回单号
		/// </summary>
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
		}
		/// <summary>
		/// 支付返回金额
		/// </summary>
		public decimal PayAmount
		{
			set{ _payamount=value;}
			get{return _payamount;}
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
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime StartDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

