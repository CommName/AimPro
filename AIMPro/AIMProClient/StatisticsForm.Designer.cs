namespace AIMProClient
{
    partial class StatisticsForm
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
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HitRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTargetHits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AllowUserToAddRows = false;
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridStatistics.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.username,
            this.Elo,
            this.HitRatio,
            this.TotalTargetHits,
            this.viewProfile});
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 36);
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.Size = new System.Drawing.Size(800, 414);
            this.dataGridStatistics.TabIndex = 0;
            this.dataGridStatistics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStatistics_CellClick);
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "rank";
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Elo
            // 
            this.Elo.DataPropertyName = "Elo";
            this.Elo.HeaderText = "Elo";
            this.Elo.Name = "Elo";
            this.Elo.ReadOnly = true;
            this.Elo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HitRatio
            // 
            this.HitRatio.HeaderText = "Hit ratio";
            this.HitRatio.Name = "HitRatio";
            this.HitRatio.ReadOnly = true;
            this.HitRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalTargetHits
            // 
            this.TotalTargetHits.HeaderText = "Total target hits";
            this.TotalTargetHits.Name = "TotalTargetHits";
            this.TotalTargetHits.ReadOnly = true;
            this.TotalTargetHits.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // viewProfile
            // 
            this.viewProfile.HeaderText = "";
            this.viewProfile.Name = "viewProfile";
            this.viewProfile.ReadOnly = true;
            this.viewProfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewProfile.Text = "View profile";
            this.viewProfile.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridStatistics);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HitRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTargetHits;
        private System.Windows.Forms.DataGridViewButtonColumn viewProfile;
        private System.Windows.Forms.Label label1;
    }
}