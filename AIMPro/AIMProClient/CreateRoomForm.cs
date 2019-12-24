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
    public partial class CreateRoomForm : Form
    {
        MenuController controller;
        
        public CreateRoomForm(Controllers.MenuController menuController)
        {
            this.controller=menuController;
            InitializeComponent();
            this.codePanel.Visible = false;
            this.controller.setCreateRoom(this);
        }

        private void privateRb_CheckedChanged(object sender, EventArgs e)
        {
            this.codePanel.Visible = privateRb.Checked;
            if (this.privateRb.Checked == true)
                this.controller.PublicSoba = false;
        }

        private void publicRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.publicRb.Checked == true)
                this.controller.PublicSoba = true;
        }

        private void duelRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.duelRb.Checked == true)
                this.controller.TipIgre = 1;
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

        private void preciseRb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.preciseRb.Checked == true)
                this.controller.TipIgre = 8;
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

        private void piercingChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.piercingChb.Checked == true)
                this.controller.TipMunicije += 1;
            else
                this.controller.TipMunicije -= 1;
        }


        private void limitedChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.limitedChb.Checked == true)
                this.controller.TipMunicije += 4;
            else
                this.controller.TipMunicije -= 4;
        }

        private void drunkChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.drunkChb.Checked == true)
                this.controller.TipMunicije += 8;
            else
                this.controller.TipMunicije -= 8;
        }

        private void bazookaChb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.bazookaChb.Checked == true)
                this.controller.TipMunicije += 16;
            else
                this.controller.TipMunicije -= 16;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (this.controller.validirajKreiranjeSobe(this.nameTxtBox.Text, this.codeTxtBox.Text))
            {
                this.Close();
            }
        }
    }
}
