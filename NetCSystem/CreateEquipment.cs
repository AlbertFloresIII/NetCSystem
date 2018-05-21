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
    public partial class CreateEquipment : Form
    {
        public CreateEquipment(string YearID, string Year, int StatusID, string Status)
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
            AdminEquipment adminEquip = new AdminEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEquip.Show();
            this.Close();
        }

        private void txtNewEquipmentCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtNewEquipmentName.Text == "" || txtNewEquipmentCost.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                decimal EquipmentCost = Convert.ToDecimal(txtNewEquipmentCost.Text);
                int YearID = Convert.ToInt32(lblYearID.Text);
                int statusID = Convert.ToInt32(lblStatusID.Text);

                myData.AddEquipment(txtNewEquipmentName.Text, EquipmentCost,YearID); //Parameters to pass to DataAccess class

                MessageBox.Show("Equipment Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminEquipment adminEquip = new AdminEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
                adminEquip.Show();
                this.Close();
            }
        }
    }
}
