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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboxPlat = new System.Windows.Forms.ComboBox();
            this.cLabel4 = new bxyztSkin.CControls.CLabel();
            this.cLabel3 = new bxyztSkin.CControls.CLabel();
            this.txtAreae = new bxyztSkin.CControls.CLabel();
            this.cLabel1 = new bxyztSkin.CControls.CLabel();
            this.txtHotelName = new bxyztSkin.CControls.CTextBox();
            this.txtArea = new bxyztSkin.CControls.CTextBox();
            this.txtCity = new bxyztSkin.CControls.CTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comStar = new System.Windows.Forms.ComboBox();
            this.cLabel9 = new bxyztSkin.CControls.CLabel();
            this.btnFindPrice = new DNTBaseArch.Windows.Forms.ButtonEx();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cLabel6 = new bxyztSkin.CControls.CLabel();
            this.cLabel5 = new bxyztSkin.CControls.CLabel();
            this.btnStop = new DNTBaseArch.Windows.Forms.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
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
            this.btnQuery.Location = new System.Drawing.Point(697, 12);
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
            this.winFormPager1.Size = new System.Drawing.Size(1200, 30);
            this.winFormPager1.TabIndex = 2;
            // 
            // cDataGridView1
            // 
            this.cDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.cDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.cDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            this.Star,
            this.City,
            this.Area});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.cDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDataGridView1.EnableHeadersVisualStyles = false;
            this.cDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.cDataGridView1.Name = "cDataGridView1";
            this.cDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.cDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cDataGridView1.RowTemplate.Height = 23;
            this.cDataGridView1.Size = new System.Drawing.Size(1200, 452);
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
            this.HotelID.Visible = false;
            this.HotelID.Width = 80;
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
            this.PlatID.Visible = false;
            this.PlatID.Width = 80;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "ID";
            this.ID.Visible = false;
            this.ID.Width = 80;
            // 
            // Star
            // 
            this.Star.DataPropertyName = "Star";
            this.Star.HeaderText = "星级";
            this.Star.MinimumWidth = 30;
            this.Star.Name = "Star";
            this.Star.ReadOnly = true;
            this.Star.ToolTipText = "Star";
            this.Star.Width = 80;
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
            this.panel1.Size = new System.Drawing.Size(1200, 482);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.dateTimeInput2);
            this.panel2.Controls.Add(this.dateTimeInput1);
            this.panel2.Controls.Add(this.cLabel6);
            this.panel2.Controls.Add(this.cLabel5);
            this.panel2.Controls.Add(this.comStar);
            this.panel2.Controls.Add(this.cLabel9);
            this.panel2.Controls.Add(this.comboxPlat);
            this.panel2.Controls.Add(this.cLabel4);
            this.panel2.Controls.Add(this.cLabel3);
            this.panel2.Controls.Add(this.txtAreae);
            this.panel2.Controls.Add(this.cLabel1);
            this.panel2.Controls.Add(this.txtHotelName);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.btnFindPrice);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 77);
            this.panel2.TabIndex = 5;
            // 
            // comboxPlat
            // 
            this.comboxPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPlat.FormattingEnabled = true;
            this.comboxPlat.Items.AddRange(new object[] {
            "所有",
            "携程"});
            this.comboxPlat.Location = new System.Drawing.Point(608, 17);
            this.comboxPlat.Name = "comboxPlat";
            this.comboxPlat.Size = new System.Drawing.Size(73, 20);
            this.comboxPlat.TabIndex = 3;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Location = new System.Drawing.Point(560, 27);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(29, 12);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "平台";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Location = new System.Drawing.Point(297, 27);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(53, 12);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "酒店名称";
            // 
            // txtAreae
            // 
            this.txtAreae.AutoSize = true;
            this.txtAreae.BackColor = System.Drawing.Color.Transparent;
            this.txtAreae.Location = new System.Drawing.Point(162, 25);
            this.txtAreae.Name = "txtAreae";
            this.txtAreae.Size = new System.Drawing.Size(29, 12);
            this.txtAreae.TabIndex = 2;
            this.txtAreae.Text = "地区";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Location = new System.Drawing.Point(20, 21);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(29, 12);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "城市";
            // 
            // txtHotelName
            // 
            this.txtHotelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotelName.Location = new System.Drawing.Point(356, 17);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 21);
            this.txtHotelName.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Location = new System.Drawing.Point(197, 17);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 21);
            this.txtArea.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(55, 17);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // comStar
            // 
            this.comStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStar.FormattingEnabled = true;
            this.comStar.Items.AddRange(new object[] {
            "所有",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comStar.Location = new System.Drawing.Point(502, 17);
            this.comStar.Name = "comStar";
            this.comStar.Size = new System.Drawing.Size(52, 20);
            this.comStar.TabIndex = 5;
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cLabel9.Location = new System.Drawing.Point(467, 27);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.Size = new System.Drawing.Size(29, 12);
            this.cLabel9.TabIndex = 4;
            this.cLabel9.Text = "星级";
            // 
            // btnFindPrice
            // 
            this.btnFindPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindPrice.CanExecute = true;
            this.btnFindPrice.Changed = "";
            this.btnFindPrice.CheckNull = "";
            this.btnFindPrice.CheckType = "";
            this.btnFindPrice.ChengeKey = false;
            this.btnFindPrice.Clear = false;
            this.btnFindPrice.CloseWindow = false;
            this.btnFindPrice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindPrice.CommandName = "";
            this.btnFindPrice.ControlMemo = null;
            this.btnFindPrice.DBTable = "";
            this.btnFindPrice.DefaultType = "";
            this.btnFindPrice.EnableField = "";
            this.btnFindPrice.FormName = "";
            this.btnFindPrice.KeyField = "";
            this.btnFindPrice.LoadType = null;
            this.btnFindPrice.Location = new System.Drawing.Point(356, 44);
            this.btnFindPrice.Message = "";
            this.btnFindPrice.Name = "btnFindPrice";
            this.btnFindPrice.OkMessage = "";
            this.btnFindPrice.RightGrid = "";
            this.btnFindPrice.Size = new System.Drawing.Size(101, 31);
            this.btnFindPrice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindPrice.TabIndex = 0;
            this.btnFindPrice.TableName = "";
            this.btnFindPrice.Text = "自动查价格";
            this.btnFindPrice.TextField = "";
            this.btnFindPrice.TimeStampField = "";
            this.btnFindPrice.Click += new System.EventHandler(this.btnFindPrice_Click);
            // 
            // dateTimeInput2
            // 
            // 
            // 
            // 
            this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput2.ButtonDropDown.Visible = true;
            this.dateTimeInput2.IsPopupCalendarOpen = false;
            this.dateTimeInput2.Location = new System.Drawing.Point(55, 53);
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateTimeInput2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimeInput2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput2.Name = "dateTimeInput2";
            this.dateTimeInput2.Size = new System.Drawing.Size(126, 21);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 9;
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(212, 53);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(130, 21);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 10;
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cLabel6.Location = new System.Drawing.Point(189, 57);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.Size = new System.Drawing.Size(11, 12);
            this.cLabel6.TabIndex = 7;
            this.cLabel6.Text = "-";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cLabel5.Location = new System.Drawing.Point(20, 57);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Size = new System.Drawing.Size(29, 12);
            this.cLabel5.TabIndex = 8;
            this.cLabel5.Text = "日期";
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.CanExecute = true;
            this.btnStop.Changed = "";
            this.btnStop.CheckNull = "";
            this.btnStop.CheckType = "";
            this.btnStop.ChengeKey = false;
            this.btnStop.Clear = false;
            this.btnStop.CloseWindow = false;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.CommandName = "";
            this.btnStop.ControlMemo = null;
            this.btnStop.DBTable = "";
            this.btnStop.DefaultType = "";
            this.btnStop.EnableField = "";
            this.btnStop.FormName = "";
            this.btnStop.KeyField = "";
            this.btnStop.LoadType = null;
            this.btnStop.Location = new System.Drawing.Point(463, 44);
            this.btnStop.Message = "";
            this.btnStop.Name = "btnStop";
            this.btnStop.OkMessage = "";
            this.btnStop.RightGrid = "";
            this.btnStop.Size = new System.Drawing.Size(63, 31);
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStop.TabIndex = 11;
            this.btnStop.TableName = "";
            this.btnStop.Text = "停止查询";
            this.btnStop.TextField = "";
            this.btnStop.TimeStampField = "";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmHotel";
            this.Text = "酒店信息";
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
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
        private DataGridViewTextBoxColumn Star;
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
        private ComboBox comStar;
        private bxyztSkin.CControls.CLabel cLabel9;
        private DNTBaseArch.Windows.Forms.ButtonEx btnFindPrice;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private bxyztSkin.CControls.CLabel cLabel6;
        private bxyztSkin.CControls.CLabel cLabel5;
        private DNTBaseArch.Windows.Forms.ButtonEx btnStop;
    }
}

