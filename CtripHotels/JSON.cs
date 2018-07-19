using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtripHotelServer
{
    
    public class Rootobject
    {
        public CtripRoomlist[] roomlist { get; set; }
    }

    public class CtripRoomlist
    {
        public string room { get; set; }
        public string shadowid { get; set; }
        public string paytype { get; set; }
        public string minusamount { get; set; }
        public string promotion { get; set; }
        public string promotiontype { get; set; }
        public string iscomfirm { get; set; }
        public string roompricefq { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double roompricefh { get; set; }
        public string bedtype { get; set; }
        /// <summary>
        /// 早餐:0无;1单早;2双早;3三早;4四早
        /// </summary>
        public string breakfast { get; set; }
        public string policy { get; set; }
        public string guaranteetype { get; set; }
        public string bookable { get; set; }
        public string isgift { get; set; }
        public string isgroup { get; set; }
    }

}
