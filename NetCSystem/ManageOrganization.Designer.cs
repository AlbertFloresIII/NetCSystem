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
            this.OrganizationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Echelon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
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
            this.Echelon,
            this.StatusID,
            this.YearStart,
            this.YearEnd});
            this.tblOrganization.Location = new System.Drawing.Point(15, 77);
            this.tblOrganization.Name = "tblOrganization";
            this.tblOrganization.ReadOnly = true;
            this.tblOrganization.Size = new System.Drawing.Size(760, 290);
            this.tblOrganization.TabIndex = 48;
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
            this.btnBack.Location = new System.Drawing.Point(512, 475);
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
            this.btnDeleteEquipment.Location = new System.Drawing.Point(606, 424);
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
            this.btnUpdateEquipment.Location = new System.Drawing.Point(422, 424);
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
            this.label4.Location = new System.Drawing.Point(102, 510);
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
            this.cboEchelonName.Location = new System.Drawing.Point(187, 510);
            this.cboEchelonName.Name = "cboEchelonName";
            this.cboEchelonName.Size = new System.Drawing.Size(188, 21);
            this.cboEchelonName.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(187, 387);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(188, 21);
            this.cboStatus.TabIndex = 55;
            this.cboStatus.SelectionChangeCommitted += new System.EventHandler(this.cboStatus_SelectionChangeCommitted);
            // 
            // ManageOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboEchelonName);
            this.Controls.Add(this.tblOrganization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.txtOrganizationName);
            this.Controls.Add(this.txtOrganizationID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Echelon;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}