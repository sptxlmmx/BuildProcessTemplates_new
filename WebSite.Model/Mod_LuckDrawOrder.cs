/**  版本信息模板在安装目录下，可自行修改。
* Mod_LuckDrawOrder.cs
*
* 功 能： N/A
* 类 名： Mod_LuckDrawOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/3 10:12:18   N/A    初版
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
	/// Mod_LuckDrawOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_LuckDrawOrder
	{
		public Mod_LuckDrawOrder()
		{}
		#region Model
		private int _id;
		private string _model;
		private string _orderno;
		private int? _userid;
		private string _usernickname;
		private string _productids;
		private string _consignee;
		private string _mobile;
		private string _province;
		private string _city;
		private string _region;
		private string _address;
		private string _remark;
		private int? _isprocess;
		private int? _state;
		private int? _orderby;
		private DateTime? _adddate= DateTime.Now;
		private DateTime? _processdate;
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
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserNickName
		{
			set{ _usernickname=value;}
			get{return _usernickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Productids
		{
			set{ _productids=value;}
			get{return _productids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Consignee
		{
			set{ _consignee=value;}
			get{return _consignee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Region
		{
			set{ _region=value;}
			get{return _region;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsProcess
		{
			set{ _isprocess=value;}
			get{return _isprocess;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ProcessDate
		{
			set{ _processdate=value;}
			get{return _processdate;}
		}
		#endregion Model

	}
}

