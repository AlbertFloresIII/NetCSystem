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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewPositions = new System.Windows.Forms.Button();
            this.btnManagePositions = new System.Windows.Forms.Button();
            this.btnCreatePositions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(270, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "VIEW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "MANAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 284);
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
            // btnViewPositions
            // 
            this.btnViewPositions.Location = new System.Drawing.Point(445, 158);
            this.btnViewPositions.Name = "btnViewPositions";
            this.btnViewPositions.Size = new System.Drawing.Size(132, 123);
            this.btnViewPositions.TabIndex = 20;
            this.btnViewPositions.UseVisualStyleBackColor = true;
            // 
            // btnManagePositions
            // 
            this.btnManagePositions.Location = new System.Drawing.Point(245, 158);
            this.btnManagePositions.Name = "btnManagePositions";
            this.btnManagePositions.Size = new System.Drawing.Size(132, 123);
            this.btnManagePositions.TabIndex = 21;
            this.btnManagePositions.UseVisualStyleBackColor = true;
            // 
            // btnCreatePositions
            // 
            this.btnCreatePositions.Location = new System.Drawing.Point(48, 158);
            this.btnCreatePositions.Name = "btnCreatePositions";
            this.btnCreatePositions.Size = new System.Drawing.Size(132, 123);
            this.btnCreatePositions.TabIndex = 22;
            this.btnCreatePositions.UseVisualStyleBackColor = true;
            this.btnCreatePositions.Click += new System.EventHandler(this.btnCreatePositions_Click);
            // 
            // AdminPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewPositions);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewPositions;
        private System.Windows.Forms.Button btnManagePositions;
        private System.Windows.Forms.Button btnCreatePositions;
    }
}