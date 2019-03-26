
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_UserOauth:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_UserOauth
    {
        public Mod_UserOauth()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _username;
        private int _useridold;
        private string _oauthname;
        private string _oauthunionid;
        private string _oauthopenid;
        private string _oauthopenidmall;
        private string _oauthaccesstoken;
        private int _isloginonapp;
        private int _isloginonweixinclient;
        private int _isloginonappmall;
        private int _isloginonweixinclientmall;
        private int _state;
        private int _orderby;
        private DateTime _adddate;
        private int _websiteid;
        private int _otherint1;
        private int _otherint2;
        private string _otherstriing1;
        private string _otherstriing2;
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
        /// 
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserIDOld
        {
            set { _useridold = value; }
            get { return _useridold; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OauthName
        {
            set { _oauthname = value; }
            get { return _oauthname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OauthUnionid
        {
            set { _oauthunionid = value; }
            get { return _oauthunionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OauthOpenid
        {
            set { _oauthopenid = value; }
            get { return _oauthopenid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OauthOpenidMall
        {
            set { _oauthopenidmall = value; }
            get { return _oauthopenidmall; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OauthAccesstoken
        {
            set { _oauthaccesstoken = value; }
            get { return _oauthaccesstoken; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsLoginonAPP
        {
            set { _isloginonapp = value; }
            get { return _isloginonapp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsLoginonWeiXinClient
        {
            set { _isloginonweixinclient = value; }
            get { return _isloginonweixinclient; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsLoginonAPPMall
        {
            set { _isloginonappmall = value; }
            get { return _isloginonappmall; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsLoginonWeiXinClientMall
        {
            set { _isloginonweixinclientmall = value; }
            get { return _isloginonweixinclientmall; }
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
        /// 排序
        /// </summary>
        public int OrderBy
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int otherInt1
        {
            set { _otherint1 = value; }
            get { return _otherint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int otherInt2
        {
            set { _otherint2 = value; }
            get { return _otherint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string otherStriing1
        {
            set { _otherstriing1 = value; }
            get { return _otherstriing1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string otherStriing2
        {
            set { _otherstriing2 = value; }
            get { return _otherstriing2; }
        }
        #endregion Model

    }
}

