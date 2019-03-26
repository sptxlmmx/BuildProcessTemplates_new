
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_UserExtend:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_UserExtend
    {
        public Mod_UserExtend()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _aboutus;
        private string _qualifications;
        private string _notice;
        private string _qrcodeimage;
        private string _logoimage;
        private string _copyright;
        private string _hotline;
        private string _mobile;
        private string _email;
        private string _zipcode;
        private string _address;
        private string _manager;
        private string _domain;
        private string _elogoimage;
        private string _mainproducts;
        private string _blogoimage;
        private string _logotitle;
        private string _logotitleen;
        private int _edition;
        private int _selfadaption;
        private string _headimage;
        private string _pagebanner1;
        private string _pagebanner2;
        private string _pagebanner3;
        private string _pagebanner4;
        private string _pagebanner5;
        private string _pagebanner6;
        private string _pagebanner7;
        private string _pagebanner8;
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
        public string Aboutus
        {
            set{ _aboutus=value;}
            get{return _aboutus;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Qualifications
        {
            set{ _qualifications=value;}
            get{return _qualifications;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Notice
        {
            set{ _notice=value;}
            get{return _notice;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string QRcodeImage
        {
            set{ _qrcodeimage=value;}
            get{return _qrcodeimage;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string LogoImage
        {
            set{ _logoimage=value;}
            get{return _logoimage;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Copyright
        {
            set{ _copyright=value;}
            get{return _copyright;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Hotline
        {
            set{ _hotline=value;}
            get{return _hotline;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set{ _mobile=value;}
            get{return _mobile;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set{ _email=value;}
            get{return _email;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZipCode
        {
            set{ _zipcode=value;}
            get{return _zipcode;}
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
        public string Manager
        {
            set{ _manager=value;}
            get{return _manager;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string Domain
        {
            set{ _domain=value;}
            get{return _domain;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string ELogoImage
        {
            set{ _elogoimage=value;}
            get{return _elogoimage;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string MainProducts
        {
            set{ _mainproducts=value;}
            get{return _mainproducts;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string BLogoImage
        {
            set{ _blogoimage=value;}
            get{return _blogoimage;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string LogoTitle
        {
            set{ _logotitle=value;}
            get{return _logotitle;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string LogoTitleEn
        {
            set{ _logotitleen=value;}
            get{return _logotitleen;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int Edition
        {
            set{ _edition=value;}
            get{return _edition;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int SelfAdaption
        {
            set{ _selfadaption=value;}
            get{return _selfadaption;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string HeadImage
        {
            set{ _headimage=value;}
            get{return _headimage;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner1
        {
            set{ _pagebanner1=value;}
            get{return _pagebanner1;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner2
        {
            set{ _pagebanner2=value;}
            get{return _pagebanner2;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner3
        {
            set{ _pagebanner3=value;}
            get{return _pagebanner3;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner4
        {
            set{ _pagebanner4=value;}
            get{return _pagebanner4;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner5
        {
            set{ _pagebanner5=value;}
            get{return _pagebanner5;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner6
        {
            set{ _pagebanner6=value;}
            get{return _pagebanner6;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner7
        {
            set{ _pagebanner7=value;}
            get{return _pagebanner7;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBanner8
        {
            set{ _pagebanner8=value;}
            get{return _pagebanner8;}
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

