
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserFavorite:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserFavorite
	{
		public Mod_UserFavorite()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private int _productid;
		private string _productname;
		private string _image;
		private decimal _price1;
		private decimal _price2;
		private int _integral1;
		private int _integral2;
		private int _sales;
		private DateTime _adddate;
		private int _orderby;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
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
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
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
		/// 
		/// </summary>
		public int Sales
		{
			set{ _sales=value;}
			get{return _sales;}
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
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

