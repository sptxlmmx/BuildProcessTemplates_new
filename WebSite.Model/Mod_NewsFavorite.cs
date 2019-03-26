
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_NewsFavorite:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_NewsFavorite
	{
		public Mod_NewsFavorite()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private int _buserid;
		private string _busername;
		private string _busernickname;
		private string _buserimage;
		private string _buserclass;
		private int _newsid;
		private string _newsname;
		private int _newstypeid;
		private string _newstypename;
		private string _newsimage;
		private int _newscommentcount;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BUserID
		{
			set{ _buserid=value;}
			get{return _buserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUserName
		{
			set{ _busername=value;}
			get{return _busername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUserNickName
		{
			set{ _busernickname=value;}
			get{return _busernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUserImage
		{
			set{ _buserimage=value;}
			get{return _buserimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUserClass
		{
			set{ _buserclass=value;}
			get{return _buserclass;}
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
		public string NewsName
		{
			set{ _newsname=value;}
			get{return _newsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewsTypeID
		{
			set{ _newstypeid=value;}
			get{return _newstypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsTypeName
		{
			set{ _newstypename=value;}
			get{return _newstypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsImage
		{
			set{ _newsimage=value;}
			get{return _newsimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewsCommentCount
		{
			set{ _newscommentcount=value;}
			get{return _newscommentcount;}
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

