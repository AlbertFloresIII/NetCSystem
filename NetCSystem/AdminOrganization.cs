using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCSystem
{
    public partial class AdminOrganization : Form
    {
        public AdminOrganization(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            Admin admin = new Admin(lblYearID.Text, lblYear.Text, statusID);
            admin.Show();
            this.Close();
        }

        private void btnCreateOrganization_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            CreateOrganization createOrg = new CreateOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            createOrg.Show();
            this.Close();
        }

        private void btnManageOrganization_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            ManageOrganization manageOrg = new ManageOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            manageOrg.Show();
            this.Close();
        }

        private void btnViewEquipment_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            ViewOrganization viewOrganization = new ViewOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            viewOrganization.Show();
            this.Close();
        }
    }
}
