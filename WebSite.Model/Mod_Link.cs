using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Link:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Link
	{
		public Mod_Link()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _title;
		private string _content;
		private string _info;
		private string _tage;
		private string _image;
		private string _weburl;
		private int _linktype;
		private int _typeid;
		private int _productid;
		private int _userid;
		private string _filename;
		private string _fileurl;
		private string _filesize;
		private string _filesuffix;
		private int _websiteid;
		private int _orderby;
		private int _ispermissions;
		private int _iscommend;
		private int _istop;
		private int _browsecount;
		private int _downloadcount;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _state;
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
		/// 简介
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 标签
		/// </summary>
		public string Tage
		{
			set{ _tage=value;}
			get{return _tage;}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 链接
		/// </summary>
		public string WebUrl
		{
			set{ _weburl=value;}
			get{return _weburl;}
		}
		/// <summary>
		/// 链接类别
		/// </summary>
		public int LinkType
		{
			set{ _linktype=value;}
			get{return _linktype;}
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
		/// 产品id
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
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
		/// 文件名称
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 文件地址
		/// </summary>
		public string FileUrl
		{
			set{ _fileurl=value;}
			get{return _fileurl;}
		}
		/// <summary>
		/// 文件大小
		/// </summary>
		public string FileSize
		{
			set{ _filesize=value;}
			get{return _filesize;}
		}
		/// <summary>
		/// 文件后缀
		/// </summary>
		public string FileSuffix
		{
			set{ _filesuffix=value;}
			get{return _filesuffix;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public int IsPermissions
		{
			set{ _ispermissions=value;}
			get{return _ispermissions;}
		}
		/// <summary>
		/// 推荐
		/// </summary>
		public int IsCommend
		{
			set{ _iscommend=value;}
			get{return _iscommend;}
		}
		/// <summary>
		/// 置顶
		/// </summary>
		public int IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 浏览数
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 下载数
		/// </summary>
		public int DownloadCount
		{
			set{ _downloadcount=value;}
			get{return _downloadcount;}
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
		/// 修改时间
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

