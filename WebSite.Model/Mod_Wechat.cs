
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Wechat:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Wechat
	{
		public Mod_Wechat()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _wechat_name;
		private string _wechat_key;
		private string _wechat_url;
		private string _wechat_token;
		private string _wechat_appid;
		private string _wechat_appsecret;
		private string _wechat_originalid;
		private string _content1;
		private DateTime _adddate;
		private int _state;
		private int _userid;
		private int _wechat_type;
		private string _wechat_typename;
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
		public string Wechat_name
		{
			set{ _wechat_name=value;}
			get{return _wechat_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_key
		{
			set{ _wechat_key=value;}
			get{return _wechat_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_url
		{
			set{ _wechat_url=value;}
			get{return _wechat_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_token
		{
			set{ _wechat_token=value;}
			get{return _wechat_token;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_appid
		{
			set{ _wechat_appid=value;}
			get{return _wechat_appid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_appsecret
		{
			set{ _wechat_appsecret=value;}
			get{return _wechat_appsecret;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_originalid
		{
			set{ _wechat_originalid=value;}
			get{return _wechat_originalid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
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
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Wechat_type
		{
			set{ _wechat_type=value;}
			get{return _wechat_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wechat_typename
		{
			set{ _wechat_typename=value;}
			get{return _wechat_typename;}
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

