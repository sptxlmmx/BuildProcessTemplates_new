using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductAttr:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductAttr
	{
		public Mod_ProductAttr()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _attrname;
		private string _attrvalue;
		private int _attrtype;
		private int _attrentrytype;
		private string _image;
		private int _typeid;
		private int _parentid;
		private string _idpath;
		private int _isimage;
		private int _issearch;
		private int _istop;
		private int _orderby;
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
		/// 属性名称
		/// </summary>
		public string AttrName
		{
			set{ _attrname=value;}
			get{return _attrname;}
		}
		/// <summary>
		/// 属性值
		/// </summary>
		public string AttrValue
		{
			set{ _attrvalue=value;}
			get{return _attrvalue;}
		}
		/// <summary>
		/// 属性类型（唯一、单选、复选）
		/// </summary>
		public int AttrType
		{
			set{ _attrtype=value;}
			get{return _attrtype;}
		}
		/// <summary>
		/// 属性值录入方式
		/// </summary>
		public int AttrEntryType
		{
			set{ _attrentrytype=value;}
			get{return _attrentrytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
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
		/// 父类id
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// id路径
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
		}
		/// <summary>
		/// 是否为图片
		/// </summary>
		public int IsImage
		{
			set{ _isimage=value;}
			get{return _isimage;}
		}
		/// <summary>
		/// 是否进行筛选
		/// </summary>
		public int IsSearch
		{
			set{ _issearch=value;}
			get{return _issearch;}
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
		#endregion Model

	}
}

