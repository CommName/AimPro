using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;

namespace AIMProClient
{
    public class CommunicationLayer
    {
        public AIMProServerServiceClient proxy;
        public Form1 mainForm;
        protected static CommunicationLayer instance = null;

        public static CommunicationLayer Instance {
            get { if (instance == null) instance = new CommunicationLayer(); return instance;  }
        }
  
        protected CommunicationLayer() {
            proxy = new AIMProServerServiceClient();
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

        public List<User> getUsers()
        {
            return proxy.getProfiles();
        }

    }
}
