using System;
using WebSite.Common;

namespace WebSite.Model
{
    /// <summary>
    /// Mod_LiveUser:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_LiveUser
    {
        public Mod_LiveUser()
        {
            Global.InitModel(this);
        }
        #region Model
        private int _id;
        private int _userid;
        private string _username;
        private string _nicename;
        private string _token;
        private string _roomid;
        private string _cid;
        private string _ctime;
        private string _pushurl;
        private string _httppullurl;
        private string _hlspullurl;
        private string _rtmppullurl;
        private int _type;
        private string _esstring1;
        private string _esstring2;
        private string _esstring3;
        private string _esstring4;
        private int _state;
        private DateTime _adddate;
        private DateTime _modifydate;
        private int _orderby;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int userID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string niceName
        {
            set { _nicename = value; }
            get { return _nicename; }
        }
        /// <summary>
        /// 网易云信账号注册成功后 会返回token，该token需要存到后台服务器，下次登录需要，需要在登录接口中提供给我
        /// </summary>
        public string token
        {
            set { _token = value; }
            get { return _token; }
        }
        /// <summary>
        /// 房间号id
        /// </summary>
        public string roomid
        {
            set { _roomid = value; }
            get { return _roomid; }
        }
        /// <summary>
        /// 直播频道id
        /// </summary>
        public string cid
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 创建时间 时间戳
        /// </summary>
        public string ctime
        {
            set { _ctime = value; }
            get { return _ctime; }
        }
        /// <summary>
        /// 推流地址
        /// </summary>
        public string pushUrl
        {
            set { _pushurl = value; }
            get { return _pushurl; }
        }
        /// <summary>
        /// http拉流地址
        /// </summary>
        public string httpPullUrl
        {
            set { _httppullurl = value; }
            get { return _httppullurl; }
        }
        /// <summary>
        /// hls拉流地址
        /// </summary>
        public string hlsPullUrl
        {
            set { _hlspullurl = value; }
            get { return _hlspullurl; }
        }
        /// <summary>
        /// rtmp拉流地址
        /// </summary>
        public string rtmpPullUrl
        {
            set { _rtmppullurl = value; }
            get { return _rtmppullurl; }
        }
        /// <summary>
        /// 频道类型
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string esString1
        {
            set { _esstring1 = value; }
            get { return _esstring1; }
        }
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string esString2
        {
            set { _esstring2 = value; }
            get { return _esstring2; }
        }
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string esString3
        {
            set { _esstring3 = value; }
            get { return _esstring3; }
        }
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string esString4
        {
            set { _esstring4 = value; }
            get { return _esstring4; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate
        {
            set { _modifydate = value; }
            get { return _modifydate; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        #endregion Model

    }
}
