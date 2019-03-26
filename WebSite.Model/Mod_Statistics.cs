
using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_Statistics:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_Statistics
	{
		public Mod_Statistics()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private string _statisticsdate;
		private int _integralall;
		private int _integralallcurrent;
		private int _integraloutputday;
		private int _integralinputday;
		private int _integralinvitationtotal;
		private int _integralnoinvitationtotal;
		private int _integralsharetotal;
		private int _integralshareproducttotal;
		private int _integralnewstotal;
		private int _integralvideototal;
		private int _integralmusictotal;
		private int _integralbestanswer;
		private int _integraltips;
		private int _integralsell;
		private int _integralnewsmodify;
		private int _integralmarketsell;
		private int _integralproductsell;
		private int _integralproductsellout;
		private int _integraladvertisement;
		private int _integralcontact;
		private int _integralrenews;
		private int _integralattend;
		private int _integraldistribution;
		private int _integraldistributionin;
		private decimal _moneywithdraw;
		private decimal _moneysell;
		private decimal _moneyoutputday;
		private decimal _moneyinputday;
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
		/// 统计模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 统计日期
		/// </summary>
		public string StatisticsDate
		{
			set{ _statisticsdate=value;}
			get{return _statisticsdate;}
		}
		/// <summary>
		/// 网站总积分
		/// </summary>
		public int IntegralAll
		{
			set{ _integralall=value;}
			get{return _integralall;}
		}
		/// <summary>
		/// 当前积分
		/// </summary>
		public int IntegralAllCurrent
		{
			set{ _integralallcurrent=value;}
			get{return _integralallcurrent;}
		}
		/// <summary>
		/// 当天总输出积分
		/// </summary>
		public int IntegralOutputDay
		{
			set{ _integraloutputday=value;}
			get{return _integraloutputday;}
		}
		/// <summary>
		/// 当天总回收积分
		/// </summary>
		public int IntegralInputDay
		{
			set{ _integralinputday=value;}
			get{return _integralinputday;}
		}
		/// <summary>
		/// 当天总邀请积分
		/// </summary>
		public int IntegralInvitationTotal
		{
			set{ _integralinvitationtotal=value;}
			get{return _integralinvitationtotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralNoInvitationTotal
		{
			set{ _integralnoinvitationtotal=value;}
			get{return _integralnoinvitationtotal;}
		}
		/// <summary>
		/// 当天总分享积分
		/// </summary>
		public int IntegralShareTotal
		{
			set{ _integralsharetotal=value;}
			get{return _integralsharetotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralShareProductTotal
		{
			set{ _integralshareproducttotal=value;}
			get{return _integralshareproducttotal;}
		}
		/// <summary>
		/// 当天发新闻积分
		/// </summary>
		public int IntegralNewsTotal
		{
			set{ _integralnewstotal=value;}
			get{return _integralnewstotal;}
		}
		/// <summary>
		/// 当天总视频积分
		/// </summary>
		public int IntegralVideoTotal
		{
			set{ _integralvideototal=value;}
			get{return _integralvideototal;}
		}
		/// <summary>
		/// 当天总佛乐积分
		/// </summary>
		public int IntegralMusicTotal
		{
			set{ _integralmusictotal=value;}
			get{return _integralmusictotal;}
		}
		/// <summary>
		/// 当天最佳答案积分
		/// </summary>
		public int IntegralBestAnswer
		{
			set{ _integralbestanswer=value;}
			get{return _integralbestanswer;}
		}
		/// <summary>
		/// 当天打赏总积分
		/// </summary>
		public int IntegralTips
		{
			set{ _integraltips=value;}
			get{return _integraltips;}
		}
		/// <summary>
		/// 当天充值总积分
		/// </summary>
		public int IntegralSell
		{
			set{ _integralsell=value;}
			get{return _integralsell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralNewsModify
		{
			set{ _integralnewsmodify=value;}
			get{return _integralnewsmodify;}
		}
		/// <summary>
		/// 当天市场买卖积分
		/// </summary>
		public int IntegralMarketSell
		{
			set{ _integralmarketsell=value;}
			get{return _integralmarketsell;}
		}
		/// <summary>
		/// 当天产品兑换积分
		/// </summary>
		public int IntegralProductSell
		{
			set{ _integralproductsell=value;}
			get{return _integralproductsell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralProductSellOut
		{
			set{ _integralproductsellout=value;}
			get{return _integralproductsellout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralAdvertisement
		{
			set{ _integraladvertisement=value;}
			get{return _integraladvertisement;}
		}
		/// <summary>
		/// 当天查看信息积分
		/// </summary>
		public int IntegralContact
		{
			set{ _integralcontact=value;}
			get{return _integralcontact;}
		}
		/// <summary>
		/// 当天新闻推荐回收积分
		/// </summary>
		public int IntegralReNews
		{
			set{ _integralrenews=value;}
			get{return _integralrenews;}
		}
		/// <summary>
		/// 当天支付旁听积分
		/// </summary>
		public int IntegralAttend
		{
			set{ _integralattend=value;}
			get{return _integralattend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralDistribution
		{
			set{ _integraldistribution=value;}
			get{return _integraldistribution;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IntegralDistributionIn
		{
			set{ _integraldistributionin=value;}
			get{return _integraldistributionin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneyWithdraw
		{
			set{ _moneywithdraw=value;}
			get{return _moneywithdraw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MoneySell
		{
			set{ _moneysell=value;}
			get{return _moneysell;}
		}
		/// <summary>
		/// 当天输出总金额
		/// </summary>
		public decimal MoneyOutputDay
		{
			set{ _moneyoutputday=value;}
			get{return _moneyoutputday;}
		}
		/// <summary>
		/// 当天输入总金额
		/// </summary>
		public decimal MoneyInputDay
		{
			set{ _moneyinputday=value;}
			get{return _moneyinputday;}
		}
		/// <summary>
		/// 显示状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 排序方法
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 统计时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
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

