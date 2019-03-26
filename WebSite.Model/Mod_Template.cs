
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Template:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Template
	{
		public Mod_Template()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _title;
		private int _stypeid;
		private string _templateimage;
		private string _templateimagestatic;
		private string _templateclass;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string TemplateImage
		{
			set{ _templateimage=value;}
			get{return _templateimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TemplateImageStatic
		{
			set{ _templateimagestatic=value;}
			get{return _templateimagestatic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TemplateClass
		{
			set{ _templateclass=value;}
			get{return _templateclass;}
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

