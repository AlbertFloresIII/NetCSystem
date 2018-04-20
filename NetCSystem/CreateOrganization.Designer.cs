namespace NetCSystem
{
    partial class CreateOrganization
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
            this.txtNewOrgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOrgEchelon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYearStart = new System.Windows.Forms.TextBox();
            this.txtYearEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(273, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 48);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(273, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(242, 48);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNewOrgName
            // 
            this.txtNewOrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewOrgName.Location = new System.Drawing.Point(273, 206);
            this.txtNewOrgName.Name = "txtNewOrgName";
            this.txtNewOrgName.Size = new System.Drawing.Size(242, 31);
            this.txtNewOrgName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "ORGANIZATION NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "CREATE ORGANIZATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "ECHELON:";
            // 
            // cboOrgEchelon
            // 
            this.cboOrgEchelon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrgEchelon.FormattingEnabled = true;
            this.cboOrgEchelon.Location = new System.Drawing.Point(273, 255);
            this.cboOrgEchelon.Name = "cboOrgEchelon";
            this.cboOrgEchelon.Size = new System.Drawing.Size(242, 21);
            this.cboOrgEchelon.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "STATUS ID:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtStatus.Location = new System.Drawing.Point(273, 130);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(242, 31);
            this.txtStatus.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "YEARS:";
            // 
            // txtYearStart
            // 
            this.txtYearStart.Enabled = false;
            this.txtYearStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtYearStart.Location = new System.Drawing.Point(273, 166);
            this.txtYearStart.Name = "txtYearStart";
            this.txtYearStart.Size = new System.Drawing.Size(63, 31);
            this.txtYearStart.TabIndex = 26;
            // 
            // txtYearEnd
            // 
            this.txtYearEnd.Enabled = false;
            this.txtYearEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtYearEnd.Location = new System.Drawing.Point(364, 166);
            this.txtYearEnd.Name = "txtYearEnd";
            this.txtYearEnd.Size = new System.Drawing.Size(63, 31);
            this.txtYearEnd.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "-";
            // 
            // CreateOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cboOrgEchelon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtYearEnd);
            this.Controls.Add(this.txtYearStart);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtNewOrgName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNewOrgName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrgEchelon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYearStart;
        private System.Windows.Forms.TextBox txtYearEnd;
        private System.Windows.Forms.Label label6;
    }
}