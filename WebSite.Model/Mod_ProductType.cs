using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductType
	{
		public Mod_ProductType()
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
		private int _specid;
		private string _specs;
		private string _link;
		private string _info;
		private string _content;
		private int _state;
		private string _image;
		private int _displaymode;
		private string _includetype;
		private int _columnid;
        private string _subtitle;
        private string _brandidstr;
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
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public int SpecID
		{
			set{ _specid=value;}
			get{return _specid;}
		}
		/// <summary>
		/// 规格集
		/// </summary>
		public string Specs
		{
			set{ _specs=value;}
			get{return _specs;}
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
        /// 副标题
        /// </summary>
        public string SubTitle
        {
            set { _subtitle = value; }
            get { return _subtitle; }
        }
        /// <summary>
        /// 品牌id集合
        /// </summary>
        public string BrandIDStr
        {
            set { _brandidstr = value; }
            get { return _brandidstr; }
        }
		#endregion Model

	}
}

