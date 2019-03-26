using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductSpec:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductSpec
	{
		public Mod_ProductSpec()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _productid;
		private int _specid;
		private int _displaytype;
		private string _specname;
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
		/// 规格类型
		/// </summary>
		public int DisplayType
		{
			set{ _displaytype=value;}
			get{return _displaytype;}
		}
		/// <summary>
		/// 规格名称
		/// </summary>
		public string SpecName
		{
			set{ _specname=value;}
			get{return _specname;}
		}
		#endregion Model

	}
}

