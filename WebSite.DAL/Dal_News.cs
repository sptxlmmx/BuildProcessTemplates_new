
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebSite.DBUtility;//Please add references
namespace WebSite.DAL
{
	/// <summary>
	/// 数据访问类:Dal_News
	/// </summary>
	public partial class Dal_News
	{
		public Dal_News()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SW_News");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SW_News");
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
        public int Add(WebSite.Model.Mod_News model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SW_News(");
            strSql.Append("Model,UserID,UserName,UserLevelID,UserLevelName,UserNickName,UserImage,UserlevelClass,Title,TypeID,TypeName,STypeID,STypeIDs,STypeName,CustomTypeID,CustomTypeName,Author,Content1,Content2,Introduction,Remarks,AddDate,ModifyDate,OrderBy,State,Tags,Tags1,Tags2,Tags3,Tags4,ImageUrl,PicBig,FileUrl,IsReview,ReviewID,ReviewName,AdminID,AdminName,IsCommend,IsCommendHot,Integral,Money,IsMoney,RedEnvelopes,IsRedEnvelopes,IsTop,IsHot,IsNew,IsApplyOriginal,IsOriginal,IsLaunch,BrowseCount,CommentCount,FabulousCount,ReportCount,Allmoney,AllIntegral,ActionCount,CommendTitle,CommendUrl,Province,City,Region,WithdrawMoney,RegionID,ProveCount,IsWithdraw,IsGifts,IsGiftsReview,GiftsTypeID,GiftsTypeName,GiftsProductID,GiftsUrl,IsHelp,HelpTypeID,HelpTypeName,HelpRealName,TargetAmount,Commitmentstatement,MaterialScience,AuditInstructions,Helpcontentstr1,Helpcontentstr2,Helpcontentstr3,Helpcontentstr4,Helpcontentstr5,Helpcontentstr6,Helpcontentstr7,Helpcontentstr8,SeoTitle,SeoKeywords,SeoDescription,IsFabulous,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSiteID)");
            strSql.Append(" values (");
            strSql.Append("@Model,@UserID,@UserName,@UserLevelID,@UserLevelName,@UserNickName,@UserImage,@UserlevelClass,@Title,@TypeID,@TypeName,@STypeID,@STypeIDs,@STypeName,@CustomTypeID,@CustomTypeName,@Author,@Content1,@Content2,@Introduction,@Remarks,@AddDate,@ModifyDate,@OrderBy,@State,@Tags,@Tags1,@Tags2,@Tags3,@Tags4,@ImageUrl,@PicBig,@FileUrl,@IsReview,@ReviewID,@ReviewName,@AdminID,@AdminName,@IsCommend,@IsCommendHot,@Integral,@Money,@IsMoney,@RedEnvelopes,@IsRedEnvelopes,@IsTop,@IsHot,@IsNew,@IsApplyOriginal,@IsOriginal,@IsLaunch,@BrowseCount,@CommentCount,@FabulousCount,@ReportCount,@Allmoney,@AllIntegral,@ActionCount,@CommendTitle,@CommendUrl,@Province,@City,@Region,@WithdrawMoney,@RegionID,@ProveCount,@IsWithdraw,@IsGifts,@IsGiftsReview,@GiftsTypeID,@GiftsTypeName,@GiftsProductID,@GiftsUrl,@IsHelp,@HelpTypeID,@HelpTypeName,@HelpRealName,@TargetAmount,@Commitmentstatement,@MaterialScience,@AuditInstructions,@Helpcontentstr1,@Helpcontentstr2,@Helpcontentstr3,@Helpcontentstr4,@Helpcontentstr5,@Helpcontentstr6,@Helpcontentstr7,@Helpcontentstr8,@SeoTitle,@SeoKeywords,@SeoDescription,@IsFabulous,@OtherInt1,@OtherInt2,@OtherInt3,@OtherInt4,@OtherInt5,@OtherInt6,@OtherInt7,@OtherInt8,@OtherInt9,@OtherInt10,@OtherInt11,@OtherInt12,@OtherInt13,@OtherInt14,@OtherInt15,@OtherString1,@OtherString2,@OtherString3,@OtherString4,@OtherString5,@OtherString6,@OtherString7,@OtherString8,@OtherString9,@OtherString10,@OtherText1,@OtherText2,@OtherText3,@OtherText4,@OtherText5,@WebSiteID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserLevelID", SqlDbType.Int,4),
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,500),
					new SqlParameter("@UserlevelClass", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.NVarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,200),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeIDs", SqlDbType.VarChar,200),
					new SqlParameter("@STypeName", SqlDbType.VarChar,200),
					new SqlParameter("@CustomTypeID", SqlDbType.Int,4),
					new SqlParameter("@CustomTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@Author", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@Content2", SqlDbType.NText),
					new SqlParameter("@Introduction", SqlDbType.VarChar,2000),
					new SqlParameter("@Remarks", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.Text),
					new SqlParameter("@Tags1", SqlDbType.VarChar,200),
					new SqlParameter("@Tags2", SqlDbType.VarChar,200),
					new SqlParameter("@Tags3", SqlDbType.VarChar,200),
					new SqlParameter("@Tags4", SqlDbType.VarChar,200),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,500),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@FileUrl", SqlDbType.VarChar,500),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@ReviewID", SqlDbType.Int,4),
					new SqlParameter("@ReviewName", SqlDbType.VarChar,200),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@AdminName", SqlDbType.VarChar,200),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsCommendHot", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsMoney", SqlDbType.Int,4),
					new SqlParameter("@RedEnvelopes", SqlDbType.Decimal,9),
					new SqlParameter("@IsRedEnvelopes", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsApplyOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsLaunch", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@AllIntegral", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@CommendTitle", SqlDbType.VarChar,200),
					new SqlParameter("@CommendUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@Region", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawMoney", SqlDbType.Decimal,9),
					new SqlParameter("@RegionID", SqlDbType.Int,4),
					new SqlParameter("@ProveCount", SqlDbType.Int,4),
					new SqlParameter("@IsWithdraw", SqlDbType.Int,4),
					new SqlParameter("@IsGifts", SqlDbType.Int,4),
					new SqlParameter("@IsGiftsReview", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeID", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@GiftsProductID", SqlDbType.Int,4),
					new SqlParameter("@GiftsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@IsHelp", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeID", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@HelpRealName", SqlDbType.VarChar,200),
					new SqlParameter("@TargetAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Commitmentstatement", SqlDbType.Text),
					new SqlParameter("@MaterialScience", SqlDbType.Text),
					new SqlParameter("@AuditInstructions", SqlDbType.Text),
					new SqlParameter("@Helpcontentstr1", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr2", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr3", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr4", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr5", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr6", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr7", SqlDbType.NText),
					new SqlParameter("@Helpcontentstr8", SqlDbType.NText),
					new SqlParameter("@SeoTitle", SqlDbType.VarChar,200),
					new SqlParameter("@SeoKeywords", SqlDbType.Text),
					new SqlParameter("@SeoDescription", SqlDbType.Text),
					new SqlParameter("@IsFabulous", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherInt6", SqlDbType.Int,4),
					new SqlParameter("@OtherInt7", SqlDbType.Int,4),
					new SqlParameter("@OtherInt8", SqlDbType.Int,4),
					new SqlParameter("@OtherInt9", SqlDbType.Int,4),
					new SqlParameter("@OtherInt10", SqlDbType.Int,4),
					new SqlParameter("@OtherInt11", SqlDbType.Int,4),
					new SqlParameter("@OtherInt12", SqlDbType.Int,4),
					new SqlParameter("@OtherInt13", SqlDbType.Int,4),
					new SqlParameter("@OtherInt14", SqlDbType.Int,4),
					new SqlParameter("@OtherInt15", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.NText),
					new SqlParameter("@OtherText5", SqlDbType.NText),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserLevelID;
            parameters[4].Value = model.UserLevelName;
            parameters[5].Value = model.UserNickName;
            parameters[6].Value = model.UserImage;
            parameters[7].Value = model.UserlevelClass;
            parameters[8].Value = model.Title;
            parameters[9].Value = model.TypeID;
            parameters[10].Value = model.TypeName;
            parameters[11].Value = model.STypeID;
            parameters[12].Value = model.STypeIDs;
            parameters[13].Value = model.STypeName;
            parameters[14].Value = model.CustomTypeID;
            parameters[15].Value = model.CustomTypeName;
            parameters[16].Value = model.Author;
            parameters[17].Value = model.Content1;
            parameters[18].Value = model.Content2;
            parameters[19].Value = model.Introduction;
            parameters[20].Value = model.Remarks;
            parameters[21].Value = model.AddDate;
            parameters[22].Value = model.ModifyDate;
            parameters[23].Value = model.OrderBy;
            parameters[24].Value = model.State;
            parameters[25].Value = model.Tags;
            parameters[26].Value = model.Tags1;
            parameters[27].Value = model.Tags2;
            parameters[28].Value = model.Tags3;
            parameters[29].Value = model.Tags4;
            parameters[30].Value = model.ImageUrl;
            parameters[31].Value = model.PicBig;
            parameters[32].Value = model.FileUrl;
            parameters[33].Value = model.IsReview;
            parameters[34].Value = model.ReviewID;
            parameters[35].Value = model.ReviewName;
            parameters[36].Value = model.AdminID;
            parameters[37].Value = model.AdminName;
            parameters[38].Value = model.IsCommend;
            parameters[39].Value = model.IsCommendHot;
            parameters[40].Value = model.Integral;
            parameters[41].Value = model.Money;
            parameters[42].Value = model.IsMoney;
            parameters[43].Value = model.RedEnvelopes;
            parameters[44].Value = model.IsRedEnvelopes;
            parameters[45].Value = model.IsTop;
            parameters[46].Value = model.IsHot;
            parameters[47].Value = model.IsNew;
            parameters[48].Value = model.IsApplyOriginal;
            parameters[49].Value = model.IsOriginal;
            parameters[50].Value = model.IsLaunch;
            parameters[51].Value = model.BrowseCount;
            parameters[52].Value = model.CommentCount;
            parameters[53].Value = model.FabulousCount;
            parameters[54].Value = model.ReportCount;
            parameters[55].Value = model.Allmoney;
            parameters[56].Value = model.AllIntegral;
            parameters[57].Value = model.ActionCount;
            parameters[58].Value = model.CommendTitle;
            parameters[59].Value = model.CommendUrl;
            parameters[60].Value = model.Province;
            parameters[61].Value = model.City;
            parameters[62].Value = model.Region;
            parameters[63].Value = model.WithdrawMoney;
            parameters[64].Value = model.RegionID;
            parameters[65].Value = model.ProveCount;
            parameters[66].Value = model.IsWithdraw;
            parameters[67].Value = model.IsGifts;
            parameters[68].Value = model.IsGiftsReview;
            parameters[69].Value = model.GiftsTypeID;
            parameters[70].Value = model.GiftsTypeName;
            parameters[71].Value = model.GiftsProductID;
            parameters[72].Value = model.GiftsUrl;
            parameters[73].Value = model.IsHelp;
            parameters[74].Value = model.HelpTypeID;
            parameters[75].Value = model.HelpTypeName;
            parameters[76].Value = model.HelpRealName;
            parameters[77].Value = model.TargetAmount;
            parameters[78].Value = model.Commitmentstatement;
            parameters[79].Value = model.MaterialScience;
            parameters[80].Value = model.AuditInstructions;
            parameters[81].Value = model.Helpcontentstr1;
            parameters[82].Value = model.Helpcontentstr2;
            parameters[83].Value = model.Helpcontentstr3;
            parameters[84].Value = model.Helpcontentstr4;
            parameters[85].Value = model.Helpcontentstr5;
            parameters[86].Value = model.Helpcontentstr6;
            parameters[87].Value = model.Helpcontentstr7;
            parameters[88].Value = model.Helpcontentstr8;
            parameters[89].Value = model.SeoTitle;
            parameters[90].Value = model.SeoKeywords;
            parameters[91].Value = model.SeoDescription;
            parameters[92].Value = model.IsFabulous;
            parameters[93].Value = model.OtherInt1;
            parameters[94].Value = model.OtherInt2;
            parameters[95].Value = model.OtherInt3;
            parameters[96].Value = model.OtherInt4;
            parameters[97].Value = model.OtherInt5;
            parameters[98].Value = model.OtherInt6;
            parameters[99].Value = model.OtherInt7;
            parameters[100].Value = model.OtherInt8;
            parameters[101].Value = model.OtherInt9;
            parameters[102].Value = model.OtherInt10;
            parameters[103].Value = model.OtherInt11;
            parameters[104].Value = model.OtherInt12;
            parameters[105].Value = model.OtherInt13;
            parameters[106].Value = model.OtherInt14;
            parameters[107].Value = model.OtherInt15;
            parameters[108].Value = model.OtherString1;
            parameters[109].Value = model.OtherString2;
            parameters[110].Value = model.OtherString3;
            parameters[111].Value = model.OtherString4;
            parameters[112].Value = model.OtherString5;
            parameters[113].Value = model.OtherString6;
            parameters[114].Value = model.OtherString7;
            parameters[115].Value = model.OtherString8;
            parameters[116].Value = model.OtherString9;
            parameters[117].Value = model.OtherString10;
            parameters[118].Value = model.OtherText1;
            parameters[119].Value = model.OtherText2;
            parameters[120].Value = model.OtherText3;
            parameters[121].Value = model.OtherText4;
            parameters[122].Value = model.OtherText5;
            parameters[123].Value = model.WebSiteID;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
                return model.ID;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WebSite.Model.Mod_News model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_News set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserLevelID=@UserLevelID,");
            strSql.Append("UserLevelName=@UserLevelName,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("UserImage=@UserImage,");
            strSql.Append("UserlevelClass=@UserlevelClass,");
            strSql.Append("Title=@Title,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("STypeID=@STypeID,");
            strSql.Append("STypeIDs=@STypeIDs,");
            strSql.Append("STypeName=@STypeName,");
            strSql.Append("CustomTypeID=@CustomTypeID,");
            strSql.Append("CustomTypeName=@CustomTypeName,");
            strSql.Append("Author=@Author,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("Content2=@Content2,");
            strSql.Append("Introduction=@Introduction,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("State=@State,");
            strSql.Append("Tags=@Tags,");
            strSql.Append("Tags1=@Tags1,");
            strSql.Append("Tags2=@Tags2,");
            strSql.Append("Tags3=@Tags3,");
            strSql.Append("Tags4=@Tags4,");
            strSql.Append("ImageUrl=@ImageUrl,");
            strSql.Append("PicBig=@PicBig,");
            strSql.Append("FileUrl=@FileUrl,");
            strSql.Append("IsReview=@IsReview,");
            strSql.Append("ReviewID=@ReviewID,");
            strSql.Append("ReviewName=@ReviewName,");
            strSql.Append("AdminID=@AdminID,");
            strSql.Append("AdminName=@AdminName,");
            strSql.Append("IsCommend=@IsCommend,");
            strSql.Append("IsCommendHot=@IsCommendHot,");
            strSql.Append("Integral=@Integral,");
            strSql.Append("Money=@Money,");
            strSql.Append("IsMoney=@IsMoney,");
            strSql.Append("RedEnvelopes=@RedEnvelopes,");
            strSql.Append("IsRedEnvelopes=@IsRedEnvelopes,");
            strSql.Append("IsTop=@IsTop,");
            strSql.Append("IsHot=@IsHot,");
            strSql.Append("IsNew=@IsNew,");
            strSql.Append("IsApplyOriginal=@IsApplyOriginal,");
            strSql.Append("IsOriginal=@IsOriginal,");
            strSql.Append("IsLaunch=@IsLaunch,");
            strSql.Append("BrowseCount=@BrowseCount,");
            strSql.Append("CommentCount=@CommentCount,");
            strSql.Append("FabulousCount=@FabulousCount,");
            strSql.Append("ReportCount=@ReportCount,");
            strSql.Append("Allmoney=@Allmoney,");
            strSql.Append("AllIntegral=@AllIntegral,");
            strSql.Append("ActionCount=@ActionCount,");
            strSql.Append("CommendTitle=@CommendTitle,");
            strSql.Append("CommendUrl=@CommendUrl,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Region=@Region,");
            strSql.Append("WithdrawMoney=@WithdrawMoney,");
            strSql.Append("RegionID=@RegionID,");
            strSql.Append("ProveCount=@ProveCount,");
            strSql.Append("IsWithdraw=@IsWithdraw,");
            strSql.Append("IsGifts=@IsGifts,");
            strSql.Append("IsGiftsReview=@IsGiftsReview,");
            strSql.Append("GiftsTypeID=@GiftsTypeID,");
            strSql.Append("GiftsTypeName=@GiftsTypeName,");
            strSql.Append("GiftsProductID=@GiftsProductID,");
            strSql.Append("GiftsUrl=@GiftsUrl,");
            strSql.Append("IsHelp=@IsHelp,");
            strSql.Append("HelpTypeID=@HelpTypeID,");
            strSql.Append("HelpTypeName=@HelpTypeName,");
            strSql.Append("HelpRealName=@HelpRealName,");
            strSql.Append("TargetAmount=@TargetAmount,");
            strSql.Append("Commitmentstatement=@Commitmentstatement,");
            strSql.Append("MaterialScience=@MaterialScience,");
            strSql.Append("AuditInstructions=@AuditInstructions,");
            strSql.Append("Helpcontentstr1=@Helpcontentstr1,");
            strSql.Append("Helpcontentstr2=@Helpcontentstr2,");
            strSql.Append("Helpcontentstr3=@Helpcontentstr3,");
            strSql.Append("Helpcontentstr4=@Helpcontentstr4,");
            strSql.Append("Helpcontentstr5=@Helpcontentstr5,");
            strSql.Append("Helpcontentstr6=@Helpcontentstr6,");
            strSql.Append("Helpcontentstr7=@Helpcontentstr7,");
            strSql.Append("Helpcontentstr8=@Helpcontentstr8,");
            strSql.Append("SeoTitle=@SeoTitle,");
            strSql.Append("SeoKeywords=@SeoKeywords,");
            strSql.Append("SeoDescription=@SeoDescription,");
            strSql.Append("IsFabulous=@IsFabulous,");
            strSql.Append("OtherInt1=@OtherInt1,");
            strSql.Append("OtherInt2=@OtherInt2,");
            strSql.Append("OtherInt3=@OtherInt3,");
            strSql.Append("OtherInt4=@OtherInt4,");
            strSql.Append("OtherInt5=@OtherInt5,");
            strSql.Append("OtherInt6=@OtherInt6,");
            strSql.Append("OtherInt7=@OtherInt7,");
            strSql.Append("OtherInt8=@OtherInt8,");
            strSql.Append("OtherInt9=@OtherInt9,");
            strSql.Append("OtherInt10=@OtherInt10,");
            strSql.Append("OtherInt11=@OtherInt11,");
            strSql.Append("OtherInt12=@OtherInt12,");
            strSql.Append("OtherInt13=@OtherInt13,");
            strSql.Append("OtherInt14=@OtherInt14,");
            strSql.Append("OtherInt15=@OtherInt15,");
            strSql.Append("OtherString1=@OtherString1,");
            strSql.Append("OtherString2=@OtherString2,");
            strSql.Append("OtherString3=@OtherString3,");
            strSql.Append("OtherString4=@OtherString4,");
            strSql.Append("OtherString5=@OtherString5,");
            strSql.Append("OtherString6=@OtherString6,");
            strSql.Append("OtherString7=@OtherString7,");
            strSql.Append("OtherString8=@OtherString8,");
            strSql.Append("OtherString9=@OtherString9,");
            strSql.Append("OtherString10=@OtherString10,");
            strSql.Append("OtherText1=@OtherText1,");
            strSql.Append("OtherText2=@OtherText2,");
            strSql.Append("OtherText3=@OtherText3,");
            strSql.Append("OtherText4=@OtherText4,");
            strSql.Append("OtherText5=@OtherText5,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserLevelID", SqlDbType.Int,4),
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,500),
					new SqlParameter("@UserlevelClass", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.NVarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,200),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeIDs", SqlDbType.VarChar,200),
					new SqlParameter("@STypeName", SqlDbType.VarChar,200),
					new SqlParameter("@CustomTypeID", SqlDbType.Int,4),
					new SqlParameter("@CustomTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@Author", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@Content2", SqlDbType.NText),
					new SqlParameter("@Introduction", SqlDbType.VarChar,2000),
					new SqlParameter("@Remarks", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.Text),
					new SqlParameter("@Tags1", SqlDbType.VarChar,200),
					new SqlParameter("@Tags2", SqlDbType.VarChar,200),
					new SqlParameter("@Tags3", SqlDbType.VarChar,200),
					new SqlParameter("@Tags4", SqlDbType.VarChar,200),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,500),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@FileUrl", SqlDbType.VarChar,500),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@ReviewID", SqlDbType.Int,4),
					new SqlParameter("@ReviewName", SqlDbType.VarChar,200),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@AdminName", SqlDbType.VarChar,200),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsCommendHot", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsMoney", SqlDbType.Int,4),
					new SqlParameter("@RedEnvelopes", SqlDbType.Decimal,9),
					new SqlParameter("@IsRedEnvelopes", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsApplyOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsLaunch", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@AllIntegral", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@CommendTitle", SqlDbType.VarChar,200),
					new SqlParameter("@CommendUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@Region", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawMoney", SqlDbType.Decimal,9),
					new SqlParameter("@RegionID", SqlDbType.Int,4),
					new SqlParameter("@ProveCount", SqlDbType.Int,4),
					new SqlParameter("@IsWithdraw", SqlDbType.Int,4),
					new SqlParameter("@IsGifts", SqlDbType.Int,4),
					new SqlParameter("@IsGiftsReview", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeID", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@GiftsProductID", SqlDbType.Int,4),
					new SqlParameter("@GiftsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@IsHelp", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeID", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@HelpRealName", SqlDbType.VarChar,200),
					new SqlParameter("@TargetAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Commitmentstatement", SqlDbType.Text),
					new SqlParameter("@MaterialScience", SqlDbType.Text),
					new SqlParameter("@AuditInstructions", SqlDbType.Text),
					new SqlParameter("@Helpcontentstr1", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr2", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr3", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr4", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr5", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr6", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr7", SqlDbType.NText),
					new SqlParameter("@Helpcontentstr8", SqlDbType.NText),
					new SqlParameter("@SeoTitle", SqlDbType.VarChar,200),
					new SqlParameter("@SeoKeywords", SqlDbType.Text),
					new SqlParameter("@SeoDescription", SqlDbType.Text),
					new SqlParameter("@IsFabulous", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherInt6", SqlDbType.Int,4),
					new SqlParameter("@OtherInt7", SqlDbType.Int,4),
					new SqlParameter("@OtherInt8", SqlDbType.Int,4),
					new SqlParameter("@OtherInt9", SqlDbType.Int,4),
					new SqlParameter("@OtherInt10", SqlDbType.Int,4),
					new SqlParameter("@OtherInt11", SqlDbType.Int,4),
					new SqlParameter("@OtherInt12", SqlDbType.Int,4),
					new SqlParameter("@OtherInt13", SqlDbType.Int,4),
					new SqlParameter("@OtherInt14", SqlDbType.Int,4),
					new SqlParameter("@OtherInt15", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.NText),
					new SqlParameter("@OtherText5", SqlDbType.NText),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserLevelID;
            parameters[4].Value = model.UserLevelName;
            parameters[5].Value = model.UserNickName;
            parameters[6].Value = model.UserImage;
            parameters[7].Value = model.UserlevelClass;
            parameters[8].Value = model.Title;
            parameters[9].Value = model.TypeID;
            parameters[10].Value = model.TypeName;
            parameters[11].Value = model.STypeID;
            parameters[12].Value = model.STypeIDs;
            parameters[13].Value = model.STypeName;
            parameters[14].Value = model.CustomTypeID;
            parameters[15].Value = model.CustomTypeName;
            parameters[16].Value = model.Author;
            parameters[17].Value = model.Content1;
            parameters[18].Value = model.Content2;
            parameters[19].Value = model.Introduction;
            parameters[20].Value = model.Remarks;
            parameters[21].Value = model.AddDate;
            parameters[22].Value = model.ModifyDate;
            parameters[23].Value = model.OrderBy;
            parameters[24].Value = model.State;
            parameters[25].Value = model.Tags;
            parameters[26].Value = model.Tags1;
            parameters[27].Value = model.Tags2;
            parameters[28].Value = model.Tags3;
            parameters[29].Value = model.Tags4;
            parameters[30].Value = model.ImageUrl;
            parameters[31].Value = model.PicBig;
            parameters[32].Value = model.FileUrl;
            parameters[33].Value = model.IsReview;
            parameters[34].Value = model.ReviewID;
            parameters[35].Value = model.ReviewName;
            parameters[36].Value = model.AdminID;
            parameters[37].Value = model.AdminName;
            parameters[38].Value = model.IsCommend;
            parameters[39].Value = model.IsCommendHot;
            parameters[40].Value = model.Integral;
            parameters[41].Value = model.Money;
            parameters[42].Value = model.IsMoney;
            parameters[43].Value = model.RedEnvelopes;
            parameters[44].Value = model.IsRedEnvelopes;
            parameters[45].Value = model.IsTop;
            parameters[46].Value = model.IsHot;
            parameters[47].Value = model.IsNew;
            parameters[48].Value = model.IsApplyOriginal;
            parameters[49].Value = model.IsOriginal;
            parameters[50].Value = model.IsLaunch;
            parameters[51].Value = model.BrowseCount;
            parameters[52].Value = model.CommentCount;
            parameters[53].Value = model.FabulousCount;
            parameters[54].Value = model.ReportCount;
            parameters[55].Value = model.Allmoney;
            parameters[56].Value = model.AllIntegral;
            parameters[57].Value = model.ActionCount;
            parameters[58].Value = model.CommendTitle;
            parameters[59].Value = model.CommendUrl;
            parameters[60].Value = model.Province;
            parameters[61].Value = model.City;
            parameters[62].Value = model.Region;
            parameters[63].Value = model.WithdrawMoney;
            parameters[64].Value = model.RegionID;
            parameters[65].Value = model.ProveCount;
            parameters[66].Value = model.IsWithdraw;
            parameters[67].Value = model.IsGifts;
            parameters[68].Value = model.IsGiftsReview;
            parameters[69].Value = model.GiftsTypeID;
            parameters[70].Value = model.GiftsTypeName;
            parameters[71].Value = model.GiftsProductID;
            parameters[72].Value = model.GiftsUrl;
            parameters[73].Value = model.IsHelp;
            parameters[74].Value = model.HelpTypeID;
            parameters[75].Value = model.HelpTypeName;
            parameters[76].Value = model.HelpRealName;
            parameters[77].Value = model.TargetAmount;
            parameters[78].Value = model.Commitmentstatement;
            parameters[79].Value = model.MaterialScience;
            parameters[80].Value = model.AuditInstructions;
            parameters[81].Value = model.Helpcontentstr1;
            parameters[82].Value = model.Helpcontentstr2;
            parameters[83].Value = model.Helpcontentstr3;
            parameters[84].Value = model.Helpcontentstr4;
            parameters[85].Value = model.Helpcontentstr5;
            parameters[86].Value = model.Helpcontentstr6;
            parameters[87].Value = model.Helpcontentstr7;
            parameters[88].Value = model.Helpcontentstr8;
            parameters[89].Value = model.SeoTitle;
            parameters[90].Value = model.SeoKeywords;
            parameters[91].Value = model.SeoDescription;
            parameters[92].Value = model.IsFabulous;
            parameters[93].Value = model.OtherInt1;
            parameters[94].Value = model.OtherInt2;
            parameters[95].Value = model.OtherInt3;
            parameters[96].Value = model.OtherInt4;
            parameters[97].Value = model.OtherInt5;
            parameters[98].Value = model.OtherInt6;
            parameters[99].Value = model.OtherInt7;
            parameters[100].Value = model.OtherInt8;
            parameters[101].Value = model.OtherInt9;
            parameters[102].Value = model.OtherInt10;
            parameters[103].Value = model.OtherInt11;
            parameters[104].Value = model.OtherInt12;
            parameters[105].Value = model.OtherInt13;
            parameters[106].Value = model.OtherInt14;
            parameters[107].Value = model.OtherInt15;
            parameters[108].Value = model.OtherString1;
            parameters[109].Value = model.OtherString2;
            parameters[110].Value = model.OtherString3;
            parameters[111].Value = model.OtherString4;
            parameters[112].Value = model.OtherString5;
            parameters[113].Value = model.OtherString6;
            parameters[114].Value = model.OtherString7;
            parameters[115].Value = model.OtherString8;
            parameters[116].Value = model.OtherString9;
            parameters[117].Value = model.OtherString10;
            parameters[118].Value = model.OtherText1;
            parameters[119].Value = model.OtherText2;
            parameters[120].Value = model.OtherText3;
            parameters[121].Value = model.OtherText4;
            parameters[122].Value = model.OtherText5;
            parameters[123].Value = model.WebSiteID;
            parameters[124].Value = model.ID;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(WebSite.Model.Mod_News model, bool IsSub)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SW_News set ");
            strSql.Append("Model=@Model,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserLevelID=@UserLevelID,");
            strSql.Append("UserLevelName=@UserLevelName,");
            strSql.Append("UserNickName=@UserNickName,");
            strSql.Append("UserImage=@UserImage,");
            strSql.Append("UserlevelClass=@UserlevelClass,");
            strSql.Append("Title=@Title,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("STypeID=@STypeID,");
            strSql.Append("STypeIDs=@STypeIDs,");
            strSql.Append("STypeName=@STypeName,");
            strSql.Append("CustomTypeID=@CustomTypeID,");
            strSql.Append("CustomTypeName=@CustomTypeName,");
            strSql.Append("Author=@Author,");
            strSql.Append("Content1=@Content1,");
            strSql.Append("Content2=@Content2,");
            strSql.Append("Introduction=@Introduction,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("ModifyDate=@ModifyDate,");
            strSql.Append("OrderBy=@OrderBy,");
            strSql.Append("State=@State,");
            strSql.Append("Tags=@Tags,");
            strSql.Append("Tags1=@Tags1,");
            strSql.Append("Tags2=@Tags2,");
            strSql.Append("Tags3=@Tags3,");
            strSql.Append("Tags4=@Tags4,");
            strSql.Append("ImageUrl=@ImageUrl,");
            strSql.Append("PicBig=@PicBig,");
            strSql.Append("FileUrl=@FileUrl,");
            strSql.Append("IsReview=@IsReview,");
            strSql.Append("ReviewID=@ReviewID,");
            strSql.Append("ReviewName=@ReviewName,");
            strSql.Append("AdminID=@AdminID,");
            strSql.Append("AdminName=@AdminName,");
            strSql.Append("IsCommend=@IsCommend,");
            strSql.Append("IsCommendHot=@IsCommendHot,");
            strSql.Append("Integral=@Integral,");
            strSql.Append("Money=@Money,");
            strSql.Append("IsMoney=@IsMoney,");
            strSql.Append("RedEnvelopes=@RedEnvelopes,");
            strSql.Append("IsRedEnvelopes=@IsRedEnvelopes,");
            strSql.Append("IsTop=@IsTop,");
            strSql.Append("IsHot=@IsHot,");
            strSql.Append("IsNew=@IsNew,");
            strSql.Append("IsApplyOriginal=@IsApplyOriginal,");
            strSql.Append("IsOriginal=@IsOriginal,");
            strSql.Append("IsLaunch=@IsLaunch,");
            strSql.Append("BrowseCount=@BrowseCount,");
            strSql.Append("CommentCount=@CommentCount,");
            strSql.Append("FabulousCount=@FabulousCount,");
            strSql.Append("ReportCount=@ReportCount,");
            strSql.Append("Allmoney=@Allmoney,");
            strSql.Append("AllIntegral=@AllIntegral,");
            strSql.Append("ActionCount=@ActionCount,");
            strSql.Append("CommendTitle=@CommendTitle,");
            strSql.Append("CommendUrl=@CommendUrl,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Region=@Region,");
            strSql.Append("WithdrawMoney=@WithdrawMoney,");
            strSql.Append("RegionID=@RegionID,");
            strSql.Append("ProveCount=@ProveCount,");
            strSql.Append("IsWithdraw=@IsWithdraw,");
            strSql.Append("IsGifts=@IsGifts,");
            strSql.Append("IsGiftsReview=@IsGiftsReview,");
            strSql.Append("GiftsTypeID=@GiftsTypeID,");
            strSql.Append("GiftsTypeName=@GiftsTypeName,");
            strSql.Append("GiftsProductID=@GiftsProductID,");
            strSql.Append("GiftsUrl=@GiftsUrl,");
            strSql.Append("IsHelp=@IsHelp,");
            strSql.Append("HelpTypeID=@HelpTypeID,");
            strSql.Append("HelpTypeName=@HelpTypeName,");
            strSql.Append("HelpRealName=@HelpRealName,");
            strSql.Append("TargetAmount=@TargetAmount,");
            strSql.Append("Commitmentstatement=@Commitmentstatement,");
            strSql.Append("MaterialScience=@MaterialScience,");
            strSql.Append("AuditInstructions=@AuditInstructions,");
            strSql.Append("Helpcontentstr1=@Helpcontentstr1,");
            strSql.Append("Helpcontentstr2=@Helpcontentstr2,");
            strSql.Append("Helpcontentstr3=@Helpcontentstr3,");
            strSql.Append("Helpcontentstr4=@Helpcontentstr4,");
            strSql.Append("Helpcontentstr5=@Helpcontentstr5,");
            strSql.Append("Helpcontentstr6=@Helpcontentstr6,");
            strSql.Append("Helpcontentstr7=@Helpcontentstr7,");
            strSql.Append("Helpcontentstr8=@Helpcontentstr8,");
            strSql.Append("SeoTitle=@SeoTitle,");
            strSql.Append("SeoKeywords=@SeoKeywords,");
            strSql.Append("SeoDescription=@SeoDescription,");
            strSql.Append("IsFabulous=@IsFabulous,");
            strSql.Append("OtherInt1=@OtherInt1,");
            strSql.Append("OtherInt2=@OtherInt2,");
            strSql.Append("OtherInt3=@OtherInt3,");
            strSql.Append("OtherInt4=@OtherInt4,");
            strSql.Append("OtherInt5=@OtherInt5,");
            strSql.Append("OtherInt6=@OtherInt6,");
            strSql.Append("OtherInt7=@OtherInt7,");
            strSql.Append("OtherInt8=@OtherInt8,");
            strSql.Append("OtherInt9=@OtherInt9,");
            strSql.Append("OtherInt10=@OtherInt10,");
            strSql.Append("OtherInt11=@OtherInt11,");
            strSql.Append("OtherInt12=@OtherInt12,");
            strSql.Append("OtherInt13=@OtherInt13,");
            strSql.Append("OtherInt14=@OtherInt14,");
            strSql.Append("OtherInt15=@OtherInt15,");
            strSql.Append("OtherString1=@OtherString1,");
            strSql.Append("OtherString2=@OtherString2,");
            strSql.Append("OtherString3=@OtherString3,");
            strSql.Append("OtherString4=@OtherString4,");
            strSql.Append("OtherString5=@OtherString5,");
            strSql.Append("OtherString6=@OtherString6,");
            strSql.Append("OtherString7=@OtherString7,");
            strSql.Append("OtherString8=@OtherString8,");
            strSql.Append("OtherString9=@OtherString9,");
            strSql.Append("OtherString10=@OtherString10,");
            strSql.Append("OtherText1=@OtherText1,");
            strSql.Append("OtherText2=@OtherText2,");
            strSql.Append("OtherText3=@OtherText3,");
            strSql.Append("OtherText4=@OtherText4,");
            strSql.Append("OtherText5=@OtherText5,");
            strSql.Append("WebSiteID=@WebSiteID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Model", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@UserLevelID", SqlDbType.Int,4),
					new SqlParameter("@UserLevelName", SqlDbType.VarChar,200),
					new SqlParameter("@UserNickName", SqlDbType.VarChar,200),
					new SqlParameter("@UserImage", SqlDbType.VarChar,500),
					new SqlParameter("@UserlevelClass", SqlDbType.VarChar,50),
					new SqlParameter("@Title", SqlDbType.NVarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,200),
					new SqlParameter("@STypeID", SqlDbType.Int,4),
					new SqlParameter("@STypeIDs", SqlDbType.VarChar,200),
					new SqlParameter("@STypeName", SqlDbType.VarChar,200),
					new SqlParameter("@CustomTypeID", SqlDbType.Int,4),
					new SqlParameter("@CustomTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@Author", SqlDbType.VarChar,200),
					new SqlParameter("@Content1", SqlDbType.NText),
					new SqlParameter("@Content2", SqlDbType.NText),
					new SqlParameter("@Introduction", SqlDbType.VarChar,2000),
					new SqlParameter("@Remarks", SqlDbType.VarChar,500),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.Text),
					new SqlParameter("@Tags1", SqlDbType.VarChar,200),
					new SqlParameter("@Tags2", SqlDbType.VarChar,200),
					new SqlParameter("@Tags3", SqlDbType.VarChar,200),
					new SqlParameter("@Tags4", SqlDbType.VarChar,200),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,500),
					new SqlParameter("@PicBig", SqlDbType.VarChar,500),
					new SqlParameter("@FileUrl", SqlDbType.VarChar,500),
					new SqlParameter("@IsReview", SqlDbType.Int,4),
					new SqlParameter("@ReviewID", SqlDbType.Int,4),
					new SqlParameter("@ReviewName", SqlDbType.VarChar,200),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@AdminName", SqlDbType.VarChar,200),
					new SqlParameter("@IsCommend", SqlDbType.Int,4),
					new SqlParameter("@IsCommendHot", SqlDbType.Int,4),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsMoney", SqlDbType.Int,4),
					new SqlParameter("@RedEnvelopes", SqlDbType.Decimal,9),
					new SqlParameter("@IsRedEnvelopes", SqlDbType.Int,4),
					new SqlParameter("@IsTop", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsNew", SqlDbType.Int,4),
					new SqlParameter("@IsApplyOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsOriginal", SqlDbType.Int,4),
					new SqlParameter("@IsLaunch", SqlDbType.Int,4),
					new SqlParameter("@BrowseCount", SqlDbType.Int,4),
					new SqlParameter("@CommentCount", SqlDbType.Int,4),
					new SqlParameter("@FabulousCount", SqlDbType.Int,4),
					new SqlParameter("@ReportCount", SqlDbType.Int,4),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@AllIntegral", SqlDbType.Int,4),
					new SqlParameter("@ActionCount", SqlDbType.Int,4),
					new SqlParameter("@CommendTitle", SqlDbType.VarChar,200),
					new SqlParameter("@CommendUrl", SqlDbType.VarChar,500),
					new SqlParameter("@Province", SqlDbType.VarChar,50),
					new SqlParameter("@City", SqlDbType.VarChar,50),
					new SqlParameter("@Region", SqlDbType.VarChar,50),
					new SqlParameter("@WithdrawMoney", SqlDbType.Decimal,9),
					new SqlParameter("@RegionID", SqlDbType.Int,4),
					new SqlParameter("@ProveCount", SqlDbType.Int,4),
					new SqlParameter("@IsWithdraw", SqlDbType.Int,4),
					new SqlParameter("@IsGifts", SqlDbType.Int,4),
					new SqlParameter("@IsGiftsReview", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeID", SqlDbType.Int,4),
					new SqlParameter("@GiftsTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@GiftsProductID", SqlDbType.Int,4),
					new SqlParameter("@GiftsUrl", SqlDbType.VarChar,200),
					new SqlParameter("@IsHelp", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeID", SqlDbType.Int,4),
					new SqlParameter("@HelpTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@HelpRealName", SqlDbType.VarChar,200),
					new SqlParameter("@TargetAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Commitmentstatement", SqlDbType.Text),
					new SqlParameter("@MaterialScience", SqlDbType.Text),
					new SqlParameter("@AuditInstructions", SqlDbType.Text),
					new SqlParameter("@Helpcontentstr1", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr2", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr3", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr4", SqlDbType.NVarChar,200),
					new SqlParameter("@Helpcontentstr5", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr6", SqlDbType.NVarChar,500),
					new SqlParameter("@Helpcontentstr7", SqlDbType.NText),
					new SqlParameter("@Helpcontentstr8", SqlDbType.NText),
					new SqlParameter("@SeoTitle", SqlDbType.VarChar,200),
					new SqlParameter("@SeoKeywords", SqlDbType.Text),
					new SqlParameter("@SeoDescription", SqlDbType.Text),
					new SqlParameter("@IsFabulous", SqlDbType.Int,4),
					new SqlParameter("@OtherInt1", SqlDbType.Int,4),
					new SqlParameter("@OtherInt2", SqlDbType.Int,4),
					new SqlParameter("@OtherInt3", SqlDbType.Int,4),
					new SqlParameter("@OtherInt4", SqlDbType.Int,4),
					new SqlParameter("@OtherInt5", SqlDbType.Int,4),
					new SqlParameter("@OtherInt6", SqlDbType.Int,4),
					new SqlParameter("@OtherInt7", SqlDbType.Int,4),
					new SqlParameter("@OtherInt8", SqlDbType.Int,4),
					new SqlParameter("@OtherInt9", SqlDbType.Int,4),
					new SqlParameter("@OtherInt10", SqlDbType.Int,4),
					new SqlParameter("@OtherInt11", SqlDbType.Int,4),
					new SqlParameter("@OtherInt12", SqlDbType.Int,4),
					new SqlParameter("@OtherInt13", SqlDbType.Int,4),
					new SqlParameter("@OtherInt14", SqlDbType.Int,4),
					new SqlParameter("@OtherInt15", SqlDbType.Int,4),
					new SqlParameter("@OtherString1", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString2", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString3", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString4", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString5", SqlDbType.VarChar,200),
					new SqlParameter("@OtherString6", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString7", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString8", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString9", SqlDbType.VarChar,500),
					new SqlParameter("@OtherString10", SqlDbType.VarChar,500),
					new SqlParameter("@OtherText1", SqlDbType.Text),
					new SqlParameter("@OtherText2", SqlDbType.Text),
					new SqlParameter("@OtherText3", SqlDbType.Text),
					new SqlParameter("@OtherText4", SqlDbType.NText),
					new SqlParameter("@OtherText5", SqlDbType.NText),
					new SqlParameter("@WebSiteID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Model;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserLevelID;
            parameters[4].Value = model.UserLevelName;
            parameters[5].Value = model.UserNickName;
            parameters[6].Value = model.UserImage;
            parameters[7].Value = model.UserlevelClass;
            parameters[8].Value = model.Title;
            parameters[9].Value = model.TypeID;
            parameters[10].Value = model.TypeName;
            parameters[11].Value = model.STypeID;
            parameters[12].Value = model.STypeIDs;
            parameters[13].Value = model.STypeName;
            parameters[14].Value = model.CustomTypeID;
            parameters[15].Value = model.CustomTypeName;
            parameters[16].Value = model.Author;
            parameters[17].Value = model.Content1;
            parameters[18].Value = model.Content2;
            parameters[19].Value = model.Introduction;
            parameters[20].Value = model.Remarks;
            parameters[21].Value = model.AddDate;
            parameters[22].Value = model.ModifyDate;
            parameters[23].Value = model.OrderBy;
            parameters[24].Value = model.State;
            parameters[25].Value = model.Tags;
            parameters[26].Value = model.Tags1;
            parameters[27].Value = model.Tags2;
            parameters[28].Value = model.Tags3;
            parameters[29].Value = model.Tags4;
            parameters[30].Value = model.ImageUrl;
            parameters[31].Value = model.PicBig;
            parameters[32].Value = model.FileUrl;
            parameters[33].Value = model.IsReview;
            parameters[34].Value = model.ReviewID;
            parameters[35].Value = model.ReviewName;
            parameters[36].Value = model.AdminID;
            parameters[37].Value = model.AdminName;
            parameters[38].Value = model.IsCommend;
            parameters[39].Value = model.IsCommendHot;
            parameters[40].Value = model.Integral;
            parameters[41].Value = model.Money;
            parameters[42].Value = model.IsMoney;
            parameters[43].Value = model.RedEnvelopes;
            parameters[44].Value = model.IsRedEnvelopes;
            parameters[45].Value = model.IsTop;
            parameters[46].Value = model.IsHot;
            parameters[47].Value = model.IsNew;
            parameters[48].Value = model.IsApplyOriginal;
            parameters[49].Value = model.IsOriginal;
            parameters[50].Value = model.IsLaunch;
            parameters[51].Value = model.BrowseCount;
            parameters[52].Value = model.CommentCount;
            parameters[53].Value = model.FabulousCount;
            parameters[54].Value = model.ReportCount;
            parameters[55].Value = model.Allmoney;
            parameters[56].Value = model.AllIntegral;
            parameters[57].Value = model.ActionCount;
            parameters[58].Value = model.CommendTitle;
            parameters[59].Value = model.CommendUrl;
            parameters[60].Value = model.Province;
            parameters[61].Value = model.City;
            parameters[62].Value = model.Region;
            parameters[63].Value = model.WithdrawMoney;
            parameters[64].Value = model.RegionID;
            parameters[65].Value = model.ProveCount;
            parameters[66].Value = model.IsWithdraw;
            parameters[67].Value = model.IsGifts;
            parameters[68].Value = model.IsGiftsReview;
            parameters[69].Value = model.GiftsTypeID;
            parameters[70].Value = model.GiftsTypeName;
            parameters[71].Value = model.GiftsProductID;
            parameters[72].Value = model.GiftsUrl;
            parameters[73].Value = model.IsHelp;
            parameters[74].Value = model.HelpTypeID;
            parameters[75].Value = model.HelpTypeName;
            parameters[76].Value = model.HelpRealName;
            parameters[77].Value = model.TargetAmount;
            parameters[78].Value = model.Commitmentstatement;
            parameters[79].Value = model.MaterialScience;
            parameters[80].Value = model.AuditInstructions;
            parameters[81].Value = model.Helpcontentstr1;
            parameters[82].Value = model.Helpcontentstr2;
            parameters[83].Value = model.Helpcontentstr3;
            parameters[84].Value = model.Helpcontentstr4;
            parameters[85].Value = model.Helpcontentstr5;
            parameters[86].Value = model.Helpcontentstr6;
            parameters[87].Value = model.Helpcontentstr7;
            parameters[88].Value = model.Helpcontentstr8;
            parameters[89].Value = model.SeoTitle;
            parameters[90].Value = model.SeoKeywords;
            parameters[91].Value = model.SeoDescription;
            parameters[92].Value = model.IsFabulous;
            parameters[93].Value = model.OtherInt1;
            parameters[94].Value = model.OtherInt2;
            parameters[95].Value = model.OtherInt3;
            parameters[96].Value = model.OtherInt4;
            parameters[97].Value = model.OtherInt5;
            parameters[98].Value = model.OtherInt6;
            parameters[99].Value = model.OtherInt7;
            parameters[100].Value = model.OtherInt8;
            parameters[101].Value = model.OtherInt9;
            parameters[102].Value = model.OtherInt10;
            parameters[103].Value = model.OtherInt11;
            parameters[104].Value = model.OtherInt12;
            parameters[105].Value = model.OtherInt13;
            parameters[106].Value = model.OtherInt14;
            parameters[107].Value = model.OtherInt15;
            parameters[108].Value = model.OtherString1;
            parameters[109].Value = model.OtherString2;
            parameters[110].Value = model.OtherString3;
            parameters[111].Value = model.OtherString4;
            parameters[112].Value = model.OtherString5;
            parameters[113].Value = model.OtherString6;
            parameters[114].Value = model.OtherString7;
            parameters[115].Value = model.OtherString8;
            parameters[116].Value = model.OtherString9;
            parameters[117].Value = model.OtherString10;
            parameters[118].Value = model.OtherText1;
            parameters[119].Value = model.OtherText2;
            parameters[120].Value = model.OtherText3;
            parameters[121].Value = model.OtherText4;
            parameters[122].Value = model.OtherText5;
            parameters[123].Value = model.WebSiteID;
            parameters[124].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                if (IsSub)
                {
                    //操作图片集
                    Dal_PicList DPicList = new Dal_PicList();
                    DPicList.OperateList(model.PicList, model.ID, true);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SW_News ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                //操作图片集
                Dal_PicList DPicList = new Dal_PicList();
                DPicList.DeleteFile(ID.ToString(), true);
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
            strSql.Append("delete from SW_News ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                //操作图片集
                Dal_PicList DPicList = new Dal_PicList();
                DPicList.DeleteFile(IDlist, true);
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
        public WebSite.Model.Mod_News GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Model,UserID,UserName,UserLevelID,UserLevelName,UserNickName,UserImage,UserlevelClass,Title,TypeID,TypeName,STypeID,STypeIDs,STypeName,CustomTypeID,CustomTypeName,Author,Content1,Content2,Introduction,Remarks,AddDate,ModifyDate,OrderBy,State,Tags,Tags1,Tags2,Tags3,Tags4,ImageUrl,PicBig,FileUrl,IsReview,ReviewID,ReviewName,AdminID,AdminName,IsCommend,IsCommendHot,Integral,Money,IsMoney,RedEnvelopes,IsRedEnvelopes,IsTop,IsHot,IsNew,IsApplyOriginal,IsOriginal,IsLaunch,BrowseCount,CommentCount,FabulousCount,ReportCount,Allmoney,AllIntegral,ActionCount,CommendTitle,CommendUrl,Province,City,Region,WithdrawMoney,RegionID,ProveCount,IsWithdraw,IsGifts,IsGiftsReview,GiftsTypeID,GiftsTypeName,GiftsProductID,GiftsUrl,IsHelp,HelpTypeID,HelpTypeName,HelpRealName,TargetAmount,Commitmentstatement,MaterialScience,AuditInstructions,Helpcontentstr1,Helpcontentstr2,Helpcontentstr3,Helpcontentstr4,Helpcontentstr5,Helpcontentstr6,Helpcontentstr7,Helpcontentstr8,SeoTitle,SeoKeywords,SeoDescription,IsFabulous,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSiteID from SW_News ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            WebSite.Model.Mod_News model = new WebSite.Model.Mod_News();
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
        public WebSite.Model.Mod_News DataRowToModel(DataRow row)
        {
            WebSite.Model.Mod_News model = new WebSite.Model.Mod_News();
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
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["UserLevelID"] != null && row["UserLevelID"].ToString() != "")
                {
                    model.UserLevelID = int.Parse(row["UserLevelID"].ToString());
                }
                if (row["UserLevelName"] != null)
                {
                    model.UserLevelName = row["UserLevelName"].ToString();
                }
                if (row["UserNickName"] != null)
                {
                    model.UserNickName = row["UserNickName"].ToString();
                }
                if (row["UserImage"] != null)
                {
                    model.UserImage = row["UserImage"].ToString();
                }
                if (row["UserlevelClass"] != null)
                {
                    model.UserlevelClass = row["UserlevelClass"].ToString();
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["TypeID"] != null && row["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(row["TypeID"].ToString());
                }
                if (row["TypeName"] != null)
                {
                    model.TypeName = row["TypeName"].ToString();
                }
                if (row["STypeID"] != null && row["STypeID"].ToString() != "")
                {
                    model.STypeID = int.Parse(row["STypeID"].ToString());
                }
                if (row["STypeIDs"] != null)
                {
                    model.STypeIDs = row["STypeIDs"].ToString();
                }
                if (row["STypeName"] != null)
                {
                    model.STypeName = row["STypeName"].ToString();
                }
                if (row["CustomTypeID"] != null && row["CustomTypeID"].ToString() != "")
                {
                    model.CustomTypeID = int.Parse(row["CustomTypeID"].ToString());
                }
                if (row["CustomTypeName"] != null)
                {
                    model.CustomTypeName = row["CustomTypeName"].ToString();
                }
                if (row["Author"] != null)
                {
                    model.Author = row["Author"].ToString();
                }
                if (row["Content1"] != null)
                {
                    model.Content1 = row["Content1"].ToString();
                }
                if (row["Content2"] != null)
                {
                    model.Content2 = row["Content2"].ToString();
                }
                if (row["Introduction"] != null)
                {
                    model.Introduction = row["Introduction"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
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
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["Tags"] != null)
                {
                    model.Tags = row["Tags"].ToString();
                }
                if (row["Tags1"] != null)
                {
                    model.Tags1 = row["Tags1"].ToString();
                }
                if (row["Tags2"] != null)
                {
                    model.Tags2 = row["Tags2"].ToString();
                }
                if (row["Tags3"] != null)
                {
                    model.Tags3 = row["Tags3"].ToString();
                }
                if (row["Tags4"] != null)
                {
                    model.Tags4 = row["Tags4"].ToString();
                }
                if (row["ImageUrl"] != null)
                {
                    model.ImageUrl = row["ImageUrl"].ToString();
                }
                if (row["PicBig"] != null)
                {
                    model.PicBig = row["PicBig"].ToString();
                }
                if (row["FileUrl"] != null)
                {
                    model.FileUrl = row["FileUrl"].ToString();
                }
                if (row["IsReview"] != null && row["IsReview"].ToString() != "")
                {
                    model.IsReview = int.Parse(row["IsReview"].ToString());
                }
                if (row["ReviewID"] != null && row["ReviewID"].ToString() != "")
                {
                    model.ReviewID = int.Parse(row["ReviewID"].ToString());
                }
                if (row["ReviewName"] != null)
                {
                    model.ReviewName = row["ReviewName"].ToString();
                }
                if (row["AdminID"] != null && row["AdminID"].ToString() != "")
                {
                    model.AdminID = int.Parse(row["AdminID"].ToString());
                }
                if (row["AdminName"] != null)
                {
                    model.AdminName = row["AdminName"].ToString();
                }
                if (row["IsCommend"] != null && row["IsCommend"].ToString() != "")
                {
                    model.IsCommend = int.Parse(row["IsCommend"].ToString());
                }
                if (row["IsCommendHot"] != null && row["IsCommendHot"].ToString() != "")
                {
                    model.IsCommendHot = int.Parse(row["IsCommendHot"].ToString());
                }
                if (row["Integral"] != null && row["Integral"].ToString() != "")
                {
                    model.Integral = int.Parse(row["Integral"].ToString());
                }
                if (row["Money"] != null && row["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(row["Money"].ToString());
                }
                if (row["IsMoney"] != null && row["IsMoney"].ToString() != "")
                {
                    model.IsMoney = int.Parse(row["IsMoney"].ToString());
                }
                if (row["RedEnvelopes"] != null && row["RedEnvelopes"].ToString() != "")
                {
                    model.RedEnvelopes = decimal.Parse(row["RedEnvelopes"].ToString());
                }
                if (row["IsRedEnvelopes"] != null && row["IsRedEnvelopes"].ToString() != "")
                {
                    model.IsRedEnvelopes = int.Parse(row["IsRedEnvelopes"].ToString());
                }
                if (row["IsTop"] != null && row["IsTop"].ToString() != "")
                {
                    model.IsTop = int.Parse(row["IsTop"].ToString());
                }
                if (row["IsHot"] != null && row["IsHot"].ToString() != "")
                {
                    model.IsHot = int.Parse(row["IsHot"].ToString());
                }
                if (row["IsNew"] != null && row["IsNew"].ToString() != "")
                {
                    model.IsNew = int.Parse(row["IsNew"].ToString());
                }
                if (row["IsApplyOriginal"] != null && row["IsApplyOriginal"].ToString() != "")
                {
                    model.IsApplyOriginal = int.Parse(row["IsApplyOriginal"].ToString());
                }
                if (row["IsOriginal"] != null && row["IsOriginal"].ToString() != "")
                {
                    model.IsOriginal = int.Parse(row["IsOriginal"].ToString());
                }
                if (row["IsLaunch"] != null && row["IsLaunch"].ToString() != "")
                {
                    model.IsLaunch = int.Parse(row["IsLaunch"].ToString());
                }
                if (row["BrowseCount"] != null && row["BrowseCount"].ToString() != "")
                {
                    model.BrowseCount = int.Parse(row["BrowseCount"].ToString());
                }
                if (row["CommentCount"] != null && row["CommentCount"].ToString() != "")
                {
                    model.CommentCount = int.Parse(row["CommentCount"].ToString());
                }
                if (row["FabulousCount"] != null && row["FabulousCount"].ToString() != "")
                {
                    model.FabulousCount = int.Parse(row["FabulousCount"].ToString());
                }
                if (row["ReportCount"] != null && row["ReportCount"].ToString() != "")
                {
                    model.ReportCount = int.Parse(row["ReportCount"].ToString());
                }
                if (row["Allmoney"] != null && row["Allmoney"].ToString() != "")
                {
                    model.Allmoney = decimal.Parse(row["Allmoney"].ToString());
                }
                if (row["AllIntegral"] != null && row["AllIntegral"].ToString() != "")
                {
                    model.AllIntegral = int.Parse(row["AllIntegral"].ToString());
                }
                if (row["ActionCount"] != null && row["ActionCount"].ToString() != "")
                {
                    model.ActionCount = int.Parse(row["ActionCount"].ToString());
                }
                if (row["CommendTitle"] != null)
                {
                    model.CommendTitle = row["CommendTitle"].ToString();
                }
                if (row["CommendUrl"] != null)
                {
                    model.CommendUrl = row["CommendUrl"].ToString();
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
                if (row["WithdrawMoney"] != null && row["WithdrawMoney"].ToString() != "")
                {
                    model.WithdrawMoney = decimal.Parse(row["WithdrawMoney"].ToString());
                }
                if (row["RegionID"] != null && row["RegionID"].ToString() != "")
                {
                    model.RegionID = int.Parse(row["RegionID"].ToString());
                }
                if (row["ProveCount"] != null && row["ProveCount"].ToString() != "")
                {
                    model.ProveCount = int.Parse(row["ProveCount"].ToString());
                }
                if (row["IsWithdraw"] != null && row["IsWithdraw"].ToString() != "")
                {
                    model.IsWithdraw = int.Parse(row["IsWithdraw"].ToString());
                }
                if (row["IsGifts"] != null && row["IsGifts"].ToString() != "")
                {
                    model.IsGifts = int.Parse(row["IsGifts"].ToString());
                }
                if (row["IsGiftsReview"] != null && row["IsGiftsReview"].ToString() != "")
                {
                    model.IsGiftsReview = int.Parse(row["IsGiftsReview"].ToString());
                }
                if (row["GiftsTypeID"] != null && row["GiftsTypeID"].ToString() != "")
                {
                    model.GiftsTypeID = int.Parse(row["GiftsTypeID"].ToString());
                }
                if (row["GiftsTypeName"] != null)
                {
                    model.GiftsTypeName = row["GiftsTypeName"].ToString();
                }
                if (row["GiftsProductID"] != null && row["GiftsProductID"].ToString() != "")
                {
                    model.GiftsProductID = int.Parse(row["GiftsProductID"].ToString());
                }
                if (row["GiftsUrl"] != null)
                {
                    model.GiftsUrl = row["GiftsUrl"].ToString();
                }
                if (row["IsHelp"] != null && row["IsHelp"].ToString() != "")
                {
                    model.IsHelp = int.Parse(row["IsHelp"].ToString());
                }
                if (row["HelpTypeID"] != null && row["HelpTypeID"].ToString() != "")
                {
                    model.HelpTypeID = int.Parse(row["HelpTypeID"].ToString());
                }
                if (row["HelpTypeName"] != null)
                {
                    model.HelpTypeName = row["HelpTypeName"].ToString();
                }
                if (row["HelpRealName"] != null)
                {
                    model.HelpRealName = row["HelpRealName"].ToString();
                }
                if (row["TargetAmount"] != null && row["TargetAmount"].ToString() != "")
                {
                    model.TargetAmount = decimal.Parse(row["TargetAmount"].ToString());
                }
                if (row["Commitmentstatement"] != null)
                {
                    model.Commitmentstatement = row["Commitmentstatement"].ToString();
                }
                if (row["MaterialScience"] != null)
                {
                    model.MaterialScience = row["MaterialScience"].ToString();
                }
                if (row["AuditInstructions"] != null)
                {
                    model.AuditInstructions = row["AuditInstructions"].ToString();
                }
                if (row["Helpcontentstr1"] != null)
                {
                    model.Helpcontentstr1 = row["Helpcontentstr1"].ToString();
                }
                if (row["Helpcontentstr2"] != null)
                {
                    model.Helpcontentstr2 = row["Helpcontentstr2"].ToString();
                }
                if (row["Helpcontentstr3"] != null)
                {
                    model.Helpcontentstr3 = row["Helpcontentstr3"].ToString();
                }
                if (row["Helpcontentstr4"] != null)
                {
                    model.Helpcontentstr4 = row["Helpcontentstr4"].ToString();
                }
                if (row["Helpcontentstr5"] != null)
                {
                    model.Helpcontentstr5 = row["Helpcontentstr5"].ToString();
                }
                if (row["Helpcontentstr6"] != null)
                {
                    model.Helpcontentstr6 = row["Helpcontentstr6"].ToString();
                }
                if (row["Helpcontentstr7"] != null)
                {
                    model.Helpcontentstr7 = row["Helpcontentstr7"].ToString();
                }
                if (row["Helpcontentstr8"] != null)
                {
                    model.Helpcontentstr8 = row["Helpcontentstr8"].ToString();
                }
                if (row["SeoTitle"] != null)
                {
                    model.SeoTitle = row["SeoTitle"].ToString();
                }
                if (row["SeoKeywords"] != null)
                {
                    model.SeoKeywords = row["SeoKeywords"].ToString();
                }
                if (row["SeoDescription"] != null)
                {
                    model.SeoDescription = row["SeoDescription"].ToString();
                }
                if (row["IsFabulous"] != null && row["IsFabulous"].ToString() != "")
                {
                    model.IsFabulous = int.Parse(row["IsFabulous"].ToString());
                }
                if (row["OtherInt1"] != null && row["OtherInt1"].ToString() != "")
                {
                    model.OtherInt1 = int.Parse(row["OtherInt1"].ToString());
                }
                if (row["OtherInt2"] != null && row["OtherInt2"].ToString() != "")
                {
                    model.OtherInt2 = int.Parse(row["OtherInt2"].ToString());
                }
                if (row["OtherInt3"] != null && row["OtherInt3"].ToString() != "")
                {
                    model.OtherInt3 = int.Parse(row["OtherInt3"].ToString());
                }
                if (row["OtherInt4"] != null && row["OtherInt4"].ToString() != "")
                {
                    model.OtherInt4 = int.Parse(row["OtherInt4"].ToString());
                }
                if (row["OtherInt5"] != null && row["OtherInt5"].ToString() != "")
                {
                    model.OtherInt5 = int.Parse(row["OtherInt5"].ToString());
                }
                if (row["OtherInt6"] != null && row["OtherInt6"].ToString() != "")
                {
                    model.OtherInt6 = int.Parse(row["OtherInt6"].ToString());
                }
                if (row["OtherInt7"] != null && row["OtherInt7"].ToString() != "")
                {
                    model.OtherInt7 = int.Parse(row["OtherInt7"].ToString());
                }
                if (row["OtherInt8"] != null && row["OtherInt8"].ToString() != "")
                {
                    model.OtherInt8 = int.Parse(row["OtherInt8"].ToString());
                }
                if (row["OtherInt9"] != null && row["OtherInt9"].ToString() != "")
                {
                    model.OtherInt9 = int.Parse(row["OtherInt9"].ToString());
                }
                if (row["OtherInt10"] != null && row["OtherInt10"].ToString() != "")
                {
                    model.OtherInt10 = int.Parse(row["OtherInt10"].ToString());
                }
                if (row["OtherInt11"] != null && row["OtherInt11"].ToString() != "")
                {
                    model.OtherInt11 = int.Parse(row["OtherInt11"].ToString());
                }
                if (row["OtherInt12"] != null && row["OtherInt12"].ToString() != "")
                {
                    model.OtherInt12 = int.Parse(row["OtherInt12"].ToString());
                }
                if (row["OtherInt13"] != null && row["OtherInt13"].ToString() != "")
                {
                    model.OtherInt13 = int.Parse(row["OtherInt13"].ToString());
                }
                if (row["OtherInt14"] != null && row["OtherInt14"].ToString() != "")
                {
                    model.OtherInt14 = int.Parse(row["OtherInt14"].ToString());
                }
                if (row["OtherInt15"] != null && row["OtherInt15"].ToString() != "")
                {
                    model.OtherInt15 = int.Parse(row["OtherInt15"].ToString());
                }
                if (row["OtherString1"] != null)
                {
                    model.OtherString1 = row["OtherString1"].ToString();
                }
                if (row["OtherString2"] != null)
                {
                    model.OtherString2 = row["OtherString2"].ToString();
                }
                if (row["OtherString3"] != null)
                {
                    model.OtherString3 = row["OtherString3"].ToString();
                }
                if (row["OtherString4"] != null)
                {
                    model.OtherString4 = row["OtherString4"].ToString();
                }
                if (row["OtherString5"] != null)
                {
                    model.OtherString5 = row["OtherString5"].ToString();
                }
                if (row["OtherString6"] != null)
                {
                    model.OtherString6 = row["OtherString6"].ToString();
                }
                if (row["OtherString7"] != null)
                {
                    model.OtherString7 = row["OtherString7"].ToString();
                }
                if (row["OtherString8"] != null)
                {
                    model.OtherString8 = row["OtherString8"].ToString();
                }
                if (row["OtherString9"] != null)
                {
                    model.OtherString9 = row["OtherString9"].ToString();
                }
                if (row["OtherString10"] != null)
                {
                    model.OtherString10 = row["OtherString10"].ToString();
                }
                if (row["OtherText1"] != null)
                {
                    model.OtherText1 = row["OtherText1"].ToString();
                }
                if (row["OtherText2"] != null)
                {
                    model.OtherText2 = row["OtherText2"].ToString();
                }
                if (row["OtherText3"] != null)
                {
                    model.OtherText3 = row["OtherText3"].ToString();
                }
                if (row["OtherText4"] != null)
                {
                    model.OtherText4 = row["OtherText4"].ToString();
                }
                if (row["OtherText5"] != null)
                {
                    model.OtherText5 = row["OtherText5"].ToString();
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
            strSql.Append("select ID,Model,UserID,UserName,UserLevelID,UserLevelName,UserNickName,UserImage,UserlevelClass,Title,TypeID,TypeName,STypeID,STypeIDs,STypeName,CustomTypeID,CustomTypeName,Author,Content1,Content2,Introduction,Remarks,AddDate,ModifyDate,OrderBy,State,Tags,Tags1,Tags2,Tags3,Tags4,ImageUrl,PicBig,FileUrl,IsReview,ReviewID,ReviewName,AdminID,AdminName,IsCommend,IsCommendHot,Integral,Money,IsMoney,RedEnvelopes,IsRedEnvelopes,IsTop,IsHot,IsNew,IsApplyOriginal,IsOriginal,IsLaunch,BrowseCount,CommentCount,FabulousCount,ReportCount,Allmoney,AllIntegral,ActionCount,CommendTitle,CommendUrl,Province,City,Region,WithdrawMoney,RegionID,ProveCount,IsWithdraw,IsGifts,IsGiftsReview,GiftsTypeID,GiftsTypeName,GiftsProductID,GiftsUrl,IsHelp,HelpTypeID,HelpTypeName,HelpRealName,TargetAmount,Commitmentstatement,MaterialScience,AuditInstructions,Helpcontentstr1,Helpcontentstr2,Helpcontentstr3,Helpcontentstr4,Helpcontentstr5,Helpcontentstr6,Helpcontentstr7,Helpcontentstr8,SeoTitle,SeoKeywords,SeoDescription,IsFabulous,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSiteID ");
            strSql.Append(" FROM SW_News ");
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
            strSql.Append(" ID,Model,UserID,UserName,UserLevelID,UserLevelName,UserNickName,UserImage,UserlevelClass,Title,TypeID,TypeName,STypeID,STypeIDs,STypeName,CustomTypeID,CustomTypeName,Author,Content1,Content2,Introduction,Remarks,AddDate,ModifyDate,OrderBy,State,Tags,Tags1,Tags2,Tags3,Tags4,ImageUrl,PicBig,FileUrl,IsReview,ReviewID,ReviewName,AdminID,AdminName,IsCommend,IsCommendHot,Integral,Money,IsMoney,RedEnvelopes,IsRedEnvelopes,IsTop,IsHot,IsNew,IsApplyOriginal,IsOriginal,IsLaunch,BrowseCount,CommentCount,FabulousCount,ReportCount,Allmoney,AllIntegral,ActionCount,CommendTitle,CommendUrl,Province,City,Region,WithdrawMoney,RegionID,ProveCount,IsWithdraw,IsGifts,IsGiftsReview,GiftsTypeID,GiftsTypeName,GiftsProductID,GiftsUrl,IsHelp,HelpTypeID,HelpTypeName,HelpRealName,TargetAmount,Commitmentstatement,MaterialScience,AuditInstructions,Helpcontentstr1,Helpcontentstr2,Helpcontentstr3,Helpcontentstr4,Helpcontentstr5,Helpcontentstr6,Helpcontentstr7,Helpcontentstr8,SeoTitle,SeoKeywords,SeoDescription,IsFabulous,OtherInt1,OtherInt2,OtherInt3,OtherInt4,OtherInt5,OtherInt6,OtherInt7,OtherInt8,OtherInt9,OtherInt10,OtherInt11,OtherInt12,OtherInt13,OtherInt14,OtherInt15,OtherString1,OtherString2,OtherString3,OtherString4,OtherString5,OtherString6,OtherString7,OtherString8,OtherString9,OtherString10,OtherText1,OtherText2,OtherText3,OtherText4,OtherText5,WebSiteID ");
            strSql.Append(" FROM SW_News ");
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
            strSql.Append("select count(1) FROM SW_News ");
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
                strSql = "select top " + endIndex + " * from SW_News where  " + strWhere + "  order by " + orderby + " ";
            }
            else
            {
                strSql = "select top " + endIndex + " * from SW_News where  " + strWhere + " and  ID not in ( select top " + endIndex * (startIndex - 1) + " ID from SW_News where  " + strWhere + "  order by " + orderby + " ) order by " + orderby + " ";
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
			parameters[0].Value = "SW_News";
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

