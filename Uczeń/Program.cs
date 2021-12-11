using System;

namespace Uczeń
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Uczeń A = new Uczeń(4, 5, "Kowalski");
                Console.WriteLine(A);
                double wynik = A.średnia();
                Console.WriteLine(wynik);
            } while (Console.ReadLine() = "tak");
        }
    }
}
