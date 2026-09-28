using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1_Addierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl ein: ");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.Write("Super, gib eine zweite Zahl ein: ");
            int zahl2 = int.Parse(Console.ReadLine());

            int ergebnis = zahl1 + zahl2;
            Console.WriteLine($"Summe: {ergebnis}");
        }
    }
}
