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
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblPositions = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tblPerEquipment = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tblPosEquipment = new System.Windows.Forms.DataGridView();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHierarchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerPosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosPosEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentCostPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrganization)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositions)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPerEquipment)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPosEquipment)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 389);
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
            this.EchelonName,
            this.Status,
            this.YearStart,
            this.YearEnd});
            this.tblOrganization.Location = new System.Drawing.Point(6, 19);
            this.tblOrganization.Name = "tblOrganization";
            this.tblOrganization.ReadOnly = true;
            this.tblOrganization.Size = new System.Drawing.Size(446, 305);
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
            // Status
            // 
            this.Status.DataPropertyName = "status_desc";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // YearStart
            // 
            this.YearStart.DataPropertyName = "year_start";
            this.YearStart.HeaderText = "Year Start";
            this.YearStart.Name = "YearStart";
            this.YearStart.ReadOnly = true;
            // 
            // YearEnd
            // 
            this.YearEnd.DataPropertyName = "year_end";
            this.YearEnd.HeaderText = "Year End";
            this.YearEnd.Name = "YearEnd";
            this.YearEnd.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(13, 421);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(219, 422);
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
            this.groupBox2.Location = new System.Drawing.Point(476, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 168);
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
            this.Rank,
            this.RankSalary});
            this.tblPositions.Location = new System.Drawing.Point(6, 12);
            this.tblPositions.Name = "tblPositions";
            this.tblPositions.ReadOnly = true;
            this.tblPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPositions.Size = new System.Drawing.Size(493, 150);
            this.tblPositions.TabIndex = 0;
            this.tblPositions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPositions_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tblPerEquipment);
            this.groupBox4.Location = new System.Drawing.Point(987, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 168);
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
            this.PerEquipQty,
            this.EquipmentCost});
            this.tblPerEquipment.Location = new System.Drawing.Point(6, 12);
            this.tblPerEquipment.Name = "tblPerEquipment";
            this.tblPerEquipment.ReadOnly = true;
            this.tblPerEquipment.Size = new System.Drawing.Size(338, 150);
            this.tblPerEquipment.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tblPosEquipment);
            this.groupBox5.Location = new System.Drawing.Point(987, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 168);
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
            this.PosEquipQty,
            this.EquipmentCostPos});
            this.tblPosEquipment.Location = new System.Drawing.Point(6, 12);
            this.tblPosEquipment.Name = "tblPosEquipment";
            this.tblPosEquipment.ReadOnly = true;
            this.tblPosEquipment.Size = new System.Drawing.Size(338, 150);
            this.tblPosEquipment.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(476, 196);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(505, 251);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1169, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 52;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(1169, 33);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 53;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(1065, 46);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 54;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(1065, 33);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1117, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(1117, 33);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 57;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(1013, 46);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 58;
            this.lb.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1013, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Year ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addChildToolStripMenuItem
            // 
            this.addChildToolStripMenuItem.Name = "addChildToolStripMenuItem";
            this.addChildToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addChildToolStripMenuItem.Text = "Add Hierarchy";
            this.addChildToolStripMenuItem.Click += new System.EventHandler(this.addChildToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHierarchyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewHierarchyToolStripMenuItem
            // 
            this.viewHierarchyToolStripMenuItem.Name = "viewHierarchyToolStripMenuItem";
            this.viewHierarchyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewHierarchyToolStripMenuItem.Text = "View Hierarchy";
            this.viewHierarchyToolStripMenuItem.Click += new System.EventHandler(this.viewHierarchyToolStripMenuItem_Click);
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
            // Rank
            // 
            this.Rank.DataPropertyName = "rank_name";
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // RankSalary
            // 
            this.RankSalary.DataPropertyName = "rank_salary";
            this.RankSalary.HeaderText = "Salary";
            this.RankSalary.Name = "RankSalary";
            this.RankSalary.ReadOnly = true;
            // 
            // PerPosID
            // 
            this.PerPosID.DataPropertyName = "position_name";
            this.PerPosID.HeaderText = "Position Name";
            this.PerPosID.Name = "PerPosID";
            this.PerPosID.ReadOnly = true;
            // 
            // PerEquipID
            // 
            this.PerEquipID.DataPropertyName = "equipment_name";
            this.PerEquipID.HeaderText = "Equipment Name";
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
            // EquipmentCost
            // 
            this.EquipmentCost.DataPropertyName = "equipment_cost";
            this.EquipmentCost.HeaderText = "Equipment Cost";
            this.EquipmentCost.Name = "EquipmentCost";
            this.EquipmentCost.ReadOnly = true;
            // 
            // PosPosEquipID
            // 
            this.PosPosEquipID.DataPropertyName = "position_name";
            this.PosPosEquipID.HeaderText = "Position Name";
            this.PosPosEquipID.Name = "PosPosEquipID";
            this.PosPosEquipID.ReadOnly = true;
            // 
            // PosEquipID
            // 
            this.PosEquipID.DataPropertyName = "equipment_name";
            this.PosEquipID.HeaderText = "Equipment Name";
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
            // EquipmentCostPos
            // 
            this.EquipmentCostPos.DataPropertyName = "equipment_cost";
            this.EquipmentCostPos.HeaderText = "Equipment Cost";
            this.EquipmentCostPos.Name = "EquipmentCostPos";
            this.EquipmentCostPos.ReadOnly = true;
            // 
            // ViewOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 465);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblPositions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView tblPerEquipment;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView tblPosEquipment;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EchelonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearEnd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHierarchyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerPosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosPosEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCostPos;
    }
}