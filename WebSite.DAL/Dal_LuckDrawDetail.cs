/**  版本信息模板在安装目录下，可自行修改。
* Dal_LuckDrawDetail.cs
*
* 功 能： N/A
* 类 名： Dal_LuckDrawDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/5 16:22:48   N/A    初版
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
    /// 数据访问类:Dal_LuckDrawDetail
    /// </summary>
    public partial class Dal_LuckDrawDetail
    {
        public Dal_LuckDrawDetail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_LuckDrawDetail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_LuckDrawDetail");
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
        public int Add(WebSite.Model.Mod_LuckDrawDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_LuckDrawDetail(");
            strSql.Append("Model,UserID,UserNickName,TypeID,TypeName,LuckDrawProductsID,LuckDrawProductsTitle,Content1,IsReceive,State,OrderBy,AddDate,ReceiveDate,Title,GuidSn,Image)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@UserNickName,@TypeID,@TypeName,@LuckDrawProductsID,@LuckDrawProductsTitle,@Content1,@IsReceive,@State,@OrderBy,@AddDate,@ReceiveDate,@Title,@GuidSn,@Image)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@LuckDrawProductsID", SqlDbType.Int,4),
					new SqlParameter("@LuckDrawProductsTitle", SqlDbType.VarChar,100),
					new SqlParameter("@Content1", SqlDbType.VarChar,200),
					new SqlParameter("@IsReceive", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@GuidSn", SqlDbType.VarChar,64),
					new SqlParameter("@Image", SqlDbType.VarChar,200)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserNickName;
            parameters[3].Value = model.TypeID;
            parameters[4].Value = model.TypeName;
            parameters[5].Value = model.LuckDrawProductsID;
            parameters[6].Value = model.LuckDrawProductsTitle;
            parameters[7].Value = model.Content1;
            parameters[8].Value = model.IsReceive;
            parameters[9].Value = model.State;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.AddDate;
            parameters[12].Value = model.ReceiveDate;
            parameters[13].Value = model.Title;
            parameters[14].Value = model.GuidSn;
            parameters[15].Value = model.Image;

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
        public bool Update(WebSite.Model.Mod_LuckDrawDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_LuckDrawDetail set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("LuckDrawProductsID=@LuckDrawProductsID,");
            strSql.Append("LuckDrawProductsTitle=@LuckDrawProductsTitle,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("IsReceive=@IsReceive,");
            strSql.Append("State=@State,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ReceiveDate=@ReceiveDate,");
            strSql.Append("Title=@Title,");
            strSql.Append("GuidSn=@GuidSn,");
            strSql.Append("Image=@Image");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,100),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@LuckDrawProductsID", SqlDbType.Int,4),
					new SqlParameter("@LuckDrawProductsTitle", SqlDbType.VarChar,100),
					new SqlParameter("@Content1", SqlDbType.VarChar,200),
					new SqlParameter("@IsReceive", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@GuidSn", SqlDbType.VarChar,64),
					new SqlParameter("@Image", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserNickName;
            parameters[3].Value = model.TypeID;
            parameters[4].Value = model.TypeName;
            parameters[5].Value = model.LuckDrawProductsID;
            parameters[6].Value = model.LuckDrawProductsTitle;
            parameters[7].Value = model.Content1;
            parameters[8].Value = model.IsReceive;
            parameters[9].Value = model.State;
            parameters[10].Value = model.OrderBy;
            parameters[11].Value = model.AddDate;
            parameters[12].Value = model.ReceiveDate;
            parameters[13].Value = model.Title;
            parameters[14].Value = model.GuidSn;
            parameters[15].Value = model.Image;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from SW_LuckDrawDetail ");
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
            strSql.Append("delete from SW_LuckDrawDetail ");
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
        public WebSite.Model.Mod_LuckDrawDetail GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserNickName,TypeID,TypeName,LuckDrawProductsID,LuckDrawProductsTitle,Content1,IsReceive,State,OrderBy,AddDate,ReceiveDate,Title,GuidSn,Image from SW_LuckDrawDetail ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_LuckDrawDetail model = new WebSite.Model.Mod_LuckDrawDetail();
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
        public WebSite.Model.Mod_LuckDrawDetail DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_LuckDrawDetail model = new WebSite.Model.Mod_LuckDrawDetail();
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
                if (row["UserNickName"] != null)
                {
                    model.UserNickName = row["UserNickName"].ToString();
                }
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["TypeName"] != null)
                {
                    model.TypeName = row["TypeName"].ToString();
                }
                if (row["LuckDrawProductsID"] != null && row["LuckDrawProductsID"].ToString() != "")
                {
                    model.LuckDrawProductsID = int.Parse(row["LuckDrawProductsID"].ToString());
                }
                if (row["LuckDrawProductsTitle"] != null)
                {
                    model.LuckDrawProductsTitle = row["LuckDrawProductsTitle"].ToString();
                }
                if (row["Content1"] != null)
                {
                    model.Content1 = row["Content1"].ToString();
                }
                if (row["IsReceive"] != null && row["IsReceive"].ToString() != "")
                {
                    model.IsReceive = int.Parse(row["IsReceive"].ToString());
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["OrderBy"] != null && row["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(row["OrderBy"].ToString());
                }
                if (row["AddDate"] != null && row["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(row["AddDate"].ToString());
                }
                if (row["ReceiveDate"] != null && row["ReceiveDate"].ToString() != "")
                {
                    model.ReceiveDate = DateTime.Parse(row["ReceiveDate"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["GuidSn"] != null)
                {
                    model.GuidSn = row["GuidSn"].ToString();
                }
                if (row["Image"] != null)
                {
                    model.Image = row["Image"].ToString();
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
            strSql.Append("select ID,Model,UserID,UserNickName,TypeID,TypeName,LuckDrawProductsID,LuckDrawProductsTitle,Content1,IsReceive,State,OrderBy,AddDate,ReceiveDate,Title,GuidSn,Image ");
            strSql.Append(" FROM SW_LuckDrawDetail ");
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
            strSql.Append(" ID,Model,UserID,UserNickName,TypeID,TypeName,LuckDrawProductsID,LuckDrawProductsTitle,Content1,IsReceive,State,OrderBy,AddDate,ReceiveDate,Title,GuidSn,Image ");
            strSql.Append(" FROM SW_LuckDrawDetail ");
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
            strSql.Append("select count(1) FROM SW_LuckDrawDetail ");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from SW_LuckDrawDetail T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
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
            parameters[0].Value = "SW_LuckDrawDetail";
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

        #endregion  ExtensionMethod
    }
}

