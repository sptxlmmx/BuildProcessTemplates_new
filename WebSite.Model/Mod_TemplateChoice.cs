
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_TemplateChoice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_TemplateChoice
	{
		public Mod_TemplateChoice()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _templateid;
		private int _userid;
		private int _stypeid;
		private string _stypename;
		private DateTime _adddate;
		private int _orderby;
		private int _state;
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
		public int TemplateID
		{
			set{ _templateid=value;}
			get{return _templateid;}
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
		public int STypeID
		{
			set{ _stypeid=value;}
			get{return _stypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STypeName
		{
			set{ _stypename=value;}
			get{return _stypename;}
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
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

