
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MarketIntegral:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MarketIntegral
	{
		public Mod_MarketIntegral()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _productname;
		private int _userid;
		private string _usernickname;
		private string _username;
		private string _phone;
		private decimal _discount;
		private int _integral;
		private int _integralcount;
		private int _typeid;
		private string _typeidpath;
		private int _areaid;
		private string _areaidpath;
		private string _content1;
		private int _browsecount;
		private int _istop;
		private int _isnew;
		private int _isrecommend;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _state;
		private int _otherint1;
		private int _otherint2;
		private string _otherstring1;
		private string _otherstring2;
		private string _otherstring3;
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
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
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
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
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
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
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
		public int IntegralCount
		{
			set{ _integralcount=value;}
			get{return _integralcount;}
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
		public string TypeIDPath
		{
			set{ _typeidpath=value;}
			get{return _typeidpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AreaID
		{
			set{ _areaid=value;}
			get{return _areaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AreaIDPath
		{
			set{ _areaidpath=value;}
			get{return _areaidpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsNew
		{
			set{ _isnew=value;}
			get{return _isnew;}
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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
		public string OtherString3
		{
			set{ _otherstring3=value;}
			get{return _otherstring3;}
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

