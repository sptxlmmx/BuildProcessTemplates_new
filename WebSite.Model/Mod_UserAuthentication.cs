
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserAuthentication:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserAuthentication
	{
		public Mod_UserAuthentication()
		{
            Global.InitModel(this);
        }

        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _usernickname;
        private string _userrealname;
        private string _identitynum;
        private string _imageidentity1;
        private string _imageidentity2;
        private string _remarks;
        private int _isreview;
        private int _state;
        private int _orderby;
        private DateTime _adddate;
        private DateTime _modifydate;
        private DateTime _reviewdate;
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
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserNickName
        {
            set { _usernickname = value; }
            get { return _usernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserRealName
        {
            set { _userrealname = value; }
            get { return _userrealname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IdentityNum
        {
            set { _identitynum = value; }
            get { return _identitynum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ImageIdentity1
        {
            set { _imageidentity1 = value; }
            get { return _imageidentity1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ImageIdentity2
        {
            set { _imageidentity2 = value; }
            get { return _imageidentity2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
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
        public DateTime ReviewDate
        {
            set { _reviewdate = value; }
            get { return _reviewdate; }
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

