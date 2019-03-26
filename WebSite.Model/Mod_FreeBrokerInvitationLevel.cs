
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBrokerInvitationLevel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBrokerInvitationLevel
	{
		public Mod_FreeBrokerInvitationLevel()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _title;
		private decimal _invitationshop;
		private decimal _shopprofit;
		private decimal _invitationbrokerone;
		private decimal _invitationbrokertwo;
		private decimal _invitationbrokerthree;
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
		/// 邀请店铺直接收益
		/// </summary>
		public decimal InvitationShop
		{
			set{ _invitationshop=value;}
			get{return _invitationshop;}
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
		/// 邀请经纪人直接收益
		/// </summary>
		public decimal InvitationBrokerOne
		{
			set{ _invitationbrokerone=value;}
			get{return _invitationbrokerone;}
		}
		/// <summary>
		/// 邀请合伙人直接收益
		/// </summary>
		public decimal InvitationBrokerTwo
		{
			set{ _invitationbrokertwo=value;}
			get{return _invitationbrokertwo;}
		}
		/// <summary>
		/// 邀请独立董事直接收益
		/// </summary>
		public decimal InvitationBrokerThree
		{
			set{ _invitationbrokerthree=value;}
			get{return _invitationbrokerthree;}
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

