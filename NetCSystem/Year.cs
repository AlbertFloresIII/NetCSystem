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
    public partial class Year : Form
    {
        public Year()
        {
            InitializeComponent();
            DisplayYear();
        }

        DataAccess myData = new DataAccess();
        BindingSource myYear = new BindingSource();

        void DisplayYear()
        {
            myYear.DataSource = myData.DisplayYear().Tables["YearRecord"];
            cboYear.DataSource = myYear;
            cboYear.DisplayMember = "year_start";
            cboYear.ValueMember = "year_id";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            CreateYear createYear = new CreateYear();
            createYear.Show();
            this.Close();
        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            int YearID = (int)cboYear.SelectedValue;
            string YearName = this.cboYear.GetItemText(this.cboYear.SelectedItem);

            Status status = new Status(YearID, YearName);
            status.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
