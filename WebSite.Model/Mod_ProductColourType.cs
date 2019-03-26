
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductColourType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductColourType
	{
		public Mod_ProductColourType()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _productid;
		private string _title;
		private string _image;
		private int _integral;
		private int _integral2;
		private int _sum;
		private int _isrecommend;
		private DateTime _adddate= DateTime.Now;
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
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
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
		public int Sum
		{
			set{ _sum=value;}
			get{return _sum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsRecommend
		{
			set{ _isrecommend=value;}
			get{return _isrecommend;}
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

