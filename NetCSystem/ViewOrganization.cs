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
    public partial class ViewOrganization : Form
    {
        public ViewOrganization()
        {
            InitializeComponent();
            var topLeftHeaderCell = tblOrganization.TopLeftHeaderCell;
            var topLeftHeaderCell1 = tblPositions.TopLeftHeaderCell;
            var topLeftHeaderCell3 = tblPerEquipment.TopLeftHeaderCell;
            var topLeftHeaderCell4 = tblPosEquipment.TopLeftHeaderCell;
            DisplayOrganization();
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationTable = new BindingSource();

        void DisplayOrganization()
        {
            myOrganizationTable.DataSource = myData.DisplayOrganizationWithEchelonName().Tables["OrganizationRecord"];
            tblOrganization.DataSource = myOrganizationTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminOrganization adminOrganization = new AdminOrganization();
            adminOrganization.Show();
            this.Close();
        }

        private void tblOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrgID.Text = "";
            txtOrgName.Text = "";
            txtOrgEchelon.Text = "";

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all rows
                DataGridViewRow row = this.tblOrganization.Rows[e.RowIndex];

                //populate the textbox
                txtOrgID.Text = row.Cells[0].Value.ToString();
                txtOrgName.Text = row.Cells[1].Value.ToString();
                txtOrgEchelon.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.tblPositions.DataSource = null;
            this.tblPositions.Rows.Clear();
            this.tblPerEquipment.DataSource = null;
            this.tblPerEquipment.Rows.Clear();
            this.tblPosEquipment.DataSource = null;
            this.tblPosEquipment.Rows.Clear();
            txtResult.Text = "";

            if (txtOrgID.Text == "" || txtOrgName.Text == "" || txtOrgEchelon.Text == "")
            {
                MessageBox.Show("Please select on the table the data you want to view!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int OrganizationID = Convert.ToInt32(txtOrgID.Text);

                DataView posView = new DataView();

                posView.Table = myData.DisplayPositionAccdgToOrganization(OrganizationID).Tables["PositionRecord"];
                tblPositions.DataSource = posView;
                myData.CountPosition(OrganizationID);

                List<int> listOfPosID = new List<int>();
                foreach (DataGridViewRow row in tblPositions.Rows)
                {
                    int posID = (int)row.Cells[0].Value;
                    listOfPosID.Add(posID);
                }

                listOfPosID.ForEach(delegate (int posID)
                {
                    DataTable myEquipTable = myData.DisplayPerEquipmentAccdgToPositions(posID).Tables["PerEquipRecord"];

                    List<decimal> listOfTotalPerEquip = new List<decimal>();

                    foreach (DataRow dRow in myEquipTable.Rows)
                    {
                        int equipID = (int)dRow["equipment_id"];

                        if (myData.GetCostForPerEquip(posID, equipID))
                        {
                            decimal addTotalPerEquip = myData.PerEquipmentTotalCost;
                            listOfTotalPerEquip.Add(addTotalPerEquip);
                            Console.WriteLine("" + addTotalPerEquip);
                        }
                    }
                    decimal totalPerEquip = listOfTotalPerEquip.Sum();
                    txtResult.Text = "Total Positions: " + myData.TotalPosition + "\nTotal Personal Equipment:" + totalPerEquip;
                });
            }
        }

        private void tblPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tblPerEquipment.DataSource = null;
            this.tblPerEquipment.Rows.Clear();
            this.tblPosEquipment.DataSource = null;
            this.tblPosEquipment.Rows.Clear();

            DataView perEquipView = new DataView();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tblPositions.Rows[e.RowIndex];
                DataView posEquipView = new DataView();

                int posID = (int)row.Cells[0].Value;
                perEquipView.Table = myData.DisplayPerEquipmentAccdgToPositions(posID).Tables["PerEquipRecord"];
                posEquipView.Table = myData.DisplayPosEquipmentAccdgToPositions(posID).Tables["PosEquipRecord"];

                tblPerEquipment.DataSource = perEquipView;
                tblPosEquipment.DataSource = posEquipView;
            }
        }
    }
}
