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
using AIMProClient.Controllers;

namespace AIMProClient
{
    public partial class MenuForm : Form
    {
        MenuController controller;
        public MenuForm()
        {
            InitializeComponent();
            controller = new MenuController(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommunicationLayer.Instance.mainForm.Close();
        }
    }
}
