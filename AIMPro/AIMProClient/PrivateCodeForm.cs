using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMProClient.Controllers;

namespace AIMProClient
{
    public partial class PrivateCodeForm : Form
    {
        MenuController controller;
        int index;

        public PrivateCodeForm(MenuController menuController, int i)
        {
            this.controller = menuController;
            index = i;
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 3)
            {
                MessageBox.Show("Treba da salje zahtev serveru za Auth room passworda.");
                //treba da otvori Lobby form;
                if (this.controller.authPassword(textBox1.Text, this.controller.ListaMogucihSoba[index]))
                    this.controller.udjiULobby(index);
            }
            else
            {
                MessageBox.Show("Invalid Input!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
