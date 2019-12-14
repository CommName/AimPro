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
            this.signUpButton = new System.Windows.Forms.Button();
            this.usernameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.maskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(251, 207);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // usernameSignUpTextBox
            // 
            this.usernameSignUpTextBox.Location = new System.Drawing.Point(226, 88);
            this.usernameSignUpTextBox.Name = "usernameSignUpTextBox";
            this.usernameSignUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameSignUpTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // passwordSignUpTextBox
            // 
            this.passwordSignUpTextBox.Location = new System.Drawing.Point(226, 138);
            this.passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            this.passwordSignUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordSignUpTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AIMPro Sign Up Form";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(217, 171);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(7, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "\r\n";
            // 
            // maskButton
            // 
            this.maskButton.Location = new System.Drawing.Point(357, 136);
            this.maskButton.Name = "maskButton";
            this.maskButton.Size = new System.Drawing.Size(75, 23);
            this.maskButton.TabIndex = 7;
            this.maskButton.Text = "Mask";
            this.maskButton.UseVisualStyleBackColor = true;
            this.maskButton.Click += new System.EventHandler(this.maskButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 283);
            this.Controls.Add(this.maskButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordSignUpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameSignUpTextBox);
            this.Controls.Add(this.signUpButton);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
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
    }
}