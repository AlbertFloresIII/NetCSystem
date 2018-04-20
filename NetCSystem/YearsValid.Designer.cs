namespace NetCSystem
{
    partial class YearsValid
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYearEnd = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "YEARS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Start:";
            // 
            // txtYearStart
            // 
            this.txtYearStart.Location = new System.Drawing.Point(86, 99);
            this.txtYearStart.Name = "txtYearStart";
            this.txtYearStart.Size = new System.Drawing.Size(100, 20);
            this.txtYearStart.TabIndex = 21;
            this.txtYearStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearStart_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "End:";
            // 
            // txtYearEnd
            // 
            this.txtYearEnd.Location = new System.Drawing.Point(86, 125);
            this.txtYearEnd.Name = "txtYearEnd";
            this.txtYearEnd.Size = new System.Drawing.Size(100, 20);
            this.txtYearEnd.TabIndex = 21;
            this.txtYearEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearEnd_KeyPress);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(86, 167);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 23);
            this.btnAdmin.TabIndex = 22;
            this.btnAdmin.Text = "Proceed";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(86, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(86, 73);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 21;
            this.txtStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearStart_KeyPress);
            // 
            // YearsValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtYearEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYearStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YearsValid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Years";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYearEnd;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
    }
}