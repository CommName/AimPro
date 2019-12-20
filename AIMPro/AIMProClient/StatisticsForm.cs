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
    public partial class StatisticsForm : Form
    {
        MenuController controller;
        List<User> users;


        public StatisticsForm( MenuController controller, List<User> users )
        {
            InitializeComponent();
            this.controller = controller;
            this.users = users;
            ShowTable(users);
        }

        public void ShowTable(List<User> users)
        {
            int rank = 0;
            foreach (User user in users)
            {
               dataGridStatistics.Rows.Add(++rank, user.Username,user.Elo, null,null);
            }
        }


        private void dataGridStatistics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex==5)
            {
                ProfileForm pf = new ProfileForm(users[e.RowIndex]);
                pf.ShowDialog();
            }

        }
    }
}
