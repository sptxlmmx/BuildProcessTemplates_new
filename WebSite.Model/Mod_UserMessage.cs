
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserMessage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserMessage
	{
		public Mod_UserMessage()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _typemode;
		private string _model;
		private int _userid;
		private int _suserid;
		private int _messageid;
		private int _status;
		private int _state=1;
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
		public string TypeMode
		{
			set{ _typemode=value;}
			get{return _typemode;}
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
		public int SUserID
		{
			set{ _suserid=value;}
			get{return _suserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MessageID
		{
			set{ _messageid=value;}
			get{return _messageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
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
        /// 版本
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
		#endregion Model

	}
}

