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
        AIMProServerServiceClient proxy;
        MenuForm menuForm;
        Form1 form1;
        public MenuController(AIMProServerServiceClient proxy, MenuForm mf, Form1 form1) {
            this.proxy = proxy;
            this.menuForm = mf;
            this.form1 = form1;
        }
    }
}
