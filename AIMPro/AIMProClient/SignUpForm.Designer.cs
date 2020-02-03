namespace AIMProClient
{
    partial class SignUpForm
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
            this.usernameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.maskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameSignUpTextBox
            // 
            this.usernameSignUpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSignUpTextBox.Location = new System.Drawing.Point(126, 73);
            this.usernameSignUpTextBox.Name = "usernameSignUpTextBox";
            this.usernameSignUpTextBox.Size = new System.Drawing.Size(100, 26);
            this.usernameSignUpTextBox.TabIndex = 1;
            this.usernameSignUpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameSignUpTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // passwordSignUpTextBox
            // 
            this.passwordSignUpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignUpTextBox.Location = new System.Drawing.Point(126, 123);
            this.passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            this.passwordSignUpTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordSignUpTextBox.TabIndex = 3;
            this.passwordSignUpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordSignUpTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "*AIMPro Sign Up*";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(117, 156);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(7, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "\r\n";
            // 
            // signUpButton
            // 
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(126, 168);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(100, 35);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::AIMProClient.Properties.Resources.nazadd;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(274, 197);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 29);
            this.backBtn.TabIndex = 8;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // maskButton
            // 
            this.maskButton.BackgroundImage = global::AIMProClient.Properties.Resources.oko12;
            this.maskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maskButton.Location = new System.Drawing.Point(240, 121);
            this.maskButton.Name = "maskButton";
            this.maskButton.Size = new System.Drawing.Size(38, 30);
            this.maskButton.TabIndex = 7;
            this.maskButton.UseVisualStyleBackColor = true;
            this.maskButton.Click += new System.EventHandler(this.maskButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 238);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.maskButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordSignUpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameSignUpTextBox);
            this.Controls.Add(this.signUpButton);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.Shown += new System.EventHandler(this.SignUpForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox usernameSignUpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordSignUpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button maskButton;
        private System.Windows.Forms.Button backBtn;
    }
}