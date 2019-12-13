using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;

namespace AIMProClient
{
    class LoginController
    {
        AIMProServerServiceClient proxy;
        bool mask = false;
        Form1 form1;
        public string errorMessage = "";
        public LoginController(AIMProServerServiceClient proxy,Form1 form1) {
            this.proxy = proxy;
            this.form1 = form1;
        }

        public char setMask()
        {
            char c;
            if (mask)
                c = '\0';
            else
                c = '*';
            mask = !mask;
            return c;
        }

        public bool login(string username, string password) {
            if (username.Length > 2 && password.Length > 2)
            {
                if (proxy.login(username, Encoding.ASCII.GetBytes(password)))
                {
                    MenuForm mf = new MenuForm(proxy, form1);
                    mf.Show();
                    return true;
                }   
                else
                {
                    errorMessage = "There is no such Username/Password combination.";
                    return false;
                }
            }
            else
            {
                errorMessage = "Input data is invalid.";
                return false;
            }
        }
    }
}
