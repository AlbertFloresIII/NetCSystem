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
    public partial class Admin : Form
    {
        public Admin(string YearID, string Year, int StatusID)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();

            DisplayStatusName();
        }

        DataAccess myData = new DataAccess();

        void DisplayStatusName()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            if(myData.DisplayStatusName(statusID))
            {
                lblStatus.Text = myData.StatusName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminEchelon adminEchelon = new AdminEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEchelon.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminRanks adminRanks = new AdminRanks(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminRanks.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminEquipment adminEquip = new AdminEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEquip.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminOrganization adminOrg = new AdminOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminOrg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminPosition adminPosition = new AdminPosition(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminPosition.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
