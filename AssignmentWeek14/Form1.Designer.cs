namespace AssignmentWeek14
{
    partial class FormTeam
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.lblWorstDiscipline = new System.Windows.Forms.Label();
            this.lblHasilTeamName = new System.Windows.Forms.Label();
            this.lblHasilManager = new System.Windows.Forms.Label();
            this.lblHasilStadium = new System.Windows.Forms.Label();
            this.lblHasilTopScorer = new System.Windows.Forms.Label();
            this.lblHasilWorstDiscipline = new System.Windows.Forms.Label();
            this.dgvPertandingan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPertandingan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(62, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(58, 44);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(126, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(58, 44);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(190, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(254, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(58, 44);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(40, 71);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(68, 13);
            this.lblTeamName.TabIndex = 4;
            this.lblTeamName.Text = "Team Name:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(56, 95);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(52, 13);
            this.lblManager.TabIndex = 5;
            this.lblManager.Text = "Manager:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(60, 120);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(48, 13);
            this.lblStadium.TabIndex = 6;
            this.lblStadium.Text = "Stadium:";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Location = new System.Drawing.Point(42, 145);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(66, 13);
            this.lblTopScorer.TabIndex = 7;
            this.lblTopScorer.Text = "Top Scrorer:";
            // 
            // lblWorstDiscipline
            // 
            this.lblWorstDiscipline.AutoSize = true;
            this.lblWorstDiscipline.Location = new System.Drawing.Point(22, 172);
            this.lblWorstDiscipline.Name = "lblWorstDiscipline";
            this.lblWorstDiscipline.Size = new System.Drawing.Size(86, 13);
            this.lblWorstDiscipline.TabIndex = 8;
            this.lblWorstDiscipline.Text = "Worst Discipline:";
            // 
            // lblHasilTeamName
            // 
            this.lblHasilTeamName.AutoSize = true;
            this.lblHasilTeamName.Location = new System.Drawing.Point(115, 71);
            this.lblHasilTeamName.Name = "lblHasilTeamName";
            this.lblHasilTeamName.Size = new System.Drawing.Size(22, 13);
            this.lblHasilTeamName.TabIndex = 9;
            this.lblHasilTeamName.Text = ".....";
            // 
            // lblHasilManager
            // 
            this.lblHasilManager.AutoSize = true;
            this.lblHasilManager.Location = new System.Drawing.Point(115, 95);
            this.lblHasilManager.Name = "lblHasilManager";
            this.lblHasilManager.Size = new System.Drawing.Size(22, 13);
            this.lblHasilManager.TabIndex = 10;
            this.lblHasilManager.Text = ".....";
            // 
            // lblHasilStadium
            // 
            this.lblHasilStadium.AutoSize = true;
            this.lblHasilStadium.Location = new System.Drawing.Point(115, 120);
            this.lblHasilStadium.Name = "lblHasilStadium";
            this.lblHasilStadium.Size = new System.Drawing.Size(22, 13);
            this.lblHasilStadium.TabIndex = 11;
            this.lblHasilStadium.Text = ".....";
            // 
            // lblHasilTopScorer
            // 
            this.lblHasilTopScorer.AutoSize = true;
            this.lblHasilTopScorer.Location = new System.Drawing.Point(115, 145);
            this.lblHasilTopScorer.Name = "lblHasilTopScorer";
            this.lblHasilTopScorer.Size = new System.Drawing.Size(22, 13);
            this.lblHasilTopScorer.TabIndex = 12;
            this.lblHasilTopScorer.Text = ".....";
            // 
            // lblHasilWorstDiscipline
            // 
            this.lblHasilWorstDiscipline.AutoSize = true;
            this.lblHasilWorstDiscipline.Location = new System.Drawing.Point(115, 172);
            this.lblHasilWorstDiscipline.Name = "lblHasilWorstDiscipline";
            this.lblHasilWorstDiscipline.Size = new System.Drawing.Size(22, 13);
            this.lblHasilWorstDiscipline.TabIndex = 13;
            this.lblHasilWorstDiscipline.Text = ".....";
            // 
            // dgvPertandingan
            // 
            this.dgvPertandingan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPertandingan.Location = new System.Drawing.Point(12, 198);
            this.dgvPertandingan.Name = "dgvPertandingan";
            this.dgvPertandingan.Size = new System.Drawing.Size(351, 155);
            this.dgvPertandingan.TabIndex = 14;
            this.dgvPertandingan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPertandingan_CellContentClick);
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 356);
            this.Controls.Add(this.dgvPertandingan);
            this.Controls.Add(this.lblHasilWorstDiscipline);
            this.Controls.Add(this.lblHasilTopScorer);
            this.Controls.Add(this.lblHasilStadium);
            this.Controls.Add(this.lblHasilManager);
            this.Controls.Add(this.lblHasilTeamName);
            this.Controls.Add(this.lblWorstDiscipline);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPertandingan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblTopScorer;
        private System.Windows.Forms.Label lblWorstDiscipline;
        private System.Windows.Forms.Label lblHasilTeamName;
        private System.Windows.Forms.Label lblHasilManager;
        private System.Windows.Forms.Label lblHasilStadium;
        private System.Windows.Forms.Label lblHasilTopScorer;
        private System.Windows.Forms.Label lblHasilWorstDiscipline;
        private System.Windows.Forms.DataGridView dgvPertandingan;
    }
}

