using System;

namespace Konto
{
    class Account
    {
        private String user;
        private String number;
        private String login;
        private String password;
        private bool logged; //na wstępie zawsze false
        private double saldo = 0;

        public Account(String user, String num, String log, String pass)
        {
            this.user = user; number = num; password = pass;
            login = log;
        }

        public void Zaloguj(String log, String pass)
        {
            if ((login == log) && (password == pass)) { logged = true; }
        }

        public override String ToString()
        {
            return "\nUżytkownik konta " + user + " o numerze " + number +
                   " posiada na koncie " + saldo;
        }
    }
}