using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_OrderDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_OrderDetail
	{
		public Mod_OrderDetail()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _orderid;
		private string _orderno;
		private int _productid;
		private string _productno;
		private string _productname;
		private string _productpic;
		private int _skuid;
		private string _skuno;
		private string _skuspec;
		private int _buycount;
		private decimal _price1;
		private decimal _price2;
		private decimal _price3;
		private decimal _price4;
		private decimal _weight;
		private int _integral;
		private decimal _totalprice;
		private int _totalintegral;
		private DateTime _adddate;
        private string _producturl;
		private int _userid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单id
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
		/// 产品ID
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 货号
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 商品图片
		/// </summary>
		public string ProductPic
		{
			set{ _productpic=value;}
			get{return _productpic;}
		}
		/// <summary>
		/// 货品ID
		/// </summary>
		public int SkuID
		{
			set{ _skuid=value;}
			get{return _skuid;}
		}
		/// <summary>
		/// 货品号
		/// </summary>
		public string SkuNo
		{
			set{ _skuno=value;}
			get{return _skuno;}
		}
		/// <summary>
		/// 货品规格
		/// </summary>
		public string SkuSpec
		{
			set{ _skuspec=value;}
			get{return _skuspec;}
		}
		/// <summary>
		/// 购买数量
		/// </summary>
		public int BuyCount
		{
			set{ _buycount=value;}
			get{return _buycount;}
		}
		/// <summary>
		/// 价格1
		/// </summary>
		public decimal Price1
		{
			set{ _price1=value;}
			get{return _price1;}
		}
		/// <summary>
		/// 价格2
		/// </summary>
		public decimal Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 价格3
		/// </summary>
		public decimal Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 价格4
		/// </summary>
		public decimal Price4
		{
			set{ _price4=value;}
			get{return _price4;}
		}
		/// <summary>
		/// 重量
		/// </summary>
		public decimal Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 价格总额
		/// </summary>
		public decimal TotalPrice
		{
			set{ _totalprice=value;}
			get{return _totalprice;}
		}
		/// <summary>
		/// 积分总额
		/// </summary>
		public int TotalIntegral
		{
			set{ _totalintegral=value;}
			get{return _totalintegral;}
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
		/// 产品URL
		/// </summary>
        public string ProductUrl
		{
            set { _producturl = value; }
            get { return _producturl; }
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

