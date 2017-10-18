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
            comStar.SelectedIndex = 0;
            winFormPager1.PageSize = 100;
            //winFormPager1.PageCount = 80;

            winFormPager1.EventPaging += WinFormPager1_EventPaging;
            _price.OnStartWorkerNotify += _price_OnStartWorkerNotify;
            _price.OnStopWorkerNotify += _price_OnStopWorkerNotify;
            this.btnStop.Enabled = false;
        }

        private void _price_OnStopWorkerNotify()
        {
            this.BeginInvoke(new Action(() =>
            {
                this.btnFindPrice.Enabled = true;
                this.btnStop.Enabled = false;
            }));
        }

        private void _price_OnStartWorkerNotify()
        {
            this.BeginInvoke(new Action(() =>
            {
                this.btnFindPrice.Enabled = false;
                this.btnStop.Enabled = true;
            }));
        }

        HotelDetailViewServer server = new HotelDetailViewServer();
        private int WinFormPager1_EventPaging(bxyztSkin.Editors.EventPagingArg e)
        {
            string sql = sqlwhere();
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
            if (comStar.SelectedIndex != 0)
            {
                sql.Append("[Star] = '" + (comStar.SelectedIndex - 1) + "' AND");
            }
            return sql.ToString().Trim('A', 'N', 'D',' ');
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            winFormPager1.PageCurrent = 1;
            WinFormPager1_EventPaging(null);
        }
        PriceController _price = new PriceController();
        private void btnFindPrice_Click(object sender, EventArgs e)
        {
            _price.sql = sqlwhere();
            _price.d1 = this.dateTimeInput2.Value;
            _price.d2 = this.dateTimeInput1.Value;
            if ((_price.d2.Date - _price.d1.Date).Days <= 0)
            {
                MessageBox.Show("结束日期不能小于开始日期", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((_price.d2.Date - DateTime.Now.Date).Days <= 0)
            {
                MessageBox.Show("开始日期不能在今天之前", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _price.StartWork();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _price.StopWork();
        }
    }
}
