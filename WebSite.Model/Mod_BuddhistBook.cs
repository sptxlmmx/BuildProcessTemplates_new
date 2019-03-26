
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_BuddhistBook:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_BuddhistBook
    {
        public Mod_BuddhistBook()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private string _title;
        private string _content1;
        private int _numberword;
        private int _count;
        private int _fabulouscount;
        private int _browsecount;
        private int _iscommend;
        private int _state;
        private int _orderby;
        private DateTime _adddate;
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
        public int NumberWord
        {
            set{ _numberword=value;}
            get{return _numberword;}
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
        public int FabulousCount
        {
            set{ _fabulouscount=value;}
            get{return _fabulouscount;}
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
        public int IsCommend
        {
            set{ _iscommend=value;}
            get{return _iscommend;}
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
        public int WebSiteID
        {
            set{ _websiteid=value;}
            get{return _websiteid;}
        }
        #endregion Model

    }
}

