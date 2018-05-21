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
    public partial class CreateEchelon : Form
    {
        public CreateEchelon(string YearID, string Year, int StatusID, string Status)
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
            AdminEchelon adminEchelon = new AdminEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEchelon.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtNewEchelonName.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int statusID = Convert.ToInt32(lblStatusID.Text);

                myData.AddEchelon(txtNewEchelonName.Text, txtEchelonCode.Text); //Parameters to be pass to DataAccess class
                
                MessageBox.Show("Echelon Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminEchelon adminEchelon = new AdminEchelon(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
                adminEchelon.Show();
                this.Close();
                
            }
        }
    }
}
