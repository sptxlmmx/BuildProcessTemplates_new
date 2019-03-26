
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_BuddhistBookUser:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_BuddhistBookUser
    {
        public Mod_BuddhistBookUser()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private int _bookid;
        private string _title;
        private string _content1;
        private int _count;
        private int _iscomplete;
        private int _state;
        private int _orderby;
        private DateTime _adddate;
        private DateTime _modifydate;
        private DateTime _completedate;
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
        public int BookID
        {
            set{ _bookid=value;}
            get{return _bookid;}
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
        public string Content1
        {
            set{ _content1=value;}
            get{return _content1;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            set{ _count=value;}
            get{return _count;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsComplete
        {
            set{ _iscomplete=value;}
            get{return _iscomplete;}
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
        public DateTime CompleteDate
        {
            set{ _completedate=value;}
            get{return _completedate;}
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

