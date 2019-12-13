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
        public LoginForm(AIMProServerServiceClient proxy)
        {
            InitializeComponent();
            this.proxy = proxy;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm(this.proxy);
            sf.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (proxy.login(this.usernameTextBox.Text, Encoding.ASCII.GetBytes(this.passwordTextBox.Text)))
            {
                MessageBox.Show("Ulazi");
                MenuForm mf = new MenuForm(proxy);
                mf.Show();
                this.Close();
            }
        }
    }
}
