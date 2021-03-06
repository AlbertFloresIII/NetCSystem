﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace NetCSystem
{
    public partial class ManageRanks : Form
    {
        public ManageRanks(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayRank();
        }

        DataAccess myData = new DataAccess();
        BindingSource myRankTable = new BindingSource();

        void DisplayRank()
        {
            int yearID = Convert.ToInt32(lblYearID.Text);

            myRankTable.DataSource = myData.DisplayRankAccdgToYear(yearID).Tables["RankRecord"]; //Parameters to pass to DataAccess class
            tblRank.DataSource = myRankTable;
        }

        private void txtRankSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disables key on keyboard except numbers, Back key and '.' key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tblRank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRankID.Clear();
            txtRankName.Clear();
            txtRankSalary.Clear();
            txtRankCode.Clear();

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblRank.Rows[e.RowIndex];

                //populate the textbox
                txtRankID.Text = row.Cells["RankID"].Value.ToString();
                txtRankName.Text = row.Cells["RankName"].Value.ToString();
                txtRankSalary.Text = row.Cells["RankSalary"].Value.ToString();
                txtRankCode.Text = row.Cells["RankCode"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminRanks adminRanks = new AdminRanks(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminRanks.Show();
            this.Close();
        }

        private void btnUpdateRank_Click(object sender, EventArgs e)
        {
            if(txtRankID.Text == "" || txtRankName.Text == "" || txtRankSalary.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int RankID = Convert.ToInt32(txtRankID.Text);
                decimal RankSalary = Convert.ToDecimal(txtRankSalary.Text);

                if (!myData.UpdateRank(RankID, txtRankName.Text, RankSalary, txtRankCode.Text)) //Parameters to pass to DataAccess class
                {
                    MessageBox.Show("Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }

        private void Reset()
        {
            txtRankID.Text = "";
            txtRankName.Text = "";
            txtRankSalary.Text = "";
            txtRankCode.Text = "";

            DisplayRank();
        }

        private void btnDeleteRank_Click(object sender, EventArgs e)
        {
            if(txtRankID.Text == "" || txtRankName.Text == "" || txtRankSalary.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int RankID = Convert.ToInt32(txtRankID.Text);
                myData.DeleteRank(RankID); //Parameters to pass to DataAccess class
                MessageBox.Show("Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
    }
}