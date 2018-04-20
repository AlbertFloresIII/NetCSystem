namespace NetCSystem
{
    partial class ManageEquipment
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
            this.tblEquipment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.txtEquipmentCost = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEquipment
            // 
            this.tblEquipment.AllowUserToAddRows = false;
            this.tblEquipment.AllowUserToDeleteRows = false;
            this.tblEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentID,
            this.EquipmentName,
            this.EquipmentCost});
            this.tblEquipment.Location = new System.Drawing.Point(15, 78);
            this.tblEquipment.Name = "tblEquipment";
            this.tblEquipment.ReadOnly = true;
            this.tblEquipment.Size = new System.Drawing.Size(760, 331);
            this.tblEquipment.TabIndex = 37;
            this.tblEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEquipment_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "MANAGE EQUIPMENTS";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(512, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 45);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(606, 425);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteEquipment.TabIndex = 42;
            this.btnDeleteEquipment.Text = "Delete";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEquipment.Location = new System.Drawing.Point(422, 425);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(148, 45);
            this.btnUpdateEquipment.TabIndex = 43;
            this.btnUpdateEquipment.Text = "Update";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // txtEquipmentCost
            // 
            this.txtEquipmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEquipmentCost.Location = new System.Drawing.Point(159, 512);
            this.txtEquipmentCost.Name = "txtEquipmentCost";
            this.txtEquipmentCost.Size = new System.Drawing.Size(188, 31);
            this.txtEquipmentCost.TabIndex = 38;
            this.txtEquipmentCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipmentCost_KeyPress);
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEquipmentName.Location = new System.Drawing.Point(159, 466);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(188, 31);
            this.txtEquipmentName.TabIndex = 39;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEquipmentID.Location = new System.Drawing.Point(159, 420);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(188, 31);
            this.txtEquipmentID.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Equipment Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Equipment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Equipment ID:";
            // 
            // EquipmentID
            // 
            this.EquipmentID.DataPropertyName = "equipment_id";
            this.EquipmentID.HeaderText = "Equipment ID";
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.ReadOnly = true;
            // 
            // EquipmentName
            // 
            this.EquipmentName.DataPropertyName = "equipment_name";
            this.EquipmentName.HeaderText = "Equipment Name";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            // 
            // EquipmentCost
            // 
            this.EquipmentCost.DataPropertyName = "equipment_cost";
            this.EquipmentCost.HeaderText = "Equipment Cost";
            this.EquipmentCost.Name = "EquipmentCost";
            this.EquipmentCost.ReadOnly = true;
            // 
            // ManageEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tblEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.txtEquipmentCost);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.txtEquipmentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManageEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEquipment";
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.TextBox txtEquipmentCost;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCost;
    }
}