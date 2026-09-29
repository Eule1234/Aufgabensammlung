using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe9_EineGanzzahlBinärDarstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = " ";
            Console.WriteLine("Enter 'q' to exit or c to continiue");
            
                Console.Write("Gib eine Ganzzahl ein, welche du in binär umwandeln möchtest: ");
                string input = Console.ReadLine();

            while (input != "q")
            {
                bin = " ";
                if ((int.TryParse(input, out int number)) && number > 0)
                {

                    while (number != 0)
                    {
                        int rest = number % 2;
                        bin = rest + bin;
                        int wert = number / 2;
                        number = wert;
                    }

                    Console.WriteLine($"Die binäre Darstellung von {input} ist {bin}");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Es wird eine positive Ganzzahl erwartet.");
                }
                Console.Write("Weitermachen? Gib eine Ganzzahl ein, welche du in binär umwandeln möchtest (or q to quit): ");
                input = Console.ReadLine();

                if (input == "q" || input == "Q")
                {
                    break;
                }
            }
        }
    }
}
