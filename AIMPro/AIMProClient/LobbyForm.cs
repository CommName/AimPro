﻿using AIMProClient.Controllers;
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
        MenuController controller;
        public LobbyForm(MenuController menuController, AIMProService.RoomState roomState)
        {
            InitializeComponent();
            this.controller = menuController;
        }
    }
}