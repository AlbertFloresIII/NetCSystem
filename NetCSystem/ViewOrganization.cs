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
        public ViewOrganization(string YearID, string Year, int StatusID, string Status)
        {
            InitializeComponent();
            var topLeftHeaderCell = tblOrganization.TopLeftHeaderCell;
            var topLeftHeaderCell1 = tblPositions.TopLeftHeaderCell;
            var topLeftHeaderCell3 = tblPerEquipment.TopLeftHeaderCell;
            var topLeftHeaderCell4 = tblPosEquipment.TopLeftHeaderCell;

            lblYearID.Text = YearID;
            lblYear.Text = Year;
            lblStatusID.Text = StatusID.ToString();
            lblStatus.Text = Status;

            DisplayOrganization();
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationTable = new BindingSource();

        void DisplayOrganization()
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            int yearID = Convert.ToInt32(lblYearID.Text);
            myOrganizationTable.DataSource = myData.DisplayOrganizationWithEchelonName(yearID, statusID).Tables["OrganizationRecord"];
            tblOrganization.DataSource = myOrganizationTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int statusID = Convert.ToInt32(lblStatusID.Text);
            AdminOrganization adminOrganization = new AdminOrganization(lblYearID.Text, lblYear.Text, statusID, lblStatus.Text);
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

            else
            {
                MessageBox.Show("There are no records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                myData.OrganizationID(OrganizationID);
                myData.CountPosition(OrganizationID);

                tblPositions.Columns.Remove("rank_id");

                txtResult.Text = "Number of Positions: " + myData.TotalPosition +
                                 "\nTotal Personal Equipment Cost: " + myData.TotalPersonalCost() +
                                 "\nTotal Position Equipment Cost: " + myData.TotalPositionCost() +
                                 "\nTotal Equipment Cost: " + myData.TotalEquipmentCost() +
                                 "\nTotal Salary Cost: " + myData.TotalSalaryCost() +
                                 "\nTotal Organization Cost: " + myData.TotalOrgCost();
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

                tblPosEquipment.Columns.Remove("equipment_id");
                tblPerEquipment.Columns.Remove("equipment_id");
            }
        }

        private void addChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int status_id = Convert.ToInt32(lblStatusID.Text);
            CreateOrganizationChild createOrganizationChild = new CreateOrganizationChild(lblYearID.Text, lblYear.Text, status_id, lblStatus.Text);
            createOrganizationChild.Show();
            this.Close();
        }

        private void viewHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int status_id = Convert.ToInt32(lblStatusID.Text);
            DisplayOrganizationTree display = new DisplayOrganizationTree(lblYearID.Text, lblYear.Text, status_id, lblStatus.Text);
            display.Show();
            this.Close();
        }
    }
}
