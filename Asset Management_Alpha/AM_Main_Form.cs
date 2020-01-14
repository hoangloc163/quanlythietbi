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
            //connect database
            TestRegister();

            //MrC_XuLi();
            HienThiDataGridView2(SQLQuery);
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";

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
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\QLVT_test");
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
        #endregion

        #region Function on Form
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
            label97.Text = dataGridView2.Rows.Count.ToString() + " Rows";
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
            if (rbt_Or_Check.Checked == true)
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

        private void MrC_BT_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        #endregion
    }
}
