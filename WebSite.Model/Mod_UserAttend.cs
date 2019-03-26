
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserAttend:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserAttend
	{
		public Mod_UserAttend()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _payid;
		private string _payname;
		private int _integral;
		private int _userid;
		private string _usernickname;
		private int _buserid;
		private string _busernickname;
		private int _newsid;
		private int _commentid;
		private DateTime _adddate;
		private int _orderby;
		private int _ispay;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
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
		/// 旁听表模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
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
		/// 支付方式id
		/// </summary>
		public int Payid
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
		/// 支付积分金额
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 旁听的用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 旁听的用户昵称
		/// </summary>
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 被旁听的用户ID
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 被旁听的用户昵称
		/// </summary>
		public string BUserNickName
		{
			set{ _busernickname=value;}
			get{return _busernickname;}
		}
		/// <summary>
		/// 旁听对应求法新闻ID
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 旁听对应的评论ID
		/// </summary>
		public int CommentID
		{
			set{ _commentid=value;}
			get{return _commentid;}
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
		/// 是否支付
		/// </summary>
		public int IsPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
		}
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime PayDate
		{
			set{ _paydate=value;}
			get{return _paydate;}
		}
		/// <summary>
		/// 支付返回单号
		/// </summary>
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
		}
		/// <summary>
		/// 支付返回金额
		/// </summary>
		public decimal PayAmount
		{
			set{ _payamount=value;}
			get{return _payamount;}
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

