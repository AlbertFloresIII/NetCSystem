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
    public partial class Status : Form
    {
        public Status(int YearID, string Year)
        {
            InitializeComponent();

            lblYearID.Text = YearID.ToString();
            lblYearName.Text = Year;
        }

        private int statusID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.Show();
            this.Close();
        }

        private void btnIdeal_Click(object sender, EventArgs e)
        {
            statusID = 1;

            Admin admin = new Admin(lblYearID.Text, lblYearName.Text, statusID);
            admin.Show();
            this.Close();
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            statusID = 2;

            Admin admin = new Admin(lblYearID.Text, lblYearName.Text, statusID);
            admin.Show();
            this.Close();
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            statusID = 3;

            Admin admin = new Admin(lblYearID.Text, lblYearName.Text, statusID);
            admin.Show();
            this.Close();
        }
    }
}
