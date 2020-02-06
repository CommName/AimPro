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

        internal void leaveLobby(bool leaving)
        {
            CommunicationLayer.Instance.leaveLobby();
            getRooms();
            FormLayer.Instance.joinRoomForm.RefreshTable(ListaMogucihSoba);
        }

        internal void leaveLobbyAndGame() {
            CommunicationLayer.Instance.leaveLobby();
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

        public User getUser
        {
            get { return this.logovaniKorisnik; }
        }

        internal List<MatchStatistics> getUserMatchHistory(string username)
        {
           return CommunicationLayer.Instance.getUserMatchHistory(username);
        }

        internal Profile getProfile(string username)
        {
            return CommunicationLayer.Instance.getProfileStatistics(username);
        }


        public MenuController(MenuForm mf, User logovaniKorisnik) {
            this.menuForm = mf;
            this.logovaniKorisnik = logovaniKorisnik;
            initFormLayer();
        }

        public void initFormLayer()
        {
            FormLayer.Instance.joinRoomForm = new JoinRoomForm(this);
            FormLayer.Instance.createRoomForm = new CreateRoomForm(this);
            FormLayer.Instance.lobbyForm = new LobbyForm(this, null);
            FormLayer.Instance.statistics =  new StatisticsForm(this, null); ;
        }

        public void otvoriProfil()
        {
            Profile pomProfile = getProfile(this.logovaniKorisnik.Username);
            List<MatchStatistics> pomListMatchHistory = getUserMatchHistory(this.logovaniKorisnik.Username);
            ProfileForm pf = new ProfileForm(pomProfile, pomListMatchHistory);
            pf.ShowDialog();
        }

        public void napraviSobu()
        {
            FormLayer.Instance.setCreateRoomView();
        }

        public void udjiUSobu()
        {
            FormLayer.Instance.setJoinRoomView();
        }

        public List<RoomState> getRooms() {
            this.listaMogucihSoba= CommunicationLayer.Instance.GetRooms();
            return this.listaMogucihSoba;
        }

        public void generisiStatistiku()
        {
            List<Profile> users = CommunicationLayer.Instance.getUsers();

            FormLayer.Instance.setStatisticsView(users);
        }

        public void pokreniLobby(int i) {
            if ((listaMogucihSoba[i].RoomSettings & RoomSettings.PasswordProtected) != 0){//private room
                PrivateCodeForm pcf = new PrivateCodeForm(this,i);
                pcf.ShowDialog();
            }
            else //public room
            {
                CommunicationLayer.Instance.joinRoom(listaMogucihSoba[i].ID);
                udjiULobby(i);
                
            }
        }

        public bool authPassword(string pass, RoomState roomState) {
            return CommunicationLayer.Instance.authenticatePrivateRoom(pass,roomState);
        }

        public void udjiULobby (int i) {

            showLobyRoom();
        }

        public bool validirajKreiranjeSobe(string sobaName,string sobaCode) {
            if (PublicSoba == true && sobaName != "" && sobaName.Length>3 && TipIgre!=0)
            {
                RoomProperties room = new RoomProperties
                {
                    maxPlayers = 4,
                    GameMode = (GameMode)TipIgre,
                    TargetTypesAllowed = vratiTipMete(),
                    CursorType = vratiTipMunicije(),
                    Settings = vratiTipSobe(),
                    Name = sobaName,
                    Password = sobaCode,
                    
                };
                CommunicationLayer.Instance.CreateRoom(room);
                FormLayer.Instance.createRoomForm.deSelectAll();
                TipMete = 0;
                TipIgre = 2;
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enterLobbyRoomFromCreate();
                return true;
            }
            else if (PublicSoba == false && sobaName != "" && sobaName.Length > 3 && sobaCode != "" && sobaCode.Length>3 && TipIgre != 0)
            {
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
                FormLayer.Instance.createRoomForm.deSelectAll();
                TipMete = 0;
                TipIgre = 2;
                CommunicationLayer.Instance.CreateRoom(room);
                MessageBox.Show("Room created Successfully!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enterLobbyRoomFromCreate();
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

        public void logout() 
        {
            CommunicationLayer.Instance.Logout();//obavesti server o logoutu , ta metoda nije implementovana
            menuForm.exitApp = false;
            menuForm.Close();
            FormLayer.Instance.menuForm = null;
            LoginForm lf = new LoginForm();
            FormLayer.Instance.loginForm = lf;
            lf.Show();
        }
        private void enterLobbyRoomFromCreate()
        {
            //FormLayer.Instance.menuForm.Close();
            showLobyRoom();
        }

        public void showLobyRoom()
        {
            FormLayer.Instance.menuForm.Hide();
            FormLayer.Instance.lobbyForm.regularView();
            FormLayer.Instance.lobbyForm.ShowDialog();
            FormLayer.Instance.menuForm.Show();
        }
    }
}
