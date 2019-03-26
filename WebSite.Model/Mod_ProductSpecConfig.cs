using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductSpecConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductSpecConfig
	{
		public Mod_ProductSpecConfig()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _productid;
		private int _specid;
		private int _specvalueid;
		private string _specvalue;
		private int _displaytype;
		private int _displaymode;
		private string _specimage;
		private string _specproductimage;
		private string _defaultspecvalue;
		private string _defaultspecvalueimage;
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
		/// 产品id
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 规格id
		/// </summary>
		public int SpecID
		{
			set{ _specid=value;}
			get{return _specid;}
		}
		/// <summary>
		/// 规格值id
		/// </summary>
		public int SpecValueID
		{
			set{ _specvalueid=value;}
			get{return _specvalueid;}
		}
		/// <summary>
		/// 规格值
		/// </summary>
		public string SpecValue
		{
			set{ _specvalue=value;}
			get{return _specvalue;}
		}
		/// <summary>
		/// 显示类型
		/// </summary>
		public int DisplayType
		{
			set{ _displaytype=value;}
			get{return _displaytype;}
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
		/// 规格图片
		/// </summary>
		public string SpecImage
		{
			set{ _specimage=value;}
			get{return _specimage;}
		}
		/// <summary>
		/// 对应产品图片集
		/// </summary>
		public string SpecProductImage
		{
			set{ _specproductimage=value;}
			get{return _specproductimage;}
		}
		/// <summary>
		/// 默认规格值
		/// </summary>
		public string DefaultSpecValue
		{
			set{ _defaultspecvalue=value;}
			get{return _defaultspecvalue;}
		}
		/// <summary>
		/// 默认规格图片
		/// </summary>
		public string DefaultSpecValueImage
		{
			set{ _defaultspecvalueimage=value;}
			get{return _defaultspecvalueimage;}
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

