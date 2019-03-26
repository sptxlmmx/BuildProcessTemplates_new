
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserOauthConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserOauthConfig
	{
		public Mod_UserOauthConfig()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _oauth_name;
		private string _oauth_appid;
		private string _oauth_key;
		private string _oauth_returnurl;
		private DateTime _adddate;
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
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oauth_Name
		{
			set{ _oauth_name=value;}
			get{return _oauth_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oauth_appid
		{
			set{ _oauth_appid=value;}
			get{return _oauth_appid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oauth_key
		{
			set{ _oauth_key=value;}
			get{return _oauth_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oauth_returnurl
		{
			set{ _oauth_returnurl=value;}
			get{return _oauth_returnurl;}
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
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

