using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using DataAccessLayer;
using ValueObject;
using BussinessLogicLayer;

namespace Asset_Management_Alpha
{
    public partial class ConnectToDataBaseForm : Form
    {
        //dbConnect db = new dbConnect(); // code ket noi db
        public ConnectToDataBaseForm()
        {
            InitializeComponent();
        }

        private void ConnectToDataBaseForm_Load(object sender, EventArgs e)
        {
            LoadTenSRV();
            cbx_sername.SelectedIndex = 0;
        }

        void LoadTenSRV()
        {
            cbx_sername.Items.Clear();
            try
            {
                ////code cũ lay server database name
                //string[] ServerList = (string[])
                //    Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server").GetValue("InstalledInstances");

                //code mới
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var rk = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
                var ServerList = (String[])rk.GetValue("InstalledInstances");

                foreach (string SqlServer in ServerList)
                {
                    cbx_sername.Items.Add(SystemInformation.ComputerName + "\\" + SqlServer);
                }
                cbx_sername.Items.Add(SystemInformation.ComputerName);
                cbx_sername.Text = SystemInformation.ComputerName;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, không tìm thấy Server nào của Microsoft SQL Server trong máy tính của bạn");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txt_DatabaseName.Text == "")
            {
                lbl_thongbao.Text = "Chưa nhập Database Name";
                return;
            }

            try
            {
                ConnectObj ObjConnect = new ConnectObj();
                DevicesBUS busDevices = new DevicesBUS();

                message = busDevices.connect(/*cbx_sername.SelectedItem.ToString()*/cbx_sername.Text, txt_DatabaseName.Text, txt_Username.Text, txt_Password.Text, message);
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open)
                    //conn.Close();
                this.Close();
            }
        }
    }
}
