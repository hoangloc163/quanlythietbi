﻿namespace Asset_Management_Alpha
{
    partial class AM_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AM_Main_Form));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cb_Status_MrC = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.txt_Serial_MrC = new System.Windows.Forms.TextBox();
            this.bt_Refresh_MrC = new System.Windows.Forms.Button();
            this.rbt_Or_Check = new System.Windows.Forms.RadioButton();
            this.rbt_And_Check = new System.Windows.Forms.RadioButton();
            this.MrC_BT_Search = new System.Windows.Forms.Button();
            this.label95 = new System.Windows.Forms.Label();
            this.cb_Position_MrC = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_Brand_MrC = new System.Windows.Forms.ComboBox();
            this.cb_Supplier_MrC = new System.Windows.Forms.ComboBox();
            this.cb_Devices_MrC = new System.Windows.Forms.ComboBox();
            this.cb_Area_MrC = new System.Windows.Forms.ComboBox();
            this.txt_UserName_MrC = new System.Windows.Forms.TextBox();
            this.bt_Insert_MrC = new System.Windows.Forms.Button();
            this.MrC_BT_Cancel = new System.Windows.Forms.Button();
            this.label97 = new System.Windows.Forms.Label();
            this.col_darea_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_devices_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Supplies_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_model_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serial_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hostname_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invoice_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_handover_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Warranty_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dstatus_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remark_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_location_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_assetcode_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_position_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_memory_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hdd_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_macaddr_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipaddr_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dns_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_defaultgw_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_logname_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_darea_MrC,
            this.col_devices_MrC,
            this.col_brand_MrC,
            this.col_Supplies_MrC,
            this.col_model_MrC,
            this.col_serial_MrC,
            this.col_hostname_MrC,
            this.col_invoice_MrC,
            this.col_handover_MrC,
            this.col_Warranty_MrC,
            this.col_dstatus_MrC,
            this.col_remark_MrC,
            this.col_location_MrC,
            this.col_assetcode_MrC,
            this.col_username_MrC,
            this.col_position_MrC,
            this.col_memory_MrC,
            this.col_hdd_MrC,
            this.col_macaddr_MrC,
            this.col_ipaddr_MrC,
            this.col_dns_MrC,
            this.col_defaultgw_MrC,
            this.col_logname_MrC,
            this.col_password_MrC});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 85);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1205, 475);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserDeletedRow);
            // 
            // cb_Status_MrC
            // 
            this.cb_Status_MrC.FormattingEnabled = true;
            this.cb_Status_MrC.Location = new System.Drawing.Point(675, 47);
            this.cb_Status_MrC.Name = "cb_Status_MrC";
            this.cb_Status_MrC.Size = new System.Drawing.Size(141, 21);
            this.cb_Status_MrC.TabIndex = 71;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(632, 50);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(43, 13);
            this.label98.TabIndex = 70;
            this.label98.Text = "Status";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(632, 15);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(39, 13);
            this.label96.TabIndex = 69;
            this.label96.Text = "Serial";
            // 
            // txt_Serial_MrC
            // 
            this.txt_Serial_MrC.Location = new System.Drawing.Point(675, 11);
            this.txt_Serial_MrC.Name = "txt_Serial_MrC";
            this.txt_Serial_MrC.Size = new System.Drawing.Size(141, 20);
            this.txt_Serial_MrC.TabIndex = 68;
            // 
            // bt_Refresh_MrC
            // 
            this.bt_Refresh_MrC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh_MrC.Location = new System.Drawing.Point(835, 11);
            this.bt_Refresh_MrC.Name = "bt_Refresh_MrC";
            this.bt_Refresh_MrC.Size = new System.Drawing.Size(57, 57);
            this.bt_Refresh_MrC.TabIndex = 67;
            this.bt_Refresh_MrC.Text = "Refesh";
            this.bt_Refresh_MrC.UseVisualStyleBackColor = true;
            this.bt_Refresh_MrC.Click += new System.EventHandler(this.bt_Refresh_MrC_Click);
            // 
            // rbt_Or_Check
            // 
            this.rbt_Or_Check.AutoSize = true;
            this.rbt_Or_Check.Location = new System.Drawing.Point(909, 46);
            this.rbt_Or_Check.Name = "rbt_Or_Check";
            this.rbt_Or_Check.Size = new System.Drawing.Size(94, 17);
            this.rbt_Or_Check.TabIndex = 66;
            this.rbt_Or_Check.Text = "Relative Value";
            this.rbt_Or_Check.UseVisualStyleBackColor = true;
            // 
            // rbt_And_Check
            // 
            this.rbt_And_Check.AutoSize = true;
            this.rbt_And_Check.Checked = true;
            this.rbt_And_Check.Location = new System.Drawing.Point(909, 17);
            this.rbt_And_Check.Name = "rbt_And_Check";
            this.rbt_And_Check.Size = new System.Drawing.Size(96, 17);
            this.rbt_And_Check.TabIndex = 65;
            this.rbt_And_Check.TabStop = true;
            this.rbt_And_Check.Text = "Absolute Value";
            this.rbt_And_Check.UseVisualStyleBackColor = true;
            // 
            // MrC_BT_Search
            // 
            this.MrC_BT_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrC_BT_Search.Location = new System.Drawing.Point(1011, 12);
            this.MrC_BT_Search.Name = "MrC_BT_Search";
            this.MrC_BT_Search.Size = new System.Drawing.Size(75, 56);
            this.MrC_BT_Search.TabIndex = 64;
            this.MrC_BT_Search.Text = "Search";
            this.MrC_BT_Search.UseVisualStyleBackColor = true;
            this.MrC_BT_Search.Click += new System.EventHandler(this.MrC_BT_Search_Click);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(182, 51);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(40, 13);
            this.label95.TabIndex = 63;
            this.label95.Text = "Brand";
            // 
            // cb_Position_MrC
            // 
            this.cb_Position_MrC.FormattingEnabled = true;
            this.cb_Position_MrC.Location = new System.Drawing.Point(433, 47);
            this.cb_Position_MrC.Name = "cb_Position_MrC";
            this.cb_Position_MrC.Size = new System.Drawing.Size(170, 21);
            this.cb_Position_MrC.TabIndex = 62;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(358, 15);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(69, 13);
            this.label94.TabIndex = 61;
            this.label94.Text = "User Name";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(367, 50);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(52, 13);
            this.label93.TabIndex = 60;
            this.label93.Text = "Position";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(171, 15);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(53, 13);
            this.label92.TabIndex = 59;
            this.label92.Text = "Supplier";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(10, 51);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(53, 13);
            this.label91.TabIndex = 58;
            this.label91.Text = "Devices";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = " Area";
            // 
            // cb_Brand_MrC
            // 
            this.cb_Brand_MrC.FormattingEnabled = true;
            this.cb_Brand_MrC.Location = new System.Drawing.Point(237, 48);
            this.cb_Brand_MrC.Name = "cb_Brand_MrC";
            this.cb_Brand_MrC.Size = new System.Drawing.Size(103, 21);
            this.cb_Brand_MrC.TabIndex = 56;
            // 
            // cb_Supplier_MrC
            // 
            this.cb_Supplier_MrC.FormattingEnabled = true;
            this.cb_Supplier_MrC.Location = new System.Drawing.Point(237, 12);
            this.cb_Supplier_MrC.Name = "cb_Supplier_MrC";
            this.cb_Supplier_MrC.Size = new System.Drawing.Size(103, 21);
            this.cb_Supplier_MrC.TabIndex = 55;
            // 
            // cb_Devices_MrC
            // 
            this.cb_Devices_MrC.FormattingEnabled = true;
            this.cb_Devices_MrC.Location = new System.Drawing.Point(66, 48);
            this.cb_Devices_MrC.Name = "cb_Devices_MrC";
            this.cb_Devices_MrC.Size = new System.Drawing.Size(91, 21);
            this.cb_Devices_MrC.TabIndex = 54;
            // 
            // cb_Area_MrC
            // 
            this.cb_Area_MrC.FormattingEnabled = true;
            this.cb_Area_MrC.Location = new System.Drawing.Point(66, 12);
            this.cb_Area_MrC.Name = "cb_Area_MrC";
            this.cb_Area_MrC.Size = new System.Drawing.Size(62, 21);
            this.cb_Area_MrC.TabIndex = 53;
            // 
            // txt_UserName_MrC
            // 
            this.txt_UserName_MrC.Location = new System.Drawing.Point(433, 11);
            this.txt_UserName_MrC.Name = "txt_UserName_MrC";
            this.txt_UserName_MrC.Size = new System.Drawing.Size(170, 20);
            this.txt_UserName_MrC.TabIndex = 52;
            // 
            // bt_Insert_MrC
            // 
            this.bt_Insert_MrC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Insert_MrC.Location = new System.Drawing.Point(1116, 14);
            this.bt_Insert_MrC.Name = "bt_Insert_MrC";
            this.bt_Insert_MrC.Size = new System.Drawing.Size(101, 23);
            this.bt_Insert_MrC.TabIndex = 73;
            this.bt_Insert_MrC.Text = "ADD";
            this.bt_Insert_MrC.UseVisualStyleBackColor = true;
            this.bt_Insert_MrC.Click += new System.EventHandler(this.bt_Insert_MrC_Click);
            // 
            // MrC_BT_Cancel
            // 
            this.MrC_BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrC_BT_Cancel.Location = new System.Drawing.Point(1116, 43);
            this.MrC_BT_Cancel.Name = "MrC_BT_Cancel";
            this.MrC_BT_Cancel.Size = new System.Drawing.Size(101, 23);
            this.MrC_BT_Cancel.TabIndex = 72;
            this.MrC_BT_Cancel.Text = "Cancel";
            this.MrC_BT_Cancel.UseVisualStyleBackColor = true;
            this.MrC_BT_Cancel.Click += new System.EventHandler(this.MrC_BT_Cancel_Click);
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(1150, 565);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(43, 13);
            this.label97.TabIndex = 74;
            this.label97.Text = "0 Rows";
            // 
            // col_darea_MrC
            // 
            this.col_darea_MrC.DataPropertyName = "DAREA";
            this.col_darea_MrC.HeaderText = "AREA";
            this.col_darea_MrC.MaxInputLength = 3;
            this.col_darea_MrC.Name = "col_darea_MrC";
            this.col_darea_MrC.Width = 61;
            // 
            // col_devices_MrC
            // 
            this.col_devices_MrC.DataPropertyName = "DTYPE";
            this.col_devices_MrC.HeaderText = "DEVICES";
            this.col_devices_MrC.Name = "col_devices_MrC";
            this.col_devices_MrC.Width = 78;
            // 
            // col_brand_MrC
            // 
            this.col_brand_MrC.DataPropertyName = "BRAND";
            this.col_brand_MrC.HeaderText = "BRAND";
            this.col_brand_MrC.Name = "col_brand_MrC";
            this.col_brand_MrC.Width = 70;
            // 
            // col_Supplies_MrC
            // 
            this.col_Supplies_MrC.DataPropertyName = "SUPPLIES";
            this.col_Supplies_MrC.HeaderText = "SUPPLIER";
            this.col_Supplies_MrC.Name = "col_Supplies_MrC";
            this.col_Supplies_MrC.Width = 84;
            // 
            // col_model_MrC
            // 
            this.col_model_MrC.DataPropertyName = "MODEL";
            this.col_model_MrC.HeaderText = "MODEL";
            this.col_model_MrC.Name = "col_model_MrC";
            this.col_model_MrC.Width = 70;
            // 
            // col_serial_MrC
            // 
            this.col_serial_MrC.DataPropertyName = "SERIAL";
            this.col_serial_MrC.HeaderText = "SERIAL";
            this.col_serial_MrC.Name = "col_serial_MrC";
            this.col_serial_MrC.ReadOnly = true;
            this.col_serial_MrC.Width = 70;
            // 
            // col_hostname_MrC
            // 
            this.col_hostname_MrC.DataPropertyName = "HOSTNAME";
            this.col_hostname_MrC.HeaderText = "HOST NAME";
            this.col_hostname_MrC.Name = "col_hostname_MrC";
            this.col_hostname_MrC.Width = 96;
            // 
            // col_invoice_MrC
            // 
            this.col_invoice_MrC.DataPropertyName = "INVOICE_DATE";
            this.col_invoice_MrC.HeaderText = "INVOICE DATE";
            this.col_invoice_MrC.MaxInputLength = 10;
            this.col_invoice_MrC.Name = "col_invoice_MrC";
            this.col_invoice_MrC.Width = 98;
            // 
            // col_handover_MrC
            // 
            this.col_handover_MrC.DataPropertyName = "HANDOVER_DATE";
            this.col_handover_MrC.HeaderText = "HAND-OVER DATE";
            this.col_handover_MrC.MaxInputLength = 10;
            this.col_handover_MrC.Name = "col_handover_MrC";
            this.col_handover_MrC.Width = 117;
            // 
            // col_Warranty_MrC
            // 
            this.col_Warranty_MrC.DataPropertyName = "WARANTY";
            this.col_Warranty_MrC.HeaderText = "WARRANTY";
            this.col_Warranty_MrC.Name = "col_Warranty_MrC";
            this.col_Warranty_MrC.Width = 95;
            // 
            // col_dstatus_MrC
            // 
            this.col_dstatus_MrC.DataPropertyName = "DSTATUS";
            this.col_dstatus_MrC.HeaderText = "STATUS";
            this.col_dstatus_MrC.Name = "col_dstatus_MrC";
            // 
            // col_remark_MrC
            // 
            this.col_remark_MrC.DataPropertyName = "REMARK";
            this.col_remark_MrC.HeaderText = "REMARK";
            this.col_remark_MrC.Name = "col_remark_MrC";
            this.col_remark_MrC.Width = 78;
            // 
            // col_location_MrC
            // 
            this.col_location_MrC.DataPropertyName = "LOCATION";
            this.col_location_MrC.HeaderText = "LOCATION";
            this.col_location_MrC.Name = "col_location_MrC";
            this.col_location_MrC.Width = 86;
            // 
            // col_assetcode_MrC
            // 
            this.col_assetcode_MrC.DataPropertyName = "ASSETCODE";
            this.col_assetcode_MrC.HeaderText = "ASSET CODE";
            this.col_assetcode_MrC.Name = "col_assetcode_MrC";
            this.col_assetcode_MrC.Width = 92;
            // 
            // col_username_MrC
            // 
            this.col_username_MrC.DataPropertyName = "USRNAME";
            this.col_username_MrC.HeaderText = "USER NAME";
            this.col_username_MrC.Name = "col_username_MrC";
            this.col_username_MrC.Width = 93;
            // 
            // col_position_MrC
            // 
            this.col_position_MrC.DataPropertyName = "POSITION";
            this.col_position_MrC.HeaderText = "POSITION";
            this.col_position_MrC.Name = "col_position_MrC";
            this.col_position_MrC.Width = 83;
            // 
            // col_memory_MrC
            // 
            this.col_memory_MrC.DataPropertyName = "MEMORY";
            this.col_memory_MrC.HeaderText = "MEMORY";
            this.col_memory_MrC.Name = "col_memory_MrC";
            this.col_memory_MrC.Width = 80;
            // 
            // col_hdd_MrC
            // 
            this.col_hdd_MrC.DataPropertyName = "HDD";
            this.col_hdd_MrC.HeaderText = "HDD";
            this.col_hdd_MrC.Name = "col_hdd_MrC";
            this.col_hdd_MrC.Width = 56;
            // 
            // col_macaddr_MrC
            // 
            this.col_macaddr_MrC.DataPropertyName = "MAC_ADDR";
            this.col_macaddr_MrC.HeaderText = "MAC ADDRESS";
            this.col_macaddr_MrC.Name = "col_macaddr_MrC";
            // 
            // col_ipaddr_MrC
            // 
            this.col_ipaddr_MrC.DataPropertyName = "IP_ADDR";
            this.col_ipaddr_MrC.HeaderText = "IP ADDRESS";
            this.col_ipaddr_MrC.Name = "col_ipaddr_MrC";
            // 
            // col_dns_MrC
            // 
            this.col_dns_MrC.DataPropertyName = "DNS";
            this.col_dns_MrC.HeaderText = "DNS";
            this.col_dns_MrC.Name = "col_dns_MrC";
            // 
            // col_defaultgw_MrC
            // 
            this.col_defaultgw_MrC.DataPropertyName = "DEFAULT_GW";
            this.col_defaultgw_MrC.HeaderText = "DEFAULT GW";
            this.col_defaultgw_MrC.Name = "col_defaultgw_MrC";
            // 
            // col_logname_MrC
            // 
            this.col_logname_MrC.DataPropertyName = "LOG_NAME";
            this.col_logname_MrC.HeaderText = "LOGIN NAME";
            this.col_logname_MrC.Name = "col_logname_MrC";
            // 
            // col_password_MrC
            // 
            this.col_password_MrC.DataPropertyName = "PASSWRD";
            this.col_password_MrC.HeaderText = "PASSWORD";
            this.col_password_MrC.Name = "col_password_MrC";
            // 
            // AM_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 587);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.bt_Insert_MrC);
            this.Controls.Add(this.MrC_BT_Cancel);
            this.Controls.Add(this.cb_Status_MrC);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.txt_Serial_MrC);
            this.Controls.Add(this.bt_Refresh_MrC);
            this.Controls.Add(this.rbt_Or_Check);
            this.Controls.Add(this.rbt_And_Check);
            this.Controls.Add(this.MrC_BT_Search);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.cb_Position_MrC);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cb_Brand_MrC);
            this.Controls.Add(this.cb_Supplier_MrC);
            this.Controls.Add(this.cb_Devices_MrC);
            this.Controls.Add(this.cb_Area_MrC);
            this.Controls.Add(this.txt_UserName_MrC);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AM_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Management";
            this.Load += new System.EventHandler(this.AM_Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cb_Status_MrC;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox txt_Serial_MrC;
        private System.Windows.Forms.Button bt_Refresh_MrC;
        private System.Windows.Forms.RadioButton rbt_Or_Check;
        private System.Windows.Forms.RadioButton rbt_And_Check;
        private System.Windows.Forms.Button MrC_BT_Search;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.ComboBox cb_Position_MrC;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_Brand_MrC;
        private System.Windows.Forms.ComboBox cb_Supplier_MrC;
        private System.Windows.Forms.ComboBox cb_Devices_MrC;
        private System.Windows.Forms.ComboBox cb_Area_MrC;
        private System.Windows.Forms.TextBox txt_UserName_MrC;
        private System.Windows.Forms.Button bt_Insert_MrC;
        private System.Windows.Forms.Button MrC_BT_Cancel;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_darea_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_devices_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Supplies_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_model_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serial_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hostname_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoice_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_handover_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Warranty_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dstatus_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_remark_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_location_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_assetcode_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_position_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_memory_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hdd_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_macaddr_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipaddr_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dns_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_defaultgw_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_logname_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password_MrC;
    }
}