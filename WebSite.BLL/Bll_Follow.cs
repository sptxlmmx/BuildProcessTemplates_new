
using System;
using System.Data;
using System.Collections.Generic;
using WebSite.Common;
using WebSite.Model;
namespace WebSite.BLL
{
	/// <summary>
	/// Bll_Follow
	/// </summary>
	public partial class Bll_Follow
	{
		private readonly WebSite.DAL.Dal_Follow dal=new WebSite.DAL.Dal_Follow();
		public Bll_Follow()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(WebSite.Model.Mod_Follow model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_Follow model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebSite.Model.Mod_Follow GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebSite.Model.Mod_Follow GetModelByCache(int ID)
		{
			
			string CacheKey = "Mod_FollowModel-" + ID;
            object objModel = WebSite.Common.CacheHelper.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
                        int ModelCache = WebSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        WebSite.Common.CacheHelper.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WebSite.Model.Mod_Follow)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebSite.Model.Mod_Follow> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebSite.Model.Mod_Follow> DataTableToList(DataTable dt)
		{
			List<WebSite.Model.Mod_Follow> modelList = new List<WebSite.Model.Mod_Follow>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebSite.Model.Mod_Follow model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageALL(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPageALL(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageFans(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPageFans(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取json数据列表
        /// </summary>
        public List<WebSite.Model.Mod_Follow> GetListByPageALLjson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            DataSet ds = dal.GetListByPageALL(strWhere, orderby, startIndex, endIndex);
            return DataTableToList(ds.Tables[0]);
            //return dal.GetListByPageALL(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取json数据列表
        /// </summary>
        public List<WebSite.Model.Mod_Follow> GetListByPageFansjson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            DataSet ds = dal.GetListByPageFans(strWhere, orderby, startIndex, endIndex);
            return DataTableToList(ds.Tables[0]);
            //return dal.GetListByPageFans(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_Follow GetModelUserID(int UserID, int BuserID)
        {

            return dal.GetModelUserID(UserID, BuserID);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteUserID(int UserID, int BuserID)
        {
            return dal.DeleteUserID(UserID, BuserID);
        }
		#endregion  ExtensionMethod
	}
}

