using System;

namespace Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            Account k = new Account("Jan Kowalski", "37562", "mała", "czarna");
            k.Zaloguj("mała", "czarna");
            Console.WriteLine(k);
            k.LogOut();
            k.ChangePassword("awf");
            k.SprawdzSaldo();
            k.Zaloguj("mała", "czarna");
            k.SprawdzSaldo();
            k.ChangePassword("acc");
            k.Wplac(50);
            k.LogOut();
            Console.WriteLine(k);
            k.Wyplac(120);
            Console.WriteLine(k);
            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}