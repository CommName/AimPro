using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;

namespace AIMProClient
{
    public class LoginController
    {
        public bool mask = false;
        public string errorMessage = "";
        public LoginController() {

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
                if (CommunicationLayer.Instance.login(username, Encoding.ASCII.GetBytes(password)))
                {
                    openMenuForm(username);
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
        public bool signUp(string username, string password)
        {
            if (username.Length > 2 && password.Length > 2)
            {
                if (CommunicationLayer.Instance.signUp(username, Encoding.ASCII.GetBytes(password)))
                    return true;
                else
                {
                    errorMessage = "That Username/Password combination is already taken.";
                    return false;
                }
            }
            else
            {
                errorMessage = "Input data is invalid.";
                return false;
            }
        }
        public void openMenuForm(string username) 
        {
            FormLayer.Instance.loginForm.flag = true;
            FormLayer.Instance.loginForm.Close();
            User logovaniKorisnik = CommunicationLayer.Instance.getUser(username);
            MenuForm mf = new MenuForm(logovaniKorisnik);
            FormLayer.Instance.menuForm = mf;
            mf.Show();
        }
    }
}
