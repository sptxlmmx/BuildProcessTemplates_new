using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Recruit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Recruit
	{
		public Mod_Recruit()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _userid;
		private string _jobname;
		private int _typeid;
		private string _department;
		private string _sex;
		private string _jobtype;
		private string _languageability;
		private string _education;
		private string _experience;
		private string _address;
		private string _age;
		private string _salary;
		private string _hiringnum;
		private string _startdate;
		private string _enddate;
		private string _nature;
		private string _responsibility;
		private string _jobrequirements;
		private string _content;
		private int _state;
		private DateTime _adddate;
		private int _orderby;
		private int _isessence;
		private int _iscommend;
		private int _istop;
		private int _isaudit;
		private DateTime _auditdate;
		private int _auditmember;
		private int _iscrawl;
		private string _filename;
		private string _fileurl;
		private int _clanguage;
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
		public string JobName
		{
			set{ _jobname=value;}
			get{return _jobname;}
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
		public string Department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobType
		{
			set{ _jobtype=value;}
			get{return _jobtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LanguageAbility
		{
			set{ _languageability=value;}
			get{return _languageability;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Education
		{
			set{ _education=value;}
			get{return _education;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Experience
		{
			set{ _experience=value;}
			get{return _experience;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Salary
		{
			set{ _salary=value;}
			get{return _salary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HiringNum
		{
			set{ _hiringnum=value;}
			get{return _hiringnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nature
		{
			set{ _nature=value;}
			get{return _nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Responsibility
		{
			set{ _responsibility=value;}
			get{return _responsibility;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobRequirements
		{
			set{ _jobrequirements=value;}
			get{return _jobrequirements;}
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
		public int IsEssence
		{
			set{ _isessence=value;}
			get{return _isessence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsCommend
		{
			set{ _iscommend=value;}
			get{return _iscommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsAudit
		{
			set{ _isaudit=value;}
			get{return _isaudit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AuditDate
		{
			set{ _auditdate=value;}
			get{return _auditdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuditMember
		{
			set{ _auditmember=value;}
			get{return _auditmember;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsCrawl
		{
			set{ _iscrawl=value;}
			get{return _iscrawl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileURL
		{
			set{ _fileurl=value;}
			get{return _fileurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Clanguage
		{
			set{ _clanguage=value;}
			get{return _clanguage;}
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

