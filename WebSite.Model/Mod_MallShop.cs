using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_MallShop:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_MallShop
	{
		public Mod_MallShop()
		{
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private string _model;
        private int _userid;
        private string _nicename;
        private string _shopname;
        private int _shoplevelid;
        private string _shoplevelname;
        private int _shoptypeid;
        private string _shoptypename;
        private int _brandid;
        private string _shopbrand;
        private string _brandimagebig;
        private string _brandmagesmall;
        private string _shopimagebig;
        private string _shopimagesmall;
        private string _mobile;
        private string _email;
        private int _provinceid;
        private int _cityid;
        private int _regionid;
        private string _country;
        private string _province;
        private string _city;
        private string _region;
        private string _address;
        private int _supplyid;
        private string _supplyname;
        private string _shopprofile;
        private string _content;
        private string _remarks;
        private int _isbrand = 0;
        private int _isbond = 0;
        private int _state;
        private int _auditstate;
        private int _ispay;
        private int _paystate;
        private int _parentid;
        private int _parentidtwo;
        private int _parentidthree;
        private string _idpath;
        private DateTime _adddate;
        private DateTime _modifydate;
        private int _orderby;
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
        /// 用户id
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NiceName
        {
            set { _nicename = value; }
            get { return _nicename; }
        }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName
        {
            set { _shopname = value; }
            get { return _shopname; }
        }
        /// <summary>
        /// 店铺级别ID
        /// </summary>
        public int ShopLevelID
        {
            set { _shoplevelid = value; }
            get { return _shoplevelid; }
        }
        /// <summary>
        /// 店铺级别名称
        /// </summary>
        public string ShopLevelName
        {
            set { _shoplevelname = value; }
            get { return _shoplevelname; }
        }
        /// <summary>
        /// 店铺类型ID (SW_ShopType)
        /// </summary>
        public int ShopTypeID
        {
            set { _shoptypeid = value; }
            get { return _shoptypeid; }
        }
        /// <summary>
        /// 店铺类型名称
        /// </summary>
        public string ShopTypeName
        {
            set { _shoptypename = value; }
            get { return _shoptypename; }
        }
        /// <summary>
        /// 品牌iD
        /// </summary>
        public int BrandID
        {
            set { _brandid = value; }
            get { return _brandid; }
        }
        /// <summary>
        /// 店铺品牌
        /// </summary>
        public string ShopBrand
        {
            set { _shopbrand = value; }
            get { return _shopbrand; }
        }
        /// <summary>
        /// 品牌大图片
        /// </summary>
        public string BrandImageBig
        {
            set { _brandimagebig = value; }
            get { return _brandimagebig; }
        }
        /// <summary>
        /// 品牌小图片
        /// </summary>
        public string BrandmageSmall
        {
            set { _brandmagesmall = value; }
            get { return _brandmagesmall; }
        }
        /// <summary>
        /// 店铺大图片
        /// </summary>
        public string ShopImageBig
        {
            set { _shopimagebig = value; }
            get { return _shopimagebig; }
        }
        /// <summary>
        /// 店铺小图片
        /// </summary>
        public string ShopImageSmall
        {
            set { _shopimagesmall = value; }
            get { return _shopimagesmall; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 省份ID
        /// </summary>
        public int ProvinceID
        {
            set { _provinceid = value; }
            get { return _provinceid; }
        }
        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID
        {
            set { _cityid = value; }
            get { return _cityid; }
        }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int RegionID
        {
            set { _regionid = value; }
            get { return _regionid; }
        }
        /// <summary>
        /// 中国
        /// </summary>
        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 省份
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 市
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 区域
        /// </summary>
        public string Region
        {
            set { _region = value; }
            get { return _region; }
        }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 主要供应（分类表id）
        /// </summary>
        public int SupplyID
        {
            set { _supplyid = value; }
            get { return _supplyid; }
        }
        /// <summary>
        /// 主要供应
        /// </summary>
        public string SupplyName
        {
            set { _supplyname = value; }
            get { return _supplyname; }
        }
        /// <summary>
        /// 店铺简介
        /// </summary>
        public string ShopProfile
        {
            set { _shopprofile = value; }
            get { return _shopprofile; }
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsBrand
        {
            set { _isbrand = value; }
            get { return _isbrand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsBond
        {
            set { _isbond = value; }
            get { return _isbond; }
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
        /// 是否审核1通过0待处理-1未通过
        /// </summary>
        public int AuditState
        {
            set { _auditstate = value; }
            get { return _auditstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsPay
        {
            set { _ispay = value; }
            get { return _ispay; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PayState
        {
            set { _paystate = value; }
            get { return _paystate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentIDTwo
        {
            set { _parentidtwo = value; }
            get { return _parentidtwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentIDThree
        {
            set { _parentidthree = value; }
            get { return _parentidthree; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDPath
        {
            set { _idpath = value; }
            get { return _idpath; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate
        {
            set { _modifydate = value; }
            get { return _modifydate; }
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
        /// 排序
        /// </summary>
        public int WebSiteID
        {
            set { _websiteid = value; }
            get { return _websiteid; }
        }
        #endregion Model

	}
}

