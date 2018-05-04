namespace NetCSystem
{
    partial class ManageOrganization
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
            this.tblOrganization = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.txtOrganizationID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEchelonName = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrganizationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Echelon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrganizationCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrganization)).BeginInit();
            this.SuspendLayout();
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
            this.OrganizationCode,
            this.Echelon,
            this.StatusID,
            this.YearStart,
            this.YearEnd});
            this.tblOrganization.Location = new System.Drawing.Point(13, 111);
            this.tblOrganization.Name = "tblOrganization";
            this.tblOrganization.ReadOnly = true;
            this.tblOrganization.Size = new System.Drawing.Size(760, 290);
            this.tblOrganization.TabIndex = 48;
            this.tblOrganization.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOrganization_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 34);
            this.label1.TabIndex = 44;
            this.label1.Text = "MANAGE ORGANIZATIONS";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(517, 502);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 45);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(611, 451);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteEquipment.TabIndex = 53;
            this.btnDeleteEquipment.Text = "Delete";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEquipment.Location = new System.Drawing.Point(427, 451);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(148, 45);
            this.btnUpdateEquipment.TabIndex = 54;
            this.btnUpdateEquipment.Text = "Update";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtOrganizationName.Location = new System.Drawing.Point(187, 465);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(188, 31);
            this.txtOrganizationName.TabIndex = 50;
            // 
            // txtOrganizationID
            // 
            this.txtOrganizationID.Enabled = false;
            this.txtOrganizationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtOrganizationID.Location = new System.Drawing.Point(187, 419);
            this.txtOrganizationID.Name = "txtOrganizationID";
            this.txtOrganizationID.Size = new System.Drawing.Size(188, 31);
            this.txtOrganizationID.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Echelon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Organization Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Organization ID:";
            // 
            // cboEchelonName
            // 
            this.cboEchelonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEchelonName.FormattingEnabled = true;
            this.cboEchelonName.Location = new System.Drawing.Point(187, 556);
            this.cboEchelonName.Name = "cboEchelonName";
            this.cboEchelonName.Size = new System.Drawing.Size(188, 21);
            this.cboEchelonName.TabIndex = 55;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 56;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(168, 62);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 57;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(64, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 58;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(64, 62);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(116, 62);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 61;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 75);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 62;
            this.lb.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Year ID:";
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
            // OrganizationCode
            // 
            this.OrganizationCode.DataPropertyName = "organization_code";
            this.OrganizationCode.HeaderText = "Organization Code";
            this.OrganizationCode.Name = "OrganizationCode";
            this.OrganizationCode.ReadOnly = true;
            // 
            // Echelon
            // 
            this.Echelon.DataPropertyName = "echelon_name";
            this.Echelon.HeaderText = "Echelon";
            this.Echelon.Name = "Echelon";
            this.Echelon.ReadOnly = true;
            // 
            // StatusID
            // 
            this.StatusID.DataPropertyName = "status_desc";
            this.StatusID.HeaderText = "Status";
            this.StatusID.Name = "StatusID";
            this.StatusID.ReadOnly = true;
            // 
            // YearStart
            // 
            this.YearStart.DataPropertyName = "year_start";
            this.YearStart.HeaderText = "Start";
            this.YearStart.Name = "YearStart";
            this.YearStart.ReadOnly = true;
            // 
            // YearEnd
            // 
            this.YearEnd.DataPropertyName = "year_end";
            this.YearEnd.HeaderText = "End";
            this.YearEnd.Name = "YearEnd";
            this.YearEnd.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Organization Code:";
            // 
            // txtOrganizationCode
            // 
            this.txtOrganizationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtOrganizationCode.Location = new System.Drawing.Point(187, 509);
            this.txtOrganizationCode.Name = "txtOrganizationCode";
            this.txtOrganizationCode.Size = new System.Drawing.Size(188, 31);
            this.txtOrganizationCode.TabIndex = 50;
            // 
            // ManageOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEchelonName);
            this.Controls.Add(this.tblOrganization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.txtOrganizationCode);
            this.Controls.Add(this.txtOrganizationName);
            this.Controls.Add(this.txtOrganizationID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManageOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrganization";
            ((System.ComponentModel.ISupportInitialize)(this.tblOrganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.TextBox txtOrganizationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEchelonName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Echelon;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrganizationCode;
    }
}