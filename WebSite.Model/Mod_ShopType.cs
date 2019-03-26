
using System;
using WebSite.Common;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_ShopType:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_ShopType
    {
        public Mod_ShopType()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private string _title;
        private string _content1;
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

