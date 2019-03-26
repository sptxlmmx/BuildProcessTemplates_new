
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_FreeBroker:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_FreeBroker
	{
		public Mod_FreeBroker()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _userid;
		private string _usernickname;
		private int _levelid;
		private string _levelidtitle;
		private string _freebrokername;
		private string _freebrokertel;
		private string _freebrokeremail;
		private string _freebrokerweixin;
		private int _provinceid;
		private string _province;
		private int _cityid;
		private string _city;
		private int _areaid;
		private string _area;
		private string _content1;
		private int _isfreebroker;
		private int _isreview;
		private int _parentid;
		private int _parentidtwo;
		private int _parentidthree;
		private string _idpath;
		private int _shopcount;
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
		/// 关联的用户ID
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
		/// 自由合伙人级别ID
		/// </summary>
		public int LevelID
		{
			set{ _levelid=value;}
			get{return _levelid;}
		}
		/// <summary>
		/// 自由合伙人级别名称
		/// </summary>
		public string LevelIDTitle
		{
			set{ _levelidtitle=value;}
			get{return _levelidtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerName
		{
			set{ _freebrokername=value;}
			get{return _freebrokername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerTel
		{
			set{ _freebrokertel=value;}
			get{return _freebrokertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerEmail
		{
			set{ _freebrokeremail=value;}
			get{return _freebrokeremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreeBrokerWeiXin
		{
			set{ _freebrokerweixin=value;}
			get{return _freebrokerweixin;}
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
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 是否是合伙人
		/// </summary>
		public int IsFreeBroker
		{
			set{ _isfreebroker=value;}
			get{return _isfreebroker;}
		}
		/// <summary>
		/// 审核是否通过
		/// </summary>
		public int IsReview
		{
			set{ _isreview=value;}
			get{return _isreview;}
		}
		/// <summary>
		/// 上一级ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentIDTwo
		{
			set{ _parentidtwo=value;}
			get{return _parentidtwo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentIDThree
		{
			set{ _parentidthree=value;}
			get{return _parentidthree;}
		}
		/// <summary>
		/// 级别路径
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
		}
		/// <summary>
		/// 统计直接邀请店铺
		/// </summary>
		public int ShopCount
		{
			set{ _shopcount=value;}
			get{return _shopcount;}
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

