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
using AIMProClient.AIMProService;

namespace AIMProClient
{
    public partial class JoinRoomForm : UserControl
    {
        MenuController controller;
        public bool ideUMenu = false;
        public JoinRoomForm(MenuController controller)
        {
            InitializeComponent();
            this.controller = controller;
            RefreshTable(controller.getRooms());
        }

        public void RefreshTable(List<RoomState> room)
        {
            this.dataGridView1.Rows.Clear();
            foreach (RoomState r in room)
            {
                bool pass = (r.RoomSettings & RoomSettings.PasswordProtected)!=0;
                dataGridView1.Rows.Add(r.Name,r.gameModes.ToString(), r.currentNumberOfPlayers.ToString()+"/"+r.maxNumberOfPlayers.ToString(), pass);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1 )
            {
                this.controller.pokreniLobby(e.RowIndex);
            }
        }

        public void RefreshList()
        {

            this.RefreshTable(controller.getRooms());
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.RefreshList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ideUMenu = true;
            FormLayer.Instance.clearView();
        }

        private void JoinRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
