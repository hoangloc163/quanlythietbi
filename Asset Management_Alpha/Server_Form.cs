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

namespace Asset_Management_Alpha
{
    public partial class Server_Form : Form
    {
        public Server_Form()
        {
            InitializeComponent();
        }


        Devices objDevices = new Devices();
        DevicesBUS busDevices = new DevicesBUS();
        Server objServer = new Server();
        ServerBUS busServer = new ServerBUS();

        string SQLQuery = "Select * from SERVER_TBL";
        string Current_Cell;
        string Updated_Cell;
        string HeaderSelectedCell;
        string ServerSerial;

        public void loadcb_Area()
        {
            cb_Area_MrC.DataSource = busDevices.GetData4Cb_Area();
            cb_Area_MrC.DisplayMember = "darea".Trim();
        }
        
        public void loadcb_Supplier()
        {
            cb_Supplier_MrC.DataSource = busServer.GetData4Cb_Supplier();
            cb_Supplier_MrC.DisplayMember = "supplier".Trim();
        }
        public void loadcb_Brand()
        {
            cb_Brand_MrC.DataSource = busServer.GetData4Cb_Brand();
            cb_Brand_MrC.DisplayMember = "brand".Trim();
        }
        public void loadcb_Status()
        {
            cb_Status.DataSource = busServer.GetData4Cb_Status();
            cb_Status.DisplayMember = "dstatus".Trim();
        }
        public void loadcb_Warranty()
        {
            cb_Waranty.DataSource = busServer.GetData4Cb_Warranty();
            cb_Waranty.DisplayMember = "warranty".Trim();
        }

        private void Server_Form_Load(object sender, EventArgs e)
        {
            HienThiDataGridView2(SQLQuery);
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
            loadcb_Area();
            loadcb_Brand();
            loadcb_Supplier();
            loadcb_Status();
            loadcb_Warranty();
            btn_Change.Enabled = false;
        }

        public void HienThiDataGridView2(string SQL)
        {
            dataGridView2.DataSource = busDevices.GetDataOriginal(SQL);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            Current_Cell = "";
            //Check_Cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            Current_Cell = this.dataGridView2.CurrentCell.FormattedValue.ToString().Trim();
            btn_Change.Enabled = true;
            txt_Serial.Enabled = false;

            if (e.RowIndex >= 0)
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView2.CurrentRow.Selected = true;
                    objServer.model = dataGridView2.Rows[e.RowIndex].Cells["col_model_MrC"].FormattedValue.ToString().Trim();
                    objServer.serial = dataGridView2.Rows[e.RowIndex].Cells["col_serial_MrC"].FormattedValue.ToString().Trim();
                    objServer.RAM = dataGridView2.Rows[e.RowIndex].Cells["col_ram_MrC"].FormattedValue.ToString().Trim();
                    objServer.storage = dataGridView2.Rows[e.RowIndex].Cells["col_storage_MrC"].FormattedValue.ToString().Trim();
                    objServer.CPU = dataGridView2.Rows[e.RowIndex].Cells["col_cpu_MrC"].FormattedValue.ToString().Trim();
                    objServer.ethernet = dataGridView2.Rows[e.RowIndex].Cells["col_ethernet_MrC"].FormattedValue.ToString().Trim();
                    objServer.graphic = dataGridView2.Rows[e.RowIndex].Cells["col_Graphic_MrC"].FormattedValue.ToString().Trim();
                    objServer.optical_drive = dataGridView2.Rows[e.RowIndex].Cells["col_opticaldrive_MrC"].FormattedValue.ToString().Trim();
                    objServer.raid_controller = dataGridView2.Rows[e.RowIndex].Cells["col_raidcontroller_MrC"].FormattedValue.ToString().Trim();
                    objServer.remarks = dataGridView2.Rows[e.RowIndex].Cells["col_remark_MrC"].FormattedValue.ToString().Trim();
                    objServer.invoice_date = dataGridView2.Rows[e.RowIndex].Cells["col_invoice_MrC"].FormattedValue.ToString().Trim();
                    objServer.handover_date = dataGridView2.Rows[e.RowIndex].Cells["col_handover_MrC"].FormattedValue.ToString().Trim();
                    objServer.brand = dataGridView2.Rows[e.RowIndex].Cells["col_brand_MrC"].FormattedValue.ToString().Trim();
                    objServer.supplier = dataGridView2.Rows[e.RowIndex].Cells["col_Supplier_MrC"].FormattedValue.ToString().Trim();
                    objServer.power_supply = dataGridView2.Rows[e.RowIndex].Cells["col_powersupply_MrC"].FormattedValue.ToString().Trim();
                    objServer.location = dataGridView2.Rows[e.RowIndex].Cells["col_location_MrC"].FormattedValue.ToString().Trim();
                    objServer.dstatus = dataGridView2.Rows[e.RowIndex].Cells["col_dstatus_MrC"].FormattedValue.ToString().Trim();
                    objServer.warranty = dataGridView2.Rows[e.RowIndex].Cells["col_warranty_MrC"].FormattedValue.ToString().Trim();
                    objServer.hostname = dataGridView2.Rows[e.RowIndex].Cells["col_hostname_MrC"].FormattedValue.ToString().Trim();
                    objServer.assetcode = dataGridView2.Rows[e.RowIndex].Cells["col_assetcode_MrC"].FormattedValue.ToString().Trim();
                    ObjToTxt();

                    HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
                }
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
                }
           }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // delete 1 dong
                DialogResult dialogResult = MessageBox.Show("Delete Server with serial number: " + objServer.serial, "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.RemoveAt(row.Index);
                    }
                    busServer.Delete(objServer);
                    dataGridView2.Refresh();
                    loadcb_Area();
                    loadcb_Brand();
                    loadcb_Supplier();
                    label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataGridView2.Refresh();
                }
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // lam gon chuoi nvchar o SQL khi hien thi len dataGridView2
            string str_name = null;
            str_name = dataGridView2.Columns[e.ColumnIndex].Name.ToString().Trim();
            dataGridView2.Rows[e.RowIndex].Cells[str_name].Value = dataGridView2.Rows[e.RowIndex].Cells[str_name].FormattedValue.ToString().Trim();
            // disable nut change
            btn_Change.Enabled = false;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Updated_Cell = "";
            Updated_Cell = this.dataGridView2.CurrentCell.FormattedValue.ToString().Trim();
            HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
            
            if (HeaderSelectedCell != "SERIAL" && HeaderSelectedCell != null)
            {
                if (Current_Cell != Updated_Cell)
                {
                    if (HeaderSelectedCell == "INVOICE_DATE" || HeaderSelectedCell == "HANDOVER_DATE")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to change " + HeaderSelectedCell + "\n from: [ " + Current_Cell.Trim() + " ] to: [ " + Updated_Cell + " ]\n which serial number: " + objServer.serial, "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string ConvertDate = "convert(date,'" + Updated_Cell + "',105)";
                            busServer.Change("update [SERVER_TBL] SET " + HeaderSelectedCell + " = " + ConvertDate + " where SERIAL = '" + objServer.serial + "'");
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            string str_name = null;
                            str_name = dataGridView2.Columns[e.ColumnIndex].Name.ToString().Trim();
                            dataGridView2.Rows[e.RowIndex].Cells[str_name].Value = Current_Cell.Trim();
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to change " + HeaderSelectedCell + "\n from: [ " + Current_Cell.Trim() + " ] to: [ " + Updated_Cell + " ]\n which serial number: " + objServer.serial, "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            busServer.Change("update [SERVER_TBL] SET " + HeaderSelectedCell + " = '" + Updated_Cell + "' where SERIAL = '" + objServer.serial + "'");
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            string str_name = null;
                            str_name = dataGridView2.Columns[e.ColumnIndex].Name.ToString().Trim();
                            dataGridView2.Rows[e.RowIndex].Cells[str_name].Value = Current_Cell.Trim();
                        }
                    }
                }
            }
            btn_Change.Enabled = true;
        }


        private void cb_Area_MrC_SelectedIndexChanged(object sender, EventArgs e)
        {
            objServer.darea = cb_Area_MrC.Text;
            dataGridView2.DataSource = busServer.GetData_Serverdtgv_By_Area(objServer);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                HienThiDataGridView2(SQLQuery);
            }
            else
            {
                objServer.darea = cb_Area_MrC.Text;
                dataGridView2.DataSource = busServer.GetData_Serverdtgv_By_Area(objServer);
            }
        }
              

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Serial.Enabled == true && txt_Serial.Text.Trim() != "")
            {
                txtboxToObj();
                string message = "";
                message = busServer.Insert(objServer, message);
                MessageBox.Show(message);
                if(message == "Đã nhập thành công")
                {
                    HienThiDataGridView2(SQLQuery);
                    dataGridView2.Refresh();
                    btn_Change.Enabled = true;
                }
            }
            if (txt_Serial.Enabled == false)
            {
                txt_Serial.Enabled = true;
                btn_Change.Enabled = false;
                ServerSerial = txt_Serial.Text;
            }
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Server with serial number: " + objServer.serial, "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                objServer.serial = txt_Serial.Text;
                busServer.Delete(objServer);
                HienThiDataGridView2(SQLQuery);
                dataGridView2.Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }  
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //AM_Main_Form FormMain = new AM_Main_Form();
            this.Close();
        }

        
        void txtboxToObj()
        {
            objServer.dtype = "Server";
            objServer.serial = txt_Serial.Text;
            objServer.CPU = txt_CPU.Text;
            objServer.ethernet = txt_Ethernet.Text;
            objServer.graphic = txt_Graphic.Text;
            objServer.model = txt_Model.Text;
            objServer.optical_drive = txt_OptDrive.Text;
            objServer.raid_controller = txt_RaidContrl.Text;
            objServer.RAM = txt_RAM.Text;
            objServer.remarks = txt_remark.Text;
            objServer.storage = txt_Storage.Text;
            objServer.darea = cb_Area_MrC.Text;
            objServer.handover_date = dt_handover.Text;
            objServer.invoice_date = dt_invoice.Text;
            objServer.dstatus = cb_Status.Text;
            objServer.warranty = cb_Waranty.Text;
            objServer.location = txt_Location.Text;
            objServer.power_supply = txt_Power.Text;
            objServer.brand = cb_Brand_MrC.Text;
            objServer.supplier = cb_Supplier_MrC.Text;
            objServer.hostname = txt_Hostname.Text;
        }

        void ObjToTxt()
        { 
            txt_Model.Text = objServer.model;
            txt_Serial.Text = objServer.serial;
            txt_RAM.Text = objServer.RAM;
            txt_Storage.Text = objServer.storage;
            txt_CPU.Text = objServer.CPU;
            txt_Ethernet.Text = objServer.ethernet;
            txt_Graphic.Text = objServer.graphic;
            txt_OptDrive.Text = objServer.optical_drive;
            txt_RaidContrl.Text = objServer.raid_controller;
            txt_remark.Text = objServer.remarks;
            dt_invoice.Text = objServer.invoice_date;
            dt_handover.Text = objServer.handover_date;
            cb_Brand_MrC.Text = objServer.brand;
            cb_Supplier_MrC.Text = objServer.supplier;
            txt_Power.Text= objServer.power_supply;
            txt_Location.Text = objServer.location;
            cb_Status.Text = objServer.dstatus;
            cb_Waranty.Text = objServer.warranty;
            txt_Hostname.Text = objServer.hostname;
        }

        void ClearTextBox()
        {
            txt_Serial.Clear() ;
            txt_CPU.Clear();
            txt_Ethernet.Clear();
            txt_Graphic.Clear();
            txt_Model.Clear();
            txt_OptDrive.Clear();
            txt_RaidContrl.Clear();
            txt_RAM.Clear();
            txt_remark.Clear();
            txt_Serial.Clear();
            txt_Storage.Clear();
            txt_Location.Clear();
            txt_Power.Clear();
            txt_Hostname.Clear();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            txtboxToObj();
            string messages = "";
            messages = busServer.ChangeALot(objServer, messages);
            MessageBox.Show(messages);
            HienThiDataGridView2(SQLQuery);
            dataGridView2.Refresh();
        }

        private void btn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (btn_Add.Focused == true && txt_Serial.Enabled == true)
                {
                    txt_Serial.Enabled = false;
                    btn_Change.Enabled = true;
                    txt_Serial.Text = ServerSerial;
                }
            }
        }

        private void txt_Serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (txt_Serial.Focused == true && btn_Change.Enabled == false)
                {
                    txt_Serial.Text = ServerSerial;
                    txt_Serial.Enabled = false;
                    btn_Change.Enabled = true;
                }
            }
        }

        private void cb_Brand_MrC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = e.KeyChar.ToString().ToUpper();
            char[] ch = str.ToCharArray();
            e.KeyChar = ch[0];
        }

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {
            txt_Serial.CharacterCasing = CharacterCasing.Upper;
        }

        private void cb_Supplier_MrC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = e.KeyChar.ToString().ToUpper();
            char[] ch = str.ToCharArray();
            e.KeyChar = ch[0];
        }

    }
}
