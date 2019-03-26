using System;
using WebSite.Common;
namespace WebSite.Model
{
    public partial class Mod_Baidu_IP
    {
        public string address { get; set; }
        public _content content { get; set; }
        public string status { get; set; }
    }

    public partial class _content
    {
        public _address_detail address_detail { get; set; }
        public string address { get; set; }
        public _point point { get; set; }
    }
    public partial class _address_detail
    {
        public string province { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string street_number { get; set; }
        public string city_code { get; set; }
    }
    public partial class _point
    {
        public string y { get; set; }
        public string x { get; set; }
    }
}

