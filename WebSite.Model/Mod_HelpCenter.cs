using System;
using System.Data;
using System.Collections.Generic;
using WebSite.Common;
using WebSite.Model;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_HelpCenter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_HelpCenter
	{
		public Mod_HelpCenter()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _title;
		private string _content1;
		private string _content2;
		private string _introduction;
		private int _typeid;
		private int _stypeid;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _browsecount;
		private DateTime _commenddate;
		private int _state;
		private string _tags;
		private string _image;
		private int _iscommend;
		private int _istop;
		private int _isessence;
		private int _ispermissions;
		private int _websiteid;
		private string _author;
		private string _source;
		private int _commentcount;
		private string _username;
		private string _fileurl;
		private string _filename;
		private int _iscrawl;
		private int _isaudit;
		private DateTime _auditdate;
		private int _auditmember;
		private int _orderby;
		private string _citationtitle;
		private string _subtitle;
		private string _link;
		private string _titlecolor;
		private int _iscomment;
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
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
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
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
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
		/// 简介
		/// </summary>
		public string Introduction
		{
			set{ _introduction=value;}
			get{return _introduction;}
		}
		/// <summary>
		/// 已经类别ID
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 二级类别ID
		/// </summary>
		public int STypeID
		{
			set{ _stypeid=value;}
			get{return _stypeid;}
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
		/// 浏览数
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 推荐时间
		/// </summary>
		public DateTime CommendDate
		{
			set{ _commenddate=value;}
			get{return _commenddate;}
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
		/// 标签
		/// </summary>
		public string Tags
		{
			set{ _tags=value;}
			get{return _tags;}
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
		/// 精华
		/// </summary>
		public int IsEssence
		{
			set{ _isessence=value;}
			get{return _isessence;}
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
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 作者
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 来源
		/// </summary>
		public string Source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 评论数
		/// </summary>
		public int CommentCount
		{
			set{ _commentcount=value;}
			get{return _commentcount;}
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
		/// 文件链接
		/// </summary>
		public string FileURL
		{
			set{ _fileurl=value;}
			get{return _fileurl;}
		}
		/// <summary>
		/// 文件名
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 是否让搜录
		/// </summary>
		public int IsCrawl
		{
			set{ _iscrawl=value;}
			get{return _iscrawl;}
		}
		/// <summary>
		/// 审核
		/// </summary>
		public int IsAudit
		{
			set{ _isaudit=value;}
			get{return _isaudit;}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime AuditDate
		{
			set{ _auditdate=value;}
			get{return _auditdate;}
		}
		/// <summary>
		/// 审核员ID
		/// </summary>
		public int AuditMember
		{
			set{ _auditmember=value;}
			get{return _auditmember;}
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
		/// 引用标题
		/// </summary>
		public string CitationTitle
		{
			set{ _citationtitle=value;}
			get{return _citationtitle;}
		}
		/// <summary>
		/// 子标题
		/// </summary>
		public string SubTitle
		{
			set{ _subtitle=value;}
			get{return _subtitle;}
		}
		/// <summary>
		/// 链接
		/// </summary>
		public string Link
		{
			set{ _link=value;}
			get{return _link;}
		}
		/// <summary>
		/// 标题颜色
		/// </summary>
		public string TitleColor
		{
			set{ _titlecolor=value;}
			get{return _titlecolor;}
		}
		/// <summary>
		/// 是否可以评论
		/// </summary>
		public int IsComment
		{
			set{ _iscomment=value;}
			get{return _iscomment;}
		}
		#endregion Model

	}
}

