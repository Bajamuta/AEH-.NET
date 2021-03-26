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
            if ((login == log) && (password == pass))
            {
                logged = true;
                Console.WriteLine("Zalogowano.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowe dane.");
            }
        }

        public override String ToString()
        {
            return "\nUżytkownik konta " + user + " o numerze " + number +
                   " posiada na koncie " + saldo;
        }
        
        public void LogOut()
        {
            if (logged)
            {
                logged = false;
            }
        }

        public void ChangePassword(String newPassword)
        {
            if (logged && (newPassword != password))
            {
                password = newPassword;
                Console.WriteLine($"Nowe hasło: {password}");
                
            }
            else if (logged && newPassword == password)
            {
                Console.WriteLine("To hasło już było użyte.");
            }
            else
            {
                Console.WriteLine("Należy być zalogowanym, aby zmienić hasło!");
            }
        }

        public void Wplac(double kwota)
        {
            saldo += kwota;
        }

        public void Wyplac(double kwota)
        {
            saldo -= kwota;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public bool getLogged()
        {
            return logged;
        }

        public void SprawdzSaldo()
        {
            if (logged)
            {
                Console.WriteLine($"Stan konta wynosi: {getSaldo()}");
            }
            else
            {
                Console.WriteLine("Należy być zalogowanym, aby sprawdzić saldo.");
            }
        }
    }
}