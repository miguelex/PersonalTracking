using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDeparment frm = new FrmDeparment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDeparment frm = new FrmDeparment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        List<Department> list = new List<Department>();
        private void FrmDepartmentList_Load(object sender, EventArgs e)
        {
            
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Name = "Department ID";
            dataGridView1.Columns[1].Name = "Department Name";
        }
    }
}
