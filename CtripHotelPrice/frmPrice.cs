using CommonHelper;
using HotelServerLogic;
using Maticsoft.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtripHotelPrice
{
    public partial class frmPrice : Form
    {
        public frmPrice()
        {
            InitializeComponent();
            comboxPlat.SelectedIndex = 0;
            comBedType.SelectedIndex = 0;
            comBreakFirst.SelectedIndex = 0;
            comIsCancel.SelectedIndex = 0;
            comStar.SelectedIndex = 0;
            winFormPager1.PageSize = 100;

            saveFileDialog1.Filter = "xls files(*.xls)|";
            winFormPager1.EventPaging += WinFormPager1_EventPaging;
            btnQuery_Click(null, null);
        }

        private int WinFormPager1_EventPaging(bxyztSkin.Editors.EventPagingArg e)
        {
            string sql = sqlwhere();
            this.cDataGridView1.DataSource = server.GetListByPage(sql, "ID", (winFormPager1.PageCurrent - 1) * 100, winFormPager1.PageCurrent * 100).Tables[0];
            int count = server.GetRecordCount(sql);
            return count;
        }

        HotelPriceViewServer server = new HotelPriceViewServer();

        private void btnQuery_Click(object sender, EventArgs e)
        {
            winFormPager1.PageCurrent = 1;
            WinFormPager1_EventPaging(null);
        }
        private string sqlwhere()
        {
            StringBuilder sql = new StringBuilder("AND ");
            if (!string.IsNullOrEmpty(txtArea.Text.Trim()))
            {
                sql.Append("Area like '%" + txtArea.Text.Trim() + "%' AND ");
            }
            if (!string.IsNullOrEmpty(txtCity.Text.Trim()))
            {
                sql.Append("City like '%" + txtCity.Text.Trim() + "%' AND ");
            }
            if (!string.IsNullOrEmpty(txtroom.Text.Trim()))
            {
                sql.Append("RoomName like '%" + txtroom.Text.Trim() + "%' AND ");
            }
            if (!string.IsNullOrEmpty(txtHotelName.Text.Trim()))
            {
                sql.Append("HotelName like '%" + txtHotelName.Text.Trim() + "%' AND ");
            }
            if (comboxPlat.SelectedIndex != 0)
            {
                sql.Append("[PlatID]=" + comboxPlat.SelectedIndex);
            }
            DateTime d1 = DateTime.MinValue;
            if (DateTime.TryParse(dateTimeInput1.Text, out d1))
            {
                sql.Append("INDATE<='" + d1.ToString("yyyy-MM-dd 00:00") + "' AND ");
            }
            DateTime d2 = DateTime.MinValue;
            if (DateTime.TryParse(dateTimeInput2.Text, out d2))
            {
                sql.Append("INDATE>='" + d2.ToString("yyyy-MM-dd 23:59") + "' AND ");
            }

            //comboxPlat.SelectedIndex = 0;
            //comBedType.SelectedIndex = 0;
            //comBreakFirst.SelectedIndex = 0;
            //comIsCancel.SelectedIndex = 0;
            //comStar.SelectedIndex = 0;
            if (comBedType.SelectedIndex != 0)
            {
                sql.Append("[BedType] = '" + comBedType.SelectedItem.ToString() + "' AND");
            }
            if (comStar.SelectedIndex != 0)
            {
                sql.Append("[Star] = '" + (comStar.SelectedIndex - 1) + "' AND");
            }
            if (comBreakFirst.SelectedIndex != 0)
            {
                sql.Append("[BreakfirstType] = " + (comBreakFirst.SelectedIndex - 1) + "");
            }
            //if (comIsCancel.SelectedIndex != 0)
            //{
            //    sql.Append("[BreakfirstType] = '" + comIsCancel.SelectedIndex+"'");
            //}
            return sql.ToString().Trim('A', 'N', 'D', ' ');
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            frmHotel f = new CtripHotelPrice.frmHotel();
            f.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom r = new CtripHotelPrice.frmRoom();
            r.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            var dr = saveFileDialog1.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            string sql = sqlwhere();
            var count = server.GetRecordCount(sql);
            if (count > 50000)
            {
                MessageBox.Show("数据量大于5万条,请筛选数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var dt = server.GetTable(sql);
                NPOIExcelHelperV2 npoi = new NPOIExcelHelperV2(saveFileDialog1.FileName + ".xls");
                foreach (DataGridViewColumn col in this.cDataGridView1.Columns)
                {
                    foreach (DataColumn item in dt.Columns)
                    {
                        if (col.Name == item.ColumnName)
                        {
                            item.ColumnName = col.HeaderText;
                            break;
                        }
                    }
                }
                npoi.DataTableToExcel(dt, "sheet1", true);
                MessageBox.Show("导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
