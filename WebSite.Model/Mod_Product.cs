using System;
using WebSite.Common;
using System.Collections.Generic;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Product
	{
		public Mod_Product()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _productno;
		private int _shopid;
		private string _shopname;
		private string _productname;
		private string _subproductname;
		private string _title;
		private string _keywords;
		private string _description;
		private int _typeid;
		private string _typeidpath;
		private int _areaid;
		private string _areaidpath;
		private int _shopstate;
		private int _sellcount;
		private int _stockcount;
		private string _content1;
		private string _content2;
		private string _content3;
		private string _content4;
		private string _content5;
        private string _specconfig;
		private decimal _price1;
		private decimal _price2;
		private decimal _price3;
		private decimal _price4;
		private decimal _weight;
		private string _info;
		private int _browsecount;
		private string _picbig;
		private string _picsmall;
		private string _picthumbnail;
		private string _other1;
		private string _other2;
		private string _other3;
		private string _other4;
		private string _other5;
		private string _other6;
		private string _other7;
		private string _other8;
		private string _other9;
		private string _other10;
		private int _other11;
		private int _other12;
		private int _other13;
		private int _istop;
		private int _isnew;
		private int _isrecommend;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _modifydate;
		private int _state;
		private int _websiteid;
		private int _userid;
		private string _unit;
		private int _integral;
		private int _brandid;
        private int _isvip;
        private int _isFreemail;
        private int _integral2;
		private int _ishot;
        private List<Mod_PicList> _piclist;
        private List<Mod_ProductAttrValue> _productattrvalue;
        private List<Mod_ProductColourType> _productcolourtype;
        
        private List<Mod_ProductSku> _productsku;
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
		/// 商品编号
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 店铺ID
		/// </summary>
		public int ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 店铺名称
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 商品副名称
		/// </summary>
		public string SubProductName
		{
			set{ _subproductname=value;}
			get{return _subproductname;}
		}
		/// <summary>
		/// SEO标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// SEO关键字
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// SEO描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 类别
		/// </summary>
		public int TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 分类id路径
		/// </summary>
		public string TypeIDPath
		{
			set{ _typeidpath=value;}
			get{return _typeidpath;}
		}
		/// <summary>
		/// 地区ID
		/// </summary>
		public int AreaID
		{
			set{ _areaid=value;}
			get{return _areaid;}
		}
		/// <summary>
		/// 地区ID路径
		/// </summary>
		public string AreaIDPath
		{
			set{ _areaidpath=value;}
			get{return _areaidpath;}
		}
		/// <summary>
		/// 销售状态
		/// </summary>
		public int ShopState
		{
			set{ _shopstate=value;}
			get{return _shopstate;}
		}
		/// <summary>
		/// 销售数量
		/// </summary>
		public int SellCount
		{
			set{ _sellcount=value;}
			get{return _sellcount;}
		}
		/// <summary>
		/// 库存
		/// </summary>
		public int StockCount
		{
			set{ _stockcount=value;}
			get{return _stockcount;}
		}
		/// <summary>
		/// 内容1
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 内容2
		/// </summary>
		public string Content2
		{
			set{ _content2=value;}
			get{return _content2;}
		}
		/// <summary>
		/// 内容3
		/// </summary>
		public string Content3
		{
			set{ _content3=value;}
			get{return _content3;}
		}
		/// <summary>
        /// 内容4
		/// </summary>
		public string Content4
		{
			set{ _content4=value;}
			get{return _content4;}
		}
		/// <summary>
		/// 内容5
		/// </summary>
		public string Content5
		{
			set{ _content5=value;}
			get{return _content5;}
		}
        /// <summary>
        /// 规格配置
        /// </summary>
        public string SpecConfig
        {
            set { _specconfig = value; }
            get { return _specconfig; }
        }
		/// <summary>
		/// 价格1
		/// </summary>
		public decimal Price1
		{
			set{ _price1=value;}
			get{return _price1;}
		}
		/// <summary>
		/// 价格2
		/// </summary>
		public decimal Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 价格3
		/// </summary>
		public decimal Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 价格4
		/// </summary>
		public decimal Price4
		{
			set{ _price4=value;}
			get{return _price4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 简介
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 浏览量
		/// </summary>
		public int BrowseCount
		{
			set{ _browsecount=value;}
			get{return _browsecount;}
		}
		/// <summary>
		/// 主图
		/// </summary>
		public string PicBig
		{
			set{ _picbig=value;}
			get{return _picbig;}
		}
		/// <summary>
		/// 小图
		/// </summary>
		public string PicSmall
		{
			set{ _picsmall=value;}
			get{return _picsmall;}
		}
		/// <summary>
		/// 缩略图
		/// </summary>
		public string PicThumbnail
		{
			set{ _picthumbnail=value;}
			get{return _picthumbnail;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other1
		{
			set{ _other1=value;}
			get{return _other1;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other2
		{
			set{ _other2=value;}
			get{return _other2;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other3
		{
			set{ _other3=value;}
			get{return _other3;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other4
		{
			set{ _other4=value;}
			get{return _other4;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other5
		{
			set{ _other5=value;}
			get{return _other5;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other6
		{
			set{ _other6=value;}
			get{return _other6;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other7
		{
			set{ _other7=value;}
			get{return _other7;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other8
		{
			set{ _other8=value;}
			get{return _other8;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other9
		{
			set{ _other9=value;}
			get{return _other9;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string Other10
		{
			set{ _other10=value;}
			get{return _other10;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public int Other11
		{
			set{ _other11=value;}
			get{return _other11;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public int Other12
		{
			set{ _other12=value;}
			get{return _other12;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public int Other13
		{
			set{ _other13=value;}
			get{return _other13;}
		}
		/// <summary>
		/// 置顶
		/// </summary>
		public int IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 新品
		/// </summary>
		public int IsNew
		{
			set{ _isnew=value;}
			get{return _isnew;}
		}
		/// <summary>
		/// 推荐
		/// </summary>
		public int IsRecommend
		{
			set{ _isrecommend=value;}
			get{return _isrecommend;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 语言
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public int BrandID
		{
			set{ _brandid=value;}
			get{return _brandid;}
		}
        /// <summary>
        /// vip
        /// </summary>
        public int IsVip
        {
            set { _isvip = value; }
            get { return _isvip; }
        }
        /// <summary>
        /// 是否包邮
        /// </summary>
        public int IsFreemail
        {
            set { _isFreemail = value; }
            get { return _isFreemail; }
        }
        /// <summary>
        /// 积分2
        /// </summary>
        public int Integral2
        {
            set { _integral2 = value; }
            get { return _integral2; }
        }
		/// <summary>
		/// 热销
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
        /// <summary>
        /// 图片集合
        /// </summary>
        public List<Mod_PicList> PicList
        {
            set { _piclist = value; }
            get { return _piclist; }
        }
        /// <summary>
        /// 属性集
        /// </summary>
        public List<Mod_ProductAttrValue> ProductAttrValue
        {
            set { _productattrvalue = value; }
            get { return _productattrvalue; }
        }
        /// <summary>
        /// 属性集
        /// </summary>
        public List<Mod_ProductColourType> ProductColourType
        {
            set { _productcolourtype = value; }
            get { return _productcolourtype; }
        }
        /// <summary>
        /// 商品货号集
        /// </summary>
        public List<Mod_ProductSku> ProductSku
        {
            set { _productsku = value; }
            get { return _productsku; }
        }
		#endregion Model

	}
}

