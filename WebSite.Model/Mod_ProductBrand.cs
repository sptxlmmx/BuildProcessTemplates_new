using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_ProductBrand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_ProductBrand
	{
		public Mod_ProductBrand()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _brandname;
		private string _brandnameen;
		private string _brandnamepinyin;
		private string _company;
		private string _logoimg;
		private string _image;
		private string _weburl;
		private string _keywords;
		private string _description;
		private string _content;
		private int _istop;
		private int _iscommend;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
		private int _websiteid;
		private int _userid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 品牌名称
		/// </summary>
		public string BrandName
		{
			set{ _brandname=value;}
			get{return _brandname;}
		}
		/// <summary>
		/// 品牌名称英文
		/// </summary>
		public string BrandNameEn
		{
			set{ _brandnameen=value;}
			get{return _brandnameen;}
		}
		/// <summary>
		/// 品牌名称拼音
		/// </summary>
		public string BrandNamePinYin
		{
			set{ _brandnamepinyin=value;}
			get{return _brandnamepinyin;}
		}
		/// <summary>
		/// 品牌公司
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 品牌Logo
		/// </summary>
		public string LogoImg
		{
			set{ _logoimg=value;}
			get{return _logoimg;}
		}
		/// <summary>
		/// 品牌大图
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 品牌网址
		/// </summary>
		public string WebUrl
		{
			set{ _weburl=value;}
			get{return _weburl;}
		}
		/// <summary>
		/// seo关键词
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// seo描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
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
		/// 推荐
		/// </summary>
		public int IsCommend
		{
			set{ _iscommend=value;}
			get{return _iscommend;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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
		/// 用户id
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

