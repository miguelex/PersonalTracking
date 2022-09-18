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
    public partial class FrmTasksList : Form
    {
        public FrmTasksList()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtUserNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            rbStart.Checked = false;
            rbDelivery.Checked = false;
            cmbTaskState.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Tasks;
        }
        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.TaskID == 0)
                MessageBox.Show("Please select a task on table");
            else
            {
                FrmTask frm = new FrmTask();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                FillAllData();
                CleanFilters();
            }
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        void FillAllData()
        {
            dto = TaskBLL.GetAll();
            
            dataGridView1.DataSource = dto.Tasks;
            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbTaskState.DataSource = dto.TaskStates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.ValueMember = "ID";
            cmbTaskState.SelectedIndex = -1;
        }

        TaskDetailDTO detail = new TaskDetailDTO();
        private void FrmTasksList_Load(object sender, EventArgs e)
        {
            FillAllData();
            dataGridView1.DataSource = dto.Tasks;
            dataGridView1.Columns[0].HeaderText = "Task Title";
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Start Date";
            dataGridView1.Columns[5].HeaderText = "Delivered Date";
            dataGridView1.Columns[6].HeaderText = "Task State";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            
            combofull = true;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.Department_id ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dto.Tasks;

            if (txtUserNo.Text.Trim() != "")
            {
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            }

            if (txtName.Text.Trim() != "")
            {
                list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();
            }

            if (txtSurname.Text.Trim() != "")
            {
                list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            }

            if (cmbDepartment.SelectedIndex != -1)
            {
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }

            if (cmbPosition.SelectedIndex != -1)
            {
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }

            if (rbStart.Checked)
                list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(DTStart.Value) &&
                x.TaskStartDate < Convert.ToDateTime(DTEnd.Value)).ToList();
            if (rbDelivery.Checked)
                list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(DTStart.Value) &&
                x.TaskDeliveryDate < Convert.ToDateTime(DTEnd.Value)).ToList();
            if (cmbTaskState.SelectedIndex != -1)
                list = list.Where(x => x.taskStateID == Convert.ToInt32(cmbTaskState.SelectedValue)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Title = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.Content = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.taskStateID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detail.TaskID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detail.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.TaskStartDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.TaskDeliveryDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this task", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TaskBLL.DeleteTask(detail.TaskID);
                MessageBox.Show("Task was Deleted");
                FillAllData();
                CleanFilters();

            }
        }

       private void btnApprove_Click(object sender, EventArgs e)
        {
            /*if (UserStatic.isAdmin && detail.taskStateID == TasksStates.OnEmployee && detail.EmployeeID != UserStatic.EmployeeID)
                MessageBox.Show("Before approve a task employee have to delivery task");
            else if (UserStatic.isAdmin && detail.taskStateID == TasksStates.Approved)
                MessageBox.Show("This task is already approved");
            else if (!UserStatic.isAdmin && detail.taskStateID == TasksStates.Delivered)
                MessageBox.Show("This task is already delivered");
            else if (!UserStatic.isAdmin && detail.taskStateID == TasksStates.Approved)
                MessageBox.Show("This task is already approved");
            else
            {
                TaskBLL.ApproveTask(detail.TaskID, UserStatic.isAdmin);
                MessageBox.Show("Task was Updated");
                FillAllData();
                CleanFilters();

            }*/
        }
    }
}
