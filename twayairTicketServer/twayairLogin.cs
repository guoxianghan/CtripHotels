using CommonHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace twayairTicketServer
{
   public class twayairLogin : LoginServer
    {
        public override bool Login(string username, string pwd, out string err)
        {
            return base.Login(username, pwd, out err);
        }
        public override MemoryStream CheckCode()
        {
            throw new NotImplementedException();
        }
    }
}
