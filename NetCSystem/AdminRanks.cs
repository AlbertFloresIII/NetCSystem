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
        public AdminRanks(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;
        }

        DataAccess myData = new DataAccess();

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            Admin admin = new Admin(lblYearID.Text, lblYear.Text, statusID);
            admin.Show();
            this.Close();
        }

        private void btnCreateEchelon_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            CreateRanks createRank = new CreateRanks(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            createRank.Show();
            this.Close();
        }

        private void btnManageEchelon_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            ManageRanks manageRank = new ManageRanks(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            manageRank.Show();
            this.Close();
        }

        private void btnViewEchelon_Click(object sender, EventArgs e)
        {

        }
    }
}
