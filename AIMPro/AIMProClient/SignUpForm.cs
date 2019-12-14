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
        LoginForm lf;
        LoginController controller;
        public SignUpForm(LoginForm lf,LoginController controller)
        {
            this.lf = lf;
            this.controller = controller;
            this.controller.mask = false;
            InitializeComponent();
            this.passwordSignUpTextBox.PasswordChar = this.controller.setMask();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (controller.signUp(this.usernameSignUpTextBox.Text, this.passwordSignUpTextBox.Text))
            {
                MessageBox.Show("Kreira Account");
                this.Close();
            }
            else 
                errorLabel.Text = controller.errorMessage;
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Show();
        }

        private void SignUpForm_Shown(object sender, EventArgs e)
        {
            lf.Hide();
        }
        private void maskButton_Click(object sender, EventArgs e)
        {
            this.passwordSignUpTextBox.PasswordChar=this.controller.setMask();
        }
    }
}
