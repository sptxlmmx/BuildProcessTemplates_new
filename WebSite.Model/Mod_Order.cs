using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Order
	{
		public Mod_Order()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _shopid;
		private string _shopname;
		private int _state;
		private string _phone;
		private int _userid;
		private string _username;
		private int _totalcount;
		private decimal _totalweight;
		private decimal _totalfreight;
		private decimal _totalamount;
		private decimal _productamount;
		private decimal _orderamount;
		private int _isfreefreight;
		private string _discountreason;
		private decimal _discount;
		private decimal _discountamount;
		private decimal _lessamount;
		private decimal _addamount;
		private string _currencytype;
		private string _currencymark;
		private string _consignee;
		private string _country;
		private string _province;
		private string _city;
		private string _region;
		private string _address;
		private string _zipcode;
		private string _tel;
		private string _mobile;
		private string _signbuilding;
		private string _besttime;
		private decimal _returnamount;
		private string _returngoods;
		private string _replacement;
		private string _remark;
		private string _logisticsdllname;
		private string _logisticsname;
		private string _logisticsno;
		private int _logisticsstate;
		private DateTime _logisticsdate;
		private decimal _logisticsamount;
		private DateTime _receivingdate;
		private int _paystate;
		private string _payno;
		private string _payname;
		private string _paydllname;
		private decimal _payamount;
		private DateTime _paydate;
		private int _isinvoice;
		private string _invoicecommercial;
		private string _message;
		private DateTime _adddate;
		private int _websiteid;
		private int _subintegral;
		private int _addintegral;
		private decimal _integralamount;
		private int _couponid;
		private string _couponno;
		private decimal _couponamount;
		private string _logisticscompany;
		private string _logisticscode;
		private DateTime _completedate;
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
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 店铺ID
		/// </summary>
		public int ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 店铺名称
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
        /// （0已生成，10已确认，20已完成，30已取消,40:无效,50:退货）
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// 用户名称
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 商品数量
		/// </summary>
		public int TotalCount
		{
			set{ _totalcount=value;}
			get{return _totalcount;}
		}
		/// <summary>
		/// 总重量
		/// </summary>
		public decimal TotalWeight
		{
			set{ _totalweight=value;}
			get{return _totalweight;}
		}
		/// <summary>
		/// 总运费
		/// </summary>
		public decimal TotalFreight
		{
			set{ _totalfreight=value;}
			get{return _totalfreight;}
		}
		/// <summary>
		/// 总金额
		/// </summary>
		public decimal TotalAmount
		{
			set{ _totalamount=value;}
			get{return _totalamount;}
		}
		/// <summary>
		/// 商品金额
		/// </summary>
		public decimal ProductAmount
		{
			set{ _productamount=value;}
			get{return _productamount;}
		}
		/// <summary>
		/// 订单金额
		/// </summary>
		public decimal OrderAmount
		{
			set{ _orderamount=value;}
			get{return _orderamount;}
		}
		/// <summary>
		/// 是否免运费
		/// </summary>
		public int IsFreeFreight
		{
			set{ _isfreefreight=value;}
			get{return _isfreefreight;}
		}
		/// <summary>
		/// 折扣原因
		/// </summary>
		public string DiscountReason
		{
			set{ _discountreason=value;}
			get{return _discountreason;}
		}
		/// <summary>
		/// 折扣
		/// </summary>
		public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 折扣金额
		/// </summary>
		public decimal DiscountAmount
		{
			set{ _discountamount=value;}
			get{return _discountamount;}
		}
		/// <summary>
		/// 促销优惠金额
		/// </summary>
		public decimal LessAmount
		{
			set{ _lessamount=value;}
			get{return _lessamount;}
		}
		/// <summary>
		/// 增加金额
		/// </summary>
		public decimal AddAmount
		{
			set{ _addamount=value;}
			get{return _addamount;}
		}
		/// <summary>
		/// 货币类型
		/// </summary>
		public string CurrencyType
		{
			set{ _currencytype=value;}
			get{return _currencytype;}
		}
		/// <summary>
		/// 货币标识
		/// </summary>
		public string CurrencyMark
		{
			set{ _currencymark=value;}
			get{return _currencymark;}
		}
		/// <summary>
		/// 收货人
		/// </summary>
		public string Consignee
		{
			set{ _consignee=value;}
			get{return _consignee;}
		}
		/// <summary>
		/// 国家
		/// </summary>
		public string Country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 省
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 市
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 区
		/// </summary>
		public string Region
		{
			set{ _region=value;}
			get{return _region;}
		}
		/// <summary>
		/// 详细地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zipcode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 标志性的建筑
		/// </summary>
		public string SignBuilding
		{
			set{ _signbuilding=value;}
			get{return _signbuilding;}
		}
		/// <summary>
		/// 收货的最佳时间
		/// </summary>
		public string BestTime
		{
			set{ _besttime=value;}
			get{return _besttime;}
		}
		/// <summary>
		/// 退货金额
		/// </summary>
		public decimal ReturnAmount
		{
			set{ _returnamount=value;}
			get{return _returnamount;}
		}
		/// <summary>
		/// 退货原因
		/// </summary>
		public string ReturnGoods
		{
			set{ _returngoods=value;}
			get{return _returngoods;}
		}
		/// <summary>
		/// 换货原因
		/// </summary>
		public string Replacement
		{
			set{ _replacement=value;}
			get{return _replacement;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 物流DllName
		/// </summary>
		public string LogisticsDllName
		{
			set{ _logisticsdllname=value;}
			get{return _logisticsdllname;}
		}
		/// <summary>
		/// 物流名称
		/// </summary>
		public string LogisticsName
		{
			set{ _logisticsname=value;}
			get{return _logisticsname;}
		}
		/// <summary>
		/// 物流单号
		/// </summary>
		public string LogisticsNo
		{
			set{ _logisticsno=value;}
			get{return _logisticsno;}
		}
		/// <summary>
		/// 物流状态
		/// </summary>
		public int LogisticsState
		{
			set{ _logisticsstate=value;}
			get{return _logisticsstate;}
		}
		/// <summary>
		/// 发货时间
		/// </summary>
		public DateTime LogisticsDate
		{
			set{ _logisticsdate=value;}
			get{return _logisticsdate;}
		}
		/// <summary>
		/// 物流金额
		/// </summary>
		public decimal LogisticsAmount
		{
			set{ _logisticsamount=value;}
			get{return _logisticsamount;}
		}
		/// <summary>
		/// 收货时间
		/// </summary>
		public DateTime ReceivingDate
		{
			set{ _receivingdate=value;}
			get{return _receivingdate;}
		}
		/// <summary>
		/// 支付状态
		/// </summary>
		public int PayState
		{
			set{ _paystate=value;}
			get{return _paystate;}
		}
		/// <summary>
		/// 支付单号
		/// </summary>
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
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
		/// 支付的DllName
		/// </summary>
		public string PayDllName
		{
			set{ _paydllname=value;}
			get{return _paydllname;}
		}
		/// <summary>
		/// 支付金额
		/// </summary>
		public decimal PayAmount
		{
			set{ _payamount=value;}
			get{return _payamount;}
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
		/// 是否需要发票
		/// </summary>
		public int IsInvoice
		{
			set{ _isinvoice=value;}
			get{return _isinvoice;}
		}
		/// <summary>
		/// 发票抬头
		/// </summary>
		public string InvoiceCommercial
		{
			set{ _invoicecommercial=value;}
			get{return _invoicecommercial;}
		}
		/// <summary>
		/// 留言
		/// </summary>
		public string Message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 扣掉积分
		/// </summary>
		public int SubIntegral
		{
			set{ _subintegral=value;}
			get{return _subintegral;}
		}
		/// <summary>
		/// 增加积分
		/// </summary>
		public int AddIntegral
		{
			set{ _addintegral=value;}
			get{return _addintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal IntegralAmount
		{
			set{ _integralamount=value;}
			get{return _integralamount;}
		}
		/// <summary>
		/// 优惠劵ID
		/// </summary>
		public int CouponID
		{
			set{ _couponid=value;}
			get{return _couponid;}
		}
		/// <summary>
		/// 优惠劵编码
		/// </summary>
		public string CouponNo
		{
			set{ _couponno=value;}
			get{return _couponno;}
		}
		/// <summary>
		/// 优惠劵金额
		/// </summary>
		public decimal CouponAmount
		{
			set{ _couponamount=value;}
			get{return _couponamount;}
		}
		/// <summary>
		/// 快递公司
		/// </summary>
		public string LogisticsCompany
		{
			set{ _logisticscompany=value;}
			get{return _logisticscompany;}
		}
		/// <summary>
		/// 快递公司代码
		/// </summary>
		public string LogisticsCode
		{
			set{ _logisticscode=value;}
			get{return _logisticscode;}
		}
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime CompleteDate
		{
			set{ _completedate=value;}
			get{return _completedate;}
		}
		#endregion Model

	}
}

