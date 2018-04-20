namespace NetCSystem
{
    partial class CreateRanks
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
            this.txtNewRankName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewRankSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(282, 310);
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
            this.btnCreate.Location = new System.Drawing.Point(282, 256);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(242, 48);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNewRankName
            // 
            this.txtNewRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewRankName.Location = new System.Drawing.Point(282, 157);
            this.txtNewRankName.Name = "txtNewRankName";
            this.txtNewRankName.Size = new System.Drawing.Size(242, 31);
            this.txtNewRankName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rank Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "CREATE RANKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rank Salary:";
            // 
            // txtNewRankSalary
            // 
            this.txtNewRankSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewRankSalary.Location = new System.Drawing.Point(282, 199);
            this.txtNewRankSalary.Name = "txtNewRankSalary";
            this.txtNewRankSalary.Size = new System.Drawing.Size(242, 31);
            this.txtNewRankSalary.TabIndex = 26;
            this.txtNewRankSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRankSalary_KeyPress);
            // 
            // CreateRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNewRankSalary);
            this.Controls.Add(this.txtNewRankName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateRanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNewRankName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewRankSalary;
    }
}