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
    public partial class ManageEquipment : Form
    {
        public ManageEquipment(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();
            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;


            DisplayEquipment();
        }

        DataAccess myData = new DataAccess();
        BindingSource myEquipmentTable = new BindingSource();

        void DisplayEquipment()
        {
            int YearID = Convert.ToInt32(lblYearID.Text);

            myEquipmentTable.DataSource = myData.DisplayEquipmentAccdgToYear(YearID).Tables["EquipmentRecord"];
            tblEquipment.DataSource = myEquipmentTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminEquipment adminEquip = new AdminEquipment(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
            adminEquip.Show();
            this.Close();
        }

        private void txtEquipmentCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tblEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEquipmentID.Clear();
            txtEquipmentName.Clear();
            txtEquipmentCost.Clear();

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblEquipment.Rows[e.RowIndex];

                //populate the textbox
                txtEquipmentID.Text = row.Cells["EquipmentID"].Value.ToString();
                txtEquipmentName.Text = row.Cells["EquipmentName"].Value.ToString();
                txtEquipmentCost.Text = row.Cells["EquipmentCost"].Value.ToString();
            }
        }

        private void Reset()
        {
            txtEquipmentID.Text = "";
            txtEquipmentName.Text = "";
            txtEquipmentCost.Text = "";

            DisplayEquipment();
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            if(txtEquipmentID.Text == "" || txtEquipmentName.Text == "" || txtEquipmentCost.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int EquipmentID = Convert.ToInt32(txtEquipmentID.Text);
                decimal EquipmentCost = Convert.ToDecimal(txtEquipmentCost.Text);

                if (!myData.UpdateEquipment(EquipmentID, txtEquipmentName.Text, EquipmentCost))
                {
                    MessageBox.Show("Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if(txtEquipmentID.Text == "" || txtEquipmentName.Text == "" || txtEquipmentCost.Text == "")
            {
                MessageBox.Show("Please click on the table the data you want to delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int EquipmentID = Convert.ToInt32(txtEquipmentID.Text);
                myData.DeleteEquipment(EquipmentID);
                MessageBox.Show("Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
    }
}
