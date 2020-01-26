using AIMProClient.AIMProService;
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
        public LobbyController lobbyController;
        public LobbyForm(MenuController menuController, AIMProService.RoomState roomState)
        {
            InitializeComponent();
            this.menuController = menuController;
            LobbyController lobbyController = new LobbyController(this);
            this.lobbyController = lobbyController;
            this.readyBtn.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.menuController.leaveLobby();
            //this.Close();
        }

        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommunicationLayer.Instance.leaveLobby();
        }

        private void shieldChckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void osveziLobbyMetainfo(RoomState roomState) {
            this.playersNeededLbl.Text = roomState.maxNumberOfPlayers.ToString();
            this.nameOfLobbyLbl.Text = roomState.Name;
            this.naslovLbl.Text = "Welcome to " + roomState.Name + " Lobby.";
            this.typeOfGameLbl.Text = lobbyController.kastujEnum((int)roomState.gameModes);
            if (roomState.RoomSettings == 0)
                privateChckBox.Checked = false;
            else
                privateChckBox.Checked = true;
        }

        public void osveziPrikazUsera(List<string> listaUsera) {
                int brojac = 0;
                bool[] flags = { false, false, false, false };
                foreach (string user in listaUsera) {
                    flags[brojac++] = true;
                }
                groupBoxOnOff(flags);
                osveziUsers(listaUsera);
                playersInLobbyLbl.Text = listaUsera.Count.ToString();
                if (listaUsera.Count >= 4)
                    this.readyBtn.Enabled = true;
        }
        private void groupBoxOnOff(bool[] niz) {
                player1GroupBox.Visible = niz[0];
                player2GroupBox.Visible = niz[1];
                player3GroupBox.Visible = niz[2];
                player4GroupBox.Visible = niz[3];
        }
        private void osveziUsers(List<string> nizUsera) {
            if (nizUsera.Count == 1)
            {
                p1UsernameLbl.Text = nizUsera[0];
            }
            if (nizUsera.Count == 2)
            {
                p1UsernameLbl.Text = nizUsera[0];
                p2UsernameLbl.Text = nizUsera[1];
            }
            if (nizUsera.Count == 3)
            {
                p1UsernameLbl.Text = nizUsera[0];
                p2UsernameLbl.Text = nizUsera[1];
                p3UsernameLbl.Text = nizUsera[2];
            }
            else if (nizUsera.Count == 4)
            {
                p1UsernameLbl.Text = nizUsera[0];
                p2UsernameLbl.Text = nizUsera[1];
                p3UsernameLbl.Text = nizUsera[2];
                p4UsernameLbl.Text = nizUsera[3];
            }
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            // this.lobbyController.userReady();
            loadGameView();
        }

        private void loadGameView()
        {
            this.Controls.Clear();
            resizeForm();
        }

        private void resizeForm()
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }
    }
}
