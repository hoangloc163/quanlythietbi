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
    public partial class Form_Add_NV : Form
    {
        public Form_Add_NV()
        {
            InitializeComponent();
        }

        NhanVien objnhanvien = new NhanVien();
        NhanVienBUS busnhanvien = new NhanVienBUS();
        int RowsIndex;
        int ColumnsIndex;

        private void Form_Add_NV_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        void loadDataGridView()
        {
            dataGridView1.DataSource = busnhanvien.GetData();
            lb_Rows.Text = dataGridView1.Rows.Count.ToString() + " Rows";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_matkhau.Enabled = false;
                btn_Add.Enabled = false;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    objnhanvien.manhanvien = txt_manhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells["col_manhanvien"].FormattedValue.ToString().Trim();
                    objnhanvien.tennhanvien = txt_tennhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells["col_tennhanvien"].FormattedValue.ToString().Trim();
                    objnhanvien.tendangnhap= txt_tendangnhap.Text = dataGridView1.Rows[e.RowIndex].Cells["col_tendangnhap"].FormattedValue.ToString().Trim();
                    objnhanvien.matkhau = txt_matkhau.Text = dataGridView1.Rows[e.RowIndex].Cells["col_matkhau"].FormattedValue.ToString().Trim();
                    //objnhanvien.matkhau = busnhanvien.Mahoa(objnhanvien);
                    objnhanvien.phongban = txt_phongban.Text = dataGridView1.Rows[e.RowIndex].Cells["col_phongban"].FormattedValue.ToString().Trim();
                    objnhanvien.permission = cb_permission.Text = dataGridView1.Rows[e.RowIndex].Cells["col_permission"].FormattedValue.ToString().Trim();

                    RowsIndex = e.RowIndex;
                    ColumnsIndex = e.ColumnIndex;
                }
            }
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            if (objnhanvien.manhanvien != "" && objnhanvien.manhanvien != null)
            { 
                string messages = "";
            objnhanvien.matkhau = txt_DefaultPassword.Text;
            objnhanvien.matkhau = busnhanvien.Mahoa(objnhanvien);

            messages = busnhanvien.ResetPass(objnhanvien, messages);
            if (messages == "Reset Password Successful")
            {
                txt_matkhau.Clear();
                MessageBox.Show(messages);

                string str_name = null;
                str_name = dataGridView1.Columns[3].Name.ToString().Trim();
                dataGridView1.Rows[RowsIndex].Cells[str_name].Value = objnhanvien.matkhau.ToString().Trim();
            }
            } 
            else
            {
                MessageBox.Show("Vui lòng chọn 1 user để Reset password");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_manhanvien.Text != null && txt_manhanvien.Text != "")
            { 
                txtboxToObj();
                string messages = "";
                messages = busnhanvien.Add(objnhanvien, messages);
                if (messages == "Đã nhập thành công")
                {
                    MessageBox.Show(messages);
                    loadDataGridView();
                    dataGridView1.Refresh();
                    lb_Rows.Text = dataGridView1.Rows.Count.ToString() + " Rows";
                }
                else
                {
                    MessageBox.Show(messages);
                }
            }
            else
            {
                MessageBox.Show("Nhập mã Nhân Viên");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa User có mã: " + objnhanvien.manhanvien, "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string message = "";
                objnhanvien.manhanvien = txt_manhanvien.Text;
                message = busnhanvien.Delete(objnhanvien, message);
                loadDataGridView();
                dataGridView1.Refresh();
                lb_Rows.Text = dataGridView1.Rows.Count.ToString() + " Rows";
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            string messages = "";
            objnhanvien.manhanvien = txt_manhanvien.Text;
            objnhanvien.tennhanvien = txt_tennhanvien.Text;
            objnhanvien.tendangnhap = txt_tendangnhap.Text;
            objnhanvien.phongban = txt_phongban.Text;
            objnhanvien.permission = cb_permission.Text;
            messages = busnhanvien.Change(objnhanvien,messages);
            if (messages == "Thay đổi thành công")
            {
                MessageBox.Show(messages);
                loadDataGridView();
            }
        }

        void txtboxToObj()
        {
            objnhanvien.manhanvien = txt_manhanvien.Text;
            objnhanvien.tennhanvien = txt_tennhanvien.Text;
            objnhanvien.tendangnhap = txt_tendangnhap.Text;
            objnhanvien.matkhau = txt_matkhau.Text;
            objnhanvien.phongban = txt_phongban.Text;
            objnhanvien.permission = cb_permission.Text;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Xóa User có mã: " + objnhanvien.manhanvien, "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                    string message = "";
                    objnhanvien.manhanvien = txt_manhanvien.Text;
                    message = busnhanvien.Delete(objnhanvien, message);
                    dataGridView1.Refresh();
                    lb_Rows.Text = dataGridView1.Rows.Count.ToString() + " Rows";
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataGridView1.Refresh();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                txt_matkhau.Enabled = true;
                btn_Add.Enabled = true;
                txt_manhanvien.Clear();
                txt_tennhanvien.Clear();
                txt_tendangnhap.Clear();
                txt_matkhau.Clear();
                txt_phongban.Clear();
            }
        }

        private void txt_manhanvien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objnhanvien.manhanvien = txt_manhanvien.Text;
                dataGridView1.DataSource = busnhanvien.Search(objnhanvien);
                dataGridView1.Refresh();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            objnhanvien.manhanvien = txt_manhanvien.Text;
            dataGridView1.DataSource = busnhanvien.Search(objnhanvien);
            dataGridView1.Refresh();
        }
    }
}
