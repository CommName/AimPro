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
        AIMProServerServiceClient proxy;
        Form1 f;
        bool flag = false;
        LoginController controller;
        public LoginForm(AIMProServerServiceClient proxy, Form1 form1)
        {
            this.f = form1;
            InitializeComponent();
            controller = new LoginController(proxy,f);
            passwordTextBox.PasswordChar = passwordTextBox.PasswordChar = controller.setMask();
            this.proxy = proxy;
            errorLabel.Visible = false;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm(this.proxy,this);
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
            {
                errorLabel.Visible = true;
                errorLabel.Text = controller.errorMessage;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
                f.Close();
        }

        private void maskButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = controller.setMask();
        }
    }
}
