namespace AIMProClient
{
    partial class CreateRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endlessRb = new System.Windows.Forms.RadioButton();
            this.preciseRb = new System.Windows.Forms.RadioButton();
            this.fastRb = new System.Windows.Forms.RadioButton();
            this.multyPlayerRb = new System.Windows.Forms.RadioButton();
            this.duelRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codePanel = new System.Windows.Forms.Panel();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privateRb = new System.Windows.Forms.RadioButton();
            this.publicRb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bazookaChb = new System.Windows.Forms.CheckBox();
            this.drunkChb = new System.Windows.Forms.CheckBox();
            this.limitedChb = new System.Windows.Forms.CheckBox();
            this.piercingChb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.childChb = new System.Windows.Forms.CheckBox();
            this.navigateCb = new System.Windows.Forms.CheckBox();
            this.boostChb = new System.Windows.Forms.CheckBox();
            this.shieldChb = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Create and customize your Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name your room :";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(396, 50);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(179, 22);
            this.nameTxtBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endlessRb);
            this.groupBox1.Controls.Add(this.preciseRb);
            this.groupBox1.Controls.Add(this.fastRb);
            this.groupBox1.Controls.Add(this.multyPlayerRb);
            this.groupBox1.Controls.Add(this.duelRb);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(483, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Game";
            // 
            // endlessRb
            // 
            this.endlessRb.AutoSize = true;
            this.endlessRb.Location = new System.Drawing.Point(47, 143);
            this.endlessRb.Name = "endlessRb";
            this.endlessRb.Size = new System.Drawing.Size(122, 19);
            this.endlessRb.TabIndex = 4;
            this.endlessRb.TabStop = true;
            this.endlessRb.Text = "Endless Campaign";
            this.endlessRb.UseVisualStyleBackColor = true;
            this.endlessRb.CheckedChanged += new System.EventHandler(this.endlessRb_CheckedChanged);
            // 
            // preciseRb
            // 
            this.preciseRb.AutoSize = true;
            this.preciseRb.Location = new System.Drawing.Point(47, 120);
            this.preciseRb.Name = "preciseRb";
            this.preciseRb.Size = new System.Drawing.Size(113, 19);
            this.preciseRb.TabIndex = 3;
            this.preciseRb.TabStop = true;
            this.preciseRb.Text = "Precise Shooting";
            this.preciseRb.UseVisualStyleBackColor = true;
            this.preciseRb.CheckedChanged += new System.EventHandler(this.preciseRb_CheckedChanged);
            // 
            // fastRb
            // 
            this.fastRb.AutoSize = true;
            this.fastRb.Location = new System.Drawing.Point(47, 97);
            this.fastRb.Name = "fastRb";
            this.fastRb.Size = new System.Drawing.Size(99, 19);
            this.fastRb.TabIndex = 2;
            this.fastRb.TabStop = true;
            this.fastRb.Text = "Fast Shooting";
            this.fastRb.UseVisualStyleBackColor = true;
            this.fastRb.CheckedChanged += new System.EventHandler(this.fastRb_CheckedChanged);
            // 
            // multyPlayerRb
            // 
            this.multyPlayerRb.AutoSize = true;
            this.multyPlayerRb.Location = new System.Drawing.Point(47, 74);
            this.multyPlayerRb.Name = "multyPlayerRb";
            this.multyPlayerRb.Size = new System.Drawing.Size(145, 19);
            this.multyPlayerRb.TabIndex = 1;
            this.multyPlayerRb.TabStop = true;
            this.multyPlayerRb.Text = "MultyPlayer Shoot-off";
            this.multyPlayerRb.UseVisualStyleBackColor = true;
            this.multyPlayerRb.CheckedChanged += new System.EventHandler(this.multyPlayerRb_CheckedChanged);
            // 
            // duelRb
            // 
            this.duelRb.AutoSize = true;
            this.duelRb.Location = new System.Drawing.Point(47, 51);
            this.duelRb.Name = "duelRb";
            this.duelRb.Size = new System.Drawing.Size(50, 19);
            this.duelRb.TabIndex = 0;
            this.duelRb.TabStop = true;
            this.duelRb.Text = "Duel";
            this.duelRb.UseVisualStyleBackColor = true;
            this.duelRb.CheckedChanged += new System.EventHandler(this.duelRb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.codePanel);
            this.groupBox2.Controls.Add(this.privateRb);
            this.groupBox2.Controls.Add(this.publicRb);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(712, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Room";
            // 
            // codePanel
            // 
            this.codePanel.Controls.Add(this.codeTxtBox);
            this.codePanel.Controls.Add(this.label3);
            this.codePanel.Location = new System.Drawing.Point(26, 111);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(173, 59);
            this.codePanel.TabIndex = 5;
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxtBox.Location = new System.Drawing.Point(35, 26);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.Size = new System.Drawing.Size(100, 22);
            this.codeTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Your Room Code";
            // 
            // privateRb
            // 
            this.privateRb.AutoSize = true;
            this.privateRb.Location = new System.Drawing.Point(124, 46);
            this.privateRb.Name = "privateRb";
            this.privateRb.Size = new System.Drawing.Size(63, 19);
            this.privateRb.TabIndex = 1;
            this.privateRb.TabStop = true;
            this.privateRb.Text = "Private";
            this.privateRb.UseVisualStyleBackColor = true;
            this.privateRb.CheckedChanged += new System.EventHandler(this.privateRb_CheckedChanged);
            // 
            // publicRb
            // 
            this.publicRb.AutoSize = true;
            this.publicRb.Location = new System.Drawing.Point(34, 46);
            this.publicRb.Name = "publicRb";
            this.publicRb.Size = new System.Drawing.Size(59, 19);
            this.publicRb.TabIndex = 0;
            this.publicRb.TabStop = true;
            this.publicRb.Text = "Public";
            this.publicRb.UseVisualStyleBackColor = true;
            this.publicRb.CheckedChanged += new System.EventHandler(this.publicRb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of Targets and Ammo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bazookaChb);
            this.groupBox5.Controls.Add(this.drunkChb);
            this.groupBox5.Controls.Add(this.limitedChb);
            this.groupBox5.Controls.Add(this.piercingChb);
            this.groupBox5.Location = new System.Drawing.Point(222, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 146);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ammo";
            // 
            // bazookaChb
            // 
            this.bazookaChb.AutoSize = true;
            this.bazookaChb.Location = new System.Drawing.Point(15, 100);
            this.bazookaChb.Name = "bazookaChb";
            this.bazookaChb.Size = new System.Drawing.Size(71, 19);
            this.bazookaChb.TabIndex = 5;
            this.bazookaChb.Text = "Bazooka";
            this.bazookaChb.UseVisualStyleBackColor = true;
            this.bazookaChb.CheckedChanged += new System.EventHandler(this.bazookaChb_CheckedChanged);
            // 
            // drunkChb
            // 
            this.drunkChb.AutoSize = true;
            this.drunkChb.Location = new System.Drawing.Point(15, 75);
            this.drunkChb.Name = "drunkChb";
            this.drunkChb.Size = new System.Drawing.Size(61, 19);
            this.drunkChb.TabIndex = 4;
            this.drunkChb.Text = "Drunk";
            this.drunkChb.UseVisualStyleBackColor = true;
            this.drunkChb.CheckedChanged += new System.EventHandler(this.drunkChb_CheckedChanged);
            // 
            // limitedChb
            // 
            this.limitedChb.AutoSize = true;
            this.limitedChb.Location = new System.Drawing.Point(15, 50);
            this.limitedChb.Name = "limitedChb";
            this.limitedChb.Size = new System.Drawing.Size(68, 19);
            this.limitedChb.TabIndex = 3;
            this.limitedChb.Text = "Limited";
            this.limitedChb.UseVisualStyleBackColor = true;
            this.limitedChb.CheckedChanged += new System.EventHandler(this.limitedChb_CheckedChanged);
            // 
            // piercingChb
            // 
            this.piercingChb.AutoSize = true;
            this.piercingChb.Location = new System.Drawing.Point(15, 24);
            this.piercingChb.Name = "piercingChb";
            this.piercingChb.Size = new System.Drawing.Size(70, 19);
            this.piercingChb.TabIndex = 1;
            this.piercingChb.Text = "Piercing";
            this.piercingChb.UseVisualStyleBackColor = true;
            this.piercingChb.CheckedChanged += new System.EventHandler(this.piercingChb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.childChb);
            this.groupBox4.Controls.Add(this.navigateCb);
            this.groupBox4.Controls.Add(this.boostChb);
            this.groupBox4.Controls.Add(this.shieldChb);
            this.groupBox4.Location = new System.Drawing.Point(22, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 146);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Targets";
            // 
            // childChb
            // 
            this.childChb.AutoSize = true;
            this.childChb.Location = new System.Drawing.Point(8, 101);
            this.childChb.Name = "childChb";
            this.childChb.Size = new System.Drawing.Size(97, 19);
            this.childChb.TabIndex = 4;
            this.childChb.Text = "Child Targets";
            this.childChb.UseVisualStyleBackColor = true;
            this.childChb.CheckedChanged += new System.EventHandler(this.childChb_CheckedChanged);
            // 
            // navigateCb
            // 
            this.navigateCb.AutoSize = true;
            this.navigateCb.Location = new System.Drawing.Point(8, 76);
            this.navigateCb.Name = "navigateCb";
            this.navigateCb.Size = new System.Drawing.Size(114, 19);
            this.navigateCb.TabIndex = 3;
            this.navigateCb.Text = "Negative Targets";
            this.navigateCb.UseVisualStyleBackColor = true;
            this.navigateCb.CheckedChanged += new System.EventHandler(this.navigateCb_CheckedChanged);
            // 
            // boostChb
            // 
            this.boostChb.AutoSize = true;
            this.boostChb.Location = new System.Drawing.Point(8, 50);
            this.boostChb.Name = "boostChb";
            this.boostChb.Size = new System.Drawing.Size(99, 19);
            this.boostChb.TabIndex = 2;
            this.boostChb.Text = "Boost Targets";
            this.boostChb.UseVisualStyleBackColor = true;
            this.boostChb.CheckedChanged += new System.EventHandler(this.boostChb_CheckedChanged);
            // 
            // shieldChb
            // 
            this.shieldChb.AutoSize = true;
            this.shieldChb.Location = new System.Drawing.Point(8, 24);
            this.shieldChb.Name = "shieldChb";
            this.shieldChb.Size = new System.Drawing.Size(70, 19);
            this.shieldChb.TabIndex = 1;
            this.shieldChb.Text = "Shielded";
            this.shieldChb.UseVisualStyleBackColor = true;
            this.shieldChb.CheckedChanged += new System.EventHandler(this.shieldChb_CheckedChanged);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(592, 49);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(91, 24);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create Room";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::AIMProClient.Properties.Resources.nazadd;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(847, 311);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 348);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateRoomForm";
            this.Text = "Create Room";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton endlessRb;
        private System.Windows.Forms.RadioButton preciseRb;
        private System.Windows.Forms.RadioButton fastRb;
        private System.Windows.Forms.RadioButton multyPlayerRb;
        private System.Windows.Forms.RadioButton duelRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton privateRb;
        private System.Windows.Forms.RadioButton publicRb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox bazookaChb;
        private System.Windows.Forms.CheckBox drunkChb;
        private System.Windows.Forms.CheckBox limitedChb;
        private System.Windows.Forms.CheckBox piercingChb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox childChb;
        private System.Windows.Forms.CheckBox navigateCb;
        private System.Windows.Forms.CheckBox boostChb;
        private System.Windows.Forms.CheckBox shieldChb;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
    }
}