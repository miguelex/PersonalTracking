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
using System.IO;

namespace PersonalTracking
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        EmployeeDTO dto = new EmployeeDTO();
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            comboFull = true;
        }

        bool comboFull = false;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.Positions.Where(x => x.Department_id == departmentId).ToList();
            }
            
        }

        string fileName = "";
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                fileName += unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No is empty");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Password is empty");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else if (txtSurname.Text.Trim() == "")
                MessageBox.Show("Surname is empty");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is empty");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Select a Department");
            else if (cmbPosition.SelectedIndex == -1)
                MessageBox.Show("Select a Position");
            else
            {
                Employe employee = new Employe();
                employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                employee.Password = txtPassword.Text;
                employee.isAdmin = checkBox1.Checked;
                employee.Name = txtName.Text;
                employee.SurName = txtSurname.Text; 
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.Department_id = Convert.ToInt32(cmbDepartment.SelectedValue);
                employee.Position_id = Convert.ToInt32(cmbPosition.SelectedValue);
                employee.Adress = txtAddress.Text;
                employee.Birthday = dateTimePicker1.Value;
                employee.imgPath = fileName;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(txtImagePath.Text, @"images\\" + fileName);
                MessageBox.Show("Employee was added");
                txtUserNo.Clear();
                txtPassword.Clear();
                checkBox1.Checked = false;
                txtName.Clear();
                txtSurname.Clear();
                txtSalary.Clear();
                txtAddress.Clear();
                dateTimePicker1.Value = DateTime.Today;
                txtImagePath.Clear();
                pictureBox1.Image = null;
                comboFull = false;
                cmbDepartment.SelectedIndex = -1;
                cmbPosition.DataSource = dto.Positions;
                cmbPosition.SelectedIndex = -1;
                comboFull = true;

            }
        }

        bool isUnique = false;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No is empty");
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("This user no is in use by other employee");
                else
                    MessageBox.Show("This user no is usable");
            }
        }
    }
}
