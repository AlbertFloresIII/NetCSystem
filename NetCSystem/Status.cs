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
        public Status()
        {
            InitializeComponent();
        }

        private int statusID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnIdeal_Click(object sender, EventArgs e)
        {
            statusID = 1;

            YearsValid years = new YearsValid(statusID);
            years.Show();
            this.Close();
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            statusID = 2;

            YearsValid years = new YearsValid(statusID);
            years.Show();
            this.Close();
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            statusID = 3;

            YearsValid years = new YearsValid(statusID);
            years.Show();
            this.Close();
        }
    }
}
