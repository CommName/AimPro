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
    public partial class LoginForm : Form
    {
        bool flag = false;
        LoginController controller;
        public LoginForm()
        {
            InitializeComponent();
            controller = new LoginController();
            passwordTextBox.PasswordChar = passwordTextBox.PasswordChar = controller.setMask();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm(this,this.controller);
            sf.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (controller.login(this.usernameTextBox.Text, this.passwordTextBox.Text))
            {
                flag = true;
                this.Close();
            }
            else
                errorLabel.Text = controller.errorMessage; 
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
                CommunicationLayer.Instance.mainForm.Close();
        }

        private void maskButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = controller.setMask();
        }
    }
}
