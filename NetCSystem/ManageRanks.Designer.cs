namespace NetCSystem
{
    partial class ManageRanks
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
            this.tblRank = new System.Windows.Forms.DataGridView();
            this.RankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRank = new System.Windows.Forms.Button();
            this.txtRankName = new System.Windows.Forms.TextBox();
            this.txtRankID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRankSalary = new System.Windows.Forms.TextBox();
            this.btnDeleteRank = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblRank)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRank
            // 
            this.tblRank.AllowUserToAddRows = false;
            this.tblRank.AllowUserToDeleteRows = false;
            this.tblRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankID,
            this.RankName,
            this.RankSalary});
            this.tblRank.Location = new System.Drawing.Point(12, 86);
            this.tblRank.Name = "tblRank";
            this.tblRank.ReadOnly = true;
            this.tblRank.Size = new System.Drawing.Size(760, 331);
            this.tblRank.TabIndex = 27;
            this.tblRank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRank_CellClick);
            // 
            // RankID
            // 
            this.RankID.DataPropertyName = "rank_ID";
            this.RankID.HeaderText = "Rank ID";
            this.RankID.Name = "RankID";
            this.RankID.ReadOnly = true;
            // 
            // RankName
            // 
            this.RankName.DataPropertyName = "rank_Name";
            this.RankName.HeaderText = "Rank Name";
            this.RankName.Name = "RankName";
            this.RankName.ReadOnly = true;
            // 
            // RankSalary
            // 
            this.RankSalary.DataPropertyName = "rank_Salary";
            this.RankSalary.HeaderText = "Rank Salary";
            this.RankSalary.Name = "RankSalary";
            this.RankSalary.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "MANAGE RANKS";
            // 
            // btnUpdateRank
            // 
            this.btnUpdateRank.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRank.Location = new System.Drawing.Point(419, 433);
            this.btnUpdateRank.Name = "btnUpdateRank";
            this.btnUpdateRank.Size = new System.Drawing.Size(148, 45);
            this.btnUpdateRank.TabIndex = 32;
            this.btnUpdateRank.Text = "Update";
            this.btnUpdateRank.UseVisualStyleBackColor = true;
            this.btnUpdateRank.Click += new System.EventHandler(this.btnUpdateRank_Click);
            // 
            // txtRankName
            // 
            this.txtRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtRankName.Location = new System.Drawing.Point(121, 475);
            this.txtRankName.Name = "txtRankName";
            this.txtRankName.Size = new System.Drawing.Size(188, 31);
            this.txtRankName.TabIndex = 28;
            // 
            // txtRankID
            // 
            this.txtRankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtRankID.Location = new System.Drawing.Point(121, 428);
            this.txtRankID.Name = "txtRankID";
            this.txtRankID.Size = new System.Drawing.Size(188, 31);
            this.txtRankID.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rank Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rank ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rank Salary:";
            // 
            // txtRankSalary
            // 
            this.txtRankSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtRankSalary.Location = new System.Drawing.Point(127, 521);
            this.txtRankSalary.Name = "txtRankSalary";
            this.txtRankSalary.Size = new System.Drawing.Size(182, 31);
            this.txtRankSalary.TabIndex = 28;
            this.txtRankSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRankSalary_KeyPress);
            // 
            // btnDeleteRank
            // 
            this.btnDeleteRank.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRank.Location = new System.Drawing.Point(603, 433);
            this.btnDeleteRank.Name = "btnDeleteRank";
            this.btnDeleteRank.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteRank.TabIndex = 32;
            this.btnDeleteRank.Text = "Delete";
            this.btnDeleteRank.UseVisualStyleBackColor = true;
            this.btnDeleteRank.Click += new System.EventHandler(this.btnDeleteRank_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(509, 484);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 45);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tblRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteRank);
            this.Controls.Add(this.btnUpdateRank);
            this.Controls.Add(this.txtRankSalary);
            this.Controls.Add(this.txtRankName);
            this.Controls.Add(this.txtRankID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManageRanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            ((System.ComponentModel.ISupportInitialize)(this.tblRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateRank;
        private System.Windows.Forms.TextBox txtRankName;
        private System.Windows.Forms.TextBox txtRankID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRankSalary;
        private System.Windows.Forms.Button btnDeleteRank;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankSalary;
    }
}