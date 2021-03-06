﻿namespace AIMProClient
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
            this.lblTotalMatch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEndLess = new System.Windows.Forms.Label();
            this.lblPreciseShooting = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridProfileStatistics = new System.Windows.Forms.DataGridView();
            this.TypeOfGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfileStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnikLabel
            // 
            this.korisnikLabel.AutoSize = true;
            this.korisnikLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnikLabel.Location = new System.Drawing.Point(291, 21);
            this.korisnikLabel.Name = "korisnikLabel";
            this.korisnikLabel.Size = new System.Drawing.Size(0, 21);
            this.korisnikLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elo:";
            // 
            // lblElo
            // 
            this.lblElo.AutoSize = true;
            this.lblElo.Location = new System.Drawing.Point(130, 30);
            this.lblElo.Name = "lblElo";
            this.lblElo.Size = new System.Drawing.Size(0, 14);
            this.lblElo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hit ratio:";
            // 
            // lblHitRatio
            // 
            this.lblHitRatio.AutoSize = true;
            this.lblHitRatio.Location = new System.Drawing.Point(130, 59);
            this.lblHitRatio.Name = "lblHitRatio";
            this.lblHitRatio.Size = new System.Drawing.Size(0, 14);
            this.lblHitRatio.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 99);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 14);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Total target hits:";
            // 
            // lblTotalTargerHits
            // 
            this.lblTotalTargerHits.AutoSize = true;
            this.lblTotalTargerHits.Location = new System.Drawing.Point(130, 99);
            this.lblTotalTargerHits.Name = "lblTotalTargerHits";
            this.lblTotalTargerHits.Size = new System.Drawing.Size(0, 14);
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
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User statistics";
            // 
            // lblTotalTargetMiss
            // 
            this.lblTotalTargetMiss.AutoSize = true;
            this.lblTotalTargetMiss.Location = new System.Drawing.Point(130, 143);
            this.lblTotalTargetMiss.Name = "lblTotalTargetMiss";
            this.lblTotalTargetMiss.Size = new System.Drawing.Size(37, 14);
            this.lblTotalTargetMiss.TabIndex = 11;
            this.lblTotalTargetMiss.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total target miss:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalMatch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblEndLess);
            this.groupBox2.Controls.Add(this.lblPreciseShooting);
            this.groupBox2.Controls.Add(this.lblMulti);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(289, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 182);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matchs played in rooms";
            // 
            // lblTotalMatch
            // 
            this.lblTotalMatch.AutoSize = true;
            this.lblTotalMatch.Location = new System.Drawing.Point(146, 143);
            this.lblTotalMatch.Name = "lblTotalMatch";
            this.lblTotalMatch.Size = new System.Drawing.Size(37, 14);
            this.lblTotalMatch.TabIndex = 11;
            this.lblTotalMatch.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total:";
            // 
            // lblEndLess
            // 
            this.lblEndLess.AutoSize = true;
            this.lblEndLess.Location = new System.Drawing.Point(146, 99);
            this.lblEndLess.Name = "lblEndLess";
            this.lblEndLess.Size = new System.Drawing.Size(37, 14);
            this.lblEndLess.TabIndex = 9;
            this.lblEndLess.Text = "label13";
            // 
            // lblPreciseShooting
            // 
            this.lblPreciseShooting.AutoSize = true;
            this.lblPreciseShooting.Location = new System.Drawing.Point(146, 59);
            this.lblPreciseShooting.Name = "lblPreciseShooting";
            this.lblPreciseShooting.Size = new System.Drawing.Size(37, 14);
            this.lblPreciseShooting.TabIndex = 8;
            this.lblPreciseShooting.Text = "label12";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(146, 26);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(37, 14);
            this.lblMulti.TabIndex = 6;
            this.lblMulti.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Endless Campaign:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Precise Shooting:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "MultyPlayer FFA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Match history";
            // 
            // dataGridProfileStatistics
            // 
            this.dataGridProfileStatistics.AllowUserToAddRows = false;
            this.dataGridProfileStatistics.AllowUserToDeleteRows = false;
            this.dataGridProfileStatistics.AllowUserToResizeColumns = false;
            this.dataGridProfileStatistics.AllowUserToResizeRows = false;
            this.dataGridProfileStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProfileStatistics.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridProfileStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfileStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfGame,
            this.Rank,
            this.Points,
            this.Hits,
            this.Miss});
            this.dataGridProfileStatistics.Location = new System.Drawing.Point(12, 292);
            this.dataGridProfileStatistics.Name = "dataGridProfileStatistics";
            this.dataGridProfileStatistics.Size = new System.Drawing.Size(549, 150);
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
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::AIMProClient.Properties.Resources.nazadd;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(506, 448);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(55, 23);
            this.backBtn.TabIndex = 13;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(573, 476);
            this.Controls.Add(this.backBtn);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEndLess;
        private System.Windows.Forms.Label lblPreciseShooting;
        private System.Windows.Forms.Label lblMulti;
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
        private System.Windows.Forms.Button backBtn;
    }
}