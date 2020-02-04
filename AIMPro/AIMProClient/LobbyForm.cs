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
        public bool appClose = true;
        MenuController menuController;
        public LobbyController lobbyController;
        public GameController gameController;
        public bool gameNotEnd = true;
        public bool readyClick = false;
        public LobbyForm(MenuController menuController, AIMProService.RoomState roomState)
        {
            InitializeComponent();
            this.menuController = menuController;
            LobbyController lobbyController = new LobbyController(this);
            gameController = new GameController(this);
            this.lobbyController = lobbyController;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.readyBtn.Enabled = false;
        }

        public void f() {
            this.menuController.leaveLobby(gameNotEnd);
            this.appClose = false;
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            this.menuController.leaveLobby(gameNotEnd);
            this.appClose = false;
            this.Hide();
        }

        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.menuController.leaveLobbyAndGame();
            if (this.appClose == true)
                FormLayer.Instance.mainForm.Close();
        }

        private void shieldChckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        delegate void osveziPrikazUseraDgt(List<Shooter> listaUsera);

        public void refreshUsers(List<Shooter> listaUsera) {
            if (readyClick == false)
            {
                if (this.InvokeRequired)
                {
                    osveziPrikazUseraDgt d = new osveziPrikazUseraDgt(osveziPrikazUsera);
                    this.Invoke(d, new object[] { listaUsera });
                }
                else
                {
                    osveziPrikazUsera(listaUsera);
                }
            }
        }

        public void osveziPrikazUsera(List<Shooter> listaUsera) {
                int brojac = 0;
                bool[] flags = { false, false, false, false };
                foreach (Shooter user in listaUsera) {
                    flags[brojac++] = true;
                }
                groupBoxOnOff(flags);
                osveziUsers(listaUsera);
                if (listaUsera.Count >= 2)
                    this.readyBtn.Enabled = true;
        }
        private void groupBoxOnOff(bool[] niz) {
                player1GroupBox.Visible = niz[0];
                player2GroupBox.Visible = niz[1];
                player3GroupBox.Visible = niz[2];
                player4GroupBox.Visible = niz[3];
        }
        private void osveziUsers(List<Shooter> nizUsera) {
            if (nizUsera.Count == 1)
            {
                p1UsernameLbl.Text = nizUsera[0].username;
                p1EloLbl.Text = nizUsera[0].elo.ToString();
                p1PointsLbl.Text= nizUsera[0].points.ToString();
                p1NumHitsLbl.Text= nizUsera[0].numberOfHits.ToString();
                p1NumMissesLbl.Text= nizUsera[0].numbeerOfMisses.ToString();

            }
            if (nizUsera.Count == 2)
            {
                p1UsernameLbl.Text = nizUsera[0].username;
                p1EloLbl.Text = nizUsera[0].elo.ToString();
                p1PointsLbl.Text = nizUsera[0].points.ToString();
                p1NumHitsLbl.Text = nizUsera[0].numberOfHits.ToString();
                p1NumMissesLbl.Text = nizUsera[0].numbeerOfMisses.ToString();

                p2UsernameLbl.Text = nizUsera[1].username;
                p2EloLbl.Text = nizUsera[1].elo.ToString();
                p2PointsLbl.Text = nizUsera[1].points.ToString();
                p2NumHitsLbl.Text = nizUsera[1].numberOfHits.ToString();
                p2NumMissesLbl.Text = nizUsera[1].numbeerOfMisses.ToString();
            }
            if (nizUsera.Count == 3)
            {
                p1UsernameLbl.Text = nizUsera[0].username;
                p1EloLbl.Text = nizUsera[0].elo.ToString();
                p1PointsLbl.Text = nizUsera[0].points.ToString();
                p1NumHitsLbl.Text = nizUsera[0].numberOfHits.ToString();
                p1NumMissesLbl.Text = nizUsera[0].numbeerOfMisses.ToString();

                p2UsernameLbl.Text = nizUsera[1].username;
                p2EloLbl.Text = nizUsera[1].elo.ToString();
                p2PointsLbl.Text = nizUsera[1].points.ToString();
                p2NumHitsLbl.Text = nizUsera[1].numberOfHits.ToString();
                p2NumMissesLbl.Text = nizUsera[1].numbeerOfMisses.ToString();

                p3UsernameLbl.Text = nizUsera[2].username;
                p3EloLbl.Text = nizUsera[2].elo.ToString();
                p3PointsLbl.Text = nizUsera[2].points.ToString();
                p3NumHitsLbl.Text = nizUsera[2].numberOfHits.ToString();
                p3NumMissesLbl.Text = nizUsera[2].numbeerOfMisses.ToString();
            }
            else if (nizUsera.Count == 4)
            {
                p1UsernameLbl.Text = nizUsera[0].username;
                p1EloLbl.Text = nizUsera[0].elo.ToString();
                p1PointsLbl.Text = nizUsera[0].points.ToString();
                p1NumHitsLbl.Text = nizUsera[0].numberOfHits.ToString();
                p1NumMissesLbl.Text = nizUsera[0].numbeerOfMisses.ToString();


                p2UsernameLbl.Text = nizUsera[1].username;
                p2EloLbl.Text = nizUsera[1].elo.ToString();
                p2PointsLbl.Text = nizUsera[1].points.ToString();
                p2NumHitsLbl.Text = nizUsera[1].numberOfHits.ToString();
                p2NumMissesLbl.Text = nizUsera[1].numbeerOfMisses.ToString();


                p3UsernameLbl.Text = nizUsera[2].username;
                p3EloLbl.Text = nizUsera[2].elo.ToString();
                p3PointsLbl.Text = nizUsera[2].points.ToString();
                p3NumHitsLbl.Text = nizUsera[2].numberOfHits.ToString();
                p3NumMissesLbl.Text = nizUsera[2].numbeerOfMisses.ToString();


                p4UsernameLbl.Text = nizUsera[3].username;
                p4EloLbl.Text = nizUsera[3].elo.ToString();
                p4PointsLbl.Text = nizUsera[3].points.ToString();
                p4NumHitsLbl.Text = nizUsera[3].numberOfHits.ToString();
                p4NumMissesLbl.Text = nizUsera[3].numbeerOfMisses.ToString();
            }
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            this.readyClick = true;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.gameController.lobbyView.Add(this.Controls[i]);
            }
            this.lobbyController.userReady();
        }

        private void LobbyForm_Shown(object sender, EventArgs e)
        {
            this.osveziPrikazUsera(this.lobbyController.trenutniUseri);
        }

        private void LobbyForm_Resize(object sender, EventArgs e)
        {
            this.gameController.resizeEvent(sender,e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
          
        }
    }
}
