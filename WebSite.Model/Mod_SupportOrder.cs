
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_SupportOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_SupportOrder
	{
		public Mod_SupportOrder()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _username;
		private int _productid;
		private string _productname;
		private string _bigimage;
		private string _smallimage;
		private int _euserid;
		private string _entername;
		private int _templeid;
		private string _templename;
		private decimal _weight;
		private int _sum;
		private int _integral;
		private int _totalintegral;
		private decimal _price;
		private decimal _totalprice;
		private string _contents;
		private int _ispay;
		private int _payid;
		private string _payname;
		private int _isdelivery;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
		private int _otherint1;
		private int _otherint2;
		private string _otherstring1;
		private string _otherstring2;
		private int _anonymous;
		private int _orderstate;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _signdate;
		private DateTime _modifydate;
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
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
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
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BigImage
		{
			set{ _bigimage=value;}
			get{return _bigimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SmallImage
		{
			set{ _smallimage=value;}
			get{return _smallimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EUserID
		{
			set{ _euserid=value;}
			get{return _euserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterName
		{
			set{ _entername=value;}
			get{return _entername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TempleID
		{
			set{ _templeid=value;}
			get{return _templeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempleName
		{
			set{ _templename=value;}
			get{return _templename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sum
		{
			set{ _sum=value;}
			get{return _sum;}
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
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TotalPrice
		{
			set{ _totalprice=value;}
			get{return _totalprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsDelivery
		{
			set{ _isdelivery=value;}
			get{return _isdelivery;}
		}
		/// <summary>
		/// 
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
		public int Anonymous
		{
			set{ _anonymous=value;}
			get{return _anonymous;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
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
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
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
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
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

