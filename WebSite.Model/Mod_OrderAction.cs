using System;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_OrderAction:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_OrderAction
	{
		public Mod_OrderAction()
        {
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private int _orderid;
		private string _orderno;
		private string _operatormodel;
		private int _operatorid;
		private string _operatorname;
		private int _orderstate;
		private int _logisticsstate;
		private int _paystate;
		private string _reason;
		private DateTime _adddate;
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
		/// 操作员类型
		/// </summary>
		public string OperatorModel
		{
			set{ _operatormodel=value;}
			get{return _operatormodel;}
		}
		/// <summary>
		/// 操作员ID
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 操作员名称
		/// </summary>
		public string OperatorName
		{
			set{ _operatorname=value;}
			get{return _operatorname;}
		}
		/// <summary>
		/// 订单状态
		/// </summary>
		public int OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 物流状态
		/// </summary>
		public int LogisticsState
		{
			set{ _logisticsstate=value;}
			get{return _logisticsstate;}
		}
		/// <summary>
		/// 支付状态
		/// </summary>
		public int PayState
		{
			set{ _paystate=value;}
			get{return _paystate;}
		}
		/// <summary>
		/// 订单变动原因
		/// </summary>
		public string Reason
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		#endregion Model

	}
}

