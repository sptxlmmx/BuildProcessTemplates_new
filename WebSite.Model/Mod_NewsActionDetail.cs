
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_NewsActionDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_NewsActionDetail
	{
		public Mod_NewsActionDetail()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private int _newsid;
		private string _newstitle;
		private int _newsstypeid;
		private string _newsstypename;
		private int _newsactionid;
		private string _orderno;
		private int _actionattrid;
		private string _actionattrtitle;
		private string _actionattrimage;
		private int _count;
		private int _integral;
		private int _totalintegral;
		private int _money;
		private int _totalmoney;
		private int _ispay;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
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
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewsSTypeID
		{
			set{ _newsstypeid=value;}
			get{return _newsstypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsSTypeName
		{
			set{ _newsstypename=value;}
			get{return _newsstypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewsActionID
		{
			set{ _newsactionid=value;}
			get{return _newsactionid;}
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
		public int ActionAttrID
		{
			set{ _actionattrid=value;}
			get{return _actionattrid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActionAttrTitle
		{
			set{ _actionattrtitle=value;}
			get{return _actionattrtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActionAttrImage
		{
			set{ _actionattrimage=value;}
			get{return _actionattrimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Count
		{
			set{ _count=value;}
			get{return _count;}
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
		public int Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
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
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

