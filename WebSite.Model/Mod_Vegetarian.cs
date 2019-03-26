
using System;
using WebSite.Common;

namespace WebSite.Model
{
  public  class Mod_Vegetarian
    {
        public Mod_Vegetarian()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _nicename;
        private string _username;
        private string _mobile;
        private string _province;
        private string _city;
        private string _region;
        private string _address;
        private string _longlat;
        private decimal _money;
        private string _characteristic;
        private decimal _score;
        private int _isrecommend;
        private int _isauthen;
        private int _authenid;
        private string _authennicename;
        private string _remarks;
        private int _otherint1;
        private int _otherint2;
        private int _otherint3;
        private int _otherint4;
        private string _otherstring1;
        private string _otherstring2;
        private string _otherstring3;
        private string _otherstring4;
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
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Model
        {
            set { _model = value; }
            get { return _model; }
        }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NiceName
        {
            set { _nicename = value; }
            get { return _nicename; }
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
        /// 电话
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
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
        /// 区域
        /// </summary>
        public string Region
        {
            set { _region = value; }
            get { return _region; }
        }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 百度经纬度
        /// </summary>
        public string LongLat
        {
            set { _longlat = value; }
            get { return _longlat; }
        }
        /// <summary>
        /// 金额-人均消费
        /// </summary>
        public decimal Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 店特色
        /// </summary>
        public string Characteristic
        {
            set { _characteristic = value; }
            get { return _characteristic; }
        }
        /// <summary>
        /// 评论评分
        /// </summary>
        public decimal Score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int IsRecommend
        {
            set { _isrecommend = value; }
            get { return _isrecommend; }
        }
        /// <summary>
        /// 是否认证
        /// </summary>
        public int IsAuthen
        {
            set { _isauthen = value; }
            get { return _isauthen; }
        }
        /// <summary>
        /// 认证的会员id
        /// </summary>
        public int AuthenID
        {
            set { _authenid = value; }
            get { return _authenid; }
        }
        /// <summary>
        /// 认证的用户昵称
        /// </summary>
        public string AuthenNiceName
        {
            set { _authennicename = value; }
            get { return _authennicename; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public int OtherInt1
        {
            set { _otherint1 = value; }
            get { return _otherint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int OtherInt2
        {
            set { _otherint2 = value; }
            get { return _otherint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int OtherInt3
        {
            set { _otherint3 = value; }
            get { return _otherint3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int OtherInt4
        {
            set { _otherint4 = value; }
            get { return _otherint4; }
        }
        /// <summary>
        /// 高德经纬度
        /// </summary>
        public string OtherString1
        {
            set { _otherstring1 = value; }
            get { return _otherstring1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherString2
        {
            set { _otherstring2 = value; }
            get { return _otherstring2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherString3
        {
            set { _otherstring3 = value; }
            get { return _otherstring3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherString4
        {
            set { _otherstring4 = value; }
            get { return _otherstring4; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 是否审核1通过0待处理-1未通过
        /// </summary>
        public int AuditState
        {
            set { _auditstate = value; }
            get { return _auditstate; }
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
        /// 排序
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        #endregion Model
    }
}
