using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMProClient.AIMProService;

namespace AIMProClient
{
    public partial class SignUpForm : Form
    {
        LoginController controller;
        public SignUpForm(LoginController controller)
        {
            this.controller = controller;
            this.controller.mask = false;
            InitializeComponent();
            this.passwordSignUpTextBox.PasswordChar = this.controller.setMask();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ActiveControl = usernameSignUpTextBox;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (controller.signUp(this.usernameSignUpTextBox.Text, this.passwordSignUpTextBox.Text))
            {
                MessageBox.Show("Your Account was created successfully.", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                controller.openMenuForm(this.usernameSignUpTextBox.Text);
                this.Close();
            }
            else 
                errorLabel.Text = controller.errorMessage;
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FormLayer.Instance.loginForm != null)
            FormLayer.Instance.loginForm.Show();
        }

        private void SignUpForm_Shown(object sender, EventArgs e)
        {
            FormLayer.Instance.loginForm.Hide();
        }
        private void maskButton_Click(object sender, EventArgs e)
        {
            this.passwordSignUpTextBox.PasswordChar=this.controller.setMask();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameSignUpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordSignUpTextBox.Focus();
            }
        }

        private void passwordSignUpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signUpButton_Click(sender,e);
            }
        }
    }
}
