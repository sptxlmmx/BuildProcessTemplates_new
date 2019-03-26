using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Coupon:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Coupon
	{
		public Mod_Coupon()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _couponname;
		private string _couponno;
		private decimal _amount;
		private DateTime _startdate;
		private DateTime _enddate;
		private string _introduction;
		private string _reason;
		private int _isdistribution;
		private DateTime _distributiondate;
		private int _userid;
		private string _username;
		private int _orderid;
		private string _orderno;
		private int _isused;
		private DateTime _useddate;
		private DateTime _modifydate;
		private DateTime _adddate;
		private int _state;
		private string _email;
		private string _mobile;
		private int _isintegral;
		private int _integral;
		private int _minproductnum;
		private int _maxproductnum;
		private decimal _minproductprice;
		private decimal _maxproductprice;
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
		/// 优惠劵名称
		/// </summary>
		public string CouponName
		{
			set{ _couponname=value;}
			get{return _couponname;}
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
		/// 金额
		/// </summary>
		public decimal Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 结束
		/// </summary>
		public string Introduction
		{
			set{ _introduction=value;}
			get{return _introduction;}
		}
		/// <summary>
		/// 分配原因
		/// </summary>
		public string Reason
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 是否分配
		/// </summary>
		public int IsDistribution
		{
			set{ _isdistribution=value;}
			get{return _isdistribution;}
		}
		/// <summary>
		/// 分配时间
		/// </summary>
		public DateTime DistributionDate
		{
			set{ _distributiondate=value;}
			get{return _distributiondate;}
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
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 订单ID
		/// </summary>
		public int OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
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
		/// 是否使用
		/// </summary>
		public int IsUsed
		{
			set{ _isused=value;}
			get{return _isused;}
		}
		/// <summary>
		/// 使用时间
		/// </summary>
		public DateTime UsedDate
		{
			set{ _useddate=value;}
			get{return _useddate;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
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
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 邮件
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
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
		/// 是否允许积分兑换 
		/// </summary>
		public int IsIntegral
		{
			set{ _isintegral=value;}
			get{return _isintegral;}
		}
		/// <summary>
		/// 积分兑换数
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 最小商品数量
		/// </summary>
		public int MinProductNum
		{
			set{ _minproductnum=value;}
			get{return _minproductnum;}
		}
		/// <summary>
		/// 最大商品数量
		/// </summary>
		public int MaxProductNum
		{
			set{ _maxproductnum=value;}
			get{return _maxproductnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MinProductPrice
		{
			set{ _minproductprice=value;}
			get{return _minproductprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MaxProductPrice
		{
			set{ _maxproductprice=value;}
			get{return _maxproductprice;}
		}
		/// <summary>
		/// 版本
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

