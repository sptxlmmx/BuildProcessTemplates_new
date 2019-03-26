
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ShopAppointment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ShopAppointment
	{
		public Mod_ShopAppointment()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _shoplevelid;
		private string _shoplevelname;
		private int _shoptypeid;
		private string _shoptypename;
		private string _shopusername;
		private string _shopusertel;
		private string _shopuseremail;
		private int _provinceid;
		private string _province;
		private int _cityid;
		private string _city;
		private int _areaid;
		private string _area;
		private int _userid;
		private string _usernickname;
		private int _recommenderid;
		private string _recommendername;
		private string _content1;
		private int _islook;
		private int _ismyself;
		private int _myselfid;
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
		public int ShopLevelID
		{
			set{ _shoplevelid=value;}
			get{return _shoplevelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopLevelName
		{
			set{ _shoplevelname=value;}
			get{return _shoplevelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ShopTypeID
		{
			set{ _shoptypeid=value;}
			get{return _shoptypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopTypeName
		{
			set{ _shoptypename=value;}
			get{return _shoptypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopUserName
		{
			set{ _shopusername=value;}
			get{return _shopusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopUserTel
		{
			set{ _shopusertel=value;}
			get{return _shopusertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopUserEmail
		{
			set{ _shopuseremail=value;}
			get{return _shopuseremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProvinceID
		{
			set{ _provinceid=value;}
			get{return _provinceid;}
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
		public int CityID
		{
			set{ _cityid=value;}
			get{return _cityid;}
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
		public int AreaID
		{
			set{ _areaid=value;}
			get{return _areaid;}
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
		public int IsMyself
		{
			set{ _ismyself=value;}
			get{return _ismyself;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MyselfID
		{
			set{ _myselfid=value;}
			get{return _myselfid;}
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

