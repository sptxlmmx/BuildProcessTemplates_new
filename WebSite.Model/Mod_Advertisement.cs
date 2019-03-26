
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Advertisement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Advertisement
	{
		public Mod_Advertisement()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _state;
		private int _auditstate;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _modifydate;
		private DateTime _begindate;
		private DateTime _enddate;
		private int _iscommend;
		private int _istop;
		private int _ishot;
		private int _userid;
		private string _username;
		private string _realname;
		private string _adsponsor;
		private int _userlevelid;
		private string _userlevelname;
		private string _title;
		private string _imageurl;
		private string _weburl;
		private int _adcateid;
		private string _adcatename;
		private int _adtypeid;
		private string _adtypename;
		private string _adpaytype;
		private int _adpositionid;
		private string _adposition;
		private int _integral;
		private string _adinfo;
		private string _adcontent;
		private int _browsecount;
		private int _otherint1;
		private int _otherint2;
		private int _otherint3;
		private int _otherint4;
		private int _otherint5;
		private int _otherint6;
		private int _otherint7;
		private int _otherint8;
		private int _otherint9;
		private int _otherint10;
		private string _otherstring1;
		private string _otherstring2;
		private string _otherstring3;
		private string _otherstring4;
		private string _otherstring5;
		private string _otherstring6;
		private string _otherstring7;
		private string _otherstring8;
		private string _otherstring9;
		private string _otherstring10;
		private string _othertext1;
		private string _othertext2;
		private string _othertext3;
		private string _othertext4;
		private string _othertext5;
		private string _website;
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
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
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
		public DateTime BeginDate
		{
			set{ _begindate=value;}
			get{return _begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
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
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdSponsor
		{
			set{ _adsponsor=value;}
			get{return _adsponsor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserLevelID
		{
			set{ _userlevelid=value;}
			get{return _userlevelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserLevelName
		{
			set{ _userlevelname=value;}
			get{return _userlevelname;}
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
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WebUrl
		{
			set{ _weburl=value;}
			get{return _weburl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AdCateID
		{
			set{ _adcateid=value;}
			get{return _adcateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdCateName
		{
			set{ _adcatename=value;}
			get{return _adcatename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AdTypeID
		{
			set{ _adtypeid=value;}
			get{return _adtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdTypeName
		{
			set{ _adtypename=value;}
			get{return _adtypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdPayType
		{
			set{ _adpaytype=value;}
			get{return _adpaytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AdPositionid
		{
			set{ _adpositionid=value;}
			get{return _adpositionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdPosition
		{
			set{ _adposition=value;}
			get{return _adposition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdInfo
		{
			set{ _adinfo=value;}
			get{return _adinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdContent
		{
			set{ _adcontent=value;}
			get{return _adcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
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
		public int OtherInt3
		{
			set{ _otherint3=value;}
			get{return _otherint3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt4
		{
			set{ _otherint4=value;}
			get{return _otherint4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt5
		{
			set{ _otherint5=value;}
			get{return _otherint5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt6
		{
			set{ _otherint6=value;}
			get{return _otherint6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt7
		{
			set{ _otherint7=value;}
			get{return _otherint7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt8
		{
			set{ _otherint8=value;}
			get{return _otherint8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt9
		{
			set{ _otherint9=value;}
			get{return _otherint9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OtherInt10
		{
			set{ _otherint10=value;}
			get{return _otherint10;}
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
		public string OtherString3
		{
			set{ _otherstring3=value;}
			get{return _otherstring3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString4
		{
			set{ _otherstring4=value;}
			get{return _otherstring4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString5
		{
			set{ _otherstring5=value;}
			get{return _otherstring5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString6
		{
			set{ _otherstring6=value;}
			get{return _otherstring6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString7
		{
			set{ _otherstring7=value;}
			get{return _otherstring7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString8
		{
			set{ _otherstring8=value;}
			get{return _otherstring8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString9
		{
			set{ _otherstring9=value;}
			get{return _otherstring9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherString10
		{
			set{ _otherstring10=value;}
			get{return _otherstring10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText1
		{
			set{ _othertext1=value;}
			get{return _othertext1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText2
		{
			set{ _othertext2=value;}
			get{return _othertext2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText3
		{
			set{ _othertext3=value;}
			get{return _othertext3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText4
		{
			set{ _othertext4=value;}
			get{return _othertext4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherText5
		{
			set{ _othertext5=value;}
			get{return _othertext5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WebSite
		{
			set{ _website=value;}
			get{return _website;}
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

