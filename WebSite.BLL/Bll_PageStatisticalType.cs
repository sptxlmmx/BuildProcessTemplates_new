
using System;
using System.Data;
using System.Collections.Generic;
using WebSite.Common;
using WebSite.Model;
namespace WebSite.BLL
{
	/// <summary>
	/// Bll_PageStatisticalType
	/// </summary>
	public partial class Bll_PageStatisticalType
	{
		private readonly WebSite.DAL.Dal_PageStatisticalType dal=new WebSite.DAL.Dal_PageStatisticalType();
		public Bll_PageStatisticalType()
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
		public int  Add(WebSite.Model.Mod_PageStatisticalType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_PageStatisticalType model)
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
		public WebSite.Model.Mod_PageStatisticalType GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebSite.Model.Mod_PageStatisticalType GetModelByCache(int ID)
		{
			
			string CacheKey = "Mod_PageStatisticalTypeModel-" + ID;
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
			return (WebSite.Model.Mod_PageStatisticalType)objModel;
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
		public List<WebSite.Model.Mod_PageStatisticalType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebSite.Model.Mod_PageStatisticalType> DataTableToList(DataTable dt)
		{
			List<WebSite.Model.Mod_PageStatisticalType> modelList = new List<WebSite.Model.Mod_PageStatisticalType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebSite.Model.Mod_PageStatisticalType model;
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string WhereStr)
        {
            return dal.DeleteWhere(WhereStr);
        }
		#endregion  ExtensionMethod
	}
}

