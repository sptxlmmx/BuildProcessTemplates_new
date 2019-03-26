
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBrokerWallet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBrokerWallet
	{
		public Mod_FreeBrokerWallet()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _title;
		private int _userid;
		private string _usernickname;
		private int _freebrokerinvitationactionid;
		private string _freebrokerinvitationactiontitle;
		private decimal _moneytotal;
		private decimal _moneytotalfrozen;
		private decimal _money;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
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
		/// 触发收益类型ID（钱类型ID）
		/// </summary>
		public int FreeBrokerInvitationActionID
		{
			set{ _freebrokerinvitationactionid=value;}
			get{return _freebrokerinvitationactionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerInvitationActionTitle
		{
			set{ _freebrokerinvitationactiontitle=value;}
			get{return _freebrokerinvitationactiontitle;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal MoneyTotal
		{
			set{ _moneytotal=value;}
			get{return _moneytotal;}
		}
		/// <summary>
		/// 冻结金额
		/// </summary>
		public decimal MoneyTotalFrozen
		{
			set{ _moneytotalfrozen=value;}
			get{return _moneytotalfrozen;}
		}
		/// <summary>
		/// 可用金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
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

