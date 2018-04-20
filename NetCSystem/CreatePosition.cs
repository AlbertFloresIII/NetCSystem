﻿using System;
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
    public partial class CreatePosition : Form
    {
        public CreatePosition(int StatusID)
        {
            InitializeComponent();

            txtStatus.Text = StatusID.ToString();
            DisplayOrganizationName();
            DisplayRankName();
            DisplayPerEquipmentName();
            DisplayPosEquipmentName();

            cboPersonnelEquipment.SelectedValue = 1;
            cboPositionEquipment.SelectedValue = 1;
        }

        DataAccess myData = new DataAccess();
        BindingSource myOrganizationName = new BindingSource();
        BindingSource myRankName = new BindingSource();
        BindingSource myPerEquipmentName = new BindingSource();
        BindingSource myPosEquipmentName = new BindingSource();

        void DisplayOrganizationName()
        {
            int statusID = Convert.ToInt32(txtStatus.Text);
            myOrganizationName.DataSource = myData.DisplayOrganization(statusID).Tables["OrganizationRecord"];
            cboOrganization.DataSource = myOrganizationName;
            cboOrganization.DisplayMember = "organization_name";
            cboOrganization.ValueMember = "organization_id";
        }

        void DisplayRankName()
        {
            myRankName.DataSource = myData.DisplayRank().Tables["RankRecord"];
            cboRankRequired.DataSource = myRankName;
            cboRankRequired.DisplayMember = "rank_name";
            cboRankRequired.ValueMember = "rank_id";
        }

        void DisplayPerEquipmentName()
        {
            myPerEquipmentName.DataSource = myData.DisplayEquipment().Tables["EquipmentRecord"];
            cboPersonnelEquipment.DataSource = myPerEquipmentName;
            cboPersonnelEquipment.DisplayMember = "equipment_name";
            cboPersonnelEquipment.ValueMember = "equipment_id";
        }

        void DisplayPosEquipmentName()
        {
            myPosEquipmentName.DataSource = myData.DisplayEquipment().Tables["EquipmentRecord"];
            cboPositionEquipment.DataSource = myPosEquipmentName;
            cboPositionEquipment.DisplayMember = "equipment_name";
            cboPositionEquipment.ValueMember = "equipment_id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPosition adminPosition = new AdminPosition();
            adminPosition.Show();
            this.Close();
        }

        private void txtNumOfPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPerEquipQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPosEquipQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cboPersonnelEquipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPerEquipCost.Text = "";
            int EquipmentID = (int) cboPersonnelEquipment.SelectedValue;

            if (myData.DisplayEquipmentForPosition(EquipmentID))
            {
                txtPerEquipCost.Text = Convert.ToString(myData.EquipmentCost);
            }
        }

        private void cboPositionEquipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPosEquipCost.Text = "";
            int EquipmentID = (int)cboPositionEquipment.SelectedValue;

            if(myData.DisplayEquipmentForPosition(EquipmentID))
            {
                txtPosEquipCost.Text = Convert.ToString(myData.EquipmentCost);
            }
        }

        private void btnAddPerEquip_Click(object sender, EventArgs e)
        {
            if(txtPerEquipCost.Text == "" || txtPerEquipQty.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int perEquipID = (int)cboPersonnelEquipment.SelectedValue;
                string perEquipName = cboPersonnelEquipment.Text;
                string perEquipCost = txtPerEquipCost.Text;
                string perEquipQty = txtPerEquipQty.Text;

                string[] perEquip = { perEquipID.ToString(), perEquipName, perEquipCost, perEquipQty };
                tblPersonnelEquipment.Rows.Add(perEquip);

                txtPerEquipQty.Text = "";
            }
        }

        private void btnDeletePerEquip_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell oneCell in tblPersonnelEquipment.SelectedCells)
            {
                if (oneCell.Selected)
                    tblPersonnelEquipment.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnAddPosEquip_Click(object sender, EventArgs e)
        {
            if (txtPosEquipCost.Text == "" || txtPosEquipQty.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int posEquipID = (int)cboPositionEquipment.SelectedValue;
                string posEquipName = cboPositionEquipment.Text;
                string posEquipCost = txtPosEquipCost.Text;
                string posEquipQty = txtPosEquipQty.Text;

                string[] posEquip = {posEquipID.ToString(), posEquipName, posEquipCost, posEquipQty };
                tblPositionEquipment.Rows.Add(posEquip);

                txtPosEquipQty.Text = "";
            }
        }

        private void btnDeletePosEquip_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell oneCell in tblPositionEquipment.SelectedCells)
            {
                if (oneCell.Selected)
                    tblPositionEquipment.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtPositionName.Text == "" || txtNumOfPer.Text == "" || tblPersonnelEquipment.Rows.Count == 0 || tblPositionEquipment.Rows.Count == 0)
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int NumberOfPersonnel = Convert.ToInt32(txtNumOfPer.Text);
                int RankRequired = (int) cboRankRequired.SelectedValue;
                int Organization = (int)cboOrganization.SelectedValue;

                myData.AddPosition(txtPositionName.Text, NumberOfPersonnel, RankRequired, Organization);

                for (int i = 0; i < tblPersonnelEquipment.Rows.Count; i++)
                {
                    int PerEquipID = Convert.ToInt32(tblPersonnelEquipment.Rows[i].Cells["PerEquipmentID"].Value);
                    int PerEquipQty = Convert.ToInt32(tblPersonnelEquipment.Rows[i].Cells["perEquipQty"].Value);
                    myData.AddPersonalEquipment(PerEquipID, PerEquipQty);
                }

                for(int j = 0; j < tblPositionEquipment.Rows.Count; j++)
                {
                    int PosEquipID = Convert.ToInt32(tblPositionEquipment.Rows[j].Cells["PosEquipmentID"].Value);
                    int PosEquipQty = Convert.ToInt32(tblPositionEquipment.Rows[j].Cells["PosEquipQty"].Value);
                    myData.AddPositionEquipment(PosEquipID, PosEquipQty);
                }

                MessageBox.Show("Organization Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminPosition adminPosition = new AdminPosition();
                adminPosition.Show();
                this.Close();
            }
        }
    }
}