using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MallShopBondOder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MallShopBondOder
	{
		public Mod_MallShopBondOder()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _username;
		private string _phone;
		private decimal _money;
		private int _payid;
		private string _payname;
		private int _ispay;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
		private int _isthaw;
		private int _islook;
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
		/// Model
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
		/// 用户id
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 昵称
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// 支付类型ID
		/// </summary>
		public int PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 支付类型名称
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
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
		/// 是否解冻0正常，-1解冻
		/// </summary>
		public int IsThaw
		{
			set{ _isthaw=value;}
			get{return _isthaw;}
		}
		/// <summary>
		/// 后台管理员是否看过
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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
		/// 添加时间
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
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

