using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_UserAddress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_UserAddress
	{
		public Mod_UserAddress()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _userid;
		private string _consignee;
		private string _countries;
		private string _province;
		private string _city;
		private string _region;
		private string _address;
		private string _zipcode;
		private string _tel;
		private string _mobile;
		private string _signbuilding;
		private string _besttime;
		private DateTime _adddate;
		private int _isdefault;
		private int _state;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
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
		public string Countries
		{
			set{ _countries=value;}
			get{return _countries;}
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
		public string Zipcode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
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
		public string SignBuilding
		{
			set{ _signbuilding=value;}
			get{return _signbuilding;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BestTime
		{
			set{ _besttime=value;}
			get{return _besttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

