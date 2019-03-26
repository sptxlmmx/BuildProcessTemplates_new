
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_StatisticsButton:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_StatisticsButton
	{
		public Mod_StatisticsButton()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _buttonname;
		private int _newsid;
		private int _userid;
		private string _username;
		private string _usenickrname;
		private string _ip;
		private DateTime _adddate;
		private string _platform;
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
		public string ButtonName
		{
			set{ _buttonname=value;}
			get{return _buttonname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UseNickrName
		{
			set{ _usenickrname=value;}
			get{return _usenickrname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
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
		public string Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		#endregion Model

	}
}

