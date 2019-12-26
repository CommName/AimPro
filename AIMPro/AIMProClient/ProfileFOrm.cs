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
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            lblTotalMatch.Text = this.korisnik.MatchCount.ToString();
            this.FillTable();

        }
        private void FillTable()
        {
            foreach (MatchStatistics mS in this.matchHistory)
            {
                dataGridProfileStatistics.Rows.Add(kastujEnum(mS.TypeOfGame), mS.MatchRank.ToString(), mS.NumberOfPoints.ToString(), mS.NumberOfHits.ToString(), mS.NumberOfMiss.ToString());
            }
        }

        private string kastujEnum(string tipIgre) {
            if (tipIgre == "1")
                return "Duel";
            else if (tipIgre == "2")
                return "MultiPlayer FFA";
            else if (tipIgre == "4")
                return "Fast Shooting";
            else if (tipIgre == "8")
                return "Precise Shooting";
            else
                return "Endless Campaign";
        }

        private void backBtn_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }


}
