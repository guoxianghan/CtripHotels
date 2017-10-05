using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CommonHelper
{
    public static class XmlSerializer
    {
        public static void SaveToXml(string filePath, object sourceObj, Type type, string xmlRootName)
        {
            if (!string.IsNullOrWhiteSpace(filePath) && sourceObj != null)
            {
                type = type != null ? type : sourceObj.GetType();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    System.Xml.Serialization.XmlSerializer xmlSerializer = string.IsNullOrWhiteSpace(xmlRootName) ?
                        new System.Xml.Serialization.XmlSerializer(type) :
                        new System.Xml.Serialization.XmlSerializer(type, new XmlRootAttribute(xmlRootName));
                    xmlSerializer.Serialize(writer, sourceObj);
                }
            }
        }

        public static object LoadFromXml(string filePath, Type type)
        {
            object result = null;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(type);
                    result = xmlSerializer.Deserialize(reader);
                }
            }

            return result;
        }
        public static object LoadFromXml(Stream stream, Type type)
        {
            object result = null;
            using (StreamReader reader = new StreamReader(stream))
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(type);
                result = xmlSerializer.Deserialize(reader);
            }


            return result;
        }
        #region 序列化
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string Serializer(Type type, object obj)
        {
            MemoryStream Stream = new MemoryStream();
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(type);
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();

            sr.Dispose();
            Stream.Dispose();

            return str;
        }

        public static object LoadFromXml(string xml, Type type, Encoding encode)
        {
            MemoryStream ms = new MemoryStream(encode.GetBytes(xml));
            return LoadFromXml(ms, type);
        }

        #endregion
    }
}
