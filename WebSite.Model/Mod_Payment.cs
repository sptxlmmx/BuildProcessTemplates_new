
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Payment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Payment
	{
		public Mod_Payment()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _dllname;
		private string _name;
		private string _description;
		private string _queryarray;
		private int _isdisplay;
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
		/// 
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
		/// 描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 接口信息
		/// </summary>
		public string QueryArray
		{
			set{ _queryarray=value;}
			get{return _queryarray;}
		}
		/// <summary>
		/// 展示
		/// </summary>
		public int IsDisplay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		/// <summary>
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

