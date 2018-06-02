using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelHttpBase
{
    public class RoomTypeEx
    {
        /// <summary>
        /// 是否平台自营
        /// </summary>
        public bool PlatformPrivete { get; set; }
        public Platform Plat { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string BedType { get; set; }
        public string Breadfast { get; set; }
        public int Price { get; set; }
        public bool IsCancel { get; set; }
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        /// <summary>
        /// 政策id
        /// </summary>
        public string PolicyID { get; set; }
        /// <summary>
        /// 房型
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 房型ID
        /// </summary>
        public string BaseRoomID { get; set; }
        /// <summary>
        /// 房型扩展属性
        /// </summary>
        public object PlatformEx { get; set; }
    }
}
