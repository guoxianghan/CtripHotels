using System.Windows.Forms;

namespace CtripHotelPrice
{
    partial class frmHotel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuery = new DNTBaseArch.Windows.Forms.ButtonEx();
            this.winFormPager1 = new bxyztSkin.Editors.WinFormPager();
            this.cDataGridView1 = new bxyztSkin.Editors.CDataGridView();
            this.HotelPlatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelPlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCity = new bxyztSkin.CControls.CTextBox();
            this.cLabel1 = new bxyztSkin.CControls.CLabel();
            this.txtArea = new bxyztSkin.CControls.CTextBox();
            this.txtAreae = new bxyztSkin.CControls.CLabel();
            this.txtHotelName = new bxyztSkin.CControls.CTextBox();
            this.cLabel3 = new bxyztSkin.CControls.CLabel();
            this.cLabel4 = new bxyztSkin.CControls.CLabel();
            this.comboxPlat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.CanExecute = true;
            this.btnQuery.Changed = "";
            this.btnQuery.CheckNull = "";
            this.btnQuery.CheckType = "";
            this.btnQuery.ChengeKey = false;
            this.btnQuery.Clear = false;
            this.btnQuery.CloseWindow = false;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.CommandName = "";
            this.btnQuery.ControlMemo = null;
            this.btnQuery.DBTable = "";
            this.btnQuery.DefaultType = "";
            this.btnQuery.EnableField = "";
            this.btnQuery.FormName = "";
            this.btnQuery.KeyField = "";
            this.btnQuery.LoadType = null;
            this.btnQuery.Location = new System.Drawing.Point(794, 40);
            this.btnQuery.Message = "";
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.OkMessage = "";
            this.btnQuery.RightGrid = "";
            this.btnQuery.Size = new System.Drawing.Size(75, 31);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 0;
            this.btnQuery.TableName = "";
            this.btnQuery.Text = "查询";
            this.btnQuery.TextField = "";
            this.btnQuery.TimeStampField = "";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // winFormPager1
            // 
            this.winFormPager1.BackColor = System.Drawing.Color.Transparent;
            this.winFormPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winFormPager1.Location = new System.Drawing.Point(0, 452);
            this.winFormPager1.Name = "winFormPager1";
            this.winFormPager1.NMax = 0;
            this.winFormPager1.PageCount = 0;
            this.winFormPager1.PageCurrent = 0;
            this.winFormPager1.PageSize = 20;
            this.winFormPager1.Size = new System.Drawing.Size(1108, 30);
            this.winFormPager1.TabIndex = 2;
            // 
            // cDataGridView1
            // 
            this.cDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.cDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.cDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.cDataGridView1.ColumnHeadersHeight = 26;
            this.cDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelPlatName,
            this.HotelPlatID,
            this.HotelID,
            this.HotelName,
            this.PlatName,
            this.PlatID,
            this.ID,
            this.City,
            this.Area});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.cDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDataGridView1.EnableHeadersVisualStyles = false;
            this.cDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.cDataGridView1.Name = "cDataGridView1";
            this.cDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.cDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cDataGridView1.RowTemplate.Height = 23;
            this.cDataGridView1.Size = new System.Drawing.Size(1108, 452);
            this.cDataGridView1.TabIndex = 3;
            // 
            // HotelPlatName
            // 
            this.HotelPlatName.DataPropertyName = "HotelPlatName";
            this.HotelPlatName.HeaderText = "酒店名称";
            this.HotelPlatName.MinimumWidth = 30;
            this.HotelPlatName.Name = "HotelPlatName";
            this.HotelPlatName.ReadOnly = true;
            this.HotelPlatName.ToolTipText = "HotelPlatName";
            this.HotelPlatName.Width = 80;
            // 
            // HotelPlatID
            // 
            this.HotelPlatID.DataPropertyName = "HotelPlatID";
            this.HotelPlatID.HeaderText = "酒店平台ID";
            this.HotelPlatID.MinimumWidth = 30;
            this.HotelPlatID.Name = "HotelPlatID";
            this.HotelPlatID.ReadOnly = true;
            this.HotelPlatID.ToolTipText = "HotelPlatID";
            this.HotelPlatID.Width = 80;
            // 
            // HotelID
            // 
            this.HotelID.DataPropertyName = "HotelID";
            this.HotelID.HeaderText = "HotelID";
            this.HotelID.MinimumWidth = 30;
            this.HotelID.Name = "HotelID";
            this.HotelID.ReadOnly = true;
            this.HotelID.ToolTipText = "HotelID";
            this.HotelID.Width = 80;
            HotelID.Visible = false;
            // 
            // HotelName
            // 
            this.HotelName.DataPropertyName = "HotelName";
            this.HotelName.HeaderText = "酒店名称";
            this.HotelName.MinimumWidth = 30;
            this.HotelName.Name = "HotelName";
            this.HotelName.ReadOnly = true;
            this.HotelName.ToolTipText = "HotelName";
            this.HotelName.Width = 80;
            // 
            // PlatName
            // 
            this.PlatName.DataPropertyName = "PlatName";
            this.PlatName.HeaderText = "平台";
            this.PlatName.MinimumWidth = 30;
            this.PlatName.Name = "PlatName";
            this.PlatName.ReadOnly = true;
            this.PlatName.ToolTipText = "PlatName";
            this.PlatName.Width = 80;
            // 
            // PlatID
            // 
            this.PlatID.DataPropertyName = "PlatID";
            this.PlatID.HeaderText = "PlatID";
            this.PlatID.MinimumWidth = 30;
            this.PlatID.Name = "PlatID";
            this.PlatID.ReadOnly = true;
            this.PlatID.ToolTipText = "PlatID";
            this.PlatID.Width = 80;
            PlatID.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "ID";
            this.ID.Width = 80;
            ID.Visible = false;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "城市";
            this.City.MinimumWidth = 30;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.ToolTipText = "City";
            this.City.Width = 80;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "地区";
            this.Area.MinimumWidth = 30;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.ToolTipText = "Area";
            this.Area.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cDataGridView1);
            this.panel1.Controls.Add(this.winFormPager1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 482);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboxPlat);
            this.panel2.Controls.Add(this.cLabel4);
            this.panel2.Controls.Add(this.cLabel3);
            this.panel2.Controls.Add(this.txtAreae);
            this.panel2.Controls.Add(this.cLabel1);
            this.panel2.Controls.Add(this.txtHotelName);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 77);
            this.panel2.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(63, 44);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 1;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Location = new System.Drawing.Point(10, 48);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(29, 12);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "城市";
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Location = new System.Drawing.Point(209, 44);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 21);
            this.txtArea.TabIndex = 1;
            // 
            // txtAreae
            // 
            this.txtAreae.AutoSize = true;
            this.txtAreae.BackColor = System.Drawing.Color.Transparent;
            this.txtAreae.Location = new System.Drawing.Point(174, 48);
            this.txtAreae.Name = "txtAreae";
            this.txtAreae.Size = new System.Drawing.Size(29, 12);
            this.txtAreae.TabIndex = 2;
            this.txtAreae.Text = "地区";
            // 
            // txtHotelName
            // 
            this.txtHotelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotelName.Location = new System.Drawing.Point(422, 44);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 21);
            this.txtHotelName.TabIndex = 1;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Location = new System.Drawing.Point(349, 46);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(53, 12);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "酒店名称";
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Location = new System.Drawing.Point(567, 48);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(29, 12);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "平台";
            // 
            // comboxPlat
            // 
            this.comboxPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPlat.FormattingEnabled = true;
            this.comboxPlat.Items.AddRange(new object[] {
            "所有",
            "携程"});
            this.comboxPlat.Location = new System.Drawing.Point(615, 46);
            this.comboxPlat.Name = "comboxPlat";
            this.comboxPlat.Size = new System.Drawing.Size(121, 20);
            this.comboxPlat.TabIndex = 3;
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmHotel";
            this.Text = "酒店信息";
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DNTBaseArch.Windows.Forms.ButtonEx btnQuery;
        private bxyztSkin.Editors.WinFormPager winFormPager1;
        private bxyztSkin.Editors.CDataGridView cDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn HotelPlatName;
        private DataGridViewTextBoxColumn HotelPlatID;
        private DataGridViewTextBoxColumn HotelID;
        private DataGridViewTextBoxColumn HotelName;
        private DataGridViewTextBoxColumn PlatName;
        private DataGridViewTextBoxColumn PlatID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Area;
        private bxyztSkin.CControls.CLabel cLabel4;
        private bxyztSkin.CControls.CLabel cLabel3;
        private bxyztSkin.CControls.CLabel txtAreae;
        private bxyztSkin.CControls.CLabel cLabel1;
        private bxyztSkin.CControls.CTextBox txtHotelName;
        private bxyztSkin.CControls.CTextBox txtArea;
        private bxyztSkin.CControls.CTextBox txtCity;
        private ComboBox comboxPlat;
    }
}

