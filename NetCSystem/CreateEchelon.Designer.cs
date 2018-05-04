namespace NetCSystem
{
    partial class CreateEchelon
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewEchelonName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEchelonCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "CREATE ECHELON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "ECHELON NAME:";
            // 
            // txtNewEchelonName
            // 
            this.txtNewEchelonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewEchelonName.Location = new System.Drawing.Point(256, 204);
            this.txtNewEchelonName.Name = "txtNewEchelonName";
            this.txtNewEchelonName.Size = new System.Drawing.Size(242, 31);
            this.txtNewEchelonName.TabIndex = 21;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(256, 316);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(242, 48);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(256, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 48);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(247, 147);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 68;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(247, 134);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 69;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(143, 147);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 70;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(143, 134);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(195, 134);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 73;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(91, 147);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 74;
            this.lb.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Year ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "ECHELON CODE:";
            // 
            // txtEchelonCode
            // 
            this.txtEchelonCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEchelonCode.Location = new System.Drawing.Point(256, 241);
            this.txtEchelonCode.Name = "txtEchelonCode";
            this.txtEchelonCode.Size = new System.Drawing.Size(242, 31);
            this.txtEchelonCode.TabIndex = 21;
            // 
            // CreateEchelon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEchelonCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewEchelonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateEchelon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewEchelonName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEchelonCode;
    }
}