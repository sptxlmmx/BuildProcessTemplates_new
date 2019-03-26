
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Withdraw:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Withdraw
	{
		public Mod_Withdraw()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _usernickname;
		private string _userrealname;
		private int _userbankid;
		private string _userbankname;
		private string _userbanknum;
		private string _withdrawimage;
		private int _bankid;
		private decimal _money;
		private decimal _getmoney;
		private DateTime _adddate;
		private DateTime _processdate;
		private string _weixinpaymentno;
		private string _weixindeviceiinfo;
		private int _withdrawid;
		private string _content1;
		private int _withdrawcount;
		private int _orderby;
		private int _islook;
		private int _isprocess;
		private int _islookuser;
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
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRealName
		{
			set{ _userrealname=value;}
			get{return _userrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserBankID
		{
			set{ _userbankid=value;}
			get{return _userbankid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserBankName
		{
			set{ _userbankname=value;}
			get{return _userbankname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserBankNum
		{
			set{ _userbanknum=value;}
			get{return _userbanknum;}
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
		public int BankID
		{
			set{ _bankid=value;}
			get{return _bankid;}
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
		public decimal GetMoney
		{
			set{ _getmoney=value;}
			get{return _getmoney;}
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
		public DateTime ProcessDate
		{
			set{ _processdate=value;}
			get{return _processdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeiXinPaymentNo
		{
			set{ _weixinpaymentno=value;}
			get{return _weixinpaymentno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeiXinDeviceIinfo
		{
			set{ _weixindeviceiinfo=value;}
			get{return _weixindeviceiinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WithdrawID
		{
			set{ _withdrawid=value;}
			get{return _withdrawid;}
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
		public int WithdrawCount
		{
			set{ _withdrawcount=value;}
			get{return _withdrawcount;}
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
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
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
		/// 显示状态
		/// </summary>
		public int IsLookUser
		{
			set{ _islookuser=value;}
			get{return _islookuser;}
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

