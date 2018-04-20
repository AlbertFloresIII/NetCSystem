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
        public AdminEquipment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnCreateEquipment_Click(object sender, EventArgs e)
        {
            CreateEquipment createEquip = new CreateEquipment();
            createEquip.Show();
            this.Close();
        }

        private void btnManageEquipment_Click(object sender, EventArgs e)
        {
            ManageEquipment manageEquip = new ManageEquipment();
            manageEquip.Show();
            this.Close();
        }
    }
}
