
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBrokerInvitationDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBrokerInvitationDetail
	{
		public Mod_FreeBrokerInvitationDetail()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _freebrokerlevelid;
		private string _freebrokerleveltitle;
		private int _freebrokerinvitationlevelid;
		private string _freebrokerinvitationlevetitle;
		private int _freebrokerinvitationactionid;
		private string _freebrokerinvitationactiontitle;
		private decimal _money;
		private decimal _shopprofit;
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
		/// 自由合伙人级别ID
		/// </summary>
		public int FreeBrokerLevelID
		{
			set{ _freebrokerlevelid=value;}
			get{return _freebrokerlevelid;}
		}
		/// <summary>
		/// 自由合伙人级别名称
		/// </summary>
		public string FreeBrokerLevelTItle
		{
			set{ _freebrokerleveltitle=value;}
			get{return _freebrokerleveltitle;}
		}
		/// <summary>
		/// 自由合伙人邀请收益级别
		/// </summary>
		public int FreeBrokerInvitationLevelID
		{
			set{ _freebrokerinvitationlevelid=value;}
			get{return _freebrokerinvitationlevelid;}
		}
		/// <summary>
		/// 自由合伙人邀请收益名称
		/// </summary>
		public string FreeBrokerInvitationLeveTitle
		{
			set{ _freebrokerinvitationlevetitle=value;}
			get{return _freebrokerinvitationlevetitle;}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 邀请店铺销售佣金收益百分比
		/// </summary>
		public decimal ShopProfit
		{
			set{ _shopprofit=value;}
			get{return _shopprofit;}
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
		public DateTime Adddate
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

