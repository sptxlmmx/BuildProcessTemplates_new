using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Message
	{
		public Mod_Message()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _title;
		private string _content;
		private string _content2;
		private int _typeid;
		private int _parentid;
		private int _userid;
		private string _username;
		private string _name;
		private string _sex;
		private string _email;
		private string _tel;
		private string _company;
		private string _zip;
		private string _address;
		private DateTime _adddate;
		private int _websiteid;
		private int _state;
		private string _replycontent;
		private DateTime _replydate;
		private int _islook;
		private int _fromid;
		private string _fromname;
		private int _isfromlook;
		private int _toid;
		private string _toname;
		private int _istolook;
		private int _istop;
		private int _orderby;
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
		/// 标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content2
		{
			set{ _content2=value;}
			get{return _content2;}
		}
		/// <summary>
		/// 类别id
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 父类id
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
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
		/// 用户账户
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 公司名称
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zip
		{
			set{ _zip=value;}
			get{return _zip;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
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
		/// 版本
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
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
		/// 回复内容
		/// </summary>
		public string ReplyContent
		{
			set{ _replycontent=value;}
			get{return _replycontent;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime ReplyDate
		{
			set{ _replydate=value;}
			get{return _replydate;}
		}
		/// <summary>
		/// 是否查看
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
		}
		/// <summary>
		/// 发送人id
		/// </summary>
		public int FromID
		{
			set{ _fromid=value;}
			get{return _fromid;}
		}
		/// <summary>
		/// 发送人用户名
		/// </summary>
		public string FromName
		{
			set{ _fromname=value;}
			get{return _fromname;}
		}
		/// <summary>
		/// 发送人是否查看
		/// </summary>
		public int IsFromLook
		{
			set{ _isfromlook=value;}
			get{return _isfromlook;}
		}
		/// <summary>
		/// 接收人id
		/// </summary>
		public int ToID
		{
			set{ _toid=value;}
			get{return _toid;}
		}
		/// <summary>
		/// 接收人用户名
		/// </summary>
		public string ToName
		{
			set{ _toname=value;}
			get{return _toname;}
		}
		/// <summary>
		/// 接收人是否查看
		/// </summary>
		public int IsToLook
		{
			set{ _istolook=value;}
			get{return _istolook;}
		}
		/// <summary>
		/// 是否置顶
		/// </summary>
		public int IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		#endregion Model

	}
}

