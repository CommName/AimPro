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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.childChb = new System.Windows.Forms.CheckBox();
            this.navigateCb = new System.Windows.Forms.CheckBox();
            this.boostChb = new System.Windows.Forms.CheckBox();
            this.shieldChb = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Create and customize your Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name your room :";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(294, 90);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(276, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(427, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Game";
            // 
            // endlessRb
            // 
            this.endlessRb.AutoSize = true;
            this.endlessRb.Location = new System.Drawing.Point(21, 82);
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
            this.preciseRb.Enabled = false;
            this.preciseRb.Location = new System.Drawing.Point(21, 107);
            this.preciseRb.Name = "preciseRb";
            this.preciseRb.Size = new System.Drawing.Size(113, 19);
            this.preciseRb.TabIndex = 3;
            this.preciseRb.TabStop = true;
            this.preciseRb.Text = "Precise Shooting";
            this.preciseRb.UseVisualStyleBackColor = true;
            this.preciseRb.Visible = false;
            this.preciseRb.CheckedChanged += new System.EventHandler(this.preciseRb_CheckedChanged);
            // 
            // fastRb
            // 
            this.fastRb.AutoSize = true;
            this.fastRb.Location = new System.Drawing.Point(21, 57);
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
            this.multyPlayerRb.Location = new System.Drawing.Point(21, 32);
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
            this.duelRb.Enabled = false;
            this.duelRb.Location = new System.Drawing.Point(21, 132);
            this.duelRb.Name = "duelRb";
            this.duelRb.Size = new System.Drawing.Size(50, 19);
            this.duelRb.TabIndex = 0;
            this.duelRb.TabStop = true;
            this.duelRb.Text = "Duel";
            this.duelRb.UseVisualStyleBackColor = true;
            this.duelRb.Visible = false;
            this.duelRb.CheckedChanged += new System.EventHandler(this.duelRb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.childChb);
            this.groupBox3.Controls.Add(this.navigateCb);
            this.groupBox3.Controls.Add(this.shieldChb);
            this.groupBox3.Controls.Add(this.boostChb);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of Targets";
            // 
            // childChb
            // 
            this.childChb.AutoSize = true;
            this.childChb.Location = new System.Drawing.Point(19, 145);
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
            this.navigateCb.Location = new System.Drawing.Point(19, 108);
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
            this.boostChb.Location = new System.Drawing.Point(19, 69);
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
            this.shieldChb.Location = new System.Drawing.Point(19, 32);
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
            this.createBtn.Location = new System.Drawing.Point(592, 89);
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
            this.backBtn.Location = new System.Drawing.Point(378, 510);
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
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateRoomForm";
            this.Size = new System.Drawing.Size(827, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox childChb;
        private System.Windows.Forms.CheckBox navigateCb;
        private System.Windows.Forms.CheckBox boostChb;
        private System.Windows.Forms.CheckBox shieldChb;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
    }
}