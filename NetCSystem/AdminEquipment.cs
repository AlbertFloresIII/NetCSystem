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
    public partial class AdminEquipment : Form
    {
        public AdminEquipment(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            Admin admin = new Admin(lblYearID.Text, lblYear.Text, statusID);
            admin.Show();
            this.Close();
        }

        private void btnCreateEquipment_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            CreateEquipment createEquip = new CreateEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            createEquip.Show();
            this.Close();
        }

        private void btnManageEquipment_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);

            ManageEquipment manageEquip = new ManageEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            manageEquip.Show();
            this.Close();
        }
    }
}
