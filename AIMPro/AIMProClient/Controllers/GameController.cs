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

namespace AIMProClient.Controllers
{
    public class GameController
    {
        LobbyForm lobbyForm;
        public PictureBox canvas;
        Label scoreLabel;
        Label naslov;
        Timer timer;
        int cursorX = 0;
        int cursorY = 0;
        int Score = 0;
        ICursorDrawing nisan = null;
        ITargetDrawing crtacMeta = null;
        Color bojaNisana;
        public List<Target> targets;
        Color[] nizBoja = { Color.FromArgb(255, 0, 0), Color.FromArgb(155, 255, 80), Color.FromArgb(0, 0, 205), Color.FromArgb(255, 150, 170), Color.FromArgb(15, 70, 240) };
        int indexBoja = 0;


        public GameController(LobbyForm lf) {
            this.lobbyForm = lf;
        }

        public void loadGameView() {
            nisan = new RegularNisan();
            bojaNisana = Color.FromArgb(0,255,0);
            lobbyForm.Controls.Clear();
            lobbyForm.BackColor = Color.SandyBrown;
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
        }

        public void loadGameControlls() {
            generateCanvas();
            generateNaslov();
            generisiScoreLabelu();
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
                     crtacMeta.r = t.radius;
                    crtacMeta.CrtajMetu(g);
                }
            }
            
            nisan.CrtajNisan(g,cursorX,cursorY,bojaNisana);
        }

        private void gameCanvas_Click(object sender, EventArgs e) {
            double pomx= 1000.0 / canvas.Width;
            double pomy = 1000.0 / canvas.Height;
            int toSendX =(int) (cursorX * pomx);
            int toSendY = (int)(cursorY * pomy);
            updateScore(100, nizBoja[indexBoja]);
            indexBoja = (indexBoja + 1) % 5;
            CommunicationLayer.Instance.submitHit(toSendX, toSendY);
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

        private void lobbyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
                nisan = new BazookaNisan();
            else if (e.KeyCode == Keys.P) {
                bojaNisana = Color.FromArgb(255, 255, 127, 80);
                nisan = new PiercingNisan();
            }
            else if (e.KeyCode == Keys.R) {
                bojaNisana = Color.FromArgb(0,255,0);
                nisan = new RegularNisan();
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
            lobbyForm.KeyDown += new KeyEventHandler(lobbyForm_KeyDown);
            this.canvas= gameCanvas;
            lobbyForm.Controls.Add(gameCanvas);
        }

        private void generateNaslov() {
            Label naslov = new Label();
            naslov.Text = "Tip Igre";
            naslov.Font = new Font("Modern No. 20", 18, FontStyle.Underline);
            naslov.Location = new Point(lobbyForm.Width / 6, lobbyForm.Height - 80);
            this.naslov = naslov;
            lobbyForm.Controls.Add(naslov);
        }

        private void generisiScoreLabelu() {
            Label score = new Label();
            score.Text = "Score : " + Score.ToString() + " ";
            score.Font = new Font("Modern No. 20", 20, FontStyle.Underline);
            score.Location = new Point(lobbyForm.Width - lobbyForm.Width / 5, lobbyForm.Height - 80);
            scoreLabel = score;
            lobbyForm.Controls.Add(score);
        }

        private void generisiTimer() {
            if (timer != null){
                timer.Stop();
            }
            Timer scoreTimer = new Timer();
            scoreTimer.Interval = 2000;
            scoreTimer.Tick += TickHandler;
            scoreTimer.Start();
            timer = scoreTimer;
        }

        private void TickHandler(object sender, EventArgs e)
        {
            scoreLabel.Hide();
            this.timer.Stop();
            this.timer = null;
        }

        private void updateScore(int noviScore, Color boja){
            this.Score = noviScore;
            scoreLabel.Show();
            scoreLabel.Text = "Score : " + Score.ToString() + " ";
            scoreLabel.ForeColor = boja;
            generisiTimer();
        }

        internal void resizeEvent(object sender, EventArgs e)
        {
            if (this.canvas != null)
            {
                canvas.Size = new Size(lobbyForm.Width - 35, lobbyForm.Height - 80);
                scoreLabel.Location = new Point(lobbyForm.Width - lobbyForm.Width / 3, lobbyForm.Height - 72);
                naslov.Location = new Point(lobbyForm.Width / 6, lobbyForm.Height - 72);
                canvas.Invalidate();
            }
        }

        public void krajIgre() {
            MessageBox.Show("Kraj igre");
            this.lobbyForm.Controls.Clear();
        }
    }
}
