using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Product_Spec_Json:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Product_Spec_Json
	{
        public Mod_Product_Spec_Json()
		{
            Global.InitModel(this);
        }
		#region Model
        private int _spec_id;
        private int _parent_id;
        private string _title;
        private string _img_url;

		/// <summary>
		/// 规格id
		/// </summary>
        public int spec_id
		{
            set { _spec_id = value; }
            get { return _spec_id; }
		}
		/// <summary>
		/// 父类id
		/// </summary>
        public int parent_id
		{
            set { _parent_id = value; }
            get { return _parent_id; }
		}
		/// <summary>
		/// 规格标题
		/// </summary>
        public string title
		{
            set { _title = value; }
            get { return _title; }
		}
		/// <summary>
		/// 图片路径
		/// </summary>
        public string img_url
		{
            set { _img_url = value; }
            get { return _img_url; }
		}
		#endregion Model

	}
}

