﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;

namespace AIMProClient.Controllers
{
    public class LobbyController
    {
        LobbyForm lobbyForm;
        public List<Shooter> trenutniUseri = new List<Shooter>();
        public LobbyController(LobbyForm lf) {
            this.lobbyForm = lf;
        }
        public void preuzmiLobbyUsere(List<Shooter> lobbyUsers) {
            this.trenutniUseri = lobbyUsers;
            this.lobbyForm.refreshUsers(trenutniUseri);
        }

        internal void userReady()
        {
            CommunicationLayer.Instance.userReady();
        }

        public string kastujEnum(int tipIgre)
        {
            if (tipIgre == 1)
                return "Duel";
            else if (tipIgre == 2)
                return "MultiPlayer FFA";
            else if (tipIgre == 4)
                return "Fast Shooting";
            else if (tipIgre == 8)
                return "Precise Shooting";
            else
                return "Endless Campaign";
        }
    }
}
