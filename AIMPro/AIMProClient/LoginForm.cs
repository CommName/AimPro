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
        public bool flag = false;
        LoginController controller;
        public LoginForm()
        {
            InitializeComponent();
            this.Icon = new Icon("icon.ico");
            controller = new LoginController();
            passwordTextBox.PasswordChar = passwordTextBox.PasswordChar = controller.setMask();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ActiveControl = usernameTextBox;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm(this.controller);
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
                FormLayer.Instance.mainForm.Close();
        }

        private void maskButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = controller.setMask();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}
