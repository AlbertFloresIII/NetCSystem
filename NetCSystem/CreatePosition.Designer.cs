namespace NetCSystem
{
    partial class CreatePosition
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRankRequired = new System.Windows.Forms.ComboBox();
            this.txtNumOfPer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletePerEquip = new System.Windows.Forms.Button();
            this.btnAddPerEquip = new System.Windows.Forms.Button();
            this.tblPersonnelEquipment = new System.Windows.Forms.DataGridView();
            this.PerEquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPerEquipQty = new System.Windows.Forms.TextBox();
            this.txtPerEquipCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPersonnelEquipment = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletePosEquip = new System.Windows.Forms.Button();
            this.tblPositionEquipment = new System.Windows.Forms.DataGridView();
            this.PosEquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosEquipQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPosEquip = new System.Windows.Forms.Button();
            this.txtPosEquipQty = new System.Windows.Forms.TextBox();
            this.cboPositionEquipment = new System.Windows.Forms.ComboBox();
            this.txtPosEquipCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelEquipment)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(675, 632);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 48);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(104, 632);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(242, 48);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPositionName
            // 
            this.txtPositionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPositionName.Location = new System.Drawing.Point(226, 161);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(242, 31);
            this.txtPositionName.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Position Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "CREATE POSITIONS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Rank Required:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Organization:";
            // 
            // cboOrganization
            // 
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(675, 208);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(201, 21);
            this.cboOrganization.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Number of Personnel:";
            // 
            // cboRankRequired
            // 
            this.cboRankRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRankRequired.FormattingEnabled = true;
            this.cboRankRequired.Location = new System.Drawing.Point(695, 166);
            this.cboRankRequired.Name = "cboRankRequired";
            this.cboRankRequired.Size = new System.Drawing.Size(201, 21);
            this.cboRankRequired.TabIndex = 48;
            // 
            // txtNumOfPer
            // 
            this.txtNumOfPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNumOfPer.Location = new System.Drawing.Point(295, 208);
            this.txtNumOfPer.Name = "txtNumOfPer";
            this.txtNumOfPer.Size = new System.Drawing.Size(139, 31);
            this.txtNumOfPer.TabIndex = 45;
            this.txtNumOfPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfPer_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletePerEquip);
            this.groupBox1.Controls.Add(this.btnAddPerEquip);
            this.groupBox1.Controls.Add(this.tblPersonnelEquipment);
            this.groupBox1.Controls.Add(this.txtPerEquipQty);
            this.groupBox1.Controls.Add(this.txtPerEquipCost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboPersonnelEquipment);
            this.groupBox1.Location = new System.Drawing.Point(59, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 301);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment per Personnel";
            // 
            // btnDeletePerEquip
            // 
            this.btnDeletePerEquip.Location = new System.Drawing.Point(294, 267);
            this.btnDeletePerEquip.Name = "btnDeletePerEquip";
            this.btnDeletePerEquip.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePerEquip.TabIndex = 4;
            this.btnDeletePerEquip.Text = "Delete";
            this.btnDeletePerEquip.UseVisualStyleBackColor = true;
            this.btnDeletePerEquip.Click += new System.EventHandler(this.btnDeletePerEquip_Click);
            // 
            // btnAddPerEquip
            // 
            this.btnAddPerEquip.Location = new System.Drawing.Point(6, 267);
            this.btnAddPerEquip.Name = "btnAddPerEquip";
            this.btnAddPerEquip.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerEquip.TabIndex = 4;
            this.btnAddPerEquip.Text = "Add";
            this.btnAddPerEquip.UseVisualStyleBackColor = true;
            this.btnAddPerEquip.Click += new System.EventHandler(this.btnAddPerEquip_Click);
            // 
            // tblPersonnelEquipment
            // 
            this.tblPersonnelEquipment.AllowUserToAddRows = false;
            this.tblPersonnelEquipment.AllowUserToDeleteRows = false;
            this.tblPersonnelEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPersonnelEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPersonnelEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PerEquipmentID,
            this.PerEquipName,
            this.PerEquipCost,
            this.PerEquipQty});
            this.tblPersonnelEquipment.Location = new System.Drawing.Point(6, 75);
            this.tblPersonnelEquipment.Name = "tblPersonnelEquipment";
            this.tblPersonnelEquipment.ReadOnly = true;
            this.tblPersonnelEquipment.Size = new System.Drawing.Size(363, 186);
            this.tblPersonnelEquipment.TabIndex = 3;
            // 
            // PerEquipmentID
            // 
            this.PerEquipmentID.DataPropertyName = "perEquipID";
            this.PerEquipmentID.HeaderText = "Equipment ID";
            this.PerEquipmentID.Name = "PerEquipmentID";
            this.PerEquipmentID.ReadOnly = true;
            // 
            // PerEquipName
            // 
            this.PerEquipName.DataPropertyName = "perEquipName";
            this.PerEquipName.HeaderText = "Equipment Name";
            this.PerEquipName.Name = "PerEquipName";
            this.PerEquipName.ReadOnly = true;
            // 
            // PerEquipCost
            // 
            this.PerEquipCost.DataPropertyName = "perEquipCost";
            this.PerEquipCost.HeaderText = "Equipment Cost";
            this.PerEquipCost.Name = "PerEquipCost";
            this.PerEquipCost.ReadOnly = true;
            // 
            // PerEquipQty
            // 
            this.PerEquipQty.DataPropertyName = "perEquipQty";
            this.PerEquipQty.HeaderText = "Quantity";
            this.PerEquipQty.Name = "PerEquipQty";
            this.PerEquipQty.ReadOnly = true;
            // 
            // txtPerEquipQty
            // 
            this.txtPerEquipQty.Location = new System.Drawing.Point(288, 35);
            this.txtPerEquipQty.Name = "txtPerEquipQty";
            this.txtPerEquipQty.Size = new System.Drawing.Size(81, 20);
            this.txtPerEquipQty.TabIndex = 2;
            this.txtPerEquipQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerEquipQty_KeyPress);
            // 
            // txtPerEquipCost
            // 
            this.txtPerEquipCost.Enabled = false;
            this.txtPerEquipCost.Location = new System.Drawing.Point(188, 35);
            this.txtPerEquipCost.Name = "txtPerEquipCost";
            this.txtPerEquipCost.Size = new System.Drawing.Size(81, 20);
            this.txtPerEquipCost.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cost";
            // 
            // cboPersonnelEquipment
            // 
            this.cboPersonnelEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonnelEquipment.FormattingEnabled = true;
            this.cboPersonnelEquipment.Location = new System.Drawing.Point(6, 34);
            this.cboPersonnelEquipment.Name = "cboPersonnelEquipment";
            this.cboPersonnelEquipment.Size = new System.Drawing.Size(162, 21);
            this.cboPersonnelEquipment.TabIndex = 0;
            this.cboPersonnelEquipment.SelectionChangeCommitted += new System.EventHandler(this.cboPersonnelEquipment_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletePosEquip);
            this.groupBox2.Controls.Add(this.tblPositionEquipment);
            this.groupBox2.Controls.Add(this.btnAddPosEquip);
            this.groupBox2.Controls.Add(this.txtPosEquipQty);
            this.groupBox2.Controls.Add(this.cboPositionEquipment);
            this.groupBox2.Controls.Add(this.txtPosEquipCost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(542, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 301);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment per Position";
            // 
            // btnDeletePosEquip
            // 
            this.btnDeletePosEquip.Location = new System.Drawing.Point(294, 267);
            this.btnDeletePosEquip.Name = "btnDeletePosEquip";
            this.btnDeletePosEquip.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePosEquip.TabIndex = 4;
            this.btnDeletePosEquip.Text = "Delete";
            this.btnDeletePosEquip.UseVisualStyleBackColor = true;
            this.btnDeletePosEquip.Click += new System.EventHandler(this.btnDeletePosEquip_Click);
            // 
            // tblPositionEquipment
            // 
            this.tblPositionEquipment.AllowUserToAddRows = false;
            this.tblPositionEquipment.AllowUserToDeleteRows = false;
            this.tblPositionEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPositionEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPositionEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PosEquipmentID,
            this.PosEquipName,
            this.PosEquipCost,
            this.PosEquipQty});
            this.tblPositionEquipment.Location = new System.Drawing.Point(6, 75);
            this.tblPositionEquipment.Name = "tblPositionEquipment";
            this.tblPositionEquipment.ReadOnly = true;
            this.tblPositionEquipment.Size = new System.Drawing.Size(363, 186);
            this.tblPositionEquipment.TabIndex = 3;
            // 
            // PosEquipmentID
            // 
            this.PosEquipmentID.DataPropertyName = "posEquipID";
            this.PosEquipmentID.HeaderText = "Equipment ID";
            this.PosEquipmentID.Name = "PosEquipmentID";
            this.PosEquipmentID.ReadOnly = true;
            // 
            // PosEquipName
            // 
            this.PosEquipName.DataPropertyName = "posEquipName";
            this.PosEquipName.HeaderText = "Equipment Name";
            this.PosEquipName.Name = "PosEquipName";
            this.PosEquipName.ReadOnly = true;
            // 
            // PosEquipCost
            // 
            this.PosEquipCost.DataPropertyName = "posEquipCost";
            this.PosEquipCost.HeaderText = "Equipment Cost";
            this.PosEquipCost.Name = "PosEquipCost";
            this.PosEquipCost.ReadOnly = true;
            // 
            // PosEquipQty
            // 
            this.PosEquipQty.DataPropertyName = "posEquipQty";
            this.PosEquipQty.HeaderText = "Quantity";
            this.PosEquipQty.Name = "PosEquipQty";
            this.PosEquipQty.ReadOnly = true;
            // 
            // btnAddPosEquip
            // 
            this.btnAddPosEquip.Location = new System.Drawing.Point(6, 267);
            this.btnAddPosEquip.Name = "btnAddPosEquip";
            this.btnAddPosEquip.Size = new System.Drawing.Size(75, 23);
            this.btnAddPosEquip.TabIndex = 4;
            this.btnAddPosEquip.Text = "Add";
            this.btnAddPosEquip.UseVisualStyleBackColor = true;
            this.btnAddPosEquip.Click += new System.EventHandler(this.btnAddPosEquip_Click);
            // 
            // txtPosEquipQty
            // 
            this.txtPosEquipQty.Location = new System.Drawing.Point(288, 35);
            this.txtPosEquipQty.Name = "txtPosEquipQty";
            this.txtPosEquipQty.Size = new System.Drawing.Size(81, 20);
            this.txtPosEquipQty.TabIndex = 2;
            this.txtPosEquipQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosEquipQty_KeyPress);
            // 
            // cboPositionEquipment
            // 
            this.cboPositionEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPositionEquipment.FormattingEnabled = true;
            this.cboPositionEquipment.Location = new System.Drawing.Point(6, 34);
            this.cboPositionEquipment.Name = "cboPositionEquipment";
            this.cboPositionEquipment.Size = new System.Drawing.Size(162, 21);
            this.cboPositionEquipment.TabIndex = 0;
            this.cboPositionEquipment.SelectionChangeCommitted += new System.EventHandler(this.cboPositionEquipment_SelectionChangeCommitted);
            // 
            // txtPosEquipCost
            // 
            this.txtPosEquipCost.Enabled = false;
            this.txtPosEquipCost.Location = new System.Drawing.Point(188, 35);
            this.txtPosEquipCost.Name = "txtPosEquipCost";
            this.txtPosEquipCost.Size = new System.Drawing.Size(81, 20);
            this.txtPosEquipCost.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantity";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(212, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 60;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(212, 110);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 61;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(108, 123);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 62;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(108, 110);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(160, 110);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 65;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(56, 123);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 66;
            this.lb.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Year ID:";
            // 
            // CreatePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 728);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.cboRankRequired);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.txtNumOfPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "CreatePosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelEquipment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRankRequired;
        private System.Windows.Forms.TextBox txtNumOfPer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPerEquipQty;
        private System.Windows.Forms.TextBox txtPerEquipCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPersonnelEquipment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblPersonnelEquipment;
        private System.Windows.Forms.DataGridView tblPositionEquipment;
        private System.Windows.Forms.TextBox txtPosEquipQty;
        private System.Windows.Forms.ComboBox cboPositionEquipment;
        private System.Windows.Forms.TextBox txtPosEquipCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeletePerEquip;
        private System.Windows.Forms.Button btnAddPerEquip;
        private System.Windows.Forms.Button btnDeletePosEquip;
        private System.Windows.Forms.Button btnAddPosEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosEquipQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerEquipQty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
    }
}