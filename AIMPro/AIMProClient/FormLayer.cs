using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient
{
    public class FormLayer
    {
        public Form1 mainForm;
        public MenuForm menuForm;
        public CreateRoomForm createRoomForm;
        public JoinRoomForm joinRoomForm;
        public LobbyForm lobbyForm;
        public LoginForm loginForm;
        protected static FormLayer instance = null;
        public static FormLayer Instance
        {
            get { if (instance == null) instance = new FormLayer(); return instance; }
        }

        protected FormLayer()
        {

        }

        public void setJoinRoomView()
        {
            menuForm.setSubView(joinRoomForm);
        }


    }
}
