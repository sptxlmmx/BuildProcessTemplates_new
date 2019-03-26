using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Logistics:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Logistics
	{
		public Mod_Logistics()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _dllname;
		private string _name;
		private string _logo;
		private string _link;
		private string _searchlink;
		private string _description;
		private string _version;
		private string _author;
		private decimal _freight;
		private int _iscod;
		private int _isact;
		private int _orderby;
		private int _websiteid;
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
		/// DLL名称
		/// </summary>
		public string DllName
		{
			set{ _dllname=value;}
			get{return _dllname;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// Logo
		/// </summary>
		public string Logo
		{
			set{ _logo=value;}
			get{return _logo;}
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
		/// 搜索链接
		/// </summary>
		public string SearchLink
		{
			set{ _searchlink=value;}
			get{return _searchlink;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 版本
		/// </summary>
		public string Version
		{
			set{ _version=value;}
			get{return _version;}
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
		/// 保价费用
		/// </summary>
		public decimal Freight
		{
			set{ _freight=value;}
			get{return _freight;}
		}
		/// <summary>
		/// 是否货到付款
		/// </summary>
		public int IsCOD
		{
			set{ _iscod=value;}
			get{return _iscod;}
		}
		/// <summary>
		/// 是否自定义
		/// </summary>
		public int IsACT
		{
			set{ _isact=value;}
			get{return _isact;}
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
		/// 版本
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
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

