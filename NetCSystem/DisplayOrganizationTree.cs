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
    public partial class DisplayOrganizationTree : Form
    {
        public DisplayOrganizationTree(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayOrganization();
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationTable = new BindingSource();

        void DisplayOrganization()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            int yearID = Convert.ToInt32(lblYearID.Text);
            myOrganizationTable.DataSource = myData.DisplayOrganizationWithEchelonName(yearID, statusID).Tables["OrganizationRecord"];
            tblParentOrg.DataSource = myOrganizationTable;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int OrganizationID = Convert.ToInt32(txtOrganizationID.Text);

            DataView OrgView = new DataView();

            OrgView.Table = myData.DisplayOrganizationTree(OrganizationID).Tables["Organizationrecord"];
            tblChildOrg.DataSource = OrgView;

            tblChildOrg.Columns.Remove("year_start");
            tblChildOrg.Columns.Remove("year_end");
        }

        private void tblParentOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrganizationID.Clear();

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblParentOrg.Rows[e.RowIndex];

                //populate the textbox
                txtOrganizationID.Text = row.Cells[0].Value.ToString();
            }

            else
            {
                MessageBox.Show("There are no records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int status_id = Convert.ToInt32(lblStatusID.Text);
            ViewOrganization viewOrganization = new ViewOrganization(lblYearID.Text, lblYear.Text, status_id, lblStatus.Text);
            viewOrganization.Show();
            this.Close();
        }
    }
}
