namespace Asset_Management_Alpha
{
    partial class Form_Add_NV
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
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Rows = new System.Windows.Forms.Label();
            this.txt_DefaultPassword = new System.Windows.Forms.TextBox();
            this.cb_permission = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(97, 16);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(127, 20);
            this.txt_manhanvien.TabIndex = 0;
            this.txt_manhanvien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_manhanvien_KeyDown);
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(97, 52);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(185, 20);
            this.txt_tennhanvien.TabIndex = 1;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(395, 16);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(185, 20);
            this.txt_tendangnhap.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(395, 51);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(185, 20);
            this.txt_matkhau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Đăng Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật Khẩu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_manhanvien,
            this.col_tennhanvien,
            this.col_tendangnhap,
            this.col_matkhau,
            this.col_phongban,
            this.col_permission});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 158);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // col_manhanvien
            // 
            this.col_manhanvien.DataPropertyName = "manhanvien";
            this.col_manhanvien.HeaderText = "Mã Nhân Viên";
            this.col_manhanvien.Name = "col_manhanvien";
            this.col_manhanvien.ReadOnly = true;
            // 
            // col_tennhanvien
            // 
            this.col_tennhanvien.DataPropertyName = "tennhanvien";
            this.col_tennhanvien.HeaderText = "Tên Nhân Viên";
            this.col_tennhanvien.Name = "col_tennhanvien";
            // 
            // col_tendangnhap
            // 
            this.col_tendangnhap.DataPropertyName = "tendangnhap";
            this.col_tendangnhap.HeaderText = "Tên Đăng Nhập";
            this.col_tendangnhap.Name = "col_tendangnhap";
            // 
            // col_matkhau
            // 
            this.col_matkhau.DataPropertyName = "matkhau";
            this.col_matkhau.HeaderText = "Mật Khẩu";
            this.col_matkhau.Name = "col_matkhau";
            // 
            // col_phongban
            // 
            this.col_phongban.DataPropertyName = "phongban";
            this.col_phongban.HeaderText = "Phòng Ban";
            this.col_phongban.Name = "col_phongban";
            // 
            // col_permission
            // 
            this.col_permission.DataPropertyName = "permission";
            this.col_permission.HeaderText = "Permission";
            this.col_permission.Name = "col_permission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Permission:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phòng Ban:";
            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(671, 16);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(185, 20);
            this.txt_phongban.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(165, 242);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(269, 242);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(367, 242);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 15;
            this.btn_Change.Text = "Sửa";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.Location = new System.Drawing.Point(671, 242);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(102, 23);
            this.btn_ResetPass.TabIndex = 16;
            this.btn_ResetPass.Text = "Reset Password";
            this.btn_ResetPass.UseVisualStyleBackColor = true;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(786, 242);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(230, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(52, 23);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Số Nhân viên:";
            // 
            // lb_Rows
            // 
            this.lb_Rows.AutoSize = true;
            this.lb_Rows.Location = new System.Drawing.Point(94, 247);
            this.lb_Rows.Name = "lb_Rows";
            this.lb_Rows.Size = new System.Drawing.Size(34, 13);
            this.lb_Rows.TabIndex = 20;
            this.lb_Rows.Text = "Rows";
            // 
            // txt_DefaultPassword
            // 
            this.txt_DefaultPassword.Location = new System.Drawing.Point(533, 244);
            this.txt_DefaultPassword.Name = "txt_DefaultPassword";
            this.txt_DefaultPassword.Size = new System.Drawing.Size(127, 20);
            this.txt_DefaultPassword.TabIndex = 21;
            this.txt_DefaultPassword.Text = "P@ssW0rd";
            // 
            // cb_permission
            // 
            this.cb_permission.FormattingEnabled = true;
            this.cb_permission.Items.AddRange(new object[] {
            "Administrator",
            "Members",
            "Users"});
            this.cb_permission.Location = new System.Drawing.Point(671, 52);
            this.cb_permission.Name = "cb_permission";
            this.cb_permission.Size = new System.Drawing.Size(185, 21);
            this.cb_permission.TabIndex = 22;
            // 
            // Form_Add_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 271);
            this.Controls.Add(this.cb_permission);
            this.Controls.Add(this.txt_DefaultPassword);
            this.Controls.Add(this.lb_Rows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ResetPass);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.txt_manhanvien);
            this.Name = "Form_Add_NV";
            this.Text = "Form_Add_NV";
            this.Load += new System.EventHandler(this.Form_Add_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Rows;
        private System.Windows.Forms.TextBox txt_DefaultPassword;
        private System.Windows.Forms.ComboBox cb_permission;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permission;
    }
}