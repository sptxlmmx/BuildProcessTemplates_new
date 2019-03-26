using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Model
{
    public class Mod_Jsapiticket
    {
        public Mod_Jsapiticket()
        {
            // 
            //TODO:用于验证Access_token是否过期实体
            // 
        }
        string _errcode;
        string _errmsg;
        string _ticket;
        string _expires_in;


        /// <summary> 
        /// 异常0  
        /// </summary> 
        public string errcode
        {
            get { return _errcode; }
            set { _errcode = value; }
        }

        /// <summary> 
        /// 返回ok
        /// </summary> 
        public string errmsg
        {
            get { return _errmsg; }
            set { _errmsg = value; }
        }
        /// <summary> 
        /// 获取到的凭证  
        /// </summary> 
        public string ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        /// <summary> 
        /// 凭证有效时间，单位：秒   
        /// </summary> 
        public string expires_in
        {
            get { return _expires_in; }
            set { _expires_in = value; }


        }
    }
}
