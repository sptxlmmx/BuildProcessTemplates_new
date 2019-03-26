using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Admin_Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Admin_Log
	{
		public Mod_Admin_Log()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _username;
		private string _userip;
		private string _content;
		private DateTime _adddate;
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
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户IP
		/// </summary>
		public string UserIP
		{
			set{ _userip=value;}
			get{return _userip;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		#endregion Model

	}
}

