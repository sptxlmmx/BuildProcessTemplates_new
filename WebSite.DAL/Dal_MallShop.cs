using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_MallShop
	/// </summary>
	public partial class Dal_MallShop
	{
		public Dal_MallShop()
		{}
		#region  BasicMethod


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_MallShop");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_MallShop");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(WebSite.Model.Mod_MallShop model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_MallShop(");
            strSql.Append("Model,UserID,NiceName,ShopName,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,BrandID,ShopBrand,BrandImageBig,BrandmageSmall,ShopImageBig,ShopImageSmall,Mobile,Email,ProvinceID,CityID,RegionID,Country,Province,City,Region,Address,SupplyID,SupplyName,ShopProfile,Content,Remarks,IsBrand,IsBond,State,AuditState,IsPay,PayState,ParentID,ParentIDTwo,ParentIDThree,IDPath,AddDate,ModifyDate,OrderBy,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@NiceName,@ShopName,@ShopLevelID,@ShopLevelName,@ShopTypeID,@ShopTypeName,@BrandID,@ShopBrand,@BrandImageBig,@BrandmageSmall,@ShopImageBig,@ShopImageSmall,@Mobile,@Email,@ProvinceID,@CityID,@RegionID,@Country,@Province,@City,@Region,@Address,@SupplyID,@SupplyName,@ShopProfile,@Content,@Remarks,@IsBrand,@IsBond,@State,@AuditState,@IsPay,@PayState,@ParentID,@ParentIDTwo,@ParentIDThree,@IDPath,@AddDate,@ModifyDate,@OrderBy,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopName", SqlDbType.NVarChar,150),
					new SqlParameter("@ShopLevelID", SqlDbType.Int,4),
					new SqlParameter("@ShopLevelName", SqlDbType.NVarChar,100),
					new SqlParameter("@ShopTypeID", SqlDbType.Int,4),
					new SqlParameter("@ShopTypeName", SqlDbType.NVarChar,100),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@ShopBrand", SqlDbType.NVarChar,100),
					new SqlParameter("@BrandImageBig", SqlDbType.NVarChar,200),
					new SqlParameter("@BrandmageSmall", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImageBig", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImageSmall", SqlDbType.NVarChar,200),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@RegionID", SqlDbType.Int,4),
					new SqlParameter("@Country", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
					new SqlParameter("@SupplyID", SqlDbType.Int,4),
					new SqlParameter("@SupplyName", SqlDbType.NVarChar,100),
					new SqlParameter("@ShopProfile", SqlDbType.NText),
					new SqlParameter("@Content", SqlDbType.NText),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@IsBrand", SqlDbType.Int,4),
					new SqlParameter("@IsBond", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@ParentIDTwo", SqlDbType.Int,4),
					new SqlParameter("@ParentIDThree", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.NText),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.NiceName;
            parameters[3].Value = model.ShopName;
            parameters[4].Value = model.ShopLevelID;
            parameters[5].Value = model.ShopLevelName;
            parameters[6].Value = model.ShopTypeID;
            parameters[7].Value = model.ShopTypeName;
            parameters[8].Value = model.BrandID;
            parameters[9].Value = model.ShopBrand;
            parameters[10].Value = model.BrandImageBig;
            parameters[11].Value = model.BrandmageSmall;
            parameters[12].Value = model.ShopImageBig;
            parameters[13].Value = model.ShopImageSmall;
            parameters[14].Value = model.Mobile;
            parameters[15].Value = model.Email;
            parameters[16].Value = model.ProvinceID;
            parameters[17].Value = model.CityID;
            parameters[18].Value = model.RegionID;
            parameters[19].Value = model.Country;
            parameters[20].Value = model.Province;
            parameters[21].Value = model.City;
            parameters[22].Value = model.Region;
            parameters[23].Value = model.Address;
            parameters[24].Value = model.SupplyID;
            parameters[25].Value = model.SupplyName;
            parameters[26].Value = model.ShopProfile;
            parameters[27].Value = model.Content;
            parameters[28].Value = model.Remarks;
            parameters[29].Value = model.IsBrand;
            parameters[30].Value = model.IsBond;
            parameters[31].Value = model.State;
            parameters[32].Value = model.AuditState;
            parameters[33].Value = model.IsPay;
            parameters[34].Value = model.PayState;
            parameters[35].Value = model.ParentID;
            parameters[36].Value = model.ParentIDTwo;
            parameters[37].Value = model.ParentIDThree;
            parameters[38].Value = model.IDPath;
            parameters[39].Value = model.AddDate;
            parameters[40].Value = model.ModifyDate;
            parameters[41].Value = model.OrderBy;
            parameters[42].Value = model.WebSiteID;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(WebSite.Model.Mod_MallShop model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_MallShop set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("NiceName=@NiceName,");
            strSql.Append("ShopName=@ShopName,");
            strSql.Append("ShopLevelID=@ShopLevelID,");
            strSql.Append("ShopLevelName=@ShopLevelName,");
            strSql.Append("ShopTypeID=@ShopTypeID,");
            strSql.Append("ShopTypeName=@ShopTypeName,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("ShopBrand=@ShopBrand,");
            strSql.Append("BrandImageBig=@BrandImageBig,");
            strSql.Append("BrandmageSmall=@BrandmageSmall,");
            strSql.Append("ShopImageBig=@ShopImageBig,");
            strSql.Append("ShopImageSmall=@ShopImageSmall,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Email=@Email,");
            strSql.Append("ProvinceID=@ProvinceID,");
            strSql.Append("CityID=@CityID,");
            strSql.Append("RegionID=@RegionID,");
            strSql.Append("Country=@Country,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Region=@Region,");
            strSql.Append("Address=@Address,");
            strSql.Append("SupplyID=@SupplyID,");
            strSql.Append("SupplyName=@SupplyName,");
            strSql.Append("ShopProfile=@ShopProfile,");
            strSql.Append("Content=@Content,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("IsBrand=@IsBrand,");
            strSql.Append("IsBond=@IsBond,");
            strSql.Append("State=@State,");
            strSql.Append("AuditState=@AuditState,");
            strSql.Append("IsPay=@IsPay,");
            strSql.Append("PayState=@PayState,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("ParentIDTwo=@ParentIDTwo,");
            strSql.Append("ParentIDThree=@ParentIDThree,");
            strSql.Append("IDPath=@IDPath,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@NiceName", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopName", SqlDbType.NVarChar,150),
					new SqlParameter("@ShopLevelID", SqlDbType.Int,4),
					new SqlParameter("@ShopLevelName", SqlDbType.NVarChar,100),
					new SqlParameter("@ShopTypeID", SqlDbType.Int,4),
					new SqlParameter("@ShopTypeName", SqlDbType.NVarChar,100),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@ShopBrand", SqlDbType.NVarChar,100),
					new SqlParameter("@BrandImageBig", SqlDbType.NVarChar,200),
					new SqlParameter("@BrandmageSmall", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImageBig", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImageSmall", SqlDbType.NVarChar,200),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@ProvinceID", SqlDbType.Int,4),
					new SqlParameter("@CityID", SqlDbType.Int,4),
					new SqlParameter("@RegionID", SqlDbType.Int,4),
					new SqlParameter("@Country", SqlDbType.NVarChar,50),
					new SqlParameter("@Province", SqlDbType.NVarChar,50),
					new SqlParameter("@City", SqlDbType.NVarChar,50),
					new SqlParameter("@Region", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,300),
					new SqlParameter("@SupplyID", SqlDbType.Int,4),
					new SqlParameter("@SupplyName", SqlDbType.NVarChar,100),
					new SqlParameter("@ShopProfile", SqlDbType.NText),
					new SqlParameter("@Content", SqlDbType.NText),
					new SqlParameter("@Remarks", SqlDbType.NText),
					new SqlParameter("@IsBrand", SqlDbType.Int,4),
					new SqlParameter("@IsBond", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AuditState", SqlDbType.Int,4),
					new SqlParameter("@IsPay", SqlDbType.Int,4),
					new SqlParameter("@PayState", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@ParentIDTwo", SqlDbType.Int,4),
					new SqlParameter("@ParentIDThree", SqlDbType.Int,4),
					new SqlParameter("@IDPath", SqlDbType.NText),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.NiceName;
            parameters[3].Value = model.ShopName;
            parameters[4].Value = model.ShopLevelID;
            parameters[5].Value = model.ShopLevelName;
            parameters[6].Value = model.ShopTypeID;
            parameters[7].Value = model.ShopTypeName;
            parameters[8].Value = model.BrandID;
            parameters[9].Value = model.ShopBrand;
            parameters[10].Value = model.BrandImageBig;
            parameters[11].Value = model.BrandmageSmall;
            parameters[12].Value = model.ShopImageBig;
            parameters[13].Value = model.ShopImageSmall;
            parameters[14].Value = model.Mobile;
            parameters[15].Value = model.Email;
            parameters[16].Value = model.ProvinceID;
            parameters[17].Value = model.CityID;
            parameters[18].Value = model.RegionID;
            parameters[19].Value = model.Country;
            parameters[20].Value = model.Province;
            parameters[21].Value = model.City;
            parameters[22].Value = model.Region;
            parameters[23].Value = model.Address;
            parameters[24].Value = model.SupplyID;
            parameters[25].Value = model.SupplyName;
            parameters[26].Value = model.ShopProfile;
            parameters[27].Value = model.Content;
            parameters[28].Value = model.Remarks;
            parameters[29].Value = model.IsBrand;
            parameters[30].Value = model.IsBond;
            parameters[31].Value = model.State;
            parameters[32].Value = model.AuditState;
            parameters[33].Value = model.IsPay;
            parameters[34].Value = model.PayState;
            parameters[35].Value = model.ParentID;
            parameters[36].Value = model.ParentIDTwo;
            parameters[37].Value = model.ParentIDThree;
            parameters[38].Value = model.IDPath;
            parameters[39].Value = model.AddDate;
            parameters[40].Value = model.ModifyDate;
            parameters[41].Value = model.OrderBy;
            parameters[42].Value = model.WebSiteID;
            parameters[43].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_MallShop ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_MallShop ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_MallShop GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,NiceName,ShopName,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,BrandID,ShopBrand,BrandImageBig,BrandmageSmall,ShopImageBig,ShopImageSmall,Mobile,Email,ProvinceID,CityID,RegionID,Country,Province,City,Region,Address,SupplyID,SupplyName,ShopProfile,Content,Remarks,IsBrand,IsBond,State,AuditState,IsPay,PayState,ParentID,ParentIDTwo,ParentIDThree,IDPath,AddDate,ModifyDate,OrderBy,WebSiteID from SW_MallShop ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_MallShop model = new WebSite.Model.Mod_MallShop();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public WebSite.Model.Mod_MallShop DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_MallShop model = new WebSite.Model.Mod_MallShop();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Model"] != null)
                {
                    model.Model = row["Model"].ToString();
                }
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["NiceName"] != null)
                {
                    model.NiceName = row["NiceName"].ToString();
                }
                if (row["ShopName"] != null)
                {
                    model.ShopName = row["ShopName"].ToString();
                }
                if (row["ShopLevelID"] != null && row["ShopLevelID"].ToString() != "")
                {
                    model.ShopLevelID = int.Parse(row["ShopLevelID"].ToString());
                }
                if (row["ShopLevelName"] != null)
                {
                    model.ShopLevelName = row["ShopLevelName"].ToString();
                }
                if (row["ShopTypeID"] != null && row["ShopTypeID"].ToString() != "")
                {
                    model.ShopTypeID = int.Parse(row["ShopTypeID"].ToString());
                }
                if (row["ShopTypeName"] != null)
                {
                    model.ShopTypeName = row["ShopTypeName"].ToString();
                }
                if (row["BrandID"] != null && row["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(row["BrandID"].ToString());
                }
                if (row["ShopBrand"] != null)
                {
                    model.ShopBrand = row["ShopBrand"].ToString();
                }
                if (row["BrandImageBig"] != null)
                {
                    model.BrandImageBig = row["BrandImageBig"].ToString();
                }
                if (row["BrandmageSmall"] != null)
                {
                    model.BrandmageSmall = row["BrandmageSmall"].ToString();
                }
                if (row["ShopImageBig"] != null)
                {
                    model.ShopImageBig = row["ShopImageBig"].ToString();
                }
                if (row["ShopImageSmall"] != null)
                {
                    model.ShopImageSmall = row["ShopImageSmall"].ToString();
                }
                if (row["Mobile"] != null)
                {
                    model.Mobile = row["Mobile"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["ProvinceID"] != null && row["ProvinceID"].ToString() != "")
                {
                    model.ProvinceID = int.Parse(row["ProvinceID"].ToString());
                }
                if (row["CityID"] != null && row["CityID"].ToString() != "")
                {
                    model.CityID = int.Parse(row["CityID"].ToString());
                }
                if (row["RegionID"] != null && row["RegionID"].ToString() != "")
                {
                    model.RegionID = int.Parse(row["RegionID"].ToString());
                }
                if (row["Country"] != null)
                {
                    model.Country = row["Country"].ToString();
                }
                if (row["Province"] != null)
                {
                    model.Province = row["Province"].ToString();
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["Region"] != null)
                {
                    model.Region = row["Region"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["SupplyID"] != null && row["SupplyID"].ToString() != "")
                {
                    model.SupplyID = int.Parse(row["SupplyID"].ToString());
                }
                if (row["SupplyName"] != null)
                {
                    model.SupplyName = row["SupplyName"].ToString();
                }
                if (row["ShopProfile"] != null)
                {
                    model.ShopProfile = row["ShopProfile"].ToString();
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
                }
                if (row["IsBrand"] != null && row["IsBrand"].ToString() != "")
                {
                    model.IsBrand = int.Parse(row["IsBrand"].ToString());
                }
                if (row["IsBond"] != null && row["IsBond"].ToString() != "")
                {
                    model.IsBond = int.Parse(row["IsBond"].ToString());
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["AuditState"] != null && row["AuditState"].ToString() != "")
                {
                    model.AuditState = int.Parse(row["AuditState"].ToString());
                }
                if (row["IsPay"] != null && row["IsPay"].ToString() != "")
                {
                    model.IsPay = int.Parse(row["IsPay"].ToString());
                }
                if (row["PayState"] != null && row["PayState"].ToString() != "")
                {
                    model.PayState = int.Parse(row["PayState"].ToString());
                }
                if (row["ParentID"] != null && row["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(row["ParentID"].ToString());
                }
                if (row["ParentIDTwo"] != null && row["ParentIDTwo"].ToString() != "")
                {
                    model.ParentIDTwo = int.Parse(row["ParentIDTwo"].ToString());
                }
                if (row["ParentIDThree"] != null && row["ParentIDThree"].ToString() != "")
                {
                    model.ParentIDThree = int.Parse(row["ParentIDThree"].ToString());
                }
                if (row["IDPath"] != null)
                {
                    model.IDPath = row["IDPath"].ToString();
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
                {
                    model.ModifyDate = DateTime.Parse(row["ModifyDate"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["WebSiteID"] != null && row["WebSiteID"].ToString() != "")
                {
                    model.WebSiteID = int.Parse(row["WebSiteID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Model,UserID,NiceName,ShopName,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,BrandID,ShopBrand,BrandImageBig,BrandmageSmall,ShopImageBig,ShopImageSmall,Mobile,Email,ProvinceID,CityID,RegionID,Country,Province,City,Region,Address,SupplyID,SupplyName,ShopProfile,Content,Remarks,IsBrand,IsBond,State,AuditState,IsPay,PayState,ParentID,ParentIDTwo,ParentIDThree,IDPath,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_MallShop ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,Model,UserID,NiceName,ShopName,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,BrandID,ShopBrand,BrandImageBig,BrandmageSmall,ShopImageBig,ShopImageSmall,Mobile,Email,ProvinceID,CityID,RegionID,Country,Province,City,Region,Address,SupplyID,SupplyName,ShopProfile,Content,Remarks,IsBrand,IsBond,State,AuditState,IsPay,PayState,ParentID,ParentIDTwo,ParentIDThree,IDPath,AddDate,ModifyDate,OrderBy,WebSiteID ");
            strSql.Append(" FROM SW_MallShop ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM SW_MallShop ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
                strSql = "select top " + endIndex + " * from SW_MallShop where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_MallShop where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_MallShop where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
            parameters[0].Value = "SW_MallShop";
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
        /// 分页获取数据列表我的关注
        /// </summary>
        public DataSet GetListByPageALL(string strWhere, string orderby, int startIndex, int endIndex)
        {
            string strSql = "";
            if (orderby == "")
            {
                orderby = "ID";
            }
            if (startIndex <= 1)
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_MallShop.* from SW_MallShop left join SW_User on SW_MallShop.UserID=SW_User.ID where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + "  SW_User.LevelID,SW_User.LevelClass,SW_User.Image,SW_User.PicSmall,SW_User.PicBig,SW_User.NiceName ,SW_User.Model as FModel,SW_User.State as FState,SW_User.WebSiteID as FWebSiteID,SW_User.OrderBy as FOrderBy,SW_MallShop.* from SW_MallShop left join SW_User on SW_MallShop.UserID=SW_User.ID where  " + strWhere + " and  SW_MallShop.ID not in ( select top " + endIndex * (startIndex - 1) + " SW_MallShop.ID from SW_MallShop where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
            }
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_MallShop GetModelbyUserID(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,NiceName,ShopName,ShopLevelID,ShopLevelName,ShopTypeID,ShopTypeName,BrandID,ShopBrand,BrandImageBig,BrandmageSmall,ShopImageBig,ShopImageSmall,Mobile,Email,ProvinceID,CityID,RegionID,Country,Province,City,Region,Address,SupplyID,SupplyName,ShopProfile,Content,Remarks,IsBrand,IsBond,State,AuditState,IsPay,PayState,ParentID,ParentIDTwo,ParentIDThree,IDPath,AddDate,ModifyDate,OrderBy,WebSiteID from SW_MallShop ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;
            WebSite.Model.Mod_MallShop model = new WebSite.Model.Mod_MallShop();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
		#endregion  ExtensionMethod
	}
}

