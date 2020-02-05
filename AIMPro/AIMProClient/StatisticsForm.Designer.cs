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
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AllowUserToAddRows = false;
            this.dataGridStatistics.AllowUserToDeleteRows = false;
            this.dataGridStatistics.AllowUserToResizeColumns = false;
            this.dataGridStatistics.AllowUserToResizeRows = false;
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridStatistics.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.username,
            this.Elo,
            this.HitRatio,
            this.TotalTargetHits,
            this.viewProfile});
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.Size = new System.Drawing.Size(827, 550);
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
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn.Location = new System.Drawing.Point(0, 515);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(827, 35);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridStatistics);
            this.Name = "StatisticsForm";
            this.Size = new System.Drawing.Size(827, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HitRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTargetHits;
        private System.Windows.Forms.DataGridViewButtonColumn viewProfile;
        private System.Windows.Forms.Button backBtn;
    }
}