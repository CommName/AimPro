using AIMProClient.AIMProService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.Controllers
{
   public class MenuController
    {
        MenuForm menuForm;
        User logovaniKorisnik;
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
            CreateRoomForm crf = new CreateRoomForm();
            crf.ShowDialog();
        }

        public void udjiUSobu()
        {

        }

        public void generisiStatistiku()
        {



            List<User> users = CommunicationLayer.Instance.getUsers();

            StatisticsForm sf = new StatisticsForm(this, users);

            sf.ShowDialog();
        }


    }
}
