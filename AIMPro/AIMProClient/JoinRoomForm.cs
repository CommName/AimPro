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
    public partial class JoinRoomForm : Form
    {
        MenuController controller;
        public JoinRoomForm(MenuController controller)
        {
            InitializeComponent();
            this.controller = controller;
            dataGridView1.Rows.Add("Ovo");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                MessageBox.Show("Oce da joinuje " + e.RowIndex + " sobu.");
            }
            
        }
    }
}
