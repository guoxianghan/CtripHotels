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
    public partial class frmHotel : Form
    {
        public frmHotel()
        {
            InitializeComponent();
            comboxPlat.SelectedIndex = 0;
            winFormPager1.PageSize = 100;
            //winFormPager1.PageCount = 80;

            winFormPager1.EventPaging += WinFormPager1_EventPaging;
        }
        HotelDetailViewServer server = new HotelDetailViewServer();
        private int WinFormPager1_EventPaging(bxyztSkin.Editors.EventPagingArg e)
        {
            string  sql = sqlwhere();
            this.cDataGridView1.DataSource = server.GetListModelByPage(sql, "ID", (winFormPager1.PageCurrent - 1) * 100, winFormPager1.PageCurrent * 100);
            int count = server.GetRecordCount(sql);
            return count;
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
            if (!string.IsNullOrEmpty(txtHotelName.Text.Trim()))
            {
                sql.Append("HotelName like '%" + txtHotelName.Text.Trim() + "%' AND ");
            }
            if (comboxPlat.SelectedIndex != 0)
            {
                sql.Append("[PlatID]=" + comboxPlat.SelectedIndex);
            }

            return sql.ToString().Trim('N', 'A', 'D');
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            winFormPager1.PageCurrent = 1;
            WinFormPager1_EventPaging(null);            
        }
    }
}
