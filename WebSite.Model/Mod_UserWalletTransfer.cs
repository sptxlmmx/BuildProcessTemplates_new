
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserWalletTransfer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserWalletTransfer
	{
		public Mod_UserWalletTransfer()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _usernickname;
		private int _walllettypeid;
		private string _walllettypename;
		private decimal _moneytransfer;
		private decimal _moneysurplus;
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
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WallletTypeID
		{
			set{ _walllettypeid=value;}
			get{return _walllettypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WallletTypeName
		{
			set{ _walllettypename=value;}
			get{return _walllettypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneyTransfer
		{
			set{ _moneytransfer=value;}
			get{return _moneytransfer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneySurplus
		{
			set{ _moneysurplus=value;}
			get{return _moneysurplus;}
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

