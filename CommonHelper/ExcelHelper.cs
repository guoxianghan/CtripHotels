using org.in2bits.MyXls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class ExcelHelper
    {
        public static DataTable ExcelGetDataTable(string excelPath)
        {
            XlsDocument xls = new XlsDocument(excelPath);//加载外部Excel必须2003格式哦(*.xls)
            //获得Excel中的指定一个工作页
            Worksheet sheet = xls.Workbook.Worksheets[0];
            DataTable dt = new DataTable();
            try
            {
                ushort cellCount = sheet.Rows[ushort.Parse("1")].CellCount;//列数
                if (cellCount > 0)
                {
                    //添加列名
                    for (ushort j = 1; j <= cellCount; j++)
                    {
                        dt.Columns.Add(sheet.Rows[ushort.Parse("1")].GetCell(j).Value.ToString().Trim());
                    }
                    //添加行数据
                    for (ushort i = 2; i < sheet.Rows.Count; i++)//Excel文件只有一行数据但sheet.Rows.Count值为3第一行数列头，从第二行开始读是Excel文件的数据
                    {
                        object[] objRow = new object[cellCount];

                        for (ushort k = 1; k <= cellCount; k++)
                        {
                            if (sheet.Rows[i].CellExists(k))
                            {
                                objRow[k - 1] = sheet.Rows[i].CellAtCol(k).Value;
                            }
                            else
                            {
                                objRow[k - 1] = string.Empty;
                            }
                        }

                        dt.Rows.Add(objRow);
                    }
                }
            }
            catch (Exception ex)
            {
                //弹出异常
            }
            return dt;
        }
    }
}
