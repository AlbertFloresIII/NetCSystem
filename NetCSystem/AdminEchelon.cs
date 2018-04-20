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
    public partial class AdminEchelon : Form
    {
        public AdminEchelon()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnCreateEchelon_Click(object sender, EventArgs e)
        {
            CreateEchelon createEchelon = new CreateEchelon();
            createEchelon.Show();
            this.Close();
        }

        private void btnManageEchelon_Click(object sender, EventArgs e)
        {
            ManageEchelon manageEchelon = new ManageEchelon();
            manageEchelon.Show();
            this.Close();
        }
    }
}
