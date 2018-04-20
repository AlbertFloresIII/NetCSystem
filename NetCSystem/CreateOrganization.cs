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
        public CreateOrganization(int StatusID, int YearStart, int YearEnd)
        {
            InitializeComponent();
            DisplayEchelonName();
            txtStatus.Text = StatusID.ToString();
            txtYearStart.Text = YearStart.ToString();
            txtYearEnd.Text = YearEnd.ToString();
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
            int StatusID = Convert.ToInt32(txtStatus.Text);
            YearsValid years = new YearsValid(StatusID);
            years.Show();
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
                int StatusID = Convert.ToInt32(txtStatus.Text);
                int YearStart = Convert.ToInt32(txtYearStart.Text);

                int YearEnd = Convert.ToInt32(txtYearEnd.Text);

                myData.AddOrganization(txtNewOrgName.Text, OrganizationEchelon, StatusID, YearStart, YearEnd);

                MessageBox.Show("Organization Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
        }
    }
}
