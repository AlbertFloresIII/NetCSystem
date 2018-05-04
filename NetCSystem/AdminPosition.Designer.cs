namespace NetCSystem
{
    partial class AdminPosition
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManagePositions = new System.Windows.Forms.Button();
            this.btnCreatePositions = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(264, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "MANAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "CREATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "POSITIONS";
            // 
            // btnManagePositions
            // 
            this.btnManagePositions.Location = new System.Drawing.Point(340, 189);
            this.btnManagePositions.Name = "btnManagePositions";
            this.btnManagePositions.Size = new System.Drawing.Size(132, 123);
            this.btnManagePositions.TabIndex = 21;
            this.btnManagePositions.UseVisualStyleBackColor = true;
            // 
            // btnCreatePositions
            // 
            this.btnCreatePositions.Location = new System.Drawing.Point(143, 189);
            this.btnCreatePositions.Name = "btnCreatePositions";
            this.btnCreatePositions.Size = new System.Drawing.Size(132, 123);
            this.btnCreatePositions.TabIndex = 22;
            this.btnCreatePositions.UseVisualStyleBackColor = true;
            this.btnCreatePositions.Click += new System.EventHandler(this.btnCreatePositions_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 52;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(168, 119);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 53;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(64, 132);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 54;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(64, 119);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(116, 119);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 57;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 132);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 58;
            this.lb.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Year ID:";
            // 
            // AdminPosition
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManagePositions);
            this.Controls.Add(this.btnCreatePositions);
            this.Name = "AdminPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagePositions;
        private System.Windows.Forms.Button btnCreatePositions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label8;
    }
}