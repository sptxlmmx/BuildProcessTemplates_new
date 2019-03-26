using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_SpecValue:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_SpecValue
	{
		public Mod_SpecValue()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _specid;
		private string _specvalue;
		private string _alias;
		private string _image;
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
		/// 规格id
		/// </summary>
		public int SpecID
		{
			set{ _specid=value;}
			get{return _specid;}
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
		/// 别名
		/// </summary>
		public string Alias
		{
			set{ _alias=value;}
			get{return _alias;}
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

