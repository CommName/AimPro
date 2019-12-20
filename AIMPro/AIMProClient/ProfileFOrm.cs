using AIMProClient.AIMProService;
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
    public partial class ProfileForm : Form
    {
        User korisnik;
        public ProfileForm(User korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            korisnikLabel.Text = this.korisnik.Username;
            lblElo.Text = this.korisnik.Elo.ToString();


        }
    }
}
