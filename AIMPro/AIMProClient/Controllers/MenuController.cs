using AIMProClient.AIMProService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.Controllers
{
    class MenuController
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
            StatisticsForm sf = new StatisticsForm();
            sf.ShowDialog();
        }
    }
}
