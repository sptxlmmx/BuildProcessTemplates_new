
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBrokerOrderDetal:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBrokerOrderDetal
	{
		public Mod_FreeBrokerOrderDetal()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _usernickname;
		private int _userfreebrokerlevelid;
		private int _buserid;
		private string _busernickname;
		private int _buserfreebrokerlevelid;
		private int _freebrokerinvitationlevelid;
		private string _freebrokerinvitationlevetitle;
		private int _freebrokerinvitationactionid;
		private string _freebrokerinvitationactiontitle;
		private decimal _money;
		private decimal _moneyres;
		private int _moneystate;
		private int _payid;
		private string _payname;
		private string _info;
		private string _content1;
		private int _islookuser;
		private int _isthaw;
		private DateTime _thawdate;
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
		/// 交易模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 单号
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
		public int UserFreeBrokerLevelID
		{
			set{ _userfreebrokerlevelid=value;}
			get{return _userfreebrokerlevelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUserNickName
		{
			set{ _busernickname=value;}
			get{return _busernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BUserFreeBrokerLevelID
		{
			set{ _buserfreebrokerlevelid=value;}
			get{return _buserfreebrokerlevelid;}
		}
		/// <summary>
		/// 收益级别ID
		/// </summary>
		public int FreeBrokerInvitationLevelID
		{
			set{ _freebrokerinvitationlevelid=value;}
			get{return _freebrokerinvitationlevelid;}
		}
		/// <summary>
		/// 收益级别名称
		/// </summary>
		public string FreeBrokerInvitationLeveTitle
		{
			set{ _freebrokerinvitationlevetitle=value;}
			get{return _freebrokerinvitationlevetitle;}
		}
		/// <summary>
		/// 触发收益类型ID（钱类型ID）
		/// </summary>
		public int FreeBrokerInvitationActionID
		{
			set{ _freebrokerinvitationactionid=value;}
			get{return _freebrokerinvitationactionid;}
		}
		/// <summary>
		/// 触发收益类型标题
		/// </summary>
		public string FreeBrokerInvitationActionTitle
		{
			set{ _freebrokerinvitationactiontitle=value;}
			get{return _freebrokerinvitationactiontitle;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 用户剩余金额
		/// </summary>
		public decimal MoneyRes
		{
			set{ _moneyres=value;}
			get{return _moneyres;}
		}
		/// <summary>
		/// 收支状态（收入还是支出）
		/// </summary>
		public int MoneyState
		{
			set{ _moneystate=value;}
			get{return _moneystate;}
		}
		/// <summary>
		/// 支付方式ID
		/// </summary>
		public int PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 支付方式名称
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 明细说明
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 用户是否看了
		/// </summary>
		public int IsLookUser
		{
			set{ _islookuser=value;}
			get{return _islookuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsThaw
		{
			set{ _isthaw=value;}
			get{return _isthaw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ThawDate
		{
			set{ _thawdate=value;}
			get{return _thawdate;}
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

