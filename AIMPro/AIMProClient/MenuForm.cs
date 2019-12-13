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
    public partial class MenuForm : Form
    {
        AIMProServerServiceClient proxy;
        Form1 f;
        public MenuForm(AIMProServerServiceClient proxy,Form1 f)
        {
            this.proxy = proxy;
            this.f = f;
            InitializeComponent();
            this.f.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.f.Hide();
        }
    }
}
