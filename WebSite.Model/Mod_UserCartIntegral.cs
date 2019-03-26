
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserCartIntegral:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserCartIntegral
	{
		public Mod_UserCartIntegral()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _typeid;
		private int _cartid;
		private int _productid;
		private string _productno;
		private string _productname;
		private string _productpic;
		private int _stockcount;
		private int _mincount;
		private int _skuid;
		private string _skuno;
		private string _skuspec;
		private decimal _price1;
		private decimal _price2;
		private decimal _price3;
		private decimal _price4;
		private decimal _weight;
		private int _integral;
		private int _integral2;
		private int _isfreefreight;
		private int _buycount;
		private int _userid;
		private int _state;
		private DateTime _adddate;
		private string _producturl;
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
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CartID
		{
			set{ _cartid=value;}
			get{return _cartid;}
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
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
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
		public string ProductPic
		{
			set{ _productpic=value;}
			get{return _productpic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StockCount
		{
			set{ _stockcount=value;}
			get{return _stockcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MinCount
		{
			set{ _mincount=value;}
			get{return _mincount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SkuID
		{
			set{ _skuid=value;}
			get{return _skuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SkuNo
		{
			set{ _skuno=value;}
			get{return _skuno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SkuSpec
		{
			set{ _skuspec=value;}
			get{return _skuspec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price1
		{
			set{ _price1=value;}
			get{return _price1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price4
		{
			set{ _price4=value;}
			get{return _price4;}
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
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
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
		/// 
		/// </summary>
		public int IsFreeFreight
		{
			set{ _isfreefreight=value;}
			get{return _isfreefreight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BuyCount
		{
			set{ _buycount=value;}
			get{return _buycount;}
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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
		public string ProductUrl
		{
			set{ _producturl=value;}
			get{return _producturl;}
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

