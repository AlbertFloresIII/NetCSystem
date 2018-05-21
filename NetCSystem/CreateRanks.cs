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
        public CreateRanks(string YearID, string Year, int StatusID, string Status)
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

            AdminRanks adminRanks = new AdminRanks(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminRanks.Show();
            this.Close();
        }

        //Disable any keys from keyboard except numbers, Back key and '.' key
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
                int StatusID = Convert.ToInt32(lblStatusID.Text);
                int YearID = Convert.ToInt32(lblYearID.Text);

                myData.AddRank(txtNewRankName.Text, RankSalary, YearID, txtRankCode.Text); //Parameters to pass to DataAccess class

                MessageBox.Show("Rank Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminRanks adminRank = new AdminRanks(lblYearID.Text, lblYear.Text, StatusID, lblStatus.Text);
                adminRank.Show();
                this.Close();
            }
        }
    }
}
