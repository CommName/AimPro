using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;
using System.ServiceModel;

namespace AIMProClient
{
    public class CommunicationLayer
    {
        AIMProServerServiceClient proxy;
        
        protected static CommunicationLayer instance = null;

        public static CommunicationLayer Instance {
            get { if (instance == null) instance = new CommunicationLayer(); return instance; }
        }

        protected CommunicationLayer() {
             InstanceContext instanceContext = new InstanceContext(new CallBackPlayer());
             proxy = new AIMProServerServiceClient(instanceContext);
           // proxy = new AIMProServerServiceClient();
        }

        public bool login(string username, byte[] password) {
            if (proxy.login(username, password))
                return true;
            else
                return false;
        }

        public bool signUp(string username, byte[] password) {
            if (proxy.signUp(username, password))
                return true;
            else
                return false;
        }

        public User getUser(string username) {
            return proxy.getProfile(username);
        }

        public void CreateRoom(RoomProperties prop)
        {
            proxy.createRoom(prop);
        }

        public List<RoomState> GetRooms()
        {
            return proxy.GetRooms();
        }
        public List<Profile> getUsers()
        {
            return proxy.getProfiles();
        }

        public void submitHit(int x, int y)
        {
            proxy.submitHit(x, y);
        }

        public bool authenticatePrivateRoom(string password, RoomState roomState) {//IMPLEMENT
            return true;
        }

        public Profile getProfileStatistics(string username)
        {
            return proxy.getProfileStatistics(username);
        }

        public List<MatchStatistics> getUserMatchHistory(string username)
        {
            return proxy.getProfileMatchHistory(username);
        }

        public void Logout()
        {
            this.proxy.logout();
        }

        public void leaveLobby()
        {
            this.proxy.leaveRoom();
        }

        public void userReady()
        {
            this.proxy.startGame();
        }

        public void joinRoom(int idSobe)
        {
            this.proxy.joinRoom(idSobe);
        }

    }
}
