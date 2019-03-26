/**  版本信息模板在安装目录下，可自行修改。
* Dal_OrderIntegral.cs
*
* 功 能： N/A
* 类 名： Dal_OrderIntegral
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/17 13:44:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_OrderIntegral
	/// </summary>
	public partial class Dal_OrderIntegral
	{
		public Dal_OrderIntegral()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_OrderIntegral"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_OrderIntegral");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebSite.Model.Mod_OrderIntegral model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_OrderIntegral(");
			strSql.Append("Model,OrderNo,ShopID,ShopName,State,Phone,UserID,UserName,TotalCount,TotalWeight,TotalFreight,TotalAmount,ProductAmount,OrderAmount,IsFreeFreight,DiscountReason,Discount,DiscountAmount,LessAmount,AddAmount,CurrencyType,CurrencyMark,Consignee,Country,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,ReturnAmount,ReturnGoods,Replacement,Remark,LogisticsDllName,LogisticsName,LogisticsNo,LogisticsState,LogisticsDate,LogisticsAmount,ReceivingDate,PayState,PayNo,PayName,PayDllName,PayAmount,PayDate,IsInvoice,InvoiceCommercial,Message,AddDate,WebSiteID,SubIntegral,AddIntegral,IntegralAmount,CouponID,CouponNo,CouponAmount,LogisticsCompany,LogisticsCode,RefundDate,CompleteDate,PState,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherText1,OtherText2)");
			strSql.Append(" values (");
			strSql.Append("@Model,@OrderNo,@ShopID,@ShopName,@State,@Phone,@UserID,@UserName,@TotalCount,@TotalWeight,@TotalFreight,@TotalAmount,@ProductAmount,@OrderAmount,@IsFreeFreight,@DiscountReason,@Discount,@DiscountAmount,@LessAmount,@AddAmount,@CurrencyType,@CurrencyMark,@Consignee,@Country,@Province,@City,@Region,@Address,@Zipcode,@Tel,@Mobile,@SignBuilding,@BestTime,@ReturnAmount,@ReturnGoods,@Replacement,@Remark,@LogisticsDllName,@LogisticsName,@LogisticsNo,@LogisticsState,@LogisticsDate,@LogisticsAmount,@ReceivingDate,@PayState,@PayNo,@PayName,@PayDllName,@PayAmount,@PayDate,@IsInvoice,@InvoiceCommercial,@Message,@AddDate,@WebSiteID,@SubIntegral,@AddIntegral,@IntegralAmount,@CouponID,@CouponNo,@CouponAmount,@LogisticsCompany,@LogisticsCode,@RefundDate,@CompleteDate,@PState,@OtherInt1,@OtherInt2,@OtherString1,@OtherString2,@OtherText1,@OtherText2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@TotalCount", SqlDbType.Int,4),
					new SqlParameter("@TotalWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TotalFreight", SqlDbType.Decimal,9),
					new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ProductAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OrderAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsFreeFreight", SqlDbType.Int,4),
					new SqlParameter("@DiscountReason", SqlDbType.VarChar,200),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@DiscountAmount", SqlDbType.Decimal,9),
					new SqlParameter("@LessAmount", SqlDbType.Decimal,9),
					new SqlParameter("@AddAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CurrencyType", SqlDbType.VarChar,50),
					new SqlParameter("@CurrencyMark", SqlDbType.VarChar,50),
					new SqlParameter("@Consignee", SqlDbType.VarChar,50),
					new SqlParameter("@Country", SqlDbType.VarChar,50),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Zipcode", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@SignBuilding", SqlDbType.VarChar,200),
					new SqlParameter("@BestTime", SqlDbType.VarChar,200),
					new SqlParameter("@ReturnAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ReturnGoods", SqlDbType.VarChar,500),
					new SqlParameter("@Replacement", SqlDbType.VarChar,500),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@LogisticsDllName", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsName", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsNo", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsState", SqlDbType.Int,4),
					new SqlParameter("@LogisticsDate", SqlDbType.DateTime),
					new SqlParameter("@LogisticsAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ReceivingDate", SqlDbType.DateTime),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@PayDllName", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@IsInvoice", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCommercial", SqlDbType.VarChar,50),
					new SqlParameter("@Message", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@SubIntegral", SqlDbType.Int,4),
					new SqlParameter("@AddIntegral", SqlDbType.Int,4),
					new SqlParameter("@IntegralAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CouponID", SqlDbType.Int,4),
					new SqlParameter("@CouponNo", SqlDbType.VarChar,50),
					new SqlParameter("@CouponAmount", SqlDbType.Decimal,9),
					new SqlParameter("@LogisticsCompany", SqlDbType.VarChar,200),
					new SqlParameter("@LogisticsCode", SqlDbType.VarChar,50),
					new SqlParameter("@RefundDate", SqlDbType.DateTime),
					new SqlParameter("@CompleteDate", SqlDbType.DateTime),
					new SqlParameter("@PState", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.ShopID;
			parameters[3].Value = model.ShopName;
			parameters[4].Value = model.State;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.UserID;
			parameters[7].Value = model.UserName;
			parameters[8].Value = model.TotalCount;
			parameters[9].Value = model.TotalWeight;
			parameters[10].Value = model.TotalFreight;
			parameters[11].Value = model.TotalAmount;
			parameters[12].Value = model.ProductAmount;
			parameters[13].Value = model.OrderAmount;
			parameters[14].Value = model.IsFreeFreight;
			parameters[15].Value = model.DiscountReason;
			parameters[16].Value = model.Discount;
			parameters[17].Value = model.DiscountAmount;
			parameters[18].Value = model.LessAmount;
			parameters[19].Value = model.AddAmount;
			parameters[20].Value = model.CurrencyType;
			parameters[21].Value = model.CurrencyMark;
			parameters[22].Value = model.Consignee;
			parameters[23].Value = model.Country;
			parameters[24].Value = model.Province;
			parameters[25].Value = model.City;
			parameters[26].Value = model.Region;
			parameters[27].Value = model.Address;
			parameters[28].Value = model.Zipcode;
			parameters[29].Value = model.Tel;
			parameters[30].Value = model.Mobile;
			parameters[31].Value = model.SignBuilding;
			parameters[32].Value = model.BestTime;
			parameters[33].Value = model.ReturnAmount;
			parameters[34].Value = model.ReturnGoods;
			parameters[35].Value = model.Replacement;
			parameters[36].Value = model.Remark;
			parameters[37].Value = model.LogisticsDllName;
			parameters[38].Value = model.LogisticsName;
			parameters[39].Value = model.LogisticsNo;
			parameters[40].Value = model.LogisticsState;
			parameters[41].Value = model.LogisticsDate;
			parameters[42].Value = model.LogisticsAmount;
			parameters[43].Value = model.ReceivingDate;
			parameters[44].Value = model.PayState;
			parameters[45].Value = model.PayNo;
			parameters[46].Value = model.PayName;
			parameters[47].Value = model.PayDllName;
			parameters[48].Value = model.PayAmount;
			parameters[49].Value = model.PayDate;
			parameters[50].Value = model.IsInvoice;
			parameters[51].Value = model.InvoiceCommercial;
			parameters[52].Value = model.Message;
			parameters[53].Value = model.AddDate;
			parameters[54].Value = model.WebSiteID;
			parameters[55].Value = model.SubIntegral;
			parameters[56].Value = model.AddIntegral;
			parameters[57].Value = model.IntegralAmount;
			parameters[58].Value = model.CouponID;
			parameters[59].Value = model.CouponNo;
			parameters[60].Value = model.CouponAmount;
			parameters[61].Value = model.LogisticsCompany;
			parameters[62].Value = model.LogisticsCode;
			parameters[63].Value = model.RefundDate;
			parameters[64].Value = model.CompleteDate;
			parameters[65].Value = model.PState;
			parameters[66].Value = model.OtherInt1;
			parameters[67].Value = model.OtherInt2;
			parameters[68].Value = model.OtherString1;
			parameters[69].Value = model.OtherString2;
			parameters[70].Value = model.OtherText1;
			parameters[71].Value = model.OtherText2;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_OrderIntegral model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_OrderIntegral set ");
			strSql.Append("Model=@Model,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName,");
			strSql.Append("State=@State,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TotalCount=@TotalCount,");
			strSql.Append("TotalWeight=@TotalWeight,");
			strSql.Append("TotalFreight=@TotalFreight,");
			strSql.Append("TotalAmount=@TotalAmount,");
			strSql.Append("ProductAmount=@ProductAmount,");
			strSql.Append("OrderAmount=@OrderAmount,");
			strSql.Append("IsFreeFreight=@IsFreeFreight,");
			strSql.Append("DiscountReason=@DiscountReason,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("DiscountAmount=@DiscountAmount,");
			strSql.Append("LessAmount=@LessAmount,");
			strSql.Append("AddAmount=@AddAmount,");
			strSql.Append("CurrencyType=@CurrencyType,");
			strSql.Append("CurrencyMark=@CurrencyMark,");
			strSql.Append("Consignee=@Consignee,");
			strSql.Append("Country=@Country,");
			strSql.Append("Province=@Province,");
			strSql.Append("City=@City,");
			strSql.Append("Region=@Region,");
			strSql.Append("Address=@Address,");
			strSql.Append("Zipcode=@Zipcode,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("SignBuilding=@SignBuilding,");
			strSql.Append("BestTime=@BestTime,");
			strSql.Append("ReturnAmount=@ReturnAmount,");
			strSql.Append("ReturnGoods=@ReturnGoods,");
			strSql.Append("Replacement=@Replacement,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("LogisticsDllName=@LogisticsDllName,");
			strSql.Append("LogisticsName=@LogisticsName,");
			strSql.Append("LogisticsNo=@LogisticsNo,");
			strSql.Append("LogisticsState=@LogisticsState,");
			strSql.Append("LogisticsDate=@LogisticsDate,");
			strSql.Append("LogisticsAmount=@LogisticsAmount,");
			strSql.Append("ReceivingDate=@ReceivingDate,");
			strSql.Append("PayState=@PayState,");
			strSql.Append("PayNo=@PayNo,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("PayDllName=@PayDllName,");
			strSql.Append("PayAmount=@PayAmount,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("IsInvoice=@IsInvoice,");
			strSql.Append("InvoiceCommercial=@InvoiceCommercial,");
			strSql.Append("Message=@Message,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("SubIntegral=@SubIntegral,");
			strSql.Append("AddIntegral=@AddIntegral,");
			strSql.Append("IntegralAmount=@IntegralAmount,");
			strSql.Append("CouponID=@CouponID,");
			strSql.Append("CouponNo=@CouponNo,");
			strSql.Append("CouponAmount=@CouponAmount,");
			strSql.Append("LogisticsCompany=@LogisticsCompany,");
			strSql.Append("LogisticsCode=@LogisticsCode,");
			strSql.Append("RefundDate=@RefundDate,");
			strSql.Append("CompleteDate=@CompleteDate,");
			strSql.Append("PState=@PState,");
			strSql.Append("OtherInt1=@OtherInt1,");
			strSql.Append("OtherInt2=@OtherInt2,");
			strSql.Append("OtherString1=@OtherString1,");
			strSql.Append("OtherString2=@OtherString2,");
			strSql.Append("OtherText1=@OtherText1,");
			strSql.Append("OtherText2=@OtherText2");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,200),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@TotalCount", SqlDbType.Int,4),
					new SqlParameter("@TotalWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TotalFreight", SqlDbType.Decimal,9),
					new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ProductAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OrderAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsFreeFreight", SqlDbType.Int,4),
					new SqlParameter("@DiscountReason", SqlDbType.VarChar,200),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@DiscountAmount", SqlDbType.Decimal,9),
					new SqlParameter("@LessAmount", SqlDbType.Decimal,9),
					new SqlParameter("@AddAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CurrencyType", SqlDbType.VarChar,50),
					new SqlParameter("@CurrencyMark", SqlDbType.VarChar,50),
					new SqlParameter("@Consignee", SqlDbType.VarChar,50),
					new SqlParameter("@Country", SqlDbType.VarChar,50),
					new SqlParameter("@Province", SqlDbType.VarChar,200),
					new SqlParameter("@City", SqlDbType.VarChar,200),
					new SqlParameter("@Region", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Zipcode", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@SignBuilding", SqlDbType.VarChar,200),
					new SqlParameter("@BestTime", SqlDbType.VarChar,200),
					new SqlParameter("@ReturnAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ReturnGoods", SqlDbType.VarChar,500),
					new SqlParameter("@Replacement", SqlDbType.VarChar,500),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@LogisticsDllName", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsName", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsNo", SqlDbType.VarChar,50),
					new SqlParameter("@LogisticsState", SqlDbType.Int,4),
					new SqlParameter("@LogisticsDate", SqlDbType.DateTime),
					new SqlParameter("@LogisticsAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ReceivingDate", SqlDbType.DateTime),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@PayNo", SqlDbType.VarChar,50),
					new SqlParameter("@PayName", SqlDbType.VarChar,50),
					new SqlParameter("@PayDllName", SqlDbType.VarChar,50),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@IsInvoice", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCommercial", SqlDbType.VarChar,50),
					new SqlParameter("@Message", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@SubIntegral", SqlDbType.Int,4),
					new SqlParameter("@AddIntegral", SqlDbType.Int,4),
					new SqlParameter("@IntegralAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CouponID", SqlDbType.Int,4),
					new SqlParameter("@CouponNo", SqlDbType.VarChar,50),
					new SqlParameter("@CouponAmount", SqlDbType.Decimal,9),
					new SqlParameter("@LogisticsCompany", SqlDbType.VarChar,200),
					new SqlParameter("@LogisticsCode", SqlDbType.VarChar,50),
					new SqlParameter("@RefundDate", SqlDbType.DateTime),
					new SqlParameter("@CompleteDate", SqlDbType.DateTime),
					new SqlParameter("@PState", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.ShopID;
			parameters[3].Value = model.ShopName;
			parameters[4].Value = model.State;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.UserID;
			parameters[7].Value = model.UserName;
			parameters[8].Value = model.TotalCount;
			parameters[9].Value = model.TotalWeight;
			parameters[10].Value = model.TotalFreight;
			parameters[11].Value = model.TotalAmount;
			parameters[12].Value = model.ProductAmount;
			parameters[13].Value = model.OrderAmount;
			parameters[14].Value = model.IsFreeFreight;
			parameters[15].Value = model.DiscountReason;
			parameters[16].Value = model.Discount;
			parameters[17].Value = model.DiscountAmount;
			parameters[18].Value = model.LessAmount;
			parameters[19].Value = model.AddAmount;
			parameters[20].Value = model.CurrencyType;
			parameters[21].Value = model.CurrencyMark;
			parameters[22].Value = model.Consignee;
			parameters[23].Value = model.Country;
			parameters[24].Value = model.Province;
			parameters[25].Value = model.City;
			parameters[26].Value = model.Region;
			parameters[27].Value = model.Address;
			parameters[28].Value = model.Zipcode;
			parameters[29].Value = model.Tel;
			parameters[30].Value = model.Mobile;
			parameters[31].Value = model.SignBuilding;
			parameters[32].Value = model.BestTime;
			parameters[33].Value = model.ReturnAmount;
			parameters[34].Value = model.ReturnGoods;
			parameters[35].Value = model.Replacement;
			parameters[36].Value = model.Remark;
			parameters[37].Value = model.LogisticsDllName;
			parameters[38].Value = model.LogisticsName;
			parameters[39].Value = model.LogisticsNo;
			parameters[40].Value = model.LogisticsState;
			parameters[41].Value = model.LogisticsDate;
			parameters[42].Value = model.LogisticsAmount;
			parameters[43].Value = model.ReceivingDate;
			parameters[44].Value = model.PayState;
			parameters[45].Value = model.PayNo;
			parameters[46].Value = model.PayName;
			parameters[47].Value = model.PayDllName;
			parameters[48].Value = model.PayAmount;
			parameters[49].Value = model.PayDate;
			parameters[50].Value = model.IsInvoice;
			parameters[51].Value = model.InvoiceCommercial;
			parameters[52].Value = model.Message;
			parameters[53].Value = model.AddDate;
			parameters[54].Value = model.WebSiteID;
			parameters[55].Value = model.SubIntegral;
			parameters[56].Value = model.AddIntegral;
			parameters[57].Value = model.IntegralAmount;
			parameters[58].Value = model.CouponID;
			parameters[59].Value = model.CouponNo;
			parameters[60].Value = model.CouponAmount;
			parameters[61].Value = model.LogisticsCompany;
			parameters[62].Value = model.LogisticsCode;
			parameters[63].Value = model.RefundDate;
			parameters[64].Value = model.CompleteDate;
			parameters[65].Value = model.PState;
			parameters[66].Value = model.OtherInt1;
			parameters[67].Value = model.OtherInt2;
			parameters[68].Value = model.OtherString1;
			parameters[69].Value = model.OtherString2;
			parameters[70].Value = model.OtherText1;
			parameters[71].Value = model.OtherText2;
			parameters[72].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SW_OrderIntegral ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SW_OrderIntegral ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebSite.Model.Mod_OrderIntegral GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Model,OrderNo,ShopID,ShopName,State,Phone,UserID,UserName,TotalCount,TotalWeight,TotalFreight,TotalAmount,ProductAmount,OrderAmount,IsFreeFreight,DiscountReason,Discount,DiscountAmount,LessAmount,AddAmount,CurrencyType,CurrencyMark,Consignee,Country,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,ReturnAmount,ReturnGoods,Replacement,Remark,LogisticsDllName,LogisticsName,LogisticsNo,LogisticsState,LogisticsDate,LogisticsAmount,ReceivingDate,PayState,PayNo,PayName,PayDllName,PayAmount,PayDate,IsInvoice,InvoiceCommercial,Message,AddDate,WebSiteID,SubIntegral,AddIntegral,IntegralAmount,CouponID,CouponNo,CouponAmount,LogisticsCompany,LogisticsCode,RefundDate,CompleteDate,PState,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherText1,OtherText2 from SW_OrderIntegral ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_OrderIntegral model=new WebSite.Model.Mod_OrderIntegral();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebSite.Model.Mod_OrderIntegral DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_OrderIntegral model=new WebSite.Model.Mod_OrderIntegral();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["TotalCount"]!=null && row["TotalCount"].ToString()!="")
				{
					model.TotalCount=int.Parse(row["TotalCount"].ToString());
				}
				if(row["TotalWeight"]!=null && row["TotalWeight"].ToString()!="")
				{
					model.TotalWeight=decimal.Parse(row["TotalWeight"].ToString());
				}
				if(row["TotalFreight"]!=null && row["TotalFreight"].ToString()!="")
				{
					model.TotalFreight=decimal.Parse(row["TotalFreight"].ToString());
				}
				if(row["TotalAmount"]!=null && row["TotalAmount"].ToString()!="")
				{
					model.TotalAmount=decimal.Parse(row["TotalAmount"].ToString());
				}
				if(row["ProductAmount"]!=null && row["ProductAmount"].ToString()!="")
				{
					model.ProductAmount=decimal.Parse(row["ProductAmount"].ToString());
				}
				if(row["OrderAmount"]!=null && row["OrderAmount"].ToString()!="")
				{
					model.OrderAmount=decimal.Parse(row["OrderAmount"].ToString());
				}
				if(row["IsFreeFreight"]!=null && row["IsFreeFreight"].ToString()!="")
				{
					model.IsFreeFreight=int.Parse(row["IsFreeFreight"].ToString());
				}
				if(row["DiscountReason"]!=null)
				{
					model.DiscountReason=row["DiscountReason"].ToString();
				}
				if(row["Discount"]!=null && row["Discount"].ToString()!="")
				{
					model.Discount=decimal.Parse(row["Discount"].ToString());
				}
				if(row["DiscountAmount"]!=null && row["DiscountAmount"].ToString()!="")
				{
					model.DiscountAmount=decimal.Parse(row["DiscountAmount"].ToString());
				}
				if(row["LessAmount"]!=null && row["LessAmount"].ToString()!="")
				{
					model.LessAmount=decimal.Parse(row["LessAmount"].ToString());
				}
				if(row["AddAmount"]!=null && row["AddAmount"].ToString()!="")
				{
					model.AddAmount=decimal.Parse(row["AddAmount"].ToString());
				}
				if(row["CurrencyType"]!=null)
				{
					model.CurrencyType=row["CurrencyType"].ToString();
				}
				if(row["CurrencyMark"]!=null)
				{
					model.CurrencyMark=row["CurrencyMark"].ToString();
				}
				if(row["Consignee"]!=null)
				{
					model.Consignee=row["Consignee"].ToString();
				}
				if(row["Country"]!=null)
				{
					model.Country=row["Country"].ToString();
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["Region"]!=null)
				{
					model.Region=row["Region"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Zipcode"]!=null)
				{
					model.Zipcode=row["Zipcode"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["SignBuilding"]!=null)
				{
					model.SignBuilding=row["SignBuilding"].ToString();
				}
				if(row["BestTime"]!=null)
				{
					model.BestTime=row["BestTime"].ToString();
				}
				if(row["ReturnAmount"]!=null && row["ReturnAmount"].ToString()!="")
				{
					model.ReturnAmount=decimal.Parse(row["ReturnAmount"].ToString());
				}
				if(row["ReturnGoods"]!=null)
				{
					model.ReturnGoods=row["ReturnGoods"].ToString();
				}
				if(row["Replacement"]!=null)
				{
					model.Replacement=row["Replacement"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["LogisticsDllName"]!=null)
				{
					model.LogisticsDllName=row["LogisticsDllName"].ToString();
				}
				if(row["LogisticsName"]!=null)
				{
					model.LogisticsName=row["LogisticsName"].ToString();
				}
				if(row["LogisticsNo"]!=null)
				{
					model.LogisticsNo=row["LogisticsNo"].ToString();
				}
				if(row["LogisticsState"]!=null && row["LogisticsState"].ToString()!="")
				{
					model.LogisticsState=int.Parse(row["LogisticsState"].ToString());
				}
				if(row["LogisticsDate"]!=null && row["LogisticsDate"].ToString()!="")
				{
					model.LogisticsDate=DateTime.Parse(row["LogisticsDate"].ToString());
				}
				if(row["LogisticsAmount"]!=null && row["LogisticsAmount"].ToString()!="")
				{
					model.LogisticsAmount=decimal.Parse(row["LogisticsAmount"].ToString());
				}
				if(row["ReceivingDate"]!=null && row["ReceivingDate"].ToString()!="")
				{
					model.ReceivingDate=DateTime.Parse(row["ReceivingDate"].ToString());
				}
				if(row["PayState"]!=null && row["PayState"].ToString()!="")
				{
					model.PayState=int.Parse(row["PayState"].ToString());
				}
				if(row["PayNo"]!=null)
				{
					model.PayNo=row["PayNo"].ToString();
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
				}
				if(row["PayDllName"]!=null)
				{
					model.PayDllName=row["PayDllName"].ToString();
				}
				if(row["PayAmount"]!=null && row["PayAmount"].ToString()!="")
				{
					model.PayAmount=decimal.Parse(row["PayAmount"].ToString());
				}
				if(row["PayDate"]!=null && row["PayDate"].ToString()!="")
				{
					model.PayDate=DateTime.Parse(row["PayDate"].ToString());
				}
				if(row["IsInvoice"]!=null && row["IsInvoice"].ToString()!="")
				{
					model.IsInvoice=int.Parse(row["IsInvoice"].ToString());
				}
				if(row["InvoiceCommercial"]!=null)
				{
					model.InvoiceCommercial=row["InvoiceCommercial"].ToString();
				}
				if(row["Message"]!=null)
				{
					model.Message=row["Message"].ToString();
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["SubIntegral"]!=null && row["SubIntegral"].ToString()!="")
				{
					model.SubIntegral=int.Parse(row["SubIntegral"].ToString());
				}
				if(row["AddIntegral"]!=null && row["AddIntegral"].ToString()!="")
				{
					model.AddIntegral=int.Parse(row["AddIntegral"].ToString());
				}
				if(row["IntegralAmount"]!=null && row["IntegralAmount"].ToString()!="")
				{
					model.IntegralAmount=decimal.Parse(row["IntegralAmount"].ToString());
				}
				if(row["CouponID"]!=null && row["CouponID"].ToString()!="")
				{
					model.CouponID=int.Parse(row["CouponID"].ToString());
				}
				if(row["CouponNo"]!=null)
				{
					model.CouponNo=row["CouponNo"].ToString();
				}
				if(row["CouponAmount"]!=null && row["CouponAmount"].ToString()!="")
				{
					model.CouponAmount=decimal.Parse(row["CouponAmount"].ToString());
				}
				if(row["LogisticsCompany"]!=null)
				{
					model.LogisticsCompany=row["LogisticsCompany"].ToString();
				}
				if(row["LogisticsCode"]!=null)
				{
					model.LogisticsCode=row["LogisticsCode"].ToString();
				}
				if(row["RefundDate"]!=null && row["RefundDate"].ToString()!="")
				{
					model.RefundDate=DateTime.Parse(row["RefundDate"].ToString());
				}
				if(row["CompleteDate"]!=null && row["CompleteDate"].ToString()!="")
				{
					model.CompleteDate=DateTime.Parse(row["CompleteDate"].ToString());
				}
				if(row["PState"]!=null && row["PState"].ToString()!="")
				{
					model.PState=int.Parse(row["PState"].ToString());
				}
				if(row["OtherInt1"]!=null && row["OtherInt1"].ToString()!="")
				{
					model.OtherInt1=int.Parse(row["OtherInt1"].ToString());
				}
				if(row["OtherInt2"]!=null && row["OtherInt2"].ToString()!="")
				{
					model.OtherInt2=int.Parse(row["OtherInt2"].ToString());
				}
				if(row["OtherString1"]!=null)
				{
					model.OtherString1=row["OtherString1"].ToString();
				}
				if(row["OtherString2"]!=null)
				{
					model.OtherString2=row["OtherString2"].ToString();
				}
				if(row["OtherText1"]!=null)
				{
					model.OtherText1=row["OtherText1"].ToString();
				}
				if(row["OtherText2"]!=null)
				{
					model.OtherText2=row["OtherText2"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Model,OrderNo,ShopID,ShopName,State,Phone,UserID,UserName,TotalCount,TotalWeight,TotalFreight,TotalAmount,ProductAmount,OrderAmount,IsFreeFreight,DiscountReason,Discount,DiscountAmount,LessAmount,AddAmount,CurrencyType,CurrencyMark,Consignee,Country,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,ReturnAmount,ReturnGoods,Replacement,Remark,LogisticsDllName,LogisticsName,LogisticsNo,LogisticsState,LogisticsDate,LogisticsAmount,ReceivingDate,PayState,PayNo,PayName,PayDllName,PayAmount,PayDate,IsInvoice,InvoiceCommercial,Message,AddDate,WebSiteID,SubIntegral,AddIntegral,IntegralAmount,CouponID,CouponNo,CouponAmount,LogisticsCompany,LogisticsCode,RefundDate,CompleteDate,PState,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherText1,OtherText2 ");
			strSql.Append(" FROM SW_OrderIntegral ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Model,OrderNo,ShopID,ShopName,State,Phone,UserID,UserName,TotalCount,TotalWeight,TotalFreight,TotalAmount,ProductAmount,OrderAmount,IsFreeFreight,DiscountReason,Discount,DiscountAmount,LessAmount,AddAmount,CurrencyType,CurrencyMark,Consignee,Country,Province,City,Region,Address,Zipcode,Tel,Mobile,SignBuilding,BestTime,ReturnAmount,ReturnGoods,Replacement,Remark,LogisticsDllName,LogisticsName,LogisticsNo,LogisticsState,LogisticsDate,LogisticsAmount,ReceivingDate,PayState,PayNo,PayName,PayDllName,PayAmount,PayDate,IsInvoice,InvoiceCommercial,Message,AddDate,WebSiteID,SubIntegral,AddIntegral,IntegralAmount,CouponID,CouponNo,CouponAmount,LogisticsCompany,LogisticsCode,RefundDate,CompleteDate,PState,OtherInt1,OtherInt2,OtherString1,OtherString2,OtherText1,OtherText2 ");
			strSql.Append(" FROM SW_OrderIntegral ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SW_OrderIntegral ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + " * from SW_OrderIntegral where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_OrderIntegral where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_OrderIntegral where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "SW_OrderIntegral";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 批量更改数据
        /// </summary>
        public bool UpdateList(string text, string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update  SW_OrderIntegral set LogisticsState=2, Remark='" + text + "',State=20");
            strSql.Append(" where " + sqlWhere + "  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		#endregion  ExtensionMethod
	}
}

