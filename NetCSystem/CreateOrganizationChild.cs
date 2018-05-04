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
    public partial class CreateOrganizationChild : Form
    {
        public CreateOrganizationChild(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            MyParentOrganization();
            MyChildOrganization();

            cboParentOrg.SelectedValue = 1;
            cboChildOrg.SelectedValue = 1;
        }

        DataAccess myData = new DataAccess();
        BindingSource myParentOrganizationName = new BindingSource();
        BindingSource myChildOrganizationName = new BindingSource();

        void MyParentOrganization()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            myParentOrganizationName.DataSource = myData.DisplayOrganization(statusID).Tables["OrganizationRecord"];
            cboParentOrg.DataSource = myParentOrganizationName;
            cboParentOrg.DisplayMember = "organization_name";
            cboParentOrg.ValueMember = "organization_id";
        }

        void MyChildOrganization()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            myChildOrganizationName.DataSource = myData.DisplayOrganization(statusID).Tables["OrganizationRecord"];
            cboChildOrg.DataSource = myChildOrganizationName;
            cboChildOrg.DisplayMember = "organization_name";
            cboChildOrg.ValueMember = "organization_id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            ViewOrganization viewOrganization = new ViewOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            viewOrganization.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int ancestor = (int) cboParentOrg.SelectedValue;
            int descendant = (int)cboChildOrg.SelectedValue;
            int status_id = Convert.ToInt32(lblStatusID.Text);
            int year_id = Convert.ToInt32(lblYearID.Text);

            myData.AddChild(ancestor, descendant, status_id, year_id);
            MessageBox.Show("Equipment Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ViewOrganization viewOrganization = new ViewOrganization(lblYearID.Text, lblYear.Text, status_id, lblStatus.Text);
            viewOrganization.Show();
            this.Close();
        }
    }
}
