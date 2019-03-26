
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_AlbumType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_AlbumType
	{
		public Mod_AlbumType()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _albumtypename;
		private string _model;
		private int _userid;
		private string _username;
		private string _thumburl;
		private string _originalurl;
		private string _info;
		private int _browsecount;
		private int _isvisible;
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
		/// 长字符串扩展字段
		/// </summary>
		public string AlbumTypeName
		{
			set{ _albumtypename=value;}
			get{return _albumtypename;}
		}
		/// <summary>
		/// 自定义类别模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ThumbUrl
		{
			set{ _thumburl=value;}
			get{return _thumburl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OriginalUrl
		{
			set{ _originalurl=value;}
			get{return _originalurl;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 浏览次数
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 是否可见
		/// </summary>
		public int IsVisible
		{
			set{ _isvisible=value;}
			get{return _isvisible;}
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

