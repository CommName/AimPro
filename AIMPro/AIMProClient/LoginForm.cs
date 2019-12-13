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
        public LoginForm(AIMProServerServiceClient proxy, Form1 form1)
        {
            this.f = form1;
            InitializeComponent();
            this.proxy = proxy;
        }

       

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm(this.proxy,this);
            sf.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (proxy.login(this.usernameTextBox.Text, Encoding.ASCII.GetBytes(this.passwordTextBox.Text)))
            {
                MessageBox.Show("Ulazi");
                MenuForm mf = new MenuForm(proxy,f);
                mf.Show();
                flag = true;
                this.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
                f.Close();
        }
    }
}
