using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Code:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Code
	{
		public Mod_Code()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _object;
		private string _code;
		private int _state;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _userid;
		private string _username;
		private string _ip;
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
		/// 验证对象
		/// </summary>
		public string Object
		{
			set{ _object=value;}
			get{return _object;}
		}
		/// <summary>
		/// 验证码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
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
		/// 修改时间
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
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
		/// IP地址
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
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

