
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBrokerRefund:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBrokerRefund
	{
		public Mod_FreeBrokerRefund()
		{}
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _freebrokername;
		private string _freebrokertel;
		private int _levelid;
		private string _levelidtitle;
		private decimal _money;
		private int _payid;
		private string _payname;
		private string _info;
		private string _content1;
		private int _islookuser;
		private int _isprocess;
		private string _withdrawimage;
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
		public string FreeBrokerName
		{
			set{ _freebrokername=value;}
			get{return _freebrokername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerTel
		{
			set{ _freebrokertel=value;}
			get{return _freebrokertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LevelID
		{
			set{ _levelid=value;}
			get{return _levelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelIDTitle
		{
			set{ _levelidtitle=value;}
			get{return _levelidtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
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
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
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
		public int IsLookUser
		{
			set{ _islookuser=value;}
			get{return _islookuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsProcess
		{
			set{ _isprocess=value;}
			get{return _isprocess;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WithdrawImage
		{
			set{ _withdrawimage=value;}
			get{return _withdrawimage;}
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

