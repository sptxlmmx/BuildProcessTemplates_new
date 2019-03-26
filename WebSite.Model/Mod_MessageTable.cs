using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MessageTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MessageTable
	{
		public Mod_MessageTable()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _newsid;
		private int _commentsid;
		private string _title;
		private string _content;
		private string _conttext;
		private int _state;
		private int _orderby;
		private DateTime _adddate= DateTime.Now;
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
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CommentsID
		{
			set{ _commentsid=value;}
			get{return _commentsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContText
		{
			set{ _conttext=value;}
			get{return _conttext;}
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

