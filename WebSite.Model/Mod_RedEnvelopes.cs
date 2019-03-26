
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_RedEnvelopes:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_RedEnvelopes
	{
		public Mod_RedEnvelopes()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _typeid;
		private string _typename;
		private string _redenvelopesnum;
		private decimal _money;
		private int _newsid;
		private string _useropenid;
		private int _userid;
		private string _username;
		private int _isbig;
		private int _isreceive;
		private DateTime _receivedate;
		private int _state;
		private DateTime _adddate;
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
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 红包号
		/// </summary>
		public string RedEnvelopesNum
		{
			set{ _redenvelopesnum=value;}
			get{return _redenvelopesnum;}
		}
		/// <summary>
		/// 红包金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
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
		/// 领取用户Openid
		/// </summary>
		public string UserOpenID
		{
			set{ _useropenid=value;}
			get{return _useropenid;}
		}
		/// <summary>
		/// 领取用户id
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 领取用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsBig
		{
			set{ _isbig=value;}
			get{return _isbig;}
		}
		/// <summary>
		/// 是否被领取
		/// </summary>
		public int IsReceive
		{
			set{ _isreceive=value;}
			get{return _isreceive;}
		}
		/// <summary>
		/// 红包被领取时间
		/// </summary>
		public DateTime ReceiveDate
		{
			set{ _receivedate=value;}
			get{return _receivedate;}
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
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		#endregion Model

	}
}

