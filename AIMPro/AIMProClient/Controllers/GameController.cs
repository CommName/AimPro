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

namespace AIMProClient.Controllers
{
    public class GameController
    {
        LobbyForm lobbyForm;
        public PictureBox canvas;
        int cursorX = 0;
        int cursorY = 0;
        ICursorDrawing nisan = null;
        ITargetDrawing crtacMeta = null;
        Color bojaNisana;

        public List<Target> targets;

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
            lobbyForm.WindowState = FormWindowState.Maximized;
            lobbyForm.Location = new Point(0, 0);
        }

        public void loadGameControlls() {
            generateCanvas();
            generateNaslov();
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
            MessageBox.Show(string.Format("X: {0} Y: {1}", cursorX, cursorY)+ "First target is at: "+targets.First().x.ToString() +" "+targets.First().y.ToString());
            double pomx= 1000.0 / canvas.Width;
            double pomy = 1000.0 / canvas.Height;
            int toSendX =(int) (cursorX * pomx);
            int toSendY = (int)(cursorY * pomy);
            CommunicationLayer.Instance.submitHit(toSendX, toSendY);
            // CommunicationLayer.Instance.submitHit(cursorX, cursorY);
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
            gameCanvas.Location = new Point(30, 40);
            gameCanvas.Size = new Size(lobbyForm.Width - 80, lobbyForm.Height - 120);
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
            naslov.Location = new Point(lobbyForm.Width / 2, 5);
            lobbyForm.Controls.Add(naslov);
        }
    }
}
