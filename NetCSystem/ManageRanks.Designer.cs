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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRankCode = new System.Windows.Forms.TextBox();
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
            this.RankCode,
            this.RankSalary,
            this.Year});
            this.tblRank.Location = new System.Drawing.Point(12, 132);
            this.tblRank.Name = "tblRank";
            this.tblRank.ReadOnly = true;
            this.tblRank.Size = new System.Drawing.Size(760, 285);
            this.tblRank.TabIndex = 27;
            this.tblRank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRank_CellClick);
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
            this.txtRankID.Enabled = false;
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
            this.label4.Location = new System.Drawing.Point(6, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rank Salary:";
            // 
            // txtRankSalary
            // 
            this.txtRankSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtRankSalary.Location = new System.Drawing.Point(127, 562);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 64;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(168, 80);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(0, 13);
            this.lblStatusID.TabIndex = 65;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(64, 93);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 66;
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Location = new System.Drawing.Point(64, 80);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(0, 13);
            this.lblYearID.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Status:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(116, 80);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 69;
            this.l.Text = "Status ID:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 93);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 70;
            this.lb.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Year ID:";
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
            // RankCode
            // 
            this.RankCode.DataPropertyName = "rank_code";
            this.RankCode.HeaderText = "Rank Code";
            this.RankCode.Name = "RankCode";
            this.RankCode.ReadOnly = true;
            // 
            // RankSalary
            // 
            this.RankSalary.DataPropertyName = "rank_Salary";
            this.RankSalary.HeaderText = "Rank Salary";
            this.RankSalary.Name = "RankSalary";
            this.RankSalary.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "year_start";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Rank Code:";
            // 
            // txtRankCode
            // 
            this.txtRankCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtRankCode.Location = new System.Drawing.Point(121, 520);
            this.txtRankCode.Name = "txtRankCode";
            this.txtRankCode.Size = new System.Drawing.Size(188, 31);
            this.txtRankCode.TabIndex = 28;
            // 
            // ManageRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 607);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tblRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteRank);
            this.Controls.Add(this.btnUpdateRank);
            this.Controls.Add(this.txtRankSalary);
            this.Controls.Add(this.txtRankCode);
            this.Controls.Add(this.txtRankName);
            this.Controls.Add(this.txtRankID);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRankCode;
    }
}