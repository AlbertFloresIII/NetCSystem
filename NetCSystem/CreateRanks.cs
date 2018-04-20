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
    public partial class CreateRanks : Form
    {
        public CreateRanks()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminRanks adminRanks = new AdminRanks();
            adminRanks.Show();
            this.Close();
        }

        private void txtNewRankSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtNewRankName.Text == "" || txtNewRankSalary.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                decimal RankSalary = Convert.ToDecimal(txtNewRankSalary.Text);

                myData.AddRank(txtNewRankName.Text, RankSalary);

                MessageBox.Show("Rank Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminRanks adminRank = new AdminRanks();
                adminRank.Show();
                this.Close();
            }
        }
    }
}
