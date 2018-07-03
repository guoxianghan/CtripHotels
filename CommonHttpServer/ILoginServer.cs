using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpHelper;

namespace CommonHttpServer
{
   public interface ILoginServer
    {
       HttpResult LoginResult();
       /// <summary>
       /// 是否登陆成功,若登陆不成功,返回错误消息
       /// </summary>
       /// <param name="err"></param>
       /// <returns></returns>
       bool Login(out string err); 
       //bool CheckLogin(out string err);
    }
}
