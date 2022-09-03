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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmPermission : Form
    {
        public FrmPermission()
        {
            InitializeComponent();
        }

        private void DTStart_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = DTEnd.Value.Date - DTStart.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void dateTimePickeDTFinishr1_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = DTEnd.Value.Date - DTStart.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
                MessageBox.Show("please change end or start date");
            else if (Convert.ToInt32(txtAmount.Text) <= 0)
                MessageBox.Show("Permission day must be bigger than 0");
            else if (txtExplanation.Text.Trim() == "")
                MessageBox.Show("Explanation is empty");
            else
            {
                Permisions permission = new Permisions();
                permission.Employe_id = UserStatic.EmployeeID;
                permission.PermisionState = 1;
                permission.PermisionStart = DTStart.Value.Date;
                permission.PermisionEnd = DTEnd.Value.Date;
                permission.permisionDay = Convert.ToInt32(txtAmount.Text);
                permission.PermisionExplanation = txtExplanation.Text;
                PermissionBLL.AddPermission(permission);
                MessageBox.Show("Permission was Added");
                permission = new Permisions();
                DTStart.Value = DateTime.Today;
                DTEnd.Value = DateTime.Today;
                txtAmount.Clear();
                txtExplanation.Clear();
            }
        }

        TimeSpan PermissionDay;
        private void FrmPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
        }
    }
}
