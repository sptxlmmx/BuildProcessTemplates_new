/**  版本信息模板在安装目录下，可自行修改。
* Mod_LuckDrawDetail.cs
*
* 功 能： N/A
* 类 名： Mod_LuckDrawDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/5 16:22:48   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace WebSite.Model
{
    /// <summary>
    /// Mod_LuckDrawDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_LuckDrawDetail
    {
        public Mod_LuckDrawDetail()
        { }
        #region Model
        private int _id;
        private string _model;
        private int? _userid;
        private string _usernickname;
        private int? _typeid;
        private string _typename;
        private int? _luckdrawproductsid;
        private string _luckdrawproductstitle;
        private string _content1;
        private int? _isreceive;
        private int? _state;
        private int? _orderby;
        private DateTime? _adddate = DateTime.Now;
        private DateTime? _receivedate;
        private string _title;
        private string _guidsn;
        private string _image;
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
        public int? UserID
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
        public int? TypeID
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
        public int? LuckDrawProductsID
        {
            set { _luckdrawproductsid = value; }
            get { return _luckdrawproductsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LuckDrawProductsTitle
        {
            set { _luckdrawproductstitle = value; }
            get { return _luckdrawproductstitle; }
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
        public int? IsReceive
        {
            set { _isreceive = value; }
            get { return _isreceive; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OrderBy
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ReceiveDate
        {
            set { _receivedate = value; }
            get { return _receivedate; }
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
        public string GuidSn
        {
            set { _guidsn = value; }
            get { return _guidsn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Image
        {
            set { _image = value; }
            get { return _image; }
        }
        #endregion Model

    }
}

