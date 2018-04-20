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
    public partial class StatusPosition : Form
    {
        public StatusPosition()
        {
            InitializeComponent();
        }

        private int statusID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPosition adminPos = new AdminPosition();
            adminPos.Show();
            this.Close();
        }

        private void btnIdeal_Click(object sender, EventArgs e)
        {
            statusID = 1;

            CreatePosition createPos = new CreatePosition(statusID);
            createPos.Show();
            this.Close();
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            statusID = 2;

            CreatePosition createPos = new CreatePosition(statusID);
            createPos.Show();
            this.Close();
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            statusID = 3;

            CreatePosition createPos = new CreatePosition(statusID);
            createPos.Show();
            this.Close();
        }
    }
}
