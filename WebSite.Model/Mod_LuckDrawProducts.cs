/**  版本信息模板在安装目录下，可自行修改。
* Mod_LuckDrawProducts.cs
*
* 功 能： N/A
* 类 名： Mod_LuckDrawProducts
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/3 10:48:23   N/A    初版
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
	/// Mod_LuckDrawProducts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_LuckDrawProducts
	{
		public Mod_LuckDrawProducts()
		{}
		#region Model
		private int _id;
		private string _model;
		private int? _luckdrawtypeid;
		private string _luckdrawtypename;
		private int? _typeid;
		private string _typename;
		private string _title;
		private string _image;
		private string _imagewin;
		private decimal? _money;
		private int? _integral;
		private decimal? _probability;
		private int? _count=0;
		private int? _countlimit=0;
		private int? _state;
		private int? _orderby;
		private int? _turnorder=99;
		private int? _countorign=0;
		private int? _countlimitorign=0;
		private DateTime? _adddate= DateTime.Now;
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
		public int? LuckDrawTypeID
		{
			set{ _luckdrawtypeid=value;}
			get{return _luckdrawtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LuckDrawTypeName
		{
			set{ _luckdrawtypename=value;}
			get{return _luckdrawtypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
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
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageWin
		{
			set{ _imagewin=value;}
			get{return _imagewin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Probability
		{
			set{ _probability=value;}
			get{return _probability;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Count
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CountLimit
		{
			set{ _countlimit=value;}
			get{return _countlimit;}
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
		public int? TurnOrder
		{
			set{ _turnorder=value;}
			get{return _turnorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CountOrign
		{
			set{ _countorign=value;}
			get{return _countorign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CountLimitOrign
		{
			set{ _countlimitorign=value;}
			get{return _countlimitorign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		#endregion Model

	}
}

