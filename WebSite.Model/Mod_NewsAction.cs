
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_NewsAction:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_NewsAction
	{
		public Mod_NewsAction()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int _userid;
		private string _username;
		private string _nickname;
		private string _userimage;
		private string _userclass;
		private int _newsid;
		private string _newstitle;
		private int _buserid;
		private string _busername;
		private string _busernickname;
		private int _stypeid;
		private string _stypename;
		private int _othertypeid;
		private string _othertypename;
		private string _aname;
		private string _agender;
		private DateTime _abirthday;
		private string _atelphone;
		private string _aaddress;
		private string _aaddressdetail;
		private string _acontent;
		private int _browsecount;
		private int _actioncount;
		private int _commentcount;
		private int _reportcount;
		private int _fabulouscount;
		private int _aintegral;
		private decimal _amoney;
		private int _apayid;
		private string _apayname;
		private int _isopen;
		private int _ispay;
		private DateTime _paydate;
		private string _payno;
		private decimal _payamount;
		private int _islook;
		private int _isreview;
		private int _islookuser;
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
		/// 行动模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 提交行动用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 提交行动用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 提交行动用户昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 提交行动用户头像
		/// </summary>
		public string UserImage
		{
			set{ _userimage=value;}
			get{return _userimage;}
		}
		/// <summary>
		/// 提交行动用户头像认证样式
		/// </summary>
		public string UserClass
		{
			set{ _userclass=value;}
			get{return _userclass;}
		}
		/// <summary>
		/// 行动文章ID
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 行动文章标题
		/// </summary>
		public string NewsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 发布文章行动用户ID
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 发布文章行动用户名
		/// </summary>
		public string BUserName
		{
			set{ _busername=value;}
			get{return _busername;}
		}
		/// <summary>
		/// 发布文章行动昵称
		/// </summary>
		public string BUserNickName
		{
			set{ _busernickname=value;}
			get{return _busernickname;}
		}
		/// <summary>
		/// 行动类型ID
		/// </summary>
		public int STypeID
		{
			set{ _stypeid=value;}
			get{return _stypeid;}
		}
		/// <summary>
		/// 行动类型名
		/// </summary>
		public string STypeName
		{
			set{ _stypename=value;}
			get{return _stypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherTypeID
		{
			set{ _othertypeid=value;}
			get{return _othertypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherTypeName
		{
			set{ _othertypename=value;}
			get{return _othertypename;}
		}
		/// <summary>
		/// 被提交行动名字
		/// </summary>
		public string AName
		{
			set{ _aname=value;}
			get{return _aname;}
		}
		/// <summary>
		/// 被提交行动性别
		/// </summary>
		public string AGender
		{
			set{ _agender=value;}
			get{return _agender;}
		}
		/// <summary>
		/// 被提交行动出生日期
		/// </summary>
		public DateTime ABirthday
		{
			set{ _abirthday=value;}
			get{return _abirthday;}
		}
		/// <summary>
		/// 被提交行动电话
		/// </summary>
		public string ATelphone
		{
			set{ _atelphone=value;}
			get{return _atelphone;}
		}
		/// <summary>
		/// 被提交行动地址
		/// </summary>
		public string AAddress
		{
			set{ _aaddress=value;}
			get{return _aaddress;}
		}
		/// <summary>
		/// 被提交行动详细地址
		/// </summary>
		public string AAddressDetail
		{
			set{ _aaddressdetail=value;}
			get{return _aaddressdetail;}
		}
		/// <summary>
		/// 留言内容
		/// </summary>
		public string AContent
		{
			set{ _acontent=value;}
			get{return _acontent;}
		}
		/// <summary>
		/// 行动浏览次数
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 行动被回复数量
		/// </summary>
		public int ActionCount
		{
			set{ _actioncount=value;}
			get{return _actioncount;}
		}
		/// <summary>
		/// 行动评论次数
		/// </summary>
		public int CommentCount
		{
			set{ _commentcount=value;}
			get{return _commentcount;}
		}
		/// <summary>
		/// 行动举报次数
		/// </summary>
		public int ReportCount
		{
			set{ _reportcount=value;}
			get{return _reportcount;}
		}
		/// <summary>
		/// 行动点赞次数
		/// </summary>
		public int FabulousCount
		{
			set{ _fabulouscount=value;}
			get{return _fabulouscount;}
		}
		/// <summary>
		/// 行动总额
		/// </summary>
		public int AIntegral
		{
			set{ _aintegral=value;}
			get{return _aintegral;}
		}
		/// <summary>
		/// 行动总额
		/// </summary>
		public decimal AMoney
		{
			set{ _amoney=value;}
			get{return _amoney;}
		}
		/// <summary>
		/// 行动支付方式id
		/// </summary>
		public int Apayid
		{
			set{ _apayid=value;}
			get{return _apayid;}
		}
		/// <summary>
		/// 行动支付方式id
		/// </summary>
		public string ApayName
		{
			set{ _apayname=value;}
			get{return _apayname;}
		}
		/// <summary>
		/// 信息是否公开
		/// </summary>
		public int IsOpen
		{
			set{ _isopen=value;}
			get{return _isopen;}
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
		/// 是否看过
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
		}
		/// <summary>
		/// 是否审核通过
		/// </summary>
		public int IsReview
		{
			set{ _isreview=value;}
			get{return _isreview;}
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
		/// 显示状态
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

