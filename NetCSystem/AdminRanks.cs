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
    public partial class AdminRanks : Form
    {
        public AdminRanks()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnCreateEchelon_Click(object sender, EventArgs e)
        {
            CreateRanks createRank = new CreateRanks();
            createRank.Show();
            this.Close();
        }

        private void btnManageEchelon_Click(object sender, EventArgs e)
        {
            ManageRanks manageRank = new ManageRanks();
            manageRank.Show();
            this.Close();
        }
    }
}
