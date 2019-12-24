namespace AIMProClient
{
    partial class ProfileForm
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
            this.korisnikLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitRatio = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotalTargerHits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalTargetMiss = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEndLess = new System.Windows.Forms.Label();
            this.lblPreciseShooting = new System.Windows.Forms.Label();
            this.lblFastShooting = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblDuel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridProfileStatistics = new System.Windows.Forms.DataGridView();
            this.TypeOfGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalMatch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfileStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnikLabel
            // 
            this.korisnikLabel.AutoSize = true;
            this.korisnikLabel.Location = new System.Drawing.Point(89, 31);
            this.korisnikLabel.Name = "korisnikLabel";
            this.korisnikLabel.Size = new System.Drawing.Size(0, 13);
            this.korisnikLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elo:";
            // 
            // lblElo
            // 
            this.lblElo.AutoSize = true;
            this.lblElo.Location = new System.Drawing.Point(37, 30);
            this.lblElo.Name = "lblElo";
            this.lblElo.Size = new System.Drawing.Size(0, 13);
            this.lblElo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hit ratio:";
            // 
            // lblHitRatio
            // 
            this.lblHitRatio.AutoSize = true;
            this.lblHitRatio.Location = new System.Drawing.Point(58, 59);
            this.lblHitRatio.Name = "lblHitRatio";
            this.lblHitRatio.Size = new System.Drawing.Size(0, 13);
            this.lblHitRatio.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 99);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Total target hits:";
            // 
            // lblTotalTargerHits
            // 
            this.lblTotalTargerHits.AutoSize = true;
            this.lblTotalTargerHits.Location = new System.Drawing.Point(95, 99);
            this.lblTotalTargerHits.Name = "lblTotalTargerHits";
            this.lblTotalTargerHits.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTargerHits.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalTargetMiss);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalTargerHits);
            this.groupBox1.Controls.Add(this.lblElo);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblHitRatio);
            this.groupBox1.Location = new System.Drawing.Point(15, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User statistics";
            // 
            // lblTotalTargetMiss
            // 
            this.lblTotalTargetMiss.AutoSize = true;
            this.lblTotalTargetMiss.Location = new System.Drawing.Point(102, 127);
            this.lblTotalTargetMiss.Name = "lblTotalTargetMiss";
            this.lblTotalTargetMiss.Size = new System.Drawing.Size(41, 13);
            this.lblTotalTargetMiss.TabIndex = 11;
            this.lblTotalTargetMiss.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total target miss:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalMatch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblEndLess);
            this.groupBox2.Controls.Add(this.lblPreciseShooting);
            this.groupBox2.Controls.Add(this.lblFastShooting);
            this.groupBox2.Controls.Add(this.lblMulti);
            this.groupBox2.Controls.Add(this.lblDuel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(264, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 182);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matchs played in rooms";
            // 
            // lblEndLess
            // 
            this.lblEndLess.AutoSize = true;
            this.lblEndLess.Location = new System.Drawing.Point(125, 140);
            this.lblEndLess.Name = "lblEndLess";
            this.lblEndLess.Size = new System.Drawing.Size(41, 13);
            this.lblEndLess.TabIndex = 9;
            this.lblEndLess.Text = "label13";
            // 
            // lblPreciseShooting
            // 
            this.lblPreciseShooting.AutoSize = true;
            this.lblPreciseShooting.Location = new System.Drawing.Point(118, 116);
            this.lblPreciseShooting.Name = "lblPreciseShooting";
            this.lblPreciseShooting.Size = new System.Drawing.Size(41, 13);
            this.lblPreciseShooting.TabIndex = 8;
            this.lblPreciseShooting.Text = "label12";
            // 
            // lblFastShooting
            // 
            this.lblFastShooting.AutoSize = true;
            this.lblFastShooting.Location = new System.Drawing.Point(103, 90);
            this.lblFastShooting.Name = "lblFastShooting";
            this.lblFastShooting.Size = new System.Drawing.Size(41, 13);
            this.lblFastShooting.TabIndex = 7;
            this.lblFastShooting.Text = "label11";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(138, 59);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(41, 13);
            this.lblMulti.TabIndex = 6;
            this.lblMulti.Text = "label10";
            // 
            // lblDuel
            // 
            this.lblDuel.AutoSize = true;
            this.lblDuel.Location = new System.Drawing.Point(60, 30);
            this.lblDuel.Name = "lblDuel";
            this.lblDuel.Size = new System.Drawing.Size(35, 13);
            this.lblDuel.TabIndex = 5;
            this.lblDuel.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Endless Campaign:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Precise Shooting:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fast Shooting:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MultyPlayer Shoot-off:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Match history";
            // 
            // dataGridProfileStatistics
            // 
            this.dataGridProfileStatistics.AllowUserToAddRows = false;
            this.dataGridProfileStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfileStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfGame,
            this.Rank,
            this.Points,
            this.Hits,
            this.Miss});
            this.dataGridProfileStatistics.Location = new System.Drawing.Point(12, 292);
            this.dataGridProfileStatistics.Name = "dataGridProfileStatistics";
            this.dataGridProfileStatistics.Size = new System.Drawing.Size(524, 150);
            this.dataGridProfileStatistics.TabIndex = 12;
            // 
            // TypeOfGame
            // 
            this.TypeOfGame.HeaderText = "Type of game";
            this.TypeOfGame.Name = "TypeOfGame";
            this.TypeOfGame.ReadOnly = true;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // Hits
            // 
            this.Hits.HeaderText = "Hits";
            this.Hits.Name = "Hits";
            this.Hits.ReadOnly = true;
            // 
            // Miss
            // 
            this.Miss.HeaderText = "Miss";
            this.Miss.Name = "Miss";
            this.Miss.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total:";
            // 
            // lblTotalMatch
            // 
            this.lblTotalMatch.AutoSize = true;
            this.lblTotalMatch.Location = new System.Drawing.Point(62, 166);
            this.lblTotalMatch.Name = "lblTotalMatch";
            this.lblTotalMatch.Size = new System.Drawing.Size(41, 13);
            this.lblTotalMatch.TabIndex = 11;
            this.lblTotalMatch.Text = "label12";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 396);
            this.Controls.Add(this.dataGridProfileStatistics);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnikLabel);
            this.Name = "ProfileForm";
            this.Text = "User profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfileStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnikLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitRatio;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTotalTargerHits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEndLess;
        private System.Windows.Forms.Label lblPreciseShooting;
        private System.Windows.Forms.Label lblFastShooting;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblDuel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalTargetMiss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridProfileStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miss;
        private System.Windows.Forms.Label lblTotalMatch;
        private System.Windows.Forms.Label label11;
    }
}