
using System;
using System.Data;
using System.Collections.Generic;
using WebSite.Common;
using WebSite.Model;
namespace WebSite.BLL
{
	/// <summary>
	/// Bll_AlbumImage
	/// </summary>
	public partial class Bll_AlbumImage
	{
		private readonly WebSite.DAL.Dal_AlbumImage dal=new WebSite.DAL.Dal_AlbumImage();
		public Bll_AlbumImage()
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
		public int  Add(WebSite.Model.Mod_AlbumImage model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_AlbumImage model)
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
		public WebSite.Model.Mod_AlbumImage GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebSite.Model.Mod_AlbumImage GetModelByCache(int ID)
		{
			
			string CacheKey = "Mod_AlbumImageModel-" + ID;
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
			return (WebSite.Model.Mod_AlbumImage)objModel;
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
		public List<WebSite.Model.Mod_AlbumImage> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebSite.Model.Mod_AlbumImage> DataTableToList(DataTable dt)
		{
			List<WebSite.Model.Mod_AlbumImage> modelList = new List<WebSite.Model.Mod_AlbumImage>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebSite.Model.Mod_AlbumImage model;
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
        /// 修改数据
        /// </summary>
        public bool UpdateAlbum(int AlbumTypeID, string ID, int UserID)
        {
            return dal.UpdateAlbum(AlbumTypeID, ID, UserID);
        }
        /// <summary>
        /// 删除相册图片和数据
        /// </summary>
        public bool DeleteFile(string CommentIDStr, bool IsDel)
        {
            return dal.DeleteFile(CommentIDStr, IsDel);
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCountALL(string strWhere)
        {
            return dal.GetRecordCountALL(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageLeftJoin(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPageLeftJoin(strWhere, orderby, startIndex, endIndex);
        }

		#endregion  ExtensionMethod
	}
}

