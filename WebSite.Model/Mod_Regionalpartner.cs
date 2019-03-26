
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Regionalpartner:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Regionalpartner
	{
		public Mod_Regionalpartner()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _type;
		private string _model;
		private string _username;
		private string _password;
		private string _realname;
		private string _mobile;
		private string _email;
		private int _parentid;
		private string _regionpath;
		private string _regionname;
		private int _regiongrade;
		private int _state;
		private DateTime _adddate;
		private string _loginip;
		private DateTime _logindate;
		private int _logincount;
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
		/// 
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
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
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionPath
		{
			set{ _regionpath=value;}
			get{return _regionpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionName
		{
			set{ _regionname=value;}
			get{return _regionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RegionGrade
		{
			set{ _regiongrade=value;}
			get{return _regiongrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginIP
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LoginDate
		{
			set{ _logindate=value;}
			get{return _logindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LoginCount
		{
			set{ _logincount=value;}
			get{return _logincount;}
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
		/// 
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

