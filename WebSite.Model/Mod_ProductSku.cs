using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductSku:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductSku
	{
		public Mod_ProductSku()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _skuno;
        private string _manufacturerno;
		private int _productid;
		private string _specvalueid;
		private string _specconfigid;
		private string _specconfigvalue;
		private decimal _price;
		private decimal _marketprice;
		private int _stockcount;
		private DateTime _adddate;
		private int _isdisplay;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 货号
		/// </summary>
		public string SkuNo
		{
			set{ _skuno=value;}
			get{return _skuno;}
		}
        /// <summary>
        /// 制造商型号
        /// </summary>
        public string ManufacturerNo
        {
            set { _manufacturerno = value; }
            get { return _manufacturerno; }
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
		/// 
		/// </summary>
		public string SpecValueID
		{
			set{ _specvalueid=value;}
			get{return _specvalueid;}
		}
		/// <summary>
		/// 规格配置ID集
		/// </summary>
		public string SpecConfigID
		{
			set{ _specconfigid=value;}
			get{return _specconfigid;}
		}
		/// <summary>
		/// 规格配置名称集
		/// </summary>
		public string SpecConfigValue
		{
			set{ _specconfigvalue=value;}
			get{return _specconfigvalue;}
		}
		/// <summary>
		/// 价格
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 市场价格
		/// </summary>
		public decimal MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 库存数
		/// </summary>
		public int StockCount
		{
			set{ _stockcount=value;}
			get{return _stockcount;}
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
		/// 上架
		/// </summary>
		public int IsDisplay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		#endregion Model

	}
}

