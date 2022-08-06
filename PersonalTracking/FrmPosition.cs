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
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the position name");
            } else if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Department");
            } else
            {
                EmpPosition position = new EmpPosition();
                position.PositionName = txtPosition.Text;
                position.Department_id = Convert.ToInt32(cmbDepartment.SelectedValue);
                PositionBLL.AddPosition(position); 
                MessageBox.Show("Position was added");
                txtPosition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }

        List<Department> departmentList = new List<Department>();
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDepartment.DataSource = departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }
    }
}
