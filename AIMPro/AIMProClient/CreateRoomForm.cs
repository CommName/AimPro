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
    public partial class CreateRoomForm : UserControl
    {
        MenuController controller;
        
        public CreateRoomForm(Controllers.MenuController menuController)
        {
            this.controller=menuController;
            InitializeComponent();
            this.ActiveControl = nameTxtBox;
            this.multyPlayerRb.Checked = true;
            this.nameTxtBox.Text = this.controller.getUser.Username+" 's room";
            this.controller.PublicSoba = true;
            this.controller.TipIgre = 2;
            this.controller.TipMete = 0;
        }

        private void multyPlayerRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.multyPlayerRb.Checked == true)
                this.controller.TipIgre = 2;
        }

        private void fastRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.fastRb.Checked == true)
                this.controller.TipIgre = 4;
        }

        private void endlessRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.endlessRb.Checked == true)
                this.controller.TipIgre = 16;
        }

        private void shieldChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.shieldChb.Checked == true)
                this.controller.TipMete += 2;
            else
                this.controller.TipMete -= 2;
        }

        private void boostChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boostChb.Checked == true)
                this.controller.TipMete += 4;
            else
                this.controller.TipMete -= 4;
        }

        private void navigateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.navigateCb.Checked == true)
                this.controller.TipMete += 8;
            else
                this.controller.TipMete -= 8;
        }

        private void childChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.childChb.Checked == true)
                this.controller.TipMete += 16;
            else
                this.controller.TipMete -= 16;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (this.controller.validirajKreiranjeSobe(this.nameTxtBox.Text, ""))
            {
                //this.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormLayer.Instance.clearView();
        }

        public void deSelectAll() {
            this.childChb.Checked = false;
            this.navigateCb.Checked = false;
            this.boostChb.Checked = false;
            this.shieldChb.Checked = false;
            this.multyPlayerRb.Checked = true;
        }
    }
}
