namespace NetCSystem
{
    partial class ManageEchelon
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblEchelon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEchelonID = new System.Windows.Forms.TextBox();
            this.txtEchelonName = new System.Windows.Forms.TextBox();
            this.btnUpdateEchelon = new System.Windows.Forms.Button();
            this.btnDeleteEchelon = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.EchelonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EchelonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblEchelon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "MANAGE ECHELONS";
            // 
            // tblEchelon
            // 
            this.tblEchelon.AllowUserToAddRows = false;
            this.tblEchelon.AllowUserToDeleteRows = false;
            this.tblEchelon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEchelon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEchelon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EchelonID,
            this.EchelonName});
            this.tblEchelon.Location = new System.Drawing.Point(12, 89);
            this.tblEchelon.Name = "tblEchelon";
            this.tblEchelon.ReadOnly = true;
            this.tblEchelon.Size = new System.Drawing.Size(600, 276);
            this.tblEchelon.TabIndex = 20;
            this.tblEchelon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEchelon_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Echelon ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Echelon Name:";
            // 
            // txtEchelonID
            // 
            this.txtEchelonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEchelonID.Location = new System.Drawing.Point(144, 371);
            this.txtEchelonID.Name = "txtEchelonID";
            this.txtEchelonID.Size = new System.Drawing.Size(188, 31);
            this.txtEchelonID.TabIndex = 22;
            // 
            // txtEchelonName
            // 
            this.txtEchelonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEchelonName.Location = new System.Drawing.Point(144, 405);
            this.txtEchelonName.Name = "txtEchelonName";
            this.txtEchelonName.Size = new System.Drawing.Size(188, 31);
            this.txtEchelonName.TabIndex = 22;
            // 
            // btnUpdateEchelon
            // 
            this.btnUpdateEchelon.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEchelon.Location = new System.Drawing.Point(384, 373);
            this.btnUpdateEchelon.Name = "btnUpdateEchelon";
            this.btnUpdateEchelon.Size = new System.Drawing.Size(111, 28);
            this.btnUpdateEchelon.TabIndex = 23;
            this.btnUpdateEchelon.Text = "Update";
            this.btnUpdateEchelon.UseVisualStyleBackColor = true;
            this.btnUpdateEchelon.Click += new System.EventHandler(this.btnUpdateEchelon_Click);
            // 
            // btnDeleteEchelon
            // 
            this.btnDeleteEchelon.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEchelon.Location = new System.Drawing.Point(501, 374);
            this.btnDeleteEchelon.Name = "btnDeleteEchelon";
            this.btnDeleteEchelon.Size = new System.Drawing.Size(111, 28);
            this.btnDeleteEchelon.TabIndex = 23;
            this.btnDeleteEchelon.Text = "Delete";
            this.btnDeleteEchelon.UseVisualStyleBackColor = true;
            this.btnDeleteEchelon.Click += new System.EventHandler(this.btnDeleteEchelon_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(438, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 28);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EchelonID
            // 
            this.EchelonID.DataPropertyName = "echelon_id";
            this.EchelonID.HeaderText = "Echelon ID";
            this.EchelonID.Name = "EchelonID";
            this.EchelonID.ReadOnly = true;
            // 
            // EchelonName
            // 
            this.EchelonName.DataPropertyName = "echelon_name";
            this.EchelonName.HeaderText = "Echelon Name";
            this.EchelonName.Name = "EchelonName";
            this.EchelonName.ReadOnly = true;
            // 
            // ManageEchelon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnDeleteEchelon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateEchelon);
            this.Controls.Add(this.txtEchelonName);
            this.Controls.Add(this.txtEchelonID);
            this.Controls.Add(this.tblEchelon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageEchelon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            ((System.ComponentModel.ISupportInitialize)(this.tblEchelon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblEchelon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEchelonID;
        private System.Windows.Forms.TextBox txtEchelonName;
        private System.Windows.Forms.Button btnUpdateEchelon;
        private System.Windows.Forms.Button btnDeleteEchelon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn EchelonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EchelonName;
    }
}