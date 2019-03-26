
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_Support:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_Support
    {
        public Mod_Support()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private string _title;
        private int _typeid;
        private string _typename;
        private int _weight;
        private string _unit;
        private string _content1;
        private int _euserid;
        private string _eusername;
        private string _eusernickname;
        private int _tuserid;
        private string _tuserids;
        private string _tusername;
        private string _tusernickname;
        private int _integral;
        private decimal _money;
        private int _isreview;
        private DateTime _adddate;
        private int _orderby;
        private int _state;
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
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TypeID
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeName
        {
            set { _typename = value; }
            get { return _typename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Weight
        {
            set { _weight = value; }
            get { return _weight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Content1
        {
            set { _content1 = value; }
            get { return _content1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EUserID
        {
            set { _euserid = value; }
            get { return _euserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EUserName
        {
            set { _eusername = value; }
            get { return _eusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EUserNickName
        {
            set { _eusernickname = value; }
            get { return _eusernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TUserID
        {
            set { _tuserid = value; }
            get { return _tuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TUserIDs
        {
            set { _tuserids = value; }
            get { return _tuserids; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TUserName
        {
            set { _tusername = value; }
            get { return _tusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TUserNickName
        {
            set { _tusernickname = value; }
            get { return _tusernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Integral
        {
            set { _integral = value; }
            get { return _integral; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsReview
        {
            set { _isreview = value; }
            get { return _isreview; }
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
        public int OrderBy
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        #endregion Model

    }
}

