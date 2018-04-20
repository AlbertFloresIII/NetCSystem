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
        public CreateEchelon()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminEchelon adminEchelon = new AdminEchelon();
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

                myData.AddEchelon(txtNewEchelonName.Text);
                
                MessageBox.Show("Echelon Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminEchelon adminEchelon = new AdminEchelon();
                adminEchelon.Show();
                this.Close();
                
            }
        }
    }
}
