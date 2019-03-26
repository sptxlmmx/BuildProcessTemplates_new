
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_CityPartner:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_CityPartner
	{
		public Mod_CityPartner()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _userrealname;
		private string _usertel;
		private string _useremail;
		private string _industry;
		private int _cityid;
		private string _province;
		private string _city;
		private string _area;
		private int _userid;
		private string _usernickname;
		private int _recommenderid;
		private string _recommendername;
		private string _content1;
		private int _islook;
		private int _isreview;
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
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRealName
		{
			set{ _userrealname=value;}
			get{return _userrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTel
		{
			set{ _usertel=value;}
			get{return _usertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserEmail
		{
			set{ _useremail=value;}
			get{return _useremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Industry
		{
			set{ _industry=value;}
			get{return _industry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CityID
		{
			set{ _cityid=value;}
			get{return _cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
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
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RecommenderID
		{
			set{ _recommenderid=value;}
			get{return _recommenderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecommenderName
		{
			set{ _recommendername=value;}
			get{return _recommendername;}
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
		public int IsReview
		{
			set{ _isreview=value;}
			get{return _isreview;}
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

