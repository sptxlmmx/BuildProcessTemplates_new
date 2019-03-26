using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductAttrValue:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductAttrValue
	{
		public Mod_ProductAttrValue()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _productid;
		private int _productattrid;
        private string _attrtitle;
		private string _attrvalue;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
        /// 商品id
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
        /// 商品属性id
		/// </summary>
		public int ProductAttrID
		{
			set{ _productattrid=value;}
			get{return _productattrid;}
		}
        /// <summary>
        /// 商品属性标题
        /// </summary>
        public string AttrTitle
        {
            set { _attrtitle = value; }
            get { return _attrtitle; }
        }
		/// <summary>
        /// 商品属性值
		/// </summary>
		public string AttrValue
		{
			set{ _attrvalue=value;}
			get{return _attrvalue;}
		}
		#endregion Model

	}
}

