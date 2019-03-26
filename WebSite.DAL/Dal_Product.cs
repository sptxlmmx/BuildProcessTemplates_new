using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_Product
	/// </summary>
	public partial class Dal_Product
	{
		public Dal_Product()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SW_Product"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SW_Product");
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
		public int Add(WebSite.Model.Mod_Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SW_Product(");
            strSql.Append("Model,ProductNo,ShopID,ShopName,ProductName,SubProductName,Title,Keywords,Description,TypeID,TypeIDPath,AreaID,AreaIDPath,ShopState,SellCount,StockCount,Content1,Content2,Content3,Content4,Content5,SpecConfig,Price1,Price2,Price3,Price4,Weight,Info,BrowseCount,PicBig,PicSmall,PicThumbnail,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,Other11,Other12,Other13,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,WebSiteID,UserID,Unit,Integral,BrandID,IsVip,IsFreemail,Integral2,IsHot)");
			strSql.Append(" values (");
            strSql.Append("@Model,@ProductNo,@ShopID,@ShopName,@ProductName,@SubProductName,@Title,@Keywords,@Description,@TypeID,@TypeIDPath,@AreaID,@AreaIDPath,@ShopState,@SellCount,@StockCount,@Content1,@Content2,@Content3,@Content4,@Content5,@SpecConfig,@Price1,@Price2,@Price3,@Price4,@Weight,@Info,@BrowseCount,@PicBig,@PicSmall,@PicThumbnail,@Other1,@Other2,@Other3,@Other4,@Other5,@Other6,@Other7,@Other8,@Other9,@Other10,@Other11,@Other12,@Other13,@IsTop,@IsNew,@IsRecommend,@OrderBy,@AddDate,@ModifyDate,@State,@WebSiteID,@UserID,@Unit,@Integral,@BrandID,@IsVip,@IsFreemail,@Integral2,@IsHot)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@SubProductName", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Keywords", SqlDbType.Text),
					new SqlParameter("@Description", SqlDbType.Text),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@ShopState", SqlDbType.Int,4),
					new SqlParameter("@SellCount", SqlDbType.Int,4),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@Content3", SqlDbType.Text),
					new SqlParameter("@Content4", SqlDbType.Text),
					new SqlParameter("@Content5", SqlDbType.Text),
                    new SqlParameter("@SpecConfig", SqlDbType.Text),
					new SqlParameter("@Price1", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@PicSmall", SqlDbType.VarChar,500),
					new SqlParameter("@PicThumbnail", SqlDbType.VarChar,500),
					new SqlParameter("@Other1", SqlDbType.VarChar,200),
					new SqlParameter("@Other2", SqlDbType.VarChar,200),
					new SqlParameter("@Other3", SqlDbType.VarChar,200),
					new SqlParameter("@Other4", SqlDbType.VarChar,200),
					new SqlParameter("@Other5", SqlDbType.VarChar,500),
					new SqlParameter("@Other6", SqlDbType.VarChar,500),
					new SqlParameter("@Other7", SqlDbType.VarChar,500),
					new SqlParameter("@Other8", SqlDbType.VarChar,50),
					new SqlParameter("@Other9", SqlDbType.VarChar,50),
					new SqlParameter("@Other10", SqlDbType.VarChar,50),
					new SqlParameter("@Other11", SqlDbType.Int,4),
					new SqlParameter("@Other12", SqlDbType.Int,4),
					new SqlParameter("@Other13", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Unit", SqlDbType.VarChar,50),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
                    new SqlParameter("@IsVip", SqlDbType.Int,4),
                     new SqlParameter("@IsFreemail", SqlDbType.Int,4),
                      new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductNo;
			parameters[2].Value = model.ShopID;
			parameters[3].Value = model.ShopName;
			parameters[4].Value = model.ProductName;
			parameters[5].Value = model.SubProductName;
			parameters[6].Value = model.Title;
			parameters[7].Value = model.Keywords;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.TypeID;
			parameters[10].Value = model.TypeIDPath;
			parameters[11].Value = model.AreaID;
			parameters[12].Value = model.AreaIDPath;
			parameters[13].Value = model.ShopState;
			parameters[14].Value = model.SellCount;
			parameters[15].Value = model.StockCount;
			parameters[16].Value = model.Content1;
			parameters[17].Value = model.Content2;
			parameters[18].Value = model.Content3;
			parameters[19].Value = model.Content4;
			parameters[20].Value = model.Content5;
            parameters[21].Value = model.SpecConfig;
			parameters[22].Value = model.Price1;
			parameters[23].Value = model.Price2;
			parameters[24].Value = model.Price3;
			parameters[25].Value = model.Price4;
			parameters[26].Value = model.Weight;
			parameters[27].Value = model.Info;
			parameters[28].Value = model.BrowseCount;
			parameters[29].Value = model.PicBig;
			parameters[30].Value = model.PicSmall;
			parameters[31].Value = model.PicThumbnail;
			parameters[32].Value = model.Other1;
			parameters[33].Value = model.Other2;
			parameters[34].Value = model.Other3;
			parameters[35].Value = model.Other4;
			parameters[36].Value = model.Other5;
			parameters[37].Value = model.Other6;
			parameters[38].Value = model.Other7;
			parameters[39].Value = model.Other8;
			parameters[40].Value = model.Other9;
			parameters[41].Value = model.Other10;
			parameters[42].Value = model.Other11;
			parameters[43].Value = model.Other12;
			parameters[44].Value = model.Other13;
			parameters[45].Value = model.IsTop;
			parameters[46].Value = model.IsNew;
			parameters[47].Value = model.IsRecommend;
			parameters[48].Value = model.OrderBy;
			parameters[49].Value = model.AddDate;
			parameters[50].Value = model.ModifyDate;
			parameters[51].Value = model.State;
			parameters[52].Value = model.WebSiteID;
			parameters[53].Value = model.UserID;
			parameters[54].Value = model.Unit;
			parameters[55].Value = model.Integral;
			parameters[56].Value = model.BrandID;
            parameters[57].Value = model.IsVip;
            parameters[58].Value = model.IsFreemail;
            parameters[59].Value = model.Integral2;
			parameters[60].Value = model.IsHot;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
                model.ID = Convert.ToInt32(obj);
                //操作图片集
                Dal_PicList DPicList = new Dal_PicList();
                DPicList.OperateList(model.PicList, model.ID, true);
                //操作属性集
                Dal_ProductAttrValue DProductAttrValue = new Dal_ProductAttrValue();
                DProductAttrValue.OperateList(model.ProductAttrValue, model.ID);
                //操作颜色属性
                Dal_ProductColourType DProductColourType = new Dal_ProductColourType();
                DProductColourType.OperateList(model.ProductColourType, model.ID);
                //操作货号集
                Dal_ProductSku DProductSku = new Dal_ProductSku();
                DProductSku.OperateList(model.ProductSku, model.ID);
                return model.ID;

			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SW_Product set ");
			strSql.Append("Model=@Model,");
			strSql.Append("ProductNo=@ProductNo,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("SubProductName=@SubProductName,");
			strSql.Append("Title=@Title,");
			strSql.Append("Keywords=@Keywords,");
			strSql.Append("Description=@Description,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TypeIDPath=@TypeIDPath,");
			strSql.Append("AreaID=@AreaID,");
			strSql.Append("AreaIDPath=@AreaIDPath,");
			strSql.Append("ShopState=@ShopState,");
			strSql.Append("SellCount=@SellCount,");
			strSql.Append("StockCount=@StockCount,");
			strSql.Append("Content1=@Content1,");
			strSql.Append("Content2=@Content2,");
			strSql.Append("Content3=@Content3,");
			strSql.Append("Content4=@Content4,");
			strSql.Append("Content5=@Content5,");
            strSql.Append("SpecConfig=@SpecConfig,");
			strSql.Append("Price1=@Price1,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("Price4=@Price4,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("Info=@Info,");
			strSql.Append("BrowseCount=@BrowseCount,");
			strSql.Append("PicBig=@PicBig,");
			strSql.Append("PicSmall=@PicSmall,");
			strSql.Append("PicThumbnail=@PicThumbnail,");
			strSql.Append("Other1=@Other1,");
			strSql.Append("Other2=@Other2,");
			strSql.Append("Other3=@Other3,");
			strSql.Append("Other4=@Other4,");
			strSql.Append("Other5=@Other5,");
			strSql.Append("Other6=@Other6,");
			strSql.Append("Other7=@Other7,");
			strSql.Append("Other8=@Other8,");
			strSql.Append("Other9=@Other9,");
			strSql.Append("Other10=@Other10,");
			strSql.Append("Other11=@Other11,");
			strSql.Append("Other12=@Other12,");
			strSql.Append("Other13=@Other13,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("IsNew=@IsNew,");
			strSql.Append("IsRecommend=@IsRecommend,");
			strSql.Append("OrderBy=@OrderBy,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("ModifyDate=@ModifyDate,");
			strSql.Append("State=@State,");
			strSql.Append("WebSiteID=@WebSiteID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("BrandID=@BrandID,");
            strSql.Append("IsVip=@IsVip,");
            strSql.Append("IsFreemail=@IsFreemail,");
            strSql.Append("Integral2=@Integral2,");
			strSql.Append("IsHot=@IsHot");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@SubProductName", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Keywords", SqlDbType.Text),
					new SqlParameter("@Description", SqlDbType.Text),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@ShopState", SqlDbType.Int,4),
					new SqlParameter("@SellCount", SqlDbType.Int,4),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@Content3", SqlDbType.Text),
					new SqlParameter("@Content4", SqlDbType.Text),
					new SqlParameter("@Content5", SqlDbType.Text),
                    new SqlParameter("@SpecConfig", SqlDbType.Text),
					new SqlParameter("@Price1", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@PicSmall", SqlDbType.VarChar,500),
					new SqlParameter("@PicThumbnail", SqlDbType.VarChar,500),
					new SqlParameter("@Other1", SqlDbType.VarChar,200),
					new SqlParameter("@Other2", SqlDbType.VarChar,200),
					new SqlParameter("@Other3", SqlDbType.VarChar,200),
					new SqlParameter("@Other4", SqlDbType.VarChar,200),
					new SqlParameter("@Other5", SqlDbType.VarChar,500),
					new SqlParameter("@Other6", SqlDbType.VarChar,500),
					new SqlParameter("@Other7", SqlDbType.VarChar,500),
					new SqlParameter("@Other8", SqlDbType.VarChar,50),
					new SqlParameter("@Other9", SqlDbType.VarChar,50),
					new SqlParameter("@Other10", SqlDbType.VarChar,50),
					new SqlParameter("@Other11", SqlDbType.Int,4),
					new SqlParameter("@Other12", SqlDbType.Int,4),
					new SqlParameter("@Other13", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Unit", SqlDbType.VarChar,50),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
                    new SqlParameter("@IsVip", SqlDbType.Int,4),
                    new SqlParameter("@IsFreemail", SqlDbType.Int,4),
                    new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Model;
			parameters[1].Value = model.ProductNo;
			parameters[2].Value = model.ShopID;
			parameters[3].Value = model.ShopName;
			parameters[4].Value = model.ProductName;
			parameters[5].Value = model.SubProductName;
			parameters[6].Value = model.Title;
			parameters[7].Value = model.Keywords;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.TypeID;
			parameters[10].Value = model.TypeIDPath;
			parameters[11].Value = model.AreaID;
			parameters[12].Value = model.AreaIDPath;
			parameters[13].Value = model.ShopState;
			parameters[14].Value = model.SellCount;
			parameters[15].Value = model.StockCount;
			parameters[16].Value = model.Content1;
			parameters[17].Value = model.Content2;
			parameters[18].Value = model.Content3;
			parameters[19].Value = model.Content4;
			parameters[20].Value = model.Content5;
            parameters[21].Value = model.SpecConfig;
            parameters[22].Value = model.Price1;
            parameters[23].Value = model.Price2;
            parameters[24].Value = model.Price3;
            parameters[25].Value = model.Price4;
            parameters[26].Value = model.Weight;
            parameters[27].Value = model.Info;
            parameters[28].Value = model.BrowseCount;
            parameters[29].Value = model.PicBig;
            parameters[30].Value = model.PicSmall;
            parameters[31].Value = model.PicThumbnail;
            parameters[32].Value = model.Other1;
            parameters[33].Value = model.Other2;
            parameters[34].Value = model.Other3;
            parameters[35].Value = model.Other4;
            parameters[36].Value = model.Other5;
            parameters[37].Value = model.Other6;
            parameters[38].Value = model.Other7;
            parameters[39].Value = model.Other8;
            parameters[40].Value = model.Other9;
            parameters[41].Value = model.Other10;
            parameters[42].Value = model.Other11;
            parameters[43].Value = model.Other12;
            parameters[44].Value = model.Other13;
            parameters[45].Value = model.IsTop;
            parameters[46].Value = model.IsNew;
            parameters[47].Value = model.IsRecommend;
            parameters[48].Value = model.OrderBy;
            parameters[49].Value = model.AddDate;
            parameters[50].Value = model.ModifyDate;
            parameters[51].Value = model.State;
            parameters[52].Value = model.WebSiteID;
            parameters[53].Value = model.UserID;
            parameters[54].Value = model.Unit;
            parameters[55].Value = model.Integral;
            parameters[56].Value = model.BrandID;
            parameters[57].Value = model.IsVip;
            parameters[58].Value = model.IsFreemail;
            parameters[59].Value = model.Integral2;
            parameters[60].Value = model.IsHot;
			parameters[61].Value = model.ID;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(WebSite.Model.Mod_Product model, bool IsSub)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Product set ");
            strSql.Append("Model=@Model,");
            strSql.Append("ProductNo=@ProductNo,");
            strSql.Append("ShopID=@ShopID,");
            strSql.Append("ShopName=@ShopName,");
            strSql.Append("ProductName=@ProductName,");
            strSql.Append("SubProductName=@SubProductName,");
            strSql.Append("Title=@Title,");
            strSql.Append("Keywords=@Keywords,");
            strSql.Append("Description=@Description,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeIDPath=@TypeIDPath,");
            strSql.Append("AreaID=@AreaID,");
            strSql.Append("AreaIDPath=@AreaIDPath,");
            strSql.Append("ShopState=@ShopState,");
            strSql.Append("SellCount=@SellCount,");
            strSql.Append("StockCount=@StockCount,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("Content2=@Content2,");
            strSql.Append("Content3=@Content3,");
            strSql.Append("Content4=@Content4,");
            strSql.Append("Content5=@Content5,");
            strSql.Append("SpecConfig=@SpecConfig,");
            strSql.Append("Price1=@Price1,");
            strSql.Append("Price2=@Price2,");
            strSql.Append("Price3=@Price3,");
            strSql.Append("Price4=@Price4,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("Info=@Info,");
            strSql.Append("BrowseCount=@BrowseCount,");
            strSql.Append("PicBig=@PicBig,");
            strSql.Append("PicSmall=@PicSmall,");
            strSql.Append("PicThumbnail=@PicThumbnail,");
            strSql.Append("Other1=@Other1,");
            strSql.Append("Other2=@Other2,");
            strSql.Append("Other3=@Other3,");
            strSql.Append("Other4=@Other4,");
            strSql.Append("Other5=@Other5,");
            strSql.Append("Other6=@Other6,");
            strSql.Append("Other7=@Other7,");
            strSql.Append("Other8=@Other8,");
            strSql.Append("Other9=@Other9,");
            strSql.Append("Other10=@Other10,");
            strSql.Append("Other11=@Other11,");
            strSql.Append("Other12=@Other12,");
            strSql.Append("Other13=@Other13,");
            strSql.Append("IsTop=@IsTop,");
            strSql.Append("IsNew=@IsNew,");
            strSql.Append("IsRecommend=@IsRecommend,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("State=@State,");
            strSql.Append("WebSiteID=@WebSiteID,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("Unit=@Unit,");
            strSql.Append("Integral=@Integral,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("IsVip=@IsVip,");
            strSql.Append("IsFreemail=@IsFreemail,");
            strSql.Append("Integral2=@Integral2,");
            strSql.Append("IsHot=@IsHot");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@ProductNo", SqlDbType.VarChar,50),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,200),
					new SqlParameter("@ProductName", SqlDbType.VarChar,200),
					new SqlParameter("@SubProductName", SqlDbType.VarChar,200),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Keywords", SqlDbType.Text),
					new SqlParameter("@Description", SqlDbType.Text),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaIDPath", SqlDbType.VarChar,200),
					new SqlParameter("@ShopState", SqlDbType.Int,4),
					new SqlParameter("@SellCount", SqlDbType.Int,4),
					new SqlParameter("@StockCount", SqlDbType.Int,4),
					new SqlParameter("@Content1", SqlDbType.Text),
					new SqlParameter("@Content2", SqlDbType.Text),
					new SqlParameter("@Content3", SqlDbType.Text),
					new SqlParameter("@Content4", SqlDbType.Text),
					new SqlParameter("@Content5", SqlDbType.Text),
                    new SqlParameter("@SpecConfig", SqlDbType.Text),
					new SqlParameter("@Price1", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@Info", SqlDbType.Text),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@PicSmall", SqlDbType.VarChar,500),
					new SqlParameter("@PicThumbnail", SqlDbType.VarChar,500),
					new SqlParameter("@Other1", SqlDbType.VarChar,200),
					new SqlParameter("@Other2", SqlDbType.VarChar,200),
					new SqlParameter("@Other3", SqlDbType.VarChar,200),
					new SqlParameter("@Other4", SqlDbType.VarChar,200),
					new SqlParameter("@Other5", SqlDbType.VarChar,500),
					new SqlParameter("@Other6", SqlDbType.VarChar,500),
					new SqlParameter("@Other7", SqlDbType.VarChar,500),
					new SqlParameter("@Other8", SqlDbType.VarChar,50),
					new SqlParameter("@Other9", SqlDbType.VarChar,50),
					new SqlParameter("@Other10", SqlDbType.VarChar,50),
					new SqlParameter("@Other11", SqlDbType.Int,4),
					new SqlParameter("@Other12", SqlDbType.Int,4),
					new SqlParameter("@Other13", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsRecommend", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Unit", SqlDbType.VarChar,50),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
                    new SqlParameter("@IsVip", SqlDbType.Int,4),
                    new SqlParameter("@IsFreemail", SqlDbType.Int,4),
                    new SqlParameter("@Integral2", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.ProductNo;
            parameters[2].Value = model.ShopID;
            parameters[3].Value = model.ShopName;
            parameters[4].Value = model.ProductName;
            parameters[5].Value = model.SubProductName;
            parameters[6].Value = model.Title;
            parameters[7].Value = model.Keywords;
            parameters[8].Value = model.Description;
            parameters[9].Value = model.TypeID;
            parameters[10].Value = model.TypeIDPath;
            parameters[11].Value = model.AreaID;
            parameters[12].Value = model.AreaIDPath;
            parameters[13].Value = model.ShopState;
            parameters[14].Value = model.SellCount;
            parameters[15].Value = model.StockCount;
            parameters[16].Value = model.Content1;
            parameters[17].Value = model.Content2;
            parameters[18].Value = model.Content3;
            parameters[19].Value = model.Content4;
            parameters[20].Value = model.Content5;
            parameters[21].Value = model.SpecConfig;
            parameters[22].Value = model.Price1;
            parameters[23].Value = model.Price2;
            parameters[24].Value = model.Price3;
            parameters[25].Value = model.Price4;
            parameters[26].Value = model.Weight;
            parameters[27].Value = model.Info;
            parameters[28].Value = model.BrowseCount;
            parameters[29].Value = model.PicBig;
            parameters[30].Value = model.PicSmall;
            parameters[31].Value = model.PicThumbnail;
            parameters[32].Value = model.Other1;
            parameters[33].Value = model.Other2;
            parameters[34].Value = model.Other3;
            parameters[35].Value = model.Other4;
            parameters[36].Value = model.Other5;
            parameters[37].Value = model.Other6;
            parameters[38].Value = model.Other7;
            parameters[39].Value = model.Other8;
            parameters[40].Value = model.Other9;
            parameters[41].Value = model.Other10;
            parameters[42].Value = model.Other11;
            parameters[43].Value = model.Other12;
            parameters[44].Value = model.Other13;
            parameters[45].Value = model.IsTop;
            parameters[46].Value = model.IsNew;
            parameters[47].Value = model.IsRecommend;
            parameters[48].Value = model.OrderBy;
            parameters[49].Value = model.AddDate;
            parameters[50].Value = model.ModifyDate;
            parameters[51].Value = model.State;
            parameters[52].Value = model.WebSiteID;
            parameters[53].Value = model.UserID;
            parameters[54].Value = model.Unit;
            parameters[55].Value = model.Integral;
            parameters[56].Value = model.BrandID;
            parameters[57].Value = model.IsVip;
            parameters[58].Value = model.IsFreemail;
            parameters[59].Value = model.Integral2;
            parameters[60].Value = model.IsHot;
            parameters[61].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                if (IsSub)
                {
                    //操作图片集
                    Dal_PicList DPicList = new Dal_PicList();
                    DPicList.OperateList(model.PicList, model.ID, true);
                    //操作属性集
                    Dal_ProductAttrValue DProductAttrValue = new Dal_ProductAttrValue();
                    DProductAttrValue.OperateList(model.ProductAttrValue, model.ID);
                    //操作颜色属性
                    Dal_ProductColourType DProductColourType = new Dal_ProductColourType();
                    DProductColourType.OperateList(model.ProductColourType, model.ID);
                    //操作货号集
                    Dal_ProductSku DProductSku = new Dal_ProductSku();
                    DProductSku.OperateList(model.ProductSku, model.ID);
                }
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
			strSql.Append("delete from SW_Product ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
                //操作图片集
                Dal_PicList DPicList = new Dal_PicList();
                DPicList.DeleteFile(ID.ToString(), true);
                //操作属性集
                Dal_ProductAttrValue DProductAttrValue = new Dal_ProductAttrValue();
                DProductAttrValue.DeleteWhere(" ProductID=" + ID.ToString());
                //操作货号集
                Dal_ProductSku DProductSku = new Dal_ProductSku();
                DProductSku.DeleteWhere(" ProductID=" + ID.ToString());
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
			strSql.Append("delete from SW_Product ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
                //操作图片集
                Dal_PicList DPicList = new Dal_PicList();
                DPicList.DeleteFile(IDlist, true);
                //操作属性集
                Dal_ProductAttrValue DProductAttrValue = new Dal_ProductAttrValue();
                DProductAttrValue.DeleteWhere(" ProductID in(" + IDlist.ToString() + ")");
                //操作货号集
                Dal_ProductSku DProductSku = new Dal_ProductSku();
                DProductSku.DeleteWhere(" ProductID in(" + IDlist.ToString() + ")");
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
		public WebSite.Model.Mod_Product GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,Model,ProductNo,ShopID,ShopName,ProductName,SubProductName,Title,Keywords,Description,TypeID,TypeIDPath,AreaID,AreaIDPath,ShopState,SellCount,StockCount,Content1,Content2,Content3,Content4,Content5,SpecConfig,Price1,Price2,Price3,Price4,Weight,Info,BrowseCount,PicBig,PicSmall,PicThumbnail,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,Other11,Other12,Other13,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,WebSiteID,UserID,Unit,Integral,BrandID,IsVip,IsFreemail,Integral2,IsHot from SW_Product ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebSite.Model.Mod_Product model=new WebSite.Model.Mod_Product();
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
		public WebSite.Model.Mod_Product DataRowToModel(DataRow row)
		{
			WebSite.Model.Mod_Product model=new WebSite.Model.Mod_Product();
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
				if(row["ProductNo"]!=null)
				{
					model.ProductNo=row["ProductNo"].ToString();
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["SubProductName"]!=null)
				{
					model.SubProductName=row["SubProductName"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Keywords"]!=null)
				{
					model.Keywords=row["Keywords"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["TypeIDPath"]!=null)
				{
					model.TypeIDPath=row["TypeIDPath"].ToString();
				}
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
				}
				if(row["AreaIDPath"]!=null)
				{
					model.AreaIDPath=row["AreaIDPath"].ToString();
				}
				if(row["ShopState"]!=null && row["ShopState"].ToString()!="")
				{
					model.ShopState=int.Parse(row["ShopState"].ToString());
				}
				if(row["SellCount"]!=null && row["SellCount"].ToString()!="")
				{
					model.SellCount=int.Parse(row["SellCount"].ToString());
				}
				if(row["StockCount"]!=null && row["StockCount"].ToString()!="")
				{
					model.StockCount=int.Parse(row["StockCount"].ToString());
				}
				if(row["Content1"]!=null)
				{
					model.Content1=row["Content1"].ToString();
				}
				if(row["Content2"]!=null)
				{
					model.Content2=row["Content2"].ToString();
				}
				if(row["Content3"]!=null)
				{
					model.Content3=row["Content3"].ToString();
				}
				if(row["Content4"]!=null)
				{
					model.Content4=row["Content4"].ToString();
				}
				if(row["Content5"]!=null)
				{
					model.Content5=row["Content5"].ToString();
				}
                if (row["SpecConfig"] != null)
                {
                    model.SpecConfig = row["SpecConfig"].ToString();
                }
				if(row["Price1"]!=null && row["Price1"].ToString()!="")
				{
					model.Price1=decimal.Parse(row["Price1"].ToString());
				}
				if(row["Price2"]!=null && row["Price2"].ToString()!="")
				{
					model.Price2=decimal.Parse(row["Price2"].ToString());
				}
				if(row["Price3"]!=null && row["Price3"].ToString()!="")
				{
					model.Price3=decimal.Parse(row["Price3"].ToString());
				}
				if(row["Price4"]!=null && row["Price4"].ToString()!="")
				{
					model.Price4=decimal.Parse(row["Price4"].ToString());
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(row["Weight"].ToString());
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["BrowseCount"]!=null && row["BrowseCount"].ToString()!="")
				{
					model.BrowseCount=int.Parse(row["BrowseCount"].ToString());
				}
				if(row["PicBig"]!=null)
				{
					model.PicBig=row["PicBig"].ToString();
				}
				if(row["PicSmall"]!=null)
				{
					model.PicSmall=row["PicSmall"].ToString();
				}
				if(row["PicThumbnail"]!=null)
				{
					model.PicThumbnail=row["PicThumbnail"].ToString();
				}
				if(row["Other1"]!=null)
				{
					model.Other1=row["Other1"].ToString();
				}
				if(row["Other2"]!=null)
				{
					model.Other2=row["Other2"].ToString();
				}
				if(row["Other3"]!=null)
				{
					model.Other3=row["Other3"].ToString();
				}
				if(row["Other4"]!=null)
				{
					model.Other4=row["Other4"].ToString();
				}
				if(row["Other5"]!=null)
				{
					model.Other5=row["Other5"].ToString();
				}
				if(row["Other6"]!=null)
				{
					model.Other6=row["Other6"].ToString();
				}
				if(row["Other7"]!=null)
				{
					model.Other7=row["Other7"].ToString();
				}
				if(row["Other8"]!=null)
				{
					model.Other8=row["Other8"].ToString();
				}
				if(row["Other9"]!=null)
				{
					model.Other9=row["Other9"].ToString();
				}
				if(row["Other10"]!=null)
				{
					model.Other10=row["Other10"].ToString();
				}
				if(row["Other11"]!=null && row["Other11"].ToString()!="")
				{
					model.Other11=int.Parse(row["Other11"].ToString());
				}
				if(row["Other12"]!=null && row["Other12"].ToString()!="")
				{
					model.Other12=int.Parse(row["Other12"].ToString());
				}
				if(row["Other13"]!=null && row["Other13"].ToString()!="")
				{
					model.Other13=int.Parse(row["Other13"].ToString());
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					model.IsTop=int.Parse(row["IsTop"].ToString());
				}
				if(row["IsNew"]!=null && row["IsNew"].ToString()!="")
				{
					model.IsNew=int.Parse(row["IsNew"].ToString());
				}
				if(row["IsRecommend"]!=null && row["IsRecommend"].ToString()!="")
				{
					model.IsRecommend=int.Parse(row["IsRecommend"].ToString());
				}
				if(row["OrderBy"]!=null && row["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(row["OrderBy"].ToString());
				}
				if(row["AddDate"]!=null && row["AddDate"].ToString()!="")
				{
					model.AddDate=DateTime.Parse(row["AddDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["WebSiteID"]!=null && row["WebSiteID"].ToString()!="")
				{
					model.WebSiteID=int.Parse(row["WebSiteID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["BrandID"]!=null && row["BrandID"].ToString()!="")
				{
					model.BrandID=int.Parse(row["BrandID"].ToString());
				}
                if (row["IsVip"] != null && row["IsVip"].ToString() != "")
                {
                    model.IsVip = int.Parse(row["IsVip"].ToString());
                }
                if (row["IsFreemail"] != null && row["IsFreemail"].ToString() != "")
                {
                    model.IsFreemail = int.Parse(row["IsFreemail"].ToString());
                }
                if (row["Integral2"] != null && row["Integral2"].ToString() != "")
                {
                    model.Integral2 = int.Parse(row["Integral2"].ToString());
                }
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
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
            strSql.Append("select ID,Model,ProductNo,ShopID,ShopName,ProductName,SubProductName,Title,Keywords,Description,TypeID,TypeIDPath,AreaID,AreaIDPath,ShopState,SellCount,StockCount,Content1,Content2,Content3,Content4,Content5,SpecConfig,Price1,Price2,Price3,Price4,Weight,Info,BrowseCount,PicBig,PicSmall,PicThumbnail,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,Other11,Other12,Other13,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,WebSiteID,UserID,Unit,Integral,BrandID,IsVip,IsFreemail,Integral2,IsHot ");
			strSql.Append(" FROM SW_Product ");
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
            strSql.Append(" ID,Model,ProductNo,ShopID,ShopName,ProductName,SubProductName,Title,Keywords,Description,TypeID,TypeIDPath,AreaID,AreaIDPath,ShopState,SellCount,StockCount,Content1,Content2,Content3,Content4,Content5,SpecConfig,Price1,Price2,Price3,Price4,Weight,Info,BrowseCount,PicBig,PicSmall,PicThumbnail,Other1,Other2,Other3,Other4,Other5,Other6,Other7,Other8,Other9,Other10,Other11,Other12,Other13,IsTop,IsNew,IsRecommend,OrderBy,AddDate,ModifyDate,State,WebSiteID,UserID,Unit,Integral,BrandID,IsVip,IsFreemail,Integral2,IsHot ");
			strSql.Append(" FROM SW_Product ");
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
			strSql.Append("select count(1) FROM SW_Product ");
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
                strSql = "select top " + endIndex + " * from SW_Product where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_Product where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_Product where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_Product";
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
        /// 批量修改状态
        /// </summary>
        public bool UpShopState(string IDlist, int ShopState)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Product set ");
            strSql.Append("ShopState=@ShopState");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ShopState", SqlDbType.Int,4)};
            parameters[0].Value = ShopState;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 批量修改
        /// </summary>
        public bool UpTypeIDPath(string TypeIDPath, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_Product set ");
            strSql.Append("TypeIDPath=@TypeIDPath");
            strSql.Append(" where TypeID=@TypeID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TypeIDPath", SqlDbType.VarChar,200),
                    new SqlParameter("@TypeID", SqlDbType.Int,4)
            };
            parameters[0].Value = TypeIDPath;
            parameters[1].Value = TypeID;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		#endregion  ExtensionMethod
	}
}

