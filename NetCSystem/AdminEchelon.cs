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
        public AdminEchelon(string YearID, string Year, int StatusID, string Status)
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

        private void btnCreateEchelon_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            CreateEchelon createEchelon = new CreateEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            createEchelon.Show();
            this.Close();
        }

        private void btnManageEchelon_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            ManageEchelon manageEchelon = new ManageEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            manageEchelon.Show();
            this.Close();
        }
    }
}
