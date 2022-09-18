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
using DAL.DTO;

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
                if (!isUpdate)
                {
                    EmpPosition position = new EmpPosition();
                    position.PositionName = txtPosition.Text;
                    position.Department_id = Convert.ToInt32(cmbDepartment.SelectedValue);
                    BLL.PositionBLL.AddPosition(position);
                    MessageBox.Show("Position was added");
                    txtPosition.Clear();
                    cmbDepartment.SelectedIndex = -1;
                }
                else
                {
                    EmpPosition position = new EmpPosition();
                    position.ID = detail.ID;
                    position.PositionName = txtPosition.Text;
                    position.Department_id = Convert.ToInt32(cmbDepartment.SelectedValue);
                    bool control = false;
                    if (Convert.ToInt32(cmbDepartment.SelectedValue) != detail.OldDepartmentID)
                        control = true;
                    PositionBLL.UpdatePosition(position, control);
                    MessageBox.Show("Position was Updated");
                    this.Close();

                }
            }
        }

        List<Department> departmentList = new List<Department>();
        public PositionDTO detail = new PositionDTO();
        public bool isUpdate = false;
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDepartment.DataSource = departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            if (isUpdate)
            {
                txtPosition.Text = detail.PositionName;
                cmbDepartment.SelectedValue = detail.Department_id;
            }
        }
    }
}
