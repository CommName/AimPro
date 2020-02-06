using System;
using System.Collections.Generic;
using System.Drawing;
using AIMProClient.AIMProService;
using AIMProClient.Controllers;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AIMProClient.DrawingStrategy;
using BoostTarget = AIMProClient.DrawingStrategy.BoostTarget;
using AIMProClient.Crosshairs;

namespace AIMProClient.Controllers
{
    public class GameController
    {
        LobbyForm lobbyForm;
        public PictureBox canvas;
        Label scoreLabel;
        Label stoperica;
        Label ukupniPoeni;
        Label ammoLabel;
        Timer scoreTimer;
        Timer stopericaTimer;
        int cursorX = 0;
        int cursorY = 0;
        int vreme = 1;
        ICursorDrawing nisan = null;
        ITargetDrawing crtacMeta = null;
        Color bojaNisana;
        public List<Target> targets;
        Color[] nizBoja = { Color.FromArgb(255, 0, 0), Color.FromArgb(0, 128, 0), Color.FromArgb(0, 0, 255), Color.FromArgb(255, 20, 147), Color.FromArgb(128, 0, 128) };
        int indexBoja = 0;
        double bazookaKoef = 0;
        public List<Control> lobbyView = new List<Control>();
        Crosshair crosshair;
        int[] nizMunicije = {3,5,1000};
        AmmoController ammoController;

        public GameController()
        {
             crosshair= new Crosshair(this);
             ammoController = new AmmoController(nizMunicije);
        }

        public GameController(LobbyForm lf) :this() {
            this.lobbyForm = lf;
            generateCanvas();
            generisiScoreLabelu();
        }

        public void loadGameView() {
            nisan = new RegularNisan();
            bojaNisana = Color.FromArgb(0,255,0);
            generisiPoeneLabelu();
            generisiAmmoLabelu();
            generateStopericu();
            resizeForm();
            loadGameControlls();

        }

        public void resizeForm() {
            this.lobbyForm.MinimizeBox = true;
            this.lobbyForm.MaximizeBox = true;
            this.lobbyForm.FormBorderStyle = FormBorderStyle.Sizable;
            lobbyForm.WindowState = FormWindowState.Maximized;
            lobbyForm.Location = new Point(0, 0);
            lobbyForm.Text = "AimPRO Game";
            lobbyForm.BackgroundImage = null;
            this.lobbyForm.Invalidate();
        }

        public void loadGameControlls() {
            this.lobbyForm.Controls.Add(canvas);
            this.lobbyForm.Controls.Add(stoperica);
            this.lobbyForm.Controls.Add(scoreLabel);
            this.lobbyForm.Controls.Add(ukupniPoeni);
            this.lobbyForm.Controls.Add(ammoLabel);
            stoperica.BringToFront();
            scoreLabel.BringToFront();
            ukupniPoeni.BringToFront();
            ammoLabel.BringToFront();
            canvas.BringToFront();
            canvas.Focus();
        }

        private void gameCanvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            double unitx = canvas.Width/1000.0;
            double unity = canvas.Height/1000.0;

            if (targets != null)
            {
                foreach (Target t in targets)
                {
                    switch (t.type)
                    {
                        case TargetTypes.Shielded: { crtacMeta = new ShieldTarget(); break; };
                        case TargetTypes.Boost: { crtacMeta = new BoostTarget(); break; };
                        case TargetTypes.Negative: { crtacMeta = new NegativeTarget(); break; };
                        case TargetTypes.Child: { crtacMeta = new SplitTarget(); break; };

                        default:
                        case TargetTypes.None: { crtacMeta = new RegularTarget(); break; };
                    }
                    crtacMeta.x =(int) (t.x *unitx) ;
                    crtacMeta.y = (int)(t.y *unity);
                    crtacMeta.r = (unitx <= unity) ?  (int) (t.radius *unitx) : (int) (t.radius * unity);
                    crtacMeta.CrtajMetu(g);
                }
            }
            double percentToScale = (unitx <= unity) ? (double)( unitx) : (double)( unity);
         
            nisan.CrtajNisan(g,cursorX,cursorY,percentToScale, bojaNisana);
            ControlPaint.DrawBorder(g, canvas.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void gameCanvas_Click(object sender, EventArgs e) {
            double pomx= 1000.0 / canvas.Width;
            double pomy = 1000.0 / canvas.Height;
            int toSendX =(int) (cursorX * pomx);
            int toSendY = (int)(cursorY * pomy);
            crosshair.submitHit(toSendX, toSendY);
            if (!ammoController.shoot()) {
                bojaNisana = Color.FromArgb(0, 255, 0);
                nisan = new RegularNisan();
                crosshair = new Crosshair(this);
            }
            ammoLabel.Text = "B=>" + ammoController.getBazooka().ToString() + " P=>" + ammoController.getPiercing();
        }

        private void gameCanvas_MouseEnter(object sender, System.EventArgs e){
            Cursor.Hide();
        }

        private void gameCanvas_MouseLeave(object sender, System.EventArgs e){
            Cursor.Show();
        }

        private void gameCanvas_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e){
            cursorX = e.X;
            cursorY = e.Y;
            canvas.Invalidate();
        }

        public void lobbyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && ammoController.setBazooka()) {
                nisan = new BazookaNisan();
                crosshair = new Bazooka(105 , this);
            }
            else if (e.KeyCode == Keys.W && ammoController.setPiercing()) {
                bojaNisana = Color.FromArgb(255, 255, 127, 80);
                nisan = new PiercingNisan();
                crosshair = new Piercing(this);
            }
            else if (e.KeyCode == Keys.E && ammoController.setRegular()) {
                bojaNisana = Color.FromArgb(0, 255, 0);
                nisan = new RegularNisan();
                crosshair = new Crosshair(this);
            }
            canvas.Invalidate();
        }

        private void generateCanvas() {
            PictureBox gameCanvas = new PictureBox();
            gameCanvas.Location = new Point(10, 10);
            gameCanvas.Size = new Size(lobbyForm.Width-35 , lobbyForm.Height - 90);
            gameCanvas.BackColor = Color.White;
            gameCanvas.Paint += new PaintEventHandler(this.gameCanvas_Paint);
            gameCanvas.Click += new EventHandler(gameCanvas_Click);
            gameCanvas.MouseEnter += new EventHandler(gameCanvas_MouseEnter);
            gameCanvas.MouseLeave += new EventHandler(gameCanvas_MouseLeave);
            gameCanvas.MouseMove += new MouseEventHandler(gameCanvas_MouseMove);
            gameCanvas.KeyDown += new KeyEventHandler(lobbyForm_KeyDown);
            this.canvas= gameCanvas;
        }

        private void generateStopericu() {
            Label stopwatch = new Label();
            stopwatch.Text = "Time  : " + this.vreme.ToString();
            stopwatch.Font = new Font("Modern No. 20", 18, FontStyle.Underline);
            stopwatch.Location = new Point(lobbyForm.Width / 6, lobbyForm.Height - 80);
            stopwatch.Size = new Size(120, 50);
            this.stoperica = stopwatch;
            this.stopericaTimer = new Timer();
            stopericaTimer.Interval = 1000;
            stopericaTimer.Tick += TickHandlerStoperica;
            stopericaTimer.Start();
        }

        private void generisiScoreLabelu() {
            Label score = new Label();
            score.Text = "Shot : 0";
            score.Font = new Font("Modern No. 20", 20, FontStyle.Underline);
            score.Location = new Point(lobbyForm.Width - lobbyForm.Width / 5, lobbyForm.Height - 80);
            score.Size = new Size(180,60);
            scoreLabel = score;
        }

        private void generisiTimer() {
            if (this.scoreTimer != null){
                this.scoreTimer.Stop();
            }
            Timer scoreTimer = new Timer();
            scoreTimer.Interval = 2000;
            scoreTimer.Tick += TickHandlerScore;
            scoreTimer.Start();
            this.scoreTimer = scoreTimer;
        }

        private void generisiPoeneLabelu() {
            Label labPoeni = new Label();
            labPoeni.Text = "Points : 0";
            labPoeni.Font = new Font("Modern No. 20", 18, FontStyle.Underline);
            labPoeni.Location = new Point((2 * lobbyForm.Width) / 5, lobbyForm.Height - 80);
            labPoeni.Size = new Size(180, 50);
            this.ukupniPoeni = labPoeni;
        }

        private void generisiAmmoLabelu()
        {
            Label labAmmo = new Label();
            labAmmo.Text = "B=>" + ammoController.getBazooka().ToString() + " P=>" + ammoController.getPiercing();
            labAmmo.Font = new Font("Modern No. 20", 18, FontStyle.Underline);
            labAmmo.Location = new Point(lobbyForm.Width / 10, lobbyForm.Height - 80);
            labAmmo.Size = new Size(180, 50);
            this.ammoLabel = labAmmo;
        }

        private void TickHandlerScore(object sender, EventArgs e)
        {
            if(scoreLabel!=null)
            scoreLabel.Hide();
            this.scoreTimer.Stop();
            this.scoreTimer = null;
        }

        private void TickHandlerStoperica(object sender, EventArgs e)
        {
            this.vreme++;
            String labela = "Time : ";
            this.stoperica.Text = string.Concat(labela, Convert.ToString(this.vreme));
        }

        public void updateScore(int totalPoints, int newPoints)
        {
            this.ukupniPoeni.Text = "Points  : " + Convert.ToString(totalPoints);
            String labela = "Shot : ";
            scoreLabel.Text = string.Concat(labela, Convert.ToString(newPoints));
            scoreLabel.ForeColor = nizBoja[indexBoja];
            scoreLabel.Show();
            indexBoja = (indexBoja + 1) % 5;
            generisiTimer();
        }

        internal void resizeEvent(object sender, EventArgs e)
        {
            if (this.canvas != null)
            {
                int pomeraj = lobbyForm.Width / 20;
                canvas.Size = new Size(lobbyForm.Width - 35, lobbyForm.Height - 80);
                scoreLabel.Location = new Point(lobbyForm.Width - lobbyForm.Width / 5 - pomeraj, lobbyForm.Height - 72);
                stoperica.Location = new Point(lobbyForm.Width / 5 - pomeraj, lobbyForm.Height - 72);
                ukupniPoeni.Location = new Point((3 * lobbyForm.Width) / 5 - pomeraj, lobbyForm.Height - 72);
                ammoLabel.Location = new Point((2 * lobbyForm.Width) / 5 - pomeraj, lobbyForm.Height - 72);
                canvas.Invalidate();
            }
        }

        public void krajIgre() {
            this.vreme = 0;
            ammoController = new AmmoController(nizMunicije);
            lobbyForm.readyClick = false;
            this.lobbyForm.gameNotEnd = false;
            lobbyForm.WindowState = FormWindowState.Normal;
            this.lobbyForm.Size = new Size(950, 500);
            deleteGameView();
            this.lobbyForm.setWallPaper();
            this.lobbyForm.scoreView();
            this.lobbyForm.Invalidate();
        }

        private void deleteGameView() {
            this.lobbyForm.Controls.Remove(canvas);
            this.lobbyForm.Controls.Remove(stoperica);
            this.lobbyForm.Controls.Remove(scoreLabel);
            this.lobbyForm.Controls.Remove(ukupniPoeni);
            this.lobbyForm.Controls.Remove(ammoLabel);
        }
    }
}
