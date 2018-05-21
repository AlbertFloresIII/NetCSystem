using System;
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
    public partial class ManageEchelon : Form
    {
        public ManageEchelon(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayEchelon();
        }

        DataAccess myData = new DataAccess();
        BindingSource myEchelonTable = new BindingSource();

        void DisplayEchelon()
        {
            myEchelonTable.DataSource = myData.DisplayEchelon().Tables["EchelonRecord"]; //Parameters to pass to DataAccess class
            tblEchelon.DataSource = myEchelonTable;
        }

        private void tblEchelon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEchelonID.Clear();
            txtEchelonName.Clear();
            txtEchelonCode.Clear();

            if(e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblEchelon.Rows[e.RowIndex];

                //populate the textbox
                txtEchelonID.Text = row.Cells["EchelonID"].Value.ToString();
                txtEchelonName.Text = row.Cells["EchelonName"].Value.ToString();
                txtEchelonCode.Text = row.Cells["EchelonCode"].Value.ToString();
            }
        }

        private void btnUpdateEchelon_Click(object sender, EventArgs e)
        {
            if(txtEchelonID.Text == "" || txtEchelonName.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int EchelonID = Convert.ToInt32(txtEchelonID.Text);

                if (!myData.UpdateEchelon(EchelonID, txtEchelonName.Text, txtEchelonCode.Text)) //Parameters to pass to DataAccess class
                {
                    MessageBox.Show("Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }

        private void Reset()
        {
            txtEchelonID.Text = "";
            txtEchelonName.Text = "";
            txtEchelonCode.Text = "";

            DisplayEchelon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminEchelon adminEchelon = new AdminEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEchelon.Show();
            this.Close();
        }

        private void btnDeleteEchelon_Click(object sender, EventArgs e)
        {
            if(txtEchelonID.Text == "" || txtEchelonName.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int EchelonID = Convert.ToInt32(txtEchelonID.Text);
                myData.DeleteEchelon(EchelonID); //Parameters to pass to DataAccess class
                MessageBox.Show("Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
    }
}
