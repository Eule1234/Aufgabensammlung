using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe10_QuersummeBerechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = BerechneQuersumme();
            Console.WriteLine($"Die Quersumme ist {sum}");

        }

        static int BerechneQuersumme()
        {
            Console.Write("Von welcher Zahl möchtest du die Quersumme berechnen? ");
            string input = Console.ReadLine();

            int zahl;
            int sum = 0;

            if (int.TryParse(input, out zahl))

            {
                if (zahl == 0)
                {
                    return sum;
                }

                while (zahl != 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }
                return sum;

            }
            else
            {
                return 0;
            }
        }
    }
}
