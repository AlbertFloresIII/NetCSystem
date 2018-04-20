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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEchelon adminEchelon = new AdminEchelon();
            adminEchelon.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRanks adminRanks = new AdminRanks();
            adminRanks.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminEquipment adminEquip = new AdminEquipment();
            adminEquip.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminOrganization adminOrg = new AdminOrganization();
            adminOrg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPosition adminPosition = new AdminPosition();
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
