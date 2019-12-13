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
    public partial class Form1 : Form
    {
        AIMProServerServiceClient proxy = new AIMProServerServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm lf = new LoginForm(proxy, this);
            lf.ShowDialog();
        }
    }
}
