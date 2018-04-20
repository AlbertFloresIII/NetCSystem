namespace NetCSystem
{
    partial class AdminOrganization
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewEquipment = new System.Windows.Forms.Button();
            this.btnManageOrganization = new System.Windows.Forms.Button();
            this.btnCreateOrganization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(270, 369);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 23);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "VIEW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "MANAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "CREATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "ORGANIZATION";
            // 
            // btnViewEquipment
            // 
            this.btnViewEquipment.Location = new System.Drawing.Point(445, 164);
            this.btnViewEquipment.Name = "btnViewEquipment";
            this.btnViewEquipment.Size = new System.Drawing.Size(132, 123);
            this.btnViewEquipment.TabIndex = 36;
            this.btnViewEquipment.UseVisualStyleBackColor = true;
            this.btnViewEquipment.Click += new System.EventHandler(this.btnViewEquipment_Click);
            // 
            // btnManageOrganization
            // 
            this.btnManageOrganization.Location = new System.Drawing.Point(245, 164);
            this.btnManageOrganization.Name = "btnManageOrganization";
            this.btnManageOrganization.Size = new System.Drawing.Size(132, 123);
            this.btnManageOrganization.TabIndex = 37;
            this.btnManageOrganization.UseVisualStyleBackColor = true;
            this.btnManageOrganization.Click += new System.EventHandler(this.btnManageOrganization_Click);
            // 
            // btnCreateOrganization
            // 
            this.btnCreateOrganization.Location = new System.Drawing.Point(48, 164);
            this.btnCreateOrganization.Name = "btnCreateOrganization";
            this.btnCreateOrganization.Size = new System.Drawing.Size(132, 123);
            this.btnCreateOrganization.TabIndex = 38;
            this.btnCreateOrganization.UseVisualStyleBackColor = true;
            this.btnCreateOrganization.Click += new System.EventHandler(this.btnCreateOrganization_Click);
            // 
            // AdminOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewEquipment);
            this.Controls.Add(this.btnManageOrganization);
            this.Controls.Add(this.btnCreateOrganization);
            this.Name = "AdminOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOrganization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewEquipment;
        private System.Windows.Forms.Button btnManageOrganization;
        private System.Windows.Forms.Button btnCreateOrganization;
    }
}