
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Admin_User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Admin_User
	{
		public Mod_Admin_User()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _roleid;
		private string _username;
		private string _password;
		private string _passwordchangecode;
		private string _realname;
		private string _sex;
		private string _tel;
		private string _mobile;
		private string _qq;
		private string _email;
		private string _department;
		private string _job;
		private string _userids;
		private string _otherids;
		private int _state;
		private DateTime _adddate;
		private string _createip;
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
		/// 所属角色
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 账户
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PasswordChangeCode
		{
			set{ _passwordchangecode=value;}
			get{return _passwordchangecode;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// QQ号
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 部门
		/// </summary>
		public string Department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 职位
		/// </summary>
		public string Job
		{
			set{ _job=value;}
			get{return _job;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserIDs
		{
			set{ _userids=value;}
			get{return _userids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherIDs
		{
			set{ _otherids=value;}
			get{return _otherids;}
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
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 创建的IP
		/// </summary>
		public string CreateIP
		{
			set{ _createip=value;}
			get{return _createip;}
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
		#endregion Model

	}
}

