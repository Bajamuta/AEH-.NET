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
            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}