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
            winFormPager1.PageSize = 100;
            winFormPager1.EventPaging += WinFormPager1_EventPaging;
        }

        private int WinFormPager1_EventPaging(bxyztSkin.Editors.EventPagingArg e)
        {
            string sql = sqlwhere();
            this.cDataGridView1.DataSource = server.GetModelList(sql, "ID", (winFormPager1.PageCurrent - 1) * 100, winFormPager1.PageCurrent * 100);
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
                sql.Append("INDATE<='" + d1.ToString("yyyy-MM-dd 00:00") + "' AND");
            }
            DateTime d2 = DateTime.MinValue;
            if (DateTime.TryParse(dateTimeInput2.Text, out d2))
            {
                sql.Append("INDATE>='" + d2.ToString("yyyy-MM-dd 23:59") + "' AND");
            }
            return sql.ToString().Trim('N', 'A', 'D');
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
    }
}
