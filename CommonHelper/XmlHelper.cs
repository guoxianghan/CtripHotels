using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace CommonHelper
{
   public class XmlHelper
    {
       static string strpath = System.Windows.Forms.Application.StartupPath;
       private static string xmlAirTypePath = strpath + "\\AIOAirType.xml";
       private static string xmlIniConfigPath = strpath + "\\IniConfig.xml";
       private static string Xmlpath { get { return xmlAirTypePath; } }

       public XmlHelper()
       {
 //
       }

       public static XmlDocument GetXmlDocument()
       {
           XmlDocument xmdoc = new XmlDocument();
           try
           {
               xmdoc.Load(xmlAirTypePath);
           }
           catch(Exception ex)
           { string mes= ex.Message; }
             
           return xmdoc;
       }

       public static XmlNodeList GetXmlNodeList(string tagname)
       {
           return GetXmlDocument().SelectSingleNode(tagname).ChildNodes;
       }

       public static IDictionary<string, string> GetDictionary(string tagname)
       {
           IDictionary<string, string> DicResult = new Dictionary<string, string>();
           XmlNodeList xmlnode = GetXmlNodeList(tagname);
           foreach (XmlNode node in xmlnode)
           {
               XmlNode x = node;
               DicResult.Add(node.Attributes[0].Value, node.InnerText);
           }
           return DicResult;
       }

       public static DataTable CreateTable(string tagname)
       {
           IDictionary<string, string> DicResult = GetDictionary(tagname);
           DataTable dt = new DataTable();
           dt.Columns.Add("Key");
           dt.Columns.Add("Value");

           foreach(var i in DicResult)
           {
               dt.Rows.Add(i.Key,i.Value);
           }
           return dt;
       }
       public static DataTable CreateTableByKey(string tagname)
       {
           IDictionary<string, string> DicResult = GetDictionary(tagname);
           DataTable dt = new DataTable();
           dt.Columns.Add("Key");
           dt.Columns.Add("Value");

           foreach (var i in DicResult)
           {
               dt.Rows.Add(i.Key, i.Key+"-"+i.Value);
           }
           return dt;
       }
    }

  
}
