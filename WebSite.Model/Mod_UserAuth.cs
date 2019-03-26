using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserAuth:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserAuth
	{
		public Mod_UserAuth()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _userid;
		private string _openid;
		private string _unionid;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenID
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnionID
		{
			set{ _unionid=value;}
			get{return _unionid;}
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

