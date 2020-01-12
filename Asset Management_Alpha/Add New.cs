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
using Asset_Management_Alpha;
using static Asset_Management_Alpha.SFG;

namespace Asset_Management_Alpha
{
    public partial class Add_New : Form
    {
        public RefreshDtgvDelegate RefreshDtgvCallback;
        public Add_New()
        {
            InitializeComponent();
        }

        Devices objDevices = new Devices();
        DevicesBUS busDevices = new DevicesBUS();
        private void bt_Add_Dev_Click(object sender, EventArgs e)
        {     
            if (txt_Serial.Text != "" && txt_Serial.Text != null)
            {
                string message = "";
                ViewToObj();
                message = busDevices.Insert_Form(objDevices, message); // lấy ra message từ proc của sql
                // dataGridView2.Refresh();
                //MessageBox.Show("Insert Successfully!");
                MessageBox.Show(message + " " + txt_Serial.Text);
                cleartxt();
                SFG SGF_Form = new SFG();
                SGF_Form.UpdateForm("update");
                SGF_Form.Refesh_dtgv();
                RefreshDtgvCallback();
            }
            else
            {
                MessageBox.Show("Please Fill Serial Numbers");
            }
        }

        private void bt_Cancel_Dev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_New_Load(object sender, EventArgs e)
        {
            loadcb_Area();
            loadcb_Supplier();
        }

        void ViewToObj()
        {
            objDevices.darea = cb_Area.Text; 
            objDevices.dtype = txt_Devices.Text; 
            objDevices.brand = txt_Brand.Text;
            objDevices.model = txt_Model.Text;
            objDevices.serial = txt_Serial.Text.Trim();// han che viec de rong
            objDevices.invoice_date = dt_invoice.Value.ToString("yyyy/MM/dd");
            objDevices.handover_date = dt_handover.Value.ToString("yyyy/MM/dd");
            objDevices.warranty = txt_Warranty.Text;
            objDevices.supplies = cb_Supplier.Text;
            objDevices.remark = txt_remark.Text;
            objDevices.mac_addr = txt_macaddr.Text;
            objDevices.dstatus = cb_Status.Text;
        }

        void cleartxt()
        {
            txt_Serial.Clear();
            txt_Warranty.Clear();
            txt_macaddr.Clear();
        }

        public void loadcb_Area()
        {
            cb_Area.DataSource = busDevices.GetData4Cb_Area();
            cb_Area.DisplayMember = "darea".Trim();
        }

        public void loadcb_Supplier()
        {
            cb_Supplier.DataSource = busDevices.GetData4Cb_Supplier();
            cb_Supplier.DisplayMember = "supplies".Trim();
        }
    }
}
