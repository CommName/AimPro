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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDuel = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblFastShooting = new System.Windows.Forms.Label();
            this.lblPreciseShooting = new System.Windows.Forms.Label();
            this.lblEndLess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(6, 59);
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
            this.groupBox1.Text = "User global statistics";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(237, 166);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of hits in rooms";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MultyPlayer Shoot-off:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Precise Shooting:";
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
            // lblDuel
            // 
            this.lblDuel.AutoSize = true;
            this.lblDuel.Location = new System.Drawing.Point(60, 30);
            this.lblDuel.Name = "lblDuel";
            this.lblDuel.Size = new System.Drawing.Size(35, 13);
            this.lblDuel.TabIndex = 5;
            this.lblDuel.Text = "label9";
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
            // lblFastShooting
            // 
            this.lblFastShooting.AutoSize = true;
            this.lblFastShooting.Location = new System.Drawing.Point(103, 90);
            this.lblFastShooting.Name = "lblFastShooting";
            this.lblFastShooting.Size = new System.Drawing.Size(41, 13);
            this.lblFastShooting.TabIndex = 7;
            this.lblFastShooting.Text = "label11";
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
            // lblEndLess
            // 
            this.lblEndLess.AutoSize = true;
            this.lblEndLess.Location = new System.Drawing.Point(125, 140);
            this.lblEndLess.Name = "lblEndLess";
            this.lblEndLess.Size = new System.Drawing.Size(41, 13);
            this.lblEndLess.TabIndex = 9;
            this.lblEndLess.Text = "label13";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 284);
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
    }
}