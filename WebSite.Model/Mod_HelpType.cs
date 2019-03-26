
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_HelpType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_HelpType
	{
		public Mod_HelpType()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _title;
		private DateTime _adddate;
		private int _orderby;
		private int _parentid;
		private string _idpath;
		private int _websiteid;
		private string _link;
		private string _info;
		private string _content;
		private int _state;
		private string _image;
		private int _displaymode;
		private string _includetype;
		private int _columnid;
		private decimal _decimals;
		private int _ischocie;
		private int _isattribute;
		private int _istemplate;
		private int _isimagetemplate;
		private string _attr1;
		private string _attr2;
		private string _attr3;
		private string _attr4;
		private int _attr5;
		private int _attr6;
		private decimal _attr7;
		private decimal _attr8;
		private string _attr9;
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
		/// 父类ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// ID路径
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
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
		/// 链接
		/// </summary>
		public string Link
		{
			set{ _link=value;}
			get{return _link;}
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
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
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
		/// 图片
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 显示模式
		/// </summary>
		public int DisplayMode
		{
			set{ _displaymode=value;}
			get{return _displaymode;}
		}
		/// <summary>
		/// 包含类型
		/// </summary>
		public string IncludeType
		{
			set{ _includetype=value;}
			get{return _includetype;}
		}
		/// <summary>
		/// 级数
		/// </summary>
		public int ColumnID
		{
			set{ _columnid=value;}
			get{return _columnid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Decimals
		{
			set{ _decimals=value;}
			get{return _decimals;}
		}
		/// <summary>
		/// 是否被选择
		/// </summary>
		public int IsChocie
		{
			set{ _ischocie=value;}
			get{return _ischocie;}
		}
		/// <summary>
		/// 是否属性选择
		/// </summary>
		public int IsAttribute
		{
			set{ _isattribute=value;}
			get{return _isattribute;}
		}
		/// <summary>
		/// 是否页面模版
		/// </summary>
		public int IsTemplate
		{
			set{ _istemplate=value;}
			get{return _istemplate;}
		}
		/// <summary>
		/// 是否图片切换模版
		/// </summary>
		public int IsImageTemplate
		{
			set{ _isimagetemplate=value;}
			get{return _isimagetemplate;}
		}
		/// <summary>
		/// 扩展string1 pc版本打赏图片
		/// </summary>
		public string Attr1
		{
			set{ _attr1=value;}
			get{return _attr1;}
		}
		/// <summary>
		/// 扩展string2
		/// </summary>
		public string Attr2
		{
			set{ _attr2=value;}
			get{return _attr2;}
		}
		/// <summary>
		/// 扩展string3 寺院中心图标样式
		/// </summary>
		public string Attr3
		{
			set{ _attr3=value;}
			get{return _attr3;}
		}
		/// <summary>
		/// 扩展string4 打赏后默认显示文字
		/// </summary>
		public string Attr4
		{
			set{ _attr4=value;}
			get{return _attr4;}
		}
		/// <summary>
		/// 扩展int1
		/// </summary>
		public int Attr5
		{
			set{ _attr5=value;}
			get{return _attr5;}
		}
		/// <summary>
		/// 扩展int2
		/// </summary>
		public int Attr6
		{
			set{ _attr6=value;}
			get{return _attr6;}
		}
		/// <summary>
		/// 扩展decimal1
		/// </summary>
		public decimal Attr7
		{
			set{ _attr7=value;}
			get{return _attr7;}
		}
		/// <summary>
		/// 扩展decimal2
		/// </summary>
		public decimal Attr8
		{
			set{ _attr8=value;}
			get{return _attr8;}
		}
		/// <summary>
		/// 扩展text1
		/// </summary>
		public string Attr9
		{
			set{ _attr9=value;}
			get{return _attr9;}
		}
		#endregion Model

	}
}

