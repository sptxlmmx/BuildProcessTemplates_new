
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_RedEnvelopesDetails:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_RedEnvelopesDetails
	{
		public Mod_RedEnvelopesDetails()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _typeid;
		private string _typename;
		private int _userid;
		private string _nickname;
		private int _buserid;
		private string _bnickname;
		private int _newsid;
		private string _orderno;
		private decimal _money;
		private int _payid;
		private string _payname;
		private string _info;
		private int _isbig;
		private string _content1;
		private DateTime _adddate;
		private int _orderby;
		private int _moneystate;
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
		/// 红包类型ID
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 红包类型名
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 领取用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 领取用户昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 被领取用户ID
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 被领取用户昵称
		/// </summary>
		public string BNickName
		{
			set{ _bnickname=value;}
			get{return _bnickname;}
		}
		/// <summary>
		/// 新闻id
		/// </summary>
		public int Newsid
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 交易单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
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
		/// 支付ID
		/// </summary>
		public int PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 支付名
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 红包详情
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 红包是否最大
		/// </summary>
		public int IsBIg
		{
			set{ _isbig=value;}
			get{return _isbig;}
		}
		/// <summary>
		/// 积分说明
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 红包加减状态
		/// </summary>
		public int MoneyState
		{
			set{ _moneystate=value;}
			get{return _moneystate;}
		}
		/// <summary>
		/// 用户是否看过
		/// </summary>
		public int IsLookUser
		{
			set{ _islookuser=value;}
			get{return _islookuser;}
		}
		/// <summary>
		/// 显示状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 网站ID
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

