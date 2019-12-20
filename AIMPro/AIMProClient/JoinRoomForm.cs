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
    public partial class JoinRoomForm : Form
    {
        MenuController controller;
        public JoinRoomForm(MenuController controller)
        {
            InitializeComponent();
            this.controller = controller;
          
            RefreshTable(CommunicationLayer.Instance.GetRooms());
        }

        public void RefreshTable(List<RoomState> room)
        {
            foreach(RoomState r in room)
            {
                
                dataGridView1.Rows.Add(r.Name,r.gameModes.ToString(), r.currentNumberOfPlayers.ToString()+"/"+r.maxNumberOfPlayers.ToString());
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                MessageBox.Show("Oce da joinuje " + e.RowIndex + " sobu.");
            }
            
        }
    }
}
