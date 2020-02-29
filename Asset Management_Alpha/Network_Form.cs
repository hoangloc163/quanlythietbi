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

namespace Asset_Management_Alpha
{
    public partial class Network_Form : Form
    {
        public Network_Form()
        {
            InitializeComponent();
        }
        Network objnetwork = new Network();
        NetworkBUS busnetwork = new NetworkBUS();

        private void Network_Form_Load(object sender, EventArgs e)
        {
            LoadDatagridview();
        }
        void LoadDatagridview()
        {
            btn_Add.DataSource = busnetwork.GetData();
            btn_Add.Refresh();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
