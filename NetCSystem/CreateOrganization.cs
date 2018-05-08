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
    public partial class CreateOrganization : Form
    {
        public CreateOrganization(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayEchelonName();
        }

        DataAccess myData = new DataAccess();
        BindingSource myEchelonName = new BindingSource();

        void DisplayEchelonName()
        {
            myEchelonName.DataSource = myData.DisplayEchelon().Tables["EchelonRecord"];
            cboOrgEchelon.DataSource = myEchelonName;
            cboOrgEchelon.DisplayMember = "echelon_Name";
            cboOrgEchelon.ValueMember = "echelon_ID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminOrganization adminOrg = new AdminOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminOrg.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtNewOrgName.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int OrganizationEchelon = (int) cboOrgEchelon.SelectedValue;
                int StatusID = Convert.ToInt32(lblStatusID.Text);
                int YearID = Convert.ToInt32(lblYearID.Text);

                myData.AddOrganization(txtNewOrgName.Text, OrganizationEchelon, StatusID, YearID, txtOrganizationCode.Text);

                MessageBox.Show("Organization Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminOrganization admin = new AdminOrganization(lblYearID.Text, lblYear.Text, StatusID, lblStatus.Text);
                admin.Show();
                this.Close();
            }
        }
    }
}
