
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_PageStatisticalType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_PageStatisticalType
	{
		public Mod_PageStatisticalType()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _title;
		private int _parentid;
		private string _idpath;
		private int _columnid;
		private int _unionid;
		private string _uniontitle;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
		private DateTime _modifydate;
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
		/// 模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 父级ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 类别路径
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
		}
		/// <summary>
		/// 类别级别
		/// </summary>
		public int ColumnID
		{
			set{ _columnid=value;}
			get{return _columnid;}
		}
		/// <summary>
		/// 关联ID
		/// </summary>
		public int UnionID
		{
			set{ _unionid=value;}
			get{return _unionid;}
		}
		/// <summary>
		/// 关联说明
		/// </summary>
		public string UnionTitle
		{
			set{ _uniontitle=value;}
			get{return _uniontitle;}
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
		/// 修改时间
		/// </summary>
		public DateTime ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// 网站ID
		/// </summary>
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

