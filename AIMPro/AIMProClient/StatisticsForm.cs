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
        BindingSource binding;


        List<User> users;


        public StatisticsForm( MenuController controller, List<User> users )
        {
            InitializeComponent();
            this.controller = controller;

            binding = new BindingSource();
            users = users;


            binding.DataSource = users;
          //  dataGridStatistics.AutoGenerateColumns = false;
            dataGridStatistics.DataSource = binding;

        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
