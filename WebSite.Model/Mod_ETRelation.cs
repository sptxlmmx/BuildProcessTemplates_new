
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_ETRelation:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_ETRelation
    {
        public Mod_ETRelation()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _euserid;
        private string _eusernickname;
        private int _tuserid;
        private string _tusernickname;
        private int _isrelation;
        private string _content1;
        private DateTime _adddate;
        private int _orderby;
        private int _state;
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
        public int EUserID
        {
            set{ _euserid=value;}
            get{return _euserid;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string EUserNickName
        {
            set{ _eusernickname=value;}
            get{return _eusernickname;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int TUserID
        {
            set{ _tuserid=value;}
            get{return _tuserid;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string TUserNickName
        {
            set{ _tusernickname=value;}
            get{return _tusernickname;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsRelation
        {
            set{ _isrelation=value;}
            get{return _isrelation;}
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
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
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
        public int State
        {
            set{ _state=value;}
            get{return _state;}
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

