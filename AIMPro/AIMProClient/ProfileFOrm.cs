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
        Profile korisnik;
        List<MatchStatistics> matchHistory;
        public ProfileForm(Profile korisnik ,List<MatchStatistics> matchHistory)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            this.matchHistory = matchHistory;
            korisnikLabel.Text = this.korisnik.Username;
            lblElo.Text = this.korisnik.Elo.ToString();
            lblHitRatio.Text = this.korisnik.HitRatio.ToString();
            lblTotalTargerHits.Text = this.korisnik.TotalHits.ToString();
            lblTotalTargetMiss.Text = this.korisnik.TotalMiss.ToString();
            lblDuel.Text = this.korisnik.NumberDuel.ToString();
            lblMulti.Text = this.korisnik.NumberFFA.ToString();
            lblEndLess.Text= this.korisnik.NumberEndless.ToString();
            lblFastShooting.Text= this.korisnik.NumberFast.ToString();
            lblPreciseShooting.Text = this.korisnik.NumberPrecise.ToString();
            this.FillTable();

        }
        private void FillTable()
        {
            foreach (MatchStatistics mS in this.matchHistory)
            {
                dataGridProfileStatistics.Rows.Add(mS.TypeOfGame.ToString(), mS.MatchRank.ToString(), mS.NumberOfPoints.ToString(), mS.NumberOfHits.ToString(), mS.NumberOfMiss.ToString());
            }
        }
    }


}
