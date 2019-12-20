using AIMProClient.AIMProService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMProClient.Controllers
{
    public class MenuController
    {
        MenuForm menuForm;
        User logovaniKorisnik;
        int tipIgre = 0;
        int tipMete = 0;
        int tipMunicije = 0;
        bool publicSoba = false;
        public int TipIgre {
            get {return this.tipIgre; }
            set {this.tipIgre=value; }
        }
        public int TipMete
        {
            get { return this.tipMete; }
            set { this.tipMete = value; }
        }
        public int TipMunicije
        {
            get { return this.tipMunicije; }
            set { this.tipMunicije = value; }
        }
        public bool PublicSoba {
            get { return this.publicSoba; }
            set { this.publicSoba = value; }
        }
    
        public MenuController(MenuForm mf, User logovaniKorisnik) {
            this.menuForm = mf;
            this.logovaniKorisnik = logovaniKorisnik;
        }

        public void otvoriProfil()
        {
            ProfileForm pf = new ProfileForm(this.logovaniKorisnik);
            pf.ShowDialog();
        }

        public void napraviSobu()
        {
            CreateRoomForm crf = new CreateRoomForm(this);
            crf.ShowDialog();
        }

        public void udjiUSobu()
        {
            JoinRoomForm jrf = new JoinRoomForm(this);
            jrf.ShowDialog();
        }

        public void generisiStatistiku()
        {



            List<User> users = CommunicationLayer.Instance.getUsers();

            StatisticsForm sf = new StatisticsForm(this, users);

            sf.ShowDialog();
        }

        public void validirajKreiranjeSobe(string sobaName,string sobaCode) {
            MessageBox.Show("Igra"+TipIgre.ToString());
            MessageBox.Show("MEta"+TipMete.ToString());
            MessageBox.Show("Municija"+TipMunicije.ToString());
            if (PublicSoba == true && sobaName != "" && sobaName.Length>3 && TipIgre!=0)
            {
                MessageBox.Show("Kreira javnu sobu" + sobaName);
                RoomProperties room = new RoomProperties
                {
                    maxPlayers = 4,
                    GameMode = (GameMode)TipIgre,
                    TargetTypesAllowed = (TargetTypes)TipMete,
                    CursorType = (CursorType)TipMunicije,
                    Settings = (RoomSettings)vratiTipSobe(),
                    Name = sobaName,
                    Password = sobaCode
                };
                CommunicationLayer.Instance.CreateRoom(room);
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (PublicSoba == false && sobaName != "" && sobaName.Length > 3 && sobaCode != "" && sobaCode.Length>3 && TipIgre != 0)
            {
                MessageBox.Show("Kreira privatnu sobu" + sobaName + " code : " + sobaCode);
                RoomProperties room = new RoomProperties
                {
                    maxPlayers = 4,
                    GameMode = (GameMode)TipIgre,
                    TargetTypesAllowed=(TargetTypes)TipMete,
                    CursorType=(CursorType)TipMunicije,
                    Settings = vratiTipSobe(),
                    Name=sobaName,
                    Password=sobaCode
                };
                CommunicationLayer.Instance.CreateRoom(room);
                //TOODO join room and change view
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private RoomSettings vratiTipSobe() {
            if (this.PublicSoba == true)
                return RoomSettings.None;
            else
                return RoomSettings.PasswordProtected;
        }
    }
}
