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
    public partial class SFG : Form
    {
        public SFG()
        {
            InitializeComponent();
        }

        Devices objDevices = new Devices();
        DevicesBUS busDevices = new DevicesBUS();
        PC objPc = new PC();
        PcBUS busPc = new PcBUS();
        MO objMo = new MO();
        MoBUS busMo = new MoBUS();
        AP objAp = new AP();
        ApBUS busAp = new ApBUS();
        CCTV objCctv = new CCTV();
        CctvBUS busCctv = new CctvBUS();

        //// Dat bien cho tab_MrC
        //string MrC_Area;
        //string MrC_Brand;
        //string MrC_Devices;
        //string MrC_Supplier;
        //string MrC_Username;
        //string MrC_Position;
        //string VarWhere = " where ";
        //string VarAnd = " and ";
        //string VarEqual = " = ";
        string SQLQuery = "Select * from DEVICES_TBL";
        //int Count_Status;
        string Current_Cell;
        string Updated_Cell;
        string HeaderSelectedCell;

        //void MrC_XuLi()
        // {
        //     if (cb_Area_MrC.SelectedText == "All" && cb_Devices_MrC.SelectedText == "All" &&
        //        cb_Supplier_MrC.SelectedText == "ALL" && cb_Brand_MrC.SelectedText == "ALL" &&
        //        txt_UserName_MrC.Text == "" && cb_Position_MrC.SelectedText == "All")
        //     {
        //         SQLQuery = "Select * from DEVICES_TBL";
        //         MrC_Area = "DAREA";
        //         MrC_Brand = "BRAND";
        //         MrC_Devices = "DTYPE";
        //         MrC_Supplier = "SUPPLIES";
        //         MrC_Username = "USRNAME";
        //         MrC_Position = "POSITION";
        //         VarEqual = "";
        //     }
        //     else
        //     {
        //         Count_Status = 0;
        //         if(cb_Area_MrC.SelectedText != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Area = "";

        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }
        //         if (cb_Devices_MrC.SelectedText != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Devices = "";
        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }
        //         if (cb_Supplier_MrC.SelectedText != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Supplier = "";
        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }
        //         if (cb_Brand_MrC.SelectedText != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Brand = "";
        //             VarEqual = "";
        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }
        //         if (txt_UserName_MrC.Text != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Username = "";
        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }
        //         if (cb_Position_MrC.SelectedText != "All")
        //         {
        //             Count_Status = Count_Status + 1;
        //             MrC_Position = "";
        //         }
        //         else
        //         {
        //             VarEqual = "";
        //         }

        //         if (Count_Status > 1)
        //         {
        //             SQLQuery = "Select * from DEVICES_TBL" + VarWhere + MrC_Area + VarEqual + cb_Area_MrC.SelectedText
        //                                                    + VarAnd + MrC_Brand + VarEqual + cb_Brand_MrC.SelectedText
        //                                                    + VarAnd + MrC_Devices + VarEqual + cb_Devices_MrC.SelectedText
        //                                                    + VarAnd + MrC_Supplier + VarEqual + cb_Supplier_MrC.SelectedText
        //                                                    + VarAnd + MrC_Username + VarEqual + txt_UserName_MrC.Text
        //                                                    + VarAnd + MrC_Position + VarEqual + cb_Position_MrC.SelectedText;
        //         }
        //     }
        // }


        private void Form1_Load(object sender, EventArgs e)
        {
            //connect database
            TestRegister();


            // TODO: This line of code loads data into the 'qLVT_testDataSet1.DEVICES_TBL' table. You can move, or remove it, as needed.
            //this.dEVICES_TBLTableAdapter.Fill(this.qLVT_testDataSet1.DEVICES_TBL);
            PC_HienThi(objPc); //Hien thi datagridview o tab PC
            MO_HienThi(objMo); //Hien thi datagridview o tab MO
            //Thieu cac Hien Thi datagridview o cac tab con lai

            

            //MrC_XuLi();
            HienThiDataGridView2(SQLQuery);

            // hien thi cb box
            loadcb_Area();
            loadcb_Brand();
            loadcb_Devices();
            loadcb_Position();
            loadcb_Supplier();
            loadcb_Status();

        }

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


        /*KHU VUC TAB PC*/

        // View to Object (PC_tab)
        public void PC_txtBoxToObj()
        {
            objPc.area = this.Text; //lay ten form (vdu:SGF)
            objPc.devices = tab_PC.Text; // lay ten tab PC
            objPc.location = cb_location_pc.Text;
            objPc.position = txt_position_pc.Text;
            objPc.username = txt_username_pc.Text;
            objPc.hostname = txt_hostname_pc.Text;
            objPc.brand = cb_brand_pc.Text;
            objPc.model = cb_model_pc.Text;
            objPc.serial = txt_serial_pc.Text;
            objPc.invoice_date = dt_invoice_pc.Value.ToString("yyyy/MM/dd");
            objPc.handover_date = dt_handover_pc.Value.ToString("yyyy/MM/dd");
            objPc.warranty = cb_warranty_pc.Text;
            objPc.supplies = cb_supplies_pc.Text;
            objPc.assetcode = txt_assetcode_pc.Text;
            objPc.memory = cb_memory_pc.Text;
            objPc.hdd = cb_hdd_pc.Text;
            objPc.remark = txt_remark_pc.Text;
        }

        //hien thi cho dataGridView o tab PC
        void PC_HienThi(PC obj_pc) 
        {
            objPc.area = this.Text;
            PC_DEVICES_dtgv.DataSource = busPc.GetData1(obj_pc);
            PC_dtgv.DataSource = busPc.GetData2(obj_pc);
        }

        // Chuc nang "Ban Giao" | "Thu Hoi" | "Chuyen Thiet Bi"
        private void PC_BT_Insert_Click(object sender, EventArgs e)
        {
            if (txt_serial_pc.Text != "")
            {
                PC_txtBoxToObj();
                busPc.Insert(objPc);
                PC_HienThi(objPc);
                PC_DEVICES_dtgv.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose Devices with serial");
            }
        }
        private void PC_BT_Delete_Click(object sender, EventArgs e)
        {
            objPc.serial = txt_serial_pc.Text;
            busPc.Delete(objPc);
            PC_HienThi(objPc);
            PC_DEVICES_dtgv.Refresh();
        }
        private void PC_BT_Change_Click(object sender, EventArgs e)
        {
            PC_txtBoxToObj();
            busPc.Change(objPc);
            PC_HienThi(objPc);
            PC_DEVICES_dtgv.Refresh();
        }

        // DataGridView tab_PC
        private void PC_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (PC_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    PC_dtgv.CurrentRow.Selected = true;
                    txt_hostname_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_hostname_pc"].FormattedValue.ToString().Trim();
                    cb_brand_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_brand_pc"].FormattedValue.ToString().Trim();
                    cb_model_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_model_pc"].FormattedValue.ToString().Trim();
                    txt_serial_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_serial_pc"].FormattedValue.ToString().Trim();
                    dt_invoice_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_invoice_pc"].FormattedValue.ToString().Trim();
                    dt_handover_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_handover_pc"].FormattedValue.ToString().Trim();
                    cb_warranty_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_warranty_pc"].FormattedValue.ToString().Trim();
                    cb_supplies_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_supplies_pc"].FormattedValue.ToString().Trim();
                    cb_location_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_location_pc"].FormattedValue.ToString().Trim();
                    txt_assetcode_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_assetcode_pc"].FormattedValue.ToString().Trim();
                    txt_username_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_username_pc"].FormattedValue.ToString().Trim();
                    txt_position_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_position_pc"].FormattedValue.ToString().Trim();
                    cb_memory_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_memory_pc"].FormattedValue.ToString().Trim();
                    cb_hdd_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_hdd_pc"].FormattedValue.ToString().Trim();
                    txt_remark_pc.Text = PC_dtgv.Rows[e.RowIndex].Cells["col_remark_pc"].FormattedValue.ToString().Trim();
                }
            }
        }
        private void PC_DEVICES_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (PC_DEVICES_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    PC_DEVICES_dtgv.CurrentRow.Selected = true;
                    txt_hostname_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_hostname_pcdev"].FormattedValue.ToString().Trim();
                    cb_brand_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_brand_pcdev"].FormattedValue.ToString().Trim();
                    cb_model_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_model_pcdev"].FormattedValue.ToString().Trim();
                    txt_serial_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_serial_pcdev"].FormattedValue.ToString().Trim();
                    dt_invoice_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_invoice_pcdev"].FormattedValue.ToString().Trim();
                    dt_handover_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_handover_pcdev"].FormattedValue.ToString().Trim();
                    cb_warranty_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_warranty_pcdev"].FormattedValue.ToString().Trim();
                    cb_supplies_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_supplies_pcdev"].FormattedValue.ToString().Trim();
                    cb_location_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_location_pcdev"].FormattedValue.ToString().Trim();
                    txt_assetcode_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_assetcode_pcdev"].FormattedValue.ToString().Trim();
                    txt_username_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_username_pcdev"].FormattedValue.ToString().Trim();
                    txt_position_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_position_pcdev"].FormattedValue.ToString().Trim();
                    cb_memory_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_memory_pcdev"].FormattedValue.ToString().Trim();
                    cb_hdd_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_hdd_pcdev"].FormattedValue.ToString().Trim();
                    txt_remark_pc.Text = PC_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_remark_pcdev"].FormattedValue.ToString().Trim();
                }
            }
        }

        /*KHU VUC TAB MO*/

        // View to Object (MO_tab)
        public void MO_txtBoxToObj()
        {
            objMo.area = this.Text; //lay ten form (vdu:SGF)
            objMo.devices = tab_MO.Text; // lay ten tab MO
            objMo.location = cb_location_mo.Text;
            objMo.position = txt_position_mo.Text;
            objMo.username = txt_username_mo.Text;
            objMo.hostname = txt_hostname_mo.Text;
            objMo.brand = cb_brand_mo.Text;
            objMo.model = cb_model_mo.Text;
            objMo.serial = txt_serial_mo.Text;
            objMo.invoice_date = dt_invoice_mo.Value.ToString("yyyy/MM/dd");
            objMo.handover_date = dt_handover_mo.Value.ToString("yyyy/MM/dd");
            objMo.warranty = cb_warranty_mo.Text;
            objMo.supplies = cb_supplies_mo.Text;
            objMo.assetcode = txt_assetcode_mo.Text;
            objMo.remark = txt_remark_mo.Text;
        }

        //hien thi cho dataGridView o tab MO
        void MO_HienThi(MO obj)
        {
            objMo.area = this.Text;
            MO_DEVICES_dtgv.DataSource = busMo.GetData1(obj);
            MO_dtgv.DataSource = busMo.GetData2(obj);
        }

        // Chuc nang "Ban Giao" | "Thu Hoi" | "Chuyen Thiet Bi"
        private void MO_BT_Insert_Click(object sender, EventArgs e)
        {
            if (txt_serial_mo.Text != "")
            {
                MO_txtBoxToObj();
                busMo.Insert(objMo);
                MO_HienThi(objMo);
                MO_DEVICES_dtgv.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose Devices with serial");
            }
        }
        private void MO_BT_Delete_Click(object sender, EventArgs e)
        {
            objMo.serial = txt_serial_mo.Text;
            busMo.Delete(objMo);
            MO_HienThi(objMo);
            MO_DEVICES_dtgv.Refresh();
        }
        private void MO_BT_Change_Click(object sender, EventArgs e)
        {
            MO_txtBoxToObj();
            busMo.Change(objMo);
            MO_HienThi(objMo);
            MO_DEVICES_dtgv.Refresh();
        }

        // DataGridView tab_MO
        private void MO_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MO_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    MO_dtgv.CurrentRow.Selected = true;
                    txt_hostname_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_hostname_mo"].FormattedValue.ToString().Trim();
                    cb_brand_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_brand_mo"].FormattedValue.ToString().Trim();
                    cb_model_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_model_mo"].FormattedValue.ToString().Trim();
                    txt_serial_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_serial_mo"].FormattedValue.ToString().Trim();
                    dt_invoice_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_invoice_mo"].FormattedValue.ToString().Trim();
                    dt_handover_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_handover_mo"].FormattedValue.ToString().Trim();
                    cb_warranty_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_warranty_mo"].FormattedValue.ToString().Trim();
                    cb_supplies_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_supplies_mo"].FormattedValue.ToString().Trim();
                    cb_location_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_location_mo"].FormattedValue.ToString().Trim();
                    txt_assetcode_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_assetcode_mo"].FormattedValue.ToString().Trim();
                    txt_username_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_username_mo"].FormattedValue.ToString().Trim();
                    txt_position_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_position_mo"].FormattedValue.ToString().Trim();
                    txt_remark_mo.Text = MO_dtgv.Rows[e.RowIndex].Cells["col_remark_mo"].FormattedValue.ToString().Trim();
                }
            }
        }
        private void MO_DEVICES_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MO_DEVICES_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    MO_DEVICES_dtgv.CurrentRow.Selected = true;
                    txt_hostname_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_hostname_modev"].FormattedValue.ToString().Trim();
                    cb_brand_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_brand_modev"].FormattedValue.ToString().Trim();
                    cb_model_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_model_modev"].FormattedValue.ToString().Trim();
                    txt_serial_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_serial_modev"].FormattedValue.ToString().Trim();
                    dt_invoice_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_invoice_modev"].FormattedValue.ToString().Trim();
                    dt_handover_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_handover_modev"].FormattedValue.ToString().Trim();
                    cb_warranty_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_warranty_modev"].FormattedValue.ToString().Trim();
                    cb_supplies_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_supplies_modev"].FormattedValue.ToString().Trim();
                    cb_location_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_location_modev"].FormattedValue.ToString().Trim();
                    txt_assetcode_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_assetcode_modev"].FormattedValue.ToString().Trim();
                    txt_username_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_username_modev"].FormattedValue.ToString().Trim();
                    txt_position_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_position_modev"].FormattedValue.ToString().Trim();
                    txt_remark_mo.Text = MO_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_remark_modev"].FormattedValue.ToString().Trim();
                }
            }
        }

        /*KHU VUC TAB AP*/

        // View to Object (AP_tab)
        public void AP_txtBoxToObj()
        {
            objAp.area = this.Text; //lay ten form (vdu:SGF)
            objAp.devices = tab_AP.Text; // lay ten tab AP
            objAp.location = cb_location_ap.Text;
            objAp.username = txt_username_ap.Text;
            objAp.hostname = txt_hostname_ap.Text;
            objAp.brand = cb_brand_ap.Text;
            objAp.model = cb_model_ap.Text;
            objAp.serial = txt_serial_ap.Text;
            objAp.invoice_date = dt_invoice_ap.Value.ToString("yyyy/MM/dd");
            objAp.handover_date = dt_handover_ap.Value.ToString("yyyy/MM/dd");
            objAp.warranty = cb_warranty_ap.Text;
            objAp.supplies = cb_supplies_ap.Text;
            objAp.assetcode = txt_assetcode_ap.Text;
            objAp.remark = txt_remark_ap.Text;
            objAp.ip_addr = txt_ipaddress_ap.Text;
            objAp.login_name = txt_loginname_ap.Text;
            objAp.passwrd = txt_password_ap.Text;
        }

        //hien thi cho dataGridView o tab AP
        void AP_HienThi(AP obj)
        {
            objAp.area = this.Text;
            AP_DEVICES_dtgv.DataSource = busAp.GetData1(obj);
            AP_dtgv.DataSource = busAp.GetData2(obj);
        }

        // Chuc nang "Ban Giao" | "Thu Hoi" | "Chuyen Thiet Bi"
        private void AP_BT_Insert_Click(object sender, EventArgs e)
        {
            if (txt_serial_ap.Text != "")
            {
                AP_txtBoxToObj();
                busAp.Insert(objAp);
                AP_HienThi(objAp);
                AP_DEVICES_dtgv.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose Devices with serial");
            }
        }
        private void AP_BT_Delete_Click(object sender, EventArgs e)
        {
            objAp.serial = txt_serial_ap.Text;
            busAp.Delete(objAp);
            AP_HienThi(objAp);
            AP_DEVICES_dtgv.Refresh();
        }
        private void AP_BT_Change_Click(object sender, EventArgs e)
        {
            AP_txtBoxToObj();
            busAp.Change(objAp);
            AP_HienThi(objAp);
            AP_DEVICES_dtgv.Refresh();
        }

        // DataGridView tab_AP
        private void AP_DEVICES_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (AP_DEVICES_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    AP_DEVICES_dtgv.CurrentRow.Selected = true;
                    txt_hostname_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_hostname_apdev"].FormattedValue.ToString().Trim();
                    cb_brand_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_brand_apdev"].FormattedValue.ToString().Trim();
                    cb_model_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_model_apdev"].FormattedValue.ToString().Trim();
                    txt_serial_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_serial_apdev"].FormattedValue.ToString().Trim();
                    dt_invoice_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_invoice_apdev"].FormattedValue.ToString().Trim();
                    dt_handover_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_handover_apdev"].FormattedValue.ToString().Trim();
                    cb_warranty_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_warranty_apdev"].FormattedValue.ToString().Trim();
                    cb_supplies_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_supplies_apdev"].FormattedValue.ToString().Trim();
                    cb_location_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_location_apdev"].FormattedValue.ToString().Trim();
                    txt_assetcode_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_assetcode_apdev"].FormattedValue.ToString().Trim();
                    txt_username_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_username_apdev"].FormattedValue.ToString().Trim();
                    txt_remark_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_remark_apdev"].FormattedValue.ToString().Trim();
                    txt_ipaddress_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_ipaddress_apdev"].FormattedValue.ToString().Trim();
                    txt_loginname_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_loginname_apdev"].FormattedValue.ToString().Trim();
                    txt_password_ap.Text = AP_DEVICES_dtgv.Rows[e.RowIndex].Cells["col_password_apdev"].FormattedValue.ToString().Trim();
                }
            }
        }
        private void AP_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (AP_dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    AP_dtgv.CurrentRow.Selected = true;
                    txt_hostname_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_hostname_ap"].FormattedValue.ToString().Trim();
                    cb_brand_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_brand_ap"].FormattedValue.ToString().Trim();
                    cb_model_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_model_ap"].FormattedValue.ToString().Trim();
                    txt_serial_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_serial_ap"].FormattedValue.ToString().Trim();
                    dt_invoice_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_invoice_ap"].FormattedValue.ToString().Trim();
                    dt_handover_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_handover_ap"].FormattedValue.ToString().Trim();
                    cb_warranty_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_warranty_ap"].FormattedValue.ToString().Trim();
                    cb_supplies_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_supplies_ap"].FormattedValue.ToString().Trim();
                    cb_location_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_location_ap"].FormattedValue.ToString().Trim();
                    txt_assetcode_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_assetcode_ap"].FormattedValue.ToString().Trim();
                    txt_username_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_username_ap"].FormattedValue.ToString().Trim();
                    txt_remark_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_remark_ap"].FormattedValue.ToString().Trim();
                    txt_ipaddress_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_ipaddress_ap"].FormattedValue.ToString().Trim();
                    txt_loginname_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_loginname_ap"].FormattedValue.ToString().Trim();
                    txt_password_ap.Text = AP_dtgv.Rows[e.RowIndex].Cells["col_password_ap"].FormattedValue.ToString().Trim();
                }
            }
        }


        /*KHU VUC TAB AP*/

        // View to Object (CCTV_tab)
        public void CCTV_txtBoxToObj() 
        {
            objCctv.area = this.Text; //lay ten form (vdu:SGF)
            objCctv.devices = tab_CCTV.Text; // lay ten tab AP
            objCctv.location = cb_location_cctv.Text;
            objCctv.username = txt_username_cctv.Text;
            objCctv.hostname = txt_hostname_cctv.Text;
            objCctv.brand = cb_brand_cctv.Text;
            objCctv.model = cb_model_cctv.Text;
            objCctv.serial = txt_serial_cctv.Text;
            objCctv.invoice_date = dt_invoice_cctv.Value.ToString("yyyy/MM/dd");
            objCctv.handover_date = dt_handover_cctv.Value.ToString("yyyy/MM/dd");
            objCctv.warranty = cb_warranty_cctv.Text;
            objCctv.supplies = cb_supplies_cctv.Text;
            objCctv.assetcode = txt_assetcode_cctv.Text;
            objCctv.remark = txt_remark_cctv.Text;
            objCctv.ip_addr = txt_ipaddress_ap.Text;
            objCctv.dns = txt_dns_cctv.Text;
            objCctv.defaultgw = txt_defaultgw_cctv.Text;
        }

        //hien thi cho dataGridView o tab CCTV
        void CCTV_HienThi(CCTV obj)
        {
            objCctv.area = this.Text;
            CCTV_DEVICES_dtgv.DataSource = busCctv.GetData1(obj);
            CCTV_dtgv.DataSource = busCctv.GetData2(obj);
        }

        private void CCTV_BT_Insert_Click(object sender, EventArgs e)
        {

        }

        private void CCTV_BT_Delete_Click(object sender, EventArgs e)
        {

        }

        private void CCTV_BT_Change_Click(object sender, EventArgs e)
        {
            
        }


        ////////////////////////////////////////// form lam nhanh  /////////////////////////////////////////////
        
        public void UpdateForm(string update)
        {
            if (update == "update")
            {
                HienThiDataGridView2(SQLQuery);
                dataGridView2.Refresh();
            }
        }
        
        public void HienThiDataGridView2(string SQL)
        {
            dataGridView2.DataSource = busDevices.GetDataOriginal(SQL);
        }

        private void MrC_BT_Search_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;

            string filter = "";
            if (rbt_And_Check.Checked == true)
            {
                if (!string.IsNullOrEmpty(cb_Area_MrC.Text))
                {
                    filter += "DAREA" /*+ dataGridView2.Columns["col_mrc_area"].HeaderText.ToString()*/ + " LIKE '%" + cb_Area_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Devices_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND "; // dk AND
                    filter += "DTYPE" + " LIKE '%" + cb_Devices_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Brand_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "BRAND" /*dataGridView2.Columns["col_mrc_brand"].HeaderText.ToString()*/ + " LIKE '%" + cb_Brand_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Supplier_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "SUPPLIES" + " LIKE '%" + cb_Supplier_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Position_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += /*dataGridView2.Columns["col_mrc_position"].HeaderText.ToString()*/ "POSITION" + " LIKE '%" + cb_Position_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(txt_UserName_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "USRNAME" + " LIKE '%" + txt_UserName_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(txt_Serial_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "SERIAL" + " LIKE '%" + txt_Serial_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Status_MrC.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "DSTATUS" + " LIKE '%" + cb_Status_MrC.Text.Trim() + "%' ";
                }
            }

            // radiobutton search tuong doi
            if(rbt_Or_Check.Checked == true)
            {
                if (!string.IsNullOrEmpty(cb_Area_MrC.Text))
                {
                    filter += "DAREA" /*+ dataGridView2.Columns["col_mrc_area"].HeaderText.ToString()*/ + " LIKE '%" + cb_Area_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Devices_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR "; // dk AND
                    filter += "DTYPE" + " LIKE '%" + cb_Devices_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Brand_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "BRAND" /*dataGridView2.Columns["col_mrc_brand"].HeaderText.ToString()*/ + " LIKE '%" + cb_Brand_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Supplier_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "SUPPLIES" + " LIKE '%" + cb_Supplier_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Position_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += /*dataGridView2.Columns["col_mrc_position"].HeaderText.ToString()*/ "POSITION" + " LIKE '%" + cb_Position_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(txt_UserName_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "USRNAME" + " LIKE '%" + txt_UserName_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(txt_Serial_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "SERIAL" + " LIKE '%" + txt_Serial_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Status_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "DSTATUS" + " LIKE '%" + cb_Status_MrC.Text.Trim() + "%' ";
                }
            }
            bs.Filter = filter;
            dataGridView2.DataSource = bs;
            // dem dong
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
        }

        public void loadcb_Area()
        {
            cb_Area_MrC.DataSource = busDevices.GetData4Cb_Area();
            cb_Area_MrC.DisplayMember = "darea".Trim();
        }
        public void loadcb_Devices()
        {
            cb_Devices_MrC.DataSource = busDevices.GetData4Cb_Devices();
            cb_Devices_MrC.DisplayMember = "dtype".Trim();
        }
        public void loadcb_Supplier()
        {
            cb_Supplier_MrC.DataSource = busDevices.GetData4Cb_Supplier();
            cb_Supplier_MrC.DisplayMember = "supplies".Trim();
        }
        public void loadcb_Brand()
        {
            cb_Brand_MrC.DataSource = busDevices.GetData4Cb_Brand();
            cb_Brand_MrC.DisplayMember = "brand".Trim();
        }
        public void loadcb_Position()
        {
            cb_Position_MrC.DataSource = busDevices.GetData4Cb_Position();
            cb_Position_MrC.DisplayMember = "position".Trim();
        }
        public void loadcb_Status()
        {
            cb_Status_MrC.DataSource = busDevices.GetData4Cb_Status();
            cb_Status_MrC.DisplayMember = "dstatus".Trim();
        }


        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            // delete 1 dong
            busDevices.Delete(objDevices);
            dataGridView2.Refresh();
            loadcb_Area();
            loadcb_Brand();
            loadcb_Devices();
            loadcb_Position();
            loadcb_Supplier();
            loadcb_Status();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Current_Cell = "";
            //Check_Cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            Current_Cell = this.dataGridView2.CurrentCell.FormattedValue.ToString();

            if (e.RowIndex >= 0)
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView2.CurrentRow.Selected = true;
                    objDevices.hostname = dataGridView2.Rows[e.RowIndex].Cells["col_hostname_MrC"].FormattedValue.ToString().Trim();
                    objDevices.brand = dataGridView2.Rows[e.RowIndex].Cells["col_brand_MrC"].FormattedValue.ToString().Trim();
                    objDevices.model = dataGridView2.Rows[e.RowIndex].Cells["col_model_MrC"].FormattedValue.ToString().Trim();
                    objDevices.serial = dataGridView2.Rows[e.RowIndex].Cells["col_serial_MrC"].FormattedValue.ToString().Trim();
                    objDevices.invoice_date = dataGridView2.Rows[e.RowIndex].Cells["col_invoice_MrC"].FormattedValue.ToString().Trim();
                    objDevices.handover_date = dataGridView2.Rows[e.RowIndex].Cells["col_handover_MrC"].FormattedValue.ToString().Trim();
                    objDevices.warranty = dataGridView2.Rows[e.RowIndex].Cells["col_warranty_MrC"].FormattedValue.ToString().Trim();
                    objDevices.supplies = dataGridView2.Rows[e.RowIndex].Cells["col_supplies_MrC"].FormattedValue.ToString().Trim();
                    objDevices.location = dataGridView2.Rows[e.RowIndex].Cells["col_location_MrC"].FormattedValue.ToString().Trim();
                    objDevices.assetcode = dataGridView2.Rows[e.RowIndex].Cells["col_assetcode_MrC"].FormattedValue.ToString().Trim();
                    objDevices.usrname = dataGridView2.Rows[e.RowIndex].Cells["col_username_MrC"].FormattedValue.ToString().Trim();
                    objDevices.position = dataGridView2.Rows[e.RowIndex].Cells["col_position_MrC"].FormattedValue.ToString().Trim();
                    objDevices.remark = dataGridView2.Rows[e.RowIndex].Cells["col_remark_MrC"].FormattedValue.ToString().Trim();

                    objDevices.memory = dataGridView2.Rows[e.RowIndex].Cells["col_memory_MrC"].FormattedValue.ToString().Trim();
                    objDevices.hdd = dataGridView2.Rows[e.RowIndex].Cells["col_hdd_MrC"].FormattedValue.ToString().Trim();
                    objDevices.darea = dataGridView2.Rows[e.RowIndex].Cells["col_darea_MrC"].FormattedValue.ToString().Trim();
                    objDevices.dstatus = dataGridView2.Rows[e.RowIndex].Cells["col_dstatus_MrC"].FormattedValue.ToString().Trim();
                    objDevices.log_name = dataGridView2.Rows[e.RowIndex].Cells["col_logname_MrC"].FormattedValue.ToString().Trim();
                    objDevices.passwrd = dataGridView2.Rows[e.RowIndex].Cells["col_password_MrC"].FormattedValue.ToString().Trim();
                    objDevices.mac_addr = dataGridView2.Rows[e.RowIndex].Cells["col_macaddr_MrC"].FormattedValue.ToString().Trim();
                    objDevices.ip_addr = dataGridView2.Rows[e.RowIndex].Cells["col_ipaddr_MrC"].FormattedValue.ToString().Trim();
                    objDevices.dns = dataGridView2.Rows[e.RowIndex].Cells["col_dns_MrC"].FormattedValue.ToString().Trim();
                    objDevices.default_gw = dataGridView2.Rows[e.RowIndex].Cells["col_defaultgw_MrC"].FormattedValue.ToString().Trim();
                    objDevices.dtype = dataGridView2.Rows[e.RowIndex].Cells["col_devices_MrC"].FormattedValue.ToString().Trim();

                    HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Updated_Cell = "";
            Updated_Cell = this.dataGridView2.CurrentCell.FormattedValue.ToString();
            if (HeaderSelectedCell != "SERIAL")
            {
                if (Current_Cell != Updated_Cell)
                {
                    if (HeaderSelectedCell == "INVOICE_DATE" || HeaderSelectedCell == "HANDOVER_DATE")
                    {
                        string ConvertDate = "convert(date,'" + Updated_Cell + "',105)";
                        busDevices.Change("update [DEVICES_TBL] SET " + HeaderSelectedCell + " = " + ConvertDate + " where SERIAL = '" + objDevices.serial + "'");
                    }
                    else
                    {
                        busDevices.Change("update [DEVICES_TBL] SET " + HeaderSelectedCell + " = '" + Updated_Cell + "' where SERIAL = '" + objDevices.serial + "'");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được chỉnh sửa Serial của thiết bị");
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Current_Cell;
            }
        }



        private void OnCallBack(object sender, EventArgs args)
        {
            // put your process here
        }
        public delegate void SetParameterValueDelegate(string value);
        private void bt_Insert_MrC_Click(object sender, EventArgs e)
        {
            // refresh form (Hiện đang kich hoạt bên form AM_Main_Form
            //Add_New FormAddNew = new Add_New();
            //FormAddNew.RefreshDtgvCallback = new RefreshDtgvDelegate(this.Refresh_dtgv_Fn);
            //FormAddNew.Show();
        }
        public SetParameterValueDelegate SetParameterValueCallback;
        public delegate void RefreshDtgvDelegate();
        private void Refresh_dtgv_Fn()
        {
            Refesh_dtgv();
        }

        public void Refesh_dtgv()
        {
            HienThiDataGridView2(SQLQuery);
            dataGridView2.Refresh();
        }

        private void bt_Refresh_MrC_Click(object sender, EventArgs e)
        {
            Refesh_dtgv();
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";

            loadcb_Area();
            loadcb_Brand();
            loadcb_Devices();
            loadcb_Position();
            loadcb_Supplier();
            loadcb_Status();
        }

        private void MrC_BT_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckTenDangNhap(string tendangnhap)//check ten dang nhap tu form dang nhap truyen vao
        {
            SFG SGF_Form_Name = new SFG();
            SGF_Form_Name.Text = tendangnhap.ToString();
        }
    }
}
