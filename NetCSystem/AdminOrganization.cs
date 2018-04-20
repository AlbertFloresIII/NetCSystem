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
        public AdminOrganization()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnCreateOrganization_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
            this.Close();
        }

        private void btnManageOrganization_Click(object sender, EventArgs e)
        {
            ManageOrganization manageOrg = new ManageOrganization();
            manageOrg.Show();
            this.Close();
        }

        private void btnViewEquipment_Click(object sender, EventArgs e)
        {
            ViewOrganization viewOrganization = new ViewOrganization();
            viewOrganization.Show();
            this.Close();
        }
    }
}
