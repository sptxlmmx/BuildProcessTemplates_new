
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_PageStatistical:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_PageStatistical
	{
		public Mod_PageStatistical()
		{
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _typeid;
        private string _typetitle;
        private int _typeparentid;
        private string _typeparenttitle;
        private string _pageurl;
        private string _urlreferrer;
        private int _pageid;
        private string _pagetitle;
        private int _userid;
        private string _usernickname;
        private string _ip;
        private string _pcormobile;
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
        public int TypeID
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeTitle
        {
            set { _typetitle = value; }
            get { return _typetitle; }
        }
        /// <summary>
        /// 父级类别ID
        /// </summary>
        public int TypeParentID
        {
            set { _typeparentid = value; }
            get { return _typeparentid; }
        }
        /// <summary>
        /// 父级类别名称
        /// </summary>
        public string TypeParentTitle
        {
            set { _typeparenttitle = value; }
            get { return _typeparenttitle; }
        }
        /// <summary>
        /// 当前页面地址
        /// </summary>
        public string PageUrl
        {
            set { _pageurl = value; }
            get { return _pageurl; }
        }
        /// <summary>
        /// 请求的页面地址
        /// </summary>
        public string UrlReferrer
        {
            set { _urlreferrer = value; }
            get { return _urlreferrer; }
        }
        /// <summary>
        /// 关联的页面ID
        /// </summary>
        public int PageID
        {
            set { _pageid = value; }
            get { return _pageid; }
        }
        /// <summary>
        /// 关联的页面标题
        /// </summary>
        public string PageTitle
        {
            set { _pagetitle = value; }
            get { return _pagetitle; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserNickName
        {
            set { _usernickname = value; }
            get { return _usernickname; }
        }
        /// <summary>
        /// 访问IP地址
        /// </summary>
        public string IP
        {
            set { _ip = value; }
            get { return _ip; }
        }
        /// <summary>
        /// Pc端还是Mobile端
        /// </summary>
        public string PcOrMobile
        {
            set { _pcormobile = value; }
            get { return _pcormobile; }
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
        public DateTime ModifyDate
        {
            set { _modifydate = value; }
            get { return _modifydate; }
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

