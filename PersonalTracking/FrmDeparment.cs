using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PersonalTracking
{
    public partial class FrmDeparment : Form
    {
        public FrmDeparment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("Please enter department name");
            }
            else
            {
                Department department = new Department();
                department.DepartmentName = txtDepartment.Text;
                DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department added successfully");
                txtDepartment.Clear();
            }
        }
    }
}
