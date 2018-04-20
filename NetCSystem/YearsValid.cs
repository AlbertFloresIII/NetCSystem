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
    public partial class YearsValid : Form
    {
        public YearsValid(int StatusID)
        {
            InitializeComponent();

            txtStatus.Text = StatusID.ToString();
        }

        DataAccess myData = new DataAccess();

        private int statusID, yearStart, yearEnd;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
            this.Close();
        }

        private void txtYearStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtYearEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            statusID = Convert.ToInt32(txtStatus.Text);
            yearStart = Convert.ToInt32(txtYearStart.Text);
            yearEnd = Convert.ToInt32(txtYearEnd.Text);

            CreateOrganization createOrg = new CreateOrganization(statusID, yearStart, yearEnd);
            createOrg.Show();
            this.Close();
        }
    }
}
