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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            fillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("Please select a position from table");
            else
            {
                FrmPosition frm = new FrmPosition();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                fillGrid();

            }
        }

        List<PositionDTO> positionlist = new List<PositionDTO>();
        void fillGrid()
        {
            positionlist = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionlist;
        }

        
        PositionDTO detail = new PositionDTO();
        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            fillGrid();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[3].HeaderText = "position Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Department_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.OldDepartmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }
    }
}
