namespace NetCSystem
{
    partial class CreateEquipment
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
            this.txtNewEquipmentCost = new System.Windows.Forms.TextBox();
            this.txtNewEquipmentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(285, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 48);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(285, 233);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(242, 48);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNewEquipmentCost
            // 
            this.txtNewEquipmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewEquipmentCost.Location = new System.Drawing.Point(285, 176);
            this.txtNewEquipmentCost.Name = "txtNewEquipmentCost";
            this.txtNewEquipmentCost.Size = new System.Drawing.Size(242, 31);
            this.txtNewEquipmentCost.TabIndex = 34;
            this.txtNewEquipmentCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewEquipmentCost_KeyPress);
            // 
            // txtNewEquipmentName
            // 
            this.txtNewEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNewEquipmentName.Location = new System.Drawing.Point(285, 134);
            this.txtNewEquipmentName.Name = "txtNewEquipmentName";
            this.txtNewEquipmentName.Size = new System.Drawing.Size(242, 31);
            this.txtNewEquipmentName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Equipment Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Equipment Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "CREATE EQUIPMENT";
            // 
            // CreateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNewEquipmentCost);
            this.Controls.Add(this.txtNewEquipmentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNewEquipmentCost;
        private System.Windows.Forms.TextBox txtNewEquipmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}