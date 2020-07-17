using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
using BussinessLogicLayer;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Asset_Management_Alpha
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }
        
        string check = "False";

        //check connect database
        void TestRegister()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Asset Management");
            if (key == null)
            {
                ConnectToDataBaseForm frm = new ConnectToDataBaseForm();
                frm.ShowDialog();
            }
            else
            {
                key.Close();
            }
        }
     
        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            NhanVien objnhanvien = new NhanVien();
            NhanVienBUS busnhanvien = new NhanVienBUS();

            if (txt_tendangnhap.Text != "" && txt_matkhau.Text != "")
            {
                objnhanvien.tendangnhap = txt_tendangnhap.Text;
                objnhanvien.matkhau = txt_matkhau.Text;
                //ma hoa
                objnhanvien.matkhau = busnhanvien.Mahoa(objnhanvien);

                check = busnhanvien.LogIn(objnhanvien, check);

                if (check == "True") //phai la True mới dc, con true la ko dc
                {
                    MessageBox.Show("Chào mừng bạn");

                    // mo form ke tiep (AM_Main_Form)
                    AM_Main_Form SGF_Form = new AM_Main_Form();
                    SGF_Form.CheckTenDangNhap(txt_tendangnhap.Text.ToString());
                    SGF_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Thông Báo");
            }
        }

        private void LogIn_Form_Load(object sender, EventArgs e)
        {
            //check connect database
            TestRegister();

            this.AcceptButton = bt_Login;
        }

    }
}
