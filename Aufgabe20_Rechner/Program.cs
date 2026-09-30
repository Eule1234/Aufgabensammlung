using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe20_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Write("Geben Sie Ihre Rechnung ein: ");
                string input = Console.ReadLine();

                // Eingabe in einzelne Bestandteile aufteilen
                string[] teile = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Zahlen und Operator bestimmen
                if (teile.Length == 3 &&
                    double.TryParse(teile[0], out double zahl1) &&
                    double.TryParse(teile[2], out double zahl2))
                {
                    double ergebnis = 0;

                    switch (teile[1])
                    {
                        case "+":
                            ergebnis = zahl1 + zahl2;
                            break;

                        case "-":
                            ergebnis = zahl1 - zahl2;
                            break;

                        case "*":
                            ergebnis = zahl1 * zahl2;
                            break;

                        case "/":
                            if (zahl2 == 0)
                            {
                                Console.WriteLine("Division durch 0 ist nicht erlaubt!");
                                return;
                            }

                            ergebnis = zahl1 / zahl2;
                            break;

                        default:
                            Console.WriteLine("Ungültiger Operator!");
                            return;
                    }

                    Console.WriteLine($"Ergebnis: {ergebnis}");
                    Console.Write("Möchtest du weitermachen? (y/n)");
                    string input2 = Console.ReadLine();

                    if (input2 == "y" || input2 == "Y")
                    {
                        quit = false;
                    } else { break;}
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
            }
        }
    }
}
