using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Admin_Role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Admin_Role
	{
		public Mod_Admin_Role()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _rolename;
		private string _rolekey;
		private int _state;
		private string _websiteidstr;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 角色权限ID
		/// </summary>
		public string RoleKey
		{
			set{ _rolekey=value;}
			get{return _rolekey;}
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
		/// 版本ID集合
		/// </summary>
		public string WebSiteIDStr
		{
			set{ _websiteidstr=value;}
			get{return _websiteidstr;}
		}
		#endregion Model

	}
}

