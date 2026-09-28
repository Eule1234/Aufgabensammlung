using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2_AnzahlSekundenEinesMonats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen? ");

            string input = Console.ReadLine();
            int value;

            if (int.TryParse(input, out value) && value <= 31 && value >= 28) 
            {
                int sekInOneDay = 86400;
                int result = value * sekInOneDay;

                Console.WriteLine($"Ein Monat mit {value} Tagen hat {result} Sekunden");

            } else
            {
                Console.WriteLine("Ungültige Eingabe. Ganzzahl zwischen 28 und 31 erwartet");
            }
        }
    }
}
