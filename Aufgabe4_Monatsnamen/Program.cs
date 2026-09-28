using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4_Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "", "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November" };

            Console.WriteLine("Den wie vielten Monat möchtest du sehen?");
            Console.Write("Zahl eingeben: ");

            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number) && number <= 12 && number >= 1)
            {
                string showMonth = months[number];

                Console.WriteLine(showMonth);
            }
            else
            {
                Console.WriteLine("Ungültigie Eingabe. Es wird eine Ganzzahl zwischen 1 und 12 erwartet!");
            }
        }
    }
}
