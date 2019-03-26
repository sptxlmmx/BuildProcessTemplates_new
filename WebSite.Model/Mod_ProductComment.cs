using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductComment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductComment
	{
		public Mod_ProductComment()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _productid;
		private string _productno;
		private string _productname;
		private string _productimg;
		private int _skuid;
		private string _skuno;
		private string _skuspec;
		private decimal _price;
		private decimal _marketprice;
		private int _orderid;
		private string _orderno;
		private string _content;
		private int _starnum;
		private int _userid;
		private string _username;
		private string _name;
		private string _sex;
		private string _email;
		private string _tel;
		private string _company;
		private string _zip;
		private string _address;
		private DateTime _adddate;
		private int _websiteid;
		private int _state;
		private string _replycontent;
		private DateTime _replydate;
		private int _islook;
		private int _istop;
		private int _orderby;
		private int _attr1;
		private int _attr2;
		private int _attr3;
		private string _attr4;
		private string _attr5;
		private decimal _attr6;
		private string _attr7;
		private string _attr8;
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
		/// 商品id
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 货号
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 商品图片
		/// </summary>
		public string ProductImg
		{
			set{ _productimg=value;}
			get{return _productimg;}
		}
		/// <summary>
		/// 货品ID
		/// </summary>
		public int SkuID
		{
			set{ _skuid=value;}
			get{return _skuid;}
		}
		/// <summary>
		/// 货品号
		/// </summary>
		public string SkuNo
		{
			set{ _skuno=value;}
			get{return _skuno;}
		}
		/// <summary>
		/// 货品规格
		/// </summary>
		public string SkuSpec
		{
			set{ _skuspec=value;}
			get{return _skuspec;}
		}
		/// <summary>
		/// 价格
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 市场价
		/// </summary>
		public decimal MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 星级
		/// </summary>
		public int StarNum
		{
			set{ _starnum=value;}
			get{return _starnum;}
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
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 公司
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zip
		{
			set{ _zip=value;}
			get{return _zip;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 版本
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
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
		/// 回复内容
		/// </summary>
		public string ReplyContent
		{
			set{ _replycontent=value;}
			get{return _replycontent;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime ReplyDate
		{
			set{ _replydate=value;}
			get{return _replydate;}
		}
		/// <summary>
		/// 是否查看
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Attr1
		{
			set{ _attr1=value;}
			get{return _attr1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Attr2
		{
			set{ _attr2=value;}
			get{return _attr2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Attr3
		{
			set{ _attr3=value;}
			get{return _attr3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Attr4
		{
			set{ _attr4=value;}
			get{return _attr4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Attr5
		{
			set{ _attr5=value;}
			get{return _attr5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Attr6
		{
			set{ _attr6=value;}
			get{return _attr6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Attr7
		{
			set{ _attr7=value;}
			get{return _attr7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Attr8
		{
			set{ _attr8=value;}
			get{return _attr8;}
		}
		#endregion Model

	}
}

