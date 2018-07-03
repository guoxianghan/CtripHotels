using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyticketBase
{
    public class TicketDetail
    {

        /// <summary>
        /// 航程
        /// </summary>
        public string[] Fly { get; set; }
        /// <summary>
        /// 是否单程
        /// </summary>
        public bool IsOneWay { get; set; } =  true;
        public string Price { get; set; }
        public string MoneyType { get; set; }
        /// <summary>
        /// 平台扩展属性
        /// </summary>
        public object PlatEx { get; set; }
        
    }
}
