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
using static Asset_Management_Alpha.AM_Main_Form;
//using static Asset_Management_Alpha.SFG; // link ve form SGF
using System.Text.RegularExpressions;

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
                MessageBox.Show(message + " " + txt_Serial.Text);
                cleartxt();

                //// add qua form SGF
                //SFG SGF_Form = new SFG();
                //SGF_Form.UpdateForm("update");
                //SGF_Form.Refesh_dtgv();

                // add qua form AM_Main_Form
                AM_Main_Form SGF_Form = new AM_Main_Form();
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
            loadcb_Status();
            loadcb_Devices();
            loadcb_Brand();
        }

        void ViewToObj()
        {
            objDevices.darea = cb_Area.Text; 
            objDevices.dtype = cb_Devices_MrC.Text; 
            objDevices.brand = cb_Brand_MrC.Text;
            objDevices.model = txt_Model.Text;
            objDevices.serial = txt_Serial.Text.Trim();// han che viec de rong
            objDevices.invoice_date = dt_invoice.Value.ToString("yyyy/MM/dd");
            objDevices.handover_date = dt_handover.Value.ToString("yyyy/MM/dd");
            objDevices.warranty = cb_Warranty_MrC.Text;
            objDevices.supplies = cb_Supplier.Text;
            objDevices.remark = txt_remark.Text;
            objDevices.mac_addr = txt_macaddr.Text;
            objDevices.dstatus = cb_Status.Text;
        }

        void cleartxt()
        {
            txt_Serial.Clear();
            txt_macaddr.Clear();
            txt_remark.Clear();
        }

        #region load Combobox
        public void loadcb_Area()
        {
            cb_Area.DataSource = busDevices.GetData4Cb_Area();
            cb_Area.DisplayMember = "darea".Trim();
        }
        public void loadcb_Devices()
        {
            cb_Devices_MrC.DataSource = busDevices.GetData4Cb_Devices();
            cb_Devices_MrC.DisplayMember = "dtype".Trim();
        }
        public void loadcb_Brand()
        {
            cb_Brand_MrC.DataSource = busDevices.GetData4Cb_Brand();
            cb_Brand_MrC.DisplayMember = "brand".Trim();
        }
        public void loadcb_Supplier()
        {
            cb_Supplier.DataSource = busDevices.GetData4Cb_Supplier();
            cb_Supplier.DisplayMember = "supplies".Trim();
        }
        public void loadcb_Status()
        {
            cb_Status.DataSource = busDevices.GetData4Cb_Status();
            cb_Status.DisplayMember = "dstatus".Trim();
        }
        #endregion

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {
            txt_Serial.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_Serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Serial.Text = txt_Serial.Text.Trim();
                // code dua con tro ve cuoi
                txt_Serial.Focus();
                txt_Serial.SelectionStart = txt_Serial.Text.Length;
            }
        }

        private void txt_Model_TextChanged(object sender, EventArgs e)
        {
            txt_Model.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_macaddr_TextChanged(object sender, EventArgs e)
        {
            txt_macaddr.CharacterCasing = CharacterCasing.Upper;
            int count_text = txt_macaddr.Text.Length;
            // code cho de go dia chi MAC
            if(count_text == 2 || count_text == 5 || count_text == 8 || count_text == 11 || count_text == 14)
                {
                    txt_macaddr.Text = txt_macaddr.Text + ":";
                }
            // code dua con tro ve cuoi
            txt_macaddr.Focus();
            txt_macaddr.SelectionStart = txt_macaddr.Text.Length;
        }

        private void txt_macaddr_KeyDown(object sender, KeyEventArgs e)
        {
            int count_text = txt_macaddr.Text.Length;
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txt_macaddr.Text))
                {
                    if (count_text < 17)
                    {
                        if (count_text == 12)
                        {
                            // chen dau ':' vao chuoi dia chi MAC
                            txt_macaddr.Text = Regex.Replace(txt_macaddr.Text.ToString(), ".{2}", "$0:");
                            txt_macaddr.Text = txt_macaddr.Text.Substring(0, 17);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại địa chỉ MAC");
                        }
                    }
                }
                // code dua con tro ve cuoi
                txt_macaddr.Focus();
                txt_macaddr.SelectionStart = txt_macaddr.Text.Length;
            }
        }

        private void cb_Brand_MrC_TextChanged(object sender, EventArgs e)
        {
            string upper = cb_Brand_MrC.Text.ToUpper();
            if (upper != cb_Brand_MrC.Text)
                cb_Brand_MrC.Text = upper;
        }

        private void cb_Devices_MrC_TextChanged(object sender, EventArgs e)
        {
            string upper = cb_Devices_MrC.Text.ToUpper();
            if (upper != cb_Devices_MrC.Text)
                cb_Devices_MrC.Text = upper;
        }

        
    }
}
