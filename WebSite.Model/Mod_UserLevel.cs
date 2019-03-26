
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserLevel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserLevel
	{
		public Mod_UserLevel()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _userlevelname;
		private string _userlevenicelname;
		private string _stypeids;
		private string _stypenames;
		private string _image;
		private string _levelclass;
		private string _model;
		private int _state;
		private int _orderby;
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
		public string UserLevelName
		{
			set{ _userlevelname=value;}
			get{return _userlevelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserLeveNicelName
		{
			set{ _userlevenicelname=value;}
			get{return _userlevenicelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STypeIDs
		{
			set{ _stypeids=value;}
			get{return _stypeids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STypeNames
		{
			set{ _stypenames=value;}
			get{return _stypenames;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelClass
		{
			set{ _levelclass=value;}
			get{return _levelclass;}
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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

