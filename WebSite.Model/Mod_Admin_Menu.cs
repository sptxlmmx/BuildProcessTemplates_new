
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Admin_Menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Admin_Menu
	{
		public Mod_Admin_Menu()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _title;
		private int _parentid;
		private string _idpath;
		private string _url;
		private int _orderby;
		private int _state;
		private int _ismanage;
		private int _websiteid;
		private int _columnid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		/// 链接
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
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
		/// 是否为管理栏目
		/// </summary>
		public int IsManage
		{
			set{ _ismanage=value;}
			get{return _ismanage;}
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
		/// 级数
		/// </summary>
		public int ColumnID
		{
			set{ _columnid=value;}
			get{return _columnid;}
		}
		#endregion Model

	}
}

