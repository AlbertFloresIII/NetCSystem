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
    public partial class ManageOrganization : Form
    {
        public ManageOrganization(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayOrganization();
            DisplayEchelon();
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationTable = new BindingSource();
        BindingSource myEchelonName = new BindingSource();
        BindingSource myStatus = new BindingSource();

        void DisplayOrganization()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            int yearID = Convert.ToInt32(lblYearID.Text);

            myOrganizationTable.DataSource = myData.DisplayOrganizationWithEchelonName(yearID, statusID).Tables["OrganizationRecord"];
            tblOrganization.DataSource = myOrganizationTable;
        }

        void DisplayEchelon()
        {
            myEchelonName.DataSource = myData.DisplayEchelon().Tables["EchelonRecord"];
            cboEchelonName.DataSource = myEchelonName;
            cboEchelonName.DisplayMember = "echelon_Name";
            cboEchelonName.ValueMember = "echelon_ID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminOrganization adminOrg = new AdminOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminOrg.Show();
            this.Close();
        }

        private void tblOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrganizationID.Clear();
            txtOrganizationName.Clear();
            txtOrganizationCode.Clear();

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblOrganization.Rows[e.RowIndex];

                //populate the textbox
                txtOrganizationID.Text = row.Cells["OrganizationID"].Value.ToString();
                txtOrganizationName.Text = row.Cells["OrganizationName"].Value.ToString();
                txtOrganizationCode.Text = row.Cells["OrganizationCode"].Value.ToString();
            }
        }

        private void Reset()
        {
            txtOrganizationID.Text = "";
            txtOrganizationName.Text = "";
            txtOrganizationCode.Text = "";

            DisplayOrganization();
            DisplayEchelon();
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            if(txtOrganizationID.Text == "" || txtOrganizationName.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int OrganzationID = Convert.ToInt32(txtOrganizationID.Text);
                int OrganizationEchelon = (int)cboEchelonName.SelectedValue;

                if (!myData.UpdateOrganization(OrganzationID, txtOrganizationName.Text, OrganizationEchelon, txtOrganizationCode.Text))
                {
                    MessageBox.Show("Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if(txtOrganizationID.Text == "" || txtOrganizationName.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int OrganzationID = Convert.ToInt32(txtOrganizationID.Text);
                myData.DeleteOrganization(OrganzationID);
                MessageBox.Show("Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
    }
}
