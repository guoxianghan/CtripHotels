using HttpHotelServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelServerLogic
{
    public class CtripHotelLogic
    {
        public CtripHotelLogic()
        {
            server = new CtripHotelHttpServer();
        }
        CtripHotelHttpServer server = null;
       
        
    }
}
