using System.Windows.Forms;

namespace CtripHotelPrice
{
    partial class frmPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRoom = new DevComponents.DotNetBar.ButtonX();
            this.btnHotel = new DevComponents.DotNetBar.ButtonX();
            this.cLabel2 = new bxyztSkin.CControls.CLabel();
            this.txtroom = new bxyztSkin.CControls.CTextBox();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnQuery = new DNTBaseArch.Windows.Forms.ButtonEx();
            this.comIsCancel = new System.Windows.Forms.ComboBox();
            this.cLabel10 = new bxyztSkin.CControls.CLabel();
            this.comStar = new System.Windows.Forms.ComboBox();
            this.cLabel9 = new bxyztSkin.CControls.CLabel();
            this.comBreakFirst = new System.Windows.Forms.ComboBox();
            this.cLabel8 = new bxyztSkin.CControls.CLabel();
            this.comBedType = new System.Windows.Forms.ComboBox();
            this.cLabel7 = new bxyztSkin.CControls.CLabel();
            this.comboxPlat = new System.Windows.Forms.ComboBox();
            this.cLabel4 = new bxyztSkin.CControls.CLabel();
            this.cLabel3 = new bxyztSkin.CControls.CLabel();
            this.cLabel6 = new bxyztSkin.CControls.CLabel();
            this.cLabel5 = new bxyztSkin.CControls.CLabel();
            this.txtAreae = new bxyztSkin.CControls.CLabel();
            this.cLabel1 = new bxyztSkin.CControls.CLabel();
            this.txtHotelName = new bxyztSkin.CControls.CTextBox();
            this.txtArea = new bxyztSkin.CControls.CTextBox();
            this.txtCity = new bxyztSkin.CControls.CTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cDataGridView1 = new bxyztSkin.Editors.CDataGridView();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelPlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakfirstType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAgentPrivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winFormPager1 = new bxyztSkin.Editors.WinFormPager();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnImport = new DNTBaseArch.Windows.Forms.ButtonEx();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).BeginInit();
            this.winFormPager1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnRoom);
            this.panel2.Controls.Add(this.btnHotel);
            this.panel2.Controls.Add(this.cLabel2);
            this.panel2.Controls.Add(this.txtroom);
            this.panel2.Controls.Add(this.dateTimeInput2);
            this.panel2.Controls.Add(this.dateTimeInput1);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.comIsCancel);
            this.panel2.Controls.Add(this.cLabel10);
            this.panel2.Controls.Add(this.comStar);
            this.panel2.Controls.Add(this.cLabel9);
            this.panel2.Controls.Add(this.comBreakFirst);
            this.panel2.Controls.Add(this.cLabel8);
            this.panel2.Controls.Add(this.comBedType);
            this.panel2.Controls.Add(this.cLabel7);
            this.panel2.Controls.Add(this.comboxPlat);
            this.panel2.Controls.Add(this.cLabel4);
            this.panel2.Controls.Add(this.cLabel3);
            this.panel2.Controls.Add(this.cLabel6);
            this.panel2.Controls.Add(this.cLabel5);
            this.panel2.Controls.Add(this.txtAreae);
            this.panel2.Controls.Add(this.cLabel1);
            this.panel2.Controls.Add(this.txtHotelName);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 80);
            this.panel2.TabIndex = 6;
            // 
            // btnRoom
            // 
            this.btnRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRoom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRoom.Location = new System.Drawing.Point(1008, 46);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(75, 31);
            this.btnRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRoom.TabIndex = 9;
            this.btnRoom.Text = "房型";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHotel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHotel.Location = new System.Drawing.Point(1008, 13);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(75, 31);
            this.btnHotel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHotel.TabIndex = 9;
            this.btnHotel.Text = "酒店";
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Location = new System.Drawing.Point(174, 13);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(53, 12);
            this.cLabel2.TabIndex = 8;
            this.cLabel2.Text = "房型名称";
            // 
            // txtroom
            // 
            this.txtroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtroom.Location = new System.Drawing.Point(233, 9);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(100, 21);
            this.txtroom.TabIndex = 7;
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
            this.dateTimeInput2.Location = new System.Drawing.Point(409, 38);
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
            this.dateTimeInput2.Size = new System.Drawing.Size(131, 21);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 6;
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
            this.dateTimeInput1.Location = new System.Drawing.Point(566, 39);
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
            this.dateTimeInput1.Size = new System.Drawing.Size(131, 21);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 6;
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
            this.btnQuery.Location = new System.Drawing.Point(871, 36);
            this.btnQuery.Message = "";
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.OkMessage = "";
            this.btnQuery.RightGrid = "";
            this.btnQuery.Size = new System.Drawing.Size(75, 31);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 4;
            this.btnQuery.TableName = "";
            this.btnQuery.Text = "查询";
            this.btnQuery.TextField = "";
            this.btnQuery.TimeStampField = "";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // comIsCancel
            // 
            this.comIsCancel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comIsCancel.FormattingEnabled = true;
            this.comIsCancel.Items.AddRange(new object[] {
            "所有",
            "不可取消",
            "可取消"});
            this.comIsCancel.Location = new System.Drawing.Point(744, 10);
            this.comIsCancel.Name = "comIsCancel";
            this.comIsCancel.Size = new System.Drawing.Size(92, 20);
            this.comIsCancel.TabIndex = 3;
            // 
            // cLabel10
            // 
            this.cLabel10.AutoSize = true;
            this.cLabel10.BackColor = System.Drawing.Color.Transparent;
            this.cLabel10.Location = new System.Drawing.Point(673, 15);
            this.cLabel10.Name = "cLabel10";
            this.cLabel10.Size = new System.Drawing.Size(65, 12);
            this.cLabel10.TabIndex = 2;
            this.cLabel10.Text = "是否可取消";
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
            this.comStar.Location = new System.Drawing.Point(593, 12);
            this.comStar.Name = "comStar";
            this.comStar.Size = new System.Drawing.Size(52, 20);
            this.comStar.TabIndex = 3;
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cLabel9.Location = new System.Drawing.Point(558, 16);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.Size = new System.Drawing.Size(29, 12);
            this.cLabel9.TabIndex = 2;
            this.cLabel9.Text = "星级";
            // 
            // comBreakFirst
            // 
            this.comBreakFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBreakFirst.FormattingEnabled = true;
            this.comBreakFirst.Items.AddRange(new object[] {
            "所有",
            "0",
            "1",
            "2",
            "3"});
            this.comBreakFirst.Location = new System.Drawing.Point(488, 13);
            this.comBreakFirst.Name = "comBreakFirst";
            this.comBreakFirst.Size = new System.Drawing.Size(52, 20);
            this.comBreakFirst.TabIndex = 3;
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cLabel8.Location = new System.Drawing.Point(453, 17);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.Size = new System.Drawing.Size(29, 12);
            this.cLabel8.TabIndex = 2;
            this.cLabel8.Text = "含餐";
            // 
            // comBedType
            // 
            this.comBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBedType.FormattingEnabled = true;
            this.comBedType.Items.AddRange(new object[] {
            "所有",
            "大床",
            "双床"});
            this.comBedType.Location = new System.Drawing.Point(384, 12);
            this.comBedType.Name = "comBedType";
            this.comBedType.Size = new System.Drawing.Size(52, 20);
            this.comBedType.TabIndex = 3;
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cLabel7.Location = new System.Drawing.Point(349, 16);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.Size = new System.Drawing.Size(29, 12);
            this.cLabel7.TabIndex = 2;
            this.cLabel7.Text = "床型";
            // 
            // comboxPlat
            // 
            this.comboxPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPlat.FormattingEnabled = true;
            this.comboxPlat.Items.AddRange(new object[] {
            "所有",
            "携程"});
            this.comboxPlat.Location = new System.Drawing.Point(744, 40);
            this.comboxPlat.Name = "comboxPlat";
            this.comboxPlat.Size = new System.Drawing.Size(92, 20);
            this.comboxPlat.TabIndex = 3;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Location = new System.Drawing.Point(709, 44);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(29, 12);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "平台";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Location = new System.Drawing.Point(175, 40);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(53, 12);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "酒店名称";
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cLabel6.Location = new System.Drawing.Point(546, 43);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.Size = new System.Drawing.Size(11, 12);
            this.cLabel6.TabIndex = 2;
            this.cLabel6.Text = "-";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cLabel5.Location = new System.Drawing.Point(349, 42);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Size = new System.Drawing.Size(53, 12);
            this.cLabel5.TabIndex = 2;
            this.cLabel5.Text = "入住日期";
            // 
            // txtAreae
            // 
            this.txtAreae.AutoSize = true;
            this.txtAreae.BackColor = System.Drawing.Color.Transparent;
            this.txtAreae.Location = new System.Drawing.Point(15, 43);
            this.txtAreae.Name = "txtAreae";
            this.txtAreae.Size = new System.Drawing.Size(29, 12);
            this.txtAreae.TabIndex = 2;
            this.txtAreae.Text = "地区";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Location = new System.Drawing.Point(15, 13);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(29, 12);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "城市";
            // 
            // txtHotelName
            // 
            this.txtHotelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotelName.Location = new System.Drawing.Point(233, 36);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 21);
            this.txtHotelName.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Location = new System.Drawing.Point(68, 36);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 21);
            this.txtArea.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(68, 9);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cDataGridView1);
            this.panel1.Controls.Add(this.winFormPager1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 473);
            this.panel1.TabIndex = 7;
            // 
            // cDataGridView1
            // 
            this.cDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.cDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.cDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.cDataGridView1.ColumnHeadersHeight = 26;
            this.cDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelName,
            this.Price,
            this.HotelID,
            this.PlatID,
            this.RoomID,
            this.RoomName,
            this.InDate,
            this.OutDate,
            this.HotelPlatID,
            this.ID,
            this.BedType,
            this.BreakfirstType,
            this.BaseRoomID,
            this.IsAgentPrivate,
            this.SaleTitle,
            this.RoomCount,
            this.Tag,
            this.City,
            this.CreateDate,
            this.UpdateDate,
            this.PlatName,
            this.Area});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.cDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDataGridView1.EnableHeadersVisualStyles = false;
            this.cDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.cDataGridView1.Name = "cDataGridView1";
            this.cDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.cDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cDataGridView1.RowTemplate.Height = 23;
            this.cDataGridView1.Size = new System.Drawing.Size(1095, 443);
            this.cDataGridView1.TabIndex = 3;
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
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.MinimumWidth = 30;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.ToolTipText = "Price";
            this.Price.Width = 80;
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
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "价格ID";
            this.RoomID.MinimumWidth = 30;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.ToolTipText = "RoomID";
            this.RoomID.Width = 80;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "房型";
            this.RoomName.MinimumWidth = 30;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.ToolTipText = "RoomName";
            this.RoomName.Width = 80;
            // 
            // InDate
            // 
            this.InDate.DataPropertyName = "InDate";
            this.InDate.HeaderText = "入住日期";
            this.InDate.MinimumWidth = 30;
            this.InDate.Name = "InDate";
            this.InDate.ReadOnly = true;
            this.InDate.ToolTipText = "InDate";
            this.InDate.Width = 80;
            // 
            // OutDate
            // 
            this.OutDate.DataPropertyName = "OutDate";
            this.OutDate.HeaderText = "离开日期";
            this.OutDate.MinimumWidth = 30;
            this.OutDate.Name = "OutDate";
            this.OutDate.ReadOnly = true;
            this.OutDate.ToolTipText = "OutDate";
            this.OutDate.Width = 80;
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
            // BedType
            // 
            this.BedType.DataPropertyName = "BedType";
            this.BedType.HeaderText = "床型";
            this.BedType.MinimumWidth = 30;
            this.BedType.Name = "BedType";
            this.BedType.ReadOnly = true;
            this.BedType.ToolTipText = "BedType";
            this.BedType.Width = 80;
            // 
            // BreakfirstType
            // 
            this.BreakfirstType.DataPropertyName = "BreakfirstType";
            this.BreakfirstType.HeaderText = "早餐";
            this.BreakfirstType.MinimumWidth = 30;
            this.BreakfirstType.Name = "BreakfirstType";
            this.BreakfirstType.ReadOnly = true;
            this.BreakfirstType.ToolTipText = "BreakfirstType";
            this.BreakfirstType.Width = 80;
            // 
            // BaseRoomID
            // 
            this.BaseRoomID.DataPropertyName = "BaseRoomID";
            this.BaseRoomID.HeaderText = "房型ID";
            this.BaseRoomID.MinimumWidth = 30;
            this.BaseRoomID.Name = "BaseRoomID";
            this.BaseRoomID.ReadOnly = true;
            this.BaseRoomID.ToolTipText = "BaseRoomID";
            this.BaseRoomID.Width = 80;
            // 
            // IsAgentPrivate
            // 
            this.IsAgentPrivate.DataPropertyName = "IsAgentPrivate";
            this.IsAgentPrivate.HeaderText = "是否平台私有";
            this.IsAgentPrivate.MinimumWidth = 30;
            this.IsAgentPrivate.Name = "IsAgentPrivate";
            this.IsAgentPrivate.ReadOnly = true;
            this.IsAgentPrivate.ToolTipText = "IsAgentPrivate";
            this.IsAgentPrivate.Width = 80;
            // 
            // SaleTitle
            // 
            this.SaleTitle.DataPropertyName = "SaleTitle";
            this.SaleTitle.HeaderText = "发单名称";
            this.SaleTitle.MinimumWidth = 30;
            this.SaleTitle.Name = "SaleTitle";
            this.SaleTitle.ReadOnly = true;
            this.SaleTitle.ToolTipText = "SaleTitle";
            this.SaleTitle.Width = 80;
            // 
            // RoomCount
            // 
            this.RoomCount.DataPropertyName = "RoomCount";
            this.RoomCount.HeaderText = "房量";
            this.RoomCount.MinimumWidth = 30;
            this.RoomCount.Name = "RoomCount";
            this.RoomCount.ReadOnly = true;
            this.RoomCount.ToolTipText = "RoomCount";
            this.RoomCount.Width = 80;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "预定";
            this.Tag.MinimumWidth = 30;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            this.Tag.ToolTipText = "Tag";
            this.Tag.Width = 80;
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
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "查询日期";
            this.CreateDate.MinimumWidth = 30;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.ToolTipText = "CreateDate";
            this.CreateDate.Width = 80;
            // 
            // UpdateDate
            // 
            this.UpdateDate.DataPropertyName = "UpdateDate";
            this.UpdateDate.HeaderText = "更新日期";
            this.UpdateDate.MinimumWidth = 30;
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.ReadOnly = true;
            this.UpdateDate.ToolTipText = "UpdateDate";
            this.UpdateDate.Width = 80;
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
            // winFormPager1
            // 
            this.winFormPager1.BackColor = System.Drawing.Color.Transparent;
            this.winFormPager1.Controls.Add(this.bindingNavigator);
            this.winFormPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winFormPager1.Location = new System.Drawing.Point(0, 443);
            this.winFormPager1.Name = "winFormPager1";
            this.winFormPager1.NMax = 0;
            this.winFormPager1.PageCount = 0;
            this.winFormPager1.PageCurrent = 0;
            this.winFormPager1.PageSize = 20;
            this.winFormPager1.Size = new System.Drawing.Size(1095, 30);
            this.winFormPager1.TabIndex = 2;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator.Size = new System.Drawing.Size(1095, 30);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImport.CanExecute = true;
            this.btnImport.Changed = "";
            this.btnImport.CheckNull = "";
            this.btnImport.CheckType = "";
            this.btnImport.ChengeKey = false;
            this.btnImport.Clear = false;
            this.btnImport.CloseWindow = false;
            this.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImport.CommandName = "";
            this.btnImport.ControlMemo = null;
            this.btnImport.DBTable = "";
            this.btnImport.DefaultType = "";
            this.btnImport.EnableField = "";
            this.btnImport.FormName = "";
            this.btnImport.KeyField = "";
            this.btnImport.LoadType = null;
            this.btnImport.Location = new System.Drawing.Point(871, 3);
            this.btnImport.Message = "";
            this.btnImport.Name = "btnImport";
            this.btnImport.OkMessage = "";
            this.btnImport.RightGrid = "";
            this.btnImport.Size = new System.Drawing.Size(75, 31);
            this.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImport.TabIndex = 10;
            this.btnImport.TableName = "";
            this.btnImport.Text = "导出";
            this.btnImport.TextField = "";
            this.btnImport.TimeStampField = "";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店价格信息";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).EndInit();
            this.winFormPager1.ResumeLayout(false);
            this.winFormPager1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboxPlat;
        private bxyztSkin.CControls.CLabel cLabel4;
        private bxyztSkin.CControls.CLabel cLabel3;
        private bxyztSkin.CControls.CLabel txtAreae;
        private bxyztSkin.CControls.CLabel cLabel1;
        private bxyztSkin.CControls.CTextBox txtHotelName;
        private bxyztSkin.CControls.CTextBox txtArea;
        private bxyztSkin.CControls.CTextBox txtCity;
        private System.Windows.Forms.Panel panel1;
        private bxyztSkin.Editors.CDataGridView cDataGridView1;
        private bxyztSkin.Editors.WinFormPager winFormPager1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private DNTBaseArch.Windows.Forms.ButtonEx btnQuery;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private bxyztSkin.CControls.CLabel cLabel2;
        private bxyztSkin.CControls.CTextBox txtroom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private bxyztSkin.CControls.CLabel cLabel5;
        private bxyztSkin.CControls.CLabel cLabel6;
        private DataGridViewTextBoxColumn HotelName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn HotelID;
        private DataGridViewTextBoxColumn PlatID;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn InDate;
        private DataGridViewTextBoxColumn OutDate;
        private DataGridViewTextBoxColumn HotelPlatID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BedType;
        private DataGridViewTextBoxColumn BreakfirstType;
        private DataGridViewTextBoxColumn BaseRoomID;
        private DataGridViewTextBoxColumn IsAgentPrivate;
        private DataGridViewTextBoxColumn SaleTitle;
        private DataGridViewTextBoxColumn RoomCount;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn UpdateDate;
        private DataGridViewTextBoxColumn PlatName;
        private DataGridViewTextBoxColumn Area;
        private DevComponents.DotNetBar.ButtonX btnRoom;
        private DevComponents.DotNetBar.ButtonX btnHotel;
        private ComboBox comBreakFirst;
        private bxyztSkin.CControls.CLabel cLabel8;
        private ComboBox comBedType;
        private bxyztSkin.CControls.CLabel cLabel7;
        private ComboBox comStar;
        private bxyztSkin.CControls.CLabel cLabel9;
        private ComboBox comIsCancel;
        private bxyztSkin.CControls.CLabel cLabel10;
        private DNTBaseArch.Windows.Forms.ButtonEx btnImport;
        private SaveFileDialog saveFileDialog1;
    }
}