
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MallShopData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MallShopData
	{
		public Mod_MallShopData()
		{}
		#region Model
		private int _id;
		private string _model;
		private string _name;
		private int _userid;
		private int _shopid;
		private string _qualificationsname;
		private string _image;
		private DateTime _startexpirationdate;
		private DateTime _expirationdate;
		private string _explain;
		private string _remarks;
		private int _otherint1;
		private int _otherint2;
		private string _otherstring1;
		private string _otherstring2;
		private int _state;
		private int _auditstate;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _orderby;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public int ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 资质名称
		/// </summary>
		public string QualificationsName
		{
			set{ _qualificationsname=value;}
			get{return _qualificationsname;}
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
		public DateTime StartExpirationDate
		{
			set{ _startexpirationdate=value;}
			get{return _startexpirationdate;}
		}
		/// <summary>
		/// 到期时间
		/// </summary>
		public DateTime ExpirationDate
		{
			set{ _expirationdate=value;}
			get{return _expirationdate;}
		}
		/// <summary>
		/// 情况说明
		/// </summary>
		public string Explain
		{
			set{ _explain=value;}
			get{return _explain;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 审核
		/// </summary>
		public int AuditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
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
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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

