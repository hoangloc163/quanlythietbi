namespace Asset_Management_Alpha
{
    partial class Server_Form
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
            Asset_Management_Alpha.QLVT_testDataSet3 qLVT_testDataSet3;
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_Area_MrC = new System.Windows.Forms.ComboBox();
            this.cb_Brand_MrC = new System.Windows.Forms.ComboBox();
            this.cb_Supplier_MrC = new System.Windows.Forms.ComboBox();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_CPU = new System.Windows.Forms.TextBox();
            this.txt_RAM = new System.Windows.Forms.TextBox();
            this.txt_Storage = new System.Windows.Forms.TextBox();
            this.txt_RaidContrl = new System.Windows.Forms.TextBox();
            this.txt_Ethernet = new System.Windows.Forms.TextBox();
            this.txt_Graphic = new System.Windows.Forms.TextBox();
            this.dt_invoice = new System.Windows.Forms.DateTimePicker();
            this.dt_handover = new System.Windows.Forms.DateTimePicker();
            this.txt_OptDrive = new System.Windows.Forms.TextBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.col_darea_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_devices_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Supplier_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serial_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_model_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cpu_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ram_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_storage_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_powersupply_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_opticaldrive_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ethernet_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Graphic_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_raidcontroller_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invoice_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_handover_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remark_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Warranty_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hostname_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dstatus_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_location_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_assetcode_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_position_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_macaddr_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipaddr_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dns_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_defaultgw_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_logname_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password_MrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVERTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label97 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_Del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Power = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_Waranty = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.sERVER_TBLTableAdapter = new Asset_Management_Alpha.QLVT_testDataSet3TableAdapters.SERVER_TBLTableAdapter();
            this.txt_Hostname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            qLVT_testDataSet3 = new Asset_Management_Alpha.QLVT_testDataSet3();
            ((System.ComponentModel.ISupportInitialize)(qLVT_testDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVERTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_testDataSet3
            // 
            qLVT_testDataSet3.DataSetName = "QLVT_testDataSet3";
            qLVT_testDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "RAM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Storage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "RAID Controller";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ethernet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Graphic";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Optical Drive";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Invoice Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(977, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Handover Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(786, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Remarks";
            // 
            // cb_Area_MrC
            // 
            this.cb_Area_MrC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Area_MrC.FormattingEnabled = true;
            this.cb_Area_MrC.Location = new System.Drawing.Point(78, 8);
            this.cb_Area_MrC.Name = "cb_Area_MrC";
            this.cb_Area_MrC.Size = new System.Drawing.Size(61, 21);
            this.cb_Area_MrC.TabIndex = 19;
            this.cb_Area_MrC.SelectedIndexChanged += new System.EventHandler(this.cb_Area_MrC_SelectedIndexChanged);
            // 
            // cb_Brand_MrC
            // 
            this.cb_Brand_MrC.FormattingEnabled = true;
            this.cb_Brand_MrC.Location = new System.Drawing.Point(78, 47);
            this.cb_Brand_MrC.Name = "cb_Brand_MrC";
            this.cb_Brand_MrC.Size = new System.Drawing.Size(111, 21);
            this.cb_Brand_MrC.TabIndex = 22;
            this.cb_Brand_MrC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Brand_MrC_KeyPress);
            // 
            // cb_Supplier_MrC
            // 
            this.cb_Supplier_MrC.FormattingEnabled = true;
            this.cb_Supplier_MrC.Location = new System.Drawing.Point(78, 88);
            this.cb_Supplier_MrC.Name = "cb_Supplier_MrC";
            this.cb_Supplier_MrC.Size = new System.Drawing.Size(111, 21);
            this.cb_Supplier_MrC.TabIndex = 21;
            this.cb_Supplier_MrC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Supplier_MrC_KeyPress);
            // 
            // txt_Serial
            // 
            this.txt_Serial.Location = new System.Drawing.Point(78, 131);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(111, 20);
            this.txt_Serial.TabIndex = 24;
            this.txt_Serial.TextChanged += new System.EventHandler(this.txt_Serial_TextChanged);
            this.txt_Serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Serial_KeyDown);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(254, 8);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(168, 20);
            this.txt_Model.TabIndex = 25;
            // 
            // txt_CPU
            // 
            this.txt_CPU.Location = new System.Drawing.Point(254, 47);
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.Size = new System.Drawing.Size(168, 20);
            this.txt_CPU.TabIndex = 26;
            // 
            // txt_RAM
            // 
            this.txt_RAM.Location = new System.Drawing.Point(254, 88);
            this.txt_RAM.Name = "txt_RAM";
            this.txt_RAM.Size = new System.Drawing.Size(168, 20);
            this.txt_RAM.TabIndex = 27;
            // 
            // txt_Storage
            // 
            this.txt_Storage.Location = new System.Drawing.Point(255, 131);
            this.txt_Storage.Name = "txt_Storage";
            this.txt_Storage.Size = new System.Drawing.Size(168, 20);
            this.txt_Storage.TabIndex = 28;
            // 
            // txt_RaidContrl
            // 
            this.txt_RaidContrl.Location = new System.Drawing.Point(526, 131);
            this.txt_RaidContrl.Name = "txt_RaidContrl";
            this.txt_RaidContrl.Size = new System.Drawing.Size(245, 20);
            this.txt_RaidContrl.TabIndex = 29;
            // 
            // txt_Ethernet
            // 
            this.txt_Ethernet.Location = new System.Drawing.Point(526, 47);
            this.txt_Ethernet.Name = "txt_Ethernet";
            this.txt_Ethernet.Size = new System.Drawing.Size(245, 20);
            this.txt_Ethernet.TabIndex = 30;
            // 
            // txt_Graphic
            // 
            this.txt_Graphic.Location = new System.Drawing.Point(526, 88);
            this.txt_Graphic.Name = "txt_Graphic";
            this.txt_Graphic.Size = new System.Drawing.Size(245, 20);
            this.txt_Graphic.TabIndex = 31;
            // 
            // dt_invoice
            // 
            this.dt_invoice.Location = new System.Drawing.Point(869, 10);
            this.dt_invoice.Name = "dt_invoice";
            this.dt_invoice.Size = new System.Drawing.Size(98, 20);
            this.dt_invoice.TabIndex = 32;
            // 
            // dt_handover
            // 
            this.dt_handover.Location = new System.Drawing.Point(1063, 9);
            this.dt_handover.Name = "dt_handover";
            this.dt_handover.Size = new System.Drawing.Size(98, 20);
            this.dt_handover.TabIndex = 33;
            // 
            // txt_OptDrive
            // 
            this.txt_OptDrive.Location = new System.Drawing.Point(526, 8);
            this.txt_OptDrive.Name = "txt_OptDrive";
            this.txt_OptDrive.Size = new System.Drawing.Size(245, 20);
            this.txt_OptDrive.TabIndex = 34;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(869, 50);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(292, 62);
            this.txt_remark.TabIndex = 35;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_darea_MrC,
            this.col_devices_MrC,
            this.col_brand_MrC,
            this.col_Supplier_MrC,
            this.col_serial_MrC,
            this.col_model_MrC,
            this.col_cpu_MrC,
            this.col_ram_MrC,
            this.col_storage_MrC,
            this.col_powersupply_MrC,
            this.col_opticaldrive_MrC,
            this.col_ethernet_MrC,
            this.col_Graphic_MrC,
            this.col_raidcontroller_MrC,
            this.col_invoice_MrC,
            this.col_handover_MrC,
            this.col_remark_MrC,
            this.col_Warranty_MrC,
            this.col_hostname_MrC,
            this.col_dstatus_MrC,
            this.col_location_MrC,
            this.col_assetcode_MrC,
            this.col_username_MrC,
            this.col_position_MrC,
            this.col_macaddr_MrC,
            this.col_ipaddr_MrC,
            this.col_dns_MrC,
            this.col_defaultgw_MrC,
            this.col_logname_MrC,
            this.col_password_MrC});
            this.dataGridView2.DataSource = this.sERVERTBLBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 209);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1149, 321);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // col_darea_MrC
            // 
            this.col_darea_MrC.DataPropertyName = "DAREA";
            this.col_darea_MrC.Frozen = true;
            this.col_darea_MrC.HeaderText = "AREA";
            this.col_darea_MrC.MaxInputLength = 3;
            this.col_darea_MrC.Name = "col_darea_MrC";
            this.col_darea_MrC.Width = 41;
            // 
            // col_devices_MrC
            // 
            this.col_devices_MrC.DataPropertyName = "DTYPE";
            this.col_devices_MrC.Frozen = true;
            this.col_devices_MrC.HeaderText = "DEVICES";
            this.col_devices_MrC.MaxInputLength = 20;
            this.col_devices_MrC.Name = "col_devices_MrC";
            this.col_devices_MrC.Width = 68;
            // 
            // col_brand_MrC
            // 
            this.col_brand_MrC.DataPropertyName = "BRAND";
            this.col_brand_MrC.Frozen = true;
            this.col_brand_MrC.HeaderText = "BRAND";
            this.col_brand_MrC.MaxInputLength = 10;
            this.col_brand_MrC.Name = "col_brand_MrC";
            this.col_brand_MrC.Width = 60;
            // 
            // col_Supplier_MrC
            // 
            this.col_Supplier_MrC.DataPropertyName = "SUPPLIER";
            this.col_Supplier_MrC.Frozen = true;
            this.col_Supplier_MrC.HeaderText = "SUPPLIER";
            this.col_Supplier_MrC.MaxInputLength = 20;
            this.col_Supplier_MrC.Name = "col_Supplier_MrC";
            this.col_Supplier_MrC.Width = 84;
            // 
            // col_serial_MrC
            // 
            this.col_serial_MrC.DataPropertyName = "SERIAL";
            this.col_serial_MrC.Frozen = true;
            this.col_serial_MrC.HeaderText = "SERIAL";
            this.col_serial_MrC.MaxInputLength = 50;
            this.col_serial_MrC.Name = "col_serial_MrC";
            this.col_serial_MrC.ReadOnly = true;
            this.col_serial_MrC.Width = 70;
            // 
            // col_model_MrC
            // 
            this.col_model_MrC.DataPropertyName = "MODEL";
            this.col_model_MrC.Frozen = true;
            this.col_model_MrC.HeaderText = "MODEL";
            this.col_model_MrC.MaxInputLength = 100;
            this.col_model_MrC.Name = "col_model_MrC";
            this.col_model_MrC.Width = 70;
            // 
            // col_cpu_MrC
            // 
            this.col_cpu_MrC.DataPropertyName = "CPU";
            this.col_cpu_MrC.HeaderText = "CPU";
            this.col_cpu_MrC.Name = "col_cpu_MrC";
            // 
            // col_ram_MrC
            // 
            this.col_ram_MrC.DataPropertyName = "RAM";
            this.col_ram_MrC.HeaderText = "RAM";
            this.col_ram_MrC.Name = "col_ram_MrC";
            // 
            // col_storage_MrC
            // 
            this.col_storage_MrC.DataPropertyName = "STORAGE";
            this.col_storage_MrC.HeaderText = "STORAGE";
            this.col_storage_MrC.Name = "col_storage_MrC";
            // 
            // col_powersupply_MrC
            // 
            this.col_powersupply_MrC.DataPropertyName = "POWER_SUPPLY";
            this.col_powersupply_MrC.HeaderText = "POWER SUPPLY";
            this.col_powersupply_MrC.Name = "col_powersupply_MrC";
            // 
            // col_opticaldrive_MrC
            // 
            this.col_opticaldrive_MrC.DataPropertyName = "OPTICAL_DRIVE";
            this.col_opticaldrive_MrC.HeaderText = "OPTICAL DRIVE";
            this.col_opticaldrive_MrC.Name = "col_opticaldrive_MrC";
            // 
            // col_ethernet_MrC
            // 
            this.col_ethernet_MrC.DataPropertyName = "ETHERNET";
            this.col_ethernet_MrC.HeaderText = "ETHERNET";
            this.col_ethernet_MrC.Name = "col_ethernet_MrC";
            // 
            // col_Graphic_MrC
            // 
            this.col_Graphic_MrC.DataPropertyName = "GRAPHIC";
            this.col_Graphic_MrC.HeaderText = "GRAPHIC";
            this.col_Graphic_MrC.Name = "col_Graphic_MrC";
            // 
            // col_raidcontroller_MrC
            // 
            this.col_raidcontroller_MrC.DataPropertyName = "RAID_CONTROLLER";
            this.col_raidcontroller_MrC.HeaderText = "RAID CONTROLLER";
            this.col_raidcontroller_MrC.Name = "col_raidcontroller_MrC";
            // 
            // col_invoice_MrC
            // 
            this.col_invoice_MrC.DataPropertyName = "INVOICE_DATE";
            this.col_invoice_MrC.HeaderText = "INVOICE DATE";
            this.col_invoice_MrC.MaxInputLength = 10;
            this.col_invoice_MrC.Name = "col_invoice_MrC";
            this.col_invoice_MrC.Width = 80;
            // 
            // col_handover_MrC
            // 
            this.col_handover_MrC.DataPropertyName = "HANDOVER_DATE";
            this.col_handover_MrC.HeaderText = "HAND-OVER DATE";
            this.col_handover_MrC.MaxInputLength = 10;
            this.col_handover_MrC.Name = "col_handover_MrC";
            this.col_handover_MrC.Width = 87;
            // 
            // col_remark_MrC
            // 
            this.col_remark_MrC.DataPropertyName = "REMARKS";
            this.col_remark_MrC.HeaderText = "REMARKS";
            this.col_remark_MrC.MaxInputLength = 150;
            this.col_remark_MrC.Name = "col_remark_MrC";
            this.col_remark_MrC.Width = 78;
            // 
            // col_Warranty_MrC
            // 
            this.col_Warranty_MrC.DataPropertyName = "WARRANTY";
            this.col_Warranty_MrC.HeaderText = "WARRANTY";
            this.col_Warranty_MrC.MaxInputLength = 10;
            this.col_Warranty_MrC.Name = "col_Warranty_MrC";
            this.col_Warranty_MrC.Width = 85;
            // 
            // col_hostname_MrC
            // 
            this.col_hostname_MrC.DataPropertyName = "HOSTNAME";
            this.col_hostname_MrC.HeaderText = "HOST NAME";
            this.col_hostname_MrC.MaxInputLength = 20;
            this.col_hostname_MrC.Name = "col_hostname_MrC";
            this.col_hostname_MrC.Width = 76;
            // 
            // col_dstatus_MrC
            // 
            this.col_dstatus_MrC.DataPropertyName = "DSTATUS";
            this.col_dstatus_MrC.HeaderText = "STATUS";
            this.col_dstatus_MrC.MaxInputLength = 5;
            this.col_dstatus_MrC.Name = "col_dstatus_MrC";
            // 
            // col_location_MrC
            // 
            this.col_location_MrC.DataPropertyName = "LOCATION";
            this.col_location_MrC.HeaderText = "LOCATION";
            this.col_location_MrC.MaxInputLength = 30;
            this.col_location_MrC.Name = "col_location_MrC";
            this.col_location_MrC.Width = 86;
            // 
            // col_assetcode_MrC
            // 
            this.col_assetcode_MrC.DataPropertyName = "ASSETCODE";
            this.col_assetcode_MrC.HeaderText = "ASSET CODE";
            this.col_assetcode_MrC.MaxInputLength = 20;
            this.col_assetcode_MrC.Name = "col_assetcode_MrC";
            this.col_assetcode_MrC.Visible = false;
            this.col_assetcode_MrC.Width = 92;
            // 
            // col_username_MrC
            // 
            this.col_username_MrC.DataPropertyName = "USRNAME";
            this.col_username_MrC.HeaderText = "USER NAME";
            this.col_username_MrC.MaxInputLength = 50;
            this.col_username_MrC.Name = "col_username_MrC";
            this.col_username_MrC.Visible = false;
            this.col_username_MrC.Width = 93;
            // 
            // col_position_MrC
            // 
            this.col_position_MrC.DataPropertyName = "POSITION";
            this.col_position_MrC.HeaderText = "POSITION";
            this.col_position_MrC.MaxInputLength = 30;
            this.col_position_MrC.Name = "col_position_MrC";
            this.col_position_MrC.Visible = false;
            this.col_position_MrC.Width = 83;
            // 
            // col_macaddr_MrC
            // 
            this.col_macaddr_MrC.DataPropertyName = "MAC_ADDR";
            this.col_macaddr_MrC.HeaderText = "MAC ADDRESS";
            this.col_macaddr_MrC.MaxInputLength = 17;
            this.col_macaddr_MrC.Name = "col_macaddr_MrC";
            this.col_macaddr_MrC.Visible = false;
            // 
            // col_ipaddr_MrC
            // 
            this.col_ipaddr_MrC.DataPropertyName = "IP_ADDR";
            this.col_ipaddr_MrC.HeaderText = "IP ADDRESS";
            this.col_ipaddr_MrC.MaxInputLength = 15;
            this.col_ipaddr_MrC.Name = "col_ipaddr_MrC";
            this.col_ipaddr_MrC.Visible = false;
            // 
            // col_dns_MrC
            // 
            this.col_dns_MrC.DataPropertyName = "DNS";
            this.col_dns_MrC.HeaderText = "DNS";
            this.col_dns_MrC.MaxInputLength = 15;
            this.col_dns_MrC.Name = "col_dns_MrC";
            this.col_dns_MrC.Visible = false;
            // 
            // col_defaultgw_MrC
            // 
            this.col_defaultgw_MrC.DataPropertyName = "DEFAULT_GW";
            this.col_defaultgw_MrC.HeaderText = "DEFAULT GW";
            this.col_defaultgw_MrC.MaxInputLength = 15;
            this.col_defaultgw_MrC.Name = "col_defaultgw_MrC";
            this.col_defaultgw_MrC.Visible = false;
            // 
            // col_logname_MrC
            // 
            this.col_logname_MrC.DataPropertyName = "LOG_NAME";
            this.col_logname_MrC.HeaderText = "LOGIN NAME";
            this.col_logname_MrC.MaxInputLength = 20;
            this.col_logname_MrC.Name = "col_logname_MrC";
            this.col_logname_MrC.Visible = false;
            // 
            // col_password_MrC
            // 
            this.col_password_MrC.DataPropertyName = "PASSWRD";
            this.col_password_MrC.HeaderText = "PASSWORD";
            this.col_password_MrC.Name = "col_password_MrC";
            this.col_password_MrC.Visible = false;
            // 
            // sERVERTBLBindingSource
            // 
            this.sERVERTBLBindingSource.DataSource = qLVT_testDataSet3;
            this.sERVERTBLBindingSource.Position = 0;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(1118, 533);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(43, 13);
            this.label97.TabIndex = 75;
            this.label97.Text = "0 Rows";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(789, 170);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 76;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_KeyDown);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(1086, 170);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 77;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(37, 17);
            this.checkBox1.TabIndex = 78;
            this.checkBox1.Text = "All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_Del
            // 
            this.bt_Del.Location = new System.Drawing.Point(982, 170);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(75, 23);
            this.bt_Del.TabIndex = 79;
            this.bt_Del.Text = "Delete";
            this.bt_Del.UseVisualStyleBackColor = true;
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(977, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Warranty";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(255, 172);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(167, 20);
            this.txt_Location.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(201, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Location";
            // 
            // txt_Power
            // 
            this.txt_Power.Location = new System.Drawing.Point(526, 172);
            this.txt_Power.Name = "txt_Power";
            this.txt_Power.Size = new System.Drawing.Size(245, 20);
            this.txt_Power.TabIndex = 89;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 88;
            this.label20.Text = "Power Supply";
            // 
            // cb_Waranty
            // 
            this.cb_Waranty.FormattingEnabled = true;
            this.cb_Waranty.Location = new System.Drawing.Point(1036, 130);
            this.cb_Waranty.Name = "cb_Waranty";
            this.cb_Waranty.Size = new System.Drawing.Size(125, 21);
            this.cb_Waranty.TabIndex = 90;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(869, 130);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(82, 21);
            this.cb_Status.TabIndex = 91;
            // 
            // sERVER_TBLTableAdapter
            // 
            this.sERVER_TBLTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Hostname
            // 
            this.txt_Hostname.Location = new System.Drawing.Point(78, 172);
            this.txt_Hostname.Name = "txt_Hostname";
            this.txt_Hostname.Size = new System.Drawing.Size(111, 20);
            this.txt_Hostname.TabIndex = 93;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 92;
            this.label19.Text = "Host name";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(892, 170);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 94;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 546);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_Hostname);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.cb_Waranty);
            this.Controls.Add(this.txt_Power);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Del);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.txt_OptDrive);
            this.Controls.Add(this.dt_handover);
            this.Controls.Add(this.dt_invoice);
            this.Controls.Add(this.txt_Graphic);
            this.Controls.Add(this.txt_Ethernet);
            this.Controls.Add(this.txt_RaidContrl);
            this.Controls.Add(this.txt_Storage);
            this.Controls.Add(this.txt_RAM);
            this.Controls.Add(this.txt_CPU);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Serial);
            this.Controls.Add(this.cb_Brand_MrC);
            this.Controls.Add(this.cb_Supplier_MrC);
            this.Controls.Add(this.cb_Area_MrC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Server_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server_Form";
            this.Load += new System.EventHandler(this.Server_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(qLVT_testDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVERTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_Area_MrC;
        private System.Windows.Forms.ComboBox cb_Brand_MrC;
        private System.Windows.Forms.ComboBox cb_Supplier_MrC;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_CPU;
        private System.Windows.Forms.TextBox txt_RAM;
        private System.Windows.Forms.TextBox txt_Storage;
        private System.Windows.Forms.TextBox txt_RaidContrl;
        private System.Windows.Forms.TextBox txt_Ethernet;
        private System.Windows.Forms.TextBox txt_Graphic;
        private System.Windows.Forms.DateTimePicker dt_invoice;
        private System.Windows.Forms.DateTimePicker dt_handover;
        private System.Windows.Forms.TextBox txt_OptDrive;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_Del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Power;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_Waranty;
        private System.Windows.Forms.ComboBox cb_Status;
        private QLVT_testDataSet3TableAdapters.SERVER_TBLTableAdapter sERVER_TBLTableAdapter;
        private System.Windows.Forms.BindingSource sERVERTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_darea_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_devices_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Supplier_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serial_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_model_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cpu_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ram_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_storage_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_powersupply_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_opticaldrive_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ethernet_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Graphic_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_raidcontroller_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoice_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_handover_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_remark_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Warranty_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hostname_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dstatus_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_location_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_assetcode_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_position_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_macaddr_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipaddr_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dns_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_defaultgw_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_logname_MrC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password_MrC;
        private System.Windows.Forms.TextBox txt_Hostname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Change;
    }
}