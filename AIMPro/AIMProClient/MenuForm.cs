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
        public bool exitApp = true;
        MenuController controller;
        public MenuForm(User logovaniKorisnik)
        {
            InitializeComponent();
            controller = new MenuController(this,logovaniKorisnik);
            welcomeLabel.Text += logovaniKorisnik.Username+", time for shooting!";
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exitApp)
            FormLayer.Instance.mainForm.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.controller.otvoriProfil();
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            this.controller.napraviSobu();
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            this.controller.udjiUSobu();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            this.controller.generisiStatistiku();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.controller.logout();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
