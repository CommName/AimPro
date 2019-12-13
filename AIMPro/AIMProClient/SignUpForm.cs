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
        AIMProServerServiceClient proxy;
        Form1 f;
        public SignUpForm(AIMProServerServiceClient proxy,Form1 f)
        {
            this.f = f;
            this.proxy = proxy;
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            if (proxy.signUp(this.usernameSignUpTextBox.Text, Encoding.ASCII.GetBytes(this.passwordSignUpTextBox.Text)))
            {
                MessageBox.Show("Kreira Account");
                MenuForm mf = new MenuForm(proxy,f);
                mf.Show();
                this.Close();
            }
        }
    }
}
