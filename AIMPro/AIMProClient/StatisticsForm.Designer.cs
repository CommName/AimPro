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
            this.HitRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTargetHits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.HitRatio,
            this.TotalTargetHits});
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.Size = new System.Drawing.Size(800, 450);
            this.dataGridStatistics.TabIndex = 0;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            // 
            // HitRatio
            // 
            this.HitRatio.HeaderText = "Hit ratio";
            this.HitRatio.Name = "HitRatio";
            // 
            // TotalTargetHits
            // 
            this.TotalTargetHits.HeaderText = "Total target hits";
            this.TotalTargetHits.Name = "TotalTargetHits";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridStatistics);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn HitRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTargetHits;
    }
}