﻿
using System;
using System.Collections.Generic;
using WebSite.Common;
namespace WebSite.Model
{
	/// <summary>
	/// Mod_IntegralComment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_IntegralComment
	{
		public Mod_IntegralComment()
		{
            Global.InitModel(this);
        }
		#region Model
		private int _id;
		private string _model;
		private int _procutid;
		private string _procuttitle;
		private string _procutimage;
		private int _orderid;
		private string _orderno;
		private int _skuid;
		private string _skuspec;
		private int _integral;
		private int _reuserid;
		private string _reusername;
		private string _reusernickname;
		private int _reuserlevelid;
		private string _reuserimage;
		private string _reuserclass;
		private int _userparentsid;
		private int _replyuserid;
		private string _replyusername;
		private string _replynickname;
		private int _replyid=0;
		private string _content1;
		private string _explanation;
		private int _isreport=0;
		private int _columnid;
		private int _recolumnid;
		private int _fabulouscount;
		private int _replycount;
		private int _score;
		private int _state;
		private int _isreview;
		private int _isbest;
		private int _islook;
		private int _orderby;
		private DateTime _adddate;
		private int _websiteid;
        private List<Mod_IntegralCommentImage> _integralcommentImage;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类别模型
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 产品ID
		/// </summary>
		public int ProcutID
		{
			set{ _procutid=value;}
			get{return _procutid;}
		}
		/// <summary>
		/// 产品标题
		/// </summary>
		public string ProcutTitle
		{
			set{ _procuttitle=value;}
			get{return _procuttitle;}
		}
		/// <summary>
		/// 产品图片
		/// </summary>
		public string ProcutImage
		{
			set{ _procutimage=value;}
			get{return _procutimage;}
		}
		/// <summary>
		/// 订单ID
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
		/// 购买的产品属性ID
		/// </summary>
		public int SkuID
		{
			set{ _skuid=value;}
			get{return _skuid;}
		}
		/// <summary>
		/// 产品属性
		/// </summary>
		public string SkuSpec
		{
			set{ _skuspec=value;}
			get{return _skuspec;}
		}
		/// <summary>
		/// 购买的积分
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 评论人ID
		/// </summary>
		public int ReuserID
		{
			set{ _reuserid=value;}
			get{return _reuserid;}
		}
		/// <summary>
		/// 评论人用户名
		/// </summary>
		public string ReuserName
		{
			set{ _reusername=value;}
			get{return _reusername;}
		}
		/// <summary>
		/// 评论人昵称
		/// </summary>
		public string ReuserNickName
		{
			set{ _reusernickname=value;}
			get{return _reusernickname;}
		}
		/// <summary>
		/// 评论人级别ID
		/// </summary>
		public int ReuserLevelID
		{
			set{ _reuserlevelid=value;}
			get{return _reuserlevelid;}
		}
		/// <summary>
		/// 评论人头像
		/// </summary>
		public string ReuserImage
		{
			set{ _reuserimage=value;}
			get{return _reuserimage;}
		}
		/// <summary>
		/// 评论人头像样式
		/// </summary>
		public string ReuserClass
		{
			set{ _reuserclass=value;}
			get{return _reuserclass;}
		}
		/// <summary>
		/// 评论人父级ID
		/// </summary>
		public int UserParentsID
		{
			set{ _userparentsid=value;}
			get{return _userparentsid;}
		}
		/// <summary>
		/// 被评论人ID
		/// </summary>
		public int ReplyUserID
		{
			set{ _replyuserid=value;}
			get{return _replyuserid;}
		}
		/// <summary>
		/// 被评论人用户名
		/// </summary>
		public string ReplyUserName
		{
			set{ _replyusername=value;}
			get{return _replyusername;}
		}
		/// <summary>
		/// 被评论人昵称
		/// </summary>
		public string ReplyNickName
		{
			set{ _replynickname=value;}
			get{return _replynickname;}
		}
		/// <summary>
		/// 被回复评论的ID
		/// </summary>
		public int ReplyID
		{
			set{ _replyid=value;}
			get{return _replyid;}
		}
		/// <summary>
		/// 评论内容
		/// </summary>
		public string Content1
		{
			set{ _content1=value;}
			get{return _content1;}
		}
		/// <summary>
		/// 解析
		/// </summary>
		public string Explanation
		{
			set{ _explanation=value;}
			get{return _explanation;}
		}
		/// <summary>
		/// 是否被举报
		/// </summary>
		public int IsReport
		{
			set{ _isreport=value;}
			get{return _isreport;}
		}
		/// <summary>
		/// 当前评论级别ID
		/// </summary>
		public int ColumnID
		{
			set{ _columnid=value;}
			get{return _columnid;}
		}
		/// <summary>
		/// 回复的评论级别ID
		/// </summary>
		public int ReColumnID
		{
			set{ _recolumnid=value;}
			get{return _recolumnid;}
		}
		/// <summary>
		/// 点赞次数
		/// </summary>
		public int FabulousCount
		{
			set{ _fabulouscount=value;}
			get{return _fabulouscount;}
		}
		/// <summary>
		/// 被回复次数
		/// </summary>
		public int ReplyCount
		{
			set{ _replycount=value;}
			get{return _replycount;}
		}
		/// <summary>
		/// 服务评分
		/// </summary>
		public int Score
		{
			set{ _score=value;}
			get{return _score;}
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
		/// 是否审核通过
		/// </summary>
		public int IsReview
		{
			set{ _isreview=value;}
			get{return _isreview;}
		}
		/// <summary>
		/// 是否为最佳评论
		/// </summary>
		public int IsBest
		{
			set{ _isbest=value;}
			get{return _isbest;}
		}
		/// <summary>
		/// 是否看过
		/// </summary>
		public int IsLook
		{
			set{ _islook=value;}
			get{return _islook;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 添加时间
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
        /// <summary>
        /// 图片集合
        /// </summary>
        public List<Mod_IntegralCommentImage> IntegralCommentImage
        {
            set { _integralcommentImage = value; }
            get { return _integralcommentImage; }
        }
		#endregion Model

	}
}

