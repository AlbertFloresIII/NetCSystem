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
        public ManageOrganization()
        {
            InitializeComponent();
            DisplayOrganization();
            DisplayEchelon();
            DisplayStatus();
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationTable = new BindingSource();
        BindingSource myEchelonName = new BindingSource();
        BindingSource myStatus = new BindingSource();

        void DisplayOrganization()
        {
            myOrganizationTable.DataSource = myData.DisplayOrganizationWithEchelonName().Tables["OrganizationRecord"];
            tblOrganization.DataSource = myOrganizationTable;
        }

        void DisplayEchelon()
        {
            myEchelonName.DataSource = myData.DisplayEchelon().Tables["EchelonRecord"];
            cboEchelonName.DataSource = myEchelonName;
            cboEchelonName.DisplayMember = "echelon_Name";
            cboEchelonName.ValueMember = "echelon_ID";
        }

        void DisplayStatus()
        {
            myStatus.DataSource = myData.DisplayStatus().Tables["StatusRecord"];
            cboStatus.DataSource = myStatus;
            cboStatus.DisplayMember = "status_desc";
            cboStatus.ValueMember = "status_id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminOrganization adminOrg = new AdminOrganization();
            adminOrg.Show();
            this.Close();
        }

        private void tblOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrganizationID.Text = "";
            txtOrganizationName.Text = "";

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblOrganization.Rows[e.RowIndex];

                //populate the textbox
                txtOrganizationID.Text = row.Cells[0].Value.ToString();
                txtOrganizationName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Reset()
        {
            txtOrganizationID.Text = "";
            txtOrganizationName.Text = "";

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

                if (!myData.UpdateOrganization(OrganzationID, txtOrganizationName.Text, OrganizationEchelon))
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

        private void cboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.tblOrganization.DataSource = null;
            this.tblOrganization.Rows.Clear();

            int statusID = (int)cboStatus.SelectedValue;

            myOrganizationTable.DataSource = myData.DisplayOrganizationAccdgToStatus(statusID).Tables["StatusRecord"];
            tblOrganization.DataSource = myOrganizationTable;
        }
    }
}
