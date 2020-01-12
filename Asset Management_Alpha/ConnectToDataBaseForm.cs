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

        ConnectObj ObjConnect = new ConnectObj();
        DevicesBUS busDevices = new DevicesBUS();

        //public String ConnectString = "";
        //public SqlConnection conn;

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
                //db.Connect2DB(cbx_sername.SelectedItem.ToString(), txt_DatabaseName.Text, info , error);
                message = busDevices.connect(cbx_sername.SelectedItem.ToString(), txt_DatabaseName.Text, message);

                //ConnectString = "Data Source=" + cbx_sername.SelectedItem.ToString() + ";Initial Catalog=" + txt_DatabaseName.Text + ";Integrated Security=True";
                //conn = new SqlConnection(ConnectString);
                //conn.Open();

                //RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\QLVT_test");

                //key.SetValue("ServerName", cbx_sername.SelectedItem.ToString());
                //key.SetValue("DatabaseName", txt_DatabaseName.Text);
                //key.SetValue("WSLCheck", "Off");
                //key.SetValue("WSLValue", "100");
                //key.SetValue("WHSDCheck", "Off");
                //key.SetValue("WHSDValue", "30");
                //key.SetValue("MCNCheck", "Off");
                //key.SetValue("WHHCheck", "Off");
                //key.SetValue("MCNValue", "15000000");

                //key.Close();

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            finally
            {
                //if (conn.State == ConnectionState.Open)
                    //conn.Close();
                this.Close();
            }
        }
    }
}
