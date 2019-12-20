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
        CreateRoomForm createRoomForm;
        List<RoomState> listaMogucihSoba = new List<RoomState>();
        int tipIgre = 0;
        int tipMete = 0;
        int tipMunicije = 0;
        bool publicSoba = false;
        public List<RoomState> ListaMogucihSoba
        {
            get { return this.listaMogucihSoba; }
        }
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

        public void setCreateRoom(CreateRoomForm crf) {
            this.createRoomForm = crf;
        }

        public List<RoomState> getRooms() {
            this.listaMogucihSoba= CommunicationLayer.Instance.GetRooms();
            return this.listaMogucihSoba;
        }

        public void generisiStatistiku()
        {



            List<User> users = CommunicationLayer.Instance.getUsers();

            StatisticsForm sf = new StatisticsForm(this, users);

            sf.ShowDialog();
        }

        public void pokreniLobby(int i) {
            if ((listaMogucihSoba[i].RoomSettings & RoomSettings.PasswordProtected) != 0){//private room
                PrivateCodeForm pcf = new PrivateCodeForm(this,i);
                pcf.ShowDialog();
            }
            else {//public room
                udjiULobby(i);
            }
            
        }

        public bool authPassword(string pass, RoomState roomState) {
            return CommunicationLayer.Instance.authenticatePrivateRoom(pass,roomState);
        }

        public void udjiULobby (int i) {
            LobbyForm lf = new LobbyForm(this, listaMogucihSoba[i]);
            lf.ShowDialog();
        }

        public bool validirajKreiranjeSobe(string sobaName,string sobaCode) {
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
                    TargetTypesAllowed = vratiTipMete(),
                    CursorType = vratiTipMunicije(),
                    Settings = vratiTipSobe(),
                    Name = sobaName,
                    Password = sobaCode
                };
                CommunicationLayer.Instance.CreateRoom(room);
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////createRoomForm.Close();
               // udjiUSobu();
                return true;
            }
            else if (PublicSoba == false && sobaName != "" && sobaName.Length > 3 && sobaCode != "" && sobaCode.Length>3 && TipIgre != 0)
            {
                MessageBox.Show("Kreira privatnu sobu" + sobaName + " code : " + sobaCode);
                RoomProperties room = new RoomProperties
                {
                    maxPlayers = 4,
                    GameMode = (GameMode)TipIgre,
                    TargetTypesAllowed=vratiTipMete(),
                    CursorType=vratiTipMunicije(),
                    Settings = vratiTipSobe(),
                    Name=sobaName,
                    Password=sobaCode
                };
                CommunicationLayer.Instance.CreateRoom(room);
                //TOODO join room and change view
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //createRoomForm.Close();
                //udjiUSobu();
                return true;
            }
            else {
                MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private RoomSettings vratiTipSobe() {
            if (this.PublicSoba == true)
                return RoomSettings.None;
            else
                return RoomSettings.PasswordProtected;
        }
        private TargetTypes vratiTipMete() {
            TargetTypes meta = TargetTypes.None;
            if (TipMete >= 16)
            {
                meta = meta | TargetTypes.Child;
                TipMete -= 16;
            }
            if (TipMete >= 8)
            {
                meta = meta | TargetTypes.Negative;
                TipMete -= 8;
            }
            if (TipMete >= 4)
            {
                meta = meta | TargetTypes.Boost;
                TipMete -= 4;
            }
            if (TipMete >= 2)
            {
                meta = meta | TargetTypes.Shielded;
                TipMete -= 2;
            }
            if (TipMete >= 1)
            {
                meta = meta | TargetTypes.Moving;
                TipMete -= 1;
            }
            return meta;
        }
        private CursorType vratiTipMunicije() {
            CursorType municija = CursorType.None;
            if (TipMunicije >= 16)
            {
                municija = municija | CursorType.Bazooka;
                TipMunicije -= 16;
            }
            if (TipMunicije >= 8)
            {
                municija = municija | CursorType.Drunk;
                TipMunicije -= 8;
            }
            if (TipMunicije >= 4)
            {
                municija = municija | CursorType.Limited;
                TipMunicije -= 4;
            }
            if (TipMunicije >= 2)
            {
                municija = municija | CursorType.Explosive;
                TipMunicije -= 2;
            }
            if (TipMunicije >= 1)
            {
                municija = municija | CursorType.Piercing;
                TipMunicije -= 1;
            }
            return municija;
        }
    }
}
