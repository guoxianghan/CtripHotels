
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CommonHelper
{
    public class ZipHelper
    {
        #region 压缩文件或文件夹的方法 +  static void CreateZipFile(string filesPath, string zipFilePath)
        /// <summary>
        ///压缩文件或文件夹的方法
        /// </summary>
        /// <param name="filesPath">待压缩的文件或文件夹完整路径</param>
        /// <param name="zipFilePath">压缩之后的压缩文件完整路径</param>
        public static bool CreateZipFile(string filesPath, string zipFilePath)
        {
            if (!Directory.Exists(filesPath))
            {
                Console.WriteLine("Cannot find directory '{0}'", filesPath);
                return false;
            }

            try
            {
                string[] filenames = Directory.GetFiles(filesPath);
                using (ZipOutputStream s = new ZipOutputStream(File.Create(zipFilePath)))
                {
                    s.SetLevel(9); // 压缩级别 0-9
                    //s.Password = "123"; //Zip压缩文件密码
                    byte[] buffer = new byte[4096]; //缓冲区大小
                    foreach (string file in filenames)
                    {
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);
                        using (FileStream fs = File.OpenRead(file))
                        {
                            int sourceBytes;
                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                s.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }
                    s.Finish();
                    s.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during processing {0}", ex);
                return false;
            }
        }
        #endregion



        /// <summary>
        /// 解压方法
        /// </summary>
        /// <param name="zipFilePath">待解压的zip压缩文件完整路径</param>
        /// <param name="folderName">解压之后的完整文件路径</param>
        /// <returns></returns>
        public static bool UnZipFile(string zipFilePath,ref string folderName)
        {
            if (!File.Exists(zipFilePath))
            {
                Console.WriteLine("Cannot find file '{0}'", zipFilePath);
                return false;
            }

            using (ZipInputStream s = new ZipInputStream(File.OpenRead(zipFilePath)))
            {

                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string fileName = Path.GetFileName(theEntry.Name);
                    string lastName = "";
                    if (fileName.IndexOf(".csv") != -1)
                    {
                        lastName = ".csv";
                    }
                    if (fileName.IndexOf(".xls") != -1)
                    {
                        lastName = ".xls";
                    }
                    folderName += lastName; 
                    if (fileName != String.Empty)
                    {
                        using (FileStream streamWriter = File.Create(folderName))
                        {

                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            } 
                            streamWriter.Close();
                        }
                    }
                }
            }
            return true;
        }
 







    }
}