using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CommonHelper
{
    public class InitCommonContent
    {
        public static DataTable InitStatus()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("0", "所有");
            dt.Rows.Add("1", "需要跟的");
            dt.Rows.Add("2", "过期");
            dt.Rows.Add("3", "已删除");
            dt.Rows.Add("4", "暂时不跟");
            return dt;
        }

        public static DataTable PolicyTypeAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("2", "所有");
            dt.Rows.Add("0", "正常政策");
            dt.Rows.Add("1", "特殊政策");
            return dt;
        }


        public static DataTable PolicyType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("0", "正常政策");
            dt.Rows.Add("1", "特殊政策");
            return dt;
        }

        public static DataTable InitGridStatus()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("1", "需要跟的");
            dt.Rows.Add("2", "过期");
            dt.Rows.Add("3", "已删除");
            dt.Rows.Add("4", "暂时不跟");
            return dt;
        }

        public static DataTable InitUpdateStatus()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("1", "需要跟的");
            dt.Rows.Add("4", "暂时不跟");
            return dt;
        }


        public static DataTable InitModifyType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("0", "所有");
            dt.Rows.Add("1", "持平");
            dt.Rows.Add("2", "超点");
            dt.Rows.Add("3", "改为限制值");
            dt.Rows.Add("4", "不跟降");
            return dt;
        }

        #region 初始化表格
        public static DataGridViewColumn[] CreateDataTableColumns()
        {
            DataGridViewColumn ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 30;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.ToolTipText = "ID";
            ID.Visible = false;
            ID.Width = 80;
            ID.MinimumWidth = 90;




            DataGridViewColumn AirLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AirLine.DataPropertyName = "AirLine";
            AirLine.HeaderText = "航司";
            AirLine.MinimumWidth = 30;
            AirLine.Name = "AirLine";
            AirLine.ReadOnly = true;
            AirLine.ToolTipText = "航司";
            AirLine.Visible = true;
            AirLine.Width = 80;
            AirLine.FillWeight = 0.09F;


            DataGridViewColumn DownAirCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DownAirCode.DataPropertyName = "DownAirCode";
            DownAirCode.HeaderText = " 出发";
            DownAirCode.MinimumWidth = 30;
            DownAirCode.Name = "DownAirCode";
            DownAirCode.ReadOnly = true;
            DownAirCode.ToolTipText = "出发";
            DownAirCode.Visible = true;
            DownAirCode.Width = 80;
            DownAirCode.FillWeight = 0.09F;


            DataGridViewColumn UpAirCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UpAirCode.DataPropertyName = "UpAirCode";
            UpAirCode.HeaderText = " 抵达";
            UpAirCode.MinimumWidth = 30;
            UpAirCode.Name = "UpAirCode";
            UpAirCode.ReadOnly = true;
            UpAirCode.ToolTipText = "抵达";
            UpAirCode.Visible = true;
            UpAirCode.Width = 90;
            UpAirCode.FillWeight = 0.1F;


            DataGridViewColumn Cabins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cabins.DataPropertyName = "Cabins";
            Cabins.HeaderText = " 舱位";
            Cabins.MinimumWidth = 30;
            Cabins.Name = "Cabins";
            Cabins.ReadOnly = true;
            Cabins.ToolTipText = "舱位";
            Cabins.Visible = true;
            Cabins.Width = 80;
            Cabins.FillWeight = 0.12F;

            DataGridViewColumn FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FlightNo.DataPropertyName = "FlightNo";
            FlightNo.HeaderText = "航班号";
            FlightNo.MinimumWidth = 30;
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            FlightNo.ToolTipText = "航班号";
            FlightNo.Visible = true;
            FlightNo.Width = 90;
            FlightNo.FillWeight = 0.12F;

            DataGridViewColumn NoFlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NoFlightNo.DataPropertyName = "NoFlightNo";
            NoFlightNo.HeaderText = "不适用航班";
            NoFlightNo.MinimumWidth = 30;
            NoFlightNo.Name = "NoFlightNo";
            NoFlightNo.ReadOnly = true;
            NoFlightNo.ToolTipText = "不适用航班";
            NoFlightNo.Visible = false;
            NoFlightNo.Width = 80;
            NoFlightNo.FillWeight = 0.12F;

            DataGridViewColumn BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BeginDate.DataPropertyName = "BeginDate";
            BeginDate.HeaderText = "开始时间";
            BeginDate.MinimumWidth = 30;
            BeginDate.Name = "BeginDate";
            BeginDate.ReadOnly = true;
            BeginDate.ToolTipText = "开始时间";
            BeginDate.Visible = true;
            BeginDate.Width = 100;
            BeginDate.FillWeight = 0.12F;


            DataGridViewColumn EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "结束时间";
            EndDate.MinimumWidth = 30;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.ToolTipText = "结束时间";
            EndDate.Visible = true;
            EndDate.Width = 100;
            EndDate.FillWeight = 0.12F;


            DataGridViewColumn B2BValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            B2BValue.DataPropertyName = "B2BValue";
            B2BValue.HeaderText = "政策点";
            B2BValue.MinimumWidth = 30;
            B2BValue.Name = "B2BValue";
            B2BValue.ReadOnly = true;
            B2BValue.ToolTipText = "政策点";
            B2BValue.Visible = true;
            B2BValue.Width = 80;
            B2BValue.FillWeight = 0.1F;


            DataGridViewColumn Rebate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Rebate.DataPropertyName = "Rebate";
            Rebate.HeaderText = "返点";
            Rebate.MinimumWidth = 30;
            Rebate.Name = "Rebate";
            Rebate.ReadOnly = true;
            Rebate.ToolTipText = "返点";
            Rebate.Visible = true;
            Rebate.Width = 80;
            Rebate.FillWeight = 0.09F;


            DataGridViewColumn Outnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Outnumber.DataPropertyName = "Outnumber";
            Outnumber.HeaderText = "超点";
            Outnumber.MinimumWidth = 30;
            Outnumber.Name = "Outnumber";
            Outnumber.ReadOnly = true;
            Outnumber.ToolTipText = "超点";
            Outnumber.Visible = true;
            Outnumber.Width = 80;
            Outnumber.FillWeight = 0.09F;


            DataGridViewColumn MaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MaxValue.DataPropertyName = "MaxValue";
            MaxValue.HeaderText = "最大值";
            MaxValue.MinimumWidth = 30;
            MaxValue.Name = "MaxValue";
            MaxValue.ReadOnly = true;
            MaxValue.ToolTipText = "最大值";
            MaxValue.Visible = true;
            MaxValue.Width = 80;
            MaxValue.FillWeight = 0.14F;


            DataGridViewColumn ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ImportDate.DataPropertyName = "ImportDate";
            ImportDate.HeaderText = " 导入日期 ";
            ImportDate.MinimumWidth = 30;
            ImportDate.Name = "ImportDate";
            ImportDate.ReadOnly = true;
            ImportDate.ToolTipText = "导入日期";
            ImportDate.Visible = true;
            ImportDate.Width = 80;
            ImportDate.FillWeight = 0.14F;


            DataGridViewColumn ImportUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ImportUserID.DataPropertyName = "ImportUserID";
            ImportUserID.HeaderText = "ImportUserID";
            ImportUserID.MinimumWidth = 30;
            ImportUserID.Name = "ImportUserID";
            ImportUserID.ReadOnly = true;
            ImportUserID.ToolTipText = "ImportUserID";
            ImportUserID.Visible = false;
            ImportUserID.Width = 80;




            //DataGridViewComboBoxColumn PolicyType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            //PolicyType.DataPropertyName = "PolicyType";
            //PolicyType.HeaderText = " 政策类型  ";
            //PolicyType.MinimumWidth = 30;
            //PolicyType.Name = "PolicyType";
            //PolicyType.ReadOnly = true;
            //PolicyType.ToolTipText = "PolicyType";
            //PolicyType.Visible = false;
            //PolicyType.Width = 80;
            //PolicyType.DataSource = InitCommonContent.PolicyType();
            //PolicyType.DisplayMember = "Name";
            //PolicyType.ValueMember = "ID";
            //PolicyType.ReadOnly = false;
            //PolicyType.ValueType = typeof(Int32);

            DataGridViewColumn UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UpdateDate.DataPropertyName = "UpdateDate";
            UpdateDate.HeaderText = "UpdateDate";
            UpdateDate.MinimumWidth = 30;
            UpdateDate.Name = "UpdateDate";
            UpdateDate.ReadOnly = true;
            UpdateDate.ToolTipText = "更新日期";
            UpdateDate.Visible = false;
            UpdateDate.Width = 80;

            DataGridViewButtonColumn btnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            btnModify.HeaderText = "修改";
            btnModify.Name = "btnUsed";
            btnModify.Text = "修改";
            btnModify.Width = 50;
            btnModify.FillWeight = 0.12F;
            btnModify.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            btnDelete.HeaderText = "删除";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "删除";
            btnDelete.Width = 50;
            btnDelete.FillWeight = 0.12F;
            btnDelete.UseColumnTextForButtonValue = true;

            DataGridViewCheckBoxColumn SetCol = new DataGridViewCheckBoxColumn(false);
            SetCol.HeaderText = "选中";
            SetCol.Name = "SetCol";
            SetCol.Width = 50;
            SetCol.FillWeight = 0.12F;
            SetCol.Visible = true;


            DataGridViewColumn MinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MinValue.DataPropertyName = "MinValue";
            MinValue.HeaderText = "最低值";
            MinValue.MinimumWidth = 30;
            MinValue.Name = "MinValue";
            MinValue.ReadOnly = true;
            MinValue.ToolTipText = "最低值";
            MinValue.Visible = true;
            MinValue.Width = 80;
            MinValue.FillWeight = 0.14F;

            DataGridViewColumn NightPolicyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NightPolicyValue.DataPropertyName = "NightPolicyValue";
            NightPolicyValue.HeaderText = "晚间值";
            NightPolicyValue.MinimumWidth = 30;
            NightPolicyValue.Name = "NightPolicyValue";
            NightPolicyValue.ReadOnly = true;
            NightPolicyValue.ToolTipText = "晚间值";
            NightPolicyValue.Visible = true;
            NightPolicyValue.Width = 80;
            NightPolicyValue.FillWeight = 0.14F;

            DataGridViewColumn WebList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WebList.DataPropertyName = "WebList";
            WebList.HeaderText = "网站";
            WebList.MinimumWidth = 30;
            WebList.Name = "WebList";
            WebList.ReadOnly = true;
            WebList.ToolTipText = "WebList";
            WebList.Visible = false;
            WebList.Width = 80;
            WebList.FillWeight = 0.14F;

            DataGridViewColumn IsOutnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsOutnumber.DataPropertyName = "IsOutnumber";
            IsOutnumber.HeaderText = "是否需要超点";
            IsOutnumber.MinimumWidth = 30;
            IsOutnumber.Name = "IsOutnumber";
            IsOutnumber.ReadOnly = true;
            IsOutnumber.ToolTipText = "IsOutnumber";
            IsOutnumber.Visible = false;
            IsOutnumber.Width = 80;
            IsOutnumber.FillWeight = 0.14F;

            DataGridViewColumn CabinType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CabinType.DataPropertyName = "CabinType";
            CabinType.HeaderText = "舱位";
            CabinType.MinimumWidth = 30;
            CabinType.Name = "CabinType";
            CabinType.ReadOnly = true;
            CabinType.ToolTipText = "CabinType";
            CabinType.Visible = false;
            CabinType.Width = 80;
            CabinType.FillWeight = 0.14F;
            CabinType.ValueType = (typeof(bool));

            DataGridViewColumn CabinTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CabinTypeName.DataPropertyName = "CabinTypeName";
            CabinTypeName.HeaderText = "舱位";
            CabinTypeName.MinimumWidth = 30;
            CabinTypeName.Name = "CabinType";
            CabinTypeName.ReadOnly = true;
            CabinTypeName.ToolTipText = "舱位是否完全一样";
            CabinTypeName.Visible = false;
            CabinTypeName.Width = 80;
            CabinTypeName.FillWeight = 0.1F;
            CabinTypeName.ValueType = (typeof(string));

            DataGridViewColumn DataTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataTypeName.DataPropertyName = "DataTypeName";
            DataTypeName.HeaderText = "日期";
            DataTypeName.MinimumWidth = 30;
            DataTypeName.Name = "CabinType";
            DataTypeName.ReadOnly = true;
            DataTypeName.ToolTipText = "日期是否要完全一样";
            DataTypeName.Visible = false;
            DataTypeName.Width = 80;
            DataTypeName.FillWeight = 0.1F;
            DataTypeName.ValueType = (typeof(string));

            DataGridViewColumn DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataType.DataPropertyName = "DataType";
            DataType.HeaderText = "日期";
            DataType.MinimumWidth = 30;
            DataType.Name = "DataType";
            DataType.ReadOnly = true;
            DataType.ToolTipText = "DataType";
            DataType.Visible = false;
            DataType.Width = 80;
            DataType.FillWeight = 0.14F;

            DataGridViewColumn Webs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Webs.DataPropertyName = "Webs";
            Webs.HeaderText = "适用平台";
            Webs.MinimumWidth = 30;
            Webs.Name = "Webs";
            Webs.ReadOnly = true;
            Webs.ToolTipText = "适用平台";
            Webs.Visible = true;
            Webs.Width = 80;
            Webs.FillWeight = 0.14F;

            DataGridViewTextBoxColumn ModifyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ModifyType.DataPropertyName = "ModifyType";
            ModifyType.HeaderText = " 更改方式  ";
            ModifyType.MinimumWidth = 30;
            ModifyType.Name = "ModifyType";
            ModifyType.ReadOnly = true;
            ModifyType.ToolTipText = "更改方式";
            ModifyType.Visible = false;
            ModifyType.Width = 80;
            //MID.DataSource = InitCommonContent.InitModifyType();
            //MID.DisplayMember = "Name";
            //MID.ValueMember = "ID";
            ModifyType.ReadOnly = true;
            ModifyType.ValueType = typeof(Int32);

            DataGridViewTextBoxColumn MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MName.DataPropertyName = "MName";
            MName.HeaderText = " 更改方式  ";
            MName.MinimumWidth = 30;
            MName.Name = "MName";
            MName.ReadOnly = true;
            MName.ToolTipText = "更改方式";
            MName.Visible = true;
            MName.Width = 80;
            //MName.DataSource = InitCommonContent.InitModifyType();
            //MName.DisplayMember = "Name";
            //MName.ValueMember = "ID";
            MName.ReadOnly = true;
            MName.ValueType = typeof(string);

            DataGridViewTextBoxColumn StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StatusID.DataPropertyName = "StatusID";
            StatusID.HeaderText = " 使用状态  ";
            StatusID.MinimumWidth = 30;
            StatusID.Name = "StatusID";
            StatusID.ReadOnly = true;
            StatusID.ToolTipText = "使用状态";
            StatusID.Visible = false;
            StatusID.Width = 80;
            //StatusID.DataSource = InitCommonContent.InitGridStatus();
            //StatusID.DisplayMember = "Name";
            //StatusID.ValueMember = "ID";
            StatusID.ReadOnly = true;
            StatusID.ValueType = typeof(Int32);

            DataGridViewTextBoxColumn SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SName.DataPropertyName = "SName";
            SName.HeaderText = " 使用状态  ";
            SName.MinimumWidth = 30;
            SName.Name = "SName";
            SName.ReadOnly = true;
            SName.ToolTipText = "使用状态";
            SName.Visible = true;
            SName.Width = 80;
            //StatusID.DataSource = InitCommonContent.InitGridStatus();
            //StatusID.DisplayMember = "Name";
            //StatusID.ValueMember = "ID";
            SName.ReadOnly = true;
            SName.ValueType = typeof(string);


            DataGridViewTextBoxColumn IsNeedCompare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsNeedCompare.DataPropertyName = "IsNeedCompare";
            IsNeedCompare.HeaderText = "是否需要比较";
            IsNeedCompare.MinimumWidth = 30;
            IsNeedCompare.Name = "IsNeedCompare";
            IsNeedCompare.ReadOnly = true;
            IsNeedCompare.ToolTipText = "是否需要比较";
            IsNeedCompare.Visible = false;
            IsNeedCompare.Width = 80;
            //StatusID.DataSource = InitCommonContent.InitGridStatus();
            //StatusID.DisplayMember = "Name";
            //StatusID.ValueMember = "ID";
            IsNeedCompare.ReadOnly = true;
            IsNeedCompare.ValueType = typeof(string);


            DataGridViewTextBoxColumn IsCompare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsCompare.DataPropertyName = "IsCompare";
            IsCompare.HeaderText = "比较";
            IsCompare.MinimumWidth = 30;
            IsCompare.Name = "IsCompare";
            IsCompare.ReadOnly = true;
            IsCompare.ToolTipText = "是否需要比较";
            IsCompare.Visible = true;
            IsCompare.Width = 80; 
            IsCompare.ReadOnly = true;
            IsCompare.ValueType = typeof(string);

            DataGridViewTextBoxColumn TripTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TripTypeID.DataPropertyName = "TripTypeID";
            TripTypeID.HeaderText = "行程类型";
            TripTypeID.MinimumWidth = 30;
            TripTypeID.Name = "TripTypeID";
            TripTypeID.ReadOnly = true;
            TripTypeID.ToolTipText = "行程类型";
            TripTypeID.Visible = true;
            TripTypeID.Width = 80;
            TripTypeID.ReadOnly = true;
            TripTypeID.ValueType = typeof(string);

            DataGridViewTextBoxColumn PolicyTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PolicyTypeID.DataPropertyName = "PolicyTypeID";
            PolicyTypeID.HeaderText = "政策类型";
            PolicyTypeID.MinimumWidth = 30;
            PolicyTypeID.Name = "PolicyTypeID";
            PolicyTypeID.ReadOnly = true;
            PolicyTypeID.ToolTipText = "政策类型";
            PolicyTypeID.Visible = true;
            PolicyTypeID.Width = 80;
            PolicyTypeID.ReadOnly = true;
            PolicyTypeID.ValueType = typeof(string);


            DataGridViewTextBoxColumn PassengersTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PassengersTypeID.DataPropertyName = "PassengersTypeID";
            PassengersTypeID.HeaderText = "乘客类型";
            PassengersTypeID.MinimumWidth = 30;
            PassengersTypeID.Name = "PassengersTypeID";
            PassengersTypeID.ReadOnly = true;
            PassengersTypeID.ToolTipText = "乘客类型";
            PassengersTypeID.Visible = true;
            PassengersTypeID.Width = 80;
            PassengersTypeID.ReadOnly = true;
            PassengersTypeID.ValueType = typeof(string);
            return new System.Windows.Forms.DataGridViewColumn[] { SetCol,ID, AirLine, DownAirCode, UpAirCode, Cabins
                , FlightNo,NoFlightNo, BeginDate, EndDate, B2BValue, Rebate,Outnumber, MaxValue,MinValue,NightPolicyValue,ImportDate
                , ImportUserID, StatusID,SName,ModifyType,MName,Webs, UpdateDate,CabinTypeName,DataTypeName, btnModify
                , btnDelete,WebList,IsOutnumber
                ,CabinType,DataType,IsNeedCompare ,IsCompare,TripTypeID,PolicyTypeID,PassengersTypeID };
        }
        #endregion

        /// <summary>
        /// 判断并设置最大值
        /// </summary>
        /// <param name="m1">当前最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param>
        /// <param name="info">信息</param>
        /// <returns>要修改的值</returns>
        public static decimal SetPolicy(decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            decimal t = 0.0m;

            if (m2 == 0)
            {
                if (s == m1 + o)
                {
                    info = "已经是最大值";
                }
                else
                { t = (m1 + o) >= l ? l : m1 + o; }
                if (t == s)
                {
                    info = "已经是最大值";
                }

            }
            else
            {//有最低点
                if (s <= m1 + o)
                {
                    t = m1 + o;
                    t = t >= l ? l : t;
                }
                else
                {
                    if (s == m2)
                    {
                        info = "已经达到最小值";
                    }
                    t = m2;
                }
                if (t == s)
                    info = "已经达到最小值";
            }
            return t;

        }


        /// <summary>
        /// 判断并设置最大值
        /// </summary>
        /// <param name="c0">当前非自家最大值</param>
        /// <param name="m1">当前小于自家限制值的最大值</param> 
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param>
        /// <param name="modifytype">修改类型的ID</param>
        /// <param name="info">信息</param>
        /// <returns>要修改的值</returns>
        public static decimal SetPolicy(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, int modifytype, out string info)
        {
            decimal t = 0m;
            info = "";
            ModifyType type = ModifyType.None;
            if (Enum.IsDefined(typeof(ModifyType), modifytype))
            {
                type = ((ModifyType)(modifytype));
            }

            switch (type)
            {
                case ModifyType.Impartial:
                    t = SetImpartial(c0, m1, s, l, m2, o, out info);
                    break;
                case ModifyType.OutNumber:
                    t = SetOutNumber(c0, m1, s, l, m2, o, out info);
                    break;
                case ModifyType.MaxValue:
                    t = SetMaxValue(c0, m1, s, l, m2, o, out info);
                    break;
                case ModifyType.NoDown:
                    t = SetNoDown(c0, m1, s, l, m2, o, out info);
                    break;
                default:
                    info = "不合理的更改方式";
                    t = 0m;
                    break;
            }
            //t = SetPolicy(c0, m1, s, l, m2, o, type, out info);
            if (t == 0 && string.IsNullOrEmpty(info))
                info = "不需要跟";
            return t;
        }

        /// <summary>
        /// 持平
        /// </summary>
        /// <param name="c0">当前非自家最大值(暂时没用)</param>
        /// <param name="m1">当前小于自家限制值的最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param>
        /// <param name="info"></param>
        /// <returns></returns>
        private static decimal SetImpartial(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            if (m1 == s || m1 == 0)
            {
                info = "已经是最大值";
            }
            return m1;
        }



        /// <summary>
        /// 跟小于自家限制值的第一条政策比较,找到后比他多超点,超点为0时就持平
        /// 即在自家范围内超点
        /// </summary>
        /// <param name="c0">当前非自家最大值(暂时没用)</param>
        /// <param name="m1">当前小于自家限制值的最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param>
        /// <param name="info">信息</param>
        /// <returns></returns>
        private static decimal SetOutNumber(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            decimal t = 0m;
            if (o == 0)
            {
                if (m1 == s || m1 == 0)
                {
                    info = "已经是最大值";
                }
                else
                { t = (m1 + o) >= l ? l : m1 + o; }
            }
            else if (m1 + o == s || m1 == 0)
            {
                info = "已经是最大值";
            }
            else
            {
                t = (m1 + o) >= l ? l : m1 + o;
            }

            if (t == s)
            {
                info = "已经是最大值";
            }
            return t;
        }



        /// <summary>
        /// 如果别家政策有高于自家限制值的,就将政策值改为限制值;如果没有高于自家限制值的,就按超点设置
        /// </summary>
        /// <param name="c0">当前非自家最大值</param>
        /// <param name="m1">当前小于自家限制值的最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param> 
        /// <param name="info"></param>
        /// <returns></returns>
        private static decimal SetMaxValue(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            decimal t = 0m;
            if (c0 > l)
            {
                t = l;
            }
            else
            {
                t = SetOutNumber(c0, m1, s, l, m2, o, out info);
            }
            if (t == s)
            {
                info = "已经达到最大值";
            }
            return t;
        }

        /// <summary>
        /// 如果别家值很低,自家政策有优势的,不比较,直接设置为最低点;如果别家值比较高,按超点设置
        /// (适用于设置了最低点的政策,没有最低点或者最低点为0时,就按超点设置)
        /// </summary>
        /// <param name="c0">当前非自家最大值</param>
        /// <param name="m1">当前小于自家限制值的最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param> 
        /// <param name="info"></param>
        /// <returns></returns>
        private static decimal SetMinValue(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            decimal t = 0m;
            if (c0 >= l || m2 != 0)
            {
                t = SetOutNumber(c0, m1, s, l, m2, o, out info);
            }
            else
            {
                t = m2;
            }
            if (t == s)
                info = "已经是最大值";

            return t;
        }

        /// <summary>
        ///  如果别家值很低,不跟降,如果别家值高的,按超点设置
        /// </summary>
        /// <param name="c0">当前非自家最大值</param>
        /// <param name="m1">当前小于自家限制值的最大值</param>
        /// <param name="s">当前自家值</param>
        /// <param name="l">限制值</param>
        /// <param name="m2">最低点</param>
        /// <param name="o">超点</param> 
        /// <param name="info"></param>
        /// <returns></returns>
        private static decimal SetNoDown(decimal c0, decimal m1, decimal s, decimal l, decimal m2, decimal o, out string info)
        {
            info = "";
            decimal t = 0m;

            /*
             * 
             */

            if (s >= c0)
            {
                info = "已经是最大值,不需要降点";
            }
            else
            {
                t = SetOutNumber(c0, m1, s, l, m2, o, out info);
            }

            if (t == s)
                info = "已经是最大值";

            return t;
        }

        /// <summary>
        /// 判断舱位是否一样
        /// </summary>
        /// <param name="a">从页面查出的舱位</param>
        /// <param name="b">导入的舱位</param>
        /// <returns></returns>
        public static bool IsSameCabins(string a, string b)
        {
            bool r = false;
            try
            {
                char[] ca = a.Replace(",", "").Replace("/", "").ToCharArray();
                char[] cb = b.Replace("/", "").ToCharArray();

                if (cb.Length == 1)
                {
                    char c = ca.FirstOrDefault(i => i == cb[0]);
                    if (c == '\0')
                    { r = false; }
                    else
                    { r = true; }
                }
                else
                {
                    if (ca.Length == cb.Length)
                    {
                        foreach (char i in ca)
                        {
                            if (!b.Contains(i))
                            { r = false; break; }
                            r = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                r = false;
                throw;
            }
            return r;
        }


        /// <summary>
        /// 比较日期
        /// </summary>
        /// <param name="sdate">平台政策开始日期</param>
        /// <param name="edate">平台政策结束日期</param>
        /// <param name="Sdate">导入政策开始日期</param>
        /// <param name="Edate">导入政策结束日期</param>
        /// <returns></returns>
        public static bool IsSuitDate(DateTime sdate, DateTime edate, DateTime Sdate, DateTime Edate)
        {
            bool r = false;
            if (sdate <= DateTime.Now)
            {
                if (edate == Edate)
                {
                    r = true;
                }
            }
            else
            {
                if (sdate == Sdate && edate == Edate)
                { r = true; }
            }
            return r;
        }

        /// <summary>
        /// 对比航班号,其中一个为空时返回true;都不为空时,前者若包含后者,则返回true,否则,返回false
        /// </summary>
        /// <param name="webflightno"></param>
        /// <param name="flightno"></param>
        /// <returns></returns>
        public static bool IsSuitFlightNo(string webflightno, string flightno)
        {
            string fno = "";
            if(flightno.Length>4)
            {
                fno = flightno.Substring(2, 4);
            }
            else 
            {
                fno = flightno;
            }
            if (string.IsNullOrEmpty(flightno) || string.IsNullOrEmpty(webflightno))
            {
                return true;
            }
            else
            {
                try              
	            {	        
		            webflightno.Contains(fno);
	            }
	            catch (Exception)
                {
                    return false;
	            }
                return false;
            }
        }

        /// <summary>
        /// MD5 32位加密 UTF8 转码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UserMd5(string str)
        {
            byte[] result = Encoding.Default.GetBytes(str);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string re = BitConverter.ToString(output).Replace("-", "");  //tbMd5pass为输出加密文本
            return re;
        }
    }
}
