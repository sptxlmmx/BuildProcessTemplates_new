using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserBank:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserBank
	{
        public Mod_UserBank()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _nickname;
		private string _banktype;
		private int _bankid;
		private string _bankname;
		private string _bankusername;
		private string _bankicard;
		private string _banknum;
		private DateTime _adddate;
		private int _orderby;
		private int _bankstate;
		private int _state;
		private int _websiteid;
		private string _bankopen;
		private string _spare;
		private int _other1;
		private int _other2;
		private string _other3;
		private string _other4;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 银行卡表模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 银行卡类型
		/// </summary>
		public string BankType
		{
			set{ _banktype=value;}
			get{return _banktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BankID
		{
			set{ _bankid=value;}
			get{return _bankid;}
		}
		/// <summary>
		/// 银行卡名
		/// </summary>
		public string BankName
		{
			set{ _bankname=value;}
			get{return _bankname;}
		}
		/// <summary>
		/// 持卡人姓名
		/// </summary>
		public string BankUserName
		{
			set{ _bankusername=value;}
			get{return _bankusername;}
		}
		/// <summary>
		/// 持卡人省份证号
		/// </summary>
		public string BankIcard
		{
			set{ _bankicard=value;}
			get{return _bankicard;}
		}
		/// <summary>
		/// 银行卡号
		/// </summary>
		public string BankNum
		{
			set{ _banknum=value;}
			get{return _banknum;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 银行卡状态
		/// </summary>
		public int BankState
		{
			set{ _bankstate=value;}
			get{return _bankstate;}
		}
		/// <summary>
		/// 显示状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 网站ID
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 银行卡开户行
		/// </summary>
		public string BankOpen
		{
			set{ _bankopen=value;}
			get{return _bankopen;}
		}
		/// <summary>
		/// 备用
		/// </summary>
		public string Spare
		{
			set{ _spare=value;}
			get{return _spare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Other1
		{
			set{ _other1=value;}
			get{return _other1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Other2
		{
			set{ _other2=value;}
			get{return _other2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Other3
		{
			set{ _other3=value;}
			get{return _other3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Other4
		{
			set{ _other4=value;}
			get{return _other4;}
		}
		#endregion Model

	}
}

