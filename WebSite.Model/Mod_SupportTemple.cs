
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_SupportTemple:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_SupportTemple
	{
		public Mod_SupportTemple()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _enname;
		private int _tuserid;
		private string _templename;
		private string _applytext;
		private string _refusetext;
		private int _otherint1;
		private int _otherint2;
		private string _otherstring1;
		private string _otherstring2;
		private int _agreestate;
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
		public string EnName
		{
			set{ _enname=value;}
			get{return _enname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TUserID
		{
			set{ _tuserid=value;}
			get{return _tuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempleName
		{
			set{ _templename=value;}
			get{return _templename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ApplyText
		{
			set{ _applytext=value;}
			get{return _applytext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefuseText
		{
			set{ _refusetext=value;}
			get{return _refusetext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt1
		{
			set{ _otherint1=value;}
			get{return _otherint1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt2
		{
			set{ _otherint2=value;}
			get{return _otherint2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString1
		{
			set{ _otherstring1=value;}
			get{return _otherstring1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString2
		{
			set{ _otherstring2=value;}
			get{return _otherstring2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AgreeState
		{
			set{ _agreestate=value;}
			get{return _agreestate;}
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

