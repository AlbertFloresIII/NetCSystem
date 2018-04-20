namespace NetCSystem
{
    partial class ViewOrganization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrgEchelon = new System.Windows.Forms.TextBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.txtOrgID = new System.Windows.Forms.TextBox();
            this.tblOrganization = new System.Windows.Forms.DataGridView();
            this.OrganizationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EchelonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblPositions = new System.Windows.Forms.DataGridView();
            this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tblPerEquipment = new System.Windows.Forms.DataGridView();
            this.PerPosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tblPosEquipment = new System.Windows.Forms.DataGridView();
            this.PosPosEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrganization)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositions)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPerEquipment)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPosEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrgEchelon);
            this.groupBox1.Controls.Add(this.txtOrgName);
            this.groupBox1.Controls.Add(this.txtOrgID);
            this.groupBox1.Controls.Add(this.tblOrganization);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Echelon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtOrgEchelon
            // 
            this.txtOrgEchelon.Enabled = false;
            this.txtOrgEchelon.Location = new System.Drawing.Point(174, 363);
            this.txtOrgEchelon.Name = "txtOrgEchelon";
            this.txtOrgEchelon.Size = new System.Drawing.Size(78, 20);
            this.txtOrgEchelon.TabIndex = 1;
            // 
            // txtOrgName
            // 
            this.txtOrgName.Enabled = false;
            this.txtOrgName.Location = new System.Drawing.Point(90, 363);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(78, 20);
            this.txtOrgName.TabIndex = 1;
            // 
            // txtOrgID
            // 
            this.txtOrgID.Enabled = false;
            this.txtOrgID.Location = new System.Drawing.Point(6, 363);
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.Size = new System.Drawing.Size(78, 20);
            this.txtOrgID.TabIndex = 1;
            // 
            // tblOrganization
            // 
            this.tblOrganization.AllowUserToAddRows = false;
            this.tblOrganization.AllowUserToDeleteRows = false;
            this.tblOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrganization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationID,
            this.OrganizationName,
            this.EchelonName});
            this.tblOrganization.Location = new System.Drawing.Point(6, 19);
            this.tblOrganization.Name = "tblOrganization";
            this.tblOrganization.ReadOnly = true;
            this.tblOrganization.Size = new System.Drawing.Size(325, 305);
            this.tblOrganization.TabIndex = 0;
            this.tblOrganization.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOrganization_CellClick);
            // 
            // OrganizationID
            // 
            this.OrganizationID.DataPropertyName = "organization_id";
            this.OrganizationID.HeaderText = "Organization ID";
            this.OrganizationID.Name = "OrganizationID";
            this.OrganizationID.ReadOnly = true;
            // 
            // OrganizationName
            // 
            this.OrganizationName.DataPropertyName = "organization_name";
            this.OrganizationName.HeaderText = "Organization Name";
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            // 
            // EchelonName
            // 
            this.EchelonName.DataPropertyName = "echelon_name";
            this.EchelonName.HeaderText = "Echelon";
            this.EchelonName.Name = "EchelonName";
            this.EchelonName.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(13, 406);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(219, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblPositions);
            this.groupBox2.Location = new System.Drawing.Point(355, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Positions";
            // 
            // tblPositions
            // 
            this.tblPositions.AllowUserToAddRows = false;
            this.tblPositions.AllowUserToDeleteRows = false;
            this.tblPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionID,
            this.PositionName,
            this.PersonnelQuantity,
            this.RankID,
            this.Organization});
            this.tblPositions.Location = new System.Drawing.Point(6, 12);
            this.tblPositions.Name = "tblPositions";
            this.tblPositions.ReadOnly = true;
            this.tblPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPositions.Size = new System.Drawing.Size(367, 150);
            this.tblPositions.TabIndex = 0;
            this.tblPositions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPositions_CellClick);
            // 
            // PositionID
            // 
            this.PositionID.DataPropertyName = "position_id";
            this.PositionID.HeaderText = "Position ID";
            this.PositionID.Name = "PositionID";
            this.PositionID.ReadOnly = true;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "position_name";
            this.PositionName.HeaderText = "Position Name";
            this.PositionName.Name = "PositionName";
            this.PositionName.ReadOnly = true;
            // 
            // PersonnelQuantity
            // 
            this.PersonnelQuantity.DataPropertyName = "personnel_qty";
            this.PersonnelQuantity.HeaderText = "Personnel Quantity";
            this.PersonnelQuantity.Name = "PersonnelQuantity";
            this.PersonnelQuantity.ReadOnly = true;
            // 
            // RankID
            // 
            this.RankID.DataPropertyName = "rank_id";
            this.RankID.HeaderText = "Rank ID";
            this.RankID.Name = "RankID";
            this.RankID.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "organization_id";
            this.Organization.HeaderText = "Organization";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tblPerEquipment);
            this.groupBox4.Location = new System.Drawing.Point(740, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel Equipment";
            // 
            // tblPerEquipment
            // 
            this.tblPerEquipment.AllowUserToAddRows = false;
            this.tblPerEquipment.AllowUserToDeleteRows = false;
            this.tblPerEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPerEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPerEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PerPosID,
            this.PerEquipID,
            this.PerEquipQty});
            this.tblPerEquipment.Location = new System.Drawing.Point(6, 12);
            this.tblPerEquipment.Name = "tblPerEquipment";
            this.tblPerEquipment.ReadOnly = true;
            this.tblPerEquipment.Size = new System.Drawing.Size(247, 150);
            this.tblPerEquipment.TabIndex = 0;
            // 
            // PerPosID
            // 
            this.PerPosID.DataPropertyName = "position_id";
            this.PerPosID.HeaderText = "Position ID";
            this.PerPosID.Name = "PerPosID";
            this.PerPosID.ReadOnly = true;
            // 
            // PerEquipID
            // 
            this.PerEquipID.DataPropertyName = "equipment_id";
            this.PerEquipID.HeaderText = "Equipment ID";
            this.PerEquipID.Name = "PerEquipID";
            this.PerEquipID.ReadOnly = true;
            // 
            // PerEquipQty
            // 
            this.PerEquipQty.DataPropertyName = "equipment_qty";
            this.PerEquipQty.HeaderText = "Equipment Quantity";
            this.PerEquipQty.Name = "PerEquipQty";
            this.PerEquipQty.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tblPosEquipment);
            this.groupBox5.Location = new System.Drawing.Point(740, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 168);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position Equipment";
            // 
            // tblPosEquipment
            // 
            this.tblPosEquipment.AllowUserToAddRows = false;
            this.tblPosEquipment.AllowUserToDeleteRows = false;
            this.tblPosEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPosEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPosEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PosPosEquipID,
            this.PosEquipID,
            this.PosEquipQty});
            this.tblPosEquipment.Location = new System.Drawing.Point(6, 12);
            this.tblPosEquipment.Name = "tblPosEquipment";
            this.tblPosEquipment.ReadOnly = true;
            this.tblPosEquipment.Size = new System.Drawing.Size(247, 150);
            this.tblPosEquipment.TabIndex = 0;
            // 
            // PosPosEquipID
            // 
            this.PosPosEquipID.DataPropertyName = "position_id";
            this.PosPosEquipID.HeaderText = "Position ID";
            this.PosPosEquipID.Name = "PosPosEquipID";
            this.PosPosEquipID.ReadOnly = true;
            // 
            // PosEquipID
            // 
            this.PosEquipID.DataPropertyName = "equipment_id";
            this.PosEquipID.HeaderText = "Equipment ID";
            this.PosEquipID.Name = "PosEquipID";
            this.PosEquipID.ReadOnly = true;
            // 
            // PosEquipQty
            // 
            this.PosEquipQty.DataPropertyName = "equipment_qty";
            this.PosEquipQty.HeaderText = "Equipment Quantity";
            this.PosEquipQty.Name = "PosEquipQty";
            this.PosEquipQty.ReadOnly = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(355, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(373, 251);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // ViewOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Organization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrganization)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPositions)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPerEquipment)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPosEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblOrganization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrgEchelon;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.TextBox txtOrgID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EchelonName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblPositions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView tblPerEquipment;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView tblPosEquipment;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerPosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosPosEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipQty;
    }
}