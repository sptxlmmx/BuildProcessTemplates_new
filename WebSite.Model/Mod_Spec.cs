using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Spec:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Spec
	{
		public Mod_Spec()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _specname;
		private string _alias;
		private int _displaytype;
		private int _displaymode;
		private string _note;
		private int _orderby;
		private int _state;
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
		/// 规格名称
		/// </summary>
		public string SpecName
		{
			set{ _specname=value;}
			get{return _specname;}
		}
		/// <summary>
		/// 规格别名
		/// </summary>
		public string Alias
		{
			set{ _alias=value;}
			get{return _alias;}
		}
		/// <summary>
		/// 显示类型
		/// </summary>
		public int DisplayType
		{
			set{ _displaytype=value;}
			get{return _displaytype;}
		}
		/// <summary>
		/// 显示方式
		/// </summary>
		public int DisplayMode
		{
			set{ _displaymode=value;}
			get{return _displaymode;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
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
            set { _userid = value; }
            get { return _userid; }
        }
		#endregion Model

	}
}

