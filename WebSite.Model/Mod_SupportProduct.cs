
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_SupportProduct:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_SupportProduct
	{
		public Mod_SupportProduct()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _enname;
		private string _productname;
		private string _bigimage;
		private string _smallimage;
		private decimal _weight;
		private decimal _price;
		private string _contents;
		private string _templeuseridstr;
		private string _notpasstext;
		private int _otherint1;
		private int _otherint2;
		private string _otherstring1;
		private string _otherstring2;
		private int _statusstate;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnName
		{
			set{ _enname=value;}
			get{return _enname;}
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
		public decimal Weight
		{
			set{ _weight=value;}
			get{return _weight;}
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
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempleUserIDStr
		{
			set{ _templeuseridstr=value;}
			get{return _templeuseridstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NotPassText
		{
			set{ _notpasstext=value;}
			get{return _notpasstext;}
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
		public int StatusState
		{
			set{ _statusstate=value;}
			get{return _statusstate;}
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

