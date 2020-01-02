using AIMProClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMProClient
{
    public partial class LobbyForm : Form
    {
        MenuController menuController;
        LobbyController lobbyController;
        public LobbyForm(MenuController menuController, AIMProService.RoomState roomState)
        {
            InitializeComponent();
            this.menuController = menuController;
            LobbyController lobbyController = new LobbyController(this);
            this.lobbyController = lobbyController;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.menuController.leaveLobby();
            this.Close();
        }

        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void shieldChckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
