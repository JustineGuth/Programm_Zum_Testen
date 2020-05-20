using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Mitarbeit_Personal_Testen
{
    public class UserLogin
    {
        public string Login(string userName, string passwort)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passwort))
            {
                return "Name oder Passwort darf nicht leer sein";
            }
            else
            {
                if (userName == "admin" && passwort == "admin")
                {
                    return "Willkommen";
                }
                return "Name oder Passwort kann nicht gefunden werden";
            }

        }
    }
}
