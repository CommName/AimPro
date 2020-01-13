using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.Controllers
{
    public class LobbyController
    {
        LobbyForm lobbyForm;
        List<string> trenutniUseri = new List<string>();
        public LobbyController(LobbyForm lf) {
            this.lobbyForm = lf;
        }
        public void preuzmiLobbyUsere(List<string> lobbyUsers) {
            this.trenutniUseri = lobbyUsers;
            this.lobbyForm.osveziPrikazUsera(trenutniUseri);
        }
    }
}
