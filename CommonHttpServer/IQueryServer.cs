using System;
namespace CommonHttpServer
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="W">W,和网站对应的数据对象</typeparam> 
    /// <typeparam name="D">D,和数据库对应的数据对象</typeparam> 
   public interface IQueryServer<W,D>
     where D : class
    {
        string CreatePostString(int pageno);
        W FirstPage(out string err,out bool isgoing);
        W QueryResult(int pageno, out string err,out bool isgoing);
    }

   public interface IQueryServer 
   {
       string CreatePostString(int pageno);
       void FirstPage(out string err, out bool isgoing);
       void QueryResult(int pageno, out string err, out bool isgoing);
   }

}
