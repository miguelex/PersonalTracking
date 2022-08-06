﻿using System;
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
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        void fillGrid()
        {
            positionlist = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionlist;
        }

            List<PositionDTO> positionlist = new List<PositionDTO>();
        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            fillGrid();
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Position Name";
            dataGridView1.Columns[3].Visible = false;
        }
    }
}
