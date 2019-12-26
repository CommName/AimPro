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
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ActiveControl = textBox1;
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterBtn_Click(sender, e);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
