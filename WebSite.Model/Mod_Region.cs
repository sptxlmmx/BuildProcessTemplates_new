using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Region:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Region
	{
		public Mod_Region()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _type;
		private int _parentid;
		private string _regionpath;
		private string _regionname;
		private int _regiongrade;
		private int _orderby;
		private int _websiteid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类型(1:默认;自定义类型)
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 父ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 区域路径
		/// </summary>
		public string RegionPath
		{
			set{ _regionpath=value;}
			get{return _regionpath;}
		}
		/// <summary>
		/// 区域名
		/// </summary>
		public string RegionName
		{
			set{ _regionname=value;}
			get{return _regionname;}
		}
		/// <summary>
		/// 深度
		/// </summary>
		public int RegionGrade
		{
			set{ _regiongrade=value;}
			get{return _regiongrade;}
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
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

