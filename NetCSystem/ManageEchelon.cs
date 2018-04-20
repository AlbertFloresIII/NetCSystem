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
        public ManageEchelon()
        {
            InitializeComponent();
            DisplayEchelon();
        }

        DataAccess myData = new DataAccess();
        BindingSource myEchelonTable = new BindingSource();

        void DisplayEchelon()
        {
            myEchelonTable.DataSource = myData.DisplayEchelon().Tables["EchelonRecord"];
            tblEchelon.DataSource = myEchelonTable;
        }

        private void tblEchelon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEchelonID.Clear();
            txtEchelonName.Clear();
            if(e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblEchelon.Rows[e.RowIndex];

                //populate the textbox
                txtEchelonID.Text = row.Cells[0].Value.ToString();
                txtEchelonName.Text = row.Cells[1].Value.ToString();
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

                if (!myData.UpdateEchelon(EchelonID, txtEchelonName.Text))
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

            DisplayEchelon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminEchelon adminEchelon = new AdminEchelon();
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
                myData.DeleteEchelon(EchelonID);
                MessageBox.Show("Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
    }
}
