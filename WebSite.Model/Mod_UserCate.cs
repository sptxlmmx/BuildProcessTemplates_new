
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserCate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserCate
	{
		public Mod_UserCate()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _cateids;
		private string _recommendcateids;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _modifydate;
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
		public string CateIDs
		{
			set{ _cateids=value;}
			get{return _cateids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecommendCateIDs
		{
			set{ _recommendcateids=value;}
			get{return _recommendcateids;}
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
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
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

