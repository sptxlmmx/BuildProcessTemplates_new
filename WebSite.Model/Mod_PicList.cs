using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_PicList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_PicList
	{
		public Mod_PicList()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _typeid;
		private int _productid;
		private string _imgurl;
		private string _title;
		private string _vicetitle;
		private string _info;
		private string _thumburl;
		private string _midurl;
		private string _originalurl;
		private int _orderby;
		private int _state;
		private int _isdefault;
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
		/// 分类id
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
		/// 图片链接
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
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
		/// 副标题
		/// </summary>
		public string ViceTitle
		{
			set{ _vicetitle=value;}
			get{return _vicetitle;}
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
		/// 缩略图
		/// </summary>
		public string ThumbUrl
		{
			set{ _thumburl=value;}
			get{return _thumburl;}
		}
		/// <summary>
		/// 适中图
		/// </summary>
		public string MidUrl
		{
			set{ _midurl=value;}
			get{return _midurl;}
		}
		/// <summary>
		/// 原图
		/// </summary>
		public string OriginalUrl
		{
			set{ _originalurl=value;}
			get{return _originalurl;}
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
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 是否默认
		/// </summary>
		public int IsDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		#endregion Model

	}
}

