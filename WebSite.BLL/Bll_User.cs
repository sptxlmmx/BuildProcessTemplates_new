using System;
using System.Data;
using System.Collections.Generic;
using WebSite.Common;
using WebSite.Model;
namespace WebSite.BLL
{
	/// <summary>
	/// Bll_User
	/// </summary>
	public partial class Bll_User
	{
		private readonly WebSite.DAL.Dal_User dal=new WebSite.DAL.Dal_User();
		public Bll_User()
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
		public int  Add(WebSite.Model.Mod_User model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebSite.Model.Mod_User model)
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
		public WebSite.Model.Mod_User GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebSite.Model.Mod_User GetModelByCache(int ID)
		{
			
			string CacheKey = "Mod_UserModel-" + ID;
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
			return (WebSite.Model.Mod_User)objModel;
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
		public List<WebSite.Model.Mod_User> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebSite.Model.Mod_User> DataTableToList(DataTable dt)
		{
			List<WebSite.Model.Mod_User> modelList = new List<WebSite.Model.Mod_User>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebSite.Model.Mod_User model;
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
        /// 获得数据模型列表（可以取前几条）
        /// </summary>
        public List<WebSite.Model.Mod_User> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataSet ds = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据模型列表（可以获取从startIndex开始的后endIndex条）
        /// </summary>
        public List<WebSite.Model.Mod_User> GetModelList(int startIndex, int endIndex,string strWhere, string orderby)
        {
            DataSet ds = dal.GetListByPage2(strWhere, orderby, startIndex, endIndex);
            return DataTableToList(ds.Tables[0]);
        }
         /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage2(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage2(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 通过主页地址得到一个对象实体
        /// </summary>
        public WebSite.Model.Mod_User GetModel(string HomeUrl)
        {

            return dal.GetModel(HomeUrl);
        }
        /// <summary>
        /// 是否存在该昵称
        /// </summary>
        public bool ExistsNiceName(string NiceName)
        {
            return dal.ExistsNiceName(NiceName);
        }
        /// <summary>
        /// 是否存在该用户名
        /// </summary>
        public bool ExistsUserName(string UserName)
        {
            return dal.ExistsUserName(UserName);
        }

        /// <summary>
        /// 是否存在该邮箱
        /// </summary>
        public bool ExistsEmail(String Email)
        {
            return dal.ExistsEmail(Email);
        }

        /// <summary>
        /// 是否存在该手机
        /// </summary>
        public bool ExistsMobile(String Mobile)
        {
            return dal.ExistsMobile(Mobile);
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        public bool ExistsLogin(String UserName, String Password)
        {
            return dal.ExistsLogin(UserName, Password);
        }

        /// <summary>
        /// 是否存在该邮箱验证码
        /// </summary>
        public WebSite.Model.Mod_User ExistsEmailCode(String EmailCode)
        {
            return dal.ExistsEmailCode(EmailCode);
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        public WebSite.Model.Mod_User LoginUser(String UserName, String Password)
        {
            return dal.LoginUser(UserName, Password);
        }

        /// <summary>
        /// 找回密码
        /// </summary>
        public WebSite.Model.Mod_User ExistsForgot(String UserName, String Email)
        {
            return dal.ExistsForgot(UserName, Email);
        }
        /// <summary>
        /// 邮箱登录验证
        /// </summary>
        public WebSite.Model.Mod_User ExistsEmailLogin(String Email)
        {
            return dal.ExistsEmailLogin(Email);
        }
        /// <summary>
        /// 手机登陆验证
        /// </summary>
        public WebSite.Model.Mod_User ExistsMobileLogin(String Mobile)
        {
            return dal.ExistsMobileLogin(Mobile);
        }
        /// 是否存在该用户名昵称
        /// </summary>
        public bool ExistsNiceName(string UserName, int ID)
        {
            return dal.ExistsNiceName(UserName, ID);
        }
		#endregion  ExtensionMethod
	}
}

