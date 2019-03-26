
using System;
using System.Collections.Generic;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_News: 实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_News
    {
        public Mod_News()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _username;
        private int _userlevelid;
        private string _userlevelname;
        private string _usernickname;
        private string _userimage;
        private string _userlevelclass;
        private string _title;
        private int _typeid;
        private string _typename;
        private int _stypeid;
        private string _stypeids;
        private string _stypename;
        private int _customtypeid;
        private string _customtypename;
        private string _author;
        private string _content1;
        private string _content2;
        private string _introduction;
        private string _remarks;
        private DateTime _adddate;
        private DateTime _modifydate;
        private int _orderby;
        private int _state;
        private string _tags;
        private string _tags1;
        private string _tags2;
        private string _tags3;
        private string _tags4;
        private string _imageurl;
        private string _picbig;
        private string _fileurl;
        private int _isreview;
        private int _reviewid;
        private string _reviewname;
        private int _adminid;
        private string _adminname;
        private int _iscommend;
        private int _iscommendhot;
        private int _integral;
        private decimal _money;
        private int _ismoney;
        private decimal _redenvelopes;
        private int _isredenvelopes;
        private int _istop;
        private int _ishot;
        private int _isnew;
        private int _isapplyoriginal;
        private int _isoriginal;
        private int _islaunch;
        private int _browsecount;
        private int _commentcount;
        private int _fabulouscount;
        private int _reportcount;
        private decimal _allmoney;
        private int _allintegral;
        private int _actioncount;
        private string _commendtitle;
        private string _commendurl;
        private string _province;
        private string _city;
        private string _region;
        private decimal _withdrawmoney;
        private int _regionid;
        private int _provecount;
        private int _iswithdraw;
        private int _isgifts;
        private int _isgiftsreview;
        private int _giftstypeid;
        private string _giftstypename;
        private int _giftsproductid;
        private string _giftsurl;
        private int _ishelp;
        private int _helptypeid;
        private string _helptypename;
        private string _helprealname;
        private decimal _targetamount;
        private string _commitmentstatement;
        private string _materialscience;
        private string _auditinstructions;
        private string _helpcontentstr1;
        private string _helpcontentstr2;
        private string _helpcontentstr3;
        private string _helpcontentstr4;
        private string _helpcontentstr5;
        private string _helpcontentstr6;
        private string _helpcontentstr7;
        private string _helpcontentstr8;
        private string _seotitle;
        private string _seokeywords;
        private string _seodescription;
        private int _isfabulous;
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
        private int _otherint11;
        private int _otherint12;
        private int _otherint13;
        private int _otherint14;
        private int _otherint15;
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
        private int _websiteid;
        private List<Mod_PicList> _piclist;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 新闻模型
        /// </summary>
        public string Model
        {
            set { _model = value; }
            get { return _model; }
        }
        /// <summary>
        /// 新闻发布用户ID
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户级别ID
        /// </summary>
        public int UserLevelID
        {
            set { _userlevelid = value; }
            get { return _userlevelid; }
        }
        /// <summary>
        /// 用户级别名称
        /// </summary>
        public string UserLevelName
        {
            set { _userlevelname = value; }
            get { return _userlevelname; }
        }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNickName
        {
            set { _usernickname = value; }
            get { return _usernickname; }
        }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserImage
        {
            set { _userimage = value; }
            get { return _userimage; }
        }
        /// <summary>
        /// 用户级别样式
        /// </summary>
        public string UserlevelClass
        {
            set { _userlevelclass = value; }
            get { return _userlevelclass; }
        }
        /// <summary>
        /// 帖子标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 帖子类别ID
        /// </summary>
        public int TypeID
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 帖子类别名称
        /// </summary>
        public string TypeName
        {
            set { _typename = value; }
            get { return _typename; }
        }
        /// <summary>
        /// 其他类别ID
        /// </summary>
        public int STypeID
        {
            set { _stypeid = value; }
            get { return _stypeid; }
        }
        /// <summary>
        /// 其他类别ID(可以多选)
        /// </summary>
        public string STypeIDs
        {
            set { _stypeids = value; }
            get { return _stypeids; }
        }
        /// <summary>
        /// 其他类别名称
        /// </summary>
        public string STypeName
        {
            set { _stypename = value; }
            get { return _stypename; }
        }
        /// <summary>
        /// 自定义分类ID(我的分类)
        /// </summary>
        public int CustomTypeID
        {
            set { _customtypeid = value; }
            get { return _customtypeid; }
        }
        /// <summary>
        /// 自定义分类名称(我的分类)
        /// </summary>
        public string CustomTypeName
        {
            set { _customtypename = value; }
            get { return _customtypename; }
        }
        /// <summary>
        /// 歌曲作者或者其他
        /// </summary>
        public string Author
        {
            set { _author = value; }
            get { return _author; }
        }
        /// <summary>
        /// 帖子内容1
        /// </summary>
        public string Content1
        {
            set { _content1 = value; }
            get { return _content1; }
        }
        /// <summary>
        /// 帖子内容2
        /// </summary>
        public string Content2
        {
            set { _content2 = value; }
            get { return _content2; }
        }
        /// <summary>
        /// 帖子简介或者歌曲描述
        /// </summary>
        public string Introduction
        {
            set { _introduction = value; }
            get { return _introduction; }
        }
        /// <summary>
        /// 帖子简介或者歌曲描述
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate
        {
            set { _modifydate = value; }
            get { return _modifydate; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        /// <summary>
        /// 显示状态
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags
        {
            set { _tags = value; }
            get { return _tags; }
        }
        /// <summary>
        /// 标签1
        /// </summary>
        public string Tags1
        {
            set { _tags1 = value; }
            get { return _tags1; }
        }
        /// <summary>
        /// 标签2
        /// </summary>
        public string Tags2
        {
            set { _tags2 = value; }
            get { return _tags2; }
        }
        /// <summary>
        /// 标签3
        /// </summary>
        public string Tags3
        {
            set { _tags3 = value; }
            get { return _tags3; }
        }
        /// <summary>
        /// 标签4
        /// </summary>
        public string Tags4
        {
            set { _tags4 = value; }
            get { return _tags4; }
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl
        {
            set { _imageurl = value; }
            get { return _imageurl; }
        }
        /// <summary>
        /// 图片大图
        /// </summary>
        public string PicBig
        {
            set { _picbig = value; }
            get { return _picbig; }
        }
        /// <summary>
        /// 文件地址
        /// </summary>
        public string FileUrl
        {
            set { _fileurl = value; }
            get { return _fileurl; }
        }
        /// <summary>
        /// 是否审核通过
        /// </summary>
        public int IsReview
        {
            set { _isreview = value; }
            get { return _isreview; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ReviewID
        {
            set { _reviewid = value; }
            get { return _reviewid; }
        }
        /// <summary>
        /// 审核员名称
        /// </summary>
        public string ReviewName
        {
            set { _reviewname = value; }
            get { return _reviewname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AdminID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int IsCommend
        {
            set { _iscommend = value; }
            get { return _iscommend; }
        }
        /// <summary>
        /// 是否图片新闻
        /// </summary>
        public int IsCommendHot
        {
            set { _iscommendhot = value; }
            get { return _iscommendhot; }
        }
        /// <summary>
        /// 审核后给帖子积分
        /// </summary>
        public int Integral
        {
            set { _integral = value; }
            get { return _integral; }
        }
        /// <summary>
        /// 获得金额
        /// </summary>
        public decimal Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 是否获得过金额
        /// </summary>
        public int IsMoney
        {
            set { _ismoney = value; }
            get { return _ismoney; }
        }
        /// <summary>
        /// 获得红包
        /// </summary>
        public decimal RedEnvelopes
        {
            set { _redenvelopes = value; }
            get { return _redenvelopes; }
        }
        /// <summary>
        /// 是否获得过红包
        /// </summary>
        public int IsRedEnvelopes
        {
            set { _isredenvelopes = value; }
            get { return _isredenvelopes; }
        }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public int IsTop
        {
            set { _istop = value; }
            get { return _istop; }
        }
        /// <summary>
        /// 是否热门
        /// </summary>
        public int IsHot
        {
            set { _ishot = value; }
            get { return _ishot; }
        }
        /// <summary>
        /// 是否首页推荐
        /// </summary>
        public int IsNew
        {
            set { _isnew = value; }
            get { return _isnew; }
        }
        /// <summary>
        /// 是否首页推荐
        /// </summary>
        public int IsApplyOriginal
        {
            set { _isapplyoriginal = value; }
            get { return _isapplyoriginal; }
        }
        /// <summary>
        /// 是否原创
        /// </summary>
        public int IsOriginal
        {
            set { _isoriginal = value; }
            get { return _isoriginal; }
        }
        /// <summary>
        /// 是否发起
        /// </summary>
        public int IsLaunch
        {
            set { _islaunch = value; }
            get { return _islaunch; }
        }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int BrowseCount
        {
            set { _browsecount = value; }
            get { return _browsecount; }
        }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int CommentCount
        {
            set { _commentcount = value; }
            get { return _commentcount; }
        }
        /// <summary>
        /// 点赞次数
        /// </summary>
        public int FabulousCount
        {
            set { _fabulouscount = value; }
            get { return _fabulouscount; }
        }
        /// <summary>
        /// 被举报次数
        /// </summary>
        public int ReportCount
        {
            set { _reportcount = value; }
            get { return _reportcount; }
        }
        /// <summary>
        /// 行动总善款
        /// </summary>
        public decimal Allmoney
        {
            set { _allmoney = value; }
            get { return _allmoney; }
        }
        /// <summary>
        /// 行动总积分
        /// </summary>
        public int AllIntegral
        {
            set { _allintegral = value; }
            get { return _allintegral; }
        }
        /// <summary>
        /// 行动提交次数
        /// </summary>
        public int ActionCount
        {
            set { _actioncount = value; }
            get { return _actioncount; }
        }
        /// <summary>
        /// 作者推荐标题
        /// </summary>
        public string CommendTitle
        {
            set { _commendtitle = value; }
            get { return _commendtitle; }
        }
        /// <summary>
        /// 作者推荐链接
        /// </summary>
        public string CommendUrl
        {
            set { _commendurl = value; }
            get { return _commendurl; }
        }
        /// <summary>
        /// 省
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 市
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 区/县
        /// </summary>
        public string Region
        {
            set { _region = value; }
            get { return _region; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal WithdrawMoney
        {
            set { _withdrawmoney = value; }
            get { return _withdrawmoney; }
        }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int RegionID
        {
            set { _regionid = value; }
            get { return _regionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ProveCount
        {
            set { _provecount = value; }
            get { return _provecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsWithdraw
        {
            set { _iswithdraw = value; }
            get { return _iswithdraw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsGifts
        {
            set { _isgifts = value; }
            get { return _isgifts; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsGiftsReview
        {
            set { _isgiftsreview = value; }
            get { return _isgiftsreview; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int GiftsTypeID
        {
            set { _giftstypeid = value; }
            get { return _giftstypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GiftsTypeName
        {
            set { _giftstypename = value; }
            get { return _giftstypename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int GiftsProductID
        {
            set { _giftsproductid = value; }
            get { return _giftsproductid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GiftsUrl
        {
            set { _giftsurl = value; }
            get { return _giftsurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsHelp
        {
            set { _ishelp = value; }
            get { return _ishelp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int HelpTypeID
        {
            set { _helptypeid = value; }
            get { return _helptypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HelpTypeName
        {
            set { _helptypename = value; }
            get { return _helptypename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HelpRealName
        {
            set { _helprealname = value; }
            get { return _helprealname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal TargetAmount
        {
            set { _targetamount = value; }
            get { return _targetamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Commitmentstatement
        {
            set { _commitmentstatement = value; }
            get { return _commitmentstatement; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialScience
        {
            set { _materialscience = value; }
            get { return _materialscience; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AuditInstructions
        {
            set { _auditinstructions = value; }
            get { return _auditinstructions; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr1
        {
            set { _helpcontentstr1 = value; }
            get { return _helpcontentstr1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr2
        {
            set { _helpcontentstr2 = value; }
            get { return _helpcontentstr2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr3
        {
            set { _helpcontentstr3 = value; }
            get { return _helpcontentstr3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr4
        {
            set { _helpcontentstr4 = value; }
            get { return _helpcontentstr4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr5
        {
            set { _helpcontentstr5 = value; }
            get { return _helpcontentstr5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr6
        {
            set { _helpcontentstr6 = value; }
            get { return _helpcontentstr6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr7
        {
            set { _helpcontentstr7 = value; }
            get { return _helpcontentstr7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Helpcontentstr8
        {
            set { _helpcontentstr8 = value; }
            get { return _helpcontentstr8; }
        }
        /// <summary>
        /// Seo标题
        /// </summary>
        public string SeoTitle
        {
            set { _seotitle = value; }
            get { return _seotitle; }
        }
        /// <summary>
        /// Seo关键字
        /// </summary>
        public string SeoKeywords
        {
            set { _seokeywords = value; }
            get { return _seokeywords; }
        }
        /// <summary>
        /// Seo描述
        /// </summary>
        public string SeoDescription
        {
            set { _seodescription = value; }
            get { return _seodescription; }
        }
        /// <summary>
        /// 后台新闻自动点赞执行次数累计
        /// </summary>
        public int IsFabulous
        {
            set { _isfabulous = value; }
            get { return _isfabulous; }
        }
        /// <summary>
        /// 数值扩展字段1（用户自定义置顶）
        /// </summary>
        public int OtherInt1
        {
            set { _otherint1 = value; }
            get { return _otherint1; }
        }
        /// <summary>
        /// 数值扩展字段2（文章质量度评分）
        /// </summary>
        public int OtherInt2
        {
            set { _otherint2 = value; }
            get { return _otherint2; }
        }
        /// <summary>
        /// 数值扩展字段3
        /// </summary>
        public int OtherInt3
        {
            set { _otherint3 = value; }
            get { return _otherint3; }
        }
        /// <summary>
        /// 数值扩展字段4
        /// </summary>
        public int OtherInt4
        {
            set { _otherint4 = value; }
            get { return _otherint4; }
        }
        /// <summary>
        /// 数值扩展字段5(求师问法最佳答案是否已经选了)
        /// </summary>
        public int OtherInt5
        {
            set { _otherint5 = value; }
            get { return _otherint5; }
        }
        /// <summary>
        /// 数值扩展字段6
        /// </summary>
        public int OtherInt6
        {
            set { _otherint6 = value; }
            get { return _otherint6; }
        }
        /// <summary>
        /// 数值扩展字段7
        /// </summary>
        public int OtherInt7
        {
            set { _otherint7 = value; }
            get { return _otherint7; }
        }
        /// <summary>
        /// 数值扩展字段8
        /// </summary>
        public int OtherInt8
        {
            set { _otherint8 = value; }
            get { return _otherint8; }
        }
        /// <summary>
        /// 数值扩展字段9
        /// </summary>
        public int OtherInt9
        {
            set { _otherint9 = value; }
            get { return _otherint9; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt10
        {
            set { _otherint10 = value; }
            get { return _otherint10; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt11
        {
            set { _otherint11 = value; }
            get { return _otherint11; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt12
        {
            set { _otherint12 = value; }
            get { return _otherint12; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt13
        {
            set { _otherint13 = value; }
            get { return _otherint13; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt14
        {
            set { _otherint14 = value; }
            get { return _otherint14; }
        }
        /// <summary>
        /// 数值扩展字段10
        /// </summary>
        public int OtherInt15
        {
            set { _otherint15 = value; }
            get { return _otherint15; }
        }
        /// <summary>
        /// 字符串扩展字段1
        /// </summary>
        public string OtherString1
        {
            set { _otherstring1 = value; }
            get { return _otherstring1; }
        }
        /// <summary>
        /// 字符串扩展字段2
        /// </summary>
        public string OtherString2
        {
            set { _otherstring2 = value; }
            get { return _otherstring2; }
        }
        /// <summary>
        /// 字符串扩展字段3
        /// </summary>
        public string OtherString3
        {
            set { _otherstring3 = value; }
            get { return _otherstring3; }
        }
        /// <summary>
        /// 字符串扩展字段4
        /// </summary>
        public string OtherString4
        {
            set { _otherstring4 = value; }
            get { return _otherstring4; }
        }
        /// <summary>
        /// 字符串扩展字段5
        /// </summary>
        public string OtherString5
        {
            set { _otherstring5 = value; }
            get { return _otherstring5; }
        }
        /// <summary>
        /// 字符串扩展字段6
        /// </summary>
        public string OtherString6
        {
            set { _otherstring6 = value; }
            get { return _otherstring6; }
        }
        /// <summary>
        /// 字符串扩展字段7
        /// </summary>
        public string OtherString7
        {
            set { _otherstring7 = value; }
            get { return _otherstring7; }
        }
        /// <summary>
        /// 字符串扩展字段8
        /// </summary>
        public string OtherString8
        {
            set { _otherstring8 = value; }
            get { return _otherstring8; }
        }
        /// <summary>
        /// 字符串扩展字段9
        /// </summary>
        public string OtherString9
        {
            set { _otherstring9 = value; }
            get { return _otherstring9; }
        }
        /// <summary>
        /// 字符串扩展字段10
        /// </summary>
        public string OtherString10
        {
            set { _otherstring10 = value; }
            get { return _otherstring10; }
        }
        /// <summary>
        /// 长字符串扩展字段1
        /// </summary>
        public string OtherText1
        {
            set { _othertext1 = value; }
            get { return _othertext1; }
        }
        /// <summary>
        /// 长字符串扩展字段2
        /// </summary>
        public string OtherText2
        {
            set { _othertext2 = value; }
            get { return _othertext2; }
        }
        /// <summary>
        /// 长字符串扩展字段3
        /// </summary>
        public string OtherText3
        {
            set { _othertext3 = value; }
            get { return _othertext3; }
        }
        /// <summary>
        /// 长字符串扩展字段4
        /// </summary>
        public string OtherText4
        {
            set { _othertext4 = value; }
            get { return _othertext4; }
        }
        /// <summary>
        /// 长字符串扩展字段5
        /// </summary>
        public string OtherText5
        {
            set { _othertext5 = value; }
            get { return _othertext5; }
        }
        /// <summary>
        /// 语言
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        /// <summary>
        /// 图片集合
        /// </summary>
        public List<Mod_PicList> PicList
        {
            set { _piclist = value; }
            get { return _piclist; }
        }
        #endregion Model

    }
}

