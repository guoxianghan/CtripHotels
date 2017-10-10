using System.Windows.Forms;

namespace CtripHotelPrice
{
    partial class frmRoom
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
            this.btnQuery = new DNTBaseArch.Windows.Forms.ButtonEx();
            this.comboxPlat = new System.Windows.Forms.ComboBox();
            this.cLabel4 = new bxyztSkin.CControls.CLabel();
            this.cLabel3 = new bxyztSkin.CControls.CLabel();
            this.txtAreae = new bxyztSkin.CControls.CLabel();
            this.txtHotelName = new bxyztSkin.CControls.CTextBox();
            this.txtroom = new bxyztSkin.CControls.CTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cDataGridView1 = new bxyztSkin.Editors.CDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelPlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winFormPager1 = new bxyztSkin.Editors.WinFormPager();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).BeginInit();
            this.winFormPager1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.comboxPlat);
            this.panel2.Controls.Add(this.cLabel4);
            this.panel2.Controls.Add(this.cLabel3);
            this.panel2.Controls.Add(this.txtAreae);
            this.panel2.Controls.Add(this.txtHotelName);
            this.panel2.Controls.Add(this.txtroom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 77);
            this.panel2.TabIndex = 7;
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
            this.btnQuery.Location = new System.Drawing.Point(637, 32);
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
            // comboxPlat
            // 
            this.comboxPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPlat.FormattingEnabled = true;
            this.comboxPlat.Items.AddRange(new object[] {
            "所有",
            "携程"});
            this.comboxPlat.Location = new System.Drawing.Point(499, 35);
            this.comboxPlat.Name = "comboxPlat";
            this.comboxPlat.Size = new System.Drawing.Size(121, 20);
            this.comboxPlat.TabIndex = 3;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Location = new System.Drawing.Point(451, 37);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(29, 12);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "平台";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Location = new System.Drawing.Point(233, 35);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(53, 12);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "酒店名称";
            // 
            // txtAreae
            // 
            this.txtAreae.AutoSize = true;
            this.txtAreae.BackColor = System.Drawing.Color.Transparent;
            this.txtAreae.Location = new System.Drawing.Point(3, 37);
            this.txtAreae.Name = "txtAreae";
            this.txtAreae.Size = new System.Drawing.Size(53, 12);
            this.txtAreae.TabIndex = 2;
            this.txtAreae.Text = "房型名称";
            // 
            // txtHotelName
            // 
            this.txtHotelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotelName.Location = new System.Drawing.Point(306, 33);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 21);
            this.txtHotelName.TabIndex = 1;
            // 
            // txtroom
            // 
            this.txtroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtroom.Location = new System.Drawing.Point(93, 33);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(100, 21);
            this.txtroom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cDataGridView1);
            this.panel1.Controls.Add(this.winFormPager1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 473);
            this.panel1.TabIndex = 8;
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
            this.ID,
            this.BaseRoomID,
            this.PlatID,
            this.HotelID,
            this.RoomName,
            this.CreateDate,
            this.HotelPlatID,
            this.RoomID,
            this.PlatName,
            this.HotelName});
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
            this.cDataGridView1.Size = new System.Drawing.Size(1115, 443);
            this.cDataGridView1.TabIndex = 3;
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
            // PlatID
            // 
            this.PlatID.DataPropertyName = "PlatID";
            this.PlatID.HeaderText = "PlatID";
            this.PlatID.MinimumWidth = 30;
            this.PlatID.Name = "PlatID";
            this.PlatID.ReadOnly = true;
            this.PlatID.ToolTipText = "PlatID";
            this.PlatID.Width = 80;
            this.PlatID.Visible = false;
            // 
            // HotelID
            // 
            this.HotelID.DataPropertyName = "HotelID";
            this.HotelID.HeaderText = "酒店ID";
            this.HotelID.MinimumWidth = 30;
            this.HotelID.Name = "HotelID";
            this.HotelID.ReadOnly = true;
            this.HotelID.ToolTipText = "HotelID";
            this.HotelID.Width = 80;
            this.HotelID.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "房型名称";
            this.RoomName.MinimumWidth = 30;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.ToolTipText = "RoomName";
            this.RoomName.Width = 80;
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
            // HotelPlatID
            // 
            this.HotelPlatID.DataPropertyName = "HotelPlatID";
            this.HotelPlatID.HeaderText = "酒店平台ID";
            this.HotelPlatID.MinimumWidth = 30;
            this.HotelPlatID.Name = "HotelPlatID";
            this.HotelPlatID.ReadOnly = true;
            this.HotelPlatID.ToolTipText = "酒店平台ID";
            this.HotelPlatID.Width = 80;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "价格ID";
            this.RoomID.MinimumWidth = 30;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.ToolTipText = "价格ID";
            this.RoomID.Width = 80;
            // 
            // PlatName
            // 
            this.PlatName.DataPropertyName = "PlatName";
            this.PlatName.HeaderText = "PlatName";
            this.PlatName.MinimumWidth = 30;
            this.PlatName.Name = "PlatName";
            this.PlatName.ReadOnly = true;
            this.PlatName.ToolTipText = "PlatName";
            this.PlatName.Width = 80;
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
            // winFormPager1
            // 
            this.winFormPager1.BackColor = System.Drawing.Color.Transparent;
            this.winFormPager1.Controls.Add(this.bindingNavigator);
            this.winFormPager1.Controls.Add(this.bindingNavigator1);
            this.winFormPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winFormPager1.Location = new System.Drawing.Point(0, 443);
            this.winFormPager1.Name = "winFormPager1";
            this.winFormPager1.NMax = 0;
            this.winFormPager1.PageCount = 0;
            this.winFormPager1.PageCurrent = 0;
            this.winFormPager1.PageSize = 20;
            this.winFormPager1.Size = new System.Drawing.Size(1115, 30);
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
            this.bindingNavigator.Size = new System.Drawing.Size(1115, 30);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(1115, 30);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmRoom";
            this.Text = "酒店房型信息";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).EndInit();
            this.winFormPager1.ResumeLayout(false);
            this.winFormPager1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboxPlat;
        private bxyztSkin.CControls.CLabel cLabel4;
        private bxyztSkin.CControls.CLabel cLabel3;
        private bxyztSkin.CControls.CLabel txtAreae;
        private bxyztSkin.CControls.CTextBox txtHotelName;
        private bxyztSkin.CControls.CTextBox txtroom;
        private System.Windows.Forms.Panel panel1;
        private bxyztSkin.Editors.CDataGridView cDataGridView1;
        private bxyztSkin.Editors.WinFormPager winFormPager1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private DNTBaseArch.Windows.Forms.ButtonEx btnQuery;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BaseRoomID;
        private DataGridViewTextBoxColumn PlatID;
        private DataGridViewTextBoxColumn HotelID;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn HotelPlatID;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn PlatName;
        private DataGridViewTextBoxColumn HotelName;
    }
}