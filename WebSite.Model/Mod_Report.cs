
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Report:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Report
	{
		public Mod_Report()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _reportinfoid;
		private string _reportinfoname;
		private int _userid;
		private string _username;
		private string _usermobile;
		private int _reportuserid;
		private string _reportusername;
		private string _reportusermobile;
		private int _reportid;
		private string _reportids;
		private string _reportnames;
		private string _reportplagiarismurl;
		private string _reportnewsurl;
		private string _recontent;
		private string _reportremarks;
		private DateTime _adddate;
		private int _state;
		private int _islook;
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
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReportInfoID
		{
			set{ _reportinfoid=value;}
			get{return _reportinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportInfoName
		{
			set{ _reportinfoname=value;}
			get{return _reportinfoname;}
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
		public string UserMobile
		{
			set{ _usermobile=value;}
			get{return _usermobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReportUserID
		{
			set{ _reportuserid=value;}
			get{return _reportuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportUserName
		{
			set{ _reportusername=value;}
			get{return _reportusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportUserMobile
		{
			set{ _reportusermobile=value;}
			get{return _reportusermobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReportID
		{
			set{ _reportid=value;}
			get{return _reportid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportIDs
		{
			set{ _reportids=value;}
			get{return _reportids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportNames
		{
			set{ _reportnames=value;}
			get{return _reportnames;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportPlagiarismUrl
		{
			set{ _reportplagiarismurl=value;}
			get{return _reportplagiarismurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportNewsUrl
		{
			set{ _reportnewsurl=value;}
			get{return _reportnewsurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReContent
		{
			set{ _recontent=value;}
			get{return _recontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportRemarks
		{
			set{ _reportremarks=value;}
			get{return _reportremarks;}
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
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

