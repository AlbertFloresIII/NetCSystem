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
            this.label3.Location = new System.Drawing.Point(90, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "ECHELON NAME:";
            // 
            // txtNewEchelonName
            // 
            this.txtNewEchelonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewEchelonName.Location = new System.Drawing.Point(257, 132);
            this.txtNewEchelonName.Name = "txtNewEchelonName";
            this.txtNewEchelonName.Size = new System.Drawing.Size(242, 31);
            this.txtNewEchelonName.TabIndex = 21;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(257, 201);
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
            this.btnBack.Location = new System.Drawing.Point(257, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 48);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateEchelon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
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
    }
}