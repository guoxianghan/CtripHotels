﻿using CommonHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flypeachTicketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueryTicket q = new flypeachTicketQuery();
            q.Init();
            q.QueryTicket("", "", true, DateTime.Now, DateTime.Now);
        }
    }
}
