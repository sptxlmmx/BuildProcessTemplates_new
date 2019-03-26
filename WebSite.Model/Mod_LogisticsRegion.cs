using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_LogisticsRegion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_LogisticsRegion
	{
		public Mod_LogisticsRegion()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _name;
		private string _description;
		private string _dllname;
		private int _iscod;
		private string _queryarray;
		private int _orderby;
		private int _state;
		private string _regionpath;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		/// LogisticsID
		/// </summary>
		public string DllName
		{
			set{ _dllname=value;}
			get{return _dllname;}
		}
		/// <summary>
		/// 是否支持货到付款
		/// </summary>
		public int IsCOD
		{
			set{ _iscod=value;}
			get{return _iscod;}
		}
		/// <summary>
		/// 计算数据
		/// </summary>
		public string QueryArray
		{
			set{ _queryarray=value;}
			get{return _queryarray;}
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
		/// 地区路径
		/// </summary>
		public string RegionPath
		{
			set{ _regionpath=value;}
			get{return _regionpath;}
		}
		#endregion Model

	}
}

