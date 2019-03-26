
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_StatisticsMoney:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_StatisticsMoney
	{
		public Mod_StatisticsMoney()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _statisticsdate;
		private decimal _moneyallcurrent;
		private decimal _moneytoday;
		private decimal _tips;
		private decimal _point_incense;
		private decimal _merit_box;
		private decimal _light_candle;
		private decimal _release;
		private decimal _xuyuan;
		private decimal _huanyuan;
		private decimal _help_india;
		private decimal _building_blocks;
		private decimal _baitaishui;
		private decimal _flagshung;
		private decimal _support;
		private decimal _tensupport;
		private decimal _templesupport;
		private decimal _charitable;
		private decimal _poverty_financing;
		private decimal _help;
		private decimal _marketintegral;
		private decimal _contact;
		private decimal _newsrecommend;
		private decimal _userattend;
		private decimal _exc_rec;
		private decimal _exc_buy;
		private decimal _dbalance;
		private decimal _removerecommend;
		private decimal _exc_wit;
		private decimal _other1;
		private decimal _other2;
		private decimal _other3;
		private decimal _other4;
		private decimal _other5;
		private decimal _other6;
		private decimal _other7;
		private decimal _other8;
		private decimal _other9;
		private decimal _other10;
		private int _state;
		private int _orderby;
		private DateTime _adddate;
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
		public string StatisticsDate
		{
			set{ _statisticsdate=value;}
			get{return _statisticsdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneyAllCurrent
		{
			set{ _moneyallcurrent=value;}
			get{return _moneyallcurrent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneyToDay
		{
			set{ _moneytoday=value;}
			get{return _moneytoday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Tips
		{
			set{ _tips=value;}
			get{return _tips;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Point_incense
		{
			set{ _point_incense=value;}
			get{return _point_incense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Merit_box
		{
			set{ _merit_box=value;}
			get{return _merit_box;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Light_candle
		{
			set{ _light_candle=value;}
			get{return _light_candle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Release
		{
			set{ _release=value;}
			get{return _release;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal XuYuan
		{
			set{ _xuyuan=value;}
			get{return _xuyuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal HuanYuan
		{
			set{ _huanyuan=value;}
			get{return _huanyuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Help_India
		{
			set{ _help_india=value;}
			get{return _help_india;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Building_blocks
		{
			set{ _building_blocks=value;}
			get{return _building_blocks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal BaiTaiShui
		{
			set{ _baitaishui=value;}
			get{return _baitaishui;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal FlagsHung
		{
			set{ _flagshung=value;}
			get{return _flagshung;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Support
		{
			set{ _support=value;}
			get{return _support;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TenSupport
		{
			set{ _tensupport=value;}
			get{return _tensupport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TempleSupport
		{
			set{ _templesupport=value;}
			get{return _templesupport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Charitable
		{
			set{ _charitable=value;}
			get{return _charitable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Poverty_financing
		{
			set{ _poverty_financing=value;}
			get{return _poverty_financing;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Help
		{
			set{ _help=value;}
			get{return _help;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MarketIntegral
		{
			set{ _marketintegral=value;}
			get{return _marketintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NewsRecommend
		{
			set{ _newsrecommend=value;}
			get{return _newsrecommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal UserAttend
		{
			set{ _userattend=value;}
			get{return _userattend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Exc_Rec
		{
			set{ _exc_rec=value;}
			get{return _exc_rec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Exc_buy
		{
			set{ _exc_buy=value;}
			get{return _exc_buy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Dbalance
		{
			set{ _dbalance=value;}
			get{return _dbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal RemoveRecommend
		{
			set{ _removerecommend=value;}
			get{return _removerecommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Exc_Wit
		{
			set{ _exc_wit=value;}
			get{return _exc_wit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other1
		{
			set{ _other1=value;}
			get{return _other1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other2
		{
			set{ _other2=value;}
			get{return _other2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other3
		{
			set{ _other3=value;}
			get{return _other3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other4
		{
			set{ _other4=value;}
			get{return _other4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other5
		{
			set{ _other5=value;}
			get{return _other5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other6
		{
			set{ _other6=value;}
			get{return _other6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other7
		{
			set{ _other7=value;}
			get{return _other7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other8
		{
			set{ _other8=value;}
			get{return _other8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other9
		{
			set{ _other9=value;}
			get{return _other9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Other10
		{
			set{ _other10=value;}
			get{return _other10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
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
		public int WebSiteID
		{
			set{ _websiteid=value;}
			get{return _websiteid;}
		}
		#endregion Model

	}
}

