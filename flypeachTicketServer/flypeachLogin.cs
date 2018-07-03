using CommonHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace flypeachTicketServer
{
    public class flypeachLogin : LoginServer
    {
        public override bool Login(string username, string pwd, out string err)
        {
            return base.Login(username, pwd, out err);
        }
        public override bool Login(string username, string pwd, string code, out string err)
        {
            return base.Login(username, pwd, code, out err);
        }
        public override MemoryStream CheckCode()
        {
            throw new NotImplementedException();
        }
    }
}
