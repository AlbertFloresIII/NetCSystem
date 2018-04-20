namespace NetCSystem
{
    partial class Status
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
            this.btnActual = new System.Windows.Forms.Button();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.btnIdeal = new System.Windows.Forms.Button();
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
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "ACTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "ACCEPTED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "IDEAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "STATUS";
            // 
            // btnActual
            // 
            this.btnActual.Location = new System.Drawing.Point(445, 158);
            this.btnActual.Name = "btnActual";
            this.btnActual.Size = new System.Drawing.Size(132, 123);
            this.btnActual.TabIndex = 20;
            this.btnActual.UseVisualStyleBackColor = true;
            this.btnActual.Click += new System.EventHandler(this.btnActual_Click);
            // 
            // btnAccepted
            // 
            this.btnAccepted.Location = new System.Drawing.Point(245, 158);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(132, 123);
            this.btnAccepted.TabIndex = 21;
            this.btnAccepted.UseVisualStyleBackColor = true;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // btnIdeal
            // 
            this.btnIdeal.Location = new System.Drawing.Point(48, 158);
            this.btnIdeal.Name = "btnIdeal";
            this.btnIdeal.Size = new System.Drawing.Size(132, 123);
            this.btnIdeal.TabIndex = 22;
            this.btnIdeal.UseVisualStyleBackColor = true;
            this.btnIdeal.Click += new System.EventHandler(this.btnIdeal_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActual);
            this.Controls.Add(this.btnAccepted);
            this.Controls.Add(this.btnIdeal);
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActual;
        private System.Windows.Forms.Button btnAccepted;
        private System.Windows.Forms.Button btnIdeal;
    }
}