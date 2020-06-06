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
using Microsoft.Office.Interop.Excel;

namespace Asset_Management_Alpha
{
    public partial class AM_Main_Form : Form
    {
        public AM_Main_Form()
        {
            InitializeComponent();
        }

        #region Var and Object
        Devices objDevices = new Devices();
        DevicesBUS busDevices = new DevicesBUS();

        string SQLQuery = "Select * from DEVICES_TBL";
        string Current_Cell;
        string Updated_Cell;
        string HeaderSelectedCell;
        #endregion

        #region Check on Form
        private void AM_Main_Form_Load(object sender, EventArgs e)
        {
            /* fix loi Frozen column phai insert Datasource vao
            // TODO: This line of code loads data into the 'qLVT_testDataSet1.DEVICES_TBL' table. You can move, or remove it, as needed.
            //this.dEVICES_TBLTableAdapter.Fill(this.qLVT_testDataSet1.DEVICES_TBL);
            */
            
            //connect database
            TestRegister();

            //MrC_XuLi();
            HienThiDataGridView2(SQLQuery);
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";

            // hien thi cb box
            loadcb_Area();
            loadcb_Devices_By_Area();
            loadcb_Brand_By_DType();
            //loadcb_Brand();
            //loadcb_Devices();
            loadcb_Position();
            //loadcb_Supplier();
            loadcb_Supplier_By_DType();
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

        public void CheckTenDangNhap(string tendangnhap)//check ten dang nhap tu form dang nhap truyen vao
        {
            SFG SGF_Form_Name = new SFG();
            SGF_Form_Name.Text = tendangnhap.ToString();
        }

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

        #endregion

        #region load combobox
        public void loadcb_Area()
        {
            cb_Area_MrC.DataSource = busDevices.GetData4Cb_Area();
            cb_Area_MrC.DisplayMember = "darea".Trim();
        }
        public void loadcb_Devices()
        {
            cb_Devices_MrC.DataSource = busDevices.GetData4Cb_Devices();
            cb_Devices_MrC.DisplayMember = "DEVICE_TYPE".Trim();
        }
        public void loadcb_Devices_By_Area()
        {
            objDevices.darea = cb_Area_MrC.Text;
            cb_Devices_MrC.DataSource = busDevices.GetData4Cb_Devices_By_Area(objDevices);
            cb_Devices_MrC.DisplayMember = "DEVICE_TYPE".Trim();
        }

        public void loadcb_Brand()
        {
            cb_Brand_MrC.DataSource = busDevices.GetData4Cb_Brand();
            cb_Brand_MrC.DisplayMember = "brand".Trim();
        }

        public void loadcb_Brand_By_DType()
        {
            objDevices.dtype = cb_Devices_MrC.Text;
            cb_Brand_MrC.DataSource = busDevices.GetData4Cb_Brand_By_Dtype(objDevices);
            cb_Brand_MrC.DisplayMember = "BRAND".Trim();
        }

        public void loadcb_Brand_By_Area()
        {
            objDevices.darea = cb_Area_MrC.Text;
            cb_Brand_MrC.DataSource = busDevices.GetData4Cb_Brand_By_Area(objDevices);
            cb_Brand_MrC.DisplayMember = "BRAND".Trim();
        }

        public void loadcb_Supplier()
        {
            cb_Supplier_MrC.DataSource = busDevices.GetData4Cb_Supplier();
            cb_Supplier_MrC.DisplayMember = "SUPPLIER".Trim();
        }

        public void loadcb_Supplier_By_DType()
        {
            objDevices.dtype = cb_Devices_MrC.Text;
            cb_Supplier_MrC.DataSource = busDevices.GetData4Cb_Supplier_By_Dtype(objDevices);
            cb_Supplier_MrC.DisplayMember = "SUPPLIER".Trim();
        }
        public void loadcb_Suppier_By_Area()
        {
            objDevices.darea = cb_Area_MrC.Text;
            cb_Supplier_MrC.DataSource = busDevices.GetData4Cb_Supplier_By_Area(objDevices);
            cb_Supplier_MrC.DisplayMember = "SUPPLIER".Trim();
        }

        public void loadcb_Position()
        {
            cb_Position_MrC.DataSource = busDevices.GetData4Cb_Position();
            cb_Position_MrC.DisplayMember = "DEPARTMENT".Trim();
        }
        public void loadcb_Status()
        {
            cb_Status_MrC.DataSource = busDevices.GetData4Cb_Status();
            cb_Status_MrC.DisplayMember = "dstatus".Trim();
        }

        #endregion

        #region Function on Form

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // lam gon chuoi nvchar o SQL khi hien thi len dataGridView2
            string str_name = null;
            str_name = dataGridView2.Columns[e.ColumnIndex].Name.ToString().Trim();
            dataGridView2.Rows[e.RowIndex].Cells[str_name].Value = dataGridView2.Rows[e.RowIndex].Cells[str_name].FormattedValue.ToString().Trim();
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
                    cb_Brand_MrC.Text = objDevices.brand = dataGridView2.Rows[e.RowIndex].Cells["col_brand_MrC"].FormattedValue.ToString().Trim();
                    objDevices.model = dataGridView2.Rows[e.RowIndex].Cells["col_model_MrC"].FormattedValue.ToString().Trim();
                    txt_Serial_MrC.Text = objDevices.serial = dataGridView2.Rows[e.RowIndex].Cells["col_serial_MrC"].FormattedValue.ToString().Trim();
                    objDevices.invoice_date = dataGridView2.Rows[e.RowIndex].Cells["col_invoice_MrC"].FormattedValue.ToString().Trim();
                    objDevices.handover_date = dataGridView2.Rows[e.RowIndex].Cells["col_handover_MrC"].FormattedValue.ToString().Trim();
                    objDevices.warranty = dataGridView2.Rows[e.RowIndex].Cells["col_warranty_MrC"].FormattedValue.ToString().Trim();
                    cb_Supplier_MrC.Text = objDevices.supplies = dataGridView2.Rows[e.RowIndex].Cells["col_supplies_MrC"].FormattedValue.ToString().Trim();
                    objDevices.location = dataGridView2.Rows[e.RowIndex].Cells["col_location_MrC"].FormattedValue.ToString().Trim();
                    objDevices.assetcode = dataGridView2.Rows[e.RowIndex].Cells["col_assetcode_MrC"].FormattedValue.ToString().Trim();
                    txt_UserName_MrC.Text = objDevices.username = dataGridView2.Rows[e.RowIndex].Cells["col_username_MrC"].FormattedValue.ToString().Trim();
                    cb_Position_MrC.Text = objDevices.position = dataGridView2.Rows[e.RowIndex].Cells["col_position_MrC"].FormattedValue.ToString().Trim();
                    objDevices.remarks = dataGridView2.Rows[e.RowIndex].Cells["col_remark_MrC"].FormattedValue.ToString().Trim();

                    objDevices.ram = dataGridView2.Rows[e.RowIndex].Cells["col_memory_MrC"].FormattedValue.ToString().Trim();//memory > ram
                    objDevices.hdd = dataGridView2.Rows[e.RowIndex].Cells["col_hdd_MrC"].FormattedValue.ToString().Trim();
                    cb_Area_MrC.Text = objDevices.darea = dataGridView2.Rows[e.RowIndex].Cells["col_darea_MrC"].FormattedValue.ToString().Trim();
                    cb_Status_MrC.Text = objDevices.dstatus = dataGridView2.Rows[e.RowIndex].Cells["col_dstatus_MrC"].FormattedValue.ToString().Trim();
                    objDevices.log_name = dataGridView2.Rows[e.RowIndex].Cells["col_logname_MrC"].FormattedValue.ToString().Trim();
                    objDevices.password = dataGridView2.Rows[e.RowIndex].Cells["col_password_MrC"].FormattedValue.ToString().Trim();
                    objDevices.mac_addr = dataGridView2.Rows[e.RowIndex].Cells["col_macaddr_MrC"].FormattedValue.ToString().Trim();
                    objDevices.ip_addr = dataGridView2.Rows[e.RowIndex].Cells["col_ipaddr_MrC"].FormattedValue.ToString().Trim();
                    objDevices.dns = dataGridView2.Rows[e.RowIndex].Cells["col_dns_MrC"].FormattedValue.ToString().Trim();
                    objDevices.default_gw = dataGridView2.Rows[e.RowIndex].Cells["col_defaultgw_MrC"].FormattedValue.ToString().Trim();
                    objDevices.dtype = dataGridView2.Rows[e.RowIndex].Cells["col_devices_MrC"].FormattedValue.ToString().Trim();
                    objDevices.Price = dataGridView2.Rows[e.RowIndex].Cells["col_Price_MrC"].FormattedValue.ToString().Trim();

                    HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
                }
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Updated_Cell = "";
            Updated_Cell = this.dataGridView2.CurrentCell.FormattedValue.ToString();
            HeaderSelectedCell = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.ToString().Trim();

            if (HeaderSelectedCell != "SERIAL" && HeaderSelectedCell != null)
            {
                if (Current_Cell.Trim() != Updated_Cell.Trim())
                {
                    if (HeaderSelectedCell == "INVOICE_DATE" || HeaderSelectedCell == "HANDOVER_DATE")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to change " + HeaderSelectedCell + "\n from: [ " + Current_Cell.Trim() + " ] to: [ " + Updated_Cell + " ]\n which serial number: " + txt_Serial_MrC.Text, "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                          string ConvertDate = "convert(date,'" + Updated_Cell + "',105)";
                          busDevices.Change("update [DEVICES_TBL] SET " + HeaderSelectedCell + " = " + ConvertDate + " where SERIAL = '" + objDevices.serial + "'");
                          MessageBox.Show("Cập nhật " + HeaderSelectedCell + " thành công");
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
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to change " + HeaderSelectedCell + "\n from: [ " + Current_Cell.Trim() + " ] to: [ " + Updated_Cell + " ]\n which serial number: " + txt_Serial_MrC.Text, "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            busDevices.Change("update [DEVICES_TBL] SET " + HeaderSelectedCell + " = N'" + Updated_Cell + "' where SERIAL = '" + objDevices.serial + "'");
                            MessageBox.Show("Cập nhật " + HeaderSelectedCell + " thành công");
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
            else
            {
                MessageBox.Show("Không được chỉnh sửa Serial của thiết bị");
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Current_Cell;
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // delete 1 dong
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thiết bị có Serial [" + objDevices.serial + "] Không?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.RemoveAt(row.Index);
                    }
                    busDevices.Delete(objDevices);
                    dataGridView2.Refresh();
                    loadcb_Area();
                    loadcb_Brand_By_DType();
                    //loadcb_Brand();
                    loadcb_Devices_By_Area();
                    //loadcb_Devices();
                    loadcb_Position();
                    loadcb_Supplier_By_DType();
                    //loadcb_Supplier();
                    loadcb_Status();
                    label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataGridView2.Refresh();
                }
            }
        }

        public delegate void SetParameterValueDelegate(string value);
        private void bt_Insert_MrC_Click(object sender, EventArgs e)
        {
            Add_New FormAddNew = new Add_New();
            FormAddNew.RefreshDtgvCallback = new RefreshDtgvDelegate(this.Refresh_dtgv_Fn);
            FormAddNew.Show();
        }
        public SetParameterValueDelegate SetParameterValueCallback;
        public delegate void RefreshDtgvDelegate();
        private void Refresh_dtgv_Fn()
        {
            Refesh_dtgv();
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
        }

        public void Refesh_dtgv()
        {
            // co the se sua code lai
            HienThiDataGridView2(SQLQuery);
            dataGridView2.Refresh();
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
        }

        private void MrC_BT_Search_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;

            string filter = "";
            if (rbt_And_Check.Checked == true)
            {
                if (chk_Area.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Area_MrC.Text))
                    {
                        filter += "DAREA" /*+ dataGridView2.Columns["col_mrc_area"].HeaderText.ToString()*/ + " LIKE '" + cb_Area_MrC.Text.Trim() + "' ";
                    }
                }
                if (chk_Devices.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Devices_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND "; // dk AND
                        filter += "DEVICE_TYPE" + " LIKE '" + cb_Devices_MrC.Text.Trim() + "' ";
                    }
                }
                if(chk_Brand.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Brand_MrC.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(cb_Brand_MrC.Text))
                        {
                            if (filter.Length > 0) filter += "AND ";
                            filter += "BRAND" /*dataGridView2.Columns["col_mrc_brand"].HeaderText.ToString()*/ + " LIKE '" + cb_Brand_MrC.Text.Trim() + "' ";
                        }
                    }
                }
                if(chk_Supplier.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Supplier_MrC.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(cb_Supplier_MrC.Text))
                        {
                            if (filter.Length > 0) filter += "AND ";
                            filter += "SUPPLIER" + " LIKE '" + cb_Supplier_MrC.Text.Trim() + "' ";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(cb_Position_MrC.Text))
                {
                    if (!string.IsNullOrWhiteSpace(cb_Position_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND ";
                        filter += /*dataGridView2.Columns["col_mrc_position"].HeaderText.ToString()*/ "DEPARTMENT" + " LIKE '" + cb_Position_MrC.Text.Trim() + "' ";
                    }
                }
                if (!string.IsNullOrEmpty(txt_UserName_MrC.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txt_UserName_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND ";
                        filter += "USERNAME" + " LIKE '%" + txt_UserName_MrC.Text.Trim() + "%' ";
                    }
                }
                if (!string.IsNullOrEmpty(txt_Serial_MrC.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txt_Serial_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND ";
                        filter += "SERIAL" + " LIKE '" + txt_Serial_MrC.Text.Trim() + "' ";
                    }
                }
                if (!string.IsNullOrEmpty(cb_Status_MrC.Text))
                {
                    if(!string.IsNullOrWhiteSpace(cb_Status_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND ";
                        filter += "DSTATUS" + " LIKE '" + cb_Status_MrC.Text.Trim() + "' ";
                    }
                }
            }

            // radiobutton search tuong doi
            if (rbt_Or_Check.Checked == true)
            {
                if (chk_Area.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Area_MrC.Text))
                    {
                        filter += "DAREA" /*+ dataGridView2.Columns["col_mrc_area"].HeaderText.ToString()*/ + " LIKE '" + cb_Area_MrC.Text.Trim() + "' ";
                    }
                }
                if (chk_Devices.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Devices_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "AND "; // dk AND
                        filter += "DEVICE_TYPE" + " LIKE '" + cb_Devices_MrC.Text.Trim() + "' ";
                    }
                }
                if (chk_Brand.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Brand_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "OR ";
                        filter += "BRAND" /*dataGridView2.Columns["col_mrc_brand"].HeaderText.ToString()*/ + " LIKE '" + cb_Brand_MrC.Text.Trim() + "' ";
                    }
                }
                if (chk_Supplier.Checked == false)
                {
                    if (!string.IsNullOrEmpty(cb_Supplier_MrC.Text))
                    {
                        if (filter.Length > 0) filter += "OR ";
                        filter += "SUPPLIER" + " LIKE '" + cb_Supplier_MrC.Text.Trim() + "' ";
                    }
                }
                if (!string.IsNullOrEmpty(cb_Position_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += /*dataGridView2.Columns["col_mrc_position"].HeaderText.ToString()*/ "DEPARTMENT" + " LIKE '" + cb_Position_MrC.Text.Trim() + "' ";
                }
                if (!string.IsNullOrEmpty(txt_UserName_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "USERNAME" + " LIKE '%" + txt_UserName_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(txt_Serial_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "SERIAL" + " LIKE '%" + txt_Serial_MrC.Text.Trim() + "%' ";
                }
                if (!string.IsNullOrEmpty(cb_Status_MrC.Text))
                {
                    if (filter.Length > 0) filter += "OR ";
                    filter += "DSTATUS" + " LIKE '" + cb_Status_MrC.Text.Trim() + "' ";
                }
            }
            bs.Filter = filter;
            dataGridView2.DataSource = bs;
            // dem dong
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
        }

        private void MrC_BT_Cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // do co Excel nene them "System.Windows.Forms"
        }

        private void bt_Refresh_MrC_Click(object sender, EventArgs e)
        {
            Refesh_dtgv();
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";

            loadcb_Area();
            loadcb_Brand_By_DType();
            //loadcb_Brand();
            loadcb_Position();
            loadcb_Supplier_By_DType();
            //loadcb_Supplier();
            loadcb_Status();

            // neu check thi hien thi het cac sheet cua cac area
            if (chk_Area.Checked == true)
            {
                cb_Area_MrC.Enabled = false;
                loadcb_Devices();
            }
            else
            {
                cb_Area_MrC.Enabled = true;
                loadcb_Devices_By_Area();
            }
        }
        private void txt_Serial_MrC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Serial_MrC.CharacterCasing = CharacterCasing.Upper;
                txt_Serial_MrC.Text = txt_Serial_MrC.Text.Trim();
                // code dua con tro ve cuoi
                txt_Serial_MrC.Focus();
                txt_Serial_MrC.SelectionStart = txt_Serial_MrC.Text.Length;
            }
        }

        #endregion

        private void chk_Area_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Area.Checked == true)
            {
                cb_Area_MrC.Enabled = false;
                loadcb_Devices();
                chk_Brand.Checked = true;
                chk_Supplier.Checked = true;
            }
            else
            {
                cb_Area_MrC.Enabled = true;
                loadcb_Devices_By_Area();
                chk_Brand.Checked = false;
                chk_Supplier.Checked = false;
            }
        }

        private void cb_Area_MrC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chk_Devices.Checked == false)
            {
                loadcb_Devices_By_Area();
            }
            else
            {
                loadcb_Brand_By_Area();
                loadcb_Suppier_By_Area();
            }
        }

        private void cb_Devices_MrC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcb_Brand_By_DType();
            loadcb_Supplier_By_DType();
        }

        private void chk_Devices_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Devices.Checked == true)
            {
                cb_Devices_MrC.Enabled = false;
                loadcb_Brand_By_Area();
                loadcb_Suppier_By_Area();
            }
            else
            {
                cb_Devices_MrC.Enabled = true;
                loadcb_Devices_By_Area();
            }
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Server_Form FormServer = new Server_Form();
            FormServer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Add_NV FrmNV = new Form_Add_NV();
            FrmNV.Show();
        }

        private void btn_Network_Click(object sender, EventArgs e)
        {
            Network_Form frmNetwork = new Network_Form();
            frmNetwork.Show();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"]; //hien thi ten sheet theo ten combobox Device
            worksheet = workbook.ActiveSheet;
            worksheet.Name = cb_Devices_MrC.Text;
            
            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderCell.Value;
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = String.Empty;
                    }
                }
                lb_Loading2Excel.Text = "Loading: " + i;
            }

            lb_Loading2Excel.Text = "Done";
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "ASSET MANAGEMENT EXCEL";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel Worksheets 2007(*.xlsx)|*.xlsx|Excel Worksheets 2003(*.xls)|*.xls|Word Documents(*.doc)|*.doc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
            lb_Loading2Excel.Text = "";
        }
    }
}
