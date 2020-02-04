﻿using AIMProClient.AIMProService;
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
        public bool borderFlag = false;

        protected Label[] usernames;
        protected Label[] eloLabel;
        protected Label[] points;
        protected Label[] numOfHits;
        protected Label[] numOfMisses;
        protected Label[] ready;

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

            usernames = new Label[4];
            eloLabel = new Label[4];
            points = new Label[4];
            numOfHits = new Label[4];
            numOfMisses = new Label[4];
            ready = new Label[4];

            usernames[0] = p1UsernameLbl;
            usernames[1] = p2UsernameLbl;
            usernames[2] = p3UsernameLbl;
            usernames[3] = p4UsernameLbl;

            eloLabel[0] = p1EloLbl;
            eloLabel[1] = p2EloLbl;
            eloLabel[2] = p3EloLbl;
            eloLabel[3] = p4EloLbl;

            points[0] = p1PointsLbl;
            points[1] = p2PointsLbl;
            points[2] = p3PointsLbl;
            points[3] = p4PointsLbl;

            numOfHits[0] = p1NumHitsLbl;
            numOfHits[1] = p2NumHitsLbl;
            numOfHits[2] = p3NumHitsLbl;
            numOfHits[3] = p4NumHitsLbl;

            numOfMisses[0] = p1NumMissesLbl;
            numOfMisses[1] = p2NumMissesLbl;
            numOfMisses[2] = p3NumMissesLbl;
            numOfMisses[3] = p4NumMissesLbl;

            ready[0] = p1readylabel;
            ready[1] = p2readylabel;
            ready[2] = p3readylabel;
            ready[3] = p4readylabel;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.menuController.leaveLobby();
            this.appClose = false;
            this.Hide();
        }

        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.menuController.leaveLobbyAndGame();
            if (this.appClose == true)
                FormLayer.Instance.mainForm.Close();
        }

        private void shieldChckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        delegate void osveziPrikazUseraDgt(List<Shooter> listaUsera);

        public void refreshUsers(List<Shooter> listaUsera) {
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

            nizUsera.Sort((a, b) => (a.points.CompareTo(b.points)));
            for (int i =0; i < nizUsera.Count; i++)
            {
                usernames[i].Text = nizUsera[i].username;
                eloLabel[i].Text = nizUsera[i].elo.ToString();
                points[i].Text = nizUsera[i].points.ToString();
                numOfHits[i].Text = nizUsera[i].numberOfHits.ToString();
                numOfMisses[i].Text = nizUsera[i].numbeerOfMisses.ToString();
                ready[i].Text = nizUsera[i].ready ? "User is ready" : "Waiting for user";
            }

        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            // this.lobbyController.userReady();
            gameController = new GameController(this);
            CommunicationLayer.Instance.userReady();
            gameController.loadGameView();
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
            if(borderFlag == true)
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(0,0,0), ButtonBorderStyle.Solid);
        }
    }
}
