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
    public partial class CreateYear : Form
    {
        public CreateYear()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnBack_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtStartYear.Text == "" || txtEndYear.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int YearStart = Convert.ToInt32(txtStartYear.Text);
                int YearEnd = Convert.ToInt32(txtEndYear.Text);

                myData.AddYear(YearStart, YearEnd);

                MessageBox.Show("Year Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Year year = new Year();
                year.Show();
                this.Close();
            }
        }
    }
}
