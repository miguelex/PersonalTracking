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
                if (!isUpdate)
                {
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
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        permission.ID = detail.PermissionID;
                        permission.PermisionExplanation = txtExplanation.Text;
                        permission.PermisionStart = DTStart.Value;
                        permission.PermisionEnd = DTEnd.Value;
                        permission.permisionDay = Convert.ToInt32(txtAmount.Text);
                        PermissionBLL.UpdatePermission(permission);
                        MessageBox.Show("Permission was Updated");
                        this.Close();

                    }

                }
            }
        }

        TimeSpan PermissionDay;
        public bool isUpdate = false;
        public PermissionDetailDTO detail = new PermissionDetailDTO();
        private void FrmPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
            if (isUpdate)
            {
                DTStart.Value = detail.StartDate;
                DTEnd.Value = detail.EndDate;
                txtAmount.Text = detail.PermissionDayAmount.ToString();
                txtExplanation.Text = detail.Explanation;
                txtUserNo.Text = detail.UserNo.ToString();
            }
        }
    }
}
